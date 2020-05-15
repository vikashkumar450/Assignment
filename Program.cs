using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using TestProcess.Classes;
using TestProcess.Interfaces;

using Zyklus.Payer.Repositories.Common;

namespace CallApi
{

    class Program
    {
        private static List<KeyValue> GetKeyValue()
        {
            double dbleValue = 50;
            double dbleGrossAmount = 100;
            int intValue = 90;
            List<KeyValue> keyValuesRules = new List<KeyValue>();
            //keyValuesRules = RequestData;
            keyValuesRules.Add(new KeyValue("CompanyID", "100"));
            keyValuesRules.Add(new KeyValue("CompanyName", null));
            keyValuesRules.Add(new KeyValue("DiagnosisCode", "VIKAS"));
            keyValuesRules.Add(new KeyValue("DiscountAmount", dbleValue));          
            keyValuesRules.Add(new KeyValue("ServiceCode", "020100001"));
            keyValuesRules.Add(new KeyValue("OrganizationID", 1));
            keyValuesRules.Add(new KeyValue("ClinicID", 1));
            keyValuesRules.Add(new KeyValue("EncounterNo", 0));
            keyValuesRules.Add(new KeyValue("GrossAmount", 100));
            keyValuesRules.Add(new KeyValue("RightEyeAxisDistance", string.Empty));
            keyValuesRules.Add(new KeyValue("diagnosis", "Gingivitis and periodontal diseases,Calculus of kidney and ureter"));
            keyValuesRules.Add(new KeyValue("service", "BUN (S),K (S),NA (S),CBC (COMPLETE BLOOD COUNT PROFILE),CT SCAN - RENAL/ URETERAL CALCULUS"));

            return keyValuesRules;

            
        }


        private static List<KeyValue> GetKeyValue2()
        {
            double dbleValue = 101;
            double dbleGrossAmount = 261;
            int intValue = 3;
            List<KeyValue> keyValuesRules = new List<KeyValue>();
            //keyValuesRules = RequestData;
            keyValuesRules.Add(new KeyValue("ClinicID", intValue));
            keyValuesRules.Add(new KeyValue("DiscountAmount", dbleValue));
            keyValuesRules.Add(new KeyValue("DiagnosisCode", "5E2S"));
            keyValuesRules.Add(new KeyValue("GrossAmount", dbleGrossAmount));


            return keyValuesRules;
        }

        public string PatientName { get; set; }
        public string PatientSurnameFamilyName { get; set; }
        public string PatientMembershipNumber { get; set; }
        // public DateTime? PatientDOB { get; set; }
        public DateTime PatientDOB { get; set; }
        public string MaritalStatus { get; set; }
        public short VisitType { get; set; }
        public string PatientGender { get; set; }
        public string NationalityID { get; set; }
        public string PatientNationality { get; set; }
        public string PatientFileNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TownCity { get; set; }
        public string PostalCode { get; set; }
        public string PatientMobileNo { get; set; }
        public string Remarks { get; set; }


        private static List<KeyValue> PatientValidationGroup()
        {

            List<KeyValue> keyValuesRules = new List<KeyValue>();
            //keyValuesRules = RequestData;
            keyValuesRules.Add(new KeyValue("PatientDOB", "01/31/1957 12:00:00 AM"));
            return keyValuesRules;
        }

