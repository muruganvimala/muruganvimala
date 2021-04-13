using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using mshtml;
namespace Pro1
{
    /// <summary>
    /// Interaction logic for ReadContentsPage.xaml
    /// </summary>
    public partial class ReadContentsPage : Page
    {
        DataTable dtVideos = new DataTable();
        DataTable dtAdditionalContent = new DataTable();
       
        string FilePath = string.Empty;
       
        public ReadContentsPage()
        {
            InitializeComponent();
            dtVideos.Columns.Add("VideoName", typeof(string));
            dtVideos.Columns.Add("VideoPath", typeof(string));

            Globals.strSubjectId = "600a61654023ca03ccc4c811";
        }
        public ReadContentsPage(string istrSubjectId)
        {            
            InitializeComponent();
            //Globals.strSubjectId = "600a61654023ca03ccc4c811";
            Globals.strSubjectId = istrSubjectId;
        }

        private void wbcontentNavigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            //txtUrl.Text = e.Uri.OriginalString;
        }
        private void BrowseBack_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //e.CanExecute = ((wbcontent != null) && (wbcontent.CanGoBack));
        }
        private void BrowseBack_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //wbcontent.GoBack();
        }
        private void BrowseForward_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //e.CanExecute = ((wbcontent != null) && (wbcontent.CanGoForward));
        }

        private void BrowseForward_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //wbcontent.GoForward();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            List<Bookinfo> items = new List<Bookinfo>(); 
            FilePath = ConfigurationManager.AppSettings["srvrfilepath"];
            //Parent
            string jsonFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"Assets\Data\Units.json");

            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                var UnitsJsonResult = JsonConvert.DeserializeObject<List<SubContentClass>>(json).Where(n => n.SubjectId == Globals.strSubjectId).Select(a => a.Units);

                if (UnitsJsonResult.Count() > 0)
                {
                    for (int i = 0; i < UnitsJsonResult.ElementAt(0).Count(); i++)
                    {                      
                       string IndexHeadNamevalue = UnitsJsonResult.ElementAt(0).ElementAt(i).UnitName;

                        for (int j = 0; j < UnitsJsonResult.ElementAt(0).ElementAt(i).SessionDetails.Count(); j++)
                        {                           
                            string IndexNameValue = UnitsJsonResult.ElementAt(0).ElementAt(i).SessionDetails[j].SessionName;
                            string UnitIdValue = UnitsJsonResult.ElementAt(0).ElementAt(i).UnitId;
                            string SessionIdValue = UnitsJsonResult.ElementAt(0).ElementAt(i).SessionDetails[j].SessionId;
                            items.Add(new Bookinfo() {  IndexHeadName = IndexHeadNamevalue , IndexName = IndexNameValue, UnitId = UnitIdValue, SessionId = SessionIdValue });
                            //, UnitId = UnitIdValue, SessionId  = SessionIdValue
                        }
                    }
                }
                //end if               
                
                tocdataGrid.ItemsSource = items;               
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(tocdataGrid.ItemsSource);
                PropertyGroupDescription groupDescription = new PropertyGroupDescription("IndexHeadName");
                view.GroupDescriptions.Add(groupDescription);              

            }
        }
        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as System.Windows.Controls.ListViewItem;
            if (item != null)
            {            
                
                string strUnitId = ((Pro1.Bookinfo)item.DataContext).UnitId;
                string strSessionId = ((Pro1.Bookinfo)item.DataContext).SessionId;
                if (!string.IsNullOrEmpty(strSessionId))
                {
                    string jsonFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"Assets\Data\Contents.json");
                    if (File.Exists(jsonFilePath))
                    {
                        string json = File.ReadAllText(jsonFilePath);
                        var UnitsJsonResult = (JsonConvert.DeserializeObject<List<ContentClass>>(json)).Where(n => n.SubjectId == Globals.strSubjectId && n.UnitId == strUnitId && n.SessionId == strSessionId).Select(a => a);
                        ContentClass objContentClass = new ContentClass();
                        string strfilepath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), (@"Assets\Data\Images\SubjectImages\" + Globals.strSubjectId + @"\"));
                        if (UnitsJsonResult.Count() > 0)
                        {
                            StringBuilder strContent = new StringBuilder();
                            string strContentText = UnitsJsonResult.First().Content.ToString();
                            if (!string.IsNullOrEmpty(strContentText))
                            {
                                //strContent.Append("<html><head></head><body><div onselectstart=""return false;"" style=""-moz-user-select: none;""><div class=\"ps-content\" style=\"font-family: sans-serif;\">");
                                strContent.Append("<html><head></head><body><div class=\"ps-content\" style=\"font-family: sans-serif;\">");
                                strContentText = strContentText.Replace("http://192.168.2.202:2504/public\\data\\content\\Images\\", strfilepath);
                                //strContent.Append(UnitsJsonResult.First().Content.ToString());
                                strContent.Append(strContentText);
                                strContent.Append("</div></html>");
                                MemoryStream stream = new MemoryStream();
                                StreamWriter writer = new StreamWriter(stream);
                                writer.Write(strContent);
                                writer.Flush();
                                stream.Position = 0;
                                System.Windows.Forms.WebBrowser wb;
                                wb = (wfhSample.Child as System.Windows.Forms.WebBrowser);
                                wb.DocumentStream = stream;
                                //(wfhSample.Child as System.Windows.Forms.WebBrowser).Navigate("http://www.google.de/");
                                //wbcontent.NavigateToStream(stream);
                                //wbSample.Navigate("http://www.wpf-tutorial.com");
                            }
                        }
                    }                    
                }
            }
        }

        private void bookmartbtn_Click(object sender, RoutedEventArgs e)
        {
            //wbcontent.GoBack();
        }      
        
       

        private void wbcontent_LoadCompleted(object sender, NavigationEventArgs e)
        {
            
        }

        private bool NewClickEventHandler(IHTMLEventObj pEvtObj)
        {
            throw new NotImplementedException();
           
        }

        private void wbcontent_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

       

        

        private void WebBrowser_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            System.Windows.Forms.WebBrowser wb;
            wb = (wfhSample.Child as System.Windows.Forms.WebBrowser);            
            wb.Document.Body.MouseDown += new HtmlElementEventHandler(Body_MouseDown);
        }
        private void Body_MouseDown(object sender, HtmlElementEventArgs e)
        {
            System.Windows.Forms.WebBrowser wb;
            wb = (wfhSample.Child as System.Windows.Forms.WebBrowser);
            switch (e.MouseButtonsPressed)
            {
                case MouseButtons.Left:
                    HtmlElement element = wb.Document.GetElementFromPoint(e.ClientMousePosition);
                    string elementattr = string.Empty;
                    elementattr = element.GetAttribute("classname").ToUpper();
                    if (elementattr == "TEACHING" || elementattr == "CONCEPT")
                    {
                        string strconceptvideolink = element.OuterHtml;
                        string strConVideopath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), (@"Assets\Data\Videos\" + (elementattr == "TEACHING" ? "Teaching_Videos" : "Concept_Videos") + @"\" + Globals.strSubjectId + @"\"));
                        List<string> lstLinks = ExtractLinks(strconceptvideolink);
                        if (lstLinks.Count > 0)
                        {
                            string[] links = lstLinks[0].Split('|');
                            dtVideos.Clear();
                            for (int i = 0; i < links.Count(); i++)
                            {
                                string[] videolnk = links[i].Split('~');
                                if (videolnk.Count() > 0)
                                {
                                    DataRow dr = dtVideos.NewRow();
                                    dr["VideoName"] = videolnk[0];
                                    //dr["VideoPath"] = videolnk[1].Replace("https:/www.youtube.com/embed/", "");
                                    videolnk[1] = videolnk[1].Replace("?rel=0", "");
                                    videolnk[1] = videolnk[1].Replace("https:/www.youtube.com/embed/", strConVideopath);                                   
                                    dr["VideoPath"] = videolnk[1];
                                    dtVideos.Rows.Add(dr);
                                }
                            }
                           string webvideoContents = "";
                            
                            for (int i = 0; i < dtVideos.Rows.Count; i++)
                            {
                                //MediaElement bookmedia = new MediaElement();
                                //bookmedia.Source = new Uri(dtVideos.Rows[i]["VideoPath"].ToString() + ".mp4", UriKind.RelativeOrAbsolute);
                                //videopanel.Children.Add(bookmedia);
                                webvideoContents += "<video preload=\"metadata\" height=\"200\"><source src=\"" + dtVideos.Rows[i]["VideoPath"].ToString() + ".mp4\"" + " " + "type = \"video/mp4\"></video >";
                                webvideoContents += "<div style=\"background - color: #faebd7;\"><p><b>" + dtVideos.Rows[i]["VideoName"].ToString() + " </b></p></div>";

                            }
                            //add in web browser
                            if (!string.IsNullOrEmpty(webvideoContents))
                            {
                                webvideoContents = "<html><head>" + "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=9\"/>" + "</head><body>" + webvideoContents + "</body></html> "; ;
                                MemoryStream stream = new MemoryStream();
                                StreamWriter writer = new StreamWriter(stream);
                                writer.Write(webvideoContents);
                                writer.Flush();
                                stream.Position = 0;
                                System.Windows.Forms.WebBrowser videowb;
                                videowb = (myvideobrw.Child as System.Windows.Forms.WebBrowser);                               
                                videowb.DocumentStream = stream;
                                //leftbrowser.NavigateToStream(stream);

                            }
                        }
                    }
                        break;
            }
        }
        public static List<string> ExtractLinks(string htmlString)
        {
            List<string> list = new List<string>();
            //string anchorStart = "<a";
            //string anchorEnd = "</a>";
            string anchorText = string.Empty;
            //Regex regex = new Regex("(?:href)=[\"|']?(.*?)[\"|'|>]+", RegexOptions.Singleline | RegexOptions.CultureInvariant);
            Regex regex = new Regex("(?:href)=[\"']?(.*?)[\"'>]+", RegexOptions.Singleline | RegexOptions.CultureInvariant);
            if (regex.IsMatch(htmlString))
            {
                foreach (Match match in regex.Matches(htmlString))
                {
                    try
                    {
                        string strURL = match.Groups[1].Value; // should contain the HRF URL                       
                        anchorText = strURL;
                    }
                    catch (Exception ex)
                    {
                        // Log Exception in parsing the anchor Text 
                    }

                    if (!list.Contains(anchorText))
                    {
                        list.Add(anchorText);// Append URL and Text using semicolun as seperator.  
                    }
                }
            }

            return list;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            System.Windows.Forms.WebBrowser myvideobr;
            myvideobr = (myvideobrw.Child as System.Windows.Forms.WebBrowser);
            myvideobr.Document.Body.MouseDown += new HtmlElementEventHandler(videowebBrowser_MouseDown);
        }

        private void videowebBrowser_MouseDown(object sender, HtmlElementEventArgs e)
        {
            System.Windows.Forms.WebBrowser myvideobr;
            myvideobr = (myvideobrw.Child as System.Windows.Forms.WebBrowser);
            HtmlElement element = myvideobr.Document.GetElementFromPoint(e.ClientMousePosition);
            if (Regex.IsMatch(element.InnerHtml, "<source src="))
            {                
                string videoContents = "<html><head>" + "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" + "</head><body><video width=\"600\" height=\"400\" controls autoplay>" + element.InnerHtml + "</video></body></html> ";
                MemoryStream stream = new MemoryStream();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(videoContents);
                writer.Flush();
                stream.Position = 0;
                //wfhSample'
                System.Windows.Forms.WebBrowser wf;
                wf = (wfhSample.Child as System.Windows.Forms.WebBrowser);
                wf.DocumentText = string.Empty;
                wf.DocumentStream = stream;                
            }
        }

        private void searchbutton_Click(object sender, RoutedEventArgs e)
        {
            //searchtxt
            System.Windows.Forms.WebBrowser wb;
            wb = (wfhSample.Child as System.Windows.Forms.WebBrowser);
            HtmlElement doc = wb.Document.DomDocument as HtmlElement;
        }
    }
    public class SubContentClass
    {
        public string SubjectId { get; set; }
        public List<IndexClass> Units { get; set; }
    }
    public class IndexClass
    {
        public string UnitId { get; set; }
        public string UnitName { get; set; }
        public List<SessionClass> SessionDetails { get; set; }
    }
    public class SessionClass
    {
        public string SessionId { get; set; }
        public string SessionName { get; set; }
    }

    public class ContentClass
    {
        public string _id { get; set; }
        public string SubjectId { get; set; }
        public string UnitId { get; set; }
        public string SessionId { get; set; }
        public string Content { get; set; }

    }

    public class AdditionalContentClass
    {
        public string _id { get; set; }
        public string SubjectId { get; set; }
        public string UnitId { get; set; }
        public string SessionId { get; set; }
        public string Content { get; set; }
        public string LinkWord { get; set; }
    }
    public class Bookinfo
    {
        public string UnitId { get; set; }
        public string SessionId { get; set; }
        public string IndexHeadName { get; set; }
        public string IndexName { get; set; }

    }
}
