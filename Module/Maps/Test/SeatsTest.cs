﻿
using GTANetworkAPI;
using GVRP.Module.Players.Seat;
using GVRP.Module.Spawners;

namespace GVRP.Module.Maps.Test
{
    public static class SeatsTest
    {
        public static void Add(int model, Vector3 position, Vector3 rotation, uint dimension)
        {
            if (PlayerSeatModule.Instance[model] == null)
            {
                ObjectSpawn.Create(model, position, rotation, dimension);
            }
        }

        public static void Load(uint dimension)
        {
            Add(-1867871609, new Vector3(125.9254f, -420.6841f, 40.06044f),
                new Vector3(0f, 0f, -21.99994f), dimension);
            Add(-76230599, new Vector3(124.5614f, -422.1974f, 40.06044f),
                new Vector3(0f, 0f, -15.99999f), dimension);
            Add(307625467, new Vector3(126.3395f, -419.3841f, 40.06044f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(2037887057, new Vector3(126.6665f, -418.2688f, 40.06044f),
                new Vector3(0f, 0f, -21.99996f), dimension);
            Add(-1215681419, new Vector3(127.1367f, -417.1202f, 40.06044f),
                new Vector3(0f, 0f, -23.99997f), dimension);
            Add(-763859088, new Vector3(127.5446f, -416.0687f, 40.06044f),
                new Vector3(0f, 0f, -24.99996f), dimension);
            Add(-1631057904, new Vector3(127.9257f, -414.6505f, 40.06044f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(-99500382, new Vector3(128.4538f, -413.5015f, 40.06044f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(1544445682, new Vector3(128.9966f, -412.1619f, 40.06044f),
                new Vector3(0f, 0f, -22.99996f), dimension);
            Add(267626795, new Vector3(129.589f, -410.9574f, 40.06044f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(-1461986002, new Vector3(130.1339f, -409.8579f, 40.06044f),
                new Vector3(0f, 0f, -22.99996f), dimension);
            Add(1805980844, new Vector3(130.837f, -408.7463f, 40.06044f),
                new Vector3(0f, 0f, -21.99996f), dimension);
            Add(-628719744, new Vector3(131.3813f, -407.5994f, 40.06044f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(-1062810675, new Vector3(131.8431f, -406.5462f, 40.06044f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(-1317098115, new Vector3(132.036f, -405.3151f, 40.06044f),
                new Vector3(0f, 0f, -24.99997f), dimension);
            Add(-71417349, new Vector3(131.8154f, -403.8432f, 40.06044f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(-403891623, new Vector3(133.03f, -403.2428f, 40.06718f),
                new Vector3(0f, 0f, -27.99995f), dimension);
            Add(437354449, new Vector3(133.9001f, -402.182f, 40.08038f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(1290593659, new Vector3(134.2882f, -401.3851f, 40.1024f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(-70627249, new Vector3(134.9235f, -400.2165f, 40.18384f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(1916676832, new Vector3(135.5412f, -398.8687f, 40.28579f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(39200959, new Vector3(132.0402f, -397.2574f, 40.47574f),
                new Vector3(0f, 0f, -25.99995f), dimension);
            Add(-373650829, new Vector3(131.1318f, -399.392f, 40.28093f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(-67162372, new Vector3(130.2934f, -401.0616f, 40.16372f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(-1063831511, new Vector3(129.4184f, -402.8707f, 40.10218f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(1285701428, new Vector3(128.5253f, -404.6076f, 40.06044f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(1623746432, new Vector3(127.8385f, -406.271f, 40.06044f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(167066071, new Vector3(126.8656f, -407.8637f, 40.06044f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(28672923, new Vector3(127.1835f, -409.839f, 40.06044f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(-293380809, new Vector3(126.0687f, -409.3989f, 40.06044f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(-591349326, new Vector3(125.9588f, -411.0372f, 40.06044f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(1355718178, new Vector3(125.0534f, -408.8996f, 40.05119f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(-128924068, new Vector3(124.868f, -412.3179f, 40.47f),
                new Vector3(0f, 0f, -110.9996f), dimension);
            Add(1019962318, new Vector3(124.5193f, -410.2663f, 40.25f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-1175488618, new Vector3(124.3627f, -413.7889f, 40.0605f),
                new Vector3(0f, 0f, -22.99996f), dimension);
            Add(-606800174, new Vector3(125.0941f, -415.5628f, 40.06044f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(6963200, new Vector3(124.3856f, -415.2447f, 40.06051f),
                new Vector3(0f, 0f, -20.99995f), dimension);
            Add(987641063, new Vector3(123.5085f, -415.0704f, 40.061f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-1333092650, new Vector3(122.7886f, -414.5729f, 40.06143f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(1738496974, new Vector3(124.6632f, -416.7414f, 40.06044f),
                new Vector3(0f, 0f, -20.99997f), dimension);
            Add(2019753297, new Vector3(123.4517f, -415.8339f, 40.06051f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(1722309084, new Vector3(122.2409f, -415.4409f, 40.06093f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(-234688365, new Vector3(124.4095f, -418.0423f, 40.06044f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-868509571, new Vector3(123.0999f, -417.4533f, 40.06044f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(-1168018231, new Vector3(121.7581f, -417.2431f, 40.06044f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(-1482600631, new Vector3(123.9715f, -419.2488f, 40.06044f),
                new Vector3(0f, 0f, -17.99998f), dimension);
            Add(338307413, new Vector3(122.3912f, -419.1248f, 40.06044f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(49088219, new Vector3(121.1804f, -418.2293f, 40.06044f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(-1210781524, new Vector3(120.0994f, -420.1302f, 40.06044f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(-1785811936, new Vector3(121.8673f, -420.0372f, 40.06044f),
                new Vector3(0f, 0f, -9.999996f), dimension);
            Add(-677582063, new Vector3(123.3466f, -420.8824f, 40.06044f),
                new Vector3(0f, 0f, -3.000421f), dimension);
            Add(-67059393, new Vector3(129.616f, -396.6761f, 40.4034f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(1488091809, new Vector3(128.8076f, -398.263f, 40.33296f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(-393569709, new Vector3(127.9652f, -399.859f, 40.26325f),
                new Vector3(0f, 0f, -28.99995f), dimension);
            Add(-999534061, new Vector3(127.0068f, -401.6283f, 40.20427f),
                new Vector3(0f, 0f, -28.99997f), dimension);
            Add(-689899780, new Vector3(126.0683f, -403.4078f, 40.16665f),
                new Vector3(0f, 0f, -28.99997f), dimension);
            Add(233628951, new Vector3(125.225f, -405.1075f, 40.12375f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(-1608185467, new Vector3(124.3374f, -406.9671f, 40.07128f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(1740052654, new Vector3(123.5704f, -408.7631f, 40.02947f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(298623376, new Vector3(122.8492f, -410.474f, 40.04035f),
                new Vector3(0f, 0f, -24.99996f), dimension);
            Add(954232759, new Vector3(122.1567f, -412.2388f, 40.12729f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(654887944, new Vector3(121.1224f, -414.1302f, 40.10257f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(1000293277, new Vector3(120.3548f, -415.8375f, 40.07277f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(1482870357, new Vector3(120.2886f, -417.4514f, 40.06044f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(-2033210578, new Vector3(119.4712f, -417.3271f, 40.06044f),
                new Vector3(0f, 0f, -12.99999f), dimension);
            Add(2079364464, new Vector3(119.8226f, -418.7125f, 40.06044f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-1440452137, new Vector3(118.912f, -418.4492f, 40.06044f),
                new Vector3(0f, 0f, -15.99999f), dimension);
            Add(696447118, new Vector3(118.633f, -419.8839f, 40.06044f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(533585188, new Vector3(117.7185f, -419.5147f, 40.06044f),
                new Vector3(0f, 0f, -14.99999f), dimension);
            Add(1667818593, new Vector3(118.0245f, -418.2396f, 40.06044f),
                new Vector3(0f, 0f, -11f), dimension);
            Add(46768928, new Vector3(118.369f, -417.0016f, 40.06044f),
                new Vector3(0f, 0f, -15.99999f), dimension);
            Add(1699373995, new Vector3(118.7767f, -415.2122f, 40.11876f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(1361820526, new Vector3(119.5273f, -413.5265f, 40.17279f),
                new Vector3(0f, 0f, -16.99999f), dimension);
            Add(1038390496, new Vector3(120.5631f, -411.6439f, 40.22161f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(1892580027, new Vector3(121.3272f, -409.8152f, 40.11513f),
                new Vector3(0f, 0f, -16.99999f), dimension);
            Add(-987977838, new Vector3(121.909f, -408.0392f, 40.10695f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-1198343923, new Vector3(122.546f, -406.3315f, 40.15949f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(449297510, new Vector3(123.8244f, -404.494f, 40.6f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(719404538, new Vector3(124.7316f, -402.7773f, 40.23711f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(525667351, new Vector3(125.6943f, -400.856f, 40.264f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(764848282, new Vector3(126.5742f, -399.1066f, 40.2674f),
                new Vector3(0f, 0f, -26.99996f), dimension);
            Add(725259233, new Vector3(127.501f, -397.6582f, 40.32202f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(1064877149, new Vector3(128.296f, -396.0051f, 40.34627f),
                new Vector3(0f, 0f, -27.99997f), dimension);
            Add(2064599526, new Vector3(127.3901f, -395.5131f, 40.30993f),
                new Vector3(0f, 0f, -31.99994f), dimension);
            Add(-1941377959, new Vector3(126.5504f, -397.0992f, 40.30227f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(1545434534, new Vector3(125.5753f, -398.6028f, 40.264f),
                new Vector3(0f, 0f, -25.99997f), dimension);
            Add(826023884, new Vector3(124.7553f, -400.3975f, 40.264f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(1056357185, new Vector3(123.6339f, -402.2317f, 40.264f),
                new Vector3(0f, 0f, -29.99997f), dimension);
            Add(1281480215, new Vector3(122.8926f, -403.998f, 40.76f),
                new Vector3(0f, 0f, -24.99995f), dimension);
            Add(1612971419, new Vector3(121.6593f, -405.8777f, 40.19553f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(1691387372, new Vector3(120.4951f, -407.4747f, 40.15828f),
                new Vector3(0f, 0f, -23.99996f), dimension);
            Add(1028260687, new Vector3(120.0527f, -409.308f, 40.69f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(-2105381678, new Vector3(118.9748f, -411.2753f, 40.25681f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(-1118419705, new Vector3(118.4668f, -413.0618f, 40.19666f),
                new Vector3(0f, 0f, -19.99997f), dimension);
            Add(900821510, new Vector3(117.5827f, -414.7344f, 40.69f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(181607490, new Vector3(117.1525f, -416.6868f, 40.7f),
                new Vector3(0f, 0f, -15.99999f), dimension);
            Add(558578166, new Vector3(117.0103f, -418.0746f, 40.69f),
                new Vector3(0f, 0f, -11.99999f), dimension);
            Add(536071214, new Vector3(116.6589f, -419.362f, 40.06044f),
                new Vector3(0f, 0f, -6.999997f), dimension);
            Add(96868307, new Vector3(115.5189f, -419.2142f, 40.06044f),
                new Vector3(0f, 0f, -3.999999f), dimension);
            Add(1268458364, new Vector3(115.8472f, -417.8375f, 40.06044f),
                new Vector3(0f, 0f, -3.999999f), dimension);
            Add(1480618483, new Vector3(116.1367f, -416.394f, 40.09584f),
                new Vector3(0f, 0f, -11.99999f), dimension);
            Add(475561894, new Vector3(116.5605f, -414.276f, 40.17583f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(1037469683, new Vector3(117.3282f, -412.624f, 40.24397f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(1103738692, new Vector3(118.0957f, -410.69f, 40.71f),
                new Vector3(0f, 0f, -23.99997f), dimension);
            Add(1544350879, new Vector3(118.9951f, -408.8583f, 40.7f),
                new Vector3(0f, 0f, -24.99996f), dimension);
            Add(854385596, new Vector3(119.4402f, -406.9704f, 40.7f),
                new Vector3(0f, 0f, -24.99997f), dimension);
            Add(291348133, new Vector3(120.5281f, -405.3839f, 40.7f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(1071807406, new Vector3(121.8545f, -403.5826f, 40.7f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(-1108904010, new Vector3(122.7457f, -401.7527f, 40.7f),
                new Vector3(0f, 0f, -27.99997f), dimension);
            Add(-1633198649, new Vector3(123.475f, -399.9293f, 40.264f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(1262298127, new Vector3(124.5842f, -398.2377f, 40.7f),
                new Vector3(0f, 0f, -27.99997f), dimension);
            Add(1737474779, new Vector3(125.425f, -396.7337f, 40.27165f),
                new Vector3(0f, 0f, -31.99994f), dimension);
            Add(-1931340691, new Vector3(126.4543f, -394.957f, 40.7f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(-2065455377, new Vector3(114.3082f, -418.9029f, 40.06044f),
                new Vector3(0f, 0f, -3.999999f), dimension);
            Add(-1173315865, new Vector3(114.5319f, -417.4883f, 40.06868f),
                new Vector3(0f, 0f, -4.999998f), dimension);
            Add(-721037220, new Vector3(114.8627f, -416.0378f, 40.12444f),
                new Vector3(0f, 0f, -11.99998f), dimension);
            Add(736919402, new Vector3(115.3254f, -413.9202f, 40.22438f),
                new Vector3(0f, 0f, -14.99999f), dimension);
            Add(867556671, new Vector3(115.9282f, -412.0269f, 40.26056f),
                new Vector3(0f, 0f, -16.99999f), dimension);
            Add(589738836, new Vector3(116.9874f, -410.1431f, 40.7f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(-501934650, new Vector3(117.9892f, -408.4416f, 40.2506f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(-109356459, new Vector3(118.2783f, -406.5248f, 40.21244f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-784954167, new Vector3(119.6614f, -404.9833f, 40.7f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(-1291993936, new Vector3(120.5823f, -402.8667f, 40.25286f),
                new Vector3(0f, 0f, -24.99996f), dimension);
            Add(98421364, new Vector3(121.3175f, -400.9619f, 40.26333f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(-936477296, new Vector3(122.2775f, -399.3871f, 40.7f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(-1254619912, new Vector3(123.3161f, -397.7019f, 40.264f),
                new Vector3(0f, 0f, -25.99994f), dimension);
            Add(-802034762, new Vector3(124.0864f, -395.8811f, 40.25578f),
                new Vector3(0f, 0f, -25.99996f), dimension);
            Add(1696358503, new Vector3(125.0933f, -394.4981f, 40.78f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(393092335, new Vector3(123.6586f, -393.6263f, 40.23891f),
                new Vector3(0f, 0f, -26.99992f), dimension);
            Add(-1202648266, new Vector3(122.8721f, -395.1339f, 40.7f),
                new Vector3(0f, 0f, -28.99997f), dimension);
            Add(-183041205, new Vector3(122.1896f, -396.6537f, 40.264f),
                new Vector3(0f, 0f, -25.99995f), dimension);
            Add(113333890, new Vector3(121.0044f, -398.5778f, 40.264f),
                new Vector3(0f, 0f, -25.99996f), dimension);
            Add(-865883608, new Vector3(120.097f, -400.3816f, 40.26254f),
                new Vector3(0f, 0f, -11.99999f), dimension);
            Add(1099783092, new Vector3(119.5065f, -401.8423f, 40.25843f),
                new Vector3(0f, 0f, -26.99995f), dimension);
            Add(1337522187, new Vector3(118.3202f, -404.3372f, 40.2384f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(1130651494, new Vector3(117.391f, -405.6899f, 40.22399f),
                new Vector3(0f, 0f, -22.99995f), dimension);
            Add(-1335345384, new Vector3(116.6037f, -407.724f, 40.2483f),
                new Vector3(0f, 0f, -22.99996f), dimension);
            Add(-1633248363, new Vector3(116.1161f, -409.5386f, 40.25657f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(-1832551453, new Vector3(114.8871f, -411.2886f, 40.26145f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(-2129471362, new Vector3(114.172f, -413.1483f, 40.26299f),
                new Vector3(0f, 0f, -14.99997f), dimension);
            Add(-1818771240, new Vector3(113.5356f, -415.618f, 40.7f),
                new Vector3(0f, 0f, -12.99999f), dimension);
            Add(-1531508740, new Vector3(113.1827f, -417.3789f, 40.7f),
                new Vector3(0f, 0f, -5.999997f), dimension);
            Add(-1301503129, new Vector3(113.0214f, -418.8794f, 40.7f),
                new Vector3(0f, 0f, -11.99996f), dimension);
            Add(72434891, new Vector3(111.7803f, -418.8215f, 40.7f),
                new Vector3(0f, 0f, -3.999999f), dimension);
            Add(1840382115, new Vector3(111.9477f, -417.3221f, 40.7f),
                new Vector3(0f, 0f, -7.999997f), dimension);
            Add(437228694, new Vector3(112.294f, -415.5157f, 40.7f),
                new Vector3(0f, 0f, -6.999997f), dimension);
            Add(-853526657, new Vector3(112.6029f, -413.4889f, 40.9f),
                new Vector3(0f, 0f, 0f), dimension);
            Add(1896897239, new Vector3(113.1628f, -411.245f, 40.26339f),
                new Vector3(0f, 0f, -11.99999f), dimension);
            Add(-188612674, new Vector3(113.7153f, -408.6295f, 40.25378f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(-1015375034, new Vector3(115.114f, -407.1945f, 40.24234f),
                new Vector3(0f, 0f, -18.99997f), dimension);
            Add(-1780563953, new Vector3(116.0732f, -405.4239f, 40.84f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(637672069, new Vector3(116.8619f, -403.7794f, 40.9f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(-1281587804, new Vector3(118.0929f, -401.7309f, 40.25599f),
                new Vector3(0f, 0f, -29.99997f), dimension);
            Add(1151045333, new Vector3(119.0338f, -399.8073f, 40.2617f),
                new Vector3(0f, 0f, -29.99997f), dimension);
            Add(1448093015, new Vector3(119.7617f, -397.7677f, 40.264f),
                new Vector3(0f, 0f, -30.99997f), dimension);
            Add(-470815620, new Vector3(120.8285f, -396.3998f, 40.85f),
                new Vector3(0f, 0f, -31.99996f), dimension);
            Add(1339364336, new Vector3(121.8188f, -394.3752f, 40.84f),
                new Vector3(0f, 0f, -27.99997f), dimension);
            Add(1580642483, new Vector3(120.6588f, -393.5966f, 40.84f),
                new Vector3(0f, 0f, -28.99997f), dimension);
            Add(-1278649385, new Vector3(119.8282f, -395.9572f, 40.81f),
                new Vector3(0f, 0f, -25.99998f), dimension);
            Add(-1626066319, new Vector3(117.9658f, -399.2494f, 40.81f),
                new Vector3(0f, 0f, -23.99998f), dimension);
            Add(464796672, new Vector3(116.7256f, -401.0767f, 40.26119f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(2024568303, new Vector3(115.5708f, -403.2241f, 40.25799f),
                new Vector3(0f, 0f, -24.99997f), dimension);
            Add(-546388559, new Vector3(114.7682f, -404.978f, 40.2555f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(-1405722835, new Vector3(113.8732f, -406.7613f, 40.25513f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-2097476980, new Vector3(112.9063f, -408.5949f, 40.26009f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(-1247858356, new Vector3(111.9359f, -410.4168f, 40.25682f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(197077615, new Vector3(111.517f, -412.8334f, 40.19482f),
                new Vector3(0f, 0f, -11.99999f), dimension);
            Add(1859499596, new Vector3(110.8994f, -415.1144f, 40.13036f),
                new Vector3(0f, 0f, -9.999996f), dimension);
            Add(-425962029, new Vector3(110.7513f, -417.113f, 40.066f),
                new Vector3(0f, 0f, -7.999997f), dimension);
            Add(-1461075408, new Vector3(110.6119f, -418.7466f, 40.0883f),
                new Vector3(0f, 0f, -6.999997f), dimension);
            Add(-1879746753, new Vector3(116.7495f, -398.9781f, 40.264f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(699173551, new Vector3(118.6926f, -397.017f, 40.264f),
                new Vector3(0f, 0f, -32.99996f), dimension);
            Add(-256436031, new Vector3(117.9479f, -396.4865f, 40.264f),
                new Vector3(0f, 0f, -31.99996f), dimension);
            Add(607684038, new Vector3(119.0426f, -395.4577f, 40.48f),
                new Vector3(0f, 0f, -28.99997f), dimension);
            Add(451260528, new Vector3(119.7737f, -393.1562f, 40.27844f),
                new Vector3(0f, 0f, -27.99995f), dimension);
            Add(-1869605644, new Vector3(109.9547f, -412.9498f, 40.7f),
                new Vector3(0f, 0f, 165.9991f), dimension);
            Add(-171943901, new Vector3(110.5115f, -410.6031f, 40.71f),
                new Vector3(0f, 0f, -16.99996f), dimension);
            Add(508864775, new Vector3(111.3662f, -407.905f, 40.8f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(1546354612, new Vector3(112.1047f, -405.8959f, 40.264f),
                new Vector3(0f, 0f, -21.99996f), dimension);
            Add(-881696544, new Vector3(112.8679f, -404.0375f, 40.94f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(2040839490, new Vector3(113.9766f, -402.3409f, 40.79f),
                new Vector3(0f, 0f, -23.99996f), dimension);
            Add(-1971298567, new Vector3(115.2146f, -400.2743f, 40.8f),
                new Vector3(0f, 0f, -24.99996f), dimension);
            Add(1630899471, new Vector3(115.5919f, -398.3552f, 40.264f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(1872312775, new Vector3(116.9685f, -395.8183f, 40.69f),
                new Vector3(0f, 0f, -26.99997f), dimension);
            Add(-930879665, new Vector3(117.8901f, -394.6925f, 40.264f),
                new Vector3(0f, 0f, -27.99995f), dimension);
            Add(-1228586030, new Vector3(118.7988f, -392.6771f, 40.32296f),
                new Vector3(0f, 0f, -24.99998f), dimension);
            Add(-401852480, new Vector3(124.7433f, -425.2235f, 40.0683f),
                new Vector3(0f, 0f, -17.99993f), dimension);
            Add(-361055067, new Vector3(119.9486f, -423.9674f, 40.06044f),
                new Vector3(0f, 0f, -16.99998f), dimension);
            Add(-726363879, new Vector3(115.1016f, -422.3291f, 40.06044f),
                new Vector3(0f, 0f, -15.99998f), dimension);
            Add(1443107762, new Vector3(121.5833f, -429.3734f, 40.09033f),
                new Vector3(0f, 0f, 161.0008f), dimension);
            Add(-968395721, new Vector3(116.5133f, -428.014f, 40.08518f),
                new Vector3(0f, 0f, 160.0008f), dimension);
            Add(-1309717625, new Vector3(111.7599f, -426.2993f, 40.0799f),
                new Vector3(0f, 0f, 163.0008f), dimension);
            Add(-1118217677, new Vector3(122.6295f, -433.5954f, 40.11024f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(-957463636, new Vector3(113.4258f, -429.8022f, 40.09741f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(1224329141, new Vector3(109.1094f, -428.2055f, 40.18536f),
                new Vector3(0f, 0f, -18.99998f), dimension);
            Add(-373650829, new Vector3(108.2008f, -430.3185f, 40.20369f),
                new Vector3(0f, 0f, -15.99999f), dimension);
            Add(-67162372, new Vector3(111.3251f, -431.5477f, 40.11792f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(-1063831511, new Vector3(114.9844f, -433.1426f, 40.11694f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(1285701428, new Vector3(118.458f, -434.5525f, 40.11914f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(1623746432, new Vector3(120.5613f, -438.4221f, 40.12938f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(167066071, new Vector3(116.5229f, -436.618f, 40.12938f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(370253355, new Vector3(111.1605f, -436.6252f, 40.13078f),
                new Vector3(0f, 0f, -18.99998f), dimension);
            Add(609499824, new Vector3(110.0848f, -438.8181f, 40.13078f),
                new Vector3(0f, 0f, 159.9989f), dimension);
            Add(-864927101, new Vector3(117.7192f, -431.5577f, 40.7f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(1526269963, new Vector3(115.9468f, -439.9946f, 40.12938f),
                new Vector3(0f, 0f, -18.99998f), dimension);
            Add(-406716247, new Vector3(120.5624f, -441.2453f, 40.12938f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(1593135630, new Vector3(119.6359f, -443.5602f, 40.12938f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(2109741755, new Vector3(116.1138f, -442.249f, 40.12938f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(-636869637, new Vector3(113.2659f, -442.3431f, 40.12938f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(1227733354, new Vector3(108.5041f, -442.4666f, 40.13078f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(1474287310, new Vector3(112.4409f, -444.3546f, 40.12938f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(-1969563019, new Vector3(116.4536f, -444.4139f, 40.12938f),
                new Vector3(0f, 0f, -21.99997f), dimension);
            Add(2130268726, new Vector3(119.9231f, -445.9205f, 40.12938f),
                new Vector3(0f, 0f, -18.99999f), dimension);

            // Betten
            Add(-671738639, new Vector3(152.6998f, -350.3892f, 42.74132f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(94826578, new Vector3(151.2538f, -349.8027f, 42.81067f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(-1729561268, new Vector3(149.5555f, -347.9449f, 43.04556f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(466551578, new Vector3(145.7857f, -346.4856f, 43.08391f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(1111119442, new Vector3(142.0381f, -345.0724f, 43.05318f),
                new Vector3(0f, 0f, -16.99998f), dimension);
            Add(-866701635, new Vector3(150.392f, -352.6404f, 42.45032f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-864163686, new Vector3(145.8674f, -350.8834f, 42.51542f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(-1103279079, new Vector3(142.2364f, -349.143f, 42.42066f),
                new Vector3(0f, 0f, -19.99998f), dimension);
            Add(-1857343250, new Vector3(138.5217f, -347.9126f, 42.48721f),
                new Vector3(0f, 0f, -19.99996f), dimension);
            Add(1937985747, new Vector3(154.2456f, -355.4242f, 42.9f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(-1284191201, new Vector3(155.491f, -351.4819f, 42.60858f),
                new Vector3(0f, 0f, -20.99996f), dimension);
            Add(-1211387925, new Vector3(152.4998f, -359.1828f, 42.257f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(2117668672, new Vector3(148.5716f, -357.3507f, 42.76f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(1631638868, new Vector3(143.9817f, -355.5724f, 42.72f),
                new Vector3(0f, 0f, -15.99997f), dimension);
            Add(-980185685, new Vector3(140.2569f, -354.6897f, 42.257f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(314496444, new Vector3(136.7028f, -353.0355f, 42.25f),
                new Vector3(0f, 0f, 64.99981f), dimension);
            Add(-1673752417, new Vector3(150.9275f, -363.1075f, 42.257f),
                new Vector3(0f, 0f, 68.99982f), dimension);
            Add(262175156, new Vector3(146.9381f, -361.4384f, 42.257f),
                new Vector3(0f, 0f, 66.99982f), dimension);
            Add(-1818341338, new Vector3(142.3691f, -359.5016f, 42.73f),
                new Vector3(0f, 0f, -109.9995f), dimension);
            Add(-1272174018, new Vector3(138.5833f, -358.6329f, 42.257f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(973168155, new Vector3(134.9989f, -356.6828f, 42.257f),
                new Vector3(0f, 0f, 66.99982f), dimension);
            Add(-838892007, new Vector3(149.5985f, -366.6906f, 42.257f),
                new Vector3(0f, 0f, -112.9997f), dimension);
            Add(4385439, new Vector3(145.6474f, -365.0645f, 42.257f),
                new Vector3(0f, 0f, 66.99982f), dimension);
            Add(-242987742, new Vector3(147.6879f, -365.9918f, 42.257f),
                new Vector3(0f, 0f, 66.99982f), dimension);
            Add(-963487759, new Vector3(146.2946f, -355.918f, 42.4f),
                new Vector3(0f, 0f, -20.99995f), dimension);
            Add(652816835, new Vector3(143.2769f, -362.5231f, 42.257f),
                new Vector3(0f, 0f, -18.99997f), dimension);
            Add(-677582063, new Vector3(142.9012f, -363.5749f, 42.257f),
                new Vector3(0f, 0f, -8.999996f), dimension);
            Add(682082323, new Vector3(141.2044f, -361.8235f, 42.257f),
                new Vector3(0f, 0f, -14.99999f), dimension);
            Add(1170592309, new Vector3(140.7024f, -363.1321f, 42.257f),
                new Vector3(0f, 0f, -5.999997f), dimension);
            Add(573740096, new Vector3(139.1761f, -361.0976f, 42.257f),
                new Vector3(0f, 0f, 0f), dimension);
            Add(-1829764702, new Vector3(138.5773f, -362.6952f, 42.257f),
                new Vector3(0f, 0f, -16.99999f), dimension);
            Add(740404217, new Vector3(137.5831f, -360.7316f, 42.47f),
                new Vector3(0f, 0f, 0f), dimension);
            Add(1130482396, new Vector3(136.9531f, -362.0299f, 42.257f),
                new Vector3(0f, 0f, -22.99998f), dimension);
            Add(463039275, new Vector3(135.726f, -359.715f, 42.49f),
                new Vector3(0f, 0f, -20.99998f), dimension);
            Add(-1190156817, new Vector3(142.3681f, -364.7588f, 42.257f),
                new Vector3(0f, 0f, -21.99998f), dimension);
            Add(-1062023761, new Vector3(140.3581f, -364.2824f, 42.92f),
                new Vector3(0f, 0f, -19.99996f), dimension);
            Add(-992710074, new Vector3(138.1321f, -363.824f, 42.257f),
                new Vector3(0f, 0f, 0f), dimension);
            Add(196301499, new Vector3(136.4828f, -363.3058f, 42.257f),
                new Vector3(0f, 0f, -17.99999f), dimension);
            Add(1242897321, new Vector3(134.5255f, -362.5051f, 42.257f),
                new Vector3(0f, 0f, -18.99999f), dimension);
            Add(-1126331894, new Vector3(135.0771f, -360.944f, 42.257f),
                new Vector3(0f, 0f, -11.99999f), dimension);
            Add(-1348472945, new Vector3(133.6561f, -364.0871f, 42.257f),
                new Vector3(0f, 0f, -11.99999f), dimension);
            Add(-1635234464, new Vector3(135.4315f, -364.58f, 42.257f),
                new Vector3(0f, 0f, -13.99999f), dimension);
            Add(-865883608, new Vector3(137.414f, -365.2473f, 42.257f),
                new Vector3(0f, 0f, -31.99996f), dimension);
        }
    }
}