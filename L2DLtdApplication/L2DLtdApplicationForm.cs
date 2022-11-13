using Microsoft.VisualBasic.Devices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using static L2DLtdApplication.L2DLtdApplicationForm;
using static System.Windows.Forms.AxHost;

namespace L2DLtdApplication
{
    public partial class L2DLtdApplicationForm : Form
    {
        public class AttendeesValidity : Exception
        {
            public AttendeesValidity(string message) : base(message)
            {
            }
        }
        public L2DLtdApplicationForm()
        {
            InitializeComponent();
        }
        const string COURSE1 = "C# Fundamentals", COURSE2 = "C# Basic for Beginners", COURSE3 = "C# Intermediate", COURSE4 = "C# Advanced Topic", COURSE5 = "ASP.NET with C# Part A", COURSE6 = "ASP.NET with C# Part B";
        const decimal COURSE1COST = 900m, COURSE2COST = 1500m, COURSE3COST = 1800m, COURSE4COST = 2300m, COURSE5COST = 1250m, COURSE6COST = 1250m;
        const string LOCATION1 = "Belmullet", LOCATION2 = "Clifton", LOCATION3 = "Cork", LOCATION4 = "Dublin", LOCATION5 = "Killarney", LOCATION6 = "Letterkenny", LOCATION7 = "Sligo";
        const decimal LOCATION1COST = 219.99m, LOCATION2COST = 119.99m, LOCATION3COST = 149.99m, LOCATION4COST = 179.99m, LOCATION5COST = 149.99m, LOCATION6COST = 89.99m, LOCATION7COST = 119.99m;
        const decimal SUITE1COST = 99.99m, SUITE2COST = 69.99m, SUITE3COST = 49.99m, DIGITALCERTIFICATESCOST= 39.99m;

        int courseIndex = 0, locationIndex = 0, attendees = 0, clickCount= 0, discountedCounter = 0;
        Decimal courseCost = 0m, locationCost = 0m, suiteTotal = 0m, certificateCost = 0m, overallCost = 0m, discountedCost = 0m,
                totalCostCompany=0m, overallCostCompany=0m, overallDiscountedCost=0m, totalSuiteCost=0m, totalCertificateCost=0m, 
                totalLocationCost=0m, totalCourseCost=0m, overallLocationCost=0m, suiteTotalCost=0m, certificateTotalCost=0m, totalCourseCostSummary=0m, averageOfTransactions=0m;
        string course = "", location = "";



