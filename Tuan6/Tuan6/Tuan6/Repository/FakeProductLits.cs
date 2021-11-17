using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tuan6.Models;

namespace Tuan6.Repository
{
    public static class FakeProductList
    {
        public static List<Product> GetProducts()
        {
            List<Product> lst = new List<Product>();
            Random rad = new Random();
            for (int i = 0; i < 4; i++)
            {
                lst.AddRange(new List<Product>
                {
                    new Product
                    {
                        Title = "Sách Thương Mại Điện Tử" ,
                        Description = "Sản phẩm mới được ra mắt",
                        Price = 6555665,
                        Available = 12,
                        ListType = ListType.Favorites
                    },
                    new Product
                    {
                        Title = "Sách Hệ Thống Thông Tin" ,
                        Description = "Sách được bán ra với giá cao nhất",
                        Price = 57575457,
                        Available = 6,
                        ListType = ListType.Favorites
                    },
                    new Product
                    {
                        Title = "Sách Phân Tích Thiết Kế" ,
                        Description = "Độc quyền của HUTECH",
                        Price =77847474747,
                        Available = 3,
                        ListType = ListType.Favorites
                    },
                    new Product
                    {
                        Title = "Laptop DELL E5440" ,
                        Description = "Đây là sản phẩm công nghệ laptop",
                        Price =1414141474,
                        Available = 5,
                        ListType = ListType.WishList
                    },
                    new Product
                    {
                        Title = "Tivi Sony A567" ,
                        Description = "Sản phẩm công nghệ 4K",
                        Price = 757614147,
                        Available = 3,
                        ListType = ListType.WishList
                    },
                    new Product
                    {
                        Title = "Máy Giặt LG87" ,
                        Description = "Giặt sạch lắm ",
                        Price =4474767678,
                        Available = 12,
                        ListType = ListType.WishList
                    }
                });
            }
            return lst;

        }
    }
}