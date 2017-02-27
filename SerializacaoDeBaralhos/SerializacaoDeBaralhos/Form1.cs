using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializacaoDeBaralhos
{
    public partial class Form1 : Form
    {
        private Game game;
        Random random = new Random();
        Card card;
        string filePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter your name", "Can't start game yet");
                return;
            }
            game = new Game(txtName.Text, new List<string> { "Joe", "Bob" }, txtProgress);
            btnStart.Enabled = false;
            txtName.Enabled = false;
            btnAsk.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            listHand.Items.Clear();
            foreach (string cardName in game.GetPlayerCardNames())
                listHand.Items.Add(cardName);
            txtBooks.Text = game.DescribeBooks();
            txtProgress.Text += game.DescribePlayerHands();
            txtProgress.SelectionStart = txtProgress.Text.Length;
            txtProgress.ScrollToCaret();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            txtProgress.Text = "";
            if (listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a card");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                txtProgress.Text += "The winner is ..." + game.GetWinnerName();
                txtBooks.Text = game.DescribeBooks();
                btnAsk.Enabled = false;
            }
            else
                UpdateForm();
        }

        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card(
                    (Suits)random.Next(4),
                    (Values)random.Next(1, 14)));
            }
            return myDeck; 
        }

        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("----------------------");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = RandomDeck(5);
            using (Stream output = File.Create("Deck1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, deckToWrite);
            }
            DealCards(deckToWrite, "What I just wrote to the file");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck1.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Deck deckFromFile = (Deck)bf.Deserialize(input);
                DealCards(deckFromFile, "What I read from the file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (Stream outputThree = File.Create("three-c.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();

                for (int i = 1; i <= 5; i++)
                {
                    Deck deckToWrite = RandomDeck(random.Next(1, 10));
                    bf.Serialize(outputThree, deckToWrite);
                    DealCards(deckToWrite, "Deck #" + i + " written");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck2.dat")) { 
                BinaryFormatter bf = new BinaryFormatter();
                for (int i = 1; i <= 5; i++)
                {
                    Deck deckToRead = (Deck)bf.Deserialize(input);
                    DealCards(deckToRead, "Deck #" + i + " read");
                }
            }
        }

        private void btnCompareDados_Click(object sender, EventArgs e)
        {
            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");

            for (int i = 0; i < firstFile.Length; i++)
                if (firstFile[i] != secondFile[i])
                    Console.WriteLine("Byte #{0}: {1} versus {2}", i, firstFile[i], secondFile[i]);

            firstFile[307] = (byte)Suits.Spades;
            secondFile[364] = (byte)Values.King;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);

            using(Stream input = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter ft = new BinaryFormatter();
                card = (Card)ft.Deserialize(input);
                Console.WriteLine(card);
            }

        }

        private void btnThreeOfClubs_Click(object sender, EventArgs e)
        {
            Card threeOfClubs = new Card(Suits.Clubs, Values.Three);
            using(Stream outputThree = File.Create("three-c.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(outputThree, threeOfClubs);
            }
        }

        private void btnSixOfHearts_Click(object sender, EventArgs e)
        {
            Card sixOfHearts = new Card(Suits.Hearts, Values.Six);
            using (Stream outputSix = File.Create("six-h.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(outputSix, sixOfHearts);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            filePath = openFileDialog.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            filePath = saveFileDialog.FileName;
        }

        private void btnDespejo_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(filePath))
            using (StreamWriter writer = new StreamWriter(@"c:\files\output.txt",false))
            {
                int position = 0;

                while (!reader.EndOfStream)
                {
                    char[] buffer = new char[16];
                    int charactersRead = reader.ReadBlock(buffer, 0, 16);
                    writer.Write("{0}: ", string.Format("{0:x4}", position));
                    position += charactersRead;

                    for (int i = 0; i < 16; i++)
                    {
                        if (i < charactersRead)
                        {
                            string hex = string.Format("{0:x2}", (byte)buffer[i]);
                            writer.Write(hex + " ");
                        }
                        else
                            writer.Write(" ");

                        if (i == 7) { writer.Write("-- "); }
                        if (buffer[i] < 32 || buffer[i] > 250) { buffer[i] = '.'; }
                    }
                    string bufferContents = new string(buffer);
                    writer.WriteLine(" " + bufferContents.Substring(0, charactersRead));
                }
            }
        }
    }
}
