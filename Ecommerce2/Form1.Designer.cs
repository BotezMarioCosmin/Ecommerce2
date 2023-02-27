namespace Ecommerce2
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelToday = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelCreateProduct = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateBack = new System.Windows.Forms.Button();
            this.buttonCreateNext = new System.Windows.Forms.Button();
            this.textBoxCreatePrice = new System.Windows.Forms.TextBox();
            this.labelCreatePrice = new System.Windows.Forms.Label();
            this.textBoxCreateName = new System.Windows.Forms.TextBox();
            this.textBoxCreateManufacturer = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxCreateId = new System.Windows.Forms.TextBox();
            this.labelCreateDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCreateType = new System.Windows.Forms.Label();
            this.labelCreateProduct = new System.Windows.Forms.Label();
            this.comboBoxProductTypes = new System.Windows.Forms.ComboBox();
            this.panelAdditional = new System.Windows.Forms.Panel();
            this.textBoxAdditional2 = new System.Windows.Forms.TextBox();
            this.textBoxAdditional = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCreateProduct.SuspendLayout();
            this.panelAdditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(873, 421);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Manufacturer";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 140;
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToday.Location = new System.Drawing.Point(723, 43);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(197, 29);
            this.labelToday.TabIndex = 5;
            this.labelToday.Text = "Today: dd/MM/yy";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(47, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(188, 63);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Create Product";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelCreateProduct
            // 
            this.panelCreateProduct.Controls.Add(this.label5);
            this.panelCreateProduct.Controls.Add(this.buttonCreateBack);
            this.panelCreateProduct.Controls.Add(this.buttonCreateNext);
            this.panelCreateProduct.Controls.Add(this.textBoxCreatePrice);
            this.panelCreateProduct.Controls.Add(this.labelCreatePrice);
            this.panelCreateProduct.Controls.Add(this.textBoxCreateName);
            this.panelCreateProduct.Controls.Add(this.textBoxCreateManufacturer);
            this.panelCreateProduct.Controls.Add(this.richTextBox1);
            this.panelCreateProduct.Controls.Add(this.textBoxCreateId);
            this.panelCreateProduct.Controls.Add(this.labelCreateDescription);
            this.panelCreateProduct.Controls.Add(this.label3);
            this.panelCreateProduct.Controls.Add(this.label2);
            this.panelCreateProduct.Controls.Add(this.label1);
            this.panelCreateProduct.Controls.Add(this.labelCreateType);
            this.panelCreateProduct.Controls.Add(this.labelCreateProduct);
            this.panelCreateProduct.Controls.Add(this.comboBoxProductTypes);
            this.panelCreateProduct.Location = new System.Drawing.Point(555, 163);
            this.panelCreateProduct.Name = "panelCreateProduct";
            this.panelCreateProduct.Size = new System.Drawing.Size(954, 526);
            this.panelCreateProduct.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 16;
            // 
            // buttonCreateBack
            // 
            this.buttonCreateBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateBack.Location = new System.Drawing.Point(3, 2);
            this.buttonCreateBack.Name = "buttonCreateBack";
            this.buttonCreateBack.Size = new System.Drawing.Size(144, 50);
            this.buttonCreateBack.TabIndex = 15;
            this.buttonCreateBack.Text = "Back";
            this.buttonCreateBack.UseVisualStyleBackColor = false;
            this.buttonCreateBack.Click += new System.EventHandler(this.buttonCreateBack_Click);
            // 
            // buttonCreateNext
            // 
            this.buttonCreateNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNext.Location = new System.Drawing.Point(807, 5);
            this.buttonCreateNext.Name = "buttonCreateNext";
            this.buttonCreateNext.Size = new System.Drawing.Size(144, 50);
            this.buttonCreateNext.TabIndex = 8;
            this.buttonCreateNext.Text = "Next";
            this.buttonCreateNext.UseVisualStyleBackColor = false;
            this.buttonCreateNext.Click += new System.EventHandler(this.buttonCreateNext_Click);
            // 
            // textBoxCreatePrice
            // 
            this.textBoxCreatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreatePrice.Location = new System.Drawing.Point(91, 442);
            this.textBoxCreatePrice.Name = "textBoxCreatePrice";
            this.textBoxCreatePrice.Size = new System.Drawing.Size(396, 35);
            this.textBoxCreatePrice.TabIndex = 14;
            // 
            // labelCreatePrice
            // 
            this.labelCreatePrice.AutoSize = true;
            this.labelCreatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatePrice.Location = new System.Drawing.Point(10, 448);
            this.labelCreatePrice.Name = "labelCreatePrice";
            this.labelCreatePrice.Size = new System.Drawing.Size(75, 29);
            this.labelCreatePrice.TabIndex = 13;
            this.labelCreatePrice.Text = "Price:";
            // 
            // textBoxCreateName
            // 
            this.textBoxCreateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreateName.Location = new System.Drawing.Point(100, 359);
            this.textBoxCreateName.Name = "textBoxCreateName";
            this.textBoxCreateName.Size = new System.Drawing.Size(387, 35);
            this.textBoxCreateName.TabIndex = 12;
            // 
            // textBoxCreateManufacturer
            // 
            this.textBoxCreateManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreateManufacturer.Location = new System.Drawing.Point(174, 275);
            this.textBoxCreateManufacturer.Name = "textBoxCreateManufacturer";
            this.textBoxCreateManufacturer.Size = new System.Drawing.Size(313, 35);
            this.textBoxCreateManufacturer.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(516, 147);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(428, 330);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // textBoxCreateId
            // 
            this.textBoxCreateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCreateId.Location = new System.Drawing.Point(55, 198);
            this.textBoxCreateId.Name = "textBoxCreateId";
            this.textBoxCreateId.Size = new System.Drawing.Size(432, 35);
            this.textBoxCreateId.TabIndex = 7;
            // 
            // labelCreateDescription
            // 
            this.labelCreateDescription.AutoSize = true;
            this.labelCreateDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateDescription.Location = new System.Drawing.Point(625, 114);
            this.labelCreateDescription.Name = "labelCreateDescription";
            this.labelCreateDescription.Size = new System.Drawing.Size(249, 29);
            this.labelCreateDescription.TabIndex = 6;
            this.labelCreateDescription.Text = "Description (optional):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manufacturer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // labelCreateType
            // 
            this.labelCreateType.AutoSize = true;
            this.labelCreateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateType.Location = new System.Drawing.Point(10, 114);
            this.labelCreateType.Name = "labelCreateType";
            this.labelCreateType.Size = new System.Drawing.Size(74, 29);
            this.labelCreateType.TabIndex = 2;
            this.labelCreateType.Text = "Type:";
            // 
            // labelCreateProduct
            // 
            this.labelCreateProduct.AutoSize = true;
            this.labelCreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateProduct.Location = new System.Drawing.Point(375, 8);
            this.labelCreateProduct.Name = "labelCreateProduct";
            this.labelCreateProduct.Size = new System.Drawing.Size(232, 37);
            this.labelCreateProduct.TabIndex = 1;
            this.labelCreateProduct.Text = "Create Product";
            // 
            // comboBoxProductTypes
            // 
            this.comboBoxProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductTypes.FormattingEnabled = true;
            this.comboBoxProductTypes.Location = new System.Drawing.Point(90, 111);
            this.comboBoxProductTypes.Name = "comboBoxProductTypes";
            this.comboBoxProductTypes.Size = new System.Drawing.Size(397, 37);
            this.comboBoxProductTypes.TabIndex = 0;
            // 
            // panelAdditional
            // 
            this.panelAdditional.Controls.Add(this.textBoxAdditional2);
            this.panelAdditional.Controls.Add(this.textBoxAdditional);
            this.panelAdditional.Controls.Add(this.buttonCreate);
            this.panelAdditional.Controls.Add(this.label4);
            this.panelAdditional.Location = new System.Drawing.Point(683, 29);
            this.panelAdditional.Name = "panelAdditional";
            this.panelAdditional.Size = new System.Drawing.Size(954, 526);
            this.panelAdditional.TabIndex = 17;
            // 
            // textBoxAdditional2
            // 
            this.textBoxAdditional2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdditional2.Location = new System.Drawing.Point(303, 263);
            this.textBoxAdditional2.Name = "textBoxAdditional2";
            this.textBoxAdditional2.Size = new System.Drawing.Size(333, 39);
            this.textBoxAdditional2.TabIndex = 3;
            // 
            // textBoxAdditional
            // 
            this.textBoxAdditional.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdditional.Location = new System.Drawing.Point(109, 208);
            this.textBoxAdditional.Name = "textBoxAdditional";
            this.textBoxAdditional.Size = new System.Drawing.Size(734, 39);
            this.textBoxAdditional.TabIndex = 2;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(349, 347);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(245, 51);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Additional";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.panelAdditional);
            this.Controls.Add(this.panelCreateProduct);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCreateProduct.ResumeLayout(false);
            this.panelCreateProduct.PerformLayout();
            this.panelAdditional.ResumeLayout(false);
            this.panelAdditional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelCreateProduct;
        private System.Windows.Forms.Label labelCreateType;
        private System.Windows.Forms.Label labelCreateProduct;
        private System.Windows.Forms.ComboBox comboBoxProductTypes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxCreateId;
        private System.Windows.Forms.Label labelCreateDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCreateName;
        private System.Windows.Forms.TextBox textBoxCreateManufacturer;
        private System.Windows.Forms.Button buttonCreateBack;
        private System.Windows.Forms.Button buttonCreateNext;
        private System.Windows.Forms.TextBox textBoxCreatePrice;
        private System.Windows.Forms.Label labelCreatePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelAdditional;
        private System.Windows.Forms.TextBox textBoxAdditional;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdditional2;
    }
}

