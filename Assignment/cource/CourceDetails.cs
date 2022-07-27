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

namespace shaurya.net.Assignment.cource
{ 
    public partial class CourceDetails : Form
    {
        FileStream fs;
        public CourceDetails()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Cources c = new Cources();
                c.CourseId = Convert.ToInt32(txtCourseId.Text);
                c.CourseName = txtCourseName.Text;
                c.Fees = Convert.ToInt32(txtFees.Text);
                FileStream fs = new FileStream(@"D:\Cources", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, c);
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
            Cources c = new Cources();            
            FileStream fs = new FileStream(@"D:\Employee1", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            c = (Cources)bf.Deserialize(fs);
            c.CourseId = Convert.ToInt32(txtCourseId.Text);
            c.CourseName = txtCourseName.Text;
            c.Fees = Convert.ToInt32(txtFees.Text);
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
            Cources c = new Cources();
            c.CourseId = Convert.ToInt32(txtCourseId.Text);
            c.CourseName = txtCourseName.Text;
            c.Fees = Convert.ToInt32(txtFees.Text);
            FileStream fs = new FileStream(@"D:\CourcesXml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Product));
            xs.Serialize(fs, c);
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
            Cources c = new Cources();            
            FileStream fs = new FileStream(@"D:\Employee1Xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Product));
            c = (Cources)xs.Deserialize(fs);
            c.CourseId = Convert.ToInt32(txtCourseId.Text);
            c.CourseName = txtCourseName.Text;
            c.Fees = Convert.ToInt32(txtFees.Text);
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
            Cources c = new Cources();
            c.CourseId = Convert.ToInt32(txtCourseId.Text);
            c.CourseName = txtCourseName.Text;
            c.Fees = Convert.ToInt32(txtFees.Text);
            FileStream fs = new FileStream(@"D:\CourcesSoap", FileMode.Create, FileAccess.Write);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, c);
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
            Cources c = new Cources();           
            FileStream fs = new FileStream(@"D:\Employee1Soap", FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            c = (Cources)sf.Deserialize(fs);
            c.CourseId = Convert.ToInt32(txtCourseId.Text);
            c.CourseName = txtCourseName.Text;
            c.Fees = Convert.ToInt32(txtFees.Text);
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
            Cources c = new Cources();
            c.CourseId = Convert.ToInt32(txtCourseId.Text);
            c.CourseName = txtCourseName.Text;
            c.Fees = Convert.ToInt32(txtFees.Text);
            FileStream fs = new FileStream(@"D:\CourcesJson", FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize(fs, c);
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
            Cources c = new Cources();            
            FileStream fs = new FileStream(@"D:\Employee1Json", FileMode.Open, FileAccess.Read);
            c = JsonSerializer.Deserialize<Cources>(fs);
            c.CourseId = Convert.ToInt32(txtCourseId.Text);
            c.CourseName = txtCourseName.Text;
            c.Fees = Convert.ToInt32(txtFees.Text);
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
