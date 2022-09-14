using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//ProductManager productManager = new ProductManager(new EfProductDal());
//foreach (var item in productManager.GetAllByCategoryId(4))
//{
//    Console.WriteLine(item.ProductName);
//}
C GetC = new C();
Console.WriteLine(GetC.B);
public class C
{
    string a = "anan";
    public ref readonly string B => ref a;


}
#region
d
a
    c
#endregion