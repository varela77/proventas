namespace Win.Tienda
{
    partial class FormModelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activoLabel1;
            System.Windows.Forms.Label artistaLabel;
            System.Windows.Forms.Label descipcionLabel1;
            System.Windows.Forms.Label existenciaLabel1;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label precioLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModelo));
            this.listaModelosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaModelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaModelosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox1 = new System.Windows.Forms.CheckBox();
            this.artistaTextBox = new System.Windows.Forms.TextBox();
            this.descipcionTextBox1 = new System.Windows.Forms.TextBox();
            this.existenciaTextBox1 = new System.Windows.Forms.TextBox();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.precioTextBox1 = new System.Windows.Forms.TextBox();
            activoLabel1 = new System.Windows.Forms.Label();
            artistaLabel = new System.Windows.Forms.Label();
            descipcionLabel1 = new System.Windows.Forms.Label();
            existenciaLabel1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            precioLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelosBindingNavigator)).BeginInit();
            this.listaModelosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel1
            // 
            activoLabel1.AutoSize = true;
            activoLabel1.Location = new System.Drawing.Point(47, 219);
            activoLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            activoLabel1.Name = "activoLabel1";
            activoLabel1.Size = new System.Drawing.Size(50, 17);
            activoLabel1.TabIndex = 11;
            activoLabel1.Text = "Activo:";
            // 
            // artistaLabel
            // 
            artistaLabel.AutoSize = true;
            artistaLabel.Location = new System.Drawing.Point(47, 121);
            artistaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            artistaLabel.Name = "artistaLabel";
            artistaLabel.Size = new System.Drawing.Size(52, 17);
            artistaLabel.TabIndex = 13;
            artistaLabel.Text = "Artista:";
            // 
            // descipcionLabel1
            // 
            descipcionLabel1.AutoSize = true;
            descipcionLabel1.Location = new System.Drawing.Point(47, 89);
            descipcionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descipcionLabel1.Name = "descipcionLabel1";
            descipcionLabel1.Size = new System.Drawing.Size(81, 17);
            descipcionLabel1.TabIndex = 15;
            descipcionLabel1.Text = "Descipcion:";
            // 
            // existenciaLabel1
            // 
            existenciaLabel1.AutoSize = true;
            existenciaLabel1.Location = new System.Drawing.Point(47, 185);
            existenciaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            existenciaLabel1.Name = "existenciaLabel1";
            existenciaLabel1.Size = new System.Drawing.Size(75, 17);
            existenciaLabel1.TabIndex = 17;
            existenciaLabel1.Text = "Existencia:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(47, 57);
            idLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(23, 17);
            idLabel1.TabIndex = 19;
            idLabel1.Text = "Id:";
            // 
            // precioLabel1
            // 
            precioLabel1.AutoSize = true;
            precioLabel1.Location = new System.Drawing.Point(47, 153);
            precioLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precioLabel1.Name = "precioLabel1";
            precioLabel1.Size = new System.Drawing.Size(52, 17);
            precioLabel1.TabIndex = 21;
            precioLabel1.Text = "Precio:";
            // 
            // listaModelosBindingNavigator
            // 
            this.listaModelosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaModelosBindingNavigator.BindingSource = this.listaModelosBindingSource;
            this.listaModelosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaModelosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaModelosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listaModelosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaModelosBindingNavigatorSaveItem});
            this.listaModelosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaModelosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaModelosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaModelosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaModelosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaModelosBindingNavigator.Name = "listaModelosBindingNavigator";
            this.listaModelosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaModelosBindingNavigator.Size = new System.Drawing.Size(375, 27);
            this.listaModelosBindingNavigator.TabIndex = 0;
            this.listaModelosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // listaModelosBindingNavigatorSaveItem
            // 
            this.listaModelosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaModelosBindingNavigatorSaveItem.Enabled = false;
            this.listaModelosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaModelosBindingNavigatorSaveItem.Image")));
            this.listaModelosBindingNavigatorSaveItem.Name = "listaModelosBindingNavigatorSaveItem";
            this.listaModelosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.listaModelosBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activoCheckBox1
            // 
            this.activoCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaModelosBindingSource, "Activo", true));
            this.activoCheckBox1.Location = new System.Drawing.Point(139, 213);
            this.activoCheckBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheckBox1.Name = "activoCheckBox1";
            this.activoCheckBox1.Size = new System.Drawing.Size(139, 30);
            this.activoCheckBox1.TabIndex = 12;
            this.activoCheckBox1.UseVisualStyleBackColor = true;
            // 
            // artistaTextBox
            // 
            this.artistaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaModelosBindingSource, "Artista", true));
            this.artistaTextBox.Location = new System.Drawing.Point(139, 117);
            this.artistaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artistaTextBox.Name = "artistaTextBox";
            this.artistaTextBox.Size = new System.Drawing.Size(137, 22);
            this.artistaTextBox.TabIndex = 14;
            // 
            // descipcionTextBox1
            // 
            this.descipcionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaModelosBindingSource, "Descipcion", true));
            this.descipcionTextBox1.Location = new System.Drawing.Point(139, 85);
            this.descipcionTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descipcionTextBox1.Name = "descipcionTextBox1";
            this.descipcionTextBox1.Size = new System.Drawing.Size(223, 22);
            this.descipcionTextBox1.TabIndex = 16;
            // 
            // existenciaTextBox1
            // 
            this.existenciaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaModelosBindingSource, "Existencia", true));
            this.existenciaTextBox1.Location = new System.Drawing.Point(139, 181);
            this.existenciaTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.existenciaTextBox1.Name = "existenciaTextBox1";
            this.existenciaTextBox1.Size = new System.Drawing.Size(137, 22);
            this.existenciaTextBox1.TabIndex = 18;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaModelosBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(139, 53);
            this.idTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(137, 22);
            this.idTextBox1.TabIndex = 20;
            // 
            // precioTextBox1
            // 
            this.precioTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaModelosBindingSource, "Precio", true));
            this.precioTextBox1.Location = new System.Drawing.Point(139, 149);
            this.precioTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precioTextBox1.Name = "precioTextBox1";
            this.precioTextBox1.Size = new System.Drawing.Size(137, 22);
            this.precioTextBox1.TabIndex = 22;
            // 
            // FormModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(375, 255);
            this.Controls.Add(activoLabel1);
            this.Controls.Add(this.activoCheckBox1);
            this.Controls.Add(artistaLabel);
            this.Controls.Add(this.artistaTextBox);
            this.Controls.Add(descipcionLabel1);
            this.Controls.Add(this.descipcionTextBox1);
            this.Controls.Add(existenciaLabel1);
            this.Controls.Add(this.existenciaTextBox1);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(precioLabel1);
            this.Controls.Add(this.precioTextBox1);
            this.Controls.Add(this.listaModelosBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo";
            ((System.ComponentModel.ISupportInitialize)(this.listaModelosBindingNavigator)).EndInit();
            this.listaModelosBindingNavigator.ResumeLayout(false);
            this.listaModelosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaModelosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaModelosBindingSource;
        private System.Windows.Forms.BindingNavigator listaModelosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaModelosBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox1;
        private System.Windows.Forms.TextBox artistaTextBox;
        private System.Windows.Forms.TextBox descipcionTextBox1;
        private System.Windows.Forms.TextBox existenciaTextBox1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox precioTextBox1;
    }
}