using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ROMStuckBitSimulator
{
    public partial class Form1 : Form
    {
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            dt = new DataTable("Chips");
            dt.Columns.Add("Chip", typeof(String));
            dt.Columns.Add("AddressLines", typeof(int));

            DataRow choose = dt.NewRow();
            choose["Chip"] = "Please select a chip";
            choose["AddressLines"] = 0;
            dt.Rows.Add(choose);
            DataRow dr = dt.NewRow();
            dr["Chip"] = "2716";
            dr["AddressLines"] = 11;
            dt.Rows.Add(dr);
            DataRow dr1 = dt.NewRow();
            dr1["Chip"] = "2732";
            dr1["AddressLines"] = 12;
            dt.Rows.Add(dr1);
            DataRow dr2 = dt.NewRow();
            dr2["Chip"] = "2764";
            dr2["AddressLines"] = 13;
            dt.Rows.Add(dr2);
            DataRow dr3 = dt.NewRow();
            dr3["Chip"] = "27128";
            dr3["AddressLines"] = 14;
            dt.Rows.Add(dr3);
            cmbChipFamily.DisplayMember = "Chip";
            cmbChipFamily.ValueMember = "AddressLines";
            cmbChipFamily.DataSource = dt;
            cmbChipFamily.SelectedItem = 0;
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtOpenROM.Text = openFileDialog1.FileName;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            txtSaveROM.Text = saveFileDialog1.FileName;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int bitMaskAddr = 0;
            int bitMaskData = 0;
            byte[] byteArray, outputArray;
            int numBytes = 0;
            int expo = 1;
            for (int i = 0; i < pnlAddress.Controls.Count; i++)
            {
                if (i == 0)
                {
                    bitMaskAddr |= Convert.ToByte(((CheckBox)pnlAddress.Controls[i]).Checked);
                }
                else
                {
                    bitMaskAddr |= Convert.ToByte(((CheckBox)pnlAddress.Controls[i]).Checked) << expo;
                    expo++;
                }
            }
            /*
            bitMaskAddr = Convert.ToByte(chkA0.Checked) | (Convert.ToByte(chkA1.Checked) << 1) | (Convert.ToByte(chkA2.Checked) << 2) | (Convert.ToByte(chkA3.Checked) << 3) |
                (Convert.ToByte(chkA4.Checked) << 4) | (Convert.ToByte(chkA5.Checked) << 5) | (Convert.ToByte(chkA6.Checked) << 6) | (Convert.ToByte(chkA7.Checked) << 7) |
                (Convert.ToByte(chkA8.Checked) << 8) | (Convert.ToByte(chkA9.Checked) << 9) | (Convert.ToByte(chkA10.Checked) << 10);
            */
            bitMaskData = Convert.ToInt32(chkD0.Checked) | (Convert.ToInt32(chkD1.Checked) << 1) | (Convert.ToInt32(chkD2.Checked) << 2) | (Convert.ToInt32(chkD3.Checked) << 3) |
                (Convert.ToInt32(chkD4.Checked) << 4) | (Convert.ToInt32(chkD5.Checked) << 5) | (Convert.ToInt32(chkD6.Checked) << 6) | (Convert.ToInt32(chkD7.Checked) << 7);

            Console.WriteLine("Address BitMask: " + bitMaskAddr);
            Console.WriteLine("Data BitMask: " + bitMaskData);

            using (BinaryReader br = new BinaryReader(new FileStream(txtOpenROM.Text, FileMode.Open)))
            {
                numBytes = (int)br.BaseStream.Length;
                outputArray = new byte[numBytes];
                Console.WriteLine(String.Format("Original ROM contains {0} bytes.", numBytes));
                byteArray = br.ReadBytes((int)br.BaseStream.Length); // Only capable of reading up to 65k per ROM (have to convert length to fit into a 16-bit INT)
            }

            for (int i = 0; i < numBytes; i++)
            {
                outputArray[i] = (byte)(byteArray[i | bitMaskAddr] | bitMaskData);
            }

            using (BinaryWriter bw = new BinaryWriter(new FileStream(txtSaveROM.Text, FileMode.CreateNew)))
            {
                bw.Write(outputArray);
            }
        }

        private void cmbChipFamily_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int j = pnlAddress.Controls.Count - 1; j >= 0; j--)
            {
                pnlAddress.Controls.RemoveAt(j);
            }
            pnlAddress.Refresh();
            for (int i = 0; i < (int)cmbChipFamily.SelectedValue; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = String.Format("A{0}", i);
                cb.Name = "chk" + cb.Text;
                pnlAddress.Controls.Add(cb);
            }
            pnlAddress.Update();
        }
    }
}
