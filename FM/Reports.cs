﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace FM
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }



        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.FuelMileageTableAdapter' table. You can move, or remove it, as needed.
            //this.FuelMileageTableAdapterTableAdapter.Fill(this.dataSet1.FuelMileageTableAdapter);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string before = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            String rvSQL = "SELECT Warehouse.Name AS Warehouse, concat(year(date), '-', format(month(date), '00')) as Per, Records.date, SUM(Records.Miles) AS Miles, '" + start + "' AS Start, '" + before + "' AS Before "
            + "FROM Records INNER JOIN "
            + "Warehouse ON Records.Warehouse = Warehouse.ID "
            + "WHERE(Records.Date >= '"+start+"') AND(Records.Date < '"+before+"') "
            + "GROUP BY Warehouse.Name, records.date ";
            using (SqlConnection sqlConn = new SqlConnection(GlobalVar.conString))
            using (SqlDataAdapter da = new SqlDataAdapter(rvSQL, sqlConn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                this.reportViewer1.Reset();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.Mileage.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                // Must match the DataSet in the RDLC
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }

            //this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            //LocalReport localReport = reportViewer1.LocalReport;


            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.Report4.rdlc";
            //this.warehouse1TableAdapter.Fill(this.dataSet1.Warehouse1, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());

            //this.reportViewer1.RefreshReport();

            }

        private void button2_Click(object sender, EventArgs e)
        {

            string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string before = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            String rvSQL = "SELECT Warehouse.Name AS Warehouse, concat(year(date), '-', format(month(date), '00')) as Per, "
                + "Records.Gallons, '" + start + "' AS Start, '" + before + "' AS Before, records.date  FROM Records INNER JOIN "
                + "Warehouse ON Records.Warehouse = Warehouse.ID INNER JOIN Type ON Records.Type = Type.ID "
                + " WHERE(Records.Date >= '" + start + "') AND(Records.Date < '" + before + "') AND(Type.ID = 1) AND "
                + "(Records.Status = '1' OR Records.Status = 'P')";
            using (SqlConnection sqlConn = new SqlConnection(GlobalVar.conString))
            using (SqlDataAdapter da = new SqlDataAdapter(rvSQL, sqlConn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                this.reportViewer1.Reset();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.Gallons.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                // Must match the DataSet in the RDLC
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }

            //this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            //LocalReport localReport = reportViewer1.LocalReport;
         
           
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.gallons.rdlc";
            //this.Warehouse2TableAdapter.Fill(this.dataSet1.Warehouse2, dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString());
          
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string before = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            String rvSQL = "SELECT REP.Name AS Warehouse, SUM(REP.Gallons) AS Gallons, "
                + "COUNT(REP.Per) AS Runs, CONVERT(int, ROUND(SUM(REP.Gallons) / SUM(CAST(REP.Capacity "
                + "AS decimal)), 3) * 100) AS Capacity_Percent, SUM(REP.Gallons) / count(distinct "
                + "rep.date) AS GalsPerDay, SUM(CAST(REP.Gallons AS decimal)) / SUM(CAST(REP.Miles AS decimal))"
                + "AS GalsPerMile, '" + start + "' AS Start, '" + before + "' AS Before, REP.PER FROM "
                + "(SELECT Warehouse.Name, Records.Gallons, Records.Capacity, Records.Miles, "
                + "concat(year(date), '-', format(month(date), '00')) as Per, records.id, records.truck, "
                + "records.date FROM  Records INNER JOIN Warehouse ON Records.Warehouse = Warehouse.ID "
                + "INNER JOIN Type ON Records.Type = Type.ID INNER JOIN Truck ON Records.Truck = Truck.Num"
                + " WHERE(Records.Date >= '" + start + "') AND(Records.Date < '" + before + "') AND(Records.Type = 1) AND "
                + "(Records.Status = '1' OR Records.Status = 'P') ) REP GROUP BY REP.Name, REP.PER";

               
            using (SqlConnection sqlConn = new SqlConnection(GlobalVar.conString))
            using (SqlDataAdapter da = new SqlDataAdapter(rvSQL, sqlConn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                this.reportViewer1.Reset();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.Stats.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                // Must match the DataSet in the RDLC
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }

        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            
                string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string before = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            String rvSQL = "select distinct Warehouse.Name, RequiredDate, '" + start + "' AS Start, '" + before + "' AS Before  from RequiredDates, warehouse,Dates "
            + "where warehouse.id = dates.warehouse and   requiredDate < '" + before + "' and RequiredDate >= '"
            + start + "' and cast(Dates.Warehouse as varchar(2)) +'-'+convert(varchar(30),RequiredDates.RequiredDate,126)  "
            + "not in (select cast(dates.Warehouse as varchar(2))+ '-'+cast(dates.date as varchar(10)) from dates "
            + "where date < '" + before + "' and date >= '" + start + "') order by Name, RequiredDate";
            
                using (SqlConnection sqlConn = new SqlConnection(GlobalVar.conString))
                using (SqlDataAdapter da = new SqlDataAdapter(rvSQL, sqlConn))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    this.reportViewer1.Reset();
                    this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.MissingEntries.rdlc";
                    ReportDataSource reportDataSource = new ReportDataSource();
                    // Must match the DataSet in the RDLC
                    reportDataSource.Name = "DataSet1";
                    reportDataSource.Value = ds.Tables[0];
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.RefreshReport();
                
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string before = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            String rvSQL = "SELECT Warehouse.Name, Records.Truck, SUM(isnull(Records.Fuel,0)) AS Fuel, "
                + "SUM(Records.Miles) AS Miles, MPG = CASE WHEN SUM(isnull(Records.Fuel,0)) = 0 THEN 0 "
                + "ELSE SUM(isnull(Records.Miles,0))/ SUM(isnull(Records.Fuel, 0)) END, '" + start + "' AS Start, '" + before + "' AS Before  "
                + "FROM Warehouse, Records WHERE Records.Warehouse = Warehouse.id and (Records.Date >= '" + start + "')"
                + "AND (Records.Date < '" + before + "') and records.miles > 0 GROUP BY Warehouse.Name, Records.Truck ORDER BY "
                + " Warehouse.Name, Records.Truck";
                
            using (SqlConnection sqlConn = new SqlConnection(GlobalVar.conString))
            using (SqlDataAdapter da = new SqlDataAdapter(rvSQL, sqlConn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                this.reportViewer1.Reset();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.FuelMileage.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                // Must match the DataSet in the RDLC
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
        
    }

        private void button6_Click(object sender, EventArgs e)
        {
            string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string before = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            String rvSQL = "SELECT Warehouse.Name, OOS.Description, Records.Truck, COUNT(Records.Truck) "
                + "AS Truck_OOS_Days, '" + start + "' AS Start, '" + before + "' AS Before FROM Records INNER JOIN Warehouse ON Records.Warehouse"
                + "= Warehouse.ID INNER JOIN OOS ON Records.OOS = OOS.ID WHERE(Records.Date"
                + ">= '" + start + "') AND(Records.Date < '" + before + "') AND (Records."
                + "Status = '0') GROUP BY Warehouse.Name, OOS.Description, Records.Truck";
                
            using (SqlConnection sqlConn = new SqlConnection(GlobalVar.conString))
            using (SqlDataAdapter da = new SqlDataAdapter(rvSQL, sqlConn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                this.reportViewer1.Reset();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.OOS.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                // Must match the DataSet in the RDLC
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string before = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            String rvSQL = "SELECT Warehouse.Name, COUNT(Records.Truck) AS "
                + "Truck_Not_Used_Days, '" + start + "' AS Start, '" + before + "' AS Before FROM Records INNER JOIN Warehouse ON "
                + "Records.Warehouse = Warehouse.ID WHERE(Records.Date >= '" + start + "')"
                + "AND(Records.Date < '" + before + "') AND(Records.Status = '0') GROUP BY Warehouse.Name";
                
            using (SqlConnection sqlConn = new SqlConnection(GlobalVar.conString))
            using (SqlDataAdapter da = new SqlDataAdapter(rvSQL, sqlConn))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];

                this.reportViewer1.Reset();
                this.reportViewer1.ProcessingMode = ProcessingMode.Local;
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "FM.NotUsed.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                // Must match the DataSet in the RDLC
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = ds.Tables[0];
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip AllMiles = new ToolTip();
            AllMiles.SetToolTip(button1, "Shows all mileage by warehouse for the range selected.");
            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            ToolTip BulkGals = new ToolTip();
            BulkGals.SetToolTip(button2, "Shows all gallons delivered by bulk trucks, by warehouse, for the range selected.");
            
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            ToolTip Stats = new ToolTip();
            Stats.SetToolTip(button3, "Shows statistics like gallons per mile and percentage of capacity utilized by warehouse for the range selected.");

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            ToolTip OOS = new ToolTip();
            OOS.SetToolTip(button6, "Shows trucks that were not used and why, by warehouse for the range selected.");

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            ToolTip Compl = new ToolTip();
            Compl.SetToolTip(button4, "Shows fuel used and MPG for the range selected.");

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            ToolTip Miss = new ToolTip();
            Miss.SetToolTip(button5, "Use this report to see which warehouses have not completed their daily entries for specific days.");

        }

        
    }
    }

