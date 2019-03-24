namespace Assign5bPizzaOrderRChuIII
{
    partial class frmPizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaOrder));
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.grbPizzaOptions = new System.Windows.Forms.GroupBox();
            this.radNoPizza = new System.Windows.Forms.RadioButton();
            this.radXLrg = new System.Windows.Forms.RadioButton();
            this.radLrg = new System.Windows.Forms.RadioButton();
            this.radMed = new System.Windows.Forms.RadioButton();
            this.nudToppingAmount = new System.Windows.Forms.NumericUpDown();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.grbDrinks = new System.Windows.Forms.GroupBox();
            this.nudWater = new System.Windows.Forms.NumericUpDown();
            this.nudBrisk = new System.Windows.Forms.NumericUpDown();
            this.nudSprite = new System.Windows.Forms.NumericUpDown();
            this.chkDrink4 = new System.Windows.Forms.CheckBox();
            this.chkDrink3 = new System.Windows.Forms.CheckBox();
            this.chkDrink2 = new System.Windows.Forms.CheckBox();
            this.chkDrink1 = new System.Windows.Forms.CheckBox();
            this.nudCoke = new System.Windows.Forms.NumericUpDown();
            this.grbOrderList = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblsubTotal = new System.Windows.Forms.Label();
            this.lblNumDrinks = new System.Windows.Forms.Label();
            this.lblNumToppings = new System.Windows.Forms.Label();
            this.lblSizeChoice = new System.Windows.Forms.Label();
            this.grbProvince = new System.Windows.Forms.GroupBox();
            this.radBritishColumbia = new System.Windows.Forms.RadioButton();
            this.radNewBrunswick = new System.Windows.Forms.RadioButton();
            this.radSaskatchewan = new System.Windows.Forms.RadioButton();
            this.radQuébec = new System.Windows.Forms.RadioButton();
            this.radOntario = new System.Windows.Forms.RadioButton();
            this.radAlberta = new System.Windows.Forms.RadioButton();
            this.chkPizza = new System.Windows.Forms.CheckBox();
            this.chkDrinks = new System.Windows.Forms.CheckBox();
            this.chkToppings = new System.Windows.Forms.CheckBox();
            this.lblPizzaAmountChoice = new System.Windows.Forms.Label();
            this.nudPizzaAmount = new System.Windows.Forms.NumericUpDown();
            this.lblPizzaAmount = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTotalName = new System.Windows.Forms.Label();
            this.grbPizzaOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingAmount)).BeginInit();
            this.grbToppings.SuspendLayout();
            this.grbDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoke)).BeginInit();
            this.grbOrderList.SuspendLayout();
            this.grbProvince.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader1.Location = new System.Drawing.Point(500, 0);
            this.lblHeader1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(478, 117);
            this.lblHeader1.TabIndex = 0;
            this.lblHeader1.Text = "Pizza Order";
            this.lblHeader1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grbPizzaOptions
            // 
            this.grbPizzaOptions.BackColor = System.Drawing.Color.Transparent;
            this.grbPizzaOptions.Controls.Add(this.lblPizzaAmount);
            this.grbPizzaOptions.Controls.Add(this.nudPizzaAmount);
            this.grbPizzaOptions.Controls.Add(this.radNoPizza);
            this.grbPizzaOptions.Controls.Add(this.radXLrg);
            this.grbPizzaOptions.Controls.Add(this.radLrg);
            this.grbPizzaOptions.Controls.Add(this.radMed);
            this.grbPizzaOptions.Enabled = false;
            this.grbPizzaOptions.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPizzaOptions.Location = new System.Drawing.Point(208, 139);
            this.grbPizzaOptions.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grbPizzaOptions.Name = "grbPizzaOptions";
            this.grbPizzaOptions.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grbPizzaOptions.Size = new System.Drawing.Size(452, 129);
            this.grbPizzaOptions.TabIndex = 1;
            this.grbPizzaOptions.TabStop = false;
            this.grbPizzaOptions.Text = "Pizza Options";
            // 
            // radNoPizza
            // 
            this.radNoPizza.AutoSize = true;
            this.radNoPizza.Checked = true;
            this.radNoPizza.Location = new System.Drawing.Point(26, 36);
            this.radNoPizza.Margin = new System.Windows.Forms.Padding(4);
            this.radNoPizza.Name = "radNoPizza";
            this.radNoPizza.Size = new System.Drawing.Size(74, 30);
            this.radNoPizza.TabIndex = 5;
            this.radNoPizza.TabStop = true;
            this.radNoPizza.Text = "None";
            this.radNoPizza.UseVisualStyleBackColor = true;
            this.radNoPizza.CheckedChanged += new System.EventHandler(this.radNoPizza_CheckedChanged);
            // 
            // radXLrg
            // 
            this.radXLrg.AutoSize = true;
            this.radXLrg.Location = new System.Drawing.Point(301, 36);
            this.radXLrg.Margin = new System.Windows.Forms.Padding(4);
            this.radXLrg.Name = "radXLrg";
            this.radXLrg.Size = new System.Drawing.Size(126, 30);
            this.radXLrg.TabIndex = 4;
            this.radXLrg.Text = "Extra Large";
            this.radXLrg.UseVisualStyleBackColor = true;
            this.radXLrg.CheckedChanged += new System.EventHandler(this.radXLrg_OnClicked);
            // 
            // radLrg
            // 
            this.radLrg.AutoSize = true;
            this.radLrg.Location = new System.Drawing.Point(214, 36);
            this.radLrg.Margin = new System.Windows.Forms.Padding(4);
            this.radLrg.Name = "radLrg";
            this.radLrg.Size = new System.Drawing.Size(79, 30);
            this.radLrg.TabIndex = 3;
            this.radLrg.Text = "Large";
            this.radLrg.UseVisualStyleBackColor = true;
            this.radLrg.CheckedChanged += new System.EventHandler(this.radLrg_OnClicked);
            // 
            // radMed
            // 
            this.radMed.AutoSize = true;
            this.radMed.Location = new System.Drawing.Point(108, 36);
            this.radMed.Margin = new System.Windows.Forms.Padding(4);
            this.radMed.Name = "radMed";
            this.radMed.Size = new System.Drawing.Size(98, 30);
            this.radMed.TabIndex = 2;
            this.radMed.Text = "Medium";
            this.radMed.UseVisualStyleBackColor = true;
            this.radMed.CheckedChanged += new System.EventHandler(this.radMed_OnClicked);
            // 
            // nudToppingAmount
            // 
            this.nudToppingAmount.Location = new System.Drawing.Point(26, 55);
            this.nudToppingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nudToppingAmount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudToppingAmount.Name = "nudToppingAmount";
            this.nudToppingAmount.Size = new System.Drawing.Size(156, 33);
            this.nudToppingAmount.TabIndex = 3;
            this.nudToppingAmount.ValueChanged += new System.EventHandler(this.nudToppingAmount_ValueChanged);
            // 
            // grbToppings
            // 
            this.grbToppings.BackColor = System.Drawing.Color.Transparent;
            this.grbToppings.Controls.Add(this.nudToppingAmount);
            this.grbToppings.Enabled = false;
            this.grbToppings.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToppings.Location = new System.Drawing.Point(208, 280);
            this.grbToppings.Margin = new System.Windows.Forms.Padding(4);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Padding = new System.Windows.Forms.Padding(4);
            this.grbToppings.Size = new System.Drawing.Size(260, 131);
            this.grbToppings.TabIndex = 4;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Topping Amount";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Location = new System.Drawing.Point(899, 690);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(193, 155);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Complete Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // grbDrinks
            // 
            this.grbDrinks.BackColor = System.Drawing.Color.Transparent;
            this.grbDrinks.Controls.Add(this.nudWater);
            this.grbDrinks.Controls.Add(this.nudBrisk);
            this.grbDrinks.Controls.Add(this.nudSprite);
            this.grbDrinks.Controls.Add(this.chkDrink4);
            this.grbDrinks.Controls.Add(this.chkDrink3);
            this.grbDrinks.Controls.Add(this.chkDrink2);
            this.grbDrinks.Controls.Add(this.chkDrink1);
            this.grbDrinks.Controls.Add(this.nudCoke);
            this.grbDrinks.Enabled = false;
            this.grbDrinks.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDrinks.Location = new System.Drawing.Point(208, 440);
            this.grbDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.grbDrinks.Name = "grbDrinks";
            this.grbDrinks.Padding = new System.Windows.Forms.Padding(4);
            this.grbDrinks.Size = new System.Drawing.Size(389, 201);
            this.grbDrinks.TabIndex = 6;
            this.grbDrinks.TabStop = false;
            this.grbDrinks.Text = "Drinks";
            // 
            // nudWater
            // 
            this.nudWater.Enabled = false;
            this.nudWater.Location = new System.Drawing.Point(197, 150);
            this.nudWater.Margin = new System.Windows.Forms.Padding(4);
            this.nudWater.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudWater.Name = "nudWater";
            this.nudWater.Size = new System.Drawing.Size(156, 33);
            this.nudWater.TabIndex = 11;
            this.nudWater.ValueChanged += new System.EventHandler(this.nudWater_ValueChanged);
            // 
            // nudBrisk
            // 
            this.nudBrisk.Enabled = false;
            this.nudBrisk.Location = new System.Drawing.Point(198, 110);
            this.nudBrisk.Margin = new System.Windows.Forms.Padding(4);
            this.nudBrisk.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudBrisk.Name = "nudBrisk";
            this.nudBrisk.Size = new System.Drawing.Size(156, 33);
            this.nudBrisk.TabIndex = 10;
            this.nudBrisk.ValueChanged += new System.EventHandler(this.nudBrisk_ValueChanged);
            // 
            // nudSprite
            // 
            this.nudSprite.Enabled = false;
            this.nudSprite.Location = new System.Drawing.Point(198, 72);
            this.nudSprite.Margin = new System.Windows.Forms.Padding(4);
            this.nudSprite.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudSprite.Name = "nudSprite";
            this.nudSprite.Size = new System.Drawing.Size(156, 33);
            this.nudSprite.TabIndex = 9;
            this.nudSprite.ValueChanged += new System.EventHandler(this.nudSprite_ValueChanged);
            // 
            // chkDrink4
            // 
            this.chkDrink4.AutoSize = true;
            this.chkDrink4.Location = new System.Drawing.Point(26, 150);
            this.chkDrink4.Margin = new System.Windows.Forms.Padding(4);
            this.chkDrink4.Name = "chkDrink4";
            this.chkDrink4.Size = new System.Drawing.Size(83, 30);
            this.chkDrink4.TabIndex = 8;
            this.chkDrink4.Text = "Water";
            this.chkDrink4.UseVisualStyleBackColor = true;
            this.chkDrink4.CheckedChanged += new System.EventHandler(this.chkDrink4_OnClicked);
            // 
            // chkDrink3
            // 
            this.chkDrink3.AutoSize = true;
            this.chkDrink3.Location = new System.Drawing.Point(26, 112);
            this.chkDrink3.Margin = new System.Windows.Forms.Padding(4);
            this.chkDrink3.Name = "chkDrink3";
            this.chkDrink3.Size = new System.Drawing.Size(76, 30);
            this.chkDrink3.TabIndex = 7;
            this.chkDrink3.Text = "Brisk";
            this.chkDrink3.UseVisualStyleBackColor = true;
            this.chkDrink3.CheckedChanged += new System.EventHandler(this.chkDrink3_OnClicked);
            // 
            // chkDrink2
            // 
            this.chkDrink2.AutoSize = true;
            this.chkDrink2.Location = new System.Drawing.Point(26, 74);
            this.chkDrink2.Margin = new System.Windows.Forms.Padding(4);
            this.chkDrink2.Name = "chkDrink2";
            this.chkDrink2.Size = new System.Drawing.Size(83, 30);
            this.chkDrink2.TabIndex = 6;
            this.chkDrink2.Text = "Sprite";
            this.chkDrink2.UseVisualStyleBackColor = true;
            this.chkDrink2.CheckedChanged += new System.EventHandler(this.chkDrink2_OnClicked);
            // 
            // chkDrink1
            // 
            this.chkDrink1.AutoSize = true;
            this.chkDrink1.Location = new System.Drawing.Point(26, 34);
            this.chkDrink1.Margin = new System.Windows.Forms.Padding(4);
            this.chkDrink1.Name = "chkDrink1";
            this.chkDrink1.Size = new System.Drawing.Size(75, 30);
            this.chkDrink1.TabIndex = 5;
            this.chkDrink1.Text = "Coke";
            this.chkDrink1.UseVisualStyleBackColor = true;
            this.chkDrink1.CheckedChanged += new System.EventHandler(this.chkDrink1_OnClicked);
            // 
            // nudCoke
            // 
            this.nudCoke.Enabled = false;
            this.nudCoke.Location = new System.Drawing.Point(198, 34);
            this.nudCoke.Margin = new System.Windows.Forms.Padding(4);
            this.nudCoke.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudCoke.Name = "nudCoke";
            this.nudCoke.Size = new System.Drawing.Size(156, 33);
            this.nudCoke.TabIndex = 4;
            this.nudCoke.ValueChanged += new System.EventHandler(this.nudCoke_ValueChanged);
            // 
            // grbOrderList
            // 
            this.grbOrderList.BackColor = System.Drawing.Color.Wheat;
            this.grbOrderList.BackgroundImage = global::Assign5bPizzaOrderRChuIII.Properties.Resources.OrderListBack;
            this.grbOrderList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbOrderList.Controls.Add(this.lblTotalName);
            this.grbOrderList.Controls.Add(this.lblHST);
            this.grbOrderList.Controls.Add(this.lblPizzaAmountChoice);
            this.grbOrderList.Controls.Add(this.lblTotal);
            this.grbOrderList.Controls.Add(this.lblsubTotal);
            this.grbOrderList.Controls.Add(this.lblNumDrinks);
            this.grbOrderList.Controls.Add(this.lblNumToppings);
            this.grbOrderList.Controls.Add(this.lblSizeChoice);
            this.grbOrderList.Location = new System.Drawing.Point(899, 139);
            this.grbOrderList.Margin = new System.Windows.Forms.Padding(4);
            this.grbOrderList.Name = "grbOrderList";
            this.grbOrderList.Padding = new System.Windows.Forms.Padding(4);
            this.grbOrderList.Size = new System.Drawing.Size(424, 528);
            this.grbOrderList.TabIndex = 8;
            this.grbOrderList.TabStop = false;
            this.grbOrderList.Text = "Your Order : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(108, 450);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 34);
            this.lblTotal.TabIndex = 10;
            // 
            // lblsubTotal
            // 
            this.lblsubTotal.AutoSize = true;
            this.lblsubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblsubTotal.Location = new System.Drawing.Point(27, 369);
            this.lblsubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubTotal.Name = "lblsubTotal";
            this.lblsubTotal.Size = new System.Drawing.Size(123, 34);
            this.lblsubTotal.TabIndex = 9;
            this.lblsubTotal.Text = "Subtotal : ";
            // 
            // lblNumDrinks
            // 
            this.lblNumDrinks.AutoSize = true;
            this.lblNumDrinks.BackColor = System.Drawing.Color.Transparent;
            this.lblNumDrinks.Location = new System.Drawing.Point(27, 192);
            this.lblNumDrinks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumDrinks.Name = "lblNumDrinks";
            this.lblNumDrinks.Size = new System.Drawing.Size(215, 204);
            this.lblNumDrinks.TabIndex = 2;
            this.lblNumDrinks.Text = "# of Drinks:\r\n     Coke: 0  ($0.00)\r\n     Sprite: 0 ($0.00)\r\n     Brisk: 0 ($0.00" +
    ")\r\n     Water: 0 ($0.00)\r\n     ";
            // 
            // lblNumToppings
            // 
            this.lblNumToppings.AutoSize = true;
            this.lblNumToppings.BackColor = System.Drawing.Color.Transparent;
            this.lblNumToppings.Location = new System.Drawing.Point(27, 149);
            this.lblNumToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumToppings.Name = "lblNumToppings";
            this.lblNumToppings.Size = new System.Drawing.Size(278, 34);
            this.lblNumToppings.TabIndex = 1;
            this.lblNumToppings.Text = "# of Toppings: 0  ($0.00)";
            // 
            // lblSizeChoice
            // 
            this.lblSizeChoice.AutoSize = true;
            this.lblSizeChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblSizeChoice.Location = new System.Drawing.Point(27, 65);
            this.lblSizeChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSizeChoice.Name = "lblSizeChoice";
            this.lblSizeChoice.Size = new System.Drawing.Size(307, 34);
            this.lblSizeChoice.TabIndex = 0;
            this.lblSizeChoice.Text = "Pizza Size : No Pizza  ($0.00)";
            // 
            // grbProvince
            // 
            this.grbProvince.BackColor = System.Drawing.Color.Transparent;
            this.grbProvince.Controls.Add(this.radBritishColumbia);
            this.grbProvince.Controls.Add(this.radNewBrunswick);
            this.grbProvince.Controls.Add(this.radSaskatchewan);
            this.grbProvince.Controls.Add(this.radQuébec);
            this.grbProvince.Controls.Add(this.radOntario);
            this.grbProvince.Controls.Add(this.radAlberta);
            this.grbProvince.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProvince.Location = new System.Drawing.Point(208, 652);
            this.grbProvince.Margin = new System.Windows.Forms.Padding(4);
            this.grbProvince.Name = "grbProvince";
            this.grbProvince.Padding = new System.Windows.Forms.Padding(4);
            this.grbProvince.Size = new System.Drawing.Size(526, 183);
            this.grbProvince.TabIndex = 9;
            this.grbProvince.TabStop = false;
            this.grbProvince.Text = "Select your Province";
            // 
            // radBritishColumbia
            // 
            this.radBritishColumbia.AutoSize = true;
            this.radBritishColumbia.Location = new System.Drawing.Point(214, 114);
            this.radBritishColumbia.Margin = new System.Windows.Forms.Padding(4);
            this.radBritishColumbia.Name = "radBritishColumbia";
            this.radBritishColumbia.Size = new System.Drawing.Size(176, 30);
            this.radBritishColumbia.TabIndex = 15;
            this.radBritishColumbia.TabStop = true;
            this.radBritishColumbia.Text = "British Columbia ";
            this.radBritishColumbia.UseVisualStyleBackColor = true;
            this.radBritishColumbia.CheckedChanged += new System.EventHandler(this.radBritishColumbia_CheckedChanged);
            // 
            // radNewBrunswick
            // 
            this.radNewBrunswick.AutoSize = true;
            this.radNewBrunswick.Location = new System.Drawing.Point(214, 76);
            this.radNewBrunswick.Margin = new System.Windows.Forms.Padding(4);
            this.radNewBrunswick.Name = "radNewBrunswick";
            this.radNewBrunswick.Size = new System.Drawing.Size(161, 30);
            this.radNewBrunswick.TabIndex = 14;
            this.radNewBrunswick.TabStop = true;
            this.radNewBrunswick.Text = "New-Brunswick";
            this.radNewBrunswick.UseVisualStyleBackColor = true;
            this.radNewBrunswick.CheckedChanged += new System.EventHandler(this.radNewBrunswick_CheckedChanged);
            // 
            // radSaskatchewan
            // 
            this.radSaskatchewan.AutoSize = true;
            this.radSaskatchewan.Location = new System.Drawing.Point(214, 38);
            this.radSaskatchewan.Margin = new System.Windows.Forms.Padding(4);
            this.radSaskatchewan.Name = "radSaskatchewan";
            this.radSaskatchewan.Size = new System.Drawing.Size(156, 30);
            this.radSaskatchewan.TabIndex = 13;
            this.radSaskatchewan.TabStop = true;
            this.radSaskatchewan.Text = "Saskatchewan";
            this.radSaskatchewan.UseVisualStyleBackColor = true;
            this.radSaskatchewan.CheckedChanged += new System.EventHandler(this.radSaskatchewan_CheckedChanged);
            // 
            // radQuébec
            // 
            this.radQuébec.AutoSize = true;
            this.radQuébec.Location = new System.Drawing.Point(26, 116);
            this.radQuébec.Margin = new System.Windows.Forms.Padding(4);
            this.radQuébec.Name = "radQuébec";
            this.radQuébec.Size = new System.Drawing.Size(95, 30);
            this.radQuébec.TabIndex = 12;
            this.radQuébec.TabStop = true;
            this.radQuébec.Text = "Québec";
            this.radQuébec.UseVisualStyleBackColor = true;
            this.radQuébec.CheckedChanged += new System.EventHandler(this.radQuébec_CheckedChanged);
            // 
            // radOntario
            // 
            this.radOntario.AutoSize = true;
            this.radOntario.Location = new System.Drawing.Point(26, 76);
            this.radOntario.Margin = new System.Windows.Forms.Padding(4);
            this.radOntario.Name = "radOntario";
            this.radOntario.Size = new System.Drawing.Size(93, 30);
            this.radOntario.TabIndex = 10;
            this.radOntario.TabStop = true;
            this.radOntario.Text = "Ontario";
            this.radOntario.UseVisualStyleBackColor = true;
            this.radOntario.CheckedChanged += new System.EventHandler(this.radOntario_CheckedChanged);
            // 
            // radAlberta
            // 
            this.radAlberta.AutoSize = true;
            this.radAlberta.Location = new System.Drawing.Point(26, 38);
            this.radAlberta.Margin = new System.Windows.Forms.Padding(4);
            this.radAlberta.Name = "radAlberta";
            this.radAlberta.Size = new System.Drawing.Size(92, 30);
            this.radAlberta.TabIndex = 11;
            this.radAlberta.TabStop = true;
            this.radAlberta.Text = "Alberta";
            this.radAlberta.UseVisualStyleBackColor = true;
            this.radAlberta.CheckedChanged += new System.EventHandler(this.radAlberta_CheckedChanged);
            // 
            // chkPizza
            // 
            this.chkPizza.AutoSize = true;
            this.chkPizza.BackColor = System.Drawing.Color.Transparent;
            this.chkPizza.Location = new System.Drawing.Point(58, 139);
            this.chkPizza.Name = "chkPizza";
            this.chkPizza.Size = new System.Drawing.Size(101, 38);
            this.chkPizza.TabIndex = 11;
            this.chkPizza.Text = "Pizza?";
            this.chkPizza.UseVisualStyleBackColor = false;
            this.chkPizza.CheckedChanged += new System.EventHandler(this.chkPizza_CheckedChanged);
            // 
            // chkDrinks
            // 
            this.chkDrinks.AutoSize = true;
            this.chkDrinks.BackColor = System.Drawing.Color.Transparent;
            this.chkDrinks.Location = new System.Drawing.Point(70, 447);
            this.chkDrinks.Name = "chkDrinks";
            this.chkDrinks.Size = new System.Drawing.Size(120, 38);
            this.chkDrinks.TabIndex = 12;
            this.chkDrinks.Text = "Drinks?";
            this.chkDrinks.UseVisualStyleBackColor = false;
            this.chkDrinks.CheckedChanged += new System.EventHandler(this.chkDrinks_CheckedChanged);
            // 
            // chkToppings
            // 
            this.chkToppings.AutoSize = true;
            this.chkToppings.BackColor = System.Drawing.Color.Transparent;
            this.chkToppings.Enabled = false;
            this.chkToppings.Location = new System.Drawing.Point(58, 281);
            this.chkToppings.Name = "chkToppings";
            this.chkToppings.Size = new System.Drawing.Size(150, 38);
            this.chkToppings.TabIndex = 14;
            this.chkToppings.Text = "Toppings?";
            this.chkToppings.UseVisualStyleBackColor = false;
            this.chkToppings.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // lblPizzaAmountChoice
            // 
            this.lblPizzaAmountChoice.AutoSize = true;
            this.lblPizzaAmountChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblPizzaAmountChoice.Location = new System.Drawing.Point(31, 103);
            this.lblPizzaAmountChoice.Name = "lblPizzaAmountChoice";
            this.lblPizzaAmountChoice.Size = new System.Drawing.Size(242, 34);
            this.lblPizzaAmountChoice.TabIndex = 11;
            this.lblPizzaAmountChoice.Text = "# of Pizzas: 0  ($0.00)";
            // 
            // nudPizzaAmount
            // 
            this.nudPizzaAmount.Location = new System.Drawing.Point(140, 83);
            this.nudPizzaAmount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPizzaAmount.Name = "nudPizzaAmount";
            this.nudPizzaAmount.Size = new System.Drawing.Size(120, 33);
            this.nudPizzaAmount.TabIndex = 6;
            this.nudPizzaAmount.ValueChanged += new System.EventHandler(this.nudPizzaAmount_ValueChanged);
            // 
            // lblPizzaAmount
            // 
            this.lblPizzaAmount.AutoSize = true;
            this.lblPizzaAmount.Location = new System.Drawing.Point(21, 85);
            this.lblPizzaAmount.Name = "lblPizzaAmount";
            this.lblPizzaAmount.Size = new System.Drawing.Size(113, 26);
            this.lblPizzaAmount.TabIndex = 7;
            this.lblPizzaAmount.Text = "# of Pizzas : ";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.BackColor = System.Drawing.Color.Transparent;
            this.lblHST.Location = new System.Drawing.Point(28, 414);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(71, 34);
            this.lblHST.TabIndex = 8;
            this.lblHST.Text = "HST : ";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(1136, 690);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(187, 155);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Re-Do Order";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTotalName
            // 
            this.lblTotalName.AutoSize = true;
            this.lblTotalName.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalName.Location = new System.Drawing.Point(27, 450);
            this.lblTotalName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalName.Name = "lblTotalName";
            this.lblTotalName.Size = new System.Drawing.Size(85, 34);
            this.lblTotalName.TabIndex = 12;
            this.lblTotalName.Text = "Total : ";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assign5bPizzaOrderRChuIII.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 857);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.chkToppings);
            this.Controls.Add(this.chkDrinks);
            this.Controls.Add(this.chkPizza);
            this.Controls.Add(this.grbProvince);
            this.Controls.Add(this.grbOrderList);
            this.Controls.Add(this.grbDrinks);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbPizzaOptions);
            this.Controls.Add(this.lblHeader1);
            this.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "frmPizzaOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Your Pizza Today!! Romy I. Chu III";
            this.grbPizzaOptions.ResumeLayout(false);
            this.grbPizzaOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingAmount)).EndInit();
            this.grbToppings.ResumeLayout(false);
            this.grbDrinks.ResumeLayout(false);
            this.grbDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoke)).EndInit();
            this.grbOrderList.ResumeLayout(false);
            this.grbOrderList.PerformLayout();
            this.grbProvince.ResumeLayout(false);
            this.grbProvince.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.GroupBox grbPizzaOptions;
        private System.Windows.Forms.RadioButton radXLrg;
        private System.Windows.Forms.RadioButton radLrg;
        private System.Windows.Forms.RadioButton radNoPizza;
        private System.Windows.Forms.NumericUpDown nudToppingAmount;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.RadioButton radMed;
        private System.Windows.Forms.GroupBox grbDrinks;
        private System.Windows.Forms.NumericUpDown nudCoke;
        private System.Windows.Forms.NumericUpDown nudWater;
        private System.Windows.Forms.NumericUpDown nudBrisk;
        private System.Windows.Forms.NumericUpDown nudSprite;
        private System.Windows.Forms.CheckBox chkDrink4;
        private System.Windows.Forms.CheckBox chkDrink3;
        private System.Windows.Forms.CheckBox chkDrink2;
        private System.Windows.Forms.CheckBox chkDrink1;
        private System.Windows.Forms.GroupBox grbOrderList;
        private System.Windows.Forms.Label lblSizeChoice;
        private System.Windows.Forms.Label lblNumDrinks;
        private System.Windows.Forms.Label lblNumToppings;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblsubTotal;
        private System.Windows.Forms.GroupBox grbProvince;
        private System.Windows.Forms.RadioButton radBritishColumbia;
        private System.Windows.Forms.RadioButton radNewBrunswick;
        private System.Windows.Forms.RadioButton radSaskatchewan;
        private System.Windows.Forms.RadioButton radQuébec;
        private System.Windows.Forms.RadioButton radOntario;
        private System.Windows.Forms.RadioButton radAlberta;
        private System.Windows.Forms.CheckBox chkPizza;
        private System.Windows.Forms.CheckBox chkDrinks;
        private System.Windows.Forms.CheckBox chkToppings;
        private System.Windows.Forms.Label lblPizzaAmountChoice;
        private System.Windows.Forms.Label lblPizzaAmount;
        private System.Windows.Forms.NumericUpDown nudPizzaAmount;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTotalName;
    }
}

