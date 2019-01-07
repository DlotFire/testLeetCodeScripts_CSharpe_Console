
namespace DesignMethod.TemplateMethodPattern
{
    public class Program : OpenDesign
    {
        public override void Open()
        {
            Spinach spinach = new Spinach();
            spinach.CookVegetabel();
        }
    }
}