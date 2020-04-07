namespace KLineDataConverter
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btGo = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.sfDialog = new System.Windows.Forms.SaveFileDialog();
            this.txtSaveWeek = new System.Windows.Forms.TextBox();
            this.btSaveWeek = new System.Windows.Forms.Button();
            this.sfDialogWeek = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(430, 193);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(75, 23);
            this.btGo.TabIndex = 0;
            this.btGo.Text = "執行";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(528, 39);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(102, 34);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "原檔 (.xls)";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(528, 79);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(102, 37);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "存檔(月)";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(56, 48);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.ReadOnly = true;
            this.txtOpen.Size = new System.Drawing.Size(466, 25);
            this.txtOpen.TabIndex = 3;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(56, 91);
            this.txtSave.Name = "txtSave";
            this.txtSave.ReadOnly = true;
            this.txtSave.Size = new System.Drawing.Size(466, 25);
            this.txtSave.TabIndex = 4;
            // 
            // ofDialog
            // 
            this.ofDialog.FileName = "openFileDialog1";
            this.ofDialog.Filter = "Excel 檔案|*.xls";
            // 
            // sfDialog
            // 
            this.sfDialog.Filter = "CSV 檔案|*.csv";
            // 
            // txtSaveWeek
            // 
            this.txtSaveWeek.Location = new System.Drawing.Point(56, 133);
            this.txtSaveWeek.Name = "txtSaveWeek";
            this.txtSaveWeek.ReadOnly = true;
            this.txtSaveWeek.Size = new System.Drawing.Size(466, 25);
            this.txtSaveWeek.TabIndex = 6;
            // 
            // btSaveWeek
            // 
            this.btSaveWeek.Location = new System.Drawing.Point(528, 122);
            this.btSaveWeek.Name = "btSaveWeek";
            this.btSaveWeek.Size = new System.Drawing.Size(102, 36);
            this.btSaveWeek.TabIndex = 5;
            this.btSaveWeek.Text = "存檔(週)";
            this.btSaveWeek.UseVisualStyleBackColor = true;
            this.btSaveWeek.Click += new System.EventHandler(this.btSaveWeek_Click);
            // 
            // sfDialogWeek
            // 
            this.sfDialogWeek.Filter = "CSV 檔案|*.csv";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 243);
            this.Controls.Add(this.txtSaveWeek);
            this.Controls.Add(this.btSaveWeek);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btGo);
            this.Name = "Main";
            this.Text = "轉換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.SaveFileDialog sfDialog;
        private System.Windows.Forms.TextBox txtSaveWeek;
        private System.Windows.Forms.Button btSaveWeek;
        private System.Windows.Forms.SaveFileDialog sfDialogWeek;
    }
}

