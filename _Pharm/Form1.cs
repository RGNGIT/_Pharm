using _Pharm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _Pharm
{
    public partial class Form1 : Form
    {

        Storage storage;

        public Form1()
        {
            InitializeComponent();
            storage = new Storage();
            #region OnBoot
            dataGridViewDrugToChoose.Columns.Add("_name", "Название");
            dataGridViewPerpeturalCustomers.Columns.Add("_FIO", "ФИО");
            dataGridViewPerpeturalCustomers.Columns.Add("_DOB", "Дата рождения");
            dataGridViewPerpeturalCustomers.Columns.Add("_phone", "Телефон");
            dataGridViewPerpeturalCustomers.Columns.Add("_email", "Мыло");
            dataGridViewPerpeturalCustomers.Columns.Add("_disco", "Дисконтная карта");
            dataGridViewPerpeturalCustomers.Columns.Add("_drugs", "Перечень лекарств");
            dataGridViewCouriers.Columns.Add("_name", "Имя");
            dataGridViewCouriers.Columns.Add("_deliveryCount", "Количество доставок");
            dataGridViewDeliveries.Columns.Add("_date", "Дата заказа");
            dataGridViewDeliveries.Columns.Add("_name", "Название");
            dataGridViewDeliveries.Columns.Add("_addr", "Адрес");
            dataGridViewDeliveries.Columns.Add("_FIOC", "ФИО клиента");
            dataGridViewDeliveries.Columns.Add("_namec", "Имя курьера");
            dataGridViewDeliveries.Columns.Add("_drugs", "Перечень лекарств");
            dataGridViewDeliveries.Columns.Add("_price", "Сумма заказа");
            dataGridViewDeliveryDrugs.Columns.Add("_name", "Название");
            dataGridViewIncome.Columns.Add("_date", "Дата");
            dataGridViewIncome.Columns.Add("_name", "Название");
            dataGridViewIncome.Columns.Add("_addr", "Адрес");
            dataGridViewIncome.Columns.Add("_date", "Дата");
            dataGridViewIncome.Columns.Add("_drug", "Лекарство");
            dataGridViewIncome.Columns.Add("_amount", "Количество");
            commonGridSetup(dataGridViewTablets, setupTabletsGrid);
            commonGridSetup(dataGridViewSuspension, setupSuspensionGrid);
            commonGridSetup(dataGridViewCream, setupCreamGrid);
            commonGridSetup(dataGridViewSpray, setupSprayGrid);
            commonGridSetup(dataGridViewSearch);
            checkBoxIsPerpetural.Checked = false;
            #endregion boot
        }

        void commonGridSetup(DataGridView grid, Action additionalGridSetup = null)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.Columns.Add("_name", "Название");
            grid.Columns.Add("_method", "Метод использования");
            grid.Columns.Add("_dose", "Доза");
            grid.Columns.Add("_group", "Группа");
            grid.Columns.Add("_price", "Цена");
            grid.Columns.Add("_date", "Годен до");
            grid.Columns.Add("_amount", "Количество");
            if(additionalGridSetup != null)
            {
                additionalGridSetup();
            }
        }

        void setupTabletsGrid()
        {
            dataGridViewTablets.Columns.Add("_form", "Форма");
            dataGridViewTablets.Columns.Add("_type", "Тип");
        }

        Tablets newTablets(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group, string form, string kind, int amount)
        {
            return new Tablets(
                timeUntil, 
                name, 
                usageMethod, 
                dose, 
                price, 
                group, 
                form, 
                kind,
                amount
            );
        }

        void setupSuspensionGrid()
        {
            dataGridViewSuspension.Columns.Add("_type", "Тип");
        }

        Suspension newSuspension(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group, string kind, int amount)
        {
            return new Suspension(
                timeUntil, 
                name, 
                usageMethod, 
                dose, 
                price, 
                group, 
                kind,
                amount
            );
        }

        void setupCreamGrid()
        {
            dataGridViewCream.Columns.Add("_isHot", "Согревающая");
            dataGridViewCream.Columns.Add("_cumZone", "Зона применения");
        }

        Cream newCream(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group, bool isHot, string zone, int amount)
        {
            return new Cream(
                timeUntil, 
                name, 
                usageMethod, 
                dose, 
                price, 
                group, 
                isHot, 
                zone,
                amount
            );
        }

        void setupSprayGrid()
        {
            dataGridViewSpray.Columns.Add("_zone", "Зона применения");
        }

        Spray newSpray(DateTime timeUntil, string name, string usageMethod, double dose, double price, string group, string zone, int amount)
        {
            return new Spray(
                timeUntil, 
                name, 
                usageMethod, 
                dose, 
                price, 
                group, 
                zone,
                amount
            );
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            int drugTypeSelected = tabControlDrugType.SelectedIndex;
            switch(drugTypeSelected)
            {
                case 0:
                    storage.Drugs.Add(newTablets(
                        dateTimePickerDrugDate.Value, 
                        textBoxDrugName.Text, 
                        textBoxDrugUsageMethod.Text, 
                        Convert.ToDouble(textBoxDrugDose.Text),
                        Convert.ToDouble(textBoxDrugPrice.Text),
                        textBoxDrugGroup.Text,
                        textBoxTabletForm.Text,
                        textBoxTabletKind.Text,
                        Convert.ToInt32(textBoxAmount.Text)
                    ));
                    break;
                case 1:
                    storage.Drugs.Add(newSuspension(
                        dateTimePickerDrugDate.Value,
                        textBoxDrugName.Text,
                        textBoxDrugUsageMethod.Text,
                        Convert.ToDouble(textBoxDrugDose.Text),
                        Convert.ToDouble(textBoxDrugPrice.Text),
                        textBoxDrugGroup.Text,
                        textBoxSuspensionType.Text,
                        Convert.ToInt32(textBoxAmount.Text)
                    ));
                    break;
                case 2:
                    storage.Drugs.Add(newCream(
                        dateTimePickerDrugDate.Value,
                        textBoxDrugName.Text,
                        textBoxDrugUsageMethod.Text,
                        Convert.ToDouble(textBoxDrugDose.Text),
                        Convert.ToDouble(textBoxDrugPrice.Text),
                        textBoxDrugGroup.Text,
                        checkBoxIsHot.Checked,
                        textBoxCumZone.Text,
                        Convert.ToInt32(textBoxAmount.Text)
                    ));
                    break;
                case 3:
                    storage.Drugs.Add(newSpray(
                        dateTimePickerDrugDate.Value,
                        textBoxDrugName.Text,
                        textBoxDrugUsageMethod.Text,
                        Convert.ToDouble(textBoxDrugDose.Text),
                        Convert.ToDouble(textBoxDrugPrice.Text),
                        textBoxDrugGroup.Text,
                        textBoxSprayZone.Text,
                        Convert.ToInt32(textBoxAmount.Text)
                    ));
                    break;
            }
            storage.ShitSort();
            refreshDrugToChooseGrid();
        }

        void refreshGrids()
        {
            dataGridViewTablets.Rows.Clear();
            dataGridViewSuspension.Rows.Clear();
            dataGridViewCream.Rows.Clear();
            dataGridViewSpray.Rows.Clear();
            foreach(var drug in storage.Drugs)
            {
                switch(drug.GetType().Name)
                {
                    case "Tablets":
                        dataGridViewTablets.Rows.Add(
                            drug.name, 
                            drug.usageMethod, 
                            drug.dose, 
                            drug.group, 
                            drug.price, 
                            drug.timeUntil.ToString(),
                            drug.amount,
                            ((Tablets)drug).form, 
                            ((Tablets)drug).kind
                        );
                        break;
                    case "Suspension":
                        dataGridViewSuspension.Rows.Add(
                            drug.name,
                            drug.usageMethod,
                            drug.dose,
                            drug.group,
                            drug.price,
                            drug.timeUntil.ToString(),
                            drug.amount,
                            ((Suspension)drug).kind
                        );
                        break;
                    case "Cream":
                        dataGridViewCream.Rows.Add(
                            drug.name,
                            drug.usageMethod,
                            drug.dose,
                            drug.group,
                            drug.price,
                            drug.timeUntil.ToString(),
                            drug.amount,
                            ((Cream)drug).isHot ? "Да" : "Нет",
                            ((Cream)drug).zone
                        );
                        break;
                    case "Spray":
                        dataGridViewSpray.Rows.Add(
                            drug.name,
                            drug.usageMethod,
                            drug.dose,
                            drug.group,
                            drug.price,
                            drug.timeUntil.ToString(),
                            drug.amount,
                            ((Spray)drug).zone
                        );
                        break;
                }
            }
        }

        void refreshCustomerGrid()
        {
            dataGridViewPerpeturalCustomers.Rows.Clear();
            foreach(var customer in storage.Customers)
            {
                string belovedDrugs = "";
                if(customer.GetType().Name == "PerperturalCustomer")
                {
                    foreach(var drug in ((PerperturalCustomer)customer).drugs)
                    {
                        belovedDrugs += $"{drug.name}, ";
                    }
                }
                dataGridViewPerpeturalCustomers.Rows.Add(
                    customer.FIO, 
                    customer.DOB, 
                    customer.phone, 
                    customer.email, 
                    customer.GetType().Name == "PerperturalCustomer" ? ((PerperturalCustomer)customer).discountNumber : "Не постоянный",
                    customer.GetType().Name == "PerperturalCustomer" ? belovedDrugs : "Не постоянный");
            }
        }

        void refreshCouriersGrid()
        {
            dataGridViewCouriers.Rows.Clear();
            foreach(Courier courier in storage.Couriers)
            {
                dataGridViewCouriers.Rows.Add(courier.name, courier.deliveryAmount);
            }
        }

        void refreshComboBoxes()
        {
            comboBoxClients.Items.Clear();
            comboBoxCouriers.Items.Clear();
            foreach (var customer in storage.Customers)
            {
                comboBoxClients.Items.Add(customer.FIO);
            }
            foreach(var courier in storage.Couriers)
            {
                comboBoxCouriers.Items.Add(courier.name);
            }
        }

        void refreshIncomeCombo()
        {
            comboBoxDrugToOrder.Items.Clear();
            foreach(var drug in storage.Drugs)
            {
                comboBoxDrugToOrder.Items.Add(drug.name);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewTablets.Rows.Clear();
            dataGridViewCream.Rows.Clear();
            dataGridViewSpray.Rows.Clear();
            dataGridViewSuspension.Rows.Clear();
            switch(tabControl1.SelectedIndex)
            {
                case 1: refreshGrids(); break;
                case 2: refreshCustomerGrid(); break;
                case 3: refreshComboBoxes(); refreshDeliveryGrid(); break;
                case 4: refreshIncomeCombo(); break;
                case 5: refreshCouriersGrid(); break;
            }
        }

        int findDrugIndex(string name)
        {
            for (int i = 0; i < storage.Drugs.Count; i++) 
            {
                if(storage.Drugs[i].name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        void DeleteDrug(DataGridView gridFrom)
        {
            int selectedRowIndex = gridFrom.SelectedRows[0].Index;
            string drugName = gridFrom.Rows[selectedRowIndex].Cells[0].Value.ToString();
            Console.WriteLine(drugName);
            int drugIndex = findDrugIndex(drugName);
            if (drugIndex != -1) 
            {
                storage.Drugs.RemoveAt(drugIndex);
            }
            refreshGrids();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            int selectedTab = tabControl2.SelectedIndex;
            DataGridView[] grids = new DataGridView[] { dataGridViewTablets, dataGridViewSuspension, dataGridViewCream, dataGridViewSpray };
            DeleteDrug(grids[selectedTab]);
        }

        private void dataGridViewTablets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewTablets.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridViewSuspension_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSuspension.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridViewCream_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCream.Rows[e.RowIndex].Selected = true;
        }

        private void dataGridViewSpray_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSpray.Rows[e.RowIndex].Selected = true;
        }

        void refreshDrugToChooseGrid()
        {
            dataGridViewDrugToChoose.Rows.Clear();
            dataGridViewDeliveryDrugs.Rows.Clear();
            foreach (var drug in storage.Drugs)
            {
                if(drug.amount > 0)
                {
                    dataGridViewDrugToChoose.Rows.Add(drug.name);
                    dataGridViewDeliveryDrugs.Rows.Add(drug.name);
                }
            }
        }

        private void checkBoxIsPerpetural_CheckedChanged(object sender, EventArgs e)
        {
            Control[] components = new Control[] { labelDiscount, textBoxDiscount, labelDrugToChoose, dataGridViewDrugToChoose };
            foreach(var i in components)
            {
                i.Visible = checkBoxIsPerpetural.Checked;
            }
            refreshDrugToChooseGrid();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            List<Drug> formDrugList()
            {
                List<Drug> temp = new List<Drug>();
                foreach(DataGridViewRow row in dataGridViewDrugToChoose.SelectedRows)
                {
                    temp.Add(storage.Drugs[findDrugIndex(row.Cells[0].Value.ToString())]);
                }
                return temp;
            }
            if (checkBoxIsPerpetural.Checked)
            {
                storage.Customers.Add(new PerperturalCustomer(
                    textBoxFIO.Text,
                    dateTimePickerDOB.Value,
                    textBoxPhone.Text,
                    textBoxEmail.Text,
                    textBoxDiscount.Text,
                    formDrugList()
                ));
            }
            else
            {
                storage.Customers.Add(new Customer(
                    textBoxFIO.Text,
                    dateTimePickerDOB.Value,
                    textBoxPhone.Text,
                    textBoxEmail.Text
                ));
            }
            refreshCustomerGrid();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            storage.Customers.RemoveAt(dataGridViewPerpeturalCustomers.SelectedRows[0].Index);
            refreshCustomerGrid();
        }

        private void dataGridViewPerpeturalCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPerpeturalCustomers.Rows[e.RowIndex].Selected = true;
        }

        private void buttonAddCourier_Click(object sender, EventArgs e)
        {
            storage.Couriers.Add(new Courier(textBoxCourierName.Text));
            refreshCouriersGrid();
        }

        void refreshDeliveryGrid()
        {
            dataGridViewDeliveries.Rows.Clear();
            foreach(var order in storage.Orders)
            {
                if(order.GetType().Name == "Delivery")
                {
                    string drugs = "";
                    foreach(var drug in ((Delivery)order).drugs)
                    {
                        drugs += $"{drug.name}, ";
                    }
                    dataGridViewDeliveries.Rows.Add(order.date, order.name, order.address, ((Delivery)order).customer.FIO, ((Delivery)order).courier.name, drugs, ((Delivery)order).price);
                }
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            List<Drug> formDrugList()
            {
                List<Drug> temp = new List<Drug>();
                foreach (DataGridViewRow row in dataGridViewDeliveryDrugs.SelectedRows)
                {
                    temp.Add(storage.Drugs[findDrugIndex(row.Cells[0].Value.ToString())]);
                }
                return temp;
            }
            storage.Orders.Add(new Delivery(
                dateTimePickerDeliveryDate.Value, 
                textBoxDeliveryName.Text, 
                textBoxDeliveryAddress.Text,
                storage.Customers[comboBoxClients.SelectedIndex],
                storage.Couriers[comboBoxCouriers.SelectedIndex], 
                formDrugList()
            ));
            storage.Couriers[comboBoxCouriers.SelectedIndex].deliveryAmount = storage.Couriers[comboBoxCouriers.SelectedIndex].deliveryAmount + 1;
            foreach(var drug in formDrugList())
            {
                drug.amount = drug.amount - 1;
            }
            refreshDeliveryGrid();
        }

        void refreshIncomeGrid()
        {
            dataGridViewIncome.Rows.Clear();
            foreach(var order in storage.Orders)
            {
                if(order.GetType().Name == "Income")
                {
                    dataGridViewIncome.Rows.Add(order.date, order.name, order.address, ((Income)order).nameOfDrug, ((Income)order).amount);
                }
            }
        }

        private void buttonIncomeOrder_Click(object sender, EventArgs e)
        {
            storage.Orders.Add(new Income(
                dateTimePickerDateOfIncome.Value, 
                textBoxNameOfIncome.Text, 
                textBoxAddrOfIncome.Text, 
                Convert.ToInt32(textBoxIncomeAmount.Text), 
                comboBoxDrugToOrder.Text
            ));
            Drug drug = storage.Drugs[findDrugIndex(comboBoxDrugToOrder.Text)];
            drug.amount = drug.amount + Convert.ToInt32(textBoxIncomeAmount.Text);
            refreshIncomeGrid();
        }

        void RefreshAll()
        {
            refreshComboBoxes();
            refreshCouriersGrid();
            refreshCustomerGrid();
            refreshDeliveryGrid();
            refreshDrugToChooseGrid();
            refreshGrids();
            refreshIncomeCombo();
            refreshIncomeGrid();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            storage.SerializeData();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            storage.DeserializeData();
            RefreshAll();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewSearch.Rows.Clear();
            foreach (var drug in storage.Drugs)
            {
                if(drug.name == textBoxSearch.Text)
                {
                    dataGridViewSearch.Rows.Add(drug.name,
                            drug.usageMethod,
                            drug.dose,
                            drug.group,
                            drug.price,
                            drug.timeUntil.ToString(),
                            drug.amount
                    );
                }
            }
        }
    }
}
