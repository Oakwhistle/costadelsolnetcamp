using Microsoft.EntityFrameworkCore.Migrations;

namespace costadelsoltapas.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Classic", "From the good ol' grandma's recipes book. This tapas continue to stand the test of time, just as granny does." });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Fusion", "From the chef's imagination to your table. The best combinations are sometimes the weidest. Dare to try?" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Gourmet", "Carefully curated selection of Tapas for the more educated palate." });

            migrationBuilder.InsertData(
                table: "Tapas",
                columns: new[] { "TapasID", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsTapasOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://lacocinadefrabisa.lavozdegalicia.es/wp-content/uploads/2019/05/tortilla-española.jpg", "https://lacocinadefrabisa.lavozdegalicia.es/wp-content/uploads/2019/05/tortilla-española.jpg", true, false, " The absolute classic. Found everywhere in Spain, it is not hard to see why this is an staple tapa in a culture where the quality of food is of upmost importance.", "Tortilla de Patatas", 5.95m, "Simple yet delicious." },
                    { 2, null, 1, "http://www.importdelicia.com/contenido/noticias/600_img_36.jpg", "http://www.importdelicia.com/contenido/noticias/600_img_36.jpg", true, false, "Bite sized croquettes filled with the best Jamon and gently fried in olive oil.", "Croquetas del Dia", 8.95m, "Delicate confection, strong flavor!" },
                    { 3, null, 1, "http://porsolea.com/wp-content/uploads/2017/04/pulpo-a-la-gallega-2.jpg", "http://porsolea.com/wp-content/uploads/2017/04/pulpo-a-la-gallega-2.jpg", true, true, "Despite being originally from the northern regions of Spain, this traditional Galician octopus dish is a star of the spanish cuisine.", "Polbo a Feira", 12.95m, "Lets see what Paul the octopus has to say." },
                    { 4, null, 2, "https://jamonesjuanpedrodomecq.com/wp-content/uploads/2019/05/Tapas-españolas.jpg", "https://jamonesjuanpedrodomecq.com/wp-content/uploads/2019/05/Tapas-españolas.jpg", true, true, "Handmade bread, toasted and crowned with the best toppings choosed by the chef according with the current season.", "Tostas Costa del Sol", 20.95m, "The most versatile tapas made with the best ingredients, all year long." },
                    { 5, null, 3, "https://www.ibericosguillen.com/tienda/wp-content/uploads/2018/10/Jamon-iberico-bellota-50-Guillen-1-1.jpg", "https://www.ibericosguillen.com/tienda/wp-content/uploads/2018/10/Jamon-iberico-bellota-50-Guillen-1-1.jpg", true, true, "The best Jamon Iberico 100% Bellota carefully sliced and presented by an expert of the craft. The best of the best. The Ballon d'Or of the Tapas. ", "Jamon Iberico", 20.95m, "A tapa you will not forget." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tapas",
                keyColumn: "TapasID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tapas",
                keyColumn: "TapasID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tapas",
                keyColumn: "TapasID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tapas",
                keyColumn: "TapasID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tapas",
                keyColumn: "TapasID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
