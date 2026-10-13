namespace Cafeteria.UI
{
    partial class UC_Devoluciones
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Devoluciones));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            lblPedido = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtBuscarPedido = new Guna.UI2.WinForms.Guna2TextBox();
            dtgvwDatosPedido = new Guna.UI2.WinForms.Guna2DataGridView();
            dtgvwDevolucion = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDevolucion = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvwDatosPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvwDevolucion).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel5
            // 
            guna2Panel5.BackColor = Color.FromArgb(242, 232, 225);
            guna2Panel5.Controls.Add(lblPedido);
            guna2Panel5.CustomizableEdges = customizableEdges1;
            guna2Panel5.Location = new Point(0, 3);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel5.Size = new Size(839, 87);
            guna2Panel5.TabIndex = 8;
            // 
            // lblPedido
            // 
            lblPedido.BackColor = Color.Transparent;
            lblPedido.Font = new Font("Elephant", 23.9999981F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPedido.ForeColor = Color.Maroon;
            lblPedido.Location = new Point(261, 18);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(267, 53);
            lblPedido.TabIndex = 1;
            lblPedido.Text = "Devoluciones";
            lblPedido.Click += lblPedido_Click;
            // 
            // txtBuscarPedido
            // 
            txtBuscarPedido.BorderColor = Color.Maroon;
            txtBuscarPedido.CustomizableEdges = customizableEdges3;
            txtBuscarPedido.DefaultText = "Buscar pedido";
            txtBuscarPedido.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscarPedido.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscarPedido.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarPedido.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarPedido.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarPedido.Font = new Font("Segoe UI", 9F);
            txtBuscarPedido.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarPedido.IconLeft = (Image)resources.GetObject("txtBuscarPedido.IconLeft");
            txtBuscarPedido.Location = new Point(26, 111);
            txtBuscarPedido.Margin = new Padding(3, 4, 3, 4);
            txtBuscarPedido.Name = "txtBuscarPedido";
            txtBuscarPedido.PlaceholderText = "";
            txtBuscarPedido.SelectedText = "";
            txtBuscarPedido.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtBuscarPedido.Size = new Size(286, 52);
            txtBuscarPedido.TabIndex = 9;
            // 
            // dtgvwDatosPedido
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dtgvwDatosPedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvwDatosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvwDatosPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvwDatosPedido.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvwDatosPedido.GridColor = Color.FromArgb(231, 229, 255);
            dtgvwDatosPedido.Location = new Point(26, 188);
            dtgvwDatosPedido.Name = "dtgvwDatosPedido";
            dtgvwDatosPedido.RowHeadersVisible = false;
            dtgvwDatosPedido.RowHeadersWidth = 51;
            dtgvwDatosPedido.Size = new Size(755, 190);
            dtgvwDatosPedido.TabIndex = 10;
            dtgvwDatosPedido.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgvwDatosPedido.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dtgvwDatosPedido.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvwDatosPedido.ThemeStyle.HeaderStyle.Height = 4;
            dtgvwDatosPedido.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dtgvwDatosPedido.ThemeStyle.RowsStyle.Height = 29;
            // 
            // dtgvwDevolucion
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dtgvwDevolucion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgvwDevolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtgvwDevolucion.ColumnHeadersHeight = 4;
            dtgvwDevolucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtgvwDevolucion.DefaultCellStyle = dataGridViewCellStyle6;
            dtgvwDevolucion.GridColor = Color.FromArgb(231, 229, 255);
            dtgvwDevolucion.Location = new Point(26, 427);
            dtgvwDevolucion.Name = "dtgvwDevolucion";
            dtgvwDevolucion.RowHeadersVisible = false;
            dtgvwDevolucion.RowHeadersWidth = 51;
            dtgvwDevolucion.Size = new Size(755, 190);
            dtgvwDevolucion.TabIndex = 11;
            dtgvwDevolucion.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dtgvwDevolucion.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dtgvwDevolucion.ThemeStyle.HeaderStyle.Height = 4;
            dtgvwDevolucion.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dtgvwDevolucion.ThemeStyle.RowsStyle.Height = 29;
            // 
            // btnDevolucion
            // 
            btnDevolucion.BorderRadius = 8;
            btnDevolucion.CustomizableEdges = customizableEdges5;
            btnDevolucion.DisabledState.BorderColor = Color.DarkGray;
            btnDevolucion.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDevolucion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDevolucion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDevolucion.FillColor = Color.Maroon;
            btnDevolucion.Font = new Font("Segoe UI", 9F);
            btnDevolucion.ForeColor = Color.White;
            btnDevolucion.Location = new Point(261, 650);
            btnDevolucion.Name = "btnDevolucion";
            btnDevolucion.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDevolucion.Size = new Size(209, 51);
            btnDevolucion.TabIndex = 12;
            btnDevolucion.Text = "Realizar dvolución ";
            // 
            // UC_Devoluciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDevolucion);
            Controls.Add(dtgvwDevolucion);
            Controls.Add(dtgvwDatosPedido);
            Controls.Add(txtBuscarPedido);
            Controls.Add(guna2Panel5);
            Name = "UC_Devoluciones";
            Size = new Size(826, 756);
            guna2Panel5.ResumeLayout(false);
            guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvwDatosPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvwDevolucion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPedido;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarPedido;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvwDatosPedido;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvwDevolucion;
        private Guna.UI2.WinForms.Guna2Button btnDevolucion;
    }
}
