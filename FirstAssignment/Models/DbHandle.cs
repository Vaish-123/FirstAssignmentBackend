namespace FirstAssignment.Models
{
    public class DbHandle
    {
        DbConnect obj = new DbConnect();
        public List<Customer> GetCustomer()
        { 
            List<Customer> clist = obj.customerTB.ToList();
            return clist;
        }
        public List<Product> GetProduct(int id)
        {
            List<Product> plist = obj.productTB.Where(e=>e.Pid==id).ToList();
            return plist;
        }
        public void AddCustomer(Customer c)
        { 
            obj.customerTB.Add(c);
            obj.SaveChanges();
        }
        public void AddProduct(Product p)
        {
            obj.productTB.Add(p);
            obj.SaveChanges();
        }
        public void DeleteCustomer(int id)
        {
            List<Product> plist = obj.productTB.Where(e => e.Pid == id).ToList();
            for (int i = plist.Count(); i > 0; i--)
            { 
                obj.productTB.Remove(obj.productTB.FirstOrDefault(p => p.Pid == id));
                obj.SaveChanges();
            }
            Customer cus = obj.customerTB.Find(id);
            obj.customerTB.Remove(cus);
            obj.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            obj.productTB.Remove(obj.productTB.FirstOrDefault(p => p.ProdKey == id));
            obj.SaveChanges();
        }
        public void UpdateProduct(Product p)
        {
            Product prod = obj.productTB.Find(p.ProdKey);
            prod.Pid= p.Pid;
            prod.Pname = p.Pname;
            prod.Pquantity = p.Pquantity;
            prod.Pprice = p.Pprice;
            prod.Pamount = p.Pamount;
            obj.SaveChanges();
        }
        public Product GetProductById(int id)
        {
            Product prod = obj.productTB.FirstOrDefault(p => p.ProdKey == id);
            return prod;
        }
    }
}
