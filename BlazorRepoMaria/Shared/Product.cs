using System;
using System.Collections.Generic;
using System.Text;
using RepoDb;
using RepoDb.Attributes;

namespace BlazorRepoMaria.Shared
{

    // 
    // CREATE TABLE products(id INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    //  name VARCHAR(255) NOT NULL,
    //  price DECIMAL(9,2) NOT NULL,
    //  stock INTEGER NOT NULL,
    //  attr VARCHAR(1024));
    //
    [Map("product")]
    public record Product(int Id, string Name,decimal Price,int Stock, string Attr);

}
