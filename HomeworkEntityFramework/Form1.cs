using HomeworkEntityFramework.ModelDatabase;

namespace HomeworkEntityFramework
{
    public partial class FormLinqRequests : Form
    {
        private readonly DataBase db;
        public FormLinqRequests()
        {
            InitializeComponent();
            db = new DataBase();
        }

        private void ClearDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        private void AddDataDataGridView(List<string> data)
        {
            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void AddRowsDataGridView(List<string[]> data)
        {
            foreach (string[] item in data)
            {
                dataGridView1.Rows.Add(item);
            }
        }

        private void AddColumnsDataGridView(List<(string columnName, string headerText)> listColumns)
        {
            foreach ((string columnName, string headerText) in listColumns)
            {
                dataGridView1.Columns.Add(columnName, headerText);
            }
        }

        private void ButtonRequestNameOfPlayers_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            AddColumnsDataGridView(new List<(string, string)> { ("PlayerName", "Имя игрока") });
            AddDataDataGridView(Requests.NameOfPlayers(db));
        }

        private void ButtonRequestNameOfPlayersAndNameOfClass_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            AddColumnsDataGridView(new List<(string, string)> { ("PlayerName", "Имя игрока"), ("NameClass", "Название класса") });
            AddRowsDataGridView(Requests.NameOfPlayersAndNameOfClass(db));
        }

        private void ButtonRequestNameOfPlayersAndNameOfSpell_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            AddColumnsDataGridView(new List<(string, string)> { ("PlayerName", "Имя игрока"), ("Skills", "Умения") });
            AddRowsDataGridView(Requests.NameOfPlayersAndNameOfSpell(db));
        }

        private void ButtonRequesNameOfClassAndNameOfSpell_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            AddColumnsDataGridView(new List<(string, string)> { ("NameClass", "Название класса"), ("Skills", "Умения") });
            AddRowsDataGridView(Requests.NameOfClassAndNameOfSpell(db));
        }

        private void ClearText()
        {
            textBoxPlayerName.Text = "";
            comboBoxPlayerClass.Text = "";
        }

        private void ClearcomboBox()
        {
            comboBoxPlayerClass.Items.Clear();
        }

        private void FillingComboBox(string[] data)
        {

            comboBoxPlayerClass.Items.AddRange(data);
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Text = e.TabPage?.Text;
            if (e.TabPage != null && e.TabPage.Name == "AddPlayer")
            {
                ClearText();
                ClearcomboBox();
                FillingComboBox(Requests.NameOfClass(db));
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private static void ErrorMessages(string textMessages)
        {
            MessageBox.Show(
                   textMessages,
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private static void InformationMessages()
        {
            MessageBox.Show(
                   "Новый игрок был успешно добавлен",
                   "Оповещение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        private static bool ValedateTextBoxEmpty(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ErrorMessages("Вы не заполнили поле ' Имя игрока '");
                return false;
            }
            else
                return true;
        }
        private static bool ValedateComboBoxEmpty(ComboBox comboBox)
        {
            if (string.IsNullOrEmpty(comboBox.Text))
            {
                ErrorMessages("Вы не выбран класс игрока ");
                return false;
            }
            else
                return true;
        }

        private bool IsUniquePlayerName(string namePlayer)
        {
            if (Requests.UniquePlayerName(db, namePlayer) != 0)
            {
                ErrorMessages($"Игрок с именем {namePlayer} существует");
                return false;
            }
            return true;
        }

        private void AddDataTheTableCharactersClass(string nameClass)
        {
            db.CharactersClass.Add(new CharactersClass(nameClass));
            db.SaveChanges();
        }

        private void AddDataTheTableCharacters(string playerName, int idClass)
        {
            db.Characters.Add(new Characters(playerName, idClass));
            db.SaveChanges();
        }

        private void AddDataTheTableCharachtersExpirience(int idplayer)
        {
            db.CharachtersExpirience.Add(new CharachtersExpirience(idplayer));
            db.SaveChanges();
        }

        private int ReceiveIdClass(string nameClass)
        {
            int idClass = Requests.IdClass(db, nameClass);
            if (idClass == 0)
            {
                AddDataTheTableCharactersClass(nameClass);
                return ReceiveIdClass(nameClass);
            }
            else
                return idClass;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!ValedateTextBoxEmpty(textBoxPlayerName) ||
                !ValedateComboBoxEmpty(comboBoxPlayerClass) ||
                !IsUniquePlayerName(textBoxPlayerName.Text))
            {
                return;
            }
            AddDataTheTableCharacters(textBoxPlayerName.Text,
                    ReceiveIdClass(comboBoxPlayerClass.Text));
            AddDataTheTableCharachtersExpirience(Requests.IdPlayers(db, textBoxPlayerName.Text));
            InformationMessages();
            ClearText();
            ClearcomboBox();
            FillingComboBox(Requests.NameOfClass(db));
        }
    }
}