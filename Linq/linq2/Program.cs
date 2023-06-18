using System;
using System.Xml.Linq;

namespace Program // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      XMlLinq();
    }
    public static void XMlLinq()
    {
      var students =
    @"
          <Students>
            <Student>
              <Name>Thomas</Name>
              <Age>21</Age>
              <University>Yale</University>
            </Student>
            <Student>
              <Name>Daniel</Name>
              <Age>23</Age>
              <University>Bejin</University>
            </Student>
            <Student>
              <Name>Lucien</Name>
              <Age>20</Age>
              <University>Harvard</University>
            </Student>
          </Students>
        ";
      XDocument xDocument = new XDocument();
      xDocument = XDocument.Parse(students);
      var query = from student in xDocument.Descendants("Student")
                  select new
                  {
                    Name = student.Element("Name").Value,
                    Age = int.Parse((student.Element("Age")).Value),
                  };
      foreach (var item in query)
      {
        System.Console.WriteLine(item);
      }
    }
  }
}