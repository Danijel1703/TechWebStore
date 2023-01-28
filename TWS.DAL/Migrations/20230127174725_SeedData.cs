using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TWS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("0ddac2b2-4922-4286-b1af-af9dd08b6dac"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("00cc64b3-9577-49ab-afa2-efb220674dbc"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("14c7ad52-89c8-4663-bfc4-47578c7831bd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("23e1462c-108a-4040-a441-a633c7e59ac1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("23f8924f-cc45-493b-8466-151ef76daad5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("416cf279-d92f-4f2c-9b44-aa365b74bbf5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4f09b0f5-19b2-421b-ae21-48e4402dc068"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5045b807-b31f-40f5-ab85-25f5a10bc699"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("5fba1e06-dfa5-4b36-9a73-5474b0ccf241"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("69cfdefd-3738-4932-bfa0-69e9dfa186a5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6ce2b1bb-5573-456f-932a-d7415059c6af"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("91db0495-aa4e-4850-94cc-973ec3a2d9f5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9cc56cd1-136c-43e6-ba47-e6097288fc4c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9d1f510d-a483-49bc-83ae-58f305decb2d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a50ba8a8-00b4-41fe-8cce-f997c1cb23bb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a6f2c405-5c0b-422d-bd02-b48434527a6e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a70cb88d-c883-49e2-b409-401c995ce4a1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b4156f66-f406-449d-ab0f-114d81ad58b4"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("bac66f2a-38bc-4729-8feb-6b439b3a89f7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e1f641c7-146b-4989-8454-45aee656b5aa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ea8cf4b1-09cc-4c43-8ccc-5a110944f200"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("0231ad81-2818-4696-976c-f3b66bb0d84f"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("4c63829e-ef94-4000-9429-ed8708d79bf8"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("4f1cbd55-2e50-4ee5-9982-9274cfa37b27"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("6a40db6e-2648-46c8-bcf9-e7537d1b6334"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("76c98b9d-1b3d-4e79-a1d6-628a4fea7d34"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("b6840244-c436-4c02-95b8-857ed64f89f9"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("c1e80158-63f0-4a7f-b102-0500e894f945"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("c8f554d8-0c6e-4374-a3f1-dc81dc9ee7f9"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("ea1c44bf-e467-48f9-8a04-917f88fe048e"));

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "Id", "Abrv", "Name" },
                values: new object[,]
                {
                    { new Guid("0084fa4e-4ec2-407c-8d26-50eb790a5a04"), "manufacturer-14", "Manufacturer 14" },
                    { new Guid("142faf68-613b-4131-aad6-275a302d9152"), "manufacturer-17", "Manufacturer 17" },
                    { new Guid("2a19d24a-06eb-4fd4-99b1-71a75c2d9e4c"), "manufacturer-2", "Manufacturer 2" },
                    { new Guid("2e1e830f-0222-41cf-887f-493e9c312cb5"), "manufacturer-5", "Manufacturer 5" },
                    { new Guid("38de2d38-ade5-4c8d-9553-ab79425a5bbe"), "manufacturer-3", "Manufacturer 3" },
                    { new Guid("39b3f4a4-a369-421d-b70e-fc06c8eb13bf"), "manufacturer-1", "Manufacturer 1" },
                    { new Guid("5532cfa0-ee51-47d6-9d2b-386a4f137772"), "manufacturer-18", "Manufacturer 18" },
                    { new Guid("852ccb8e-14b7-47a6-841e-a9e04a7a6d86"), "manufacturer-9", "Manufacturer 9" },
                    { new Guid("891c214b-c488-4132-ae1e-b8d1ee0dc162"), "manufacturer-16", "Manufacturer 16" },
                    { new Guid("8e3e01ae-f5f4-4476-a1ee-0c31a582cd70"), "manufacturer-20", "Manufacturer 20" },
                    { new Guid("9655770b-50b9-4807-ac06-82663c03fa52"), "manufacturer-12", "Manufacturer 12" },
                    { new Guid("9665dc0a-f531-4cb0-a478-605dedce69d9"), "manufacturer-15", "Manufacturer 15" },
                    { new Guid("9e68ca38-7dab-46b8-97c7-4be0c8126271"), "manufacturer-7", "Manufacturer 7" },
                    { new Guid("b09f0934-3299-4c78-84ac-18d1142e496d"), "manufacturer-11", "Manufacturer 11" },
                    { new Guid("da917078-cf7f-4368-a4ae-652173b1eaa1"), "manufacturer-10", "Manufacturer 10" },
                    { new Guid("deb94709-ac3b-4541-bdf8-9d21d8bd431c"), "manufacturer-6", "Manufacturer 6" },
                    { new Guid("e31acad6-2948-49ee-9f18-d8eb46c1fa3a"), "manufacturer-19", "Manufacturer 19" },
                    { new Guid("ee8d0735-bf8a-4290-a775-fd1303e4faf1"), "manufacturer-8", "Manufacturer 8" },
                    { new Guid("f0a48dc7-4193-4d1f-a6cf-9787f34608c8"), "manufacturer-4", "Manufacturer 4" },
                    { new Guid("fe78fd13-930d-467f-bc95-679bbddd56d7"), "manufacturer-13", "Manufacturer 13" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Abrv", "Description", "ManufacturerId", "Name", "Price", "SKU" },
                values: new object[,]
                {
                    { new Guid("1c08edba-5a5d-4b69-9ab5-8e2a5856efac"), "product-18", "", new Guid("8e3e01ae-f5f4-4476-a1ee-0c31a582cd70"), "Product18", 800m, "p18" },
                    { new Guid("24f5b17c-28df-4ab6-853c-edd035f0e63b"), "product-19", "", new Guid("2a19d24a-06eb-4fd4-99b1-71a75c2d9e4c"), "Product19", 900m, "p19" },
                    { new Guid("2d93729b-31fe-4f23-94a3-da2f2a9a0bdb"), "product-20", "", new Guid("2a19d24a-06eb-4fd4-99b1-71a75c2d9e4c"), "Product20", 1000m, "p20" },
                    { new Guid("3c146f41-55d1-4e86-9cb6-1f2d39659eea"), "product-14", "", new Guid("9665dc0a-f531-4cb0-a478-605dedce69d9"), "Product14", 400m, "p14" },
                    { new Guid("3f6a98fb-742d-4148-86b5-de363fef3f50"), "product-3", "", new Guid("39b3f4a4-a369-421d-b70e-fc06c8eb13bf"), "Product3", 300m, "p3" },
                    { new Guid("4cb70937-5af1-4792-9b4b-68f1b311c28c"), "product-16", "", new Guid("2a19d24a-06eb-4fd4-99b1-71a75c2d9e4c"), "Product16", 600m, "p16" },
                    { new Guid("6fb115b0-234d-4f62-941e-305714d17dde"), "product-4", "", new Guid("38de2d38-ade5-4c8d-9553-ab79425a5bbe"), "Product4", 400m, "p4" },
                    { new Guid("7b8e4fec-f25a-46ce-8431-6b47cb36e380"), "product-8", "", new Guid("2a19d24a-06eb-4fd4-99b1-71a75c2d9e4c"), "Product8", 800m, "p8" },
                    { new Guid("7ebd4cfb-2a36-4256-8e61-c9c65f9dd05e"), "product-6", "", new Guid("5532cfa0-ee51-47d6-9d2b-386a4f137772"), "Product6", 600m, "p6" },
                    { new Guid("84ac3658-c2bb-4072-b8a8-3da60c47403b"), "product-5", "", new Guid("2e1e830f-0222-41cf-887f-493e9c312cb5"), "Product5", 500m, "p5" },
                    { new Guid("9c82497b-05bc-48a4-9b81-06a23a6fa4a0"), "product-17", "", new Guid("852ccb8e-14b7-47a6-841e-a9e04a7a6d86"), "Product17", 700m, "p17" },
                    { new Guid("9f833cc7-6e56-45af-9c8e-47850c5e5864"), "product-13", "", new Guid("deb94709-ac3b-4541-bdf8-9d21d8bd431c"), "Product13", 300m, "p13" },
                    { new Guid("a1007999-a699-41f1-97b6-1b910b227f0b"), "product-2", "", new Guid("0084fa4e-4ec2-407c-8d26-50eb790a5a04"), "Product2", 200m, "p2" },
                    { new Guid("a5d394e9-41e9-43f0-8f49-1678a1006f00"), "product-11", "", new Guid("b09f0934-3299-4c78-84ac-18d1142e496d"), "Product11", 100m, "p11" },
                    { new Guid("b0cd82b6-5c9f-41b7-8c30-cb5f7666e4b3"), "product-7", "", new Guid("da917078-cf7f-4368-a4ae-652173b1eaa1"), "Product7", 700m, "p7" },
                    { new Guid("b275fe7e-8bbb-4a93-9608-54c7183654c5"), "product-15", "", new Guid("38de2d38-ade5-4c8d-9553-ab79425a5bbe"), "Product15", 500m, "p15" },
                    { new Guid("dda3e0b9-996c-4d0c-acc0-863e47351b11"), "product-1", "", new Guid("39b3f4a4-a369-421d-b70e-fc06c8eb13bf"), "Product1", 100m, "p1" },
                    { new Guid("ed6b2486-3717-44c6-8cbf-940a7c9c9c36"), "product-9", "", new Guid("f0a48dc7-4193-4d1f-a6cf-9787f34608c8"), "Product9", 900m, "p9" },
                    { new Guid("efc52ac9-82d3-497d-a093-23934b00ddae"), "product-12", "", new Guid("deb94709-ac3b-4541-bdf8-9d21d8bd431c"), "Product12", 200m, "p12" },
                    { new Guid("fbe07c5d-e574-46d6-8368-f4e291e83891"), "product-10", "", new Guid("39b3f4a4-a369-421d-b70e-fc06c8eb13bf"), "Product10", 1000m, "p10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("142faf68-613b-4131-aad6-275a302d9152"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("891c214b-c488-4132-ae1e-b8d1ee0dc162"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("9655770b-50b9-4807-ac06-82663c03fa52"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("9e68ca38-7dab-46b8-97c7-4be0c8126271"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("e31acad6-2948-49ee-9f18-d8eb46c1fa3a"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("ee8d0735-bf8a-4290-a775-fd1303e4faf1"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("fe78fd13-930d-467f-bc95-679bbddd56d7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1c08edba-5a5d-4b69-9ab5-8e2a5856efac"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("24f5b17c-28df-4ab6-853c-edd035f0e63b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("2d93729b-31fe-4f23-94a3-da2f2a9a0bdb"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3c146f41-55d1-4e86-9cb6-1f2d39659eea"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("3f6a98fb-742d-4148-86b5-de363fef3f50"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4cb70937-5af1-4792-9b4b-68f1b311c28c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6fb115b0-234d-4f62-941e-305714d17dde"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7b8e4fec-f25a-46ce-8431-6b47cb36e380"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7ebd4cfb-2a36-4256-8e61-c9c65f9dd05e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("84ac3658-c2bb-4072-b8a8-3da60c47403b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9c82497b-05bc-48a4-9b81-06a23a6fa4a0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9f833cc7-6e56-45af-9c8e-47850c5e5864"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a1007999-a699-41f1-97b6-1b910b227f0b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("a5d394e9-41e9-43f0-8f49-1678a1006f00"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b0cd82b6-5c9f-41b7-8c30-cb5f7666e4b3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b275fe7e-8bbb-4a93-9608-54c7183654c5"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dda3e0b9-996c-4d0c-acc0-863e47351b11"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ed6b2486-3717-44c6-8cbf-940a7c9c9c36"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("efc52ac9-82d3-497d-a093-23934b00ddae"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("fbe07c5d-e574-46d6-8368-f4e291e83891"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("0084fa4e-4ec2-407c-8d26-50eb790a5a04"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("2a19d24a-06eb-4fd4-99b1-71a75c2d9e4c"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("2e1e830f-0222-41cf-887f-493e9c312cb5"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("38de2d38-ade5-4c8d-9553-ab79425a5bbe"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("39b3f4a4-a369-421d-b70e-fc06c8eb13bf"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("5532cfa0-ee51-47d6-9d2b-386a4f137772"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("852ccb8e-14b7-47a6-841e-a9e04a7a6d86"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("8e3e01ae-f5f4-4476-a1ee-0c31a582cd70"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("9665dc0a-f531-4cb0-a478-605dedce69d9"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("b09f0934-3299-4c78-84ac-18d1142e496d"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("da917078-cf7f-4368-a4ae-652173b1eaa1"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("deb94709-ac3b-4541-bdf8-9d21d8bd431c"));

            migrationBuilder.DeleteData(
                table: "Manufacturer",
                keyColumn: "Id",
                keyValue: new Guid("f0a48dc7-4193-4d1f-a6cf-9787f34608c8"));

            migrationBuilder.InsertData(
                table: "Manufacturer",
                columns: new[] { "Id", "Abrv", "Name" },
                values: new object[,]
                {
                    { new Guid("0231ad81-2818-4696-976c-f3b66bb0d84f"), "manufacturer-1", "Manufacturer 11" },
                    { new Guid("0ddac2b2-4922-4286-b1af-af9dd08b6dac"), "manufacturer-7", "Manufacturer 17" },
                    { new Guid("4c63829e-ef94-4000-9429-ed8708d79bf8"), "manufacturer-4", "Manufacturer 14" },
                    { new Guid("4f1cbd55-2e50-4ee5-9982-9274cfa37b27"), "manufacturer-5", "Manufacturer 15" },
                    { new Guid("6a40db6e-2648-46c8-bcf9-e7537d1b6334"), "manufacturer-2", "Manufacturer 12" },
                    { new Guid("76c98b9d-1b3d-4e79-a1d6-628a4fea7d34"), "manufacturer-10", "Manufacturer 20" },
                    { new Guid("b6840244-c436-4c02-95b8-857ed64f89f9"), "manufacturer-8", "Manufacturer 18" },
                    { new Guid("c1e80158-63f0-4a7f-b102-0500e894f945"), "manufacturer-9", "Manufacturer 19" },
                    { new Guid("c8f554d8-0c6e-4374-a3f1-dc81dc9ee7f9"), "manufacturer-3", "Manufacturer 13" },
                    { new Guid("ea1c44bf-e467-48f9-8a04-917f88fe048e"), "manufacturer-6", "Manufacturer 16" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Abrv", "Description", "ManufacturerId", "Name", "Price", "SKU" },
                values: new object[,]
                {
                    { new Guid("00cc64b3-9577-49ab-afa2-efb220674dbc"), "product-18", "", new Guid("6a40db6e-2648-46c8-bcf9-e7537d1b6334"), "Product18", 800m, "p18" },
                    { new Guid("14c7ad52-89c8-4663-bfc4-47578c7831bd"), "product-22", "", new Guid("ea1c44bf-e467-48f9-8a04-917f88fe048e"), "Product22", 200m, "p22" },
                    { new Guid("23e1462c-108a-4040-a441-a633c7e59ac1"), "product-13", "", new Guid("0231ad81-2818-4696-976c-f3b66bb0d84f"), "Product13", 300m, "p13" },
                    { new Guid("23f8924f-cc45-493b-8466-151ef76daad5"), "product-25", "", new Guid("c8f554d8-0c6e-4374-a3f1-dc81dc9ee7f9"), "Product25", 500m, "p25" },
                    { new Guid("416cf279-d92f-4f2c-9b44-aa365b74bbf5"), "product-23", "", new Guid("ea1c44bf-e467-48f9-8a04-917f88fe048e"), "Product23", 300m, "p23" },
                    { new Guid("4f09b0f5-19b2-421b-ae21-48e4402dc068"), "product-28", "", new Guid("c1e80158-63f0-4a7f-b102-0500e894f945"), "Product28", 800m, "p28" },
                    { new Guid("5045b807-b31f-40f5-ab85-25f5a10bc699"), "product-21", "", new Guid("c8f554d8-0c6e-4374-a3f1-dc81dc9ee7f9"), "Product21", 100m, "p21" },
                    { new Guid("5fba1e06-dfa5-4b36-9a73-5474b0ccf241"), "product-29", "", new Guid("6a40db6e-2648-46c8-bcf9-e7537d1b6334"), "Product29", 900m, "p29" },
                    { new Guid("69cfdefd-3738-4932-bfa0-69e9dfa186a5"), "product-19", "", new Guid("4c63829e-ef94-4000-9429-ed8708d79bf8"), "Product19", 900m, "p19" },
                    { new Guid("6ce2b1bb-5573-456f-932a-d7415059c6af"), "product-15", "", new Guid("4f1cbd55-2e50-4ee5-9982-9274cfa37b27"), "Product15", 500m, "p15" },
                    { new Guid("91db0495-aa4e-4850-94cc-973ec3a2d9f5"), "product-24", "", new Guid("b6840244-c436-4c02-95b8-857ed64f89f9"), "Product24", 400m, "p24" },
                    { new Guid("9cc56cd1-136c-43e6-ba47-e6097288fc4c"), "product-16", "", new Guid("b6840244-c436-4c02-95b8-857ed64f89f9"), "Product16", 600m, "p16" },
                    { new Guid("9d1f510d-a483-49bc-83ae-58f305decb2d"), "product-30", "", new Guid("6a40db6e-2648-46c8-bcf9-e7537d1b6334"), "Product30", 1000m, "p30" },
                    { new Guid("a50ba8a8-00b4-41fe-8cce-f997c1cb23bb"), "product-27", "", new Guid("c1e80158-63f0-4a7f-b102-0500e894f945"), "Product27", 700m, "p27" },
                    { new Guid("a6f2c405-5c0b-422d-bd02-b48434527a6e"), "product-12", "", new Guid("4c63829e-ef94-4000-9429-ed8708d79bf8"), "Product12", 200m, "p12" },
                    { new Guid("a70cb88d-c883-49e2-b409-401c995ce4a1"), "product-20", "", new Guid("0231ad81-2818-4696-976c-f3b66bb0d84f"), "Product20", 1000m, "p20" },
                    { new Guid("b4156f66-f406-449d-ab0f-114d81ad58b4"), "product-17", "", new Guid("76c98b9d-1b3d-4e79-a1d6-628a4fea7d34"), "Product17", 700m, "p17" },
                    { new Guid("bac66f2a-38bc-4729-8feb-6b439b3a89f7"), "product-14", "", new Guid("c8f554d8-0c6e-4374-a3f1-dc81dc9ee7f9"), "Product14", 400m, "p14" },
                    { new Guid("e1f641c7-146b-4989-8454-45aee656b5aa"), "product-11", "", new Guid("0231ad81-2818-4696-976c-f3b66bb0d84f"), "Product11", 100m, "p11" },
                    { new Guid("ea8cf4b1-09cc-4c43-8ccc-5a110944f200"), "product-26", "", new Guid("6a40db6e-2648-46c8-bcf9-e7537d1b6334"), "Product26", 600m, "p26" }
                });
        }
    }
}
