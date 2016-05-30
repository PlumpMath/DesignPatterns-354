using DesignPatterns.StructuralPattern.Composite.CustomComponent;

namespace DesignPatterns.StructuralPattern.Composite
{
    public class CompositeTest : PatternTest
    {
        public CompositeTest() : base("Composite")
        {
        }


        public override void Run()
        {
            var discC = new Directory("Disc C");
            var folder1 = new Directory("Folder 1");

            var filePdf = new File("pdfFile.pdf");
            var fileJpg = new File("jpgFile.pdf");
            var fileBmp = new File("bmpFile.pdf");

            folder1.Add(fileBmp);
            discC.Add(folder1);
            discC.Add(filePdf);
            discC.Add(fileJpg);

            discC.PrintInfo();
        }
    }
}