
namespace CovidPatientTrackingSystem
{
    partial class CovidPatientRecord
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
            this.View = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewDB = new System.Windows.Forms.Button();
            this.NewPatient = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.SaveRecord = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.SearchPhone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
            // 
            // View
            // 
            this.View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.View.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View.Location = new System.Drawing.Point(78, 101);
            this.View.Name = "View";
            this.View.RowTemplate.Height = 25;
            this.View.Size = new System.Drawing.Size(625, 192);
            this.View.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Covid Patient Tracking System";
            // 
            // ViewDB
            // 
            this.ViewDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ViewDB.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewDB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewDB.Location = new System.Drawing.Point(343, 327);
            this.ViewDB.Name = "ViewDB";
            this.ViewDB.Size = new System.Drawing.Size(103, 31);
            this.ViewDB.TabIndex = 2;
            this.ViewDB.Text = "View Database";
            this.ViewDB.UseVisualStyleBackColor = false;
            this.ViewDB.Click += new System.EventHandler(this.ViewDB_Click);
            // 
            // NewPatient
            // 
            this.NewPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NewPatient.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPatient.Location = new System.Drawing.Point(78, 376);
            this.NewPatient.Name = "NewPatient";
            this.NewPatient.Size = new System.Drawing.Size(96, 32);
            this.NewPatient.TabIndex = 3;
            this.NewPatient.Text = "New Patient";
            this.NewPatient.UseVisualStyleBackColor = false;
            this.NewPatient.Click += new System.EventHandler(this.NewPatient_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Edit.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Edit.Location = new System.Drawing.Point(216, 376);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(100, 32);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Edit Record";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // SaveRecord
            // 
            this.SaveRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaveRecord.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveRecord.Location = new System.Drawing.Point(476, 376);
            this.SaveRecord.Name = "SaveRecord";
            this.SaveRecord.Size = new System.Drawing.Size(92, 32);
            this.SaveRecord.TabIndex = 5;
            this.SaveRecord.Text = "Save Record";
            this.SaveRecord.UseVisualStyleBackColor = false;
            this.SaveRecord.Click += new System.EventHandler(this.SaveRecord_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteRecord.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteRecord.Location = new System.Drawing.Point(611, 376);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(92, 32);
            this.DeleteRecord.TabIndex = 6;
            this.DeleteRecord.Text = "Delete Record";
            this.DeleteRecord.UseVisualStyleBackColor = false;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(216, 441);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PlaceholderText = "Enter Patient Name or Phone Number";
            this.SearchBox.Size = new System.Drawing.Size(352, 23);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.TextChanged += new System.EventHandler(this.PID_TextChanged);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Search.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Search.Location = new System.Drawing.Point(216, 485);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(161, 31);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search by Name";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchPhone
            // 
            this.SearchPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SearchPhone.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchPhone.Location = new System.Drawing.Point(423, 485);
            this.SearchPhone.Name = "SearchPhone";
            this.SearchPhone.Size = new System.Drawing.Size(145, 31);
            this.SearchPhone.TabIndex = 10;
            this.SearchPhone.Text = "Search by Phone";
            this.SearchPhone.UseVisualStyleBackColor = false;
            this.SearchPhone.Click += new System.EventHandler(this.button2_Click);
            // 
            // CovidPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.SearchPhone);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.SaveRecord);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.NewPatient);
            this.Controls.Add(this.ViewDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.View);
            this.Name = "CovidPatientRecord";
            this.Text = "CovidPatientRecord";
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewDB;
        private System.Windows.Forms.Button NewPatient;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button SaveRecord;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button SearchPhone;
    }
}

