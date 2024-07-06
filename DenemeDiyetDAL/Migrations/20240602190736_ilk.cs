using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenemeDiyetDAL.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YemekKategorileris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekAdı = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekKategorileris", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yemeks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekAdı = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemeks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YemekTarihis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yemek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplamKalori = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YemekKategorileri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yiyecek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Olcu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplamYag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplamProtein = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplamKarbonhidrat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekTarihis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yiyeceks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adı = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Olcu = table.Column<double>(type: "float", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: false),
                    Yağ = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yiyeceks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "YiyecekYemekKategoris",
                columns: table => new
                {
                    YiyecekID = table.Column<int>(type: "int", nullable: false),
                    YemekKategorileriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YiyecekYemekKategoris", x => new { x.YiyecekID, x.YemekKategorileriID });
                    table.ForeignKey(
                        name: "FK_YiyecekYemekKategoris_YemekKategorileris_YemekKategorileriID",
                        column: x => x.YemekKategorileriID,
                        principalTable: "YemekKategorileris",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YiyecekYemekKategoris_Yiyeceks_YiyecekID",
                        column: x => x.YiyecekID,
                        principalTable: "Yiyeceks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "YemekKategorileris",
                columns: new[] { "ID", "YemekAdı" },
                values: new object[,]
                {
                    { 1, "Kahvaltı" },
                    { 2, "Tahıl Ürünleri" },
                    { 3, "Süt Ürünleri" },
                    { 4, "Sebzeler" },
                    { 5, "Atıştırmalık" },
                    { 6, "Haşlanmış Sebzeler" },
                    { 7, "Salata" },
                    { 8, "Yağlar" },
                    { 9, "Çorbalar" }
                });

            migrationBuilder.InsertData(
                table: "Yemeks",
                columns: new[] { "ID", "YemekAdı" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "Yiyeceks",
                columns: new[] { "ID", "Adı", "Kalori", "Karbonhidrat", "Olcu", "Protein", "Yağ" },
                values: new object[,]
                {
                    { 1, " Peynirli Omlet", 254.0, 2.0499999999999998, 1.0, 15.369999999999999, 14.9 },
                    { 2, "Mantarlı Omlet", 205.0, 3.6899999999999999, 1.0, 12.460000000000001, 9.9000000000000004 },
                    { 3, "Menemen ", 205.0, 3.6899999999999999, 1.0, 12.460000000000001, 9.9000000000000004 },
                    { 4, " Kaşarlı Omlet", 260.30000000000001, 2.2000000000000002, 1.0, 20.27, 13.289999999999999 },
                    { 5, "Sebzeli Omlet", 205.0, 3.6899999999999999, 1.0, 12.460000000000001, 9.9000000000000004 },
                    { 6, "Yulaflı Omlet", 258.0, 14.4, 1.0, 14.52, 10.800000000000001 },
                    { 7, "Sandviç ekmeği(beyaz)", 264.0, 48.600000000000001, 1.0, 8.9000000000000004, 3.2000000000000002 },
                    { 8, "Sandviç ekmeği(cok tahıllı)", 312.0, 57.600000000000001, 1.0, 9.5999999999999996, 2.3999999999999999 },
                    { 9, "Musli", 340.0, 62.0, 1.0, 10.0, 6.0 },
                    { 10, "Mısır gevregi", 356.0, 84.0, 1.0, 7.4000000000000004, 0.40000000000000002 },
                    { 11, "Beyaz peynir", 162.0, 0.0, 1.0, 14.1, 14.0 },
                    { 12, "Labne peyniri", 213.5, 3.5, 1.0, 6.7000000000000002, 19.300000000000001 },
                    { 13, "Hellim peyniri", 320.0, 2.7999999999999998, 1.0, 21.0, 25.0 },
                    { 14, "Kefir", 63.0, 5.2000000000000002, 1.0, 3.2999999999999998, 3.2000000000000002 },
                    { 15, "Meyveli kefir", 78.0, 10.0, 1.0, 2.7000000000000002, 3.0 },
                    { 16, "Suzme Yogurt", 106.0, 5.0, 1.0, 8.0, 6.0 },
                    { 17, "Yogurt", 61.0, 4.5999999999999996, 1.0, 3.4199999999999999, 3.25 },
                    { 18, "Meyveli Yogurt", 93.0, 15.0, 1.0, 3.1000000000000001, 2.1000000000000001 },
                    { 19, "Ayran", 32.0, 2.0, 1.0, 2.0, 1.8 },
                    { 20, "Cacik", 41.0, 3.8999999999999999, 1.0, 3.0, 0.0 },
                    { 21, "Grissini", 396.0, 74.939999999999998, 1.0, 10.210000000000001, 4.79 },
                    { 22, "Elma", 57.0, 15.0, 1.0, 0.29999999999999999, 0.20000000000000001 },
                    { 23, "Armut", 60.0, 16.199999999999999, 1.0, 0.40000000000000002, 0.20000000000000001 },
                    { 24, "Portakal", 48.299999999999997, 12.6, 1.0, 1.23, 0.10000000000000001 },
                    { 25, "Greyfurt", 41.600000000000001, 10.4, 1.0, 0.80000000000000004, 0.10000000000000001 },
                    { 26, "Mandalina", 49.0, 12.5, 1.0, 0.90000000000000002, 0.20000000000000001 },
                    { 27, "Kivi", 63.0, 15.0, 1.0, 1.2, 0.5 },
                    { 28, "Muz", 105.0, 26.949999999999999, 1.0, 1.29, 0.39000000000000001 },
                    { 29, "Avokado", 160.0, 8.5299999999999994, 1.0, 2.0, 14.66 }
                });

            migrationBuilder.InsertData(
                table: "Yiyeceks",
                columns: new[] { "ID", "Adı", "Kalori", "Karbonhidrat", "Olcu", "Protein", "Yağ" },
                values: new object[,]
                {
                    { 30, "Yesil Salata", 24.0, 5.0, 1.0, 1.3999999999999999, 0.20000000000000001 },
                    { 31, "Tavuk Salatası", 65.0, 3.23, 1.0, 9.7300000000000004, 1.6499999999999999 },
                    { 32, "Mercimek Corbasi", 69.0, 10.0, 1.0, 4.7000000000000002, 1.3999999999999999 },
                    { 33, "Tavuk Corbasi", 31.0, 3.8799999999999999, 1.0, 1.6799999999999999, 1.02 },
                    { 34, "Tarhana Corbasi", 82.0, 14.77, 1.0, 2.4500000000000002, 1.3999999999999999 },
                    { 35, "Sebze Corbasi", 43.0, 6.2599999999999998, 1.0, 0.5, 1.8999999999999999 },
                    { 36, "Zeytinyaglı Taze Fasulye", 81.0, 14.460000000000001, 1.0, 5.4199999999999999, 0.40000000000000002 },
                    { 37, "Zeytinyagli Pirasa Yemegi", 102.0, 9.8100000000000005, 1.0, 2.1200000000000001, 6.4000000000000004 },
                    { 38, "Havuclu Bezelye", 147.0, 11.07, 1.0, 3.48, 10.380000000000001 },
                    { 39, "Zeytinyagli Brokoli", 52.0, 6.6699999999999999, 1.0, 2.2200000000000002, 2.48 },
                    { 40, "Zeytinyagli Sebzeli Turlu", 112.0, 8.6799999999999997, 1.0, 1.3300000000000001, 8.8699999999999992 },
                    { 41, "Patlican Musakka", 117.0, 7.1200000000000001, 1.0, 4.8200000000000003, 7.6200000000000001 },
                    { 42, "Nohut Yemegi", 169.0, 15.630000000000001, 1.0, 3.2200000000000002, 10.789999999999999 },
                    { 43, "Bulgur pilavi", 130.0, 22.390000000000001, 1.0, 3.6699999999999999, 2.6200000000000001 },
                    { 44, "Pirinc pilavi", 125.0, 21.57, 1.0, 2.0699999999999998, 3.2400000000000002 },
                    { 45, "Makarna", 124.0, 25.120000000000001, 1.0, 4.3700000000000001, 0.97999999999999998 },
                    { 46, "Ekler", 174.0, 10.94, 1.0, 4.2999999999999998, 12.43 },
                    { 47, "Baklava", 428.0, 37.619999999999997, 1.0, 6.0700000000000003, 29.030000000000001 },
                    { 48, "MilkShake", 135.0, 20.109999999999999, 1.0, 0.0, 4.8899999999999997 },
                    { 49, "Cay", 1.0, 0.29999999999999999, 1.0, 0.0, 0.0 },
                    { 50, "Kola", 42.0, 10.6, 1.0, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "YiyecekYemekKategoris",
                columns: new[] { "YemekKategorileriID", "YiyecekID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 21 },
                    { 3, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 3, 25 },
                    { 3, 26 },
                    { 3, 27 },
                    { 3, 28 },
                    { 3, 29 },
                    { 3, 30 },
                    { 3, 31 },
                    { 3, 32 },
                    { 3, 33 },
                    { 3, 34 },
                    { 3, 35 },
                    { 3, 36 },
                    { 3, 37 },
                    { 3, 38 },
                    { 3, 39 },
                    { 3, 40 },
                    { 3, 41 },
                    { 3, 42 }
                });

            migrationBuilder.InsertData(
                table: "YiyecekYemekKategoris",
                columns: new[] { "YemekKategorileriID", "YiyecekID" },
                values: new object[,]
                {
                    { 3, 43 },
                    { 3, 44 },
                    { 3, 45 },
                    { 3, 46 },
                    { 4, 47 },
                    { 4, 48 },
                    { 4, 49 },
                    { 4, 50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_EMail",
                table: "Kullanicis",
                column: "EMail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_YiyecekYemekKategoris_YemekKategorileriID",
                table: "YiyecekYemekKategoris",
                column: "YemekKategorileriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Yemeks");

            migrationBuilder.DropTable(
                name: "YemekTarihis");

            migrationBuilder.DropTable(
                name: "YiyecekYemekKategoris");

            migrationBuilder.DropTable(
                name: "YemekKategorileris");

            migrationBuilder.DropTable(
                name: "Yiyeceks");
        }
    }
}
