
namespace RailwayManagementSystem
{
    partial class TrainMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_trainName = new System.Windows.Forms.TextBox();
            this.txt_trainCapacity = new System.Windows.Forms.TextBox();
            this.rb_busy = new System.Windows.Forms.RadioButton();
            this.rb_available = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_trainAdd = new System.Windows.Forms.Button();
            this.btn_trainDelete = new System.Windows.Forms.Button();
            this.btn_trainEdit = new System.Windows.Forms.Button();
            this.btn_trainReset = new System.Windows.Forms.Button();
            this.Train_dataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Train_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 43);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(1038, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepPink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 563);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 43);
            this.panel2.TabIndex = 2;
            // 
            // txt_trainName
            // 
            this.txt_trainName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_trainName.Location = new System.Drawing.Point(141, 156);
            this.txt_trainName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_trainName.Multiline = true;
            this.txt_trainName.Name = "txt_trainName";
            this.txt_trainName.Size = new System.Drawing.Size(223, 36);
            this.txt_trainName.TabIndex = 3;
            // 
            // txt_trainCapacity
            // 
            this.txt_trainCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_trainCapacity.Location = new System.Drawing.Point(412, 156);
            this.txt_trainCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_trainCapacity.Multiline = true;
            this.txt_trainCapacity.Name = "txt_trainCapacity";
            this.txt_trainCapacity.Size = new System.Drawing.Size(223, 36);
            this.txt_trainCapacity.TabIndex = 4;
            // 
            // rb_busy
            // 
            this.rb_busy.AutoSize = true;
            this.rb_busy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_busy.ForeColor = System.Drawing.Color.Green;
            this.rb_busy.Location = new System.Drawing.Point(703, 165);
            this.rb_busy.Margin = new System.Windows.Forms.Padding(4);
            this.rb_busy.Name = "rb_busy";
            this.rb_busy.Size = new System.Drawing.Size(52, 21);
            this.rb_busy.TabIndex = 5;
            this.rb_busy.TabStop = true;
            this.rb_busy.Text = "Busy";
            this.rb_busy.UseVisualStyleBackColor = true;
            this.rb_busy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_available
            // 
            this.rb_available.AutoSize = true;
            this.rb_available.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_available.ForeColor = System.Drawing.Color.Green;
            this.rb_available.Location = new System.Drawing.Point(819, 165);
            this.rb_available.Margin = new System.Windows.Forms.Padding(4);
            this.rb_available.Name = "rb_available";
            this.rb_available.Size = new System.Drawing.Size(78, 21);
            this.rb_available.TabIndex = 6;
            this.rb_available.TabStop = true;
            this.rb_available.Text = "Available";
            this.rb_available.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(135, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Train Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(405, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Train Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(696, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Train Status";
            // 
            // btn_trainAdd
            // 
            this.btn_trainAdd.BackColor = System.Drawing.Color.Green;
            this.btn_trainAdd.ForeColor = System.Drawing.Color.White;
            this.btn_trainAdd.Location = new System.Drawing.Point(223, 215);
            this.btn_trainAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trainAdd.Name = "btn_trainAdd";
            this.btn_trainAdd.Size = new System.Drawing.Size(109, 37);
            this.btn_trainAdd.TabIndex = 10;
            this.btn_trainAdd.Text = "Add";
            this.btn_trainAdd.UseVisualStyleBackColor = false;
            this.btn_trainAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_trainDelete
            // 
            this.btn_trainDelete.BackColor = System.Drawing.Color.Green;
            this.btn_trainDelete.ForeColor = System.Drawing.Color.White;
            this.btn_trainDelete.Location = new System.Drawing.Point(588, 215);
            this.btn_trainDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trainDelete.Name = "btn_trainDelete";
            this.btn_trainDelete.Size = new System.Drawing.Size(109, 37);
            this.btn_trainDelete.TabIndex = 11;
            this.btn_trainDelete.Text = "Delete";
            this.btn_trainDelete.UseVisualStyleBackColor = false;
            this.btn_trainDelete.Click += new System.EventHandler(this.btn_trainDelete_Click);
            // 
            // btn_trainEdit
            // 
            this.btn_trainEdit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_trainEdit.ForeColor = System.Drawing.Color.White;
            this.btn_trainEdit.Location = new System.Drawing.Point(406, 215);
            this.btn_trainEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trainEdit.Name = "btn_trainEdit";
            this.btn_trainEdit.Size = new System.Drawing.Size(109, 37);
            this.btn_trainEdit.TabIndex = 12;
            this.btn_trainEdit.Text = "Edit";
            this.btn_trainEdit.UseVisualStyleBackColor = false;
            this.btn_trainEdit.Click += new System.EventHandler(this.btn_trainEdit_Click);
            // 
            // btn_trainReset
            // 
            this.btn_trainReset.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btn_trainReset.ForeColor = System.Drawing.Color.White;
            this.btn_trainReset.Location = new System.Drawing.Point(765, 215);
            this.btn_trainReset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_trainReset.Name = "btn_trainReset";
            this.btn_trainReset.Size = new System.Drawing.Size(109, 37);
            this.btn_trainReset.TabIndex = 13;
            this.btn_trainReset.Text = "Reset";
            this.btn_trainReset.UseVisualStyleBackColor = false;
            this.btn_trainReset.Click += new System.EventHandler(this.btn_trainReset_Click);
            // 
            // Train_dataGrid
            // 
            this.Train_dataGrid.AllowUserToAddRows = false;
            this.Train_dataGrid.AllowUserToDeleteRows = false;
            this.Train_dataGrid.AllowUserToResizeColumns = false;
            this.Train_dataGrid.AllowUserToResizeRows = false;
            this.Train_dataGrid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Train_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Train_dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Train_dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Train_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Train_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Train_dataGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.Train_dataGrid.Location = new System.Drawing.Point(141, 319);
            this.Train_dataGrid.MultiSelect = false;
            this.Train_dataGrid.Name = "Train_dataGrid";
            this.Train_dataGrid.ReadOnly = true;
            this.Train_dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Train_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Train_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Train_dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Train_dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.Train_dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Train_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Train_dataGrid.Size = new System.Drawing.Size(783, 192);
            this.Train_dataGrid.TabIndex = 14;
            this.Train_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Train_dataGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(498, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(507, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trains List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(454, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Train Master";
            // 
            // TrainMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1076, 606);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Train_dataGrid);
            this.Controls.Add(this.btn_trainReset);
            this.Controls.Add(this.btn_trainEdit);
            this.Controls.Add(this.btn_trainDelete);
            this.Controls.Add(this.btn_trainAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_available);
            this.Controls.Add(this.rb_busy);
            this.Controls.Add(this.txt_trainCapacity);
            this.Controls.Add(this.txt_trainName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrainMaster";
            this.Text = "TrainMaster";
            this.Load += new System.EventHandler(this.TrainMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Train_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_trainName;
        private System.Windows.Forms.TextBox txt_trainCapacity;
        private System.Windows.Forms.RadioButton rb_busy;
        private System.Windows.Forms.RadioButton rb_available;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_trainAdd;
        private System.Windows.Forms.Button btn_trainDelete;
        private System.Windows.Forms.Button btn_trainEdit;
        private System.Windows.Forms.Button btn_trainReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Train_dataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}