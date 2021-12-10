using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BMS.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookItems",
                columns: new[] { "Id", "BookTitleId", "IsBorrowed" },
                values: new object[,]
                {
                    { new Guid("009e9651-ffc6-424e-af83-6a17d1d81426"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("02266906-948e-4001-8471-a36af4c315bd"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("04855c69-7899-45df-b0d4-c8ab0e2b1125"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("08267a3c-7f71-45e6-987e-3fa54288c0ba"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("090a57e7-57fb-41d6-80dd-58575e01e504"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("091d4a14-1fd1-4469-a5bc-6da167c29c4b"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("0b16ab75-63a0-4266-8c98-36dfdcc77af3"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("0f36bac8-071b-4f79-911b-a311dc72e7c5"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("104bb48a-4e62-4e26-9ea3-92893f857fd1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1190b225-90a2-47bd-b2e6-7535ef1d9fb0"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("16a71524-6028-4246-a858-89463e73e684"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("173924e0-167f-4fe4-a989-26c15dcce20e"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("17ecfa9c-6e18-4a34-a358-0bdc0903c9cb"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1accaee0-4294-4847-86d0-c7584033f927"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("1b6b123d-426b-4f73-9080-98410f3b6269"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1e30640f-d60c-4ed2-8e77-4884b685b84f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("1eaea26d-13b9-4b09-89fd-70a97e67423d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("20fcc1ed-fb13-44d4-9be7-7e1d64d95e93"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("217a0857-ea2c-45d0-afcb-1b847de24173"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("28063487-b860-4329-86e2-21db1c813e79"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("28a3085b-fa18-4d14-beee-3b91624051a2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2baf47aa-2100-47d0-8104-cd8fbbc73d7e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2d4c2693-4daa-42a8-a64b-83adfe7b7f27"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("2eda274e-1d35-44e7-a861-7f5e08fd6b58"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3007b622-6b90-4be4-83b7-949b5d68fd6c"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("300c6882-021e-411c-b700-fe149fe387b1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("304b7361-efa0-4199-8f0c-0cfad8e91640"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("310e1cf1-2d08-4078-9cdb-d6023f0d33da"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("35d21485-222c-4c8a-b8c3-223a5f443791"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("362494f3-fc1d-4248-badb-b6a663801145"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("36ad5ef3-458a-4b8c-a8c3-5f9d6dad3145"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("36baf297-f769-4f0b-a996-dbfeb205fd35"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("378e62f7-06f7-4d71-8892-c7469d8af1af"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("3a04266a-ef79-4b64-87ae-65db81db2890"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("3af06865-c895-4fc5-821e-fc8b3bda96e9"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("3bbb87b4-6c66-49a1-9e3b-87ed9aada1f6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3be8a52e-2855-48e8-954f-ebb3cb2fecf7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("3caf031d-9b20-435e-a8ba-dc2db46af0c9"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("3f15e1df-7890-4328-9b07-2ef5c030430c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("403faddc-71c5-4804-94e1-d01cb3201db0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("41e53ba1-9f71-4dc3-b9f2-4cc5cc06a8e5"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("425ef931-e93c-42b2-adbb-85e3639d3d2a"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("4275a3b4-ff3d-42ae-a6db-3fd028b07013"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("42a078cf-569f-48cd-93dd-4bf8a016cf62"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("45ed94e6-3cce-459a-8392-58294b9bf749"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4781af55-49d9-447d-b59e-e949d209a5ce"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("49e74183-6720-4f7b-a2e7-b674efdb6482"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("4ab17a0e-6f75-4a7d-9115-e99ebb1d1206"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("4ad94162-89d1-434b-bdd3-e67438a68f39"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("4b13b468-e28a-4ea7-a4c7-5d23343e10c1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("524a42de-a806-44ba-b8f2-d6070fa8e700"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("52a359de-fcad-4097-8bf8-33af8b9fc2b2"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("52c39dc2-5b05-4443-8818-31a02a62a7f7"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("539acbbb-a1f2-404b-aa9c-676e6fa9d162"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("55b4e75e-f2b7-4584-8bb0-e815a221c3e6"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("570013b1-ec80-4066-afdc-6c0d65a46379"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("5923c2db-d6b7-471d-bb92-18f00928d77b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("59261154-14f6-45b9-b681-5bb58da63b49"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5b75c3b8-e964-4c38-9088-69f119e53873"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5d1ef4ce-6606-4f8e-a8ed-0cf723f65669"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("5edcd8cc-249f-4141-9599-48bf32513bc4"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("5f4d310d-b8f3-4647-93bc-a12a46fcb90e"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("5fb6f12f-7e72-4dae-8705-5b57de340810"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("61022a3d-aac5-437a-87f5-b0ea6fb25f06"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("65c06fc6-c9a7-47cc-9cb4-9b52314949a5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("665fe74f-85a4-4a84-9741-815021b35fba"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("66b3974e-5d67-4af3-98e3-9c6f9596915f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("67699d38-12a4-4f6a-8fb7-fe1e897736a0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("67ac8d2f-ee16-449a-a487-4139371d1e9e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("69f0d00d-53b2-4245-8ee7-a5d0189a8a67"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("6ac3a1c0-ad5d-42fb-b013-6b7a04b9c6b8"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("714e8a40-88eb-4dd6-afbc-e0777871e3b1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("72e9737a-30ff-4be9-a3b3-52c95b70b539"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7478d254-29d7-498a-a108-24b76cd7595e"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("78f0a0d2-e5b7-48ba-8963-7a8a0eedc9ae"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("79a15ed7-ccd3-411a-b806-18aa661c6e2a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("7b3d7085-ed80-4c89-bf2b-2132306a145d"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("7d669002-426c-4eb4-a3e6-e2ad09869dc9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("80f6f712-9172-40ac-9517-5ef7c2612117"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8164253c-18cd-4f5c-8e60-804c04a37492"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("83079909-9f0c-4beb-ac12-d8e888d579c1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8690f02b-b811-4b6c-beb6-03aa16217f38"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("871284db-4f4b-47fb-a8a7-b9112df7a0c3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8ab1bc35-c615-4dc8-9a7b-40512e32d159"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("8d066e8d-af52-4530-813a-d286641b72e8"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("8d125c2e-cd16-4fdf-b555-b1062a3e611f"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("8e8f5ee7-6ac8-47fe-8005-dbad159ad2d3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9009b639-8f16-4d6d-97d6-50106f5b96df"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("91bae52e-e10b-4c09-bff4-acb85d9746d3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9284a374-a01b-4643-a557-6bd453bfbb00"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("965b0c21-a5c5-4915-aa0e-4df744457c73"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9756223c-f608-4360-9462-74b3d5883ad1"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9870024f-bbf7-4c41-9c9f-0ba4def7f0ae"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9a0cece0-1d8e-4c8f-bd5d-0986b9ff409c"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("9b219fa0-4a10-4f3b-a04e-b4a67c53a74b"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("9c006e4c-4cdb-4a5c-bce6-575d9d0b36b5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9c5db6a6-464d-445b-8de8-602dcd4591c4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9e703b67-af42-49cc-acca-c8a362b6ca8a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("9f36e916-7f5c-48c5-bea4-bdb5da33fc89"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("a1794f97-ee6f-4a1f-bd63-ec1c3429b01e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("a22c6046-d1e9-4bdf-9abc-59dc4a427ebf"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("aba0097c-4ecc-4577-b691-3eade77a4c4f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("aca61446-70c8-4d6d-b13e-282cd4788c31"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("acdc7aa1-3315-4d9c-bf1e-c59af549b6d1"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("af002f95-aa1f-410d-a222-935158f633f3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("afb24a56-0b20-4980-a78c-7ad29a4ebcb9"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b10fee82-cd9a-4b12-a6ae-acfbd4c2f9b2"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("b155a2e4-b41a-4d49-b505-4d7a54764298"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b5133cac-9750-476c-bd34-3e799de51095"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b543a69e-67a4-4138-abad-63ec5ad321eb"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("b8e5b3f7-4ef5-47a8-8bfc-c0f741cae33c"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bacba8d8-7578-4d00-be01-6ea0e90525e8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bbd92047-eb5d-4384-9c8c-a016725c5c46"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bbfd47dc-80a9-4355-8781-5540fcefdfd5"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("bdc60185-a297-4625-91a6-2c35d628ff80"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c077c3ea-8c81-4fd6-99c0-d42330b7ea4d"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c1ec680c-6ceb-40c3-9c38-bfea9cac189a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c37165d1-3aa3-4ffa-bf18-9d46b3cc2f2b"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c452d927-dce8-4feb-8a5f-1657edc37ede"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("c4bb61a9-158b-4ef4-8ac0-303112d6cd30"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c92412be-8994-417a-a536-926ff637e456"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("c937bfd7-ed18-4c81-9d17-f0c3723fd693"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("c9a788c0-9de6-46c1-891c-5f512c5b287b"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("c9f08002-792d-4a90-8017-997af6b88a44"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cc473831-d78b-417a-848e-9a061901687d"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("cc797d5c-550c-4253-8baa-1cc792aa73f2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("cca018e9-f27a-4767-91f5-0dabeb5d94e4"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d09f669c-8e0f-4a6d-8c3d-6eea78d3fbb5"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("d1da2ed5-7854-4335-bd3c-f2487af50e49"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d2f8c6f1-c616-4ae7-857b-9f6fbc50b6fb"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("d46d51b1-874a-47b1-a634-0e689e3c8403"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d4c85a3b-9eb3-4873-8100-178d0f96925e"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d56bf415-81d0-4a71-b30d-818c3d901856"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d5e458c0-571e-41ee-ac81-3b44355c9002"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d601b3f6-a1ff-42b3-9da4-5123f286fdf9"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d6d7baaa-9dd1-4569-8fa9-9d185e343551"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("d8c4610b-9cc2-477a-8af6-04226bdcdb82"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("daabc93c-f169-4df5-805c-df239ec249f0"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("dda1b0b2-a062-4746-98ab-134910866b89"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("df6ef278-87ad-4592-be78-81dacd2be3d7"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e02586b7-f981-4224-9a7d-61ab23f50abc"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e10e255c-7949-4686-a0ad-542194ec408d"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e3f89ffa-0a18-49a4-b26e-b5accaa17b67"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e5673332-79c3-4df3-963c-e6f120144bb2"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e64cfc17-fb0e-481b-9f5a-1703ed8d5b4a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("e6579027-cf01-4bbc-b709-77d90f184ca7"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("e65e07ea-19f7-46cb-b750-8f601ac51cfd"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e69126c1-417e-495e-b098-c6f8b9f90c3d"), new Guid("1abc27d5-73da-9a8c-ab95-5d7aa8a35f1e"), false },
                    { new Guid("e7392887-0dd9-441a-98c2-a8f698f110b3"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ea7ff54d-a6b8-419c-9681-59a606576bb8"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("eaa2dbf8-f553-4fc5-a132-14c06bc94c8a"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ebcaea0d-4dbc-4235-a831-fc57f7dbdece"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("ee2d8b35-028e-4ba8-9ddb-5a9fb677b9cd"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("f14589c7-bdf8-4540-b969-17eb4ab5dc7d"), new Guid("3ea3fa38-6409-2e3e-04f5-c0cc287c5c96"), false },
                    { new Guid("f173962c-42fd-417c-8070-423f10a64b45"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("f4b3c88b-6d41-4ab0-b78d-5fe0f04fca4f"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("fb9f2a57-ca2a-43af-a63b-fb12cbdc9425"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false },
                    { new Guid("fd28f38b-a506-4b62-bca9-a103a4211e74"), new Guid("7abb6e0a-3b6f-c5a1-2be8-32cdc779a93f"), false },
                    { new Guid("fda6732c-c64a-4c4f-9c4b-1a89cc91b907"), new Guid("cbee1496-fc25-0d42-98cb-827cf70a69d1"), false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("009e9651-ffc6-424e-af83-6a17d1d81426"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("02266906-948e-4001-8471-a36af4c315bd"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("04855c69-7899-45df-b0d4-c8ab0e2b1125"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("08267a3c-7f71-45e6-987e-3fa54288c0ba"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("090a57e7-57fb-41d6-80dd-58575e01e504"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("091d4a14-1fd1-4469-a5bc-6da167c29c4b"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("0b16ab75-63a0-4266-8c98-36dfdcc77af3"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("0f36bac8-071b-4f79-911b-a311dc72e7c5"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("104bb48a-4e62-4e26-9ea3-92893f857fd1"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("1190b225-90a2-47bd-b2e6-7535ef1d9fb0"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("16a71524-6028-4246-a858-89463e73e684"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("173924e0-167f-4fe4-a989-26c15dcce20e"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("17ecfa9c-6e18-4a34-a358-0bdc0903c9cb"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("1accaee0-4294-4847-86d0-c7584033f927"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("1b6b123d-426b-4f73-9080-98410f3b6269"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("1e30640f-d60c-4ed2-8e77-4884b685b84f"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("1eaea26d-13b9-4b09-89fd-70a97e67423d"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("20fcc1ed-fb13-44d4-9be7-7e1d64d95e93"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("217a0857-ea2c-45d0-afcb-1b847de24173"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("28063487-b860-4329-86e2-21db1c813e79"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("28a3085b-fa18-4d14-beee-3b91624051a2"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("2baf47aa-2100-47d0-8104-cd8fbbc73d7e"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("2d4c2693-4daa-42a8-a64b-83adfe7b7f27"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("2eda274e-1d35-44e7-a861-7f5e08fd6b58"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("3007b622-6b90-4be4-83b7-949b5d68fd6c"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("300c6882-021e-411c-b700-fe149fe387b1"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("304b7361-efa0-4199-8f0c-0cfad8e91640"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("310e1cf1-2d08-4078-9cdb-d6023f0d33da"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("35d21485-222c-4c8a-b8c3-223a5f443791"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("362494f3-fc1d-4248-badb-b6a663801145"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("36ad5ef3-458a-4b8c-a8c3-5f9d6dad3145"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("36baf297-f769-4f0b-a996-dbfeb205fd35"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("378e62f7-06f7-4d71-8892-c7469d8af1af"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("3a04266a-ef79-4b64-87ae-65db81db2890"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("3af06865-c895-4fc5-821e-fc8b3bda96e9"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("3bbb87b4-6c66-49a1-9e3b-87ed9aada1f6"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("3be8a52e-2855-48e8-954f-ebb3cb2fecf7"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("3caf031d-9b20-435e-a8ba-dc2db46af0c9"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("3f15e1df-7890-4328-9b07-2ef5c030430c"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("403faddc-71c5-4804-94e1-d01cb3201db0"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("41e53ba1-9f71-4dc3-b9f2-4cc5cc06a8e5"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("425ef931-e93c-42b2-adbb-85e3639d3d2a"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("4275a3b4-ff3d-42ae-a6db-3fd028b07013"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("42a078cf-569f-48cd-93dd-4bf8a016cf62"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("45ed94e6-3cce-459a-8392-58294b9bf749"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("4781af55-49d9-447d-b59e-e949d209a5ce"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("49e74183-6720-4f7b-a2e7-b674efdb6482"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("4ab17a0e-6f75-4a7d-9115-e99ebb1d1206"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("4ad94162-89d1-434b-bdd3-e67438a68f39"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("4b13b468-e28a-4ea7-a4c7-5d23343e10c1"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("524a42de-a806-44ba-b8f2-d6070fa8e700"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("52a359de-fcad-4097-8bf8-33af8b9fc2b2"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("52c39dc2-5b05-4443-8818-31a02a62a7f7"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("539acbbb-a1f2-404b-aa9c-676e6fa9d162"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("55b4e75e-f2b7-4584-8bb0-e815a221c3e6"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("570013b1-ec80-4066-afdc-6c0d65a46379"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("5923c2db-d6b7-471d-bb92-18f00928d77b"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("59261154-14f6-45b9-b681-5bb58da63b49"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("5b75c3b8-e964-4c38-9088-69f119e53873"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("5d1ef4ce-6606-4f8e-a8ed-0cf723f65669"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("5edcd8cc-249f-4141-9599-48bf32513bc4"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("5f4d310d-b8f3-4647-93bc-a12a46fcb90e"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("5fb6f12f-7e72-4dae-8705-5b57de340810"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("61022a3d-aac5-437a-87f5-b0ea6fb25f06"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("65c06fc6-c9a7-47cc-9cb4-9b52314949a5"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("665fe74f-85a4-4a84-9741-815021b35fba"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("66b3974e-5d67-4af3-98e3-9c6f9596915f"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("67699d38-12a4-4f6a-8fb7-fe1e897736a0"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("67ac8d2f-ee16-449a-a487-4139371d1e9e"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("69f0d00d-53b2-4245-8ee7-a5d0189a8a67"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("6ac3a1c0-ad5d-42fb-b013-6b7a04b9c6b8"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("714e8a40-88eb-4dd6-afbc-e0777871e3b1"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("72e9737a-30ff-4be9-a3b3-52c95b70b539"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("7478d254-29d7-498a-a108-24b76cd7595e"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("78f0a0d2-e5b7-48ba-8963-7a8a0eedc9ae"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("79a15ed7-ccd3-411a-b806-18aa661c6e2a"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("7b3d7085-ed80-4c89-bf2b-2132306a145d"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("7d669002-426c-4eb4-a3e6-e2ad09869dc9"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("80f6f712-9172-40ac-9517-5ef7c2612117"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("8164253c-18cd-4f5c-8e60-804c04a37492"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("83079909-9f0c-4beb-ac12-d8e888d579c1"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("8690f02b-b811-4b6c-beb6-03aa16217f38"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("871284db-4f4b-47fb-a8a7-b9112df7a0c3"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("8ab1bc35-c615-4dc8-9a7b-40512e32d159"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("8d066e8d-af52-4530-813a-d286641b72e8"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("8d125c2e-cd16-4fdf-b555-b1062a3e611f"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("8e8f5ee7-6ac8-47fe-8005-dbad159ad2d3"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9009b639-8f16-4d6d-97d6-50106f5b96df"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("91bae52e-e10b-4c09-bff4-acb85d9746d3"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9284a374-a01b-4643-a557-6bd453bfbb00"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("965b0c21-a5c5-4915-aa0e-4df744457c73"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9756223c-f608-4360-9462-74b3d5883ad1"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9870024f-bbf7-4c41-9c9f-0ba4def7f0ae"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9a0cece0-1d8e-4c8f-bd5d-0986b9ff409c"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9b219fa0-4a10-4f3b-a04e-b4a67c53a74b"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9c006e4c-4cdb-4a5c-bce6-575d9d0b36b5"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9c5db6a6-464d-445b-8de8-602dcd4591c4"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9e703b67-af42-49cc-acca-c8a362b6ca8a"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("9f36e916-7f5c-48c5-bea4-bdb5da33fc89"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("a1794f97-ee6f-4a1f-bd63-ec1c3429b01e"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("a22c6046-d1e9-4bdf-9abc-59dc4a427ebf"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("aba0097c-4ecc-4577-b691-3eade77a4c4f"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("aca61446-70c8-4d6d-b13e-282cd4788c31"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("acdc7aa1-3315-4d9c-bf1e-c59af549b6d1"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("af002f95-aa1f-410d-a222-935158f633f3"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("afb24a56-0b20-4980-a78c-7ad29a4ebcb9"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("b10fee82-cd9a-4b12-a6ae-acfbd4c2f9b2"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("b155a2e4-b41a-4d49-b505-4d7a54764298"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("b5133cac-9750-476c-bd34-3e799de51095"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("b543a69e-67a4-4138-abad-63ec5ad321eb"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("b8e5b3f7-4ef5-47a8-8bfc-c0f741cae33c"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("bacba8d8-7578-4d00-be01-6ea0e90525e8"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("bbd92047-eb5d-4384-9c8c-a016725c5c46"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("bbfd47dc-80a9-4355-8781-5540fcefdfd5"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("bdc60185-a297-4625-91a6-2c35d628ff80"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c077c3ea-8c81-4fd6-99c0-d42330b7ea4d"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c1ec680c-6ceb-40c3-9c38-bfea9cac189a"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c37165d1-3aa3-4ffa-bf18-9d46b3cc2f2b"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c452d927-dce8-4feb-8a5f-1657edc37ede"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c4bb61a9-158b-4ef4-8ac0-303112d6cd30"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c92412be-8994-417a-a536-926ff637e456"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c937bfd7-ed18-4c81-9d17-f0c3723fd693"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c9a788c0-9de6-46c1-891c-5f512c5b287b"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("c9f08002-792d-4a90-8017-997af6b88a44"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("cc473831-d78b-417a-848e-9a061901687d"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("cc797d5c-550c-4253-8baa-1cc792aa73f2"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("cca018e9-f27a-4767-91f5-0dabeb5d94e4"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d09f669c-8e0f-4a6d-8c3d-6eea78d3fbb5"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d1da2ed5-7854-4335-bd3c-f2487af50e49"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d2f8c6f1-c616-4ae7-857b-9f6fbc50b6fb"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d46d51b1-874a-47b1-a634-0e689e3c8403"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d4c85a3b-9eb3-4873-8100-178d0f96925e"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d56bf415-81d0-4a71-b30d-818c3d901856"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d5e458c0-571e-41ee-ac81-3b44355c9002"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d601b3f6-a1ff-42b3-9da4-5123f286fdf9"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d6d7baaa-9dd1-4569-8fa9-9d185e343551"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("d8c4610b-9cc2-477a-8af6-04226bdcdb82"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("daabc93c-f169-4df5-805c-df239ec249f0"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("dda1b0b2-a062-4746-98ab-134910866b89"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("df6ef278-87ad-4592-be78-81dacd2be3d7"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e02586b7-f981-4224-9a7d-61ab23f50abc"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e10e255c-7949-4686-a0ad-542194ec408d"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e3f89ffa-0a18-49a4-b26e-b5accaa17b67"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e5673332-79c3-4df3-963c-e6f120144bb2"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e64cfc17-fb0e-481b-9f5a-1703ed8d5b4a"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e6579027-cf01-4bbc-b709-77d90f184ca7"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e65e07ea-19f7-46cb-b750-8f601ac51cfd"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e69126c1-417e-495e-b098-c6f8b9f90c3d"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("e7392887-0dd9-441a-98c2-a8f698f110b3"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("ea7ff54d-a6b8-419c-9681-59a606576bb8"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("eaa2dbf8-f553-4fc5-a132-14c06bc94c8a"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("ebcaea0d-4dbc-4235-a831-fc57f7dbdece"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("ee2d8b35-028e-4ba8-9ddb-5a9fb677b9cd"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("f14589c7-bdf8-4540-b969-17eb4ab5dc7d"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("f173962c-42fd-417c-8070-423f10a64b45"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("f4b3c88b-6d41-4ab0-b78d-5fe0f04fca4f"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("fb9f2a57-ca2a-43af-a63b-fb12cbdc9425"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("fd28f38b-a506-4b62-bca9-a103a4211e74"));

            migrationBuilder.DeleteData(
                table: "BookItems",
                keyColumn: "Id",
                keyValue: new Guid("fda6732c-c64a-4c4f-9c4b-1a89cc91b907"));
        }
    }
}