        private void displayButton_Click(object sender, EventArgs e)
        {
            

            if ((courseListBox.SelectedIndex !=-1))
            { 
                if ((locationListBox.SelectedIndex !=-1))
                {
                    bookButton.Enabled=true;
                    courseIndex = courseListBox.SelectedIndex;
                    locationIndex=locationListBox.SelectedIndex;

                switch (courseIndex)
                    {
                        case 0: course=COURSE1; courseCost=COURSE1COST; break;
                        case 1: course=COURSE2; courseCost=COURSE2COST; break;
                        case 2: course=COURSE3; courseCost=COURSE3COST; break;
                        case 3: course=COURSE4; courseCost=COURSE4COST; break;
                        case 4: course=COURSE5; courseCost=COURSE5COST; break;
                        case 5: course=COURSE6; courseCost=COURSE6COST; break;
                    }

                switch (locationIndex)
                    {
                        case 0: location=LOCATION1; locationCost=LOCATION1COST; break;
                        case 1: location=LOCATION2; locationCost=LOCATION2COST; break;
                        case 2: location=LOCATION3; locationCost=LOCATION3COST; break;
                        case 3: location=LOCATION4; locationCost=LOCATION4COST; break;
                        case 4: location=LOCATION5; locationCost=LOCATION5COST; break;
                        case 5: location=LOCATION6; locationCost=LOCATION6COST; break;
                        case 6: location=LOCATION7; locationCost=LOCATION7COST; break;
                    }


                    //radio
                    if (masterSuiteRadioButton.Checked == true)
                    {
                        suiteTotal=SUITE1COST;
                    }
                    else if (executiveSuiteRadioButton.Checked == true)
                    {
                        suiteTotal=SUITE2COST;
                    }
                    else if (juniorSuiteRadioButton.Checked == true)
                    {
                        suiteTotal=SUITE3COST;
                    }
                    // Checkbox
                    if (certificateCheckBox.Checked == true)
                    {
                        certificateCost = DIGITALCERTIFICATESCOST;
                    }



                   
                    if (string.IsNullOrEmpty(attendeesTextBox.Text))
                    {
                        MessageBox.Show("Please enter attendees","Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        attendeesTextBox.SelectAll();
                        attendeesTextBox.Focus();
                        return;
                    }
                        

                        try
                        {
                            if (int.Parse(attendeesTextBox.Text)>0)
                            {
                                attendees = int.Parse(attendeesTextBox.Text);

                            }
                            else 
                            {
                                throw new AttendeesValidity("Invalid number of attendees"); 
                            }
                        }

                        catch
                        {
                         MessageBox.Show("Invalid number of attendees","Error",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        attendeesTextBox.SelectAll();
                        attendeesTextBox.Focus();

                        return;
                        
                        }
                    


                    totalCourseCost= attendees*courseCost;
                    overallLocationCost= attendees*locationCost;
                    suiteTotalCost=attendees*suiteTotal;
                    certificateTotalCost=attendees*certificateCost;
                    overallCost = (totalCourseCost + overallLocationCost +suiteTotalCost+certificateTotalCost);

                    

                    if  (attendees>=3)
                    {
                        discountedCost = overallCost-(overallCost*(0.075m));

                        discountedCounter=discountedCounter+1;
                        outputLabel.Text = "course : " + course+
                                           "\n" + "location : " + location+
                                           "\n" + "Enrollment Cost: " + totalCourseCost.ToString("C")+
                                           "\n"+ "Lodging Cost: " + overallLocationCost.ToString("C")+
                                           "\n"+ "Suite : "+ suiteTotalCost.ToString("C")+
                                           "\n"+ "Digital Certificate : "+ certificateTotalCost.ToString("C")+
                                           "\n"+ "Overall Cost: "+ overallCost.ToString("C") +"\n"+
                                           "\n"+ "Discounted Overall Cost: "+ discountedCost.ToString("C") +"\n"+
                                           "\n"+ "***Group Discount Applied 7.5%"+"\n";
                                          
                        overallCost=0;
                    }
                    else
                    {
                        outputLabel.Text = "course : " + course+
                                           "\n" + "location : " + location+
                                           "\n" + "Enrollment Cost: " + totalCourseCost.ToString("C")+
                                           "\n"+ "Lodging Cost: " + overallLocationCost.ToString("C")+
                                           "\n"+ "Suite : "+ suiteTotalCost.ToString("C")+
                                           "\n"+ "Digital Certificate : "+ certificateTotalCost.ToString("C")+
                                           "\n"+ "Overall Cost: "+ overallCost.ToString("C") +"\n";

                    }

                }
                else
                {
                    MessageBox.Show("Please Select location", "location Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } 
            else
            {
                MessageBox.Show("Please Select course", "course Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void bookButton_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult dialogResult;
            if (attendees>=3)
            {
               

                 dialogResult = MessageBox.Show("course: "+ course + "\n" + "location : " + location+
                "\n"+ "Overall Cost: "+ discountedCost.ToString("C"), "Hello",buttons);

            }
            else  
            {
                

                 dialogResult = MessageBox.Show("course "+ course +"\n" + "location : " + location+
                                  "\n"+ "Overall Cost: "+ overallCost.ToString("C"),"bye", buttons);
               

                }





            if (dialogResult == DialogResult.Yes)
            {
                clickCount=clickCount+1;
                overallCostCompany=overallCost+overallCostCompany;
                overallDiscountedCost=discountedCost+overallDiscountedCost;
                totalCourseCostSummary=totalCourseCost+totalCourseCostSummary;
                totalCostCompany =overallCostCompany+overallDiscountedCost;
                overallLocationCost=locationCost+totalLocationCost;
                totalSuiteCost=suiteTotalCost+totalSuiteCost;
                totalCertificateCost=certificateTotalCost+totalCertificateCost;
                averageOfTransactions = totalCostCompany/clickCount;
                outputLabel.Text="";
                attendeesTextBox.Text="";
                courseListBox.SelectedIndex=-1;
                locationListBox.SelectedIndex=-1;
                masterSuiteRadioButton.Checked = false;
                executiveSuiteRadioButton.Checked=false;
                juniorSuiteRadioButton.Checked=false;
                certificateCheckBox.Checked=false;
                bookButton.Enabled=false;


            }
            else  
            {
                outputLabel.Text="";
                attendeesTextBox.Text="";
                courseListBox.SelectedIndex=-1;
                locationListBox.SelectedIndex=-1;
                masterSuiteRadioButton.Checked = false;
                executiveSuiteRadioButton.Checked=false;
                juniorSuiteRadioButton.Checked=false;
                certificateCheckBox.Checked=false;
                bookButton.Enabled=false;

            }






        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            



            outputLabel.Text= "Total No Of Booking : " + clickCount+"\n"+
                              "Total Enrollment Cost : " + totalCourseCostSummary +"\n"+
                              "Total Lodging Cost : " + overallLocationCost +"\n"+
                              "Total Suite Cost : " + totalSuiteCost +"\n"+
                              "Total Certificate Cost: " + totalCertificateCost+"\n"+
                              "Total Overall Earnings : " + totalCostCompany+"\n"+
                              "Total No of Group Discount : "+ discountedCounter+"\n"+
                              "Average Of Per Booking : "+averageOfTransactions;


            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text="";
            attendeesTextBox.Text="";
            courseListBox.SelectedIndex=-1;
            locationListBox.SelectedIndex=-1;
            masterSuiteRadioButton.Checked = false;
            executiveSuiteRadioButton.Checked=false;
            juniorSuiteRadioButton.Checked=false;
            certificateCheckBox.Checked=false;
            bookButton.Enabled=false;

        }
    }

}