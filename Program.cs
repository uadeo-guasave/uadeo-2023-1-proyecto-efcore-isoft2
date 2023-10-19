// conectar a la base de datos
using MisLibrosNet.Models;

using var db = new SqliteDbContext();

// var autor1 = new Autor { Nombres = "Omar", Apellidos = "Chorohui" };

// db.Add(autor1);
// db.SaveChanges();

// Autor? omar = db.Autores.Find(2);
// omar.Apellidos = "Cervantes Montes";
// db.SaveChanges();

// var autor3 = new Autor { Nombres = "Bryan", Apellidos = "Lopez^2" };
// db.Add(autor3);
// db.SaveChanges();

// Autor? bryan = db.Autores.Find(3);
// db.Remove(bryan);
// db.SaveChanges();