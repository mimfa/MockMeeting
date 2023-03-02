using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MiMFa_MockMeeting
{
    public partial class Home : Form
    {
        XmlDocument MainXML = new XmlDocument();
        bool LoadMode = false;
        public Home()
        {
            InitializeComponent();
            NewMock(null,EventArgs.Empty);
        }


        private DialogResult Answer(string message = "")
        {
            return MessageBox.Show(message, "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }
        private void Log(string message = "")
        {
            l_Message.Text = message;
            l_Message.ForeColor = Color.WhiteSmoke;
        }
        private void SLog(string success)
        {
            l_Message.Text = success;
            l_Message.ForeColor = Color.LightGreen;
        }
        private void Log(Exception ex)
        {
            l_Message.Text = ex.Message;
            l_Message.ForeColor = Color.PaleVioletRed;
        }

        private void NewMock(object sender, EventArgs e)
        {
            if (dgv_Titles.Rows.Count < 2 || Answer("Are you sure that you want to change current project with an empty project?") == DialogResult.Yes)
            {
                try
                {
                    API.FileAddress = null;
                    MainXML = new XmlDocument();
                    XmlNode body = MainXML.CreateNode(XmlNodeType.Element, "BODY", "");
                    XmlNode Sets = MainXML.CreateNode(XmlNodeType.Element, "SETS", "");
                    XmlNode items = MainXML.CreateNode(XmlNodeType.Element, "ITEMS", "");
                    body.AppendChild(Sets);
                    body.AppendChild(items);
                    MainXML.AppendChild(body);
                    tsmb_EditMode.Checked = true;
                    Clear();
                    SLog("New Mock file created successful!");
                }
                catch (Exception ex) { Log(ex); }
            }
        }
        private void LoadMock(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
                try
                {
                    SLog(API.FileAddress = OFD.FileName);
                    Load();
                }
                catch (Exception ex) { Log(ex); }
        }
        private void SaveMock(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(API.FileAddress)) SaveAsMock(sender, e);
            else try
                {
                    XmlNode node = MainXML.CreateNode(XmlNodeType.Element, "SETS", "");
                    node.AppendChild(NewSet("SHOWTITLES", titleBarToolStripMenuItem.Checked+""));
                    node.AppendChild(NewSet("SHOWDETAIL", tsmi_Panel.Checked+""));
                    node.AppendChild(NewSet("FONTSIZE", rtb_Main.Font.Size + ""));
                    node.AppendChild(NewSet("TOPMOST", tsmi_TopM.Checked + ""));
                    node.AppendChild(NewSet("EDITMODE", tsmb_EditMode.Checked+""));
                    node.AppendChild(NewSet("WRAPMODE", tsmb_WrapMode.Checked+""));
                    node.AppendChild(NewSet("TRANSPARENT", cb_Transparent.Checked+""));
                    node.AppendChild(NewSet("CONTENTZOOM", rtb_Main.ZoomFactor+""));
                    node.AppendChild(NewSet("BACKLIGHT",cb_BackLight.Checked+""));
                    node.AppendChild(NewSet("FORECOLOR",l_ForeColor.ForeColor.ToArgb()+""));
                    node.AppendChild(NewSet("BACKCOLOR", l_BackColor.BackColor.ToArgb()+""));
                    MainXML.LastChild.RemoveChild(MainXML.LastChild.FirstChild);
                    MainXML.LastChild.PrependChild(node);
                    MainXML.Save(API.FileAddress);
                    SLog("Saved successful in '"+ API.FileAddress + "'!");
                }
                catch (Exception ex) { Log(ex); }
        }
        private void SaveAsMock(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(API.FileAddress = SFD.FileName)) SaveMock(sender, e);
        }

        private void Clear()
        {
            LoadMode = true;
            dgv_Titles.Rows.Clear();
            tb_Title.Text = rtb_Main.Text = "";
            LoadMode = false;
        }
        private new void Load()
        {
            try
            {
                if (!File.Exists(API.FileAddress)) return;
                Clear();
                LoadMode = true;
                MainXML.Load(API.FileAddress);
                foreach (XmlNode item in MainXML.GetElementsByTagName("SET"))
                    try
                    {
                        switch (item.Attributes["NAME"].Value)
                        {
                            case "TRANSPARENT":
                                cb_Transparent.Checked = Convert.ToBoolean(item.Attributes["VALUE"].Value ?? "False");
                                break;
                            case "BACKLIGHT":
                                cb_BackLight.Checked = Convert.ToBoolean(item.Attributes["VALUE"].Value ?? "False");
                                break;
                            case "FORECOLOR":
                                l_ForeColor.ForeColor = Color.FromArgb(Convert.ToInt32(item.Attributes["VALUE"].Value));
                                break;
                            case "BACKCOLOR":
                                l_BackColor.BackColor = Color.FromArgb(Convert.ToInt32(item.Attributes["VALUE"].Value));
                                break;
                            case "TOPMOST":
                                tsmi_TopM.Checked = Convert.ToBoolean(item.Attributes["VALUE"].Value ?? "False");
                                break;
                            case "ZOOM":
                            case "FONTSIZE":
                                rtb_Main.Font = new Font(rtb_Main.Font.FontFamily, Convert.ToSingle(item.Attributes["VALUE"].Value ?? "9"), rtb_Main.Font.Style);
                                SetFonts();
                                break;
                            case "EDITMODE":
                                tsmb_EditMode.Checked = Convert.ToBoolean(item.Attributes["VALUE"].Value ?? "False");
                                break;
                            case "WRAPMODE":
                                tsmb_WrapMode.Checked = Convert.ToBoolean(item.Attributes["VALUE"].Value ?? "False");
                                break;
                            case "SHOWTITLES":
                                titleBarToolStripMenuItem.Checked = Convert.ToBoolean(item.Attributes["VALUE"].Value ?? "True");
                                break;
                            case "SHOWDETAIL":
                                tsmi_Panel.Checked = Convert.ToBoolean(item.Attributes["VALUE"].Value ?? "True");
                                break;
                            case "CONTENTZOOM":
                                rtb_Main.ZoomFactor = Convert.ToSingle(item.Attributes["VALUE"].Value ?? "1");
                                break;
                        }
                    }
                    catch { }
                foreach (XmlNode item in MainXML.GetElementsByTagName("ITEM"))
                    AddItem(item);
                SLog("Load successful from '" + API.FileAddress + "'!");
            }
            catch (Exception ex) { Log(ex); }
            finally
            {
                LoadMode = false;
            }
        }
        private void SaveItem(XmlNode node)
        {
            try
            {
                if (node == null) return;
                XmlNode oldnode = GetItem(node.Attributes["ID"].Value);
                if (oldnode == null) MainXML.LastChild.LastChild.AppendChild(node);
                else MainXML.LastChild.LastChild.ReplaceChild(node, oldnode);
            }
            catch (Exception ex) { Log(ex); }
        }
        private void SaveItem(string id, string title, string text, string key)
        {
            SaveItem(NewItem(id,title,text,key));
        }
        private void AddItem(XmlNode node)
        {
            if (node == null) return;
            AddItem(node.Attributes["ID"].Value, node.Attributes["TITLE"].Value, node.Attributes["KEY"].Value);
        }
        private void AddItem(string id, string title, string key)
        {
            dgv_Titles.Rows.Add(id, title, key);
        }
        private void RemoveItem(XmlNode node)
        {
            if (node == null) return;
            MainXML.LastChild.LastChild.RemoveChild(node);
        }
        private void RemoveItem(string id)
        {
            RemoveItem(GetItem(id));
        }
        private void ShowItem(string id = "", string title = "", string text = "", string key = "")
        {
            if (btn_Reset.Visible) SaveItem(rtb_Main.Tag + "", tb_Title.Text, rtb_Main.Text, tb_Title.Tag + "");
            LoadMode = true;
            tb_Title.Text = title;
            tb_Title.Tag = key;
            rtb_Main.Text = text;
            rtb_Main.Tag = id;
            btn_Reset.Visible = false;
            LoadMode = false;
        }
        private void ShowItem(XmlNode node)
        {
            if (btn_Reset.Visible) SaveItem(rtb_Main.Tag + "", tb_Title.Text, rtb_Main.Text, tb_Title.Tag + "");
            try
            {
                if (node == null) return;
                ShowItem(
                    node.Attributes["ID"].Value+"",
                    node.Attributes["TITLE"].Value,
                    string.IsNullOrEmpty(node.InnerText) ?" ":node.InnerText,
                    node.Attributes["KEY"].Value);
            }
            catch { }
            finally { LoadMode = false; }
        }
        private void ShowItem(string id)
        {
            ShowItem(GetItem(id));
        }
        private XmlNode NewSet(string name, string value)
        {
            XmlNode node = MainXML.CreateNode(XmlNodeType.Element, "SET","");
            node.Attributes.Append(MainXML.CreateAttribute("NAME"));
            node.Attributes.Append(MainXML.CreateAttribute("VALUE"));
            node.Attributes["NAME"].Value = name;
            node.Attributes["VALUE"].Value = value;
            return node;
        }
        private XmlNode NewItem(string id, string title, string text, string key)
        {
            XmlNode node = MainXML.CreateNode(XmlNodeType.Element, "ITEM","");
            node.Attributes.Append(MainXML.CreateAttribute("ID"));
            node.Attributes.Append(MainXML.CreateAttribute("TITLE"));
            node.Attributes.Append(MainXML.CreateAttribute("KEY"));
            node.Attributes["ID"].Value = id;
            node.Attributes["TITLE"].Value = title;
            node.Attributes["KEY"].Value = key;
            node.InnerText = text;
            return node;
        }
        private XmlNode GetItem(string id)
        {
            Log("");
            foreach (XmlNode item in MainXML.LastChild.LastChild.ChildNodes)
                if (item.Attributes["ID"].Value == id) return item;
            return null;
        }
        private void SetFonts()
        {
            tb_Title.Font = new Font(tb_Title.Font.FontFamily, rtb_Main.Font.Size, tb_Title.Font.Style);
            dgv_Titles.DefaultCellStyle.Font = new Font(dgv_Titles.DefaultCellStyle.Font.FontFamily, rtb_Main.Font.Size - 2, dgv_Titles.DefaultCellStyle.Font.Style);
            p_List.Width = Convert.ToInt32(230 + (8 * (rtb_Main.Font.Size - 9)));
        }

        private void dgv_Titles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (LoadMode) return;
            if (btn_Reset.Visible) SaveItem(rtb_Main.Tag + "", tb_Title.Text, rtb_Main.Text, tb_Title.Tag + "");
            ShowItem();
            try
            {
                int index = e.RowIndex-1;
                ShowItem(NewItem(
                    (dgv_Titles.Rows[index].Cells[dgv_Titles_ID.Name].Value = DateTime.Now.Ticks)+"",
                    dgv_Titles.Rows[index].Cells[dgv_Titles_Title.Name].Value + "",
                    "- ",
                    dgv_Titles.Rows[index].Cells[dgv_Titles_SK.Name].Value + ""));
                btn_Reset.Visible = true;
            }
            catch (Exception ex) { Log(ex); }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoadMode) return;
            if (dgv_Titles.SelectedRows.Count > 0)
                try
                {
                    RemoveItem(dgv_Titles.SelectedRows[0].Cells[dgv_Titles_ID.Name].Value + "");
                    dgv_Titles.Rows.RemoveAt(dgv_Titles.SelectedRows[0].Index);
                }
                catch (Exception ex) { Log(ex); }
        }
        private void dgv_Titles_SelectionChanged(object sender, EventArgs e)
        {
            if (LoadMode) return;
            if (dgv_Titles.SelectedRows.Count > 0)
                ShowItem(dgv_Titles.SelectedRows[0].Cells[dgv_Titles_ID.Name].Value + "");
        }
        private void dgv_Titles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (LoadMode) return;
            if (dgv_Titles.SelectedRows.Count > 0)
            {
                tb_Title.Text = dgv_Titles.SelectedRows[0].Cells[dgv_Titles_Title.Name].Value+"";
                tb_Title.Tag = dgv_Titles.SelectedRows[0].Cells[dgv_Titles_SK.Name].Value + "";
                btn_Reset.Visible = true;
            }
        }
        private void p_Main_FocusedChanged(object sender, EventArgs e)
        {
        }
        private void rtb_Main_TextChanged(object sender, EventArgs e)
        {
            if (LoadMode) return;
            btn_Reset.Visible = true;
            if (dgv_Titles.SelectedRows[0].Cells[dgv_Titles_Title.Name].Value + "" != tb_Title.Text) dgv_Titles.SelectedRows[0].Cells[dgv_Titles_Title.Name].Value = tb_Title.Text;
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ShowItem(rtb_Main.Tag+"");
        }
        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load();
        }
        private void l_ForeColor_Click(object sender, EventArgs e)
        {
            if(cd_ColorDialog.ShowDialog() == DialogResult.OK)
                l_ForeColor.ForeColor = cd_ColorDialog.Color;
        }
        private void cb_Transparent_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Transparent.Checked)
            {
                TransparencyKey = BackColor;
                tsmi_Panel.Checked = true;
                titleBarToolStripMenuItem.Checked = false;
                l_Message.Visible = false;
            }
            else
            {
                TransparencyKey = Color.Empty;
                tsmi_Panel.Checked = true;
                titleBarToolStripMenuItem.Checked = true;
                l_Message.Visible = true;
            }
        }
        private void cb_BackLight_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_BackLight.Checked) BackgroundImage = Properties.Resources.Light1;
            else BackgroundImage = null;
        }
        private void btn_Reset_VisibleChanged(object sender, EventArgs e)
        {
            refreshToolStripMenuItem.Visible = btn_Reset.Visible;
        }
        private void l_ForeColor_ForeColorChanged(object sender, EventArgs e)
        {
            ForeColor = l_BackColor.ForeColor = rtb_Main.ForeColor = tb_Title.ForeColor = l_ForeColor.ForeColor;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Home_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tsmb_EditMode.Checked) return;
            string key = (e.KeyChar + "").ToUpper();
            for (int i = 0; i < dgv_Titles.Rows.Count; i++)
                if (dgv_Titles.Rows[i].Cells[dgv_Titles_SK.Name].Value + "" == key)
                {
                    dgv_Titles.Rows[i].Cells[dgv_Titles_Title.Name].Selected = true;
                    break;
                }
        }
        private void titleBarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            p_List.Visible = titleBarToolStripMenuItem.Checked;
        }
        private void toolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            p_Main.Visible = tsmi_Panel.Checked;
        }
        private void toolStripMenuItem2_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = tsmi_TopM.Checked;
        }
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_Main.Font.Size > 40) return;
            rtb_Main.Font = new Font(rtb_Main.Font.FontFamily, rtb_Main.Font.Size + 1, rtb_Main.Font.Style);
            SetFonts();
        }
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_Main.Font.Size < 7) return;
            rtb_Main.Font = new Font(rtb_Main.Font.FontFamily, rtb_Main.Font.Size - 1, rtb_Main.Font.Style);
            SetFonts();
        }
        private void toolStripMenuItem1_CheckedChanged_1(object sender, EventArgs e)
        {
            toolStrip1.Visible = tsmb__MenuBar.Checked;
        }
        private void tsmb_WrapMode_CheckedChanged(object sender, EventArgs e)
        {
            rtb_Main.WordWrap = tsmb_WrapMode.Checked;
        }
        private void toolStripMenuItem2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (tsmb_EditMode.Checked)
            {
                var f = rtb_Main.ZoomFactor;
                dgv_Titles.AllowUserToAddRows =
                deleteToolStripMenuItem.Enabled = true;
                tb_Title.ReadOnly = 
                rtb_Main.ReadOnly =
                dgv_Titles.ReadOnly = false;
                rtb_Main.ZoomFactor = f;
            }
            else
            {
                var f = rtb_Main.ZoomFactor;
                dgv_Titles.AllowUserToAddRows =
                deleteToolStripMenuItem.Enabled = false;
                tb_Title.ReadOnly =
                rtb_Main.ReadOnly =
                dgv_Titles.ReadOnly = true;
                rtb_Main.ZoomFactor = f;
            }
        }
        private void toolStripMenuItem3_BackColorChanged(object sender, EventArgs e)
        {
            BackColor = l_ForeColor.BackColor = rtb_Main.BackColor = dgv_Titles.BackgroundColor = dgv_Titles.DefaultCellStyle.BackColor = tb_Title.BackColor = l_BackColor.BackColor;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (cd_ColorDialog.ShowDialog() == DialogResult.OK)
                l_BackColor.BackColor =
                    cd_ColorDialog.Color;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l_ForeColor.ForeColor = Color.WhiteSmoke;
            l_BackColor.BackColor = Color.DimGray;
        }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l_ForeColor.ForeColor = Color.Black;
            l_BackColor.BackColor = Color.White;
        }
        private void classicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l_ForeColor.ForeColor = Color.Black;
            l_BackColor.BackColor = Color.WhiteSmoke;
        }

    }
}
