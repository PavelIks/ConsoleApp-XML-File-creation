using System.Xml.Linq;

namespace XMLFileCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xDocument1 = new XDocument
                (
                    new XElement("phones",

                    new XElement("phone",
                    new XAttribute("company", "Nokia"),
                    new XAttribute("model", "216"),
                    new XAttribute("screenSize", "2.4"),
                    new XAttribute("price", "50"),
                    new XAttribute("color", "Grey"),
                    new XAttribute("status", "New"),
                    new XAttribute("memory", "0.16")),

                    new XElement("phone",
                    new XAttribute("company", "Nokia"),
                    new XAttribute("model", "210 DS"),
                    new XAttribute("screenSize", "2.4"),
                    new XAttribute("price", "40"),
                    new XAttribute("color", "Black"),
                    new XAttribute("status", "New"),
                    new XAttribute("memory", "0.16")),

                    new XElement("phone",
                    new XAttribute("company", "Nokia"),
                    new XAttribute("model", "7.1 DS"),
                    new XAttribute("screenSize", "5.84"),
                    new XAttribute("price", "200"),
                    new XAttribute("color", "Indigo"),
                    new XAttribute("status", "New"),
                    new XAttribute("memory", "32")),

                    new XElement("phone",
                    new XAttribute("company", "Nokia"),
                    new XAttribute("model", "X7"),
                    new XAttribute("screenSize", "6.18"),
                    new XAttribute("price", "250"),
                    new XAttribute("color", "Blue"),
                    new XAttribute("status", "New"),
                    new XAttribute("memory", "64")),

                    new XElement("phone",
                    new XAttribute("company", "Nokia"),
                    new XAttribute("model", "X2-02"),
                    new XAttribute("screenSize", "2.2"),
                    new XAttribute("price", "15"),
                    new XAttribute("color", "Blue"),
                    new XAttribute("status", "Ref"),
                    new XAttribute("memory", "0.128"))));

            xDocument1.Save("Phones_Data.xml");
        }
    }
}