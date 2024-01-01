using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Bar_Management.Tool {
    public class Internet {
        public static bool IsInternetAvailable() {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        public static byte[] LoadImageFromUrl(string url) {
            
            using (WebClient client = new WebClient()) {
                try {
                    return client.DownloadData(url);
                } catch (System.Exception) {
                    //erro image
                    return client.DownloadData("https://res.cloudinary.com/dift2vpcj/image/upload/v1704122255/images_coscki.png");
                }
                
            }
        }
    }
}
