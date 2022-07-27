using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace shaurya.net
{
    public partial class Employee : Form
    {
        FileStream fs;
        public Employee()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee1 e1 = new Employee1();
                e1.Empid = Convert.ToInt32(txtEmpid.Text);
                e1.empname = txtempname.Text;
                e1.salary= Convert.ToInt32(txtsalary.Text);
                FileStream fs = new FileStream(@"D:\Employee1", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, e1);
                MessageBox.Show("File created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee1 e1 = new Employee1();
                FileStream fs = new FileStream(@"D:\Employee1", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                e1 = (Employee1)bf.Deserialize(fs);
                e1.Empid = Convert.ToInt32(txtEmpid.Text);
                e1.empname = txtempname.Text;
                e1.salary = Convert.ToInt32(txtsalary.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee1 e1 = new Employee1();
                e1.Empid = Convert.ToInt32(txtEmpid.Text);
                e1.empname = txtempname.Text;
                e1.salary = Convert.ToInt32(txtsalary.Text);
                FileStream fs = new FileStream(@"D:\Employee1Xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                xs.Serialize(fs, e1);
                MessageBox.Show("XML File created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee1 e1 = new Employee1();
                FileStream fs = new FileStream(@"D:\Employee1Xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                e1 = (Employee1)xs.Deserialize(fs);
                e1.Empid = Convert.ToInt32(txtEmpid.Text);
                e1.empname = txtempname.Text;
                e1.salary = Convert.ToInt32(txtsalary.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee1 e1 = new Employee1();
                e1.Empid = Convert.ToInt32(txtEmpid.Text);
                e1.empname = txtempname.Text;
                e1.salary = Convert.ToInt32(txtsalary.Text);
                FileStream fs = new FileStream(@"D:\Employee1Soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, e1);
                MessageBox.Show("SOAP File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee1 e1 = new Employee1();
                FileStream fs = new FileStream(@"D:\Employee1Soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                e1 = (Employee1)sf.Deserialize(fs);
                e1.Empid = Convert.ToInt32(txtEmpid.Text);
                e1.empname = txtempname.Text;
                e1.salary = Convert.ToInt32(txtsalary.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee1 e1 = new Employee1();
                e1.Empid = Convert.ToInt32(txtEmpid.Text);
                e1.empname = txtempname.Text;
                e1.salary = Convert.ToInt32(txtsalary.Text);
                FileStream fs = new FileStream(@"D:\Employee1Json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, e1);
                MessageBox.Show("SOAP File Created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                Employee1 e1 = new Employee1();
                FileStream fs = new FileStream(@"D:\Employee1Json", FileMode.Open, FileAccess.Read);
                e1 = JsonSerializer.Deserialize<Employee1>(fs);               
                e1.Empid = Convert.ToInt32(txtEmpid.Text);
                e1.empname = txtempname.Text;
                e1.salary = Convert.ToInt32(txtsalary.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
    }

