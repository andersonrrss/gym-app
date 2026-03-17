using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GymApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Users_CreatorId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_CreatorId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Exercises");

            migrationBuilder.InsertData(
                table: "MuscleGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Peitoral" },
                    { new Guid("4911e664-f75b-4f2a-92e0-6bbc9fcc6dec"), "Glúteo" },
                    { new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Ombro" },
                    { new Guid("51f00ebd-b28e-420c-a999-6f488a90362b"), "Panturrilha" },
                    { new Guid("78900b9b-e79a-47e0-8e6f-dd27da979fc9"), "Lombar" },
                    { new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Posterior de Coxa" },
                    { new Guid("84d2a33c-3ff2-4698-85eb-860e0eeb1ee3"), "Trapézio" },
                    { new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"), "Quadríceps" },
                    { new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"), "Tríceps" },
                    { new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Dorsal" },
                    { new Guid("c5fe59fb-e679-429a-ba23-57f4038675f4"), "Antebraço" },
                    { new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"), "Abdômen" },
                    { new Guid("f8f48454-d0ef-4bcf-a75b-5be98be1b838"), "Bíceps" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "MuscleGroupId", "Name" },
                values: new object[,]
                {
                    { new Guid("02e88224-85c3-4c27-9526-5f4dfd70ab20"), new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"), "Abdominal infra" },
                    { new Guid("0343986b-3ed0-4484-8da0-3edfd12b3171"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Flexão de braço" },
                    { new Guid("06bf2570-ba26-4059-9410-cc170f68ee95"), new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"), "Tríceps corda" },
                    { new Guid("0c6ddb57-8c8c-4412-90fa-cdf2107be429"), new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Elevação frontal" },
                    { new Guid("12623ed5-5b3c-4c55-b3d5-a3e118c7e3a8"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Remada curvada" },
                    { new Guid("139825e7-ffe4-4699-9c66-0064a60b1dcb"), new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Desenvolvimento com halteres" },
                    { new Guid("13ae2a63-6aca-4121-a695-442aa6bcae32"), new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"), "Roda abdominal" },
                    { new Guid("13bf0b67-b1bb-4c1f-90b4-f80ce4dc76a5"), new Guid("c5fe59fb-e679-429a-ba23-57f4038675f4"), "Rosca inversa" },
                    { new Guid("13f20034-5142-49b4-94c2-dd997c372f9c"), new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Agachamento smith" },
                    { new Guid("16404318-3ce7-4985-8225-b88531e9cbec"), new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"), "Avanço" },
                    { new Guid("185263d5-95c0-41da-8973-cf2d7c34d5c9"), new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"), "Abdominal crunch" },
                    { new Guid("1b754f7c-9c5a-4588-9bef-9f5e3f90c847"), new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"), "Abdominal máquina" },
                    { new Guid("1c4b35e5-39d8-49bc-a5d3-e736e280a307"), new Guid("f8f48454-d0ef-4bcf-a75b-5be98be1b838"), "Rosca martelo" },
                    { new Guid("23370ee4-ecb7-44fb-9ac7-d396999c7eca"), new Guid("4911e664-f75b-4f2a-92e0-6bbc9fcc6dec"), "Abdução de quadril" },
                    { new Guid("2493a453-217e-4664-9f58-26b626825261"), new Guid("4911e664-f75b-4f2a-92e0-6bbc9fcc6dec"), "Hip thrust" },
                    { new Guid("258769d6-4554-4b5b-a649-2126233a9b9a"), new Guid("f8f48454-d0ef-4bcf-a75b-5be98be1b838"), "Rosca direta" },
                    { new Guid("2682d649-a454-4a62-a207-ad27411d3edb"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Serrote" },
                    { new Guid("284e04e3-48ca-4119-8fa8-df1ad5713f14"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Puxada frontal" },
                    { new Guid("299f1eab-49c5-4efe-b06a-9b5a2f0440ce"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Supino inclinado" },
                    { new Guid("29d94801-2fa9-4d0f-b349-6010b5406e0b"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Remada máquina" },
                    { new Guid("2cf92328-039f-4ca4-8f13-9144aeb525c0"), new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Agachamento romeno" },
                    { new Guid("2e744094-0a81-433d-b91e-6dfec0a4129e"), new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"), "Agachamento sumô" },
                    { new Guid("3077eb86-f92c-4889-8616-3d1ff3b688f8"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Remada cavalinho" },
                    { new Guid("3269c16e-92cb-4b8f-9ddb-9cd6d87f7ee8"), new Guid("c5fe59fb-e679-429a-ba23-57f4038675f4"), "Rosca de punho" },
                    { new Guid("3336862c-4599-4550-96bc-3df1a676576a"), new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Mesa flexora" },
                    { new Guid("34c46b1b-50e9-4aee-a279-e98c77531aa1"), new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"), "Extensão de tríceps" },
                    { new Guid("361d1066-ec61-45bb-b014-33f2a84d87fd"), new Guid("51f00ebd-b28e-420c-a999-6f488a90362b"), "Panturrilha leg press" },
                    { new Guid("3790b237-943c-4898-94ad-bcc55d327dbd"), new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Stiff unilateral" },
                    { new Guid("37c2950d-e0cc-4ae7-902a-af172feea702"), new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Cadeira flexora" },
                    { new Guid("3d8c2d01-433c-4985-bbc5-340f51725a4f"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Supino declinado" },
                    { new Guid("3f05df30-9de0-4a7a-a7ce-03f9dc5b1547"), new Guid("4911e664-f75b-4f2a-92e0-6bbc9fcc6dec"), "Elevação pélvica" },
                    { new Guid("461e26ea-41e6-4995-acea-b77c1449723a"), new Guid("51f00ebd-b28e-420c-a999-6f488a90362b"), "Panturrilha sentado" },
                    { new Guid("4719f42c-9f84-4e04-b08c-8e8606d2c370"), new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Cruxifixo invertido" },
                    { new Guid("477114df-1c1e-4409-a5a3-b6b1f3103e06"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Peck deck" },
                    { new Guid("494c023c-2223-4b25-b855-9a56c017b85d"), new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Flexão nórdica" },
                    { new Guid("4c4cc220-e1e3-4091-9ebc-24c97f0add93"), new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Arnold press" },
                    { new Guid("4f7cbc31-77e2-4a6a-aee0-5705cb347a40"), new Guid("f8f48454-d0ef-4bcf-a75b-5be98be1b838"), "Rosca 21" },
                    { new Guid("4fe825dc-180c-4a87-9740-8f37073b6290"), new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Levantamento terra" },
                    { new Guid("50337b37-bfe8-4c28-812b-04303e0ade06"), new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"), "Agachamento livre" },
                    { new Guid("50ac7d47-2056-4d40-9066-c78be66a9d25"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Barra fixa" },
                    { new Guid("5477b8d4-4a44-47b9-9fe2-ea557cfbb2e9"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Supino reto" },
                    { new Guid("709e7f4c-12d5-4461-aceb-fe626b89f1a6"), new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"), "Abdominal oblíquo" },
                    { new Guid("7fe5beec-c495-4c38-b224-86e764e2fabe"), new Guid("4911e664-f75b-4f2a-92e0-6bbc9fcc6dec"), "Kick back glúteo" },
                    { new Guid("82904538-0e45-4fd5-938b-8d54a63cdcdc"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Puxada neutra" },
                    { new Guid("82c2de4a-7eb7-4ab7-bb71-ec7a2099fdef"), new Guid("f8f48454-d0ef-4bcf-a75b-5be98be1b838"), "Rosca alternada" },
                    { new Guid("878f3614-314c-4ae0-b2ba-661603bcb2ed"), new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"), "Elevação de pernas" },
                    { new Guid("8d6a8087-26cf-4be4-ac1e-9e2da6ec50db"), new Guid("84d2a33c-3ff2-4698-85eb-860e0eeb1ee3"), "Encolhimento com barra" },
                    { new Guid("8e583585-d03a-445a-95e8-750ace7fc291"), new Guid("7d83b8be-8106-44c7-b757-21229c45a514"), "Stiff" },
                    { new Guid("8f67f229-b992-4fe1-9138-2b38309c78b0"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Paralela" },
                    { new Guid("9133e30b-2266-48d3-8c3c-e8939530a9fe"), new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"), "Leg press" },
                    { new Guid("9377c34f-c7c1-42a5-8fd1-e02245cd4afd"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Cruxifixo inclinado" },
                    { new Guid("9aa6274b-f9d0-476e-a61d-7823b7d8c4f4"), new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"), "Cadeira extensora" },
                    { new Guid("9e41f367-e084-451e-a8a8-b8a805b47b5d"), new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Face pull" },
                    { new Guid("a883caac-92a1-4ef9-8ba0-95570375b59b"), new Guid("c5fe59fb-e679-429a-ba23-57f4038675f4"), "Rotação de punho" },
                    { new Guid("ad685077-ef96-4791-87bf-abc943e08424"), new Guid("51f00ebd-b28e-420c-a999-6f488a90362b"), "Panturrilha em pé" },
                    { new Guid("af73b55f-c8b7-459f-986b-5d78ab155eb3"), new Guid("78900b9b-e79a-47e0-8e6f-dd27da979fc9"), "Hiperextensão" },
                    { new Guid("b0383145-066c-4ed9-a86c-b8d7ee70556d"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Crucifixo reto" },
                    { new Guid("b4c1132f-063a-44c3-a4cf-6a4e7ae1d42e"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Cross over" },
                    { new Guid("b638b4fb-deab-40b9-9c74-f52a6a0fe502"), new Guid("c5fe59fb-e679-429a-ba23-57f4038675f4"), "Farmer walk" },
                    { new Guid("b858030a-9820-4b69-91ef-2b3e83f97f56"), new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"), "Mergulho" },
                    { new Guid("b881cf72-acc1-436b-8577-706fda53a38c"), new Guid("c5fe59fb-e679-429a-ba23-57f4038675f4"), "Rosca de punho invertida" },
                    { new Guid("b8d45ad1-1009-4cf9-b23d-c0db90bb6757"), new Guid("84d2a33c-3ff2-4698-85eb-860e0eeb1ee3"), "Remada alta" },
                    { new Guid("bc82460d-8593-427f-b5be-6d21b8fe0534"), new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"), "Agachamento búlgaro" },
                    { new Guid("bec6de7c-3298-4b63-ac7a-4615be4ba051"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Puxada posterior" },
                    { new Guid("bfe35d53-8096-4564-ae6d-9836f6ba0fb4"), new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"), "Tríceps testa" },
                    { new Guid("c3b7ac18-e8dc-4a37-b401-ec994fe10fa0"), new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"), "Tríceps pulley" },
                    { new Guid("cb544fd8-3ff2-477b-9e3d-06d64c39e0cc"), new Guid("78900b9b-e79a-47e0-8e6f-dd27da979fc9"), "Bom dia" },
                    { new Guid("cb9f7c31-bf89-4e5c-a56f-cb09a9b02eeb"), new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"), "Agachamento hack" },
                    { new Guid("cf12543e-2251-44ab-b7a1-9aa5ee0e87b6"), new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Encolhimento" },
                    { new Guid("d0957c87-4dd4-4875-af14-ca95ac63daa0"), new Guid("f8f48454-d0ef-4bcf-a75b-5be98be1b838"), "Rosca scott" },
                    { new Guid("d3e8f290-2f5f-4516-8572-d00092be022d"), new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Desenvolvimento com barra" },
                    { new Guid("dbc68a4c-a5f6-42e0-89cc-35b188179702"), new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"), "Kickback" },
                    { new Guid("dd2d045d-0753-4305-9270-31911a449bb0"), new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"), "Tríceps francês" },
                    { new Guid("e3091c87-603a-446b-9955-14870f0b1990"), new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"), "Remada unilateral" },
                    { new Guid("e55c80c2-6975-4a82-9c7f-573b3f8724a7"), new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"), "Pullover" },
                    { new Guid("edcfaacd-e229-4248-85c6-c66212206557"), new Guid("4e69d837-ae32-4272-9908-341963a08314"), "Elevação lateral" },
                    { new Guid("f0b74340-ca89-4429-9f3f-b1f6885dc5d7"), new Guid("4911e664-f75b-4f2a-92e0-6bbc9fcc6dec"), "Afundo" },
                    { new Guid("f60ba848-8c83-40d3-ab75-2cb8a6a1e19d"), new Guid("84d2a33c-3ff2-4698-85eb-860e0eeb1ee3"), "Encolhimento com halteres" },
                    { new Guid("fc6fe802-24e7-40a9-9129-2330f841bb2d"), new Guid("f8f48454-d0ef-4bcf-a75b-5be98be1b838"), "Rosca concentrada" },
                    { new Guid("fd126882-b03b-4337-93a9-df121adef819"), new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"), "Prancha" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("02e88224-85c3-4c27-9526-5f4dfd70ab20"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0343986b-3ed0-4484-8da0-3edfd12b3171"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("06bf2570-ba26-4059-9410-cc170f68ee95"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("0c6ddb57-8c8c-4412-90fa-cdf2107be429"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("12623ed5-5b3c-4c55-b3d5-a3e118c7e3a8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("139825e7-ffe4-4699-9c66-0064a60b1dcb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("13ae2a63-6aca-4121-a695-442aa6bcae32"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("13bf0b67-b1bb-4c1f-90b4-f80ce4dc76a5"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("13f20034-5142-49b4-94c2-dd997c372f9c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("16404318-3ce7-4985-8225-b88531e9cbec"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("185263d5-95c0-41da-8973-cf2d7c34d5c9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1b754f7c-9c5a-4588-9bef-9f5e3f90c847"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("1c4b35e5-39d8-49bc-a5d3-e736e280a307"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("23370ee4-ecb7-44fb-9ac7-d396999c7eca"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2493a453-217e-4664-9f58-26b626825261"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("258769d6-4554-4b5b-a649-2126233a9b9a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2682d649-a454-4a62-a207-ad27411d3edb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("284e04e3-48ca-4119-8fa8-df1ad5713f14"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("299f1eab-49c5-4efe-b06a-9b5a2f0440ce"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("29d94801-2fa9-4d0f-b349-6010b5406e0b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2cf92328-039f-4ca4-8f13-9144aeb525c0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("2e744094-0a81-433d-b91e-6dfec0a4129e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3077eb86-f92c-4889-8616-3d1ff3b688f8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3269c16e-92cb-4b8f-9ddb-9cd6d87f7ee8"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3336862c-4599-4550-96bc-3df1a676576a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("34c46b1b-50e9-4aee-a279-e98c77531aa1"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("361d1066-ec61-45bb-b014-33f2a84d87fd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3790b237-943c-4898-94ad-bcc55d327dbd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("37c2950d-e0cc-4ae7-902a-af172feea702"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3d8c2d01-433c-4985-bbc5-340f51725a4f"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("3f05df30-9de0-4a7a-a7ce-03f9dc5b1547"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("461e26ea-41e6-4995-acea-b77c1449723a"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4719f42c-9f84-4e04-b08c-8e8606d2c370"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("477114df-1c1e-4409-a5a3-b6b1f3103e06"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("494c023c-2223-4b25-b855-9a56c017b85d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4c4cc220-e1e3-4091-9ebc-24c97f0add93"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4f7cbc31-77e2-4a6a-aee0-5705cb347a40"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("4fe825dc-180c-4a87-9740-8f37073b6290"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("50337b37-bfe8-4c28-812b-04303e0ade06"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("50ac7d47-2056-4d40-9066-c78be66a9d25"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("5477b8d4-4a44-47b9-9fe2-ea557cfbb2e9"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("709e7f4c-12d5-4461-aceb-fe626b89f1a6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("7fe5beec-c495-4c38-b224-86e764e2fabe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("82904538-0e45-4fd5-938b-8d54a63cdcdc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("82c2de4a-7eb7-4ab7-bb71-ec7a2099fdef"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("878f3614-314c-4ae0-b2ba-661603bcb2ed"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8d6a8087-26cf-4be4-ac1e-9e2da6ec50db"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8e583585-d03a-445a-95e8-750ace7fc291"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("8f67f229-b992-4fe1-9138-2b38309c78b0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9133e30b-2266-48d3-8c3c-e8939530a9fe"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9377c34f-c7c1-42a5-8fd1-e02245cd4afd"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9aa6274b-f9d0-476e-a61d-7823b7d8c4f4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("9e41f367-e084-451e-a8a8-b8a805b47b5d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("a883caac-92a1-4ef9-8ba0-95570375b59b"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("ad685077-ef96-4791-87bf-abc943e08424"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("af73b55f-c8b7-459f-986b-5d78ab155eb3"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b0383145-066c-4ed9-a86c-b8d7ee70556d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b4c1132f-063a-44c3-a4cf-6a4e7ae1d42e"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b638b4fb-deab-40b9-9c74-f52a6a0fe502"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b858030a-9820-4b69-91ef-2b3e83f97f56"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b881cf72-acc1-436b-8577-706fda53a38c"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("b8d45ad1-1009-4cf9-b23d-c0db90bb6757"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bc82460d-8593-427f-b5be-6d21b8fe0534"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bec6de7c-3298-4b63-ac7a-4615be4ba051"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("bfe35d53-8096-4564-ae6d-9836f6ba0fb4"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("c3b7ac18-e8dc-4a37-b401-ec994fe10fa0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cb544fd8-3ff2-477b-9e3d-06d64c39e0cc"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cb9f7c31-bf89-4e5c-a56f-cb09a9b02eeb"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("cf12543e-2251-44ab-b7a1-9aa5ee0e87b6"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d0957c87-4dd4-4875-af14-ca95ac63daa0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("d3e8f290-2f5f-4516-8572-d00092be022d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dbc68a4c-a5f6-42e0-89cc-35b188179702"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("dd2d045d-0753-4305-9270-31911a449bb0"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e3091c87-603a-446b-9955-14870f0b1990"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("e55c80c2-6975-4a82-9c7f-573b3f8724a7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("edcfaacd-e229-4248-85c6-c66212206557"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f0b74340-ca89-4429-9f3f-b1f6885dc5d7"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("f60ba848-8c83-40d3-ab75-2cb8a6a1e19d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fc6fe802-24e7-40a9-9129-2330f841bb2d"));

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: new Guid("fd126882-b03b-4337-93a9-df121adef819"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("1d1e3e9b-b392-4fe7-85f0-a3e709408b3c"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("4911e664-f75b-4f2a-92e0-6bbc9fcc6dec"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("4e69d837-ae32-4272-9908-341963a08314"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("51f00ebd-b28e-420c-a999-6f488a90362b"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("78900b9b-e79a-47e0-8e6f-dd27da979fc9"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("7d83b8be-8106-44c7-b757-21229c45a514"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("84d2a33c-3ff2-4698-85eb-860e0eeb1ee3"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("8ce690bc-16ca-42aa-9d7e-bfab034a0d45"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("9c4260d8-b1d6-4fd9-8dd4-b3ecae2f3dc7"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("bd5b2d35-2696-4777-a49e-88ccdff78295"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("c5fe59fb-e679-429a-ba23-57f4038675f4"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("ea069203-b519-4629-bee7-e7a07ad1f1b4"));

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: new Guid("f8f48454-d0ef-4bcf-a75b-5be98be1b838"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "Exercises",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_CreatorId",
                table: "Exercises",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Users_CreatorId",
                table: "Exercises",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
