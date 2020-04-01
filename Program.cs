// Hello World Example
// JNBridge Sales Engineering
// Visual Studio 2019, .NET Core 3.1, Java 8

// Before attempting to run this demo, be sure to see included jnbridgeConfig.json and make path adjustments
// to insure the app can find your systems installed JVM(s) and other system dependent components.
// Demo assumes there is a valid JNBridgePro evaluation license in default location: "C:\\Program Files (x86)\\JNBridge\\JNBridgePro v10.1"

using System;
using com.dmn;
//using helloWorldDemo; 

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string dmnstring = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>" +
                         "<semantic:definitions xmlns:semantic=\"http://www.omg.org/spec/DMN/20151101/dmn.xsd\" xmlns=\"http://www.trisotech.com/definitions/_15587d56-cedf-4cef-9f16-fe20b223021b\" xmlns:feel=\"http://www.omg.org/spec/FEEL/20140401\" xmlns:tc=\"http://www.omg.org/spec/DMN/20160719/testcase\" xmlns:triso=\"http://www.trisotech.com/2015/triso/modeling\" xmlns:trisofeed=\"http://trisotech.com/feed\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" exporter=\"DMN Modeler\" exporterVersion=\"5.2.14.2\" id=\"_15587d56-cedf-4cef-9f16-fe20b223021b\" name=\"dish-decision\" namespace=\"http://www.trisotech.com/definitions/_15587d56-cedf-4cef-9f16-fe20b223021b\" triso:logoChoice=\"Default\">" +
                         "  <semantic:extensionElements/>" +
                         "  <semantic:itemDefinition label=\"tSeason\" name=\"tSeason\">" +
                         "    <semantic:typeRef>feel:string</semantic:typeRef>" +
                         "    <semantic:allowedValues triso:constraintsType=\"enumeration\">" +
                         "      <semantic:text>\"Fall\",\"Winter\",\"Spring\",\"Summer\"</semantic:text>" +
                         "    </semantic:allowedValues>" +
                         "  </semantic:itemDefinition>" +
                         "  <semantic:itemDefinition label=\"tGuests\" name=\"tGuests\">" +
                         "    <semantic:typeRef>feel:number</semantic:typeRef>" +
                         "  </semantic:itemDefinition>" +
                         "  <semantic:itemDefinition label=\"tDish\" name=\"tDish\">" +
                         "    <semantic:typeRef>feel:string</semantic:typeRef>" +
                         "  </semantic:itemDefinition>" +
                         "  <semantic:decision id=\"_6aceedc5-4809-4a73-810c-aab05eb94f2d\" name=\"Dish Decision\">" +
                         "    <semantic:variable id=\"_899da7ed-04eb-4b5e-aeb1-5f1119b23484\" name=\"Dish Decision\" typeRef=\"tDish\"/>" +
                         "    <semantic:informationRequirement>" +
                         "      <semantic:requiredInput href=\"#_d2ea8047-0a34-4942-91ff-e718ce5880c6\"/>" +
                         "    </semantic:informationRequirement>" +
                         "    <semantic:informationRequirement>" +
                         "      <semantic:requiredInput href=\"#_9d7010c2-4ec8-4ff7-998e-9bb65fb117a7\"/>" +
                         "    </semantic:informationRequirement>" +
                         "    <semantic:decisionTable hitPolicy=\"UNIQUE\" id=\"_90997060-896e-49a6-9ad4-b1bcc46a5846\" outputLabel=\"Dish Decision\">" +
                         "      <semantic:input id=\"_15f27d6b-9a5a-427d-baf6-a2163a0bf43c\">" +
                         "        <semantic:inputExpression typeRef=\"tSeason\">" +
                         "          <semantic:text>Season</semantic:text>" +
                         "        </semantic:inputExpression>" +
                         "        <semantic:inputValues triso:constraintsType=\"enumeration\">" +
                         "          <semantic:text>\"Fall\",\"Winter\",\"Spring\",\"Summer\"</semantic:text>" +
                         "        </semantic:inputValues>" +
                         "      </semantic:input>" +
                         "      <semantic:input id=\"_5527901a-1404-44a9-a50c-72b65eeffd00\">" +
                         "        <semantic:inputExpression typeRef=\"tGuests\">" +
                         "          <semantic:text>How many guests</semantic:text>" +
                         "        </semantic:inputExpression>" +
                         "      </semantic:input>" +
                         "      <semantic:output id=\"_634f46b6-bd3f-41e6-9956-2baea0c34f70\"/>" +
                         "      <semantic:rule id=\"_5622957e-bc0c-492b-9ce6-2fe6405eeb20\">" +
                         "        <semantic:inputEntry id=\"_57837258-4782-4674-ad8d-4bfb14d81317\">" +
                         "          <semantic:text>\"Fall\"</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:inputEntry id=\"_1d236568-bfa0-4dfb-8fcb-8062e279b4b7\">" +
                         "          <semantic:text>&lt;= 8</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:outputEntry id=\"_379a2c77-b8f1-482b-b073-14e6f9130670\">" +
                         "          <semantic:text>\"Spareribs\"</semantic:text>" +
                         "        </semantic:outputEntry>" +
                         "      </semantic:rule>" +
                         "      <semantic:rule id=\"_a0e212d9-d632-4a39-bc28-db009afef98a\">" +
                         "        <semantic:inputEntry id=\"_b599157e-0c41-42ce-94af-abd655706169\">" +
                         "          <semantic:text>\"Winter\"</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:inputEntry id=\"_8beed46d-770e-4df7-bfd6-131fc3dd0aba\">" +
                         "          <semantic:text>&lt;= 8</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:outputEntry id=\"_96c195cc-bd29-414c-95ec-2d00d46e037f\">" +
                         "          <semantic:text>\"Roastbeef\"</semantic:text>" +
                         "        </semantic:outputEntry>" +
                         "      </semantic:rule>" +
                         "      <semantic:rule id=\"_5c48feca-ef56-437a-9bfe-cc3008e456b6\">" +
                         "        <semantic:inputEntry id=\"_25d6b3c0-dad8-4798-ba6b-aabaf1798ca2\">" +
                         "          <semantic:text>\"Spring\"</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:inputEntry id=\"_14848008-db78-4405-b145-04b07f762a87\">" +
                         "          <semantic:text>&lt;= 4</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:outputEntry id=\"_3e174a64-f5c9-448e-a52f-324a08ca5c23\">" +
                         "          <semantic:text>\"Dry Aged Gourmet Steak\"</semantic:text>" +
                         "        </semantic:outputEntry>" +
                         "      </semantic:rule>" +
                         "      <semantic:rule id=\"_ccdcf5d1-75a6-447b-8285-eeaad8440945\">" +
                         "        <semantic:description>Save money</semantic:description>" +
                         "        <semantic:inputEntry id=\"_96c60ba8-b761-476e-99f9-cbb02657f47b\">" +
                         "          <semantic:text>\"Spring\"</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:inputEntry id=\"_c1f1c2e7-1d76-48bb-a9f7-f53739d77a57\">" +
                         "          <semantic:text>[5..8]</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:outputEntry id=\"_6f3883a9-113f-4e16-96dd-361f2e8c7917\">" +
                         "          <semantic:text>\"Steak\"</semantic:text>" +
                         "        </semantic:outputEntry>" +
                         "      </semantic:rule>" +
                         "      <semantic:rule id=\"_a73cdf14-0d81-4e2f-bbc7-ed8b92cc5c4d\">" +
                         "        <semantic:description>Less effort</semantic:description>" +
                         "        <semantic:inputEntry id=\"_b4ef3b99-e442-407c-a201-fb06e51c562d\">" +
                         "          <semantic:text>\"Fall\", \"Winter\", \"Spring\"</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:inputEntry id=\"_5a417624-b9ac-4ea8-acf0-ceafaa52250b\">" +
                         "          <semantic:text>&gt; 8</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:outputEntry id=\"_fb97fd8c-798b-4a98-80c7-5853d8151127\">" +
                         "          <semantic:text>\"Stew\"</semantic:text>" +
                         "        </semantic:outputEntry>" +
                         "      </semantic:rule>" +
                         "      <semantic:rule id=\"_d7e6f6f5-b640-42f3-88a5-886b03ffc34c\">" +
                         "        <semantic:description>Hey, why not!?</semantic:description>" +
                         "        <semantic:inputEntry id=\"_9a97da0a-37ef-44a3-a891-7d2e0ed88f1a\">" +
                         "          <semantic:text>\"Summer\"</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:inputEntry id=\"_38efbdb0-debc-4dc3-8ef0-4c973e1c6124\">" +
                         "          <semantic:text>-</semantic:text>" +
                         "        </semantic:inputEntry>" +
                         "        <semantic:outputEntry id=\"_c45c1448-1ac5-464b-afd4-e896a50376c7\">" +
                         "          <semantic:text>\"Light Salad and a nice Steak\"</semantic:text>" +
                         "        </semantic:outputEntry>" +
                         "      </semantic:rule>" +
                         "    </semantic:decisionTable>" +
                         "  </semantic:decision>" +
                         "  <semantic:inputData id=\"_d2ea8047-0a34-4942-91ff-e718ce5880c6\" name=\"Season\">" +
                         "    <semantic:variable id=\"_14c791d2-1029-444b-944e-3c12e3995b56\" name=\"Season\" typeRef=\"tSeason\"/>" +
                         "  </semantic:inputData>" +
                         "  <semantic:inputData id=\"_9d7010c2-4ec8-4ff7-998e-9bb65fb117a7\" name=\"How many guests\">" +
                         "    <semantic:variable id=\"_269694a2-22bc-4c17-a1be-82f488cdff16\" name=\"How many guests\" typeRef=\"tGuests\"/>" +
                         "  </semantic:inputData>" +
                         "</semantic:definitions>";

            


            string dmnstring1 = "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>\n" +
                "<semantic:definitions xmlns:semantic=\"http://www.omg.org/spec/DMN/20180521/MODEL/\"  xmlns:triso=\"http://www.trisotech.com/2015/triso/modeling\"  xmlns:dmndi=\"http://www.omg.org/spec/DMN/20180521/DMNDI/\"  xmlns:di=\"http://www.omg.org/spec/DMN/20180521/DI/\"  xmlns:dc=\"http://www.omg.org/spec/DMN/20180521/DC/\"  xmlns:trisodmn=\"http://www.trisotech.com/2016/triso/dmn\"  xmlns:feel=\"http://www.omg.org/spec/DMN/20180521/FEEL/\"  xmlns:tc=\"http://www.omg.org/spec/DMN/20160719/testcase\"  xmlns:drools=\"http://www.drools.org/kie/dmn/1.1\"  xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"  xmlns:rss=\"http://purl.org/rss/2.0/\"  xmlns:openapi=\"https://openapis.org/omg/extension/1.0\"  xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"  xmlns=\"http://www.trisotech.com/definitions/_90a9fca6-4312-478e-b109-31237bf9c316\" id=\"_90a9fca6-4312-478e-b109-31237bf9c316\" name=\"BMI\" namespace=\"http://www.trisotech.com/definitions/_90a9fca6-4312-478e-b109-31237bf9c316\" exporter=\"Decision Modeler\" exporterVersion=\"6.9.3\" triso:logoChoice=\"Default\">\n" +
                "    <semantic:extensionElements/>\n" +
                "    <semantic:itemDefinition name=\"tBMIScore\" label=\"tBMIScore\" isCollection=\"false\">\n" +
                "        <semantic:typeRef>number</semantic:typeRef>\n" +
                "    </semantic:itemDefinition>\n" +
                "    <semantic:decisionService id=\"_90a9fca6-4312-478e-b109-31237bf9c316_DS\" name=\"Whole Model Decision Service\" triso:dynamicDecisionService=\"true\" triso:wholeModelService=\"true\">\n" +
                "        <semantic:variable name=\"Whole Model Decision Service\" id=\"_90a9fca6-4312-478e-b109-31237bf9c316_DS_VAR\" typeRef=\"Any\"/>\n" +
                "        <semantic:outputDecision href=\"#_529abd30-9d90-46ee-bbab-9550a974b702\"/>\n" +
                "        <semantic:inputData href=\"#_f53df237-486a-42fd-95b1-64af7f0ae90b\"/>\n" +
                "        <semantic:inputData href=\"#_d267003d-400e-4026-bb43-5976137c8b6e\"/>\n" +
                "    </semantic:decisionService>\n" +
                "    <semantic:decisionService id=\"_13730806-1922-46dd-935f-3a818dccd822_DS\" name=\"Diagram Page 1\" triso:dynamicDecisionService=\"true\">\n" +
                "        <semantic:variable name=\"Diagram Page 1\" id=\"_13730806-1922-46dd-935f-3a818dccd822_DS_VAR\" typeRef=\"Any\"/>\n" +
                "        <semantic:outputDecision href=\"#_529abd30-9d90-46ee-bbab-9550a974b702\"/>\n" +
                "        <semantic:inputData href=\"#_f53df237-486a-42fd-95b1-64af7f0ae90b\"/>\n" +
                "        <semantic:inputData href=\"#_d267003d-400e-4026-bb43-5976137c8b6e\"/>\n" +
                "    </semantic:decisionService>\n" +
                "    <semantic:inputData id=\"_f53df237-486a-42fd-95b1-64af7f0ae90b\" name=\"Height\">\n" +
                "        <semantic:variable name=\"Height\" id=\"_db7b20b4-c75e-441a-933d-9a1598a78373\" typeRef=\"string\"/>\n" +
                "    </semantic:inputData>\n" +
                "    <semantic:inputData id=\"_d267003d-400e-4026-bb43-5976137c8b6e\" name=\"Weight\">\n" +
                "        <semantic:variable name=\"Weight\" id=\"_c1630fc0-3a03-450c-ab69-19b889df9313\" typeRef=\"string\"/>\n" +
                "    </semantic:inputData>\n" +
                "    <semantic:decision id=\"_529abd30-9d90-46ee-bbab-9550a974b702\" name=\"Find BMI\">\n" +
                "        <semantic:variable name=\"Find BMI\" id=\"_1f45fdae-aa08-4ca5-bbb0-baf36ff2e45b\" typeRef=\"Any\"/>\n" +
                "        <semantic:informationRequirement id=\"_f8be43de-1057-4940-8ea6-4142132448ba\">\n" +
                "            <semantic:requiredInput href=\"#_f53df237-486a-42fd-95b1-64af7f0ae90b\"/>\n" +
                "        </semantic:informationRequirement>\n" +
                "        <semantic:informationRequirement id=\"_1ccdc6ca-2f43-42ff-8189-705c1b49cfce\">\n" +
                "            <semantic:requiredInput href=\"#_d267003d-400e-4026-bb43-5976137c8b6e\"/>\n" +
                "        </semantic:informationRequirement>\n" +
                "        <semantic:knowledgeRequirement id=\"_df6bd981-da6b-4b22-b729-c6249e6d0334\">\n" +
                "            <semantic:requiredKnowledge href=\"#_a58305d2-031a-4d0d-8f31-89a78064d40c\"/>\n" +
                "        </semantic:knowledgeRequirement>\n" +
                "        <semantic:context id=\"_4da07499-1b6b-4ba3-963a-2b4b71ff1925\" typeRef=\"Any\" triso:expressionId=\"_c2e27887-cf42-4a80-9d38-db453135a535\">\n" +
                "            <semantic:contextEntry id=\"_70520a0d-efe9-41f1-95ea-80fbb68f0f70\">\n" +
                "                <semantic:variable name=\"BMI Score\" id=\"_19d52598-3b2d-41f2-b0e9-1ec106949d3c\" typeRef=\"number\"/>\n" +
                "                <semantic:invocation id=\"_52322ac1-9a0b-430d-a08a-75a038566fff\">\n" +
                "                    <semantic:literalExpression id=\"literal__52322ac1-9a0b-430d-a08a-75a038566fff\">\n" +
                "                        <semantic:text>BMI Formula</semantic:text>\n" +
                "                    </semantic:literalExpression>\n" +
                "                    <semantic:binding>\n" +
                "                        <semantic:parameter id=\"_a9ad947f-a665-4aa1-b8f8-0d0d82ae8272\" name=\"H\"/>\n" +
                "                        <semantic:literalExpression id=\"_6783c277-f1ff-4254-8e81-220a47936a25\">\n" +
                "                            <semantic:text>Height</semantic:text>\n" +
                "                        </semantic:literalExpression>\n" +
                "                    </semantic:binding>\n" +
                "                    <semantic:binding>\n" +
                "                        <semantic:parameter id=\"_3ab22521-ea12-4f05-bb4d-9f96700f3bac\" name=\"W\"/>\n" +
                "                        <semantic:literalExpression id=\"_d0316fbd-e041-42cf-a856-4ad2c923fd56\">\n" +
                "                            <semantic:text>Weight  </semantic:text>\n" +
                "                        </semantic:literalExpression>\n" +
                "                    </semantic:binding>\n" +
                "                </semantic:invocation>\n" +
                "            </semantic:contextEntry>\n" +
                "            <semantic:contextEntry id=\"_4081003a-f281-42f0-87e4-b77956f72c6c\">\n" +
                "                <semantic:variable name=\"BMI Category\" id=\"_6acaef95-f94f-4c32-a59c-011469ce772d\" typeRef=\"Any\"/>\n" +
                "                <semantic:decisionTable id=\"_35cb0786-be09-4f52-9ea7-2eb437e8e614\" hitPolicy=\"UNIQUE\" outputLabel=\"BMI Category\">\n" +
                "                    <semantic:input id=\"_ba71c780-22db-4d0d-ae73-32950e7b1479\" triso:allowNull=\"true\" label=\"BMI Score\">\n" +
                "                        <semantic:inputExpression typeRef=\"number\">\n" +
                "                            <semantic:text>BMI Score</semantic:text>\n" +
                "                        </semantic:inputExpression>\n" +
                "                    </semantic:input>\n" +
                "                    <semantic:output id=\"_9fcb6dff-75e9-41be-b665-67771a4f61fd\" triso:allowNull=\"true\"/>\n" +
                "                    <semantic:annotation name=\"Description\"/>\n" +
                "                    <semantic:rule id=\"_7249f998-7622-4e7b-a662-096b4b3d8840\">\n" +
                "                        <semantic:inputEntry id=\"_2f93a4ac-d587-42a0-b985-79469bd78a84\">\n" +
                "                            <semantic:text>&lt;18.5</semantic:text>\n" +
                "                        </semantic:inputEntry>\n" +
                "                        <semantic:outputEntry id=\"_763c1058-8616-49b7-a8bd-8e43bd9c597a\">\n" +
                "                            <semantic:text>\"Under weight\"</semantic:text>\n" +
                "                        </semantic:outputEntry>\n" +
                "                        <semantic:annotationEntry>\n" +
                "                            <semantic:text/>\n" +
                "                        </semantic:annotationEntry>\n" +
                "                    </semantic:rule>\n" +
                "                    <semantic:rule id=\"_62fa3adb-503b-4a30-962a-27c4eae46852\">\n" +
                "                        <semantic:inputEntry id=\"_75c56c37-95af-4362-8735-c23d08e58aec\">\n" +
                "                            <semantic:text>[18.5..25)</semantic:text>\n" +
                "                        </semantic:inputEntry>\n" +
                "                        <semantic:outputEntry id=\"_68806b13-1768-4385-bd70-f9550736b493\">\n" +
                "                            <semantic:text>\"Normal Weight\"</semantic:text>\n" +
                "                        </semantic:outputEntry>\n" +
                "                        <semantic:annotationEntry>\n" +
                "                            <semantic:text/>\n" +
                "                        </semantic:annotationEntry>\n" +
                "                    </semantic:rule>\n" +
                "                    <semantic:rule id=\"_0b872828-5ca3-4008-bff8-941fd9edcc9b\">\n" +
                "                        <semantic:inputEntry id=\"_ba08fdc9-c52e-41cb-b271-1dcba4698d9e\">\n" +
                "                            <semantic:text>[25..30)</semantic:text>\n" +
                "                        </semantic:inputEntry>\n" +
                "                        <semantic:outputEntry id=\"_308efd1f-6b1f-42c3-a999-3d70812816b1\">\n" +
                "                            <semantic:text>\"Over Weight\"</semantic:text>\n" +
                "                        </semantic:outputEntry>\n" +
                "                        <semantic:annotationEntry>\n" +
                "                            <semantic:text/>\n" +
                "                        </semantic:annotationEntry>\n" +
                "                    </semantic:rule>\n" +
                "                    <semantic:rule id=\"_9c08822d-503c-4bc4-adcb-8557d41cc1f8\">\n" +
                "                        <semantic:inputEntry id=\"_e0b0f83d-92df-43dd-bc05-037e00a6fa9c\">\n" +
                "                            <semantic:text>&gt;=30</semantic:text>\n" +
                "                        </semantic:inputEntry>\n" +
                "                        <semantic:outputEntry id=\"_e52fa589-f236-40f7-bd9b-e49977e0d51e\">\n" +
                "                            <semantic:text>\"Obese\"</semantic:text>\n" +
                "                        </semantic:outputEntry>\n" +
                "                        <semantic:annotationEntry>\n" +
                "                            <semantic:text/>\n" +
                "                        </semantic:annotationEntry>\n" +
                "                    </semantic:rule>\n" +
                "                </semantic:decisionTable>\n" +
                "            </semantic:contextEntry>\n" +
                "            <semantic:contextEntry id=\"_70747767-eb9e-403f-b89f-d1e48ec995e1\">\n" +
                "                <semantic:literalExpression id=\"_f77ecf82-5b24-4af2-ab23-a4b4bc7921dc\">\n" +
                "                    <semantic:text>BMI Category</semantic:text>\n" +
                "                </semantic:literalExpression>\n" +
                "            </semantic:contextEntry>\n" +
                "        </semantic:context>\n" +
                "    </semantic:decision>\n" +
                "    <semantic:decisionService id=\"_32e7c4ef-15f4-420a-ba69-ae106c2d1546\" name=\"Decision Service Find BMI\">\n" +
                "        <semantic:variable name=\"Decision Service Find BMI\" id=\"_ea513fec-6ac1-4ecd-9cea-4596a28af5f3\" typeRef=\"Any\"/>\n" +
                "        <semantic:outputDecision href=\"#_529abd30-9d90-46ee-bbab-9550a974b702\"/>\n" +
                "        <semantic:inputData href=\"#_f53df237-486a-42fd-95b1-64af7f0ae90b\"/>\n" +
                "        <semantic:inputData href=\"#_d267003d-400e-4026-bb43-5976137c8b6e\"/>\n" +
                "    </semantic:decisionService>\n" +
                "    <semantic:businessKnowledgeModel id=\"_a58305d2-031a-4d0d-8f31-89a78064d40c\" name=\"BMI Formula\">\n" +
                "        <semantic:variable name=\"BMI Formula\" id=\"_0c8db230-dfc8-45f2-a7c1-0e4f69d30bb8\" typeRef=\"number\"/>\n" +
                "        <semantic:encapsulatedLogic id=\"_347da631-130c-4541-9584-93c7a7fb99dc\" kind=\"FEEL\" typeRef=\"number\" triso:expressionId=\"_a3a35e2e-b9ac-43d1-885b-07ee3895641f\">\n" +
                "            <semantic:formalParameter name=\"H\" typeRef=\"number\" id=\"_f6dd4cd1-90a3-464c-91f8-3ff7f73c161b\"/>\n" +
                "            <semantic:formalParameter name=\"W\" typeRef=\"number\" id=\"_a518ffd3-0489-4a5d-8396-55310bd019fb\"/>\n" +
                "            <semantic:literalExpression id=\"_e6f6843f-817b-41f3-bb1e-17719e25fbde\" expressionLanguage=\"http://www.omg.org/spec/DMN/20180521/FEEL/\" triso:unparsed=\"false\" typeRef=\"number\">\n" +
                "                <semantic:text>decimal((W/H**2)*703,1)</semantic:text>\n" +
                "            </semantic:literalExpression>\n" +
                "        </semantic:encapsulatedLogic>\n" +
                "        <semantic:authorityRequirement id=\"_5af2cd1c-a024-43d5-a3b8-dd0d088cc8c4\">\n" +
                "            <semantic:requiredAuthority href=\"#_33fbce32-d278-453c-a453-1a63fb2641ab\"/>\n" +
                "        </semantic:authorityRequirement>\n" +
                "    </semantic:businessKnowledgeModel>\n" +
                "    <semantic:knowledgeSource id=\"_33fbce32-d278-453c-a453-1a63fb2641ab\" name=\"BMI\">\n" +
                "        <semantic:description>&lt;p&gt;BMI formula&lt;/p&gt;</semantic:description>\n" +
                "        <semantic:extensionElements>\n" +
                "            <triso:attachment id=\"_5a255948-090a-406f-83d4-8ed6939fec01\" name=\"BMI\" url=\"https://www.calculator.net/bmi-calculator.html\" type=\"link\" play=\"true\"/>\n" +
                "        </semantic:extensionElements>\n" +
                "    </semantic:knowledgeSource>\n" +
                "    <dmndi:DMNDI>\n" +
                "        <dmndi:DMNDiagram id=\"_13730806-1922-46dd-935f-3a818dccd822\" triso:modelElementRef=\"_6ee7ea4b-665d-4b5b-8fd4-793c606ec387\" name=\"Page 1\">\n" +
                "            <di:extension/>\n" +
                "            <dmndi:Size height=\"1050\" width=\"1485\"/>\n" +
                "            <dmndi:DMNShape id=\"_d1f23a62-080e-47eb-a3d5-d94b14b04a2b\" dmnElementRef=\"_f53df237-486a-42fd-95b1-64af7f0ae90b\">\n" +
                "                <dc:Bounds x=\"350.7588291168213\" y=\"392.99999618530273\" width=\"135.48234176635742\" height=\"60.00000762939453\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNShape id=\"_53ec140c-4f2b-4bf3-ab35-6fae44f8045d\" dmnElementRef=\"_d267003d-400e-4026-bb43-5976137c8b6e\">\n" +
                "                <dc:Bounds x=\"665.7588291168213\" y=\"392.99999618530273\" width=\"135.48234176635742\" height=\"60.00000762939453\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNShape id=\"_ffc5f150-e9d0-4fb8-bdcf-4d4e30155180\" dmnElementRef=\"_529abd30-9d90-46ee-bbab-9550a974b702\">\n" +
                "                <dc:Bounds x=\"477\" y=\"205\" width=\"153\" height=\"60\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNShape id=\"_f9347ff9-2f7f-46fe-b70a-827d34ec36a2\" dmnElementRef=\"_a58305d2-031a-4d0d-8f31-89a78064d40c\">\n" +
                "                <dc:Bounds x=\"754\" y=\"205\" width=\"153\" height=\"60\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNShape id=\"_106fa581-8f66-4b48-bcb2-382d706e0867\" dmnElementRef=\"_33fbce32-d278-453c-a453-1a63fb2641ab\">\n" +
                "                <dc:Bounds x=\"1000.5\" y=\"200.02132034301758\" width=\"100\" height=\"69.95735931396484\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNEdge id=\"_fa62bba0-fa95-4ed5-b833-94b3100eae19\" dmnElementRef=\"_df6bd981-da6b-4b22-b729-c6249e6d0334\">\n" +
                "                <di:waypoint x=\"755\" y=\"235\"/>\n" +
                "                <di:waypoint x=\"630\" y=\"235\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "            <dmndi:DMNEdge id=\"_be9fc277-aebd-4f5a-b3f5-299306a23d40\" dmnElementRef=\"_f8be43de-1057-4940-8ea6-4142132448ba\">\n" +
                "                <di:waypoint x=\"486.2411708831787\" y=\"422.99999618530273\"/>\n" +
                "                <di:waypoint x=\"523.5\" y=\"265\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "            <dmndi:DMNEdge id=\"_13b53486-bca9-4f7a-b050-795f87beff64\" dmnElementRef=\"_1ccdc6ca-2f43-42ff-8189-705c1b49cfce\">\n" +
                "                <di:waypoint x=\"665.9968013763428\" y=\"422.99999618530273\"/>\n" +
                "                <di:waypoint x=\"583.5\" y=\"265\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "            <dmndi:DMNEdge id=\"_6243cc7c-7a3e-4850-810a-010fff6682b3\" dmnElementRef=\"_5af2cd1c-a024-43d5-a3b8-dd0d088cc8c4\">\n" +
                "                <di:waypoint x=\"1000.5\" y=\"234.42132034301758\"/>\n" +
                "                <di:waypoint x=\"907\" y=\"235\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "        </dmndi:DMNDiagram>\n" +
                "        <dmndi:DMNStyle id=\"LS_90a9fca6-4312-478e-b109-31237bf9c316_0\" fontFamily=\"arial,helvetica,sans-serif\" fontSize=\"11\" fontBold=\"false\" fontItalic=\"false\" fontUnderline=\"false\" fontStrikeThrough=\"false\"/>\n" +
                "    </dmndi:DMNDI>\n" +
                "</semantic:definitions>";



            string dmnstring2= "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>\n" +
                "<semantic:definitions xmlns:semantic=\"http://www.omg.org/spec/DMN/20180521/MODEL/\"  xmlns:triso=\"http://www.trisotech.com/2015/triso/modeling\"  xmlns:dmndi=\"http://www.omg.org/spec/DMN/20180521/DMNDI/\"  xmlns:di=\"http://www.omg.org/spec/DMN/20180521/DI/\"  xmlns:dc=\"http://www.omg.org/spec/DMN/20180521/DC/\"  xmlns:trisodmn=\"http://www.trisotech.com/2016/triso/dmn\"  xmlns:feel=\"http://www.omg.org/spec/DMN/20180521/FEEL/\"  xmlns:tc=\"http://www.omg.org/spec/DMN/20160719/testcase\"  xmlns:drools=\"http://www.drools.org/kie/dmn/1.1\"  xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"  xmlns:rss=\"http://purl.org/rss/2.0/\"  xmlns:openapi=\"https://openapis.org/omg/extension/1.0\"  xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"  xmlns=\"http://www.trisotech.com/definitions/_9e55adb5-b7d3-4400-8640-a929c8a80f21\" id=\"_9e55adb5-b7d3-4400-8640-a929c8a80f21\" name=\"Vacation days\" namespace=\"http://www.trisotech.com/definitions/_9e55adb5-b7d3-4400-8640-a929c8a80f21\" exporter=\"Decision Modeler\" exporterVersion=\"6.9.3\" triso:logoChoice=\"Default\">\n" +
                "    <semantic:extensionElements/>\n" +
                "    <semantic:itemDefinition name=\"tYearsofExperience\" label=\"tYearsofExperience\" isCollection=\"false\">\n" +
                "        <semantic:typeRef>number</semantic:typeRef>\n" +
                "        <semantic:allowedValues triso:constraintsType=\"expression\">\n" +
                "            <semantic:text>&gt;=0</semantic:text>\n" +
                "        </semantic:allowedValues>\n" +
                "    </semantic:itemDefinition>\n" +
                "    <semantic:decisionService id=\"_9e55adb5-b7d3-4400-8640-a929c8a80f21_DS\" name=\"Whole Model Decision Service\" triso:dynamicDecisionService=\"true\" triso:wholeModelService=\"true\">\n" +
                "        <semantic:variable name=\"Whole Model Decision Service\" id=\"_9e55adb5-b7d3-4400-8640-a929c8a80f21_DS_VAR\" typeRef=\"Any\"/>\n" +
                "        <semantic:outputDecision href=\"#_c7c7cc35-c88c-40e1-a5b4-a5c330f9deef\"/>\n" +
                "        <semantic:encapsulatedDecision href=\"#_9c4cf6bb-570c-45cb-a869-b1971cf5bec3\"/>\n" +
                "        <semantic:encapsulatedDecision href=\"#_9d868da9-a81f-4aeb-968b-b753c1fd7a78\"/>\n" +
                "        <semantic:inputData href=\"#_9543f434-ec4f-4fe8-a934-a6df9eb00a2c\"/>\n" +
                "        <semantic:inputData href=\"#_d980d6b2-5400-411c-b31f-8c91839018fb\"/>\n" +
                "    </semantic:decisionService>\n" +
                "    <semantic:decisionService id=\"_6144a37d-e270-4eb9-870a-972fb28c110b_DS\" name=\"Diagram Page 1\" triso:dynamicDecisionService=\"true\">\n" +
                "        <semantic:variable name=\"Diagram Page 1\" id=\"_6144a37d-e270-4eb9-870a-972fb28c110b_DS_VAR\" typeRef=\"Any\"/>\n" +
                "        <semantic:outputDecision href=\"#_c7c7cc35-c88c-40e1-a5b4-a5c330f9deef\"/>\n" +
                "        <semantic:encapsulatedDecision href=\"#_9c4cf6bb-570c-45cb-a869-b1971cf5bec3\"/>\n" +
                "        <semantic:encapsulatedDecision href=\"#_9d868da9-a81f-4aeb-968b-b753c1fd7a78\"/>\n" +
                "        <semantic:inputData href=\"#_9543f434-ec4f-4fe8-a934-a6df9eb00a2c\"/>\n" +
                "        <semantic:inputData href=\"#_d980d6b2-5400-411c-b31f-8c91839018fb\"/>\n" +
                "    </semantic:decisionService>\n" +
                "    <semantic:inputData id=\"_9543f434-ec4f-4fe8-a934-a6df9eb00a2c\" name=\"Years of Experience\">\n" +
                "        <semantic:variable name=\"Years of Experience\" id=\"_025b9612-f65e-4c27-8fcd-c88812183b4b\" typeRef=\"number\"/>\n" +
                "    </semantic:inputData>\n" +
                "    <semantic:inputData id=\"_d980d6b2-5400-411c-b31f-8c91839018fb\" name=\"Age\">\n" +
                "        <semantic:variable name=\"Age\" id=\"_d8176732-f945-4f60-997b-11b2d36112d2\" typeRef=\"number\"/>\n" +
                "    </semantic:inputData>\n" +
                "    <semantic:decision id=\"_9c4cf6bb-570c-45cb-a869-b1971cf5bec3\" name=\"Five Extra days\">\n" +
                "        <semantic:variable name=\"Five Extra days\" id=\"_5fbd90db-6a95-4a6d-99b5-df9e4b00cc41\" typeRef=\"number\"/>\n" +
                "        <semantic:informationRequirement id=\"_29641349-b8c8-4f42-8e46-d61c15b884fd\">\n" +
                "            <semantic:requiredInput href=\"#_9543f434-ec4f-4fe8-a934-a6df9eb00a2c\"/>\n" +
                "        </semantic:informationRequirement>\n" +
                "        <semantic:informationRequirement id=\"_9a07defc-a258-4b21-8e03-3d2c319a368b\">\n" +
                "            <semantic:requiredInput href=\"#_d980d6b2-5400-411c-b31f-8c91839018fb\"/>\n" +
                "        </semantic:informationRequirement>\n" +
                "        <semantic:decisionTable id=\"_16b84527-9d92-4ebb-906c-45587514392b\" hitPolicy=\"ANY\" outputLabel=\"Five Extra days\" typeRef=\"number\" triso:expressionId=\"_04cc14ee-581e-4a50-bca8-0ae3e2ef5c02\">\n" +
                "            <semantic:input id=\"_1ea198ae-0216-450f-bb15-bded6a6279f8\" label=\"Years of Experience\">\n" +
                "                <semantic:inputExpression typeRef=\"number\">\n" +
                "                    <semantic:text>Years of Experience</semantic:text>\n" +
                "                </semantic:inputExpression>\n" +
                "                <semantic:inputValues triso:constraintsType=\"simple\">\n" +
                "                    <semantic:text>&gt;=0</semantic:text>\n" +
                "                </semantic:inputValues>\n" +
                "            </semantic:input>\n" +
                "            <semantic:input id=\"_d1e9c534-086a-4680-ad72-e36c789ec781\" label=\"Age\">\n" +
                "                <semantic:inputExpression typeRef=\"number\">\n" +
                "                    <semantic:text>Age</semantic:text>\n" +
                "                </semantic:inputExpression>\n" +
                "                <semantic:inputValues triso:constraintsType=\"simple\">\n" +
                "                    <semantic:text>&gt;=14</semantic:text>\n" +
                "                </semantic:inputValues>\n" +
                "            </semantic:input>\n" +
                "            <semantic:output id=\"_21a693d3-6fc4-436c-9bd9-ea497549bfff\" triso:allowNull=\"true\"/>\n" +
                "            <semantic:annotation name=\"Description\"/>\n" +
                "            <semantic:rule id=\"_56ae5ace-e077-40a2-a5f9-56583af6aa7d\">\n" +
                "                <semantic:inputEntry id=\"_51fe13b1-d9fc-447a-a5a5-5d661ee345b7\">\n" +
                "                    <semantic:text>-</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_8ef060b1-18a7-4dea-86c9-bf820ffbc41e\">\n" +
                "                    <semantic:text>&lt;18</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_e02f87cd-8fc8-4ee4-a2ed-a114356faf1e\">\n" +
                "                    <semantic:text>5</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "            <semantic:rule id=\"_d1639f78-8988-4fb5-b722-d820b8e809d9\">\n" +
                "                <semantic:inputEntry id=\"_d8f31d20-16ec-4c1f-ac9b-201d4f4f4fd8\">\n" +
                "                    <semantic:text>-</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_e7813d67-80e4-4132-9f53-112b48541740\">\n" +
                "                    <semantic:text>&gt;50</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_8efbbfe3-e591-4a7a-bb20-4ad5321abe2a\">\n" +
                "                    <semantic:text>5</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "            <semantic:rule id=\"_81c22c22-f4a3-46f8-a3ec-66a5d58bca00\">\n" +
                "                <semantic:inputEntry id=\"_7b89d10b-0cab-49ab-a735-822ffb04338e\">\n" +
                "                    <semantic:text>&gt;=10</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_c5586ae6-a018-427b-baae-8642dc8bc2a3\">\n" +
                "                    <semantic:text>-</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_664e447f-9292-4f80-8a3e-530265d1919f\">\n" +
                "                    <semantic:text>5</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "            <semantic:rule id=\"_e20ce654-69f7-4a1a-aedd-0e69b3cd2c46\">\n" +
                "                <semantic:inputEntry id=\"_9c60fb20-f94e-40e5-9dfb-1a2b632aba92\">\n" +
                "                    <semantic:text>&lt;10</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_83f772ee-a218-46ab-aa3d-9d8460c6956d\">\n" +
                "                    <semantic:text>[18..50)</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_b171aaca-c690-4ec5-a9cc-3e330f48be56\">\n" +
                "                    <semantic:text>0</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "        </semantic:decisionTable>\n" +
                "    </semantic:decision>\n" +
                "    <semantic:decision id=\"_9d868da9-a81f-4aeb-968b-b753c1fd7a78\" name=\"Three Extra days\">\n" +
                "        <semantic:variable name=\"Three Extra days\" id=\"_9631aa8c-26f4-46e6-8666-027d32887915\" typeRef=\"number\"/>\n" +
                "        <semantic:informationRequirement id=\"_00efca17-eca5-4889-aebb-41d776b45b98\">\n" +
                "            <semantic:requiredInput href=\"#_9543f434-ec4f-4fe8-a934-a6df9eb00a2c\"/>\n" +
                "        </semantic:informationRequirement>\n" +
                "        <semantic:informationRequirement id=\"_7f91282a-eb81-459c-90b2-6babaf696a38\">\n" +
                "            <semantic:requiredInput href=\"#_d980d6b2-5400-411c-b31f-8c91839018fb\"/>\n" +
                "        </semantic:informationRequirement>\n" +
                "        <semantic:decisionTable id=\"_38d7176e-3c4b-43d0-a3bb-43d6e9cc88e3\" hitPolicy=\"FIRST\" outputLabel=\"Three Extra days\" typeRef=\"number\" triso:expressionId=\"_591cb33d-a978-448c-98a7-f17f01f48495\">\n" +
                "            <semantic:input id=\"_00cfe159-b300-41c2-b7f2-013b6d913da5\" label=\"Years of Experience\">\n" +
                "                <semantic:inputExpression typeRef=\"number\">\n" +
                "                    <semantic:text>Years of Experience</semantic:text>\n" +
                "                </semantic:inputExpression>\n" +
                "                <semantic:inputValues triso:constraintsType=\"simple\">\n" +
                "                    <semantic:text>&gt;=0</semantic:text>\n" +
                "                </semantic:inputValues>\n" +
                "            </semantic:input>\n" +
                "            <semantic:input id=\"_98d3dc50-c76c-4a22-9574-755bb51aba85\" label=\"Age\">\n" +
                "                <semantic:inputExpression typeRef=\"number\">\n" +
                "                    <semantic:text>Age</semantic:text>\n" +
                "                </semantic:inputExpression>\n" +
                "                <semantic:inputValues triso:constraintsType=\"simple\">\n" +
                "                    <semantic:text>&gt;=14</semantic:text>\n" +
                "                </semantic:inputValues>\n" +
                "            </semantic:input>\n" +
                "            <semantic:output id=\"_019dd094-668e-4a11-a1f5-82575c533cd1\" triso:allowNull=\"true\"/>\n" +
                "            <semantic:annotation name=\"Description\"/>\n" +
                "            <semantic:rule id=\"_0b03e9d5-b96a-4d57-a642-a6cb875e0629\">\n" +
                "                <semantic:inputEntry id=\"_ec9ae837-d34b-47d8-944d-90df769155af\">\n" +
                "                    <semantic:text>[5..10)</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_4c51d83f-6472-47a3-b633-7c35a2bd7c45\">\n" +
                "                    <semantic:text>-</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_7ecbaa95-4b94-4e55-8dfa-6358b7b3824e\">\n" +
                "                    <semantic:text>3</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "            <semantic:rule id=\"_f862a4f9-580c-429e-9525-e8640dfaca85\">\n" +
                "                <semantic:inputEntry id=\"_4081a84d-b7f1-4f05-a1ed-de817994a8cc\">\n" +
                "                    <semantic:text>-</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_1f50d2bf-61ec-46d7-910f-72f947b088d9\">\n" +
                "                    <semantic:text>[18..50)</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_311b213a-bb34-4e1b-8480-2c5326786245\">\n" +
                "                    <semantic:text>0</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "            <semantic:rule id=\"_d80a545b-2592-4ec0-aecb-29951ad716a4\">\n" +
                "                <semantic:inputEntry id=\"_1a767ead-d102-4ffa-b999-062c0ddf9666\">\n" +
                "                    <semantic:text>-</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_5edace24-6b99-4dfc-8ef7-8d6456fb1115\">\n" +
                "                    <semantic:text>-</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_26bb5c1e-3d06-4f65-af92-411bb03a9920\">\n" +
                "                    <semantic:text>0</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "        </semantic:decisionTable>\n" +
                "    </semantic:decision>\n" +
                "    <semantic:decision id=\"_c7c7cc35-c88c-40e1-a5b4-a5c330f9deef\" name=\"Total number of vacations\">\n" +
                "        <semantic:variable name=\"Total number of vacations\" id=\"_414c6d74-055d-4559-9252-32fccd011add\" typeRef=\"Any\"/>\n" +
                "        <semantic:informationRequirement id=\"_7dfe0b74-b5ae-429d-8d05-a81d39f99e50\">\n" +
                "            <semantic:requiredDecision href=\"#_9c4cf6bb-570c-45cb-a869-b1971cf5bec3\"/>\n" +
                "        </semantic:informationRequirement>\n" +
                "        <semantic:informationRequirement id=\"_3329c05e-0e98-4b03-86c7-e2ac44e54e5a\">\n" +
                "            <semantic:requiredDecision href=\"#_9d868da9-a81f-4aeb-968b-b753c1fd7a78\"/>\n" +
                "        </semantic:informationRequirement>\n" +
                "        <semantic:decisionTable id=\"_b798599f-3cb9-45ab-a7bc-89fcaaf209a4\" hitPolicy=\"UNIQUE\" outputLabel=\"Total number of vacations\" typeRef=\"Any\" triso:expressionId=\"_102edfe8-fb80-4367-83ab-5ef4bea54003\">\n" +
                "            <semantic:input id=\"_a1ef5018-1d77-48f9-bd30-4a666660eda2\" label=\"Five Extra days\">\n" +
                "                <semantic:inputExpression typeRef=\"number\">\n" +
                "                    <semantic:text>Five Extra days</semantic:text>\n" +
                "                </semantic:inputExpression>\n" +
                "            </semantic:input>\n" +
                "            <semantic:input id=\"_70e13a27-ddcc-4cb2-979b-6000da867079\" label=\"Three Extra days\">\n" +
                "                <semantic:inputExpression typeRef=\"number\">\n" +
                "                    <semantic:text>Three Extra days</semantic:text>\n" +
                "                </semantic:inputExpression>\n" +
                "            </semantic:input>\n" +
                "            <semantic:output id=\"_3dc568a1-68b7-48e4-a96f-0930675cf6c1\" triso:allowNull=\"true\"/>\n" +
                "            <semantic:annotation name=\"Description\"/>\n" +
                "            <semantic:rule id=\"_44dba29e-1617-4645-8b7b-6f53b0b0c978\">\n" +
                "                <semantic:inputEntry id=\"_471dd39a-e857-46f5-a6ab-2a95c7ef198d\">\n" +
                "                    <semantic:text>&gt;0</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_dd3e1580-7fbb-41fe-881c-4b4d2f73378a\">\n" +
                "                    <semantic:text>&gt;0</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_eb66b0ef-42a2-471c-bce5-7e93b74f31c0\">\n" +
                "                    <semantic:text>10+Five Extra days+Three Extra days</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "            <semantic:rule id=\"_70a91935-1b17-43f4-b7c4-caffbc47f635\">\n" +
                "                <semantic:inputEntry id=\"_66c643e0-de1c-4b9b-9bcc-a912295e9ce5\">\n" +
                "                    <semantic:text>&gt;0</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_30f8fa69-90e6-400e-a623-c221133d172b\">\n" +
                "                    <semantic:text>0</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_70faab4b-e701-4183-995c-5ece0a5a33f0\">\n" +
                "                    <semantic:text>10+Five Extra days</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "            <semantic:rule id=\"_62382f05-0f83-4312-b0f1-26270aac63c5\">\n" +
                "                <semantic:inputEntry id=\"_c862ef6a-3bca-400e-a73a-e5c87897bf82\">\n" +
                "                    <semantic:text>0</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_16dbbbbd-47d5-4bf8-bbc6-0f1313ed570d\">\n" +
                "                    <semantic:text>&gt;0</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_e9e86db5-4943-4943-ae68-9d324ecffff5\">\n" +
                "                    <semantic:text>10+Three Extra days</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "            <semantic:rule id=\"_0140ae23-2f48-4e6f-805a-a30fdc60c43c\">\n" +
                "                <semantic:inputEntry id=\"_a4378ad6-7771-4277-9a89-c441437f0028\">\n" +
                "                    <semantic:text>0</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:inputEntry id=\"_0620c9d1-0dad-4ba8-9bc7-81e26d704ad6\">\n" +
                "                    <semantic:text>0</semantic:text>\n" +
                "                </semantic:inputEntry>\n" +
                "                <semantic:outputEntry id=\"_a1d2bb65-1044-4a3e-b6e2-f2c99c7caeb1\">\n" +
                "                    <semantic:text>10</semantic:text>\n" +
                "                </semantic:outputEntry>\n" +
                "                <semantic:annotationEntry>\n" +
                "                    <semantic:text/>\n" +
                "                </semantic:annotationEntry>\n" +
                "            </semantic:rule>\n" +
                "        </semantic:decisionTable>\n" +
                "    </semantic:decision>\n" +
                "    <dmndi:DMNDI>\n" +
                "        <dmndi:DMNDiagram id=\"_6144a37d-e270-4eb9-870a-972fb28c110b\" triso:modelElementRef=\"_c500e60d-64c8-4340-a4f8-463faa838a63\" name=\"Page 1\">\n" +
                "            <di:extension/>\n" +
                "            <dmndi:Size height=\"1050\" width=\"1485\"/>\n" +
                "            <dmndi:DMNShape id=\"_f605f961-e090-4759-9be0-67d898945762\" dmnElementRef=\"_9543f434-ec4f-4fe8-a934-a6df9eb00a2c\">\n" +
                "                <dc:Bounds x=\"309.7588291168213\" y=\"670.9999961853027\" width=\"135.48234176635742\" height=\"60.00000762939453\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNShape id=\"_e4c8c357-4d94-4c7f-b354-08430264610d\" dmnElementRef=\"_d980d6b2-5400-411c-b31f-8c91839018fb\">\n" +
                "                <dc:Bounds x=\"683.7588291168213\" y=\"670.9999961853027\" width=\"135.48234176635742\" height=\"60.00000762939453\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNShape id=\"_abc3fd67-df40-483e-acca-d62b59f66e39\" dmnElementRef=\"_9c4cf6bb-570c-45cb-a869-b1971cf5bec3\">\n" +
                "                <dc:Bounds x=\"379\" y=\"490\" width=\"153\" height=\"60\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNShape id=\"_cf394e02-d4f4-4dce-b5b7-3e1f8e6c2f1f\" dmnElementRef=\"_9d868da9-a81f-4aeb-968b-b753c1fd7a78\">\n" +
                "                <dc:Bounds x=\"569\" y=\"490\" width=\"153\" height=\"60\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNShape id=\"_b9bbb83b-9ef6-49db-85e1-55e60f5f92b8\" dmnElementRef=\"_c7c7cc35-c88c-40e1-a5b4-a5c330f9deef\">\n" +
                "                <dc:Bounds x=\"471\" y=\"336\" width=\"153\" height=\"60\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\" trisodmn:defaultBounds=\"true\"/>\n" +
                "            </dmndi:DMNShape>\n" +
                "            <dmndi:DMNEdge id=\"_6034b561-c4d7-430e-91e7-ae16ddca3a58\" dmnElementRef=\"_29641349-b8c8-4f42-8e46-d61c15b884fd\">\n" +
                "                <di:waypoint x=\"387.4968013763428\" y=\"670.9999961853027\"/>\n" +
                "                <di:waypoint x=\"445.5\" y=\"550\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "            <dmndi:DMNEdge id=\"_533fe184-34d1-4be6-961a-828101b72c35\" dmnElementRef=\"_00efca17-eca5-4889-aebb-41d776b45b98\">\n" +
                "                <di:waypoint x=\"417.4968013763428\" y=\"670.9999961853027\"/>\n" +
                "                <di:waypoint x=\"605.5\" y=\"550\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "            <dmndi:DMNEdge id=\"_547037d8-cd44-41e8-afbe-a0591b09a51b\" dmnElementRef=\"_7f91282a-eb81-459c-90b2-6babaf696a38\">\n" +
                "                <di:waypoint x=\"751.4968013763428\" y=\"670.9999961853027\"/>\n" +
                "                <di:waypoint x=\"645.5\" y=\"550\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "            <dmndi:DMNEdge id=\"_7c811fa0-ebbc-4c73-9efa-e984b1f55a48\" dmnElementRef=\"_9a07defc-a258-4b21-8e03-3d2c319a368b\">\n" +
                "                <di:waypoint x=\"683.9968013763428\" y=\"700.9999961853027\"/>\n" +
                "                <di:waypoint x=\"505.5\" y=\"550\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "            <dmndi:DMNEdge id=\"_9f4cb474-5ebd-4ed5-a49e-71cfd4b46799\" dmnElementRef=\"_7dfe0b74-b5ae-429d-8d05-a81d39f99e50\">\n" +
                "                <di:waypoint x=\"465.5\" y=\"490\"/>\n" +
                "                <di:waypoint x=\"517.5\" y=\"396\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "            <dmndi:DMNEdge id=\"_0c6b4ca6-f8a8-4e85-810a-6760dab030a2\" dmnElementRef=\"_3329c05e-0e98-4b03-86c7-e2ac44e54e5a\">\n" +
                "                <di:waypoint x=\"645.5\" y=\"490\"/>\n" +
                "                <di:waypoint x=\"547.5\" y=\"396\"/>\n" +
                "                <dmndi:DMNLabel sharedStyle=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\"/>\n" +
                "            </dmndi:DMNEdge>\n" +
                "        </dmndi:DMNDiagram>\n" +
                "        <dmndi:DMNStyle id=\"LS_9e55adb5-b7d3-4400-8640-a929c8a80f21_0\" fontFamily=\"arial,helvetica,sans-serif\" fontSize=\"11\" fontBold=\"false\" fontItalic=\"false\" fontUnderline=\"false\" fontStrikeThrough=\"false\"/>\n" +
                "    </dmndi:DMNDI>\n" +
                "</semantic:definitions>";
            string rulesParameters = "{" +
                          "    \"groupId\": \"Beneficiary\"," +
                          "    \"artifactId\": \"529\"," +
                          "    \"version\": \"1.0.0\"," +
                          "    \"type\": \"dmn\"," +
                          "}";
            string rulesParameters1 = "{" +
                          "    \"groupId\": \"age\"," +
                          "    \"artifactId\": \"529\"," +
                          "    \"version\": \"1.0.0\"," +
                          "    \"type\": \"dmn\"," +
                          "}";
            string rulesParameters2 = "{" +
                          "    \"groupId\": \"allocationpercentage\"," +
                          "    \"artifactId\": \"529\"," +
                          "    \"version\": \"1.0.0\"," +
                          "    \"type\": \"dmn\"," +
                          "}";
            string fact1 = " [{ \"name\":\"Height\"," +
                                "   \"value\":\"58\"," +
                                "   \"type\":\"integer\"" +
                                "}" +
                                "," +
                                "{" +
                                "   \"name\":\"Weight\"," +
                                "   \"value\":\"160\"," +
                                "   \"type\":\"integer\"" +
                                "}]";
            string fact2 = " [{ \"name\":\"Age\"," +
                                "   \"value\":\"30\"," +
                                "   \"type\":\"integer\"" +
                                "}" +
                                "," +
                                "{" +
                                "   \"name\":\"Years of Experience\"," +
                                "   \"value\":\"10\"," +
                                "   \"type\":\"integer\"" +
                                "}]";
            string facts = " [{ \"name\":\"Season\"," +
                                  "   \"value\":\"Summer\"," +
                                  "   \"type\":\"string\"" +
                                  "}" +
                                  "," +
                                  "{" +
                                  "   \"name\":\"How many guests\"," +
                                  "   \"value\":\"10\"," +
                                  "   \"type\":\"integer\"" +
                                  "}]";

            DecisionService ds = new DecisionService();


            string result= ds.executeRules(dmnstring,rulesParameters,facts );      
            string result1 = ds.executeRules(dmnstring1, rulesParameters1 , fact1);
            string result2 = ds.executeRules(dmnstring2, rulesParameters2, fact2);
            
            Console.Clear();
            Console.WriteLine("\t JSON Results recieved at .Net core app  from JAVA drools Bussiness Rule Execution Engine\n\n ");

            Console.WriteLine("\t 1. Dish decision Table result :"+result+"\n");
            Console.WriteLine("\t 2. BMI decision Table result :" + result1 + "\n");
            Console.WriteLine("\t 3. Holidays decision Table result :" + result2 + "\n");
            Console.ReadLine();

            
            
        }
    }
}
