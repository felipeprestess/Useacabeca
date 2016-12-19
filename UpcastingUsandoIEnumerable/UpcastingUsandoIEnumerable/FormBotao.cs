using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpcastingUsandoIEnumerable
{
    public partial class FormBotao : Form
    {
        public FormBotao()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
            MessageBox.Show(doesItMatch.ToString());
        }
    }
}
