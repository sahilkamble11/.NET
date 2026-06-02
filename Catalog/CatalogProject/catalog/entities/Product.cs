namespace com.transflower.catalog.entities
{
    public class Product
    {
        private int id;
        private string title;
        private string description;
        private decimal price;
        private int stock;
        private int likes;

        Product()
        {
            this.id = 0;
            this.title = "";
            this.description = "";
            this.price = 0;
            this.stock = 0;
            this.likes = 0;
        }

        Product(int id, string title, string description, decimal price, int stock, int likes)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.price = price;
            this.stock = stock;
            this.likes = likes;
        }

        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }   
        public string GetTitle()
        {
            return this.title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetDescription()
        {
            return this.description;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public decimal GetPrice()
        {
            return this.price;
        }
        public void SetPrice(decimal price)
        {
            this.price = price;
        }
        public int GetStock()
        {
            return this.stock;
        }
        public void SetStock(int stock)
        {
            this.stock = stock;
        }
        public int GetLikes()
        {
            return this.likes;
        }
        public void SetLikes(int likes)
        {
            this.likes = likes;
        }

        ~Product()
        {
        }
    }
}