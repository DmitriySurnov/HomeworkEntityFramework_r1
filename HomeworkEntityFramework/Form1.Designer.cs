namespace HomeworkEntityFramework
{
    partial class FormLinqRequests
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonRequestNameOfPlayers = new Button();
            buttonRequestNameOfPlayersAndNameOfClass = new Button();
            buttonRequesNameOfClassAndNameOfSpell = new Button();
            buttonRequestNameOfPlayersAndNameOfSpell = new Button();
            tabControl1 = new TabControl();
            LINGRequests = new TabPage();
            AddPlayer = new TabPage();
            buttonAdd = new Button();
            buttonClear = new Button();
            comboBoxPlayerClass = new ComboBox();
            textBoxPlayerName = new TextBox();
            labelPlayerClass = new Label();
            labelPlayerName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            LINGRequests.SuspendLayout();
            AddPlayer.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(972, 300);
            dataGridView1.TabIndex = 0;
            // 
            // buttonRequestNameOfPlayers
            // 
            buttonRequestNameOfPlayers.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRequestNameOfPlayers.Location = new Point(36, 336);
            buttonRequestNameOfPlayers.Name = "buttonRequestNameOfPlayers";
            buttonRequestNameOfPlayers.Size = new Size(449, 136);
            buttonRequestNameOfPlayers.TabIndex = 1;
            buttonRequestNameOfPlayers.Text = "Вывести Имена всех играков";
            buttonRequestNameOfPlayers.UseVisualStyleBackColor = true;
            buttonRequestNameOfPlayers.Click += ButtonRequestNameOfPlayers_Click;
            // 
            // buttonRequestNameOfPlayersAndNameOfClass
            // 
            buttonRequestNameOfPlayersAndNameOfClass.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRequestNameOfPlayersAndNameOfClass.Location = new Point(567, 336);
            buttonRequestNameOfPlayersAndNameOfClass.Name = "buttonRequestNameOfPlayersAndNameOfClass";
            buttonRequestNameOfPlayersAndNameOfClass.Size = new Size(441, 136);
            buttonRequestNameOfPlayersAndNameOfClass.TabIndex = 2;
            buttonRequestNameOfPlayersAndNameOfClass.Text = "Вывести Имена всех играков и их классы";
            buttonRequestNameOfPlayersAndNameOfClass.UseVisualStyleBackColor = true;
            buttonRequestNameOfPlayersAndNameOfClass.Click += ButtonRequestNameOfPlayersAndNameOfClass_Click;
            // 
            // buttonRequesNameOfClassAndNameOfSpell
            // 
            buttonRequesNameOfClassAndNameOfSpell.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRequesNameOfClassAndNameOfSpell.Location = new Point(567, 500);
            buttonRequesNameOfClassAndNameOfSpell.Name = "buttonRequesNameOfClassAndNameOfSpell";
            buttonRequesNameOfClassAndNameOfSpell.Size = new Size(441, 195);
            buttonRequesNameOfClassAndNameOfSpell.TabIndex = 3;
            buttonRequesNameOfClassAndNameOfSpell.Text = "Вывести Название всех классов играков и их умения";
            buttonRequesNameOfClassAndNameOfSpell.UseVisualStyleBackColor = true;
            buttonRequesNameOfClassAndNameOfSpell.Click += ButtonRequesNameOfClassAndNameOfSpell_Click;
            // 
            // buttonRequestNameOfPlayersAndNameOfSpell
            // 
            buttonRequestNameOfPlayersAndNameOfSpell.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRequestNameOfPlayersAndNameOfSpell.Location = new Point(36, 523);
            buttonRequestNameOfPlayersAndNameOfSpell.Name = "buttonRequestNameOfPlayersAndNameOfSpell";
            buttonRequestNameOfPlayersAndNameOfSpell.Size = new Size(449, 149);
            buttonRequestNameOfPlayersAndNameOfSpell.TabIndex = 4;
            buttonRequestNameOfPlayersAndNameOfSpell.Text = "Вывести Имена всех играков и их умения";
            buttonRequestNameOfPlayersAndNameOfSpell.UseVisualStyleBackColor = true;
            buttonRequestNameOfPlayersAndNameOfSpell.Click += ButtonRequestNameOfPlayersAndNameOfSpell_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(LINGRequests);
            tabControl1.Controls.Add(AddPlayer);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1077, 850);
            tabControl1.TabIndex = 5;
            tabControl1.Selected += TabControl1_Selected;
            // 
            // LINGRequests
            // 
            LINGRequests.Controls.Add(dataGridView1);
            LINGRequests.Controls.Add(buttonRequestNameOfPlayersAndNameOfSpell);
            LINGRequests.Controls.Add(buttonRequestNameOfPlayersAndNameOfClass);
            LINGRequests.Controls.Add(buttonRequestNameOfPlayers);
            LINGRequests.Controls.Add(buttonRequesNameOfClassAndNameOfSpell);
            LINGRequests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LINGRequests.Location = new Point(8, 46);
            LINGRequests.Name = "LINGRequests";
            LINGRequests.Padding = new Padding(3);
            LINGRequests.Size = new Size(1061, 796);
            LINGRequests.TabIndex = 0;
            LINGRequests.Text = "LING Запросы";
            LINGRequests.UseVisualStyleBackColor = true;
            // 
            // AddPlayer
            // 
            AddPlayer.Controls.Add(buttonAdd);
            AddPlayer.Controls.Add(buttonClear);
            AddPlayer.Controls.Add(comboBoxPlayerClass);
            AddPlayer.Controls.Add(textBoxPlayerName);
            AddPlayer.Controls.Add(labelPlayerClass);
            AddPlayer.Controls.Add(labelPlayerName);
            AddPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddPlayer.Location = new Point(8, 46);
            AddPlayer.Name = "AddPlayer";
            AddPlayer.Padding = new Padding(3);
            AddPlayer.Size = new Size(1061, 796);
            AddPlayer.TabIndex = 1;
            AddPlayer.Text = "Добавить игрока";
            AddPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(35, 224);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(297, 100);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClear.Location = new Point(636, 224);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(297, 100);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += ButtonClear_Click;
            // 
            // comboBoxPlayerClass
            // 
            comboBoxPlayerClass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPlayerClass.FormattingEnabled = true;
            comboBoxPlayerClass.Location = new Point(395, 99);
            comboBoxPlayerClass.Name = "comboBoxPlayerClass";
            comboBoxPlayerClass.Size = new Size(538, 73);
            comboBoxPlayerClass.TabIndex = 3;
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlayerName.Location = new Point(395, 16);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(542, 71);
            textBoxPlayerName.TabIndex = 2;
            // 
            // labelPlayerClass
            // 
            labelPlayerClass.AutoSize = true;
            labelPlayerClass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerClass.Location = new Point(20, 107);
            labelPlayerClass.Name = "labelPlayerClass";
            labelPlayerClass.Size = new Size(312, 65);
            labelPlayerClass.TabIndex = 1;
            labelPlayerClass.Text = "Класс игрока";
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(20, 16);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(285, 65);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Имя игрока";
            // 
            // FormLinqRequests
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 850);
            Controls.Add(tabControl1);
            Name = "FormLinqRequests";
            Text = "LING запросы";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            LINGRequests.ResumeLayout(false);
            AddPlayer.ResumeLayout(false);
            AddPlayer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonRequestNameOfPlayers;
        private Button buttonRequestNameOfPlayersAndNameOfClass;
        private Button buttonRequesNameOfClassAndNameOfSpell;
        private Button buttonRequestNameOfPlayersAndNameOfSpell;
        private TabControl tabControl1;
        private TabPage LINGRequests;
        private TabPage AddPlayer;
        private ComboBox comboBoxPlayerClass;
        private TextBox textBoxPlayerName;
        private Label labelPlayerClass;
        private Label labelPlayerName;
        private Button buttonClear;
        private Button buttonAdd;
    }
}