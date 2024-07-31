namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label agendaIDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label empresaLabel;
            System.Windows.Forms.Label contatoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label ultimo_ContatoLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.agendaDB1DataSet = new Agenda.AgendaDB1DataSet();
            this.pESSOASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pESSOASTableAdapter = new Agenda.AgendaDB1DataSetTableAdapters.PESSOASTableAdapter();
            this.tableAdapterManager = new Agenda.AgendaDB1DataSetTableAdapters.TableAdapterManager();
            this.pESSOASBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pESSOASBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agendaIDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.empresaTextBox = new System.Windows.Forms.TextBox();
            this.contatoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.clienteCheckBox = new System.Windows.Forms.CheckBox();
            this.ultimo_ContatoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            agendaIDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            empresaLabel = new System.Windows.Forms.Label();
            contatoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ultimo_ContatoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOASBindingNavigator)).BeginInit();
            this.pESSOASBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // agendaDB1DataSet
            // 
            this.agendaDB1DataSet.DataSetName = "AgendaDB1DataSet";
            this.agendaDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pESSOASBindingSource
            // 
            this.pESSOASBindingSource.DataMember = "PESSOAS";
            this.pESSOASBindingSource.DataSource = this.agendaDB1DataSet;
            // 
            // pESSOASTableAdapter
            // 
            this.pESSOASTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PESSOASTableAdapter = this.pESSOASTableAdapter;
            this.tableAdapterManager.UpdateOrder = Agenda.AgendaDB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pESSOASBindingNavigator
            // 
            this.pESSOASBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pESSOASBindingNavigator.BindingSource = this.pESSOASBindingSource;
            this.pESSOASBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pESSOASBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pESSOASBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pESSOASBindingNavigatorSaveItem});
            this.pESSOASBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pESSOASBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pESSOASBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pESSOASBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pESSOASBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pESSOASBindingNavigator.Name = "pESSOASBindingNavigator";
            this.pESSOASBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pESSOASBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.pESSOASBindingNavigator.TabIndex = 1;
            this.pESSOASBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // pESSOASBindingNavigatorSaveItem
            // 
            this.pESSOASBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pESSOASBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pESSOASBindingNavigatorSaveItem.Image")));
            this.pESSOASBindingNavigatorSaveItem.Name = "pESSOASBindingNavigatorSaveItem";
            this.pESSOASBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pESSOASBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pESSOASBindingNavigatorSaveItem.Click += new System.EventHandler(this.pESSOASBindingNavigatorSaveItem_Click);
            // 
            // agendaIDLabel
            // 
            agendaIDLabel.AutoSize = true;
            agendaIDLabel.Location = new System.Drawing.Point(121, 41);
            agendaIDLabel.Name = "agendaIDLabel";
            agendaIDLabel.Size = new System.Drawing.Size(61, 13);
            agendaIDLabel.TabIndex = 2;
            agendaIDLabel.Text = "Agenda ID:";
            // 
            // agendaIDTextBox
            // 
            this.agendaIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESSOASBindingSource, "AgendaID", true));
            this.agendaIDTextBox.Location = new System.Drawing.Point(206, 38);
            this.agendaIDTextBox.Name = "agendaIDTextBox";
            this.agendaIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.agendaIDTextBox.TabIndex = 3;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(121, 67);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESSOASBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(206, 64);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 5;
            // 
            // empresaLabel
            // 
            empresaLabel.AutoSize = true;
            empresaLabel.Location = new System.Drawing.Point(121, 93);
            empresaLabel.Name = "empresaLabel";
            empresaLabel.Size = new System.Drawing.Size(51, 13);
            empresaLabel.TabIndex = 6;
            empresaLabel.Text = "Empresa:";
            // 
            // empresaTextBox
            // 
            this.empresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESSOASBindingSource, "Empresa", true));
            this.empresaTextBox.Location = new System.Drawing.Point(206, 90);
            this.empresaTextBox.Name = "empresaTextBox";
            this.empresaTextBox.Size = new System.Drawing.Size(200, 20);
            this.empresaTextBox.TabIndex = 7;
            // 
            // contatoLabel
            // 
            contatoLabel.AutoSize = true;
            contatoLabel.Location = new System.Drawing.Point(121, 119);
            contatoLabel.Name = "contatoLabel";
            contatoLabel.Size = new System.Drawing.Size(47, 13);
            contatoLabel.TabIndex = 8;
            contatoLabel.Text = "Contato:";
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESSOASBindingSource, "Contato", true));
            this.contatoTextBox.Location = new System.Drawing.Point(206, 116);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(200, 20);
            this.contatoTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(121, 145);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pESSOASBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(206, 142);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(121, 173);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(68, 13);
            clienteLabel.TabIndex = 12;
            clienteLabel.Text = " Ja é Cliente:";
            // 
            // clienteCheckBox
            // 
            this.clienteCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pESSOASBindingSource, "Cliente", true));
            this.clienteCheckBox.Location = new System.Drawing.Point(206, 168);
            this.clienteCheckBox.Name = "clienteCheckBox";
            this.clienteCheckBox.Size = new System.Drawing.Size(200, 24);
            this.clienteCheckBox.TabIndex = 13;
            this.clienteCheckBox.Text = "Sim";
            this.clienteCheckBox.UseVisualStyleBackColor = true;
            // 
            // ultimo_ContatoLabel
            // 
            ultimo_ContatoLabel.AutoSize = true;
            ultimo_ContatoLabel.Location = new System.Drawing.Point(121, 202);
            ultimo_ContatoLabel.Name = "ultimo_ContatoLabel";
            ultimo_ContatoLabel.Size = new System.Drawing.Size(79, 13);
            ultimo_ContatoLabel.TabIndex = 14;
            ultimo_ContatoLabel.Text = "Ultimo Contato:";
            // 
            // ultimo_ContatoDateTimePicker
            // 
            this.ultimo_ContatoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pESSOASBindingSource, "Ultimo Contato", true));
            this.ultimo_ContatoDateTimePicker.Location = new System.Drawing.Point(206, 198);
            this.ultimo_ContatoDateTimePicker.Name = "ultimo_ContatoDateTimePicker";
            this.ultimo_ContatoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ultimo_ContatoDateTimePicker.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(agendaIDLabel);
            this.Controls.Add(this.agendaIDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(empresaLabel);
            this.Controls.Add(this.empresaTextBox);
            this.Controls.Add(contatoLabel);
            this.Controls.Add(this.contatoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteCheckBox);
            this.Controls.Add(ultimo_ContatoLabel);
            this.Controls.Add(this.ultimo_ContatoDateTimePicker);
            this.Controls.Add(this.pESSOASBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOASBindingNavigator)).EndInit();
            this.pESSOASBindingNavigator.ResumeLayout(false);
            this.pESSOASBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private AgendaDB1DataSet agendaDB1DataSet;
        private System.Windows.Forms.BindingSource pESSOASBindingSource;
        private AgendaDB1DataSetTableAdapters.PESSOASTableAdapter pESSOASTableAdapter;
        private AgendaDB1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pESSOASBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pESSOASBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox agendaIDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox empresaTextBox;
        private System.Windows.Forms.TextBox contatoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.CheckBox clienteCheckBox;
        private System.Windows.Forms.DateTimePicker ultimo_ContatoDateTimePicker;
    }
}

