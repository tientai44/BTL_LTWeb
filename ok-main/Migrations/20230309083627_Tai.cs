﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotUseAuto.Migrations
{
    public partial class Tai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    DoB = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaitCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaitCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image1 = table.Column<string>(nullable: false),
                    Image2 = table.Column<string>(nullable: false),
                    Image3 = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    WaitCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_WaitCategory_WaitCategoryId",
                        column: x => x.WaitCategoryId,
                        principalTable: "WaitCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    WaitCart_ID = table.Column<int>(nullable: false),
                    productId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItem_Product_productId",
                        column: x => x.productId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "2d9f1d3a-1d5c-4c47-9360-99df6398e1f5", "Administrator", "Administrator" },
                    { "B", "812c9892-fcf4-473c-9267-b5f6ecdf663e", "Customer", "Customer" },
                    { "O", "c7408edc-0786-42d5-8f12-6ea5816b7dd8", "Owner", "Owner" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Address", "DoB", "FullName", "Image" },
                values: new object[,]
                {
                    { "1", 0, "3c9557d2-60d6-42f3-9d32-b9704e86910b", "ApplicationUser", "hoanghip108@gmail.com", false, false, null, null, "hoanghip108@gmail.com", "AQAAAAEAACcQAAAAEFXAu+ImBzAifrMEQ2XGuA0FwA+UpA6QWlCHZ9AhpYC8MUsImVSAExR/1hMzzPTqYA==", null, false, "908e4d99-5ede-450c-a2db-735dab058e18", false, "hoanghip108@gmail.com", "Thái Nguyên", "2000/08/10", "Đỗ Nguyễn Huy Hoàng", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/298710201_3244171855861409_1804411380120781534_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=174925&_nc_ohc=dFVC3HbeYfIAX-iPGLL&_nc_ht=scontent.fhan2-3.fna&oh=00_AT98b_w49sQ3jWECKsp8fsD50m1uGc981QkC8y0ES84L-g&oe=635B2C2B" },
                    { "3", 0, "98260136-d8af-4e30-9fb5-5ece2153e10e", "ApplicationUser", "customer@fpt.com", false, false, null, null, "customer@fpt.com", "AQAAAAEAACcQAAAAEBUX0MAm8eIavVVnXoB/QHvAnC8hRyv15LjtjYEKta1Z93VjUiWRJB7+8G6UH/nSQg==", null, false, "151c91df-20f4-4f08-b0b1-d52412de92ca", false, "customer@fpt.com", "Phú Thọ", "2002/08/10", "Huy", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png" },
                    { "2", 0, "cd5af727-2d4f-4213-9965-8ff2ea4b0940", "ApplicationUser", "admin@fpt.com", false, false, null, null, "admin@fpt.com", "AQAAAAEAACcQAAAAEFL+ooe18qgDsAHrqINVDlWlTB8EGHgMkHO5/IJOt87TIfhUkWCsn4gptNvTREadcA==", null, false, "54f37523-7da7-4710-9a9b-8d266347b4e5", false, "admin@fpt.com", "Hà Nội", "2002/08/10", "Trọng Đạt", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png" },
                    { "4", 0, "9c64364c-4b64-42d3-8da1-8b65c418f0f9", "ApplicationUser", "quanghuy@fpt.com", false, false, null, null, "quanghuy@fpt.com", "AQAAAAEAACcQAAAAEIVq9M+O71IjQLR1z8sgW2YpHW4cm8Tbv8yfWTKEN6rvBW9eEb7uWkljCROiqMfmsg==", null, false, "b7ed3978-fe4c-4b4c-b189-9d1dbe7b71f4", false, "quanghuy@fpt.com", "Hà Nội", "2002/02/18", "Dang Quang Huy", "https://www.alotintuc.com/wp-content/uploads/2021/07/Untitled-Capture2244-scaled-e1626766063525.jpg" },
                    { "5", 0, "21d2b542-6a40-4cff-947e-a6a8ac09facf", "ApplicationUser", "owner1@fpt.com", false, false, null, null, "owner1@fpt.com", "AQAAAAEAACcQAAAAELPG76+95yKnflVUuz0U6hgJN1sYolF7Gg40/sOSHNfu0G4+RRPTLe7MZDq+DC7pZQ==", null, false, "1d536002-87aa-4d31-b2d3-722eec816567", false, "owner1@fpt.com", "Phú Thọ", "2002/08/10", "Lan Phuong", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png" },
                    { "6", 0, "85868dba-524b-48b4-84f0-084cc2d1db17", "ApplicationUser", "owner2@fpt.com", false, false, null, null, "owner2@fpt.com", "AQAAAAEAACcQAAAAEO6N+RLXgy1PumCyflkMv3XcY8irgQJ5qcZ/OreRvccUQRClEbEsf5isGxjZVOON1g==", null, false, "b2e433da-9e9b-432b-890b-0bc3f4d25b7e", false, "owner2@fpt.com", "Phú Thọ", "2002/08/10", "Truc My", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Action", "Action", "Active" },
                    { 2, "Anime", "Anime", "Active" },
                    { 3, "Fantasy", "Fantasy", "Active" },
                    { 4, "Adventure", "Adventure", "Active" },
                    { 5, "Magic", "Magic", "Active" },
                    { 6, "Drama", "Drama", "Active" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "A" },
                    { "3", "B" },
                    { "2", "A" },
                    { "4", "A" },
                    { "5", "O" },
                    { "6", "O" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Image1", "Image2", "Image3", "Name", "Price", "Quantity", "WaitCategoryId" },
                values: new object[,]
                {
                    { 17, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 16, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 15, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 14, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 13, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 12, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 11, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 10, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 6, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 7, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 18, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 4, 3, "FAIRY TAIL is an anime series about a teen named Lucy (voiced by Cherami Leigh) who runs away with her new friend, Natsu (Todd Haberkorn), to join the well-known wizards guild, Fairy Tail.", "https://img1.ak.crunchyroll.com/i/spire2/f4ca1a545a471a9ce6e43eef8e8d72541539734102_main.jpg", "https://img1.ak.crunchyroll.com/i/spire2/f4ca1a545a471a9ce6e43eef8e8d72541539734102_main.jpg", "https://img1.ak.crunchyroll.com/i/spire2/f4ca1a545a471a9ce6e43eef8e8d72541539734102_main.jpg", "Fairy tail", 4000m, 40, null },
                    { 20, 2, "The series focuses on a middle school student Izuku Midoriya, who has no superpowers. Will he be able to become a hero and somehow to contribute to the peace and stability in the world, where the weak is the minority that needs to be defended.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Hero academia", 7000m, 70, null },
                    { 2, 2, "One Piece is the story of Monkey D. Luffy, a young man who has a single dream: To find the legendary treasure known as the One Piece and become the King of the Pirates. Alongside a crew of trusted friends, Luffy sails the dangerous seas of the Grand Line to find Laugh Tale, the hidden island containing the One Piece.", "https://i.bloganchoi.com/bloganchoi.com/wp-content/uploads/2021/09/one-piece-live-action-netlfix-2-696x1044.jpg?fit=700%2C20000&quality=95&ssl=1", "https://i.bloganchoi.com/bloganchoi.com/wp-content/uploads/2021/09/one-piece-live-action-netlfix-2-696x1044.jpg?fit=700%2C20000&quality=95&ssl=1", "https://i.bloganchoi.com/bloganchoi.com/wp-content/uploads/2021/09/one-piece-live-action-netlfix-2-696x1044.jpg?fit=700%2C20000&quality=95&ssl=1", "One Piece", 2000m, 20, null },
                    { 5, 1, "One-Punch Man (Japanese: ワンパンマン, Hepburn: Wanpanman) is a Japanese superhero manga series created by One. It tells the story of Saitama, a superhero who, because he can defeat any opponent with a single punch, grows bored from a lack of challenge. One wrote the original webcomic manga version in early 2009.", "https://static.wikia.nocookie.net/onepunchman/images/2/27/Saitama.png/revision/latest?cb=20210530114318&path-prefix=vi", "https://static.wikia.nocookie.net/onepunchman/images/2/27/Saitama.png/revision/latest?cb=20210530114318&path-prefix=vi", "https://static.wikia.nocookie.net/onepunchman/images/2/27/Saitama.png/revision/latest?cb=20210530114318&path-prefix=vi", "Onepuch man", 5000m, 50, null },
                    { 3, 1, "Demon Slayer: Kimetsu no Yaiba (鬼滅の刃, Kimetsu no Yaiba, \"Blade of Demon Destruction\") is a Japanese manga series written and illustrated by Koyoharu Gotouge. It follows teenage Tanjiro Kamado, who strives to become a demon slayer after his family was slaughtered and his younger sister, Nezuko, turned into a demon.", "https://cdnsg.kilala.vn/data/upload/article/5840/Kimetsu%20no%20Yaiba%20Mugen%20Ressha-hen%20(8).jpg", "https://cdnsg.kilala.vn/data/upload/article/5840/Kimetsu%20no%20Yaiba%20Mugen%20Ressha-hen%20(8).jpg", "https://cdnsg.kilala.vn/data/upload/article/5840/Kimetsu%20no%20Yaiba%20Mugen%20Ressha-hen%20(8).jpg", "Kimetsu No Yaiba", 3000m, 30, null },
                    { 1, 1, "The series focuses on Asta, a young orphan who is left to be raised in an orphanage alongside his fellow orphan, Yuno. While everyone is born with the ability to utilize mana in the form of magical power, Asta, with no magic however, instead focuses on physical strength.", "https://m.media-amazon.com/images/M/MV5BN2FlYjYxMTMtZGQzYy00OWU2LTkyYWMtNWJhODhmZmM0N2FhXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg", "https://m.media-amazon.com/images/M/MV5BN2FlYjYxMTMtZGQzYy00OWU2LTkyYWMtNWJhODhmZmM0N2FhXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg", "https://m.media-amazon.com/images/M/MV5BN2FlYjYxMTMtZGQzYy00OWU2LTkyYWMtNWJhODhmZmM0N2FhXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg", "Black clover", 1000m, 10, null },
                    { 8, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 19, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_OrderId",
                table: "CartItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_productId",
                table: "CartItem",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_WaitCategoryId",
                table: "Product",
                column: "WaitCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "WaitCategory");
        }
    }
}