            private static List<KeyValue> PatientKeyValue()
        {
           
            List<KeyValue> keyValuesRules = new List<KeyValue>();
            //keyValuesRules = RequestData;
            keyValuesRules.Add(new KeyValue("PatientName", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("PatientSurnameFamilyName", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("PatientMembershipNumber", "Test"));
            keyValuesRules.Add(new KeyValue("PatientDOB", Convert.ToDateTime(System.DateTime.Now)));
            keyValuesRules.Add(new KeyValue("MaritalStatus", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("VisitType", Convert.ToInt64(6)));
            keyValuesRules.Add(new KeyValue("PatientGender", Convert.ToString("Male")));
            keyValuesRules.Add(new KeyValue("NationalityID", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("PatientNationality", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("PatientFileNumber", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("Address1", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("Address2", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("TownCity", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("PostalCode", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("PatientMobileNo", Convert.ToString("Test")));
            keyValuesRules.Add(new KeyValue("Remarks", Convert.ToString("Test")));
          


            return keyValuesRules;
        }

        private static List<KeyValue> BupaSubmissionClaim()
        {

            List<KeyValue> keyValuesRules = new List<KeyValue>();
            //keyValuesRules = RequestData;
            
                keyValuesRules.Add(new KeyValue("FacilityID", Convert.ToInt16(4)));
            keyValuesRules.Add(new KeyValue("ClinicID", Convert.ToInt16(1)));
            keyValuesRules.Add(new KeyValue("DoctorID", Convert.ToInt16(0)));
            keyValuesRules.Add(new KeyValue("EncounterNo", Convert.ToInt16(0)));
            keyValuesRules.Add(new KeyValue("EncounterType", Convert.ToInt16(0)));
            keyValuesRules.Add(new KeyValue("GrossAmount", Convert.ToInt64(50)));
            keyValuesRules.Add(new KeyValue("DiscountAmount", Convert.ToInt64(6)));
            keyValuesRules.Add(new KeyValue("DeductibleAmount", Convert.ToInt64(6)));
            keyValuesRules.Add(new KeyValue("ReimbursementAmount", Convert.ToInt64(6)));
            keyValuesRules.Add(new KeyValue("PolicyNumber", 1222222));
            keyValuesRules.Add(new KeyValue("NetAmount", Convert.ToInt64(6)));
            keyValuesRules.Add(new KeyValue("DeductibleAmount", Convert.ToInt64(6)));
            keyValuesRules.Add(new KeyValue("ReimbursementAmount", Convert.ToInt64(6)));
            keyValuesRules.Add(new KeyValue("EncounterStartTime", Convert.ToDateTime(System.DateTime.Now.AddDays(1))));
            keyValuesRules.Add(new KeyValue("EncounterEndTime", Convert.ToDateTime(System.DateTime.Now)));

            //keyValuesRules.Add(new KeyValue("EncounterStartTime", null));
            //keyValuesRules.Add(new KeyValue("EncounterEndTime", null));





            return keyValuesRules;
        }


        private static List<KeyValue> BupaSubmissionServices()
        {

            List<KeyValue> keyValuesRules = new List<KeyValue>();
            //keyValuesRules = RequestData;
            keyValuesRules.Add(new KeyValue("OrganizationID", 1));
            keyValuesRules.Add(new KeyValue("LabCount", 1));
            keyValuesRules.Add(new KeyValue("RadCount", 1));
            keyValuesRules.Add(new KeyValue("DentalCount", 1));
            keyValuesRules.Add(new KeyValue("CompanyTax",null));
            keyValuesRules.Add(new KeyValue("CompanyTaxPct",5));
            keyValuesRules.Add(new KeyValue("PatientTax",5));
            keyValuesRules.Add(new KeyValue("PatientTaxPct",5));
            keyValuesRules.Add(new KeyValue("ServiceQuantity", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("ServiceStartDateTime", Convert.ToDateTime(System.DateTime.Now.AddDays(0))));
            keyValuesRules.Add(new KeyValue("EncounterStartTime", Convert.ToDateTime(System.DateTime.Now.AddDays(-2))));
            keyValuesRules.Add(new KeyValue("EncounterEndTime", Convert.ToDateTime(System.DateTime.Now.AddDays(1))));
            keyValuesRules.Add(new KeyValue("ServiceDeductiblePct", null));
            keyValuesRules.Add(new KeyValue("ServiceDiscountAmount", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("ServiceDiscountPct", null));
            keyValuesRules.Add(new KeyValue("ServiceNetAmount", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("ServiceType", "1"));
            keyValuesRules.Add(new KeyValue("ServiceCode", "ppp"));
            keyValuesRules.Add(new KeyValue("StandardCode", "asd"));
            keyValuesRules.Add(new KeyValue("ServiceGrossAmount", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("ServiceDiscountAmount", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("ServiceDeductibleAmount", ""));
            keyValuesRules.Add(new KeyValue("ServiceReimbursementAmount", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("PolicyNumber", null));
            keyValuesRules.Add(new KeyValue("ServiceNetAmount", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("ServiceDeductibleAmount", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("ServiceReimbursementAmount", Convert.ToDouble(100)));
  

            //keyValuesRules.Add(new KeyValue("EncounterStartTime", null));
            //keyValuesRules.Add(new KeyValue("EncounterEndTime", null));





            return keyValuesRules;
        }


        private static List<KeyValue> BupaSubmissionPatient()
        {

            List<KeyValue> keyValuesRules = new List<KeyValue>();
            //keyValuesRules = RequestData;
            keyValuesRules.Add(new KeyValue("MaritalStatus",null));
            keyValuesRules.Add(new KeyValue("NationalityID", null));
            keyValuesRules.Add(new KeyValue("PatientName", null));
            keyValuesRules.Add(new KeyValue("PatientTaxPct", null));
            keyValuesRules.Add(new KeyValue("ServiceQuantity", Convert.ToDouble(100)));
            keyValuesRules.Add(new KeyValue("PatientDOB", Convert.ToDateTime(System.DateTime.Now.AddDays(1))));
            keyValuesRules.Add(new KeyValue("PatientFileNumber", null));
            keyValuesRules.Add(new KeyValue("PatientGender","F"));
            keyValuesRules.Add(new KeyValue("PatientMembershipNumber", null));
            keyValuesRules.Add(new KeyValue("PatientNationality", null));
            keyValuesRules.Add(new KeyValue("PatientSurnameFamilyName", null));
            keyValuesRules.Add(new KeyValue("VisitType",5));
          

            //keyValuesRules.Add(new KeyValue("EncounterStartTime", null));
            //keyValuesRules.Add(new KeyValue("EncounterEndTime", null));





            return keyValuesRules;
        }


        private static List<KeyValue> ServicesKeyValue()
        {
            List<KeyValue> keyValuesRules = new List<KeyValue>();
          
           // keyValuesRules.Add(new KeyValue("test", Convert.ToString("2441481587")));
            keyValuesRules.Add(new KeyValue("NationalityID", Convert.ToString("24414815871")));
            keyValuesRules.Add(new KeyValue("ServiceDeductibleAmount", Convert.ToDecimal(51)));
            keyValuesRules.Add(new KeyValue("ServiceGrossAmount", Convert.ToDecimal(100)));
            keyValuesRules.Add(new KeyValue("ServiceNetAmount", Convert.ToDecimal(-1)));
            keyValuesRules.Add(new KeyValue("ServiceQuantity", Convert.ToDecimal(49.5)));
            keyValuesRules.Add(new KeyValue("ServiceDiscountPct", Convert.ToDecimal(0.5)));
            keyValuesRules.Add(new KeyValue("ServiceDeductiblePct", Convert.ToDecimal(0.5)));
            keyValuesRules.Add(new KeyValue("ServiceTypeIndicator", Convert.ToBoolean(true)));
            keyValuesRules.Add(new KeyValue("ServiceStartDateTime", Convert.ToDateTime(System.DateTime.Now).AddDays(-10)));
            

            return keyValuesRules;
        }

        private static List<KeyValue> DiagnosisGroupKeyValue()
        {
            List<KeyValue> keyValuesRules = new List<KeyValue>();
            //keyValuesRules = RequestData;
            keyValuesRules.Add(new KeyValue("DiagnosisType", Convert.ToByte(8)));

            return keyValuesRules;
        }


        private static IEnumerable<Assembly> GetAssemblies()
        {
            string executableLocation = AppContext.BaseDirectory;
            string directoryToSearch = Path.Combine(Path.GetDirectoryName(executableLocation), "Test");
            foreach (string file in Directory.EnumerateFiles(directoryToSearch, "*.dll"))
            {
                Assembly assembly = null;
                try
                {
                    //Load assembly using byte array
                    byte[] rawAssembly = File.ReadAllBytes(file);
                    assembly = Assembly.Load(rawAssembly);
                }
                catch (Exception)
                {
                }

                if (assembly != null)
                {
                    yield return assembly;
                }
            }
        }

       

        static void Main(string[] args)
        {
            string executableLocation = AppContext.BaseDirectory;
            string directoryToSearch = Path.Combine(Path.GetDirectoryName(executableLocation), "Test.dll");
                


            foreach (string file in Directory.EnumerateFiles(directoryToSearch, "*.dll"))
            {
                Assembly assembly = null;
                try
                {
                    //Load assembly using byte array
                    byte[] rawAssembly = File.ReadAllBytes(file);
                    assembly = Assembly.Load(rawAssembly);
                }
                catch (Exception)
                {
                }

                if (assembly != null)
                {
                    // yield return assembly;
                    Assembly s = assembly;
                }
            }

            var sss = GetAssemblies();
            char[] skkkk = "‎12‎/‎01‎/‎2019".Where(c => c < 128).ToArray();
            string x = new string(skkkk);

            
            List<DataTable> lstDt = new List<DataTable>();
            
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Name");
            dt.Columns.Add("Marks");
            DataRow _ravi = dt.NewRow();
            _ravi["Name"] = "ravi";
            _ravi["Marks"] = "500";
            dt.Rows.Add(_ravi);

            DataTable dtssss = Extension.AsDataTable(GetKeyValue());

            var kkkk = dtssss.AsEnumerable().ToList().CopyToDataTable();
           // DataTable s=ss.query.CopyToDataTable();

            for (int i=0;i<3;i++)
            {
                lstDt.Add(dtssss);
            }

            DataTable dt1 = new DataTable();
            int j = 0;
            foreach (DataTable data in lstDt)
            {
                
                DataRow dr = data.Copy().Rows[j];
                dt1.ImportRow(dr);
                dt1.AcceptChanges();
                //++j;



            }

            var ss = dt1.AsEnumerable();

            DataSet ds = new DataSet();
            


            //compareTwoandGetMatchingInTwoTable();

            //XmlDocument doc = new XmlDocument();
            //doc.Load("C:\\XMLDATA\\TestFile1.xml");

            //XmlReader xmlReader = new XmlNodeReader(doc);
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(xmlReader);
            //DataTable ss = dataSet.Tables[0];


            //var ss = doc;
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(doc);

            //MappedDiagnosisWithServiceAndGetMatchedOrNot();


            //DataTable dt = new DataTable();
            //try
            //{
            //    var ss = Convert.ToBoolean(dt.Compute("'#03/31/2017 16:00:00#' > '#01/12/2020 16:11:46#'", ""));
            //    var ssss = ss;
            //}
            //catch (Exception ex)
            //{

            //}
            //int count = 1;
            //StringBuilder sbFinalexpression = new StringBuilder();
            //StringBuilder nulloccurance = new StringBuilder();
            //string test = "'ppp' <> null OR null <> null OR 1 <> null AND 1=1";

            //string[] arrayOfExp = null;
            //arrayOfExp = test.Split(" ");
            //for (int i = 0; i < arrayOfExp.Length; i++)
            //{
            //    if (i > 0 && (arrayOfExp[i] == "<>" && arrayOfExp[i + 1] == "null"))
            //    {
            //        nulloccurance.Append(i - 1 + ",");
            //        nulloccurance.Append(i + 1 + ",");
            //    }
            //}

            //string[] nulloccur = nulloccurance.ToString().Split(",");
            //for (int i = 0; i < arrayOfExp.Length; i++)
            //{

            //    if (nulloccur.Contains(i.ToString()))
            //    {
            //        if (arrayOfExp[i].Contains("'"))
            //        {
            //            sbFinalexpression.Append(arrayOfExp[i] + "");
            //        }
            //        else
            //        {
            //            sbFinalexpression.Append("'" + arrayOfExp[i] + "'" + " ");
            //        }
            //    }
            //    else
            //    {
            //        sbFinalexpression.Append(arrayOfExp[i] + " ");
            //    }
            //}




            //var ss = dt.Compute(sbFinalexpression.ToString(), "");

            //var yes = ss;
            // compareTwoandGetMatchingInTwoTable();

            #region Encrytion
            //string key = "cloudsolutions@rcma12020";

            //Console.WriteLine("Please enter a secret key for the symmetric algorithm.");
            //var key = Console.ReadLine();

            //Console.WriteLine("Please enter a string for encryption");
            //var str = Console.ReadLine();
            //var encryptedString = Encryption.EncryptString(key, str);
            //Console.WriteLine($"encrypted string = {encryptedString}");
            //var decryptedString = Encryption.DecryptString(key, encryptedString);
            //Console.WriteLine($"decrypted string = {decryptedString}");

            //Console.ReadKey(); 
            #endregion

            #region commented for arithmatic
            // caller("", "");

            //string name = "vikash";

            //string chkvalue = "'" + name + "' not like '%salim%'";
            //DataTable dt = new DataTable();
            //bool ressss = Convert.ToBoolean(dt.Compute(chkvalue, ""));

            //string name = "true";

            //string chkvalue = "true=false";
            //DataTable dt = new DataTable();
            //bool ressss = Convert.ToBoolean(dt.Compute(chkvalue, ""));

            //var sss = ressss;


            //string cc2 = "AAAA1111111";
            //string ccc = @"^[0-9a -zA-Z]{4}\d{6,7}$".Trim();
            //string regex = "@" + ccc + "";

            //var match = Regex.Match("AAAA1111111", @""+ ccc + "", RegexOptions.IgnoreCase);
            //if (!match.Success)
            //{
            //    // does not match
            //}
            //else
            //{

            //}



            //var test1 = "20:00:00".Replace(":",",");
            //TimeSpan timespan = new TimeSpan(20,00,00);
            //DateTime time = DateTime.Today.Add(timespan);
            //string displayTime = time.ToString("hh:mm tt");
            //string test = "RAMIM";
            //string a = test.Substring(1);



            //string kkk = "Together we can do so mu_ch!";
            //string[] ppp = kkk.Split(" ");
            //if (ppp.Any(x => x == kkk.Contains("mu_").ToString()))
            //{
            //    // do some action here if true...
            //}



            //string str= "HI";
            //string[] splitstr = str.Split(" ");
            //var l = splitstr;
            //Test test = new Test();
            //test.evaluate("", null);
            //int a = 4;
            //int b = 5;
            //string functionName = "add";
            //object[] anArray= new object[2];
            //for (int i = 0; i < anArray.Length; i++)
            //{
            //    anArray[i] = i+1;

            //}
            //  object[] paramJoin=string.Join(",", anArray);

            // Test p = new Test();
            // Type t = p.GetType();
            // MethodInfo mi = t.GetMethod(functionName, BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Instance);
            // string ress = mi.Invoke(p, anArray).ToString();
            //// string result = mi.Invoke(p, new object[] { a, b }).ToString();
            // Console.WriteLine("Result = " + ress);
            // Console.ReadLine();


            //DateTime dateTime = DateTime.Now;

            //// string tmpDate = dateTime.ToString("MM/dd/yyyy HH:mm:ss ", CultureInfo.InvariantCulture);

            //DateTime dateTime1 = new DateTime();
            //dateTime1 = DateTime.Parse(Convert.ToString(null));
            //var tmpDate1 = dateTime.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            //string tmpDate = "null";
            //DateTime lstadate = DateTime.Now.AddDays(-1);
            //string chkvalue = "#" + tmpDate + "# < #06/07/1988 00:00:06 PM#";
            //DataTable dt = new DataTable();
            //bool ressss = Convert.ToBoolean(dt.Compute(chkvalue, ""));



            //string HIII = "91877 = '91877'  ";
            //string final = string.Empty;
            //if (HIII.ToLower().Contains("like"))
            //{
            //    StringBuilder sb = new StringBuilder();
            //    string[] array = HIII.Split(' ');
            //    bool isLikeExists = false;
            //    foreach(var s in array)
            //    {
            //        if (Convert.ToString(s).ToLower() == "like")
            //        {
            //            isLikeExists = true;
            //            break;
            //        }
            //    }

            //    if (isLikeExists)
            //    {
            //        for (int i = 0; i < array.Length; i++)
            //        {

            //            if (i > 1 && array[i - 1].ToString() == "LIKE")
            //            {
            //                var chkForSingleQuotesandRepl = array[i].ToString().Replace("'", "").Replace("'", "");
            //                sb.Append(" " + "'%" + chkForSingleQuotesandRepl + "%'" + " ");
            //            }
            //            else
            //            {
            //                if (array[i + 1].ToString() == "LIKE")
            //                {
            //                    sb.Append(" " + "'" + array[i].ToString() + "'" + " ");
            //                }
            //                else
            //                    sb.Append(" " + array[i].ToString() + " ");
            //            }
            //        }
            //    }
            //    final = sb.ToString();
            //}
            //else
            //    final = HIII;


            //string test = final.ToLower();
            //DataTable ddd = new DataTable();
            //var answer11eeee = Convert.ToBoolean(ddd.Compute(test, ""));



            //DateTime testD = new DateTime();
            //string  tests="Hii";
            //try
            //{
            //     testD = DateTime.Parse(("hii"));
            //}
            //catch (Exception)
            //{

            //    DateTime testDsss = DateTime.Parse(("09/07/2019"));
            //    string sdflfjsdfdks = testDsss.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
            //}




            //if (!string.IsNullOrEmpty(Convert.ToString(tests)))
            //{
            //    try
            //    {
            //        var expValueOfDateTime = Convert.ToDateTime(testD).ToString("MM/dd/yyyy");
            //        var kkkkkk = expValueOfDateTime;
            //    }
            //    catch
            //    {
            //        var sss = "";
            //    }

            //}

            //int six = 7;
            //DateTime first = DateTime.Now;
            //DateTime sec = DateTime.Now.AddDays(-1); 
            //string PP = @" ("+ six + " > (5 + 1 ) AND 6 < ( 3 + 8 ) AND '5888' LIKE   '%5888'   ) AND true=true  AND " + Convert.ToDateTime(first).ToString("MM/dd/yyyyhhmmss") + "<" + Convert.ToDateTime(sec).ToString("MM/dd/yyyyhhmmss") + " ";
            //DataTable dt1 = new DataTable();
            //var answer11 = Convert.ToBoolean(dt1.Compute(PP, ""));


            //string KKKK = " 5 = 1 + 3 + 1";
            //DataTable dt = new DataTable();
            //double answer = Convert.ToDouble(dt.Compute(KKKK, "")); 
            #endregion

            #region commented code

            //List<string> mylist = new List<string>(new string[] { "Age", "Weight", "Age" });
            //StringBuilder sbl = new StringBuilder();
            //foreach (var k in mylist)
            //{
            //    sbl.Append("Person." + k);
            //}

            //const string exp = @"(Person.Age > 3 AND Person.Weight > 50) OR Person.Age < 3";
            //var p = Expression.Parameter(typeof(Person), "Person");
            //var e = System.Linq.Dynamic.DynamicExpression.ParseLambda(new[] { p }, null, exp);
            //var bob = new Person
            //{
            //    Name = "Bob",
            //    Age = 30,
            //    Weight = 213,
            //    FavouriteDay = new DateTime(2000, 1, 1)
            //};

            //var result1 = e.Compile().DynamicInvoke(bob);
            //Console.WriteLine(result1);
            //Console.ReadKey();


            //String infix = "  DiscountAmount GreaterThan 100  OR ( DiscountAmount GreaterThan 20 ) AND DiscountAmount LessThanOrEqualTo 110 ";
            //FunctionEvaluate evaluate = new FunctionEvaluate();
            //Func<double, double> f =
            //evaluate.ConstructFunction(infix);

            //Console.WriteLine(StringTest.evaluate("  DiscountAmount GreaterThan 100  OR ( DiscountAmount GreaterThan 20 ) AND DiscountAmount LessThanOrEqualTo 110 "));
            // Console.ReadLine();

            //const string exp = @"(Person.Age > 3 AND Person.Weight > 50) OR Person.Age < 3";
            //var p = Expression.Parameter(typeof(Person), "Person");
            //var e = System.Linq.Dynamic.DynamicExpression.ParseLambda(new[] { p }, null, exp);
            //var bob = new Person
            //{
            //    Name = "Bob",
            //    Age = 30,
            //    Weight = 213,
            //    FavouriteDay = new DateTime(2000, 1, 1)
            //};

            //var result = e.Compile().DynamicInvoke(bob);
            //Console.WriteLine(result);
            //Console.ReadKey();



            //string star = "*";
            //Console.WriteLine(EvaluateString.evaluate("10 + 2 * 6"));
            //Console.WriteLine(EvaluateString.evaluate("100 * 2 + 12"));
            // Console.WriteLine(EvaluateString.evaluate("100 " + star + " ( 2 + 12 )"));
            //Console.WriteLine(EvaluateString.evaluate("100 * ( 2 + 12 ) / 14"));


            //// (((1-2)-3) + (4*(5+6)))
            //Node root = new Node('+', new Node('-', new Node('-', new Node("1"), new Node("2")), new Node("3")),
            //                            new Node('*', new Node("4"), new Node('+', new Node("5"), new Node("6"))));
            //Console.WriteLine("Prefix notation: \t" + root.Prefix());
            //Console.WriteLine("Postfix notation: \t" + root.Postfix());
            //Console.WriteLine("Infix notation: \t" + root.Infix());
            //Console.WriteLine("Solution for tree is:\t" + root.Solve());
            //Console.ReadKey(true);


            // var adsdsa = Convert.ToInt16("null".ToString());


            #endregion

            InputParameter parameter = new InputParameter();
            //parameter.RuleGroupName = "Bupa_Submission_Services";
            //parameter.KeyValue = BupaSubmissionServices();

            //parameter.RuleGroupName = "Submission_Patient";
            //parameter.KeyValue = PatientKeyValue();

            parameter.RuleGroupName = "TestGroup";
            parameter.KeyValue = GetKeyValue();
            var kkkss = CallService(parameter).ToString();

           Result result = JsonConvert.DeserializeObject<Result>(kkkss);
            string msg = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            var ruleGroupName = result.RuleGroupName;
            var ruleName = result.RuleName;
            if (result.MessageDetail!=null)
            foreach (var s in result.MessageDetail)
            {
                   
                    //if(!string.IsNullOrEmpty(s.Message))
                    msg += "\nRuleGroupName:" + ruleGroupName+":" + s.Message;

            }
            if (result.Data != null)
            {
                foreach (var ruleResult in result.Data)
                {
                   
                    if (ruleResult != null)
                        foreach (RuleResult res in ruleResult)
                        {
                            stringBuilder.Append("\nRuleGroupName: " + ruleGroupName+" - RuleId:"+ res.RuleId+ " \nResultName ::" + res.ResultName + "\nResultValue ::" + res.ResultValue + "\nSeverityId ::" + res.SeverityId + "\nSeverityName ::" + res.SeverityName + "\nSeverityLevelTypeId ::"+res.SeverityLevelTypeId +"\n--------------------------------------------------------------");
                        }
                    
                }
                Console.WriteLine("Status message: " + msg + "\n------------------------------------------------------------------" + "\nEvalution error details is ::"+"\n------------------------------------------------------------------------" + stringBuilder );
            }
            else
            {
                Console.WriteLine("Evalution Status is ::" + msg +"\n------------------------------------------------------------------");
            }


            Console.ReadLine();


        }



        public static object CallService(InputParameter parameter)
        {
            object response = null;
            try
            {
                var keyValue = GetKeyValue();
                string _BaseURL = "https://localhost:44391/";
                string serviceMethod = "api/RuleEngine/EvaluteRulesByRuleGroupNameAndInputField";
                string sResponse = string.Empty;
                string JSONRequest = Newtonsoft.Json.JsonConvert.SerializeObject(parameter);
                using (System.Net.WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";

                    System.Diagnostics.Debug.WriteLine(_BaseURL + serviceMethod);
                    try
                    {
                        sResponse = client.UploadString(_BaseURL + serviceMethod, "POST", JSONRequest);
                        var responseresult = Newtonsoft.Json.JsonConvert.DeserializeObject(sResponse);
                        response = responseresult;
                        // response = ((Newtonsoft.Json.Linq.JToken)responseresult).Root["token"].ToString();
                    }
                    catch (System.Net.WebException ex)
                    {
                        try
                        {
                            System.IO.Stream receiveStream = ex.Response.GetResponseStream();
                            System.IO.StreamReader readStream = new System.IO.StreamReader(receiveStream, System.Text.Encoding.UTF8);
                            string exceptionResponse = readStream.ReadToEnd();
                            sResponse += Environment.NewLine + exceptionResponse;
                            response = sResponse;
                        }
                        catch
                        { }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }


        public static object CallSetUpService(InputParameterSetUp parameter)
        {
            object response = null;
            try
            {
                InputParameterSetUp s = new InputParameterSetUp();
                s.LoginUser = "rcmuser";
                var keyValue = s;
                parameter = keyValue;
                string _BaseURL = "https://localhost:44320/";
                string serviceMethod = "api/Login/GetOTP";
                string sResponse = string.Empty;
                string JSONRequest = Newtonsoft.Json.JsonConvert.SerializeObject(parameter);
                using (System.Net.WebClient client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";

                    System.Diagnostics.Debug.WriteLine(_BaseURL + serviceMethod);
                    try
                    {
                        sResponse = client.UploadString(_BaseURL + serviceMethod, "GET", JSONRequest);
                        var responseresult = Newtonsoft.Json.JsonConvert.DeserializeObject(sResponse);
                        response = responseresult;
                        // response = ((Newtonsoft.Json.Linq.JToken)responseresult).Root["token"].ToString();
                    }
                    catch (System.Net.WebException ex)
                    {
                        try
                        {
                            System.IO.Stream receiveStream = ex.Response.GetResponseStream();
                            System.IO.StreamReader readStream = new System.IO.StreamReader(receiveStream, System.Text.Encoding.UTF8);
                            string exceptionResponse = readStream.ReadToEnd();
                            sResponse += Environment.NewLine + exceptionResponse;
                            response = sResponse;
                        }
                        catch
                        { }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }



        public class KeyValue
        {
            public string Keys { get; set; }
            public dynamic Values { get; set; }

            public KeyValue(string key, dynamic values)
            {
                Keys = key;
                Values = values;
            }
        }

        //public static string CallRestMethod()
        //{
        //    string url = string.Format("{0}/name?PrimaryName={1}", System.Configuration.ConfigurationManager.AppSettings["URLREST"], "yournmae");
        //    HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
        //    webrequest.Method = "GET";
        //    webrequest.ContentType = "application/x-www-form-urlencoded";           
        //    HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
        //    Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
        //    StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
        //    string result = string.Empty;
        //    result = responseStream.ReadToEnd();
        //    webresponse.Close();
        //    return result;
        //}

        public class InputParameterSetUp
        {
            public string LoginUser { get; set; }           
        }

        public class InputParameter
        {
            public string RuleGroupName { get; set; }
            public List<KeyValue> KeyValue { get; set; }
        }

        List<Result> lstresult = new List<Result>();
        public class Result
        {
            public string RuleGroupName { get; set; }
            public string RuleName { get; set; }
            public List<List<RuleResult>> Data { get; set; }
            public bool Status { get; set; }
            public List<MessageDetail> MessageDetail { get; set; }

        }

        public class RuleResult
        {

            //public int RuleResultId { get; set; }
            public int RuleId { get; set; }
            public string ResultName { get; set; }
            public string ResultValue { get; set; }
            public string SeverityName { get; set; }
            public string SeverityId { get; set; }
            public int SeverityLevelTypeId { get; set; }

            //public int? CreatedBy { get; set; }
            //public DateTime? CreatedOn { get; set; }
            //public int? ModifiedBy { get; set; }
            //public DateTime? ModifiedOn { get; set; }

        }

        public class MessageDetail
        {
            public int Code { get; set; }
            public string Message { get; set; }
            public string MessageN { get; set; }
        }



        //public class RootObject
        //{
        //    public List<List<object>> Data { get; set; }
        //    public bool Status { get; set; }
        //    public List<MessageDetail> MessageDetail { get; set; }
        //}


        public static T Add<T>(T a, T b)
        {
            // Declare the parameters
            var paramA = Expression.Parameter(typeof(T), "a");
            var paramB = Expression.Parameter(typeof(T), "b");

            // Add the parameters together
            BinaryExpression body = Expression.Add(paramA, paramB);

            // Compile it
            Func<T, T, T> add = Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();

            // Call it
            return add(a, b);
        }

        


        static void caller(String myclass, String mymethod)
        {
            MethodForRuleEngine objMethod = new MethodForRuleEngine(null, null);
            Type objMethodType = objMethod.GetType();
            object[] anArray = new object[1];
            anArray[0] = "2";
            MethodInfo mi = objMethodType.GetMethod("Func_Facilty_Available_Count", BindingFlags.Public | BindingFlags.IgnoreCase | BindingFlags.Instance);
            string ress = Convert.ToString(mi.Invoke(objMethod, anArray));         
        }

        //compare two table in one

        //var idsNotInB = TableA.AsEnumerable().Select(r => r.Field<int>("id"))
        //.Except(TableB.AsEnumerable().Select(r => r.Field<int>("id")));
        //DataTable TableC = (from row in TableA.AsEnumerable()
        //                    join id in idsNotInB
        //                    on row.Field<int>("id") equals id
        //                    select row).CopyToDataTable();


        public static void compareTwoandGetMatchingInTwoTable()
        {

            string diagnosis = "deepthi@gmail.com,divya@gmail.com";
            string Service = "deepthi@gmail.com,divya@gmail.com";
            List<string> diagnosisList = new List<string>();
            List<string> lstservice = new List<string>();
            diagnosisList = diagnosis.Split(',').ToList();
            lstservice = Service.Split(',').ToList();



        DataTable dt1 = new DataTable();
        dt1.Columns.Add(new DataColumn("registeredmails", typeof(string)));
        dt1.Rows.Add(new object[]{"deepthi@gmail.com,divya@gmail.com,indra@gmail.com,lavanya@gmail.com"});
        dt1.Rows.Add(new object[]{"lanadelray@gmail.com,digimanus@gmail.com,overflow@gmail.com,lennykravitz@gmail.com"});
        dt1.Rows.Add(new object[]{"gretavanfleet@gmail.com,direstraits@gmail.com,johnydeep@gmail.com,sia@gmail.com"});

            //var dt = dt1.AsEnumerable().Where(p => p.Field<string>("registeredmails").Any(Filter.Split(",")==p.Field<string>("registeredmails")));
            var result = (dt1.AsEnumerable()).Where(m => (diagnosisList).Any(r => r.Equals(m.Field<string>("registeredmails"))));

            //here it will filter data based on diagnosis
            var servicesFilterbyDiagnosis = dt1.AsEnumerable()
                .SelectMany(x => x.Field<string>("registeredmails").Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)) //split mails by delimiter
                .Where(m => diagnosisList.Contains(m)).ToList();


            //here it will show matched services
            var matchServices = servicesFilterbyDiagnosis                 
                .Where(m => lstservice.Contains(m)).ToList().Count;













            DataTable dt2 = new DataTable();
            dt2.Columns.Add(new DataColumn("loggedmails", typeof(string)));
            dt2.Rows.Add(new object[]{"divya@gmail.com"});
            dt2.Rows.Add(new object[]{"sia@gmail.com"});

            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add(new DataColumn("mail", typeof(string)));


        dtTemp = dt1.AsEnumerable()
        .SelectMany(x=>x.Field<string>("registeredmails").Split(new string[]{","}, StringSplitOptions.RemoveEmptyEntries)) //split mails by delimiter
        .Where(m=> dt2.AsEnumerable().Any(d=>d.Field<string>("loggedmails")==m)) //get equal data
        .Select(t=> dtTemp.LoadDataRow(new object[]{t}, false)) //convert IEnumerable<string> into set of DataRow
        .CopyToDataTable(); //copy data into final DataTable
	
        //dtTemp contains equal data (mails):
        //divya@gmail.com 
        //sia@gmail.com 
        }


        public static void MappedDiagnosisWithServiceAndGetMatchedOrNot()
        {
            int i = 0;
            List<DiagnosisAndService> lstDiagnosisAndServices = new List<DiagnosisAndService>();
            List<Services> lstServices = new List<Services>();
            List<Diagnosis> lstDiagnoses = new List<Diagnosis>();

            lstDiagnosisAndServices.Add(new DiagnosisAndService() { Id = 1, ServiceName = "ADVANCED PERIODONTAL TREATMENT PER QUADRANT", DiagnosisCode = "K05", DiagnosisName = "Gingivitis and periodontal diseases" });
            lstDiagnosisAndServices.Add(new DiagnosisAndService() { Id = 2, ServiceName = "CHEST X RAY PORTABLE (ONE VIEW)", DiagnosisCode = "R07.4", DiagnosisName = "Chest pain, unspecified" });
            lstDiagnosisAndServices.Add(new DiagnosisAndService() { Id = 3, ServiceName = "REFRACTION (BOTH EYES)", DiagnosisCode = "Z01.0", DiagnosisName = "Examination of eyes and vision" });
            lstDiagnosisAndServices.Add(new DiagnosisAndService() { Id = 4, ServiceName = "BUN (S)", DiagnosisCode = "N20", DiagnosisName = "Calculus of kidney and ureter" });
            lstDiagnosisAndServices.Add(new DiagnosisAndService() { Id = 5, ServiceName = "K (S)", DiagnosisCode = "N20", DiagnosisName = "Calculus of kidney and ureter" });
            lstDiagnosisAndServices.Add(new DiagnosisAndService() { Id = 6, ServiceName = "NA (S)", DiagnosisCode = "N20", DiagnosisName = "Calculus of kidney and ureter" });
            lstDiagnosisAndServices.Add(new DiagnosisAndService() { Id = 7, ServiceName = "CBC (COMPLETE BLOOD COUNT PROFILE)", DiagnosisCode = "N20", DiagnosisName = "Calculus of kidney and ureter" });
            lstDiagnosisAndServices.Add(new DiagnosisAndService() { Id = 8, ServiceName = "CT SCAN - RENAL/ URETERAL CALCULUS", DiagnosisCode = "N20", DiagnosisName = "Calculus of kidney and ureter" });

            //services List
            lstServices.Add(new Services() { ServiceName = "BUN (S)" });
            lstServices.Add(new Services() { ServiceName = "K (S)" });
            lstServices.Add(new Services() { ServiceName = "NA (S)" });
            lstServices.Add(new Services() { ServiceName = "CBC (COMPLETE BLOOD COUNT PROFILE)" });
            lstServices.Add(new Services() { ServiceName = "CT SCAN - RENAL/ URETERAL CALCULUS" });
            lstServices.Add(new Services() { ServiceName = "ADVANCED PERIODONTAL TREATMENT PER QUADRANT" });


            //diagnosis list
            lstDiagnoses.Add(new Diagnosis() { DiagnosisName = "Gingivitis and periodontal diseases" });
            lstDiagnoses.Add(new Diagnosis() { DiagnosisName = "Calculus of kidney and ureter" });



            // Filter Data from Mapping Table based on Diagnosis list and Get All Services reated to those Diagnosis.
            var ServiceDetails = lstDiagnosisAndServices.Where(s => lstDiagnoses.Select(ks=>ks.DiagnosisName).Contains(s.DiagnosisName)).ToList();

            //To get Matched services from inputed services..or we can get count also if it will match 
            var ResultantList = ServiceDetails.Where(s => lstServices.Any(l => (l.ServiceName == s.ServiceName))).ToList();

            //Grouped Result by Diagnosis Code
            var groupedResultList = ResultantList
                                    .GroupBy(u => u.DiagnosisCode)
                                    .Select(grp => grp.ToList())
                                    .ToList();
            StringBuilder sb = new StringBuilder();
           
             
            foreach (var diagnoses in groupedResultList)
            {
                i = 1;
                sb.Append("Result:Matched with given Diagnosis.\n");
                sb.Append("-------------------------------------\n");
                sb.Append("\nFor Diagnosis" + ":");
                sb.Append("("+diagnoses.Select(s => s.DiagnosisName).FirstOrDefault().ToString()+")"+":: matched services are as below. \n");
                foreach(var service in diagnoses)
                {
                   
                    sb.Append(""+i+++":-"+service.ServiceName+"\n");
                }
                sb.Append("\n");
            }

            var message = sb.ToString();



        }

        public class DiagnosisAndService
        {
            public int Id { get; set; }
            public string  ServiceName { get; set; }
            public string DiagnosisCode { get; set; }
            public string DiagnosisName { get; set; }
        }


        public class Services
        {
            public string ServiceName { get; set; }
        }

        public class Diagnosis
        {
            public string DiagnosisName { get; set; }
        }



    }
}
