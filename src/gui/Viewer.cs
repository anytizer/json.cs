using models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            this.SuspendLayout();
            this.dataGridView1.Rows.Clear();

            fill();

            this.ResumeLayout();
        }

        /**
         * @see http://stackoverflow.com/questions/10063770/how-to-add-a-new-row-to-datagridview-programmatically
         */
        private void fill()
        {
            members m = new members();
            List<idv> all = m.all();
            if(null != all && all.Count >= 1)
            {
                foreach (idv row in all)
                {
                    DataGridViewRow r = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    r.Cells[0].Value = row.id;
                    r.Cells[1].Value = row.name;
                    r.Cells[2].Value = row.value;

                    this.dataGridView1.Rows.Add(r);
                }
            }
            
        }
    }
}
