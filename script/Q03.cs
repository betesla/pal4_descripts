// Structured PAL4 reconstruction for Q03.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q03_Q03S_init()
{
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giSetObjectVisible("entrance0", false);
        giSetObjectVisible("entrance3", false);
        giSetObjectVisible("entrance1", true);
        giSetObjectVisible("entrance2", true);
    }
    else
    {
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance3", true);
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance2", false);
    }
    if (global_mvar <= 21800 /* 第一章 / 2-1-6.初涉红尘 / 等待菱纱 */)
    {
        giSetObjectVisible("MO005", true);
    }
    if (global_mvar <= 21900 && global_mvar >= 21600 /* 第一章 / 2-2-1.徒惹官非 / 拜访柳府 / 寿阳揭榜 */)
    {
        giIMMBegin();
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance2", false);
        giIMMEnd();
    }
    if (global_mvar == 21800 /* 第一章 / 2-1-6.初涉红尘 / 等待菱纱 */)
    {
        giGameObjectSetResearch("MO005", true);
    }
    if (global_mvar == 31400 || global_mvar == 31500 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giIMMBegin();
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance2", false);
        giIMMEnd();
    }
    if (global_mvar < 21900 /* 第一章 / 2-2-1.徒惹官非 / 拜访柳府 / 寿阳揭榜 */)
    {
        giIMMBegin();
        giSetObjectVisible("title01", false);
        giSetObjectVisible("title11", false);
        giEventVolumeVisible("ev_Q03_Q03S_1", false);
        giIMMEnd();
    }
    if (global_mvar >= 50100 /* 离开王墓 */)
    {
        giSetObjectVisible("title11", false);
        giEventVolumeVisible("ev_Q03_Q03S_1", false);
    }
    if (var_shop021 == 1)
    {
        giSetNpcVisible("4023", false);
    }
    if (global_mvar > 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giSetNpcVisible("4023", false);
    }
    if (global_mvar == 21600 /* 第一章 / 2-1-4.初涉红尘 / 前去寿阳 / 露宿湖边 */)
    {
        func2001();
    }
    giArenaReadyRestore();
}

void Q03_XN03Y_init()
{
    if (global_mvar != 22400)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2006();
    }
}

void Q03_Q03X_init()
{
    if (global_mvar == 21901 /* 第一章 / 2-3-1.礼请天河 / 应邀去前厅 */)
    {
        giScriptMusicPlay("P58", 0, 0.0, 2.5);
    }
    if (global_mvar == 30101 /* 第一章 / 2-4-2.迷香梦绕 / 去找菱纱 */)
    {
        giSetNpcVisible("4048", false);
    }
    if (global_mvar < 21901 /* 第一章 / 2-3-1.礼请天河 / 应邀去前厅 */)
    {
        giSetObjectVisible("title06", false);
    }
    if (global_mvar == 21901 /* 第一章 / 2-3-1.礼请天河 / 应邀去前厅 */)
    {
        giSetObjectVisible("title05", false);
    }
    if (global_mvar != 30200 /* 第一章 / 2-4-3.迷香梦绕 / 前厅议事 */)
    {
        if (global_mvar == 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
        {
            giIMMBegin();
            giPlayerSetPos(2, 89.8405, 7.831, -978.6171);
            giPlayerSetAng(2, 325.0);
            giPlayerSetVisible(2, true);
            giNpcSetPos("MN002", 332.6761, -0.3236, -1061.1261);
            giNpcSetAng("MN002", 280.0);
            giSetNpcVisible("MN002", true);
            giIMMEnd();
        }
    }
    else
    {
        giSetObjectVisible("title05", false);
    }
    giArenaReadyRestore();
}

void func1001()
{
    giArenaLoad("Q03", "SN01", "", true);
    giPlayerCurrentSetPos(-34.788822, 0.273792, 45.034943);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(610.6397, -11.290636, -691.99445);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q03", "SN03", "", true);
    giPlayerCurrentSetPos(10.897669, -0.100082, 35.18219);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(-518.2896, -11.290636, -430.9664);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q03", "SN05", "", true);
    giPlayerCurrentSetPos(8.721521, 2.000031, 70.41687);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(522.1737, -11.290632, 1187.3804);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1007()
{
    if (global_mvar != 21800 /* 第一章 / 2-1-6.初涉红尘 / 等待菱纱 */)
    {
        if ((global_mvar < 100100 && global_mvar >= 90100 || global_mvar <= 101500 && global_mvar >= 100200) && var_zhu != 0 || global_mvar < 100200 && (global_mvar < 90100 || global_mvar >= 100100) || global_mvar > 101500 /* 第二章 / 6-3-3.义结金兰 / 歇息一晚 */)
        {
            giArenaLoad("Q03", "SN06", "", true);
            giPlayerCurrentSetPos(-73.861786, 0.999819, 103.04677);
            giPlayerCurrentSetAng(180.0);
            giCameraSetMode(3, true);
            giArenaReady();
        }
        else
        {
            giPlayerLock();
            giArenaLoad("Q03", "SN06", "", true);
            func3001();
        }
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -399.1352, -13.7907, 1489.6509, true);
        giPlayerSetDir(0, 93.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101C", true);
        giTalk("云天河：菱纱说要在客栈门口等她，别进去……", "");
        giPlayerUnLock();
    }
}

void func1008()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(-365.2335, -11.290628, 1493.6964);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("Q03", "SN07", "", true);
    giPlayerCurrentSetPos(353.63666, -13.999985, 13.881317);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q03", "SN06", "", true);
    giPlayerCurrentSetPos(305.20447, 97.25491, -82.96332);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("Q03", "SN08", "SN08a", true);
    giPlayerCurrentSetPos(84.78712, 0.5, 125.86101);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("Q03", "SN07", "", true);
    giPlayerCurrentSetPos(-13.482301, -13.9998, -16.520382);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("Q03", "SN08", "SN08b", true);
    giPlayerCurrentSetPos(84.78712, 0.5, 125.86101);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("Q03", "SN07", "", true);
    giPlayerCurrentSetPos(266.65265, -14.000002, -12.660447);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("Q03", "SN09", "SN09a", true);
    giPlayerCurrentSetPos(-98.45822, 0.391718, 102.856804);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(-101.99642, -11.290636, -1944.6874);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1017()
{
    giArenaLoad("Q03", "SN09", "SN09a", true);
    giPlayerCurrentSetPos(-96.69635, 0.391714, -61.924168);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1018()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(-472.00156, -3.538979, -1946.012);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1019()
{
    giArenaLoad("Q03", "SN10", "SN10a", true);
    giPlayerCurrentSetPos(-31.901264, 0.600002, 47.578407);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1020()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(-695.77814, -3.538979, -1946.8182);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1021()
{
    giArenaLoad("Q03", "SN09", "SN09b", true);
    giPlayerCurrentSetPos(-98.45822, 0.391718, 102.856804);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1022()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(-1455.0248, -11.290636, 1581.5603);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1023()
{
    giArenaLoad("Q03", "SN09", "SN09b", true);
    giPlayerCurrentSetPos(-96.69635, 0.391714, -61.924168);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1024()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(-1456.9146, -4.816584, 1212.729);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1025()
{
    giArenaLoad("Q03", "SN10", "SN10b", true);
    giPlayerCurrentSetPos(-31.901264, 0.600002, 47.578407);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1026()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(-1453.7833, -4.816584, 997.53046);
    giPlayerCurrentSetAng(359.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1027()
{
    giArenaLoad("Q03", "SN11", "SN11a", true);
    giPlayerCurrentSetPos(20.658192, -0.000002, 61.592106);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1028()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(2758.2559, -13.790632, 169.77603);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1029()
{
    giArenaLoad("Q03", "SN11", "SN11b", true);
    giPlayerCurrentSetPos(20.658192, -0.000002, 61.592106);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1030()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(551.6254, -11.290634, 1749.2378);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1031()
{
    giArenaLoad("Q03", "SN11", "SN11c", true);
    giPlayerCurrentSetPos(20.658192, -0.000002, 61.592106);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1032()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(1100.2671, -11.290632, 1636.5472);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1033()
{
    giArenaLoad("Q03", "SN11", "SN11d", true);
    giPlayerCurrentSetPos(20.658192, -0.000002, 61.592106);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1034()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(1611.2343, -11.290638, 2288.2126);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1035()
{
    giArenaLoad("Q03", "SN11", "SN11e", true);
    giPlayerCurrentSetPos(20.658192, -0.000002, 61.592106);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1036()
{
    giArenaLoad("Q03", "Q03S", "", true);
    giPlayerCurrentSetPos(2745.0476, -9.18396, 585.7874);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1037()
{
    if (global_mvar != 21900 /* 第一章 / 2-2-1.徒惹官非 / 拜访柳府 / 寿阳揭榜 */)
    {
        giArenaLoad("Q03", "Q03X", "", true);
        giPlayerCurrentSetPos(-5.546272, 8.527678, 1583.1295);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q03", "Q03X", "", true);
        func2004();
    }
}

void func1038()
{
    switch (global_mvar)
    {
        case 40100:
            giArenaLoad("Q03", "Q03S", "", true);
            func2011();
            break;
        case 21901:
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, -5.0987, 10.3118, 1616.1107, true);
            giPlayerSetDir(0, 177.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("101A", true);
            giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>那个胖胖的柳波波让我进那间大房子，</colour><dc0>我就跟进去看看好了～</dc0>", "");
            giPlayerUnLock();
            break;
        case 30200:
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, -5.0987, 10.3118, 1616.1107, true);
            giPlayerSetDir(0, 177.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("101A", true);
            giTalk("云天河：我要<colour red=255 green=187 blue=0 alpha=255>先去前厅找菱纱</colour><dc0>～</dc0>", "");
            giPlayerUnLock();
            break;
        default:
            giArenaLoad("Q03", "Q03S", "", true);
            giPlayerCurrentSetPos(218.21367, -11.290636, -2030.0826);
            giPlayerCurrentSetAng(270.0);
            giCameraSetMode(0, true);
            giArenaReady();
            break;
    }
}

void func1039()
{
    giArenaLoad("Q03", "XN01", "", true);
    giPlayerCurrentSetPos(32.44662, -0.909294, 0.526472);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1040()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(-1202.6006, -0.67111, 1670.2604);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1041()
{
    giArenaLoad("Q03", "XN02", "", true);
    giPlayerCurrentSetPos(-1.036641, -0.299999, 21.980696);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1042()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(-1193.0471, -0.671108, 1159.5411);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1043()
{
    giArenaLoad("Q03", "XN03", "", true);
    giPlayerCurrentSetPos(16.567957, -0.199997, 41.982555);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1044()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(1173.0825, -0.671108, 1327.7189);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1045()
{
}

void func1046()
{
}

void func1047()
{
    switch (global_mvar)
    {
        case 21901:
            giArenaLoad("Q03", "XN04", "", true);
            func2005();
            break;
        case 30200:
            giArenaLoad("Q03", "XN04", "", true);
            func2008();
            break;
        case 31300:
            giArenaLoad("Q03", "XN04", "", true);
            func2009();
            break;
        case 31400:
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, -3.7209, 10.8531, 414.0219, true);
            giPlayerSetDir(0, 0.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("101C", true);
            giTalk("云天河：菱纱让我不要去打扰柳波波他们，我还是别进去了。", "");
            giPlayerUnLock();
            break;
        default:
            giArenaLoad("Q03", "XN04", "", true);
            giPlayerCurrentSetPos(-6.665374, 0.564423, 102.97418);
            giPlayerCurrentSetAng(180.0);
            giCameraSetMode(2, true);
            giArenaReady();
            break;
    }
}

void func1048()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(-1.616041, -0.67111, 523.09216);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1049()
{
    giArenaLoad("Q03", "XN05", "", true);
    giPlayerCurrentSetPos(-68.486534, -0.287197, -84.616066);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1050()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(-1192.3339, -0.671106, -76.43428);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1051()
{
    giArenaLoad("Q03", "XN06", "", true);
    giPlayerCurrentSetPos(-1.451633, 0.849287, 85.27204);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1052()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(1128.8773, -0.671108, -377.34222);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1053()
{
    giArenaLoad("Q03", "XN07", "", true);
    giPlayerCurrentSetPos(-31.0, 0.0, 104.0);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1054()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(-451.07953, -0.671106, -428.00214);
    giPlayerCurrentSetAng(1.08);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1055()
{
    giArenaLoad("Q03", "XN08", "", true);
    giPlayerCurrentSetPos(64.29286, -0.006262, 4.119156);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1056()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(-1173.5726, -0.323544, -1838.2327);
    giPlayerCurrentSetAng(1.6);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1057()
{
    giArenaLoad("Q03", "XN09", "", true);
    giPlayerCurrentSetPos(-1.924697, 1.00086, 87.64637);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1058()
{
    giArenaLoad("Q03", "Q03X", "", true);
    giPlayerCurrentSetPos(537.83594, -0.32354, -1789.8706);
    giPlayerCurrentSetAng(0.8);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1059()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("M03", "1", "", true);
        giPlayerCurrentSetPos(-1631.8359, -33.835938, -1961.8359);
        giPlayerCurrentSetAng(80.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else if (global_mvar != 110200 /* 第二章 / 6-5-2.非愿 / 前往巢湖 / 月夜惜别 */)
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去巢湖    ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("     准备<colour red=255 green=102 blue=0 alpha=255>去巢湖</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -1.55481, -13.55481, 2784.555, true);
                giPlayerSetDir(leader_player_id, 180.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
            }
            else
            {
                giShowWorldMap();
            }
        }
        else
        {
            giArenaLoad("M03", "1", "", true);
            giPlayerCurrentSetPos(-1631.8359, -33.835938, -1961.8359);
            giPlayerCurrentSetAng(80.0);
            giCameraSetMode(5, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
    else
    {
        giFlashOutBlack(0.1, true, false);
        giArenaLoad("M03", "1", "", true);
    }
}

void func1060()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        if (global_mvar != 30201 /* 第一章 / 2-5-1.女萝平妖 / 北门出城 */)
        {
            giArenaLoad("M05", "1", "", true);
            giPlayerCurrentSetPos(1525.2577, -281.50745, 1837.627);
            giPlayerCurrentSetAng(192.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        else
        {
            giFlashOutBlack(1.0, true, true);
            giArenaLoad("M05", "1", "", true);
        }
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去八公山  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去八公山</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, 2.918462, -13.29063, -3285.2183, true);
                giPlayerSetDir(leader_player_id, 356.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
            }
            else
            {
                giShowWorldMap();
            }
        }
        else
        {
            giArenaLoad("M05", "1", "", true);
            giPlayerCurrentSetPos(1525.2577, -281.50745, 1837.627);
            giPlayerCurrentSetAng(192.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1061()
{
    int leader_player_id = 0;

    giPlayerLock();
    giNpcPauseBeh("4026");
    giNpcFaceToCurrentPlayer("4026", true);
    giCurrentPlayerFaceToNpc("4026", true);
    giTalk("郭正忠：衙门重地，闲杂人等速速离开！", "");
    giNpcResetDir("4026");
    giNpcResumeBeh("4026");
    leader_player_id = giPlayerGetLeader();
    giPlayerWalkTo(leader_player_id, -1722.3676, -11.290634, 158.26474, true);
    giPlayerSetDir(leader_player_id, 1.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giPlayerUnLock();
}

void func1062()
{
    giPlayerLock();
    giNpcPauseBeh("4042");
    giNpcFaceToCurrentPlayer("4042", true);
    giCurrentPlayerFaceToNpc("4042", true);
    giTalk("仇敬：牢房重地，闲杂人等速速离开！", "");
    giNpcResetDir("4042");
    giNpcResumeBeh("4042");
    giPlayerWalkTo(0, -2420.3184, -11.290634, 63.575455, true);
    giPlayerSetDir(0, 265.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giPlayerUnLock();
}

void func1063()
{
}

void func1064()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-378.86227, 0.100002, -103.00063, true);
    giPlayerCurrentSetAng(29.0);
    giSetPortrait("101C", true);
    giTalk("云天河：里面是厨房，还是不要进去为好。", "");
    giPlayerUnLock();
}

void func1065()
{
    if (global_mvar != 22100 /* 第一章 / 2-3-2.礼请天河 / 离开柳府 */)
    {
        giArenaLoad("M04", "1", "", true);
        giPlayerCurrentSetPos(1173.0825, -0.671108, 1327.7189);
        giPlayerCurrentSetAng(270.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.1, true, true);
        giArenaLoad("M04", "1", "", true);
    }
}

void func1066()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(3389.8623, -13.100002, 375.00064, true);
    giPlayerCurrentSetAng(270.0);
    giSetPortrait("101C", true);
    giTalk("云天河：这边城门已经关闭，走另外一边吧。", "");
    giPlayerUnLock();
}

void func1067()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-3051.8623, -13.100002, 370.00064, true);
    giPlayerCurrentSetAng(87.0);
    giSetPortrait("101C", true);
    giTalk("云天河：这边城门已经关闭，走另外一边吧。", "");
    giPlayerUnLock();
}

void func1068()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(1877.8623, 9.100002, -543.0006, true);
    giPlayerCurrentSetAng(358.0);
    giSetPortrait("101C", true);
    giTalk("云天河：里边正在修缮，就别进去了吧。", "");
    giPlayerUnLock();
}

void func2001()
{
    switch (global_mvar)
    {
        case 21600:
            giPlayerLock();
            giFlashOutBlack(1.5, true, true);
            giCameraSetCollide(false);
            giCameraAutoSeek(false);
            giPlayerCurrentSetVisible(false);
            giPlayerSetPos(0, -17.5012, -13.7906, 2628.534);
            giPlayerSetAng(0, 164.0);
            giPlayerSetVisible(0, true);
            giPlayerSetPos(1, 26.0642, -13.7906, 2577.8198);
            giPlayerSetAng(1, 192.0);
            giPlayerSetVisible(1, true);
            giCameraPrepare("MC001");
            giCameraRunSingle("001", true);
            giFlashInBlack(2.2, false);
            giArenaReady();
            giGrantSmithSystem(true, true, false, false);
            giWait(1.0);
            giCameraRunSingle("002", true);
            giWait(1.8);
            giCameraRunSingle("003", true);
            giPlayerDoAction(0, "J13", -1, false);
            giSetPortrait("101D", true);
            giTalk("云天河：…………好大的门、好多房子！！", "40842");
            giPlayerUnHoldAct(0);
            giPlayerEndAction(0);
            giPlayerSetDir(1, 337.0, true);
            giWait(0.3);
            giPlayerDoAction(1, "J13", -1, false);
            giSetPortrait("103M", false);
            giTalk("韩菱纱：嘻嘻，见识到了吧～", "40843");
            giPlayerUnHoldAct(1);
            giPlayerEndAction(1);
            giPlayerSetDir(0, 131.0, true);
            giWait(0.3);
            giSetPortrait("103M", false);
            giTalk("韩菱纱：走，<colour red=255 green=187 blue=0 alpha=255>先去客栈找点吃的，</colour><dc0>我都饿得前胸贴后背了……</dc0>", "40844");
            giSetPortrait("101C", true);
            giTalk("云天河：克占？", "40845");
            giPlayerSetDir(1, 212.0, true);
            giWait(0.3);
            giSetPortrait("103M", false);
            giTalk("韩菱纱：那边，看到没？阳～春～客～栈几个大字！", "40846");
            giWait(0.3);
            giCameraRunSingle("004", true);
            giWait(0.3);
            giSetPortrait("103A", false);
            giTalk("韩菱纱：听好了，所谓“客栈”呢，就是供人休息睡觉的地方——", "40847");
            giCameraRunSingle("003", true);
            giWait(0.3);
            giPlayerSetDir(1, 336.0, true);
            giWait(0.3);
            giPlayerDoAction(1, "C07", -1, false);
            giSetPortrait("103A", false);
            giTalk("韩菱纱：喂，人家好心和你解释，你怎么不听？真没礼貌！", "40848");
            giPlayerUnHoldAct(1);
            giPlayerEndAction(1);
            giPlayerDoAction(0, "J14", 1, false);
            giSetPortrait("101A", true);
            giTalk("云天河：我、我在想，你饿得真快，一下又要吃饭了。", "40849");
            giSetPortrait("103F", false);
            giTalk("韩菱纱：说什么呢，我可是从昨晚一直饿到现在……", "40850");
            giSetPortrait("101A", true);
            giTalk("云天河：你不是讲过，被我气都气饱了？", "40851");
            giSetPortrait("101B", true);
            giTalk("云天河：这气饱的，果然比不上吃东西填肚子，一会儿就撑不住了。", "40852");
            giPlayerDoAction(1, "J17", -1, false);
            giSetPortrait("103F", false);
            giTalk("韩菱纱：你！——傻瓜！气话也当真！", "40853");
            giPlayerUnHoldAct(1);
            giPlayerEndAction(1);
            giPlayerDoAction(0, "C08", 1, false);
            giSetPortrait("101A", true);
            giTalk("云天河：哦……", "40854");
            giPlayerDoAction(1, "J04", -1, false);
            giSetPortrait("103F", false);
            giTalk("韩菱纱：哦什么哦，遇上你算我倒霉……", "40855");
            giSetPortrait("103E", false);
            giTalk("韩菱纱：（不教而杀谓之过，我忍！）", "40856");
            giFlashOutBlack(1.5, true, true);
            giPlayerUnHoldAct(1);
            giPlayerEndAction(1);
            giPlayerSetVisible(1, false);
            giPlayerSetVisible(0, false);
            global_mvar = 21700; // 0x000054C4, 第一章 / 2-1-5.初涉红尘 / 阳春客栈
            giPlayerCurrentSetPos(6.6844, -13.7906, 2301.69);
            giPlayerCurrentSetAng(181.0);
            giPlayerCurrentSetVisible(true);
            giCameraSetMode(0, true);
            giCameraSeekToPlayer();
            giFlashInBlack(1.5, true);
            giPlayerUnLock();
            break;
        case 21700:
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, 0.5663, -13.7906, 2530.6357, true);
            giPlayerSetDir(0, 182.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("101A", true);
            giTalk("云天河：菱纱说<colour red=255 green=187 blue=0 alpha=255>要先去那个叫“客栈”的地方</colour><dc0>……</dc0>", "");
            giPlayerUnLock();
            break;
        case 21900:
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, 0.5663, -13.7906, 2530.6357, true);
            giPlayerSetDir(0, 182.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("101A", true);
            giTalk("云天河：现在<colour red=255 green=187 blue=0 alpha=255>该去那个老大的家里</colour><dc0>……</dc0>", "");
            giPlayerUnLock();
            break;
        default:
            if (global_mvar == 31400 || global_mvar == 31500 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
            {
                giPlayerLock();
                giPlayerSetLeader(0);
                giPlayerWalkTo(0, 0.5663, -13.7906, 2530.6357, true);
                giPlayerSetDir(0, 182.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giSetPortrait("101B", true);
                giTalk("云天河：快到吃晚饭的时间了吧？还是别出城了。", "");
                giPlayerUnLock();
            }
            break;
    }
}

void func2002()
{
    if (global_mvar == 21700 /* 第一章 / 2-1-5.初涉红尘 / 阳春客栈 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -243.3991, -13.7906, 1916.8087);
        giPlayerSetAng(0, 223.0);
        giPlayerSetVisible(0, true);
        giSetNpcVisible("4037", false);
        giSetNpcVisible("4039", false);
        giSetNpcVisible("4042", false);
        giCameraPrepare("MC002");
        giCameraRunSingle("002", true);
        giPlayerWalkTo(0, -390.9582, -13.7906, 1759.3036, false);
        giFlashInBlack(2.3, false);
        giCameraRunSingle("003", false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 232.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J22", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：什么味儿？好香～～", "40857");
        giPlayerSetPos(1, -221.3826, -13.7906, 1902.618);
        giPlayerSetAng(1, 229.0);
        giPlayerSetVisible(1, true);
        giPlayerRunTo(1, -347.165, -13.7906, 1746.5083, true);
        giPlayerSetDir(1, 273.0, true);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：香？我说，你该不会是个酒鬼吧？！", "40858");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 97.0, true);
        giCameraRunSingle("004", false);
        giSetPortrait("101B", true);
        giTalk("云天河：酒柜？什么东西？", "40859");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：不懂算了，总之这些坛子先前装过一种叫作“酒”的东西，和水差不多吧，但它可不是个好东西，喝下去会头晕乱说话，说不定会做出不可挽回的祸事呢。", "40860");
        giPlayerEndAction(1);
        giSetPortrait("101B", true);
        giTalk("云天河：真的？！", "40861");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：难道我会骗你不成？所以酒是少碰，不，别碰的为好！", "40862");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：……原来“酒”是个坏东西，可这味道，实在很香……", "40863");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（不妙……这家伙有做酒鬼的潜质，闻到酒味这么兴奋，要是让他知道客栈里卖酒……）", "40864");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：啊，我看既然要赶路去陈州，也不用住店了，你在这儿等着，我去去就回。", "40865");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101B", true);
        giTalk("云天河：好！", "40866");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：别乱跑，也别多管闲事哦！", "40867");
        giSetPortrait("101B", true);
        giTalk("云天河：好！", "40868");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……别多管闲事，别惹麻烦！", "40869");
        giSetPortrait("101B", true);
        giTalk("云天河：好！", "40870");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：还有别乱拿东西、别帮别人忙！", "40871");
        giSetPortrait("101B", true);
        giTalk("云天河：好！", "40872");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：唉～好好好，就怕最后又不好了……", "40873");
        giPlayerEndAction(1);
        giPlayerWalkTo(1, -456.1798, -4.6104, 1514.9445, false);
        giWait(1.2);
        giPlayerSetDir(0, 200.0, true);
        giPlayerEndMove(1);
        giPlayerSetVisible(1, false);
        giPlayerOutTeam(1, true);
        giWait(2.5);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(0, false);
        giPlayerCurrentSetVisible(true);
        giSetNpcVisible("4037", true);
        giSetNpcVisible("4039", true);
        giSetNpcVisible("4042", true);
        giGameObjectSetResearch("MO005", true);
        global_mvar = 21800; // 0x00005528, 第一章 / 2-1-6.初涉红尘 / 等待菱纱
        giPlayerCurrentSetPos(-340.2695, -13.7907, 1520.4476);
        giPlayerCurrentSetAng(260.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2003()
{
    if (global_mvar == 21800 /* 第一章 / 2-1-6.初涉红尘 / 等待菱纱 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -388.3969, -13.7906, 1284.5422);
        giPlayerSetAng(0, 262.0);
        giPlayerSetVisible(0, true);
        giSetNpcVisible("4037", false);
        giSetNpcVisible("4039", false);
        giSetNpcVisible("4042", false);
        giSetNpcVisible("4101", false);
        giSetNpcVisible("4035", false);
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giSetPortrait("101D", true);
        giTalk("云天河：咦——这是菱纱？", "40874");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：（眉毛、鼻子，还有眼睛都差不多～）", "40875");
        gi2DSoundPlay("WJ044", 1);
        giWait(0.5);
        giSetObjectVisible("MO005", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giIMMBegin();
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giIMMEnd();
        giNpcFaceToPlayer("MN001", 0, false);
        giTalk("官差甲：小兄弟！你既然揭了告示，可是见过画上之人？", "40876");
        giWait(0.3);
        giPlayerSetDir(0, 117.0, false);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：这是你的？不能拿？还是……要钱？", "40877");
        giTalk("官差甲：莫要说笑，你可知画上此人现在何处？", "40878");
        giSetPortrait("101A", true);
        giTalk("云天河：哦，她刚进客栈了…………没想到她跟我爹一样有名——", "40879");
        giNpcSetDir("MN001", 197.0, true);
        giTalk("官差甲：快！你马上禀报裴捕头！", "40880");
        giNpcSetDir("MN002", 10.0, true);
        giTalk("官差乙：好！", "40881");
        giWait(0.5);
        giNpcRunTo("MN002", -460.8626, -13.7906, 1056.9004, false);
        giWait(1.2);
        giNpcFaceToPlayer("MN001", 0, true);
        giWait(0.3);
        giTalk("官差甲：别怕，那贼人虽然狡猾，也挡不住人多势众！你今日举报有功，官府必有重谢！", "40882");
        giSetPortrait("101D", true);
        giTalk("云天河：什么？", "40883");
        giIMMBegin();
        giPlayerSetPos(1, -395.9485, -13.7906, 1419.184);
        giPlayerSetAng(1, 176.0);
        giPlayerSetVisible(1, true);
        giSetNpcVisible("MN002", false);
        giIMMEnd();
        giSetPortrait("103M", false);
        giTalk("韩菱纱：天河，我们走吧！", "40884");
        giWait(0.3);
        giPlayerSetDir(0, 0.0, false);
        giNpcSetDir("MN001", 321.0, true);
        giCameraRunSingle("003", true);
        giWait(0.3);
        giNpcDoAction("MN001", "J01", -1, false);
        giTalk("官差甲：大胆贼人，果然是你！还不乖乖束手就擒！", "40885");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：什么贼？你居然说我是“贼”？！", "40886");
        giCameraRunSingle("004", true);
        giPlayerRunTo(1, -340.3349, -13.7906, 1314.3395, false);
        giWait(1.0);
        giPlayerSetDir(0, 53.0, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：可恶！睁大你的眼睛！倒是看看我从头到脚哪一点像“贼”！", "40887");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", false);
        giTalk("官差甲：还敢狡辩！旁边这位小兄弟已揭了通缉告示，我在此守着，果然等到你来！", "40888");
        giPlayerSetDir(1, 231.0, true);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：云——天——河！！", "40889");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：我、我也不知道怎么回事，那纸上有你的脸，我撕下来想让你看看……画得挺不错的……", "40890");
        giSetPortrait("103K", true);
        giTalk("韩菱纱：笨笨笨！笨死啦！", "40891");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：我是不是又做错什么了啊？", "40892");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103K", true);
        giTalk("韩菱纱：还用问？！自从遇到你以后，我的火气比以前大了好多！拜托别老是做让我没气质的事好不好？换谁都受不了啦……", "40893");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("官差乙：裴捕头到！", "47002");
        giNpcSetPos("MN002", -474.829, -13.7906, 1007.103);
        giNpcSetAng("MN002", 17.0);
        giIMMBegin();
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("MN003", true);
        giSetNpcVisible("MN005", true);
        giIMMEnd();
        giPlayerSetDir(0, 173.0, true);
        giPlayerSetDir(1, 208.0, true);
        giNpcSetDir("MN001", 237.0, true);
        giCameraRunSingle("005", false);
        giNpcWalkTo("MN003", -379.2362, -13.7906, 1072.6812, false);
        giNpcWalkTo("MN002", -449.2618, -13.7906, 1079.8828, false);
        giNpcWalkTo("MN005", -396.173, -13.7906, 1143.8827, true);
        giCameraWait();
        giIMMBegin();
        giNpcFaceToPlayer("MN003", 0, false);
        giNpcFaceToPlayer("MN002", 0, false);
        giIMMEnd();
        giWait(1.0);
        giCameraRunSingle("006", true);
        giWait(0.5);
        giTalk("官差乙：将犯人拿下！", "40894");
        giWait(1.3);
        giNpcWalkTo("MN005", -385.8273, -13.7906, 1221.9886, true);
        giWait(0.2);
        giNpcSetDir("MN005", 354.0, true);
        giSetNpcVisible("MN006", true);
        giSetNpcVisible("MN005", false);
        giSetPortrait("204A", false);
        giTalk("裴剑：……且慢——！！", "40895");
        giNpcDoAction("MN006", "J01", -1, true);
        giSetPortrait("204A", false);
        giTalk("裴剑：请问小兄弟姓谁名甚，哪里人氏？", "40896");
        giSetPortrait("101C", true);
        giTalk("云天河：我？你问我？", "40897");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：我叫云天河，刚从山上下来，怎么了？", "40898");
        giNpcUnHoldAct("MN006");
        giNpcEndAction("MN006", true);
        giSetPortrait("204A", false);
        giTalk("裴剑：果然是云公子……", "40899");
        giSetNpcVisible("MN005", true);
        giSetNpcVisible("MN006", false);
        giNpcDoAction("MN005", "J02", -1, true);
        giSetPortrait("204A", false);
        giTalk("裴剑：裴剑代我家大人请云公子去府上一叙，请一定赏脸。", "40900");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101D", true);
        giTalk("云天河：啊？什么意思？", "40901");
        giWait(0.3);
        giIMMBegin();
        giCameraRunSingle("007", false);
        giPlayerSetAng(1, 232.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：嗯……说好懂一点，就是他的老大想让你去他家玩。", "40902");
        giWait(0.5);
        giSetPortrait("204A", false);
        giTalk("裴剑：我家大人姓柳，正是寿阳县令。", "40903");
        giNpcUnHoldAct("MN005");
        giNpcEndAction("MN005", true);
        giPlayerSetDir(1, 207.0, true);
        giSetPortrait("204A", false);
        giTalk("裴剑：大人与云家颇有渊源，叮嘱我留意云家人的行踪，若是公子不肯前去，裴剑受罚事小，大人多年的夙愿却难了却了。", "40904");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：哦～～这回我懂了，大人就是老大，我不去你就要挨骂，那我去总行了吧？不能害你。", "40905");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giNpcDoAction("MN005", "J02", -1, true);
        giSetPortrait("204A", false);
        giTalk("裴剑：多谢云公子！", "40906");
        giNpcUnHoldAct("MN005");
        giNpcEndAction("MN005", false);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：嘻嘻，这不就结了？喊打喊杀干嘛呀？一场误会～", "40907");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("204A", false);
        giTalk("裴剑：对不住，姑娘请和诸位官差回衙门一趟，最后若是查清冤枉了你，自会还你公道。", "40908");
        giNpcFaceToNpc("MN001", "MN005", false);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：什么？有没搞错？我和他是一起的，哪有他吃大鱼大肉，我吃牢饭的道理！", "40909");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("204A", false);
        giTalk("裴剑：姑娘和那通缉要犯实在相像，官府办案宁枉勿纵，还请见谅。", "40910");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：（……麻烦，好像遇上个难缠的家伙……）", "40911");
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：不行！菱纱不想跟你们去，谁也不许强迫她！她说去牙门是要杀头的！", "40912");
        giCameraRunSingle("006", true);
        giNpcDoAction("MN004", "J01", -1, false);
        giNpcDoAction("MN003", "J01", -1, false);
        giNpcDoAction("MN002", "J01", -1, false);
        giTalk("官差乙：大胆！敢这样对裴捕头讲话，你待如何？！", "40913");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：我呆如何？……呆又怎样？反正………你们先不仁，我也可以不义！", "40914");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：哈、哈哈……", "40915");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101H", true);
        giTalk("云天河：菱纱你干嘛笑？快走！不然你我两条命就搁这儿了。", "40916");
        giPlayerSetDir(1, 239.0, true);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：（哎，这家伙真是傻得可爱，突然觉得他顺眼多了～）", "40917");
        giSetPortrait("204A", false);
        giTalk("裴剑：……都住手，不得对云公子无礼！", "40918");
        giWait(0.5);
        giIMMBegin();
        giNpcUnHoldAct("MN004");
        giNpcUnHoldAct("MN003");
        giNpcUnHoldAct("MN002");
        giIMMEnd();
        giIMMBegin();
        giNpcEndAction("MN004", false);
        giNpcEndAction("MN003", false);
        giNpcEndAction("MN002", false);
        giIMMEnd();
        giCameraRunSingle("007", true);
        giWait(0.3);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：好了好了～我看都别争了。", "40919");
        giPlayerEndAction(1);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：捕头大人简直是块又臭又硬的石头，一点情理都不通，真没办法。天河你就去吧，不要忘了和县令大人说个明白，还我清白！", "40920");
        giPlayerSetDir(0, 54.0, true);
        giSetPortrait("101H", false);
        giTalk("云天河：你要跟他们走？去杀头？", "40921");
        giPlayerSetDir(1, 239.0, true);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：放心，他们不会把我怎么样的，别多问了。倒是你，趁这机会看看那个县令到底怎么回事，说不定他认识你爹呢。", "40922");
        giSetPortrait("101C", false);
        giTalk("云天河：爹？！", "40923");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：嘘，小声点～你走吧，见机行事，我自然会去找你的。", "40924");
        giPlayerEndAction(1);
        giNpcDoAction("MN005", "J02", -1, true);
        giSetPortrait("204A", false);
        giTalk("裴剑：云公子，我们这就走吧，请。", "40925");
        giNpcUnHoldAct("MN005");
        giNpcEndAction("MN005", false);
        giWait(0.6);
        giPlayerDoAction(0, "C08", 1, true);
        giWait(0.8);
        giCameraRunSingle("008", false);
        giNpcWalkTo("MN005", -345.1042, -13.7906, 1120.3495, false);
        giPlayerWalkTo(0, -332.5928, -13.7906, 1178.034, false);
        giWait(0.7);
        giPlayerSetDir(1, 181.0, false);
        giNpcFaceToNpc("MN001", "MN003", false);
        giPlayerEndMove(0);
        giNpcEndMove("MN005");
        giNpcSetDir("MN005", 157.0, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：喂！野人！", "40926");
        giPlayerSetDir(0, 360.0, false);
        giNpcSetDir("MN005", 4.0, false);
        giSetPortrait("101C", false);
        giTalk("云天河：啊？", "40927");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：谢谢你～", "40928");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101C", false);
        giTalk("云天河：谢我？为什么？", "40929");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：没事，走啦走啦，别问这么多！", "40930");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：好……", "40931");
        giWait(0.6);
        giCameraRunSingle("009", true);
        giWait(0.5);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：嘻，真是个大孩子……", "40932");
        giPlayerEndAction(1);
        giFlashOutBlack(1.5, true, true);
        giNpcSetPos("MN005", -29.1892, -13.7906, 287.6304);
        giNpcSetAng("MN005", 6.0);
        giPlayerSetPos(0, -8.9403, -13.7906, 392.6672);
        giPlayerSetAng(0, 189.0);
        giCameraRunSingle("010", true);
        giCameraSetDistOptEnable(false);
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giSetPortrait("204A", true);
        giTalk("裴剑：云公子，<colour red=255 green=187 blue=0 alpha=255>我家大人的府邸就是寿阳北城门附近的柳府，</colour><dc0>请随我来。</dc0>", "40933");
        giNpcWalkTo("MN005", -20.7478, -13.7906, 102.6635, false);
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giCameraSetDistOptEnable(true);
        giIMMBegin();
        giPlayerOutTeam(1, false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerCurrentSetVisible(true);
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN004", false);
        giSetNpcVisible("MN005", false);
        giSetNpcVisible("4037", true);
        giSetNpcVisible("4039", true);
        giSetNpcVisible("4042", true);
        giSetNpcVisible("4101", true);
        giSetNpcVisible("4035", true);
        giSetObjectVisible("entrance1", true);
        giSetObjectVisible("title11", true);
        giSetObjectVisible("title01", true);
        giSetObjectVisible("entrance2", true);
        giEventVolumeVisible("ev_Q03_Q03S_1", true);
        global_mvar = 21900; // 0x0000558C, 第一章 / 2-2-1.徒惹官非 / 拜访柳府 / 寿阳揭榜
        giIMMEnd();
        giPlayerCurrentSetPos(-7.1958, -13.7906, 385.3745);
        giPlayerCurrentSetAng(159.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2004()
{
    giPlayerLock();
    giScriptMusicPlay("P58", 0, 0.0, 2.5);
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerSetLeader(0);
    giPlayerSetPos(0, -4.4984, -0.6711, 996.2631);
    giPlayerSetAng(0, 186.0);
    giSetNpcVisible("MN001", true);
    giSetNpcVisible("4047", false);
    giSetNpcVisible("4048", false);
    giCameraPrepare("MC001");
    giCameraRunSingle("002", true);
    giFlashInBlack(2.5, false);
    giPlayerWalkTo(0, -6.0332, -0.6711, 847.7023, false);
    giArenaReady();
    giPlayerEndMove(0);
    giPlayerSetDir(0, 191.0, true);
    giWait(0.3);
    giSetPortrait("204A", true);
    giTalk("裴剑：云公子，请在此稍候，我去禀报大人，速速便回。", "40934");
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101A", false);
    giTalk("云天河：好啊，你快点，我也有事想问你的老大。", "40935");
    giPlayerEndAction(0);
    giSetPortrait("204A", true);
    giTalk("裴剑：……", "40936");
    giNpcDoAction("MN001", "J02", 1, true);
    giWait(0.5);
    giNpcWalkTo("MN001", -5.7264, -0.6711, 523.3387, false);
    giWait(1.8);
    giCameraRunSingle("003", true);
    giSetNpcVisible("MN001", false);
    giPlayerDoAction(0, "J13", 1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：（这里的房子真大……）", "40937");
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：（那个老大……真的认识我爹吗？）", "40938");
    giSetPortrait("101C", false);
    giTalk("云天河：（以前常听爹说怎么打坏人，人的老大和猴子的老大不一样，很多都是大大的坏蛋……）", "40939");
    giSetNpcVisible("MN002", true);
    giSetNpcVisible("MN003", true);
    giTalk("禄珠：快看！哪来的傻小子～", "40940");
    giWait(0.3);
    giPlayerSetDir(0, 132.0, false);
    giCameraRunSingle("004", true);
    giCameraRunSingle("006", false);
    giWait(4.6);
    giCameraRunSingle("007", true);
    giTalk("禄蓉：嘘！小点儿声，他能进到内院，肯定是老爷的客人，太稀奇了！", "40941");
    giTalk("禄蓉：仔细瞧瞧，他穿得是破，可长得很俊呢！", "40942");
    giPlayerSetPos(0, 385.5377, -0.6711, 616.0508);
    giPlayerSetAng(0, 109.0);
    giTalk("禄珠：哎呀！他过来了，我们快走～", "40943");
    giNpcWalkTo("MN003", 747.3444, -0.6711, 551.1429, false);
    giNpcWalkTo("MN002", 757.9632, -0.6711, 530.5361, true);
    giCameraRunSingle("008", true);
    giWait(0.5);
    giPlayerDoAction(0, "J14", 1, true);
    giWait(0.7);
    giSetNpcVisible("MN004", true);
    giSetPortrait("205A", false);
    giTalk("？？：贤～侄～呐～～～", "40944");
    giPlayerSetDir(0, 224.0, false);
    giCameraRunSingle("009", true);
    giWait(0.5);
    giNpcWalkTo("MN004", 339.0678, -0.6711, 575.6158, false);
    giSetPortrait("205A", false);
    giTalk("？？：啊！！这——！！", "40945");
    giNpcEndMove("MN004");
    giSetPortrait("205A", false);
    giTalk("？？：长得太像了！裴剑说的时候，我还不敢相信，这天底下哪有这等巧事！", "40946");
    giCameraRunSingle("010", true);
    giWait(0.3);
    giSetPortrait("205A", false);
    giTalk("？？：你叫云天河？你爹可是云天青？！", "40947");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：对啊，你认识我爹？", "40948");
    giSetPortrait("101A", true);
    giTalk("云天河：（看来他不当老大好多年，都胖成这样了……）", "40949");
    giNpcDoAction("MN004", "C08", 1, false);
    giSetPortrait("205A", false);
    giTalk("？？：当然！老夫柳世封，乃是受过你爹恩惠之人！", "40950");
    giNpcEndAction("MN004", true);
    giNpcDoAction("MN004", "J01", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：来来来，贤侄进屋再说，我已经吩咐下去准备饭菜，一定要好好招待你。", "40951");
    giSetPortrait("101C", true);
    giTalk("云天河：……咸枝？是叫我吗？", "40952");
    giSetPortrait("205A", false);
    giTalk("柳世封：哈哈，自然如此，你若不嫌弃，可以喊我一声“柳伯伯”～", "40953");
    giSetPortrait("101D", true);
    giTalk("云天河：柳波波？", "40954");
    giNpcDoAction("MN004", "C08", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：嗯，好！好！", "40955");
    giSetPortrait("205A", false);
    giTalk("柳世封：来！<colour red=255 green=187 blue=0 alpha=255>随我进屋吧，</colour><dc0>怎好叫客人一直站着。</dc0>", "40956");
    giNpcEndAction("MN004", true);
    giCameraRunSingle("011", false);
    giNpcWalkTo("MN004", 113.7995, -0.6711, 511.4174, false);
    giWait(1.6);
    giCameraRunSingle("012", true);
    giWait(0.7);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：柳波波？……", "40957");
    giSetNpcVisible("MN004", false);
    giFlashOutBlack(1.5, true, true);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerCurrentSetVisible(true);
    giSetNpcVisible("MN002", false);
    giSetNpcVisible("MN003", false);
    giSetNpcVisible("4047", true);
    giSetNpcVisible("4048", true);
    global_mvar = 21901; // 0x0000558D, 第一章 / 2-3-1.礼请天河 / 应邀去前厅
    giSetObjectVisible("title06", true);
    giSetObjectVisible("title05", false);
    giIMMEnd();
    giPlayerCurrentSetPos(-2.6261, -0.6711, 518.1707);
    giPlayerCurrentSetAng(178.0);
    giCameraSetMode(0, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2005()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giEnableShadow(false);
    giPlayerSetLeader(0);
    giPlayerSetPos(0, -8.2648, 0.5644, 125.3706);
    giPlayerSetAng(0, 191.0);
    giSetNpcVisible("MN001", true);
    giSetNpcVisible("MN002", true);
    giCameraPrepare("MC001");
    giCameraRunSingle("002", true);
    giFlashInBlack(2.5, false);
    giPlayerWalkTo(0, -34.9396, 0.5644, 30.6207, false);
    giArenaReady();
    giPlayerEndMove(0);
    giWait(0.7);
    giSetPortrait("206A", false);
    giTalk("？？：这位便是云家的公子？！", "40958");
    giPlayerDoAction(0, "J14", 1, false);
    giNpcDoAction("MN002", "J01", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：哈哈，没错，我还以为又见着了多年前的云贤弟咧！", "40959");
    giNpcEndAction("MN002", true);
    giNpcSetDir("MN002", 55.0, true);
    giSetPortrait("205A", false);
    giTalk("柳世封：贤侄，这是我夫人阮慈，你喊她“柳伯母”就好。", "40960");
    giSetPortrait("101D", true);
    giTalk("云天河：柳波母……", "40961");
    giSetPortrait("101C", true);
    giTalk("云天河：（山下的人好像很喜欢帮别人乱取名字，自己的名字也都奇奇怪怪的……）", "40962");
    giNpcDoAction("MN001", "C08", 1, false);
    giSetPortrait("206A", false);
    giTalk("阮慈：哎，乖孩子～", "40963");
    giNpcEndAction("MN001", true);
    giNpcSetDir("MN001", 344.0, true);
    giSetPortrait("206A", false);
    giTalk("阮慈：你们一老一小，还不快入座，我马上命人上饭菜，不然可都要凉了。", "40964");
    giNpcSetDir("MN002", 160.0, true);
    giSetPortrait("205A", true);
    giTalk("柳世封：夫人说的甚是！", "40965");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：饭菜…………", "40966");
    giNpcSetDir("MN002", 51.0, true);
    giNpcSetDir("MN001", 33.0, false);
    giWait(0.6);
    giSetPortrait("205A", false);
    giTalk("柳世封：贤侄，先坐下吧～", "40967");
    giPlayerEndAction(0);
    giPlayerFaceToNpc(0, "MN002", true);
    giWait(0.5);
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101J", true);
    giTalk("云天河：柳波波，我身上的钱就这么多，都给你了！", "40968");
    giSetPortrait("205A", false);
    giTalk("柳世封：贤侄这是为何？！难道、难道你不爱吃炒菜，喜欢吃凉菜？！", "40969");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("101J", true);
    giTalk("云天河：我、我刚从山上下来没多久，菱纱说山下吃饭吃菜都要给钱的，不能白吃。", "40970");
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("206A", false);
    giTalk("阮慈：……傻孩子～那些卖东西给你的都是商人，自然要你的银钱，可我们不一样，我们是你爹的朋友，难道请你吃顿饭还收钱？", "40971");
    giNpcEndAction("MN001", false);
    giNpcDoAction("MN002", "C08", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：对对对，夫人说的甚是！莫说是几顿饭，就算你今后都在府上吃住，我们也是理应照顾的，何况说不准以后还变一家人！", "40972");
    giSetPortrait("101C", true);
    giTalk("云天河：……一家人？", "40973");
    giWait(0.3);
    giNpcSetDir("MN001", 344.0, true);
    giSetPortrait("206A", false);
    giTalk("阮慈：老爷……", "40974");
    giWait(0.5);
    giNpcDoAction("MN002", "C09", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：没什么、没什么，我们吃饭，哈哈，先吃饭！", "40975");
    giFlashOutBlack(1.5, true, true);
    giSetNpcVisible("MN001", false);
    giSetNpcVisible("MN002", false);
    giArenaLoad("Q03", "XN04Y", "", true);
    giPlayerLock();
    giScriptMusicPlay("P59", 2, 2.5, 2.5);
    giIMMBegin();
    giCameraSetCollide(false);
    giPlayerCurrentSetVisible(false);
    giSetNpcVisible("MN001", true);
    giSetNpcVisible("MN002", true);
    giSetNpcVisible("MN003", true);
    giSetObjectVisible("MO001", true);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giWait(0.5);
    giSetPortrait("101K", false);
    giTalk("云天河：……这个好吃，那个也不错，原来肉还有这种味道的，比烤的还香～这碗里一粒粒白白的东西，就是爹说过的“饭”啊，真好吃！", "40976");
    giWait(0.6);
    giCameraRunSingle("003", false);
    giSetPortrait("205A", false);
    giTalk("柳世封：唉！想不到云贤弟已经过世了，还是得了如此重病，连弟妹也一起……这、怎么会这样？！", "40977");
    giCameraWait();
    giWait(0.5);
    giSetPortrait("101B", false);
    giTalk("云天河：对了，柳波波，你能不能告诉我一些关于爹的事情？", "40978");
    giWait(0.7);
    giNpcWalkTo("MN001", -47.4195, 0.5644, -72.1895, true);
    giWait(0.1);
    giNpcSetDir("MN001", 64.0, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：当然！多年前幸亏云贤弟救我性命，不然我早成了路边枯骨。", "40979");
    giWait(0.5);
    giCameraRunSingle("004", true);
    giWait(0.3);
    giNpcDoAction("MN001", "J01", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：那时候我刚接任寿阳县令一职，走马上任，不想途中被人打劫，你爹路见不平、出手相助，还将那些强盗戏弄惩戒了一番！", "40980");
    giSetPortrait("205A", true);
    giTalk("柳世封：我们就此结识，兄弟相称，我想要他留在寿阳助我治理此地，但人各有志，你爹那时一心要成剑仙，几日后便离开了。", "40981");
    giCameraRunSingle("005", true);
    giWait(0.4);
    giSetPortrait("101B", false);
    giTalk("云天河：……有点难懂，反正我爹做了好事就对了～", "40982");
    giSetPortrait("101B", false);
    giTalk("云天河：（原来这位老大当年挺惨的，还打不过别人，难怪爹要出手帮忙。）", "40983");
    giSetPortrait("101B", false);
    giTalk("云天河：那后来呢？爹成了剑仙吗？", "40984");
    giCameraRunSingle("004", true);
    giWait(0.3);
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：惭愧！这我也不太清楚，你爹如此一去，数年没有音讯，直到有一天……", "40985");
    giSetPortrait("205A", true);
    giTalk("柳世封：他突然出现在我府中，怀抱一名女婴，托我把那孩子抚养长大，让她做个心地善良之人。我和夫人成亲后一直未有生养，自然十分乐意，你爹见我们答应下来，转眼便纵身去了。", "40986");
    giNpcDoAction("MN001", "J01", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：他向来行踪飘忽，不知何年何月能再相见，所以我命裴剑带了他的画像，一有机会便四处寻访，这才有今日的相聚呐。", "40987");
    giCameraRunSingle("006", true);
    giWait(0.5);
    giSetPortrait("101A", false);
    giTalk("云天河：哦……那我娘是什么样的人？", "40988");
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：这……别说我没见过，云贤弟连提都没提起过啊。", "40989");
    giWait(0.5);
    giNpcWalkTo("MN002", -8.4106, 0.5644, -23.2161, false);
    giSetPortrait("206A", true);
    giTalk("阮慈：看你们～我才离开一会儿，就只顾着说话了。", "40990");
    giNpcSetDir("MN001", 39.0, false);
    giNpcEndMove("MN002");
    giWait(0.4);
    giIMMBegin();
    giSetObjectVisible("MO002", true);
    giSetObjectVisible("MO003", true);
    giIMMEnd();
    giSetPortrait("101K", false);
    giTalk("云天河：这味道……是酒！！好香～～", "40991");
    giNpcSetDir("MN002", 132.0, true);
    giSetPortrait("206A", true);
    giTalk("阮慈：老爷说你爹最喜欢这“蜜酒”，我才想到地窖里藏了几瓶，也该拿出来喝了。", "40992");
    giNpcSetDir("MN001", 71.0, true);
    giWait(0.7);
    giSetPortrait("205A", true);
    giTalk("柳世封：对对对，贤侄多喝几杯！", "40993");
    giCameraRunSingle("007", true);
    giWait(0.3);
    giSetPortrait("101E", false);
    giTalk("云天河：不，我不喝，菱纱说酒不是好东西！", "40994");
    giSetPortrait("205A", true);
    giTalk("柳世封：哈哈哈，男子汉大丈夫，哪能不识酒味！贤侄不用担心，酒喝多了当然糟糕，但偶尔喝一点却没什么！", "40995");
    giSetPortrait("101E", false);
    giTalk("云天河：（怎么办……菱纱说不能喝，柳波波又说能喝，到底该听哪边的？）", "40996");
    giSetPortrait("101D", false);
    giTalk("云天河：爹喜欢这“蜜酒”？", "40997");
    giNpcDoAction("MN001", "J01", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：不错，这酒乃是用了上好的糯米，佐以酒药酿制而成，还加了蜂蜜，所以喝到嘴里香味醇厚，贤侄定要尝尝呐～", "40998");
    giSetPortrait("101B", false);
    giTalk("云天河：（味道这么香……不管了，爹爱喝就代表我能喝！）", "40999");
    giSetPortrait("101K", false);
    giTalk("云天河：那我喝啰～", "41000");
    giWait(0.5);
    giSetObjectVisible("MO003", false);
    giNpcDoAction("MN003", "J28", 1, true);
    giNpcDoAction("MN003", "J28", 1, false);
    giSetPortrait("101K", false);
    giTalk("云天河：好喝、好喝！比白水好喝多了！！", "41001");
    giNpcDoAction("MN003", "J27", 0, false);
    giSetObjectVisible("MO003", true);
    giCameraRunSingle("008", true);
    giWait(0.3);
    giSetPortrait("205A", false);
    giTalk("柳世封：哈哈，贤侄今后有何打算？", "41002");
    giSetPortrait("101F", true);
    giTalk("云天河：我？我要和菱纱一起去做剑仙，可以在天上飞来飞去～", "41003");
    giSetPortrait("206A", true);
    giTalk("阮慈：你和那位姑娘，你们认识很久了？", "41004");
    giSetPortrait("101F", false);
    giTalk("云天河：对啊，挺久的，都快两天了。", "41005");
    giSetPortrait("205A", false);
    giTalk("柳世封：嗯，是挺久的…………啊？！才两天？！", "41006");
    giSetPortrait("101F", true);
    giTalk("云天河：（……奇怪～头晕乎乎的……）", "41007");
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：唉！那姑娘的来历恐怕不单纯，数月前有樵夫看到一人在寿阳东北的陵墓附近鬼祟行事，十有八九是盗墓的贼人，我请那樵夫口述，再由小女画像，与你那朋友倒是极为貌似。", "41008");
    giSetPortrait("101F", true);
    giTalk("云天河：菱纱？贼？……", "41009");
    giSetPortrait("101F", true);
    giTalk("云天河：（……我晕……）", "41010");
    giSetPortrait("206A", true);
    giTalk("阮慈：那姑娘莫非是你的心上人？", "41011");
    giSetPortrait("101F", false);
    giTalk("云天河：心上人？不懂……她对我好，我当然对她好，她是我朋友。", "41012");
    giNpcDoAction("MN001", "J01", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：原来是朋友，如此甚好！如此甚好！哈哈哈～", "41013");
    giSetPortrait("205A", false);
    giTalk("柳世封：实不相瞒，这几年我一直很头疼，小女待字闺中，却难觅佳婿，如今见到贤侄相貌人品出众，不妨和小女见上一面，若是你们彼此有意，倒是美事一桩、美事一桩呐！", "41014");
    giSetPortrait("101F", true);
    giTalk("云天河：（……咦？柳波波怎么变、变两个了…………）", "41015");
    giSetPortrait("205A", false);
    giTalk("柳世封：贤侄觉得如何？", "41016");
    giSetPortrait("101L", true);
    giTalk("云天河：……什么？", "41017");
    giSetPortrait("205A", false);
    giTalk("柳世封：我与云贤弟、与贤侄都是一见如故，若是你能成为柳家的女婿，那真是再好不过了！", "41018");
    giSetPortrait("101L", true);
    giTalk("云天河：好……好…………晕…………", "41019");
    giNpcDoAction("MN001", "J01", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：好！太好了，贤侄既然说好，我真是太高兴了，哈哈哈～", "41020");
    giSetPortrait("101L", true);
    giTalk("云天河：呃……", "41021");
    giIMMBegin();
    gi2DSoundPlay("WJ064", 1);
    giNpcDoAction("MN003", "J29", 0, false);
    giIMMEnd();
    giWait(1.0);
    giSetPortrait("205A", false);
    giTalk("柳世封：贤侄？！", "41022");
    giNpcSetDir("MN002", 217.0, false);
    giCameraRunSingle("009", true);
    giWait(0.6);
    giSetPortrait("206A", false);
    giTalk("阮慈：你啊，我看天河早醉了，就你还一个劲唠唠叨叨。", "41023");
    giNpcSetDir("MN001", 36.0, true);
    giNpcDoAction("MN001", "J01", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：哈哈，他的酒量可比他爹差远了。", "41024");
    giNpcEndAction("MN001", false);
    giNpcDoAction("MN002", "C09", 1, false);
    giSetPortrait("206A", false);
    giTalk("阮慈：唉，老爷别高兴得太早，你这样给璃儿配夫婿，依她的性子肯定不悦，何况天河对那位菱纱姑娘颇有情意，怕不会随随便便转了心思。", "41025");
    giSetPortrait("205A", true);
    giTalk("柳世封：夫人此话怎讲？！他们不只是朋友吗？", "41026");
    giSetPortrait("206A", false);
    giTalk("阮慈：这种事情，你们男人粗枝大叶当然看不出来，可小儿女的心思，哪有这么简单？", "41027");
    giSetPortrait("205A", true);
    giTalk("柳世封：这……你我百年之后，璃儿她无人照顾，又该怎么办！", "41028");
    giSetPortrait("206A", false);
    giTalk("阮慈：儿孙自有儿孙福，老爷又何必太过担心？", "41029");
    giNpcDoAction("MN001", "J01", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：还有一事，裴剑和我形容日间的情形，贤侄老实木讷，那韩姑娘却是古灵精怪，若真像夫人所说，二人怎么看也并非良配啊！", "41030");
    giNpcEndAction("MN001", false);
    giNpcDoAction("MN002", "C09", 1, false);
    giSetPortrait("206A", false);
    giTalk("阮慈：依我之见，老爷是多虑了，天河这孩子外表朴实，实则心如明镜，识人处事自有他的原则。 ", "41031");
    giSetPortrait("205A", true);
    giTalk("柳世封：但愿如此——", "41032");
    giWait(0.4);
    giSetPortrait("101G", false);
    giTalk("云天河：……爹……", "41033");
    giWait(0.5);
    giIMMBegin();
    giCameraRunSingle("008", false);
    giNpcSetAng("MN001", 77.0);
    giNpcSetAng("MN002", 132.0);
    giIMMEnd();
    giWait(1.2);
    giSetPortrait("101G", true);
    giTalk("云天河：……爹…………娘……", "41034");
    giNpcDoAction("MN002", "C09", 1, false);
    giSetPortrait("206A", true);
    giTalk("阮慈：可怜的孩子，一定是想他爹娘了……", "41035");
    giSetPortrait("205A", false);
    giTalk("柳世封：唉～是啊，一个人孤苦无依地住在山上，真是难为他了……", "41036");
    giSetPortrait("101G", true);
    giTalk("云天河：……爹……", "41037");
    giWait(1.0);
    giFlashOutBlack(1.5, true, true);
    giIMMBegin();
    giSetNpcVisible("MN001", false);
    giSetNpcVisible("MN002", false);
    giSetNpcVisible("MN003", false);
    giSetObjectVisible("MO001", false);
    giSetObjectVisible("MO002", false);
    giSetObjectVisible("MO003", false);
    giIMMEnd();
    giArenaLoad("Q03", "XN03Y", "", true);
    giPlayerLock();
    giIMMBegin();
    giCameraSetCollide(false);
    giPlayerCurrentSetVisible(false);
    giIMMEnd();
    giPlayerCurrentSetPos(-3.0558, -0.2, -3.1163);
    giPlayerCurrentSetAng(354.0);
    giPlayerSetPos(1, 23.701, -0.2, 47.2992);
    giPlayerSetAng(1, 217.0);
    giPlayerSetVisible(1, true);
    giSetNpcVisible("MN001", true);
    giNpcSetEmotion("MN001", "101_by");
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.0, false);
    giArenaReady();
    gi2DSoundPlay("WJ016", 1);
    gi2DSoundPlay("WJ024", 0);
    giWait(3.5);
    giCameraRunSingle("002", true);
    giWait(1.0);
    giCameraRunSingle("003", false);
    giPlayerWalkTo(1, -25.5408, -0.2, -19.949, true);
    giCameraWait();
    giWait(0.8);
    giCameraRunSingle("004", false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：真气人……我在牢里吃干烧饼，找这地方又累得半死才找到，你却吃饱睡好，快活着呢……", "41038");
    giCameraWait();
    giCameraRunSingle("001", true);
    giSetPortrait("101L", true);
    gi2DSoundStop();
    giTalk("云天河：……唔……死猪妖哪里跑！！……", "41039");
    giSetPortrait("103I", false);
    giTalk("韩菱纱：还猪妖？！我看你是猪头差不多，起来！", "41040");
    giWait(0.5);
    giSetPortrait("101L", true);
    giTalk("云天河：……猪妖？……不对，是菱纱的声音？", "41041");
    giNpcResetEmotion("MN001");
    giWait(1.2);
    giCameraRunSingle("005", true);
    giWait(0.3);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：哼，终于醒啦。", "41042");
    giNpcSetDir("MN001", 31.0, true);
    giNpcDoAction("MN001", "C10", 0, false);
    giWait(1.0);
    giCameraRunSingle("006", true);
    giWait(0.3);
    giSetPortrait("101D", true);
    giTalk("云天河：那些人，让你走了？", "41043");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：小小一间破牢房哪困得住我？不过是想等夜里再行动，懒得和官府起冲突。", "41044");
    giPlayerEndAction(1);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：你呢？有没有打听到你爹的事情？", "41045");
    giSetPortrait("101K", true);
    giTalk("云天河：有啊，那个柳波波说他以前被爹救过，他想和爹一起玩，但是爹想当剑仙，就离开了，后来还送了个女儿给他。柳波波也没见过我娘。", "41047");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：那个“女儿”又是怎么回事？你们见过面了？", "41048");
    giSetPortrait("101B", true);
    giTalk("云天河：柳波波说我爹把一个女孩送给他，人就不见了。", "41049");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：……什么乱七八糟的，听上去都是不太管用的消息。", "41050");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：既然这样，我们还不如快点赶去陈州呢——", "41051");
    giPlayerDoAction(1, "J02", 1, false);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：咦？什么味儿？……你、你喝酒了？！", "41052");
    giSetPortrait("101B", true);
    giTalk("云天河：呵呵，一点点而已，柳波波说没关系的～", "41053");
    giSetPortrait("101B", true);
    giTalk("云天河：对了，我当时晕乎乎的，柳波波好像还让我做他们家的女须，什么意思？", "41054");
    giCameraRunSingle("007", true);
    giWait(0.3);
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：大傻瓜，喝酒误事，说你不听，哪天——", "41055");
    giPlayerDoAction(1, "J02", -1, false);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：等等！！女婿？……女婿？！你答应他了？！", "41056");
    giSetPortrait("101A", true);
    giTalk("云天河：我？我不记得了……", "41057");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：可恶！我们尽快离开这儿，这柳家真是莫名其妙，连你这种山顶野人都要收作女婿，说不定他女儿比你大上十岁八岁，早已经徐娘半老了！", "41058");
    giSetPortrait("101C", true);
    giTalk("云天河：唔……菱纱，什么叫“贼”啊？", "41059");
    giPlayerDoAction(1, "J01", -1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：什么？！你哪里听来的？！是那个柳大人说的对不对？他说我是偷东西的小贼？！", "41060");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101A", true);
    giTalk("云天河：是、是啊，他讲的时候还一副不高兴的样子……", "41061");
    giSetPortrait("103F", false);
    giTalk("韩菱纱：胡说！我韩家子孙习风水堪舆、通机关巧槛，世世代代都是独行千里的陵墓大盗，又哪里是白痴小毛贼可以相提并论的？", "41062");
    giPlayerDoAction(1, "J17", -1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：以后不许说我是贼，不然我翻脸了！", "41063");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101C", true);
    giTalk("云天河：哦……那你去我爹娘的墓，是……", "41064");
    giPlayerDoAction(1, "J04", -1, false);
    giSetPortrait("103G", false);
    giTalk("韩菱纱：…………我、我上山是为了找剑仙的宝物，绝对没有冒犯他们的意思，墓室毁了我也很抱歉，所以现在要将功补过，帮忙找你爹娘的消息……", "41065");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101B", true);
    giTalk("云天河：呵呵，还是你对我好。", "41066");
    giSetPortrait("103G", false);
    giTalk("韩菱纱：什、什么啊，一个大男生讲这种话也不害臊……还有……你要在床上坐多久！起床走了啦！", "41067");
    giWait(0.3);
    giPlayerWalkTo(1, 25.7018, -0.2, 77.7997, false);
    giWait(0.5);
    giSetPortrait("101B", true);
    giTalk("云天河：哦……", "41068");
    giWait(0.4);
    giPlayerInTeam(1, true);
    giWait(2.0);
    giSetFullHP();
    giSetFullMP();
    giFlashOutBlack(1.5, true, true);
    giPlayerEndMove(1);
    giIMMBegin();
    giPlayerSetVisible(1, false);
    giPlayerCurrentSetVisible(true);
    giSetNpcVisible("MN001", false);
    global_mvar = 22100; // 0x00005654, 第一章 / 2-3-2.礼请天河 / 离开柳府
    giEnableShadow(true);
    giIMMEnd();
    giCameraSetMode(3, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2006()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giPlayerCurrentSetVisible(false);
    giSetNpcVisible("MN001", true);
    giCameraPrepare("MC002");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giWait(1.0);
    giCameraRunSingle("002", false);
    giSetPortrait("101B", true);
    giTalk("云天河：（呵呵，柳波波的女儿夸我爹是大英雄～她是好人。）", "41169");
    giSetPortrait("101A", true);
    giTalk("云天河：（……菱纱老爱生气，爹常说我让他生气，容易伤肝，这样不好，我得和她说说……）", "41170");
    giSetPortrait("101A", true);
    giTalk("云天河：（……睏了……今天的饭菜真香……真是好吃……）", "41171");
    giWait(0.6);
    giNpcSetEmotion("MN001", "101_by");
    giWait(0.6);
    giFlashOutBlack(2.0, true, true);
    gi2DSoundPlay("WJ032", 1);
    giSetNpcVisible("MN001", false);
    giNpcResetEmotion("MN001");
    giArenaLoad("Q03", "XN03", "", false);
    giPlayerLock();
    giCameraSetCollide(false);
    giPlayerSetLeader(0);
    giPlayerCurrentSetVisible(true);
    giPlayerCurrentSetPos(-16.3966, -0.2, -17.5171);
    giPlayerCurrentSetAng(0.0);
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.5, false);
    giArenaReady();
    giSetPortrait("101B", true);
    giTalk("云天河：唔～睡得好沉，真舒服。", "41172");
    giSetPortrait("101B", true);
    giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>不晓得菱纱起床没有，去找她～</colour>", "41173");
    giWait(0.5);
    giSetFullHP();
    giSetFullMP();
    giFlashOutBlack(1.5, true, true);
    giPlayerEndMove(1);
    global_mvar = 30101; // 0x00007595, 第一章 / 2-4-2.迷香梦绕 / 去找菱纱
    giCameraSetMode(3, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2007()
{
    if (global_mvar == 30101 /* 第一章 / 2-4-2.迷香梦绕 / 去找菱纱 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetLeader(0);
        giPlayerSetPos(0, 966.2044, -0.6711, 679.3654);
        giPlayerSetAng(0, 145.0);
        giPlayerSetVisible(0, true);
        giNpcSetPos("MN002", 1015.7386, -0.6711, 608.0494);
        giNpcSetAng("MN002", 119.0);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("4048", false);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("002", true);
        giFlashInBlack(1.5, false);
        giWait(1.2);
        giSetPortrait("101B", false);
        giTalk("云天河：喂，你……知不知道菱纱在哪？带我去找她行吗？", "41174");
        giNpcSetDir("MN002", 322.0, false);
        giCameraRunSingle("002", true);
        giWait(0.2);
        giTalk("禄蓉：啊，是未来的姑爷……", "41175");
        giTalk("禄蓉：不对、不对，是云公子，<colour red=255 green=187 blue=0 alpha=255>老爷请你睡醒后去前厅，</colour><dc0>我家小姐和韩姑娘都已经等在那里了。</dc0>", "41176");
        giTalk("禄蓉：禄蓉就先告退了～", "41177");
        giNpcWalkTo("MN002", 982.6982, -0.6711, 522.1938, false);
        giWait(1.2);
        giPlayerSetDir(0, 189.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：（……干嘛这么急，我还没问<colour red=255 green=187 blue=0 alpha=255>前厅</colour><dc0>是哪里……）</dc0>", "41178");
        giSetPortrait("101C", false);
        giTalk("云天河：（算了，边走边找，总能找到。）", "41179");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giIMMBegin();
        global_mvar = 30200; // 0x000075F8, 第一章 / 2-4-3.迷香梦绕 / 前厅议事
        giPlayerCurrentSetPos(896.8875, -0.6711, 524.8091);
        giPlayerCurrentSetAng(186.0);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("4048", true);
        giSetObjectVisible("title05", false);
        giCameraSetMode(0, true);
        giIMMEnd();
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2008()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, -14.1693, 0.5644, 100.5444);
    giPlayerSetAng(0, 172.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 25.0683, 0.5644, -35.7145);
    giPlayerSetAng(1, 272.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, 2.5843, 0.5644, -58.9558);
    giPlayerSetAng(2, 280.0);
    giPlayerSetVisible(2, true);
    giNpcSetPos("MN001", -58.6219, 0.5644, -8.7411);
    giNpcSetAng("MN001", 157.0);
    giSetNpcVisible("MN001", true);
    giNpcSetPos("MN002", -41.6852, 0.5644, -52.9684);
    giNpcSetAng("MN002", 61.0);
    giSetNpcVisible("MN002", true);
    giSetObjectVisible("MO001", true);
    giSetObjectVisible("MO002", true);
    giIMMEnd();
    giCameraPrepare("MC002");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giWait(1.0);
    giIMMBegin();
    giNpcSetDir("MN002", 19.0, false);
    giPlayerSetDir(1, 344.0, false);
    giPlayerSetDir(2, 3.0, false);
    giNpcSetDir("MN001", 20.0, false);
    giIMMEnd();
    giWait(2.0);
    giNpcDoAction("MN002", "J01", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：哈哈，贤侄～来得正好，我们正要向韩姑娘说女萝岩之事，你也听听。", "41180");
    giNpcEndAction("MN002", true);
    giSetPortrait("101B", true);
    giTalk("云天河：哦，好……", "41181");
    giWait(0.6);
    giIMMBegin();
    giNpcSetDir("MN002", 61.0, false);
    giPlayerSetDir(1, 252.0, false);
    giPlayerSetDir(2, 284.0, false);
    giNpcSetDir("MN001", 177.0, false);
    giIMMEnd();
    giCameraRunSingle("002", true);
    giWait(0.8);
    giNpcDoAction("MN002", "C09", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：说来惭愧，我初来寿阳时，治理无方，此地百姓虽不至困顿潦倒，却也绝非大有余钱，行商买卖之人更是少之又少……", "41182");
    giSetPortrait("206A", true);
    giTalk("阮慈：老爷何必耿耿于怀，尽人事而后听天命，璃儿后来帮了寿阳百姓，不也是一种福缘吗？", "41183");
    giNpcDoAction("MN002", "J01", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：夫人说的甚是！多亏璃儿巧手，把山上的“离香草”做成熏香，从此各地商贩争相竞买，连京城里的贵人都对这种香赞不绝口，寿阳也才有了今日的富庶。", "41184");
    giPlayerSetPos(0, -53.542, 0.5644, 46.6676);
    giPlayerSetAng(0, 235.0);
    giSetPortrait("101M", true);
    giTalk("云天河：唔……这样很、很好啊……和妖、唔……怪有什么相干？", "41185");
    giPlayerDoAction(0, "J22", 0, false);
    giWait(0.5);
    gi2DSoundPlay("WJ039", 0);
    giIMMBegin();
    giNpcSetDir("MN002", 355.0, false);
    giPlayerSetDir(1, 320.0, false);
    giPlayerSetDir(2, 332.0, false);
    giNpcSetDir("MN001", 12.0, false);
    giIMMEnd();
    giCameraRunSingle("003", true);
    giWait(0.8);
    giPlayerDoAction(1, "J01", -1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：笨蛋！不要边吃东西边说话！", "41186");
    giSetPortrait("103F", false);
    giTalk("韩菱纱：还有那糕点，你从哪里拿的？太没礼貌了吧！", "41187");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giNpcSetDir("MN001", 95.0, true);
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("206A", true);
    giTalk("阮慈：没关系、没关系，这桌上的核桃糕原本就是留给天河的。", "41188");
    giNpcEndAction("MN001", true);
    giNpcSetDir("MN001", 12.0, true);
    giSetPortrait("206A", false);
    giTalk("阮慈：慢慢吃，小心别噎着。", "41189");
    giPlayerDoAction(0, "C01", 0, false);
    gi2DSoundStop();
    giWait(0.65);
    giPlayerFaceToNpc(0, "MN001", true);
    giWait(0.4);
    giSetPortrait("101K", true);
    giTalk("云天河：唔，这个好吃，我正好肚子咕咕叫了～", "41190");
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（……丢脸，真想当作不认识他……算了，当他不存在好了……）", "41191");
    giWait(0.7);
    giIMMBegin();
    giCameraRunSingle("002", false);
    giNpcSetAng("MN002", 70.0);
    giNpcSetAng("MN001", 105.0);
    giPlayerSetAng(1, 231.0);
    giPlayerSetAng(2, 39.0);
    giIMMEnd();
    giWait(0.5);
    giPlayerDoAction(2, "C07", -1, false);
    giSetPortrait("106A", true);
    giTalk("柳梦璃：<colour red=255 green=187 blue=0 alpha=255>寿阳西北面的女萝岩</colour><dc0>盛产离香草，城里人多半都去那采摘，只是近半月女萝岩忽然有妖物频频伤人，如今没有人再敢接近了。</dc0>", "41192");
    giPlayerUnHoldAct(2);
    giPlayerEndAction(2);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：麻烦，财路断了，这可是大大不妙。", "41193");
    giSetPortrait("205A", true);
    giTalk("柳世封：老百姓心中慌恐，更是令人忧心……", "41194");
    giSetPortrait("106A", true);
    giTalk("柳梦璃：待云公子用完点心，我们就出发吧，这种事情总是越早解决越好。", "41195");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：那个傻瓜……根本不用理他嘛……事不宜迟，马上走就好了！", "41196");
    giNpcSetDir("MN002", 98.0, true);
    giSetPortrait("205A", true);
    giTalk("柳世封：这就要走了？璃儿，爹真是不放心你……", "41197");
    giIMMBegin();
    giPlayerSetDir(2, 283.0, false);
    giPlayerSetDir(1, 256.0, false);
    giNpcSetDir("MN001", 129.0, false);
    giIMMEnd();
    giWait(0.7);
    giSetPortrait("205A", true);
    giTalk("柳世封：你看，桌上这篮是爹嘱咐王厨娘做的点心，都是你平时爱吃的，要记得带上～", "41198");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（喂喂……老伯，我们可不是去踏青玩乐……）", "41199");
    giPlayerDoAction(2, "C09", 1, false);
    giSetPortrait("106A", false);
    giTalk("柳梦璃：爹，女儿心里记挂着事情，哪还有心情吃点心？不如等到一切解决之后，再慢慢品尝也不迟。", "41200");
    giPlayerSetAng(0, 151.0);
    giWait(0.3);
    giCameraRunSingle("003", false);
    giWait(0.4);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：你、你不吃啊？真可惜，不能浪费，那我带着吃好了——", "41201");
    giIMMBegin();
    giNpcSetDir("MN002", 355.0, false);
    giPlayerSetDir(1, 320.0, false);
    giPlayerSetDir(2, 332.0, false);
    giNpcSetDir("MN001", 12.0, false);
    giIMMEnd();
    giWait(1.0);
    giPlayerWalkTo(1, -29.8179, 0.5644, 0.292, true);
    giPlayerSetDir(1, 351.0, true);
    giPlayerDoAction(1, "J17", -1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：你！哼～就知道吃～吃～吃～", "41202");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerWalkTo(1, 14.3072, 0.5644, 149.9776, false);
    giWait(1.0);
    giIMMBegin();
    giPlayerSetDir(0, 37.0, false);
    giNpcSetDir("MN002", 18.0, false);
    giPlayerSetDir(2, 1.0, false);
    giNpcSetDir("MN001", 30.0, false);
    giIMMEnd();
    giWait(0.8);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101E", false);
    giTalk("云天河：又怎么了？菱纱真爱生气……不吃就不吃……", "41203");
    giPlayerSetDir(2, 284.0, true);
    giPlayerDoAction(2, "C07", -1, false);
    giSetPortrait("106A", false);
    giTalk("柳梦璃：爹、娘，不用挂念，我们会早去早回的。", "41204");
    giPlayerUnHoldAct(2);
    giPlayerEndAction(2);
    giIMMBegin();
    giNpcSetDir("MN002", 91.0, false);
    giNpcSetDir("MN001", 138.0, false);
    giIMMEnd();
    giWait(0.3);
    giPlayerDoAction(0, "C01", 1, true);
    giPlayerWalkTo(0, -0.6216, 0.5644, -18.5932, true);
    giPlayerSetDir(0, 227.0, true);
    giWait(0.5);
    giSetPortrait("205A", true);
    giTalk("柳世封：璃儿，你和天河，还有韩姑娘都要小心，万一情况不妙就跑，可不要逞强吃眼前亏。", "41205");
    giPlayerDoAction(0, "J18", 1, false);
    giSetPortrait("101K", false);
    giTalk("云天河：柳波波，你放心，我不怕妖怪的，就怕打不过它们……呵呵～～", "41206");
    giWait(0.4);
    giIMMBegin();
    giPlayerSetDir(2, 2.0, false);
    giNpcSetDir("MN002", 46.0, false);
    giNpcSetDir("MN001", 91.0, false);
    giIMMEnd();
    giWait(1.0);
    giPlayerDoAction(2, "C08", 1, false);
    giSetPortrait("106A", false);
    giTalk("柳梦璃：…………走吧。", "41207");
    giPlayerInTeam(2, true);
    giWait(2.5);
    giShowTutorial(19);
    giAddPlayerEquip(2, 3544);
    giAddPlayerEquip(2, 3606);
    giAddPlayerEquip(2, 3573);
    giAddPlayerEquip(2, 3636);
    giWait(2.0);
    giAddProperty(3096, 15, true);
    giWait(2.5);
    giAddProperty(3098, 15, true);
    giWait(2.5);
    giAddMoney(1000, true);
    giWait(2.5);
    giFlashOutBlack(1.0, true, true);
    giSetPlayerLevel(2, 11);
    giPlayerInTeam(1, false);
    giIMMBegin();
    giSetNpcVisible("MN002", false);
    giSetNpcVisible("MN001", false);
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    giSetObjectVisible("MO001", false);
    giSetObjectVisible("MO002", false);
    giIMMEnd();
    giArenaLoad("Q03", "Q03S", "", false);
    giPlayerLock();
    giCameraSetMode(0, true);
    giPlayerCurrentSetPos(92.1984, -13.783, -2041.1329);
    giPlayerCurrentSetAng(192.0);
    global_mvar = 30201; // 0x000075F9, 第一章 / 2-5-1.女萝平妖 / 北门出城
    giPlayerUnLock();
    giCameraSeekToPlayer();
    giFlashInBlack(2.0, false);
    giArenaReady();
}

void func2009()
{
    giPlayerLock();
    giScriptMusicPlay("P58", 0, 0.0, 2.5);
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, -38.3007, 0.5644, 58.5344);
    giPlayerSetAng(0, 155.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 12.0204, 0.5644, 32.2261);
    giPlayerSetAng(1, 210.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, -10.1402, 0.5644, -2.2068);
    giPlayerSetVisible(2, true);
    giNpcSetPos("MN001", 10.7953, 0.5644, -54.6274);
    giNpcSetAng("MN001", 343.0);
    giSetNpcVisible("MN001", true);
    giNpcSetPos("MN002", -25.247, 0.5644, -39.5061);
    giNpcSetAng("MN002", 26.0);
    giSetNpcVisible("MN002", true);
    giIMMEnd();
    giPlayerFaceToNpc(2, "MN002", true);
    giCameraPrepare("MC003");
    giCameraRunSingle("001", true);
    giWait(1.3);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giWait(1.0);
    giNpcDoAction("MN002", "J02", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：唉呀～爹的宝贝女儿，你可算回来了！有没有哪里受伤？是不是遇到了什么危险？", "41424");
    giSetPortrait("205A", false);
    giTalk("柳世封：唉，怪我这老糊涂，我越想越后悔，就不应该答应让你们去！", "41425");
    giPlayerDoAction(2, "C07", -1, false);
    giSetPortrait("106B", true);
    giTalk("柳梦璃：爹，您别这么担心，您看，什么事也没有，大家都好好的。", "41426");
    giPlayerUnHoldAct(2);
    giPlayerEndAction(2);
    giPlayerDoAction(1, "J13", -1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：对啊，闹妖怪的事也解决了，我们虽无太大功劳，总也有些苦劳～", "41427");
    giSetPortrait("103B", true);
    giTalk("韩菱纱：嘻嘻，县令大人你可要言而有信哦！别再让官差追着我跑了！", "41428");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("205A", false);
    giTalk("柳世封：这、这真是天大的好消息！可妖怪到底……", "41429");
    giPlayerDoAction(2, "C07", -1, false);
    giSetPortrait("106A", true);
    giTalk("柳梦璃：爹，当时情形容女儿慢慢说来，而且女儿也另有重要的事想告诉你和娘。", "41430");
    giPlayerUnHoldAct(2);
    giPlayerEndAction(2);
    giSetPortrait("206A", false);
    giTalk("阮慈：这倒难得～不如我们去璃儿房里谈。", "41431");
    giSetPortrait("206A", false);
    giTalk("阮慈：天河、韩姑娘也辛苦多时，想必累了，可以稍稍歇息一下。", "41432");
    giWait(0.3);
    giPlayerSetDir(2, 351.0, false);
    giNpcFaceToPlayer("MN002", 0, true);
    giWait(0.5);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：累？不会啊，比在山上打猎轻松多了，我还有使不完的力气呢！", "41433");
    giPlayerWalkTo(1, -9.2825, 0.5644, 49.0819, true);
    giPlayerDoAction(1, "J20", 1, false);
    giWait(0.2);
    gi2DSoundPlay("WJ012", 1);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：什么使不完的力气！你过来！", "41434");
    giPlayerEndAction(1);
    giPlayerWalkTo(1, 43.2323, 0.5644, 94.1996, false);
    giCameraRunSingle("002", false);
    giWait(0.6);
    giIMMBegin();
    giPlayerSetDir(0, 62.0, false);
    giPlayerSetDir(2, 43.0, false);
    giNpcSetDir("MN001", 19.0, false);
    giNpcFaceToPlayer("MN002", 1, false);
    giIMMEnd();
    giPlayerEndMove(1);
    giWait(0.6);
    giPlayerSetDir(1, 230.0, true);
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101E", false);
    giTalk("云天河：哦……", "41435");
    giPlayerEndAction(0);
    giPlayerWalkTo(0, 9.1747, 0.5644, 77.4679, true);
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：算我求你别那么活宝……别人一家子要说说话，你杵在那儿当烛台啊？", "41436");
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101E", false);
    giTalk("云天河：哦……", "41437");
    giPlayerEndAction(0);
    giPlayerSetDir(1, 203.0, true);
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：各位～不用管我们啦，我和天河先四处逛逛，你们慢慢聊。", "41438");
    giPlayerEndAction(1);
    giPlayerWalkTo(1, 26.7378, 0.5644, 146.1613, false);
    giWait(0.6);
    giPlayerSetDir(0, 28.0, true);
    giFlashOutBlack(1.0, true, true);
    gi2DSoundPlay("WJ025", 1);
    giWait(1.0);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    giSetNpcVisible("MN001", false);
    giSetNpcVisible("MN002", false);
    giIMMEnd();
    giArenaLoad("Q03", "Q03X", "", false);
    giPlayerLock();
    giIMMBegin();
    giCameraSetCollide(false);
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(0, -9.8486, -0.6711, 492.5124);
    giPlayerSetAng(0, 13.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 23.4851, -0.6711, 532.5013);
    giPlayerSetAng(1, 217.0);
    giPlayerSetVisible(1, true);
    giNpcSetPos("MN002", -205.0336, -0.6711, 438.7093);
    giNpcSetAng("MN002", 58.0);
    giSetNpcVisible("MN002", true);
    giSetNpcVisible("MN005", true);
    giSetObjectVisible("title06", false);
    giIMMEnd();
    giCameraPrepare("MC003");
    giCameraRunSingle("002", true);
    giFlashInBlack(1.0, false);
    giArenaReady();
    giWait(1.0);
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：菱纱，你要去哪玩？我们一起去～", "41439");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerDoAction(1, "J05", 1, false);
    giSetPortrait("103C", false);
    giTalk("韩菱纱：……不要。", "41440");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：怎么说我都是女孩子，也有一两个自己的小秘密，不能老和你粘在一块。", "41441");
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：小秘密？我不能知道吗？", "41442");
    giPlayerDoAction(1, "J14", -1, false);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：你找碴啊，都说是秘密了……", "41443");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：总之，你无聊的话，就自己去街上走走，或者<colour red=255 green=187 blue=0 alpha=255>在柳家逛逛</colour><dc0>，反正这里够大，风景又不错！</dc0>", "41444");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：嘻嘻，待会儿再见～", "41445");
    giPlayerDoAction(1, "J18", 1, false);
    giWait(0.8);
    giEffectPlayWithPlayer("HW_TH03.1", 1, 1);
    giWait(1.0);
    giPlayerSetVisible(1, false);
    giWait(0.4);
    giPlayerDoAction(0, "J34", 1, false);
    giSetPortrait("101E", true);
    giTalk("云天河：……咳咳……又是这招……", "41446");
    giWait(0.5);
    giTalk("禄翠：韩、韩姑娘不见了？！真的，“嘭”的一下就没了！", "41447");
    giPlayerSetDir(0, 253.0, false);
    giCameraRunSingle("003", true);
    giWait(0.3);
    giTalk("柳心：那肯定是仙法！小姐的朋友就是了不得！", "41448");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：…………", "41449");
    giFlashOutBlack(1.5, true, true);
    giPlayerOutTeam(1, false);
    giPlayerOutTeam(2, false);
    giPlayerEndAction(0);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerCurrentSetVisible(true);
    giSetNpcVisible("MN002", false);
    giSetNpcVisible("MN005", false);
    global_mvar = 31400; // 0x00007AA8, 第一章 / 2-5-7.女萝平妖 / 府中清闲
    giPlayerCurrentSetPos(-14.5456, -0.6711, 925.8619);
    giPlayerCurrentSetAng(7.0);
    giPlayerSetPos(2, 89.8405, 7.831, -978.6171);
    giPlayerSetAng(2, 325.0);
    giPlayerSetVisible(2, true);
    giNpcSetPos("MN002", 332.6761, -0.3236, -1061.1261);
    giNpcSetAng("MN002", 280.0);
    giSetNpcVisible("MN002", true);
    giSetObjectVisible("title06", true);
    giIMMEnd();
    giCameraSetMode(0, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giScriptMusicStop(2, 2.5);
    giPlayerUnLock();
}

void func2010()
{
    if (global_mvar == 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 450.5255, -0.3236, -1041.0148);
        giPlayerSetAng(0, 223.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(2, 89.8405, 7.831, -978.6171);
        giPlayerSetAng(2, 325.0);
        giPlayerSetVisible(2, true);
        giNpcSetPos("MN002", 409.4262, -0.3235, -1082.4403);
        giNpcSetAng("MN002", 54.0);
        giSetNpcVisible("MN002", true);
        giIMMEnd();
        giCameraPrepare("MC004");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giTalk("禄蓉：咦？是未来的姑爷呀？", "41450");
        giTalk("禄蓉：小姐正在亭子里呢，好像有什么烦心事，您可要想想法子哄她开心～", "41451");
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：我？我去？", "41452");
        giTalk("禄蓉：是呀，当然要姑爷去才行，嘻！", "41453");
        giNpcWalkTo("MN002", 633.4008, -0.3235, -1047.2395, false);
        giWait(1.2);
        giPlayerSetDir(0, 93.0, true);
        giPlayerDoAction(0, "J14", 1, true);
        giWait(0.5);
        giPlayerSetDir(0, 255.0, false);
        giWait(1.3);
        giCameraRunSingle("002", true);
        giPlayerSetPos(0, 463.47, -0.3236, -1121.2697);
        giPlayerSetAng(0, 282.0);
        giPlayerWalkTo(0, 242.4848, -0.267, -1066.1571, true);
        giPlayerSetDir(0, 291.0, true);
        giScriptMusicPlay("P25", 2, 0.0, 0.0);
        giWait(0.5);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：是云公子？", "41454");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101F", false);
        giTalk("云天河：啊！是我。", "41455");
        giWait(0.3);
        giPlayerSetDir(2, 152.0, false);
        giCameraRunSingle("004", true);
        giPlayerEndAction(0);
        giPlayerWalkTo(0, 118.7897, 7.7569, -1031.0144, true);
        giPlayerSetDir(0, 332.0, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101F", false);
        giTalk("云天河：唔……刚才那女孩，说你不高兴……", "41456");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：别听她的，禄蓉这丫头就喜欢添油加醋，我只是想到要和爹娘分开那么久，有点不习惯……", "41457");
        giPlayerEndAction(2);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：对了，爹和娘答应我了，以后我就能跟着云公子、还有菱纱四处游历～", "41458");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101F", false);
        giTalk("云天河：那……那真是太好了……", "41459");
        giSetPortrait("101F", false);
        giTalk("云天河：你，很想当剑仙吗？", "41460");
        giWait(0.3);
        giCameraRunSingle("005", true);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：……从小到大，我都在这个府邸里，过了一天又一天，可有的时候，我也会想知道自己究竟从哪里来，发生过什么……", "41461");
        giPlayerEndAction(2);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：在我的脑海里总闪过一些奇异的景象，说不定……说不定到了外面，就能找到什么线索…… ", "41462");
        giPlayerEndAction(2);
        giSetPortrait("101C", false);
        giTalk("云天河：我爹……他什么都没说吗？", "41463");
        giSetPortrait("106B", true);
        giTalk("柳梦璃：云叔肯定有他的理由，或许连他也不知道呢。再说，爹和娘都很疼我，能遇上他们，我已是天底下最幸运的人了。", "41464");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：嗯！你、你说的对！", "41465");
        giSetPortrait("101B", false);
        giTalk("云天河：柳波波他们是好人～我说不上来，不过像你们这样一直在一起，也挺不错的。", "41466");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：……如果你愿意，也可以把他们当成你的爹娘……我听说，你娘也是很早就过世了……", "41467");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：啊？不用不用！", "41468");
        giSetPortrait("101H", false);
        giTalk("云天河：我是说……我不能抢走你的爹娘，还有啊，我要是喊别人作“爹”，老爹说不定真要气歪了！", "41469");
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106C", true);
        giTalk("柳梦璃：嘻，云叔哪有你说的那么凶。", "41470");
        giCameraRunSingle("004", true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101F", false);
        giTalk("云天河：……梦、梦璃，我能问你一件事吗？", "41471");
        giSetPortrait("106D", true);
        giTalk("柳梦璃：嗯？ ", "41472");
        giSetPortrait("101A", false);
        giTalk("云天河：柳波波他总是喊我“咸枝”，还有这里的女孩叫我“姑爷”，我都不明白是怎么一回事，你知道吗？", "41473");
        giSetPortrait("106E", true);
        giTalk("柳梦璃：贤芝……贤侄？", "41474");
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：云公子，云叔教过你读书写字吗？", "41475");
        giSetPortrait("101B", false);
        giTalk("云天河：爹教过一些，他还留了几本书给我念，呵呵，不过烤肉的时候为了生火方便，差不多都烧掉了。", "41476");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：这么说来，你只是不晓得哪些字该对上哪些意思，以后我找时间慢慢告诉你吧～", "41477");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：好、好啊！我多学点，也省得菱纱老说会被我气死，哈哈～", "41478");
        giPlayerEndAction(0);
        giCameraRunSingle("005", true);
        giWait(0.3);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：…………至于“姑爷”……那是丫头们闹着玩的，别理她们～她们大概听了我爹的话，以为我和云公子要成亲呢。", "41479");
        giSetPortrait("101A", false);
        giTalk("云天河：成亲？啥意思？", "41480");
        giSetPortrait("106B", true);
        giTalk("柳梦璃：……简单些说，假如有个女孩子看着你心里舒坦，便会想要嫁给你，从今往后两个人一生一世都厮守在一起，永远也不分离。 ", "41481");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101F", false);
        giTalk("云天河：哦～听起来……还挺不错的，呵呵。可是……那个……连、连去茅房都要一起，不太好吧？", "41482");
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106C", true);
        giTalk("柳梦璃：…………噗～～云公子真是有趣。", "41483");
        giPlayerEndAction(2);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：时候也不早了，我还有事要出府一趟，明日再见吧，到时有件东西要送给云公子呢。", "41484");
        giSetPortrait("101K", false);
        giTalk("云天河：送我东西？真的吗？！是什么？ ", "41485");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106C", true);
        giTalk("柳梦璃：秘密～云公子见了便知。", "41486");
        giPlayerEndAction(2);
        giPlayerWalkTo(2, 250.3247, -0.1346, -1040.7552, false);
        giCameraRunSingle("006", true);
        giWait(1.3);
        giPlayerSetDir(0, 84.0, true);
        giPlayerEndMove(2);
        giWait(1.0);
        giPlayerSetDir(2, 268.0, true);
        giWait(0.3);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：云公子……有件事我还想要谢谢你。", "41487");
        giSetPortrait("101D", false);
        giTalk("云天河：啊？什么？", "41488");
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：你对那两个人说，女萝岩里没有妖怪，我……很谢谢你愿意帮槐米他们。", "41489");
        giPlayerEndAction(2);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101F", false);
        giTalk("云天河：那也没什么……", "41490");
        giPlayerEndAction(0);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：云公子你是个好人，让我想起云叔……你们都有一副好心肠……", "41491");
        giWait(1.0);
        giPlayerWalkTo(2, 365.7082, -0.3235, -1082.9596, false);
        giWait(1.2);
        giSetPortrait("101A", false);
        giTalk("云天河：（奇怪，怎么女孩子都有秘密……）", "41492");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P24", 2, 2.5, 0.0);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：哈哈，情意绵绵的，我可全听见了！！", "41493");
        giIMMBegin();
        giPlayerSetPos(1, 42.7339, 31.7408, -1003.2098);
        giPlayerSetAng(1, 112.0);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("MN002", false);
        giIMMEnd();
        giPlayerSetDir(0, 279.0, false);
        giCameraRunSingle("007", true);
        giWait(0.3);
        giSetPortrait("101C", true);
        giTalk("云天河：…………", "41494");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：无聊～看我突然出现，你都不会吓一跳，连眉毛都不动。", "41495");
        giCameraRunSingle("008", true);
        giWait(0.3);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：我爹说过，男子汉立世无所畏惧，没什么好怕的。", "41496");
        giIMMBegin();
        giPlayerSetPos(1, 52.7687, 7.831, -1007.2184);
        giPlayerSetAng(1, 112.0);
        giIMMEnd();
        giWait(0.3);
        giCameraRunSingle("009", true);
        giWait(0.4);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：好啦好啦，开个玩笑嘛，干嘛严肃得像根木头……", "41497");
        giSetPortrait("103M", false);
        giTalk("韩菱纱：我问你，你真的想好了？要和梦璃一起去求仙？", "41498");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：和她一起？呵呵，好、好啊……", "41499");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（……一脸白痴相，想到哪里去了……）", "41500");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：说真的，像梦璃这样，虽然不清楚自己的身世，可是养父母待她那么好，还真让人有点羡慕呢……可惜不是人人都有这种福气。", "41501");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：唉，她好歹也是个千金大小姐，不知对江湖上的事了解多少……", "41502");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101B", true);
        giTalk("云天河：……？", "41503");
        giSetPortrait("103J", false);
        giTalk("韩菱纱：她对妖怪的态度跟你一个样子，真是有趣。", "41504");
        giCameraRunSingle("010", true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：好像是吧，哈哈……", "41505");
        giSetPortrait("103J", false);
        giTalk("韩菱纱：一个从小到大都在山顶当野人，一个从小到大都在家里当千金大小姐，想法又差不多，难怪要你当“姑爷”呀！哼！", "41506");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：哈哈……", "47007");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：就知道哈哈哈傻笑……", "41507");
        giPlayerEndAction(1);
        giPlayerWalkTo(1, 76.6396, 7.831, -1013.099, false);
        giCameraRunSingle("009", true);
        giPlayerEndMove(1);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：但是不管怎么说，她也比你这种初次见面，因为人家貌美就断定她是好人的笨家伙要强！", "41508");
        giSetPortrait("103J", false);
        giTalk("韩菱纱：哼哼，色心不死，小心以后桃花劫要你小命！", "41509");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：逃花？不是啊，我是因为梦璃没有杀气，院子里那些怪物也没有，才知道她不是坏人。", "41510");
        giSetPortrait("103J", false);
        giTalk("韩菱纱：嘻嘻，我还香气臭气呢，少拿这么玄的东西来唬人。", "41511");
        giSetPortrait("101B", true);
        giTalk("云天河：真的！就像山上的黑熊，没杀气时不会伤人，但是万一被激怒，十几步之外都能听见磨牙和喘气声。", "41512");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（……说什么呢，人又不是熊，哪来的磨牙和喘气声……）", "41513");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：菱纱，你、你不喜欢梦璃吗？", "41514");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：没有啊，干嘛突然这么问？", "41515");
        giSetPortrait("101C", true);
        giTalk("云天河：没、没什么。", "41516");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P49", 2, 0.0, 0.0);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……", "41517");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……我……", "41518");
        giSetPortrait("101C", true);
        giTalk("云天河：怎么了？", "41519");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：…………我没有不喜欢她。", "41520");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：其实……谁喜欢谁，又讨厌谁，这种事情真有那么重要吗？ ", "41521");
        giSetPortrait("101D", true);
        giTalk("云天河：什么？", "41522");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：……虽然世上的人千千万万，可每个人都是孤伶伶地来，又孤伶伶地去，没有其他任何人是可以依靠和作伴的。", "41523");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：再真挚的感情、再深沉的牵挂，还是会有分开的一天，好像你爹和你娘，到头来又怎么抵得过生死离别……", "41524");
        giCameraRunSingle("011", true);
        giCameraRunSingle("012", false);
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：…………不是……你说的不对，虽然我讲不出来，可不应该是这样的……", "41525");
        giSetPortrait("103H", false);
        giTalk("韩菱纱：…………", "41526");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……哼，你这家伙，下山才多久，倒学会数落我了！", "41527");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：我觉得……有时候你好像不是菱纱……不……像是另外一个菱纱……", "41528");
        giSetPortrait("103D", false);
        giTalk("韩菱纱：你！…………", "41529");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：什么这个那个，我又不是妖怪，还会变来变去。", "41530");
        giPlayerEndAction(1);
        giSetPortrait("101E", true);
        giTalk("云天河：话是这么说没错，但是……", "41531");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：少啰嗦，就凭你这种木鱼脑袋，想太多搞不好会突然爆掉，先管好自己吧！", "41532");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：知道了……", "41533");
        giPlayerEndAction(0);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：我回房了，<colour red=255 green=187 blue=0 alpha=255>你也早点去休息，</colour><dc0>明天赶路去陈州可是很辛苦的！</dc0>", "41534");
        giPlayerWalkTo(1, 119.9967, 7.831, -988.7159, true);
        giPlayerWalkTo(1, 251.1103, -0.2265, -1059.1345, false);
        giWait(1.3);
        giPlayerSetDir(0, 98.0, true);
        giSetPortrait("101E", false);
        giTalk("云天河：菱纱……", "41535");
        giWait(1.3);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：女孩子的心情怎么老是变来变去？好像前一刻天晴，后一刻又下雨……难道我刚刚又说错话？奇怪……", "41536");
        giWait(0.7);
        giSetPortrait("101G", false);
        giTalk("云天河：…………再真挚的感情、再深沉的牵挂，还是会有分开的一天……", "41537");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "C09", 1, true);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("011", true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerCurrentSetVisible(true);
        global_mvar = 31500; // 0x00007B0C, 第一章 / 2-5-8.女萝平妖 / 回房休息
        giPlayerCurrentSetPos(409.8458, -0.3235, -1116.6335);
        giPlayerCurrentSetAng(70.0);
        giIMMEnd();
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giFlashInBlack(1.5, true);
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
    }
}

void func2011()
{
    giPlayerLock();
    giScriptMusicPlay("P25", 2, 0.0, 0.0);
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, 379.4926, -7.6317, -2027.6765);
    giPlayerSetAng(0, 258.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, -4.9408, -13.7906, -2057.6592);
    giPlayerSetAng(1, 82.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, 33.9053, -13.7906, -2091.445);
    giPlayerSetAng(2, 49.0);
    giPlayerSetVisible(2, true);
    giSetNpcVisible("4037", false);
    giSetNpcVisible("4039", false);
    giSetNpcVisible("4042", false);
    giSetNpcVisible("4029", false);
    giSetObjectVisible("entrance1", false);
    giIMMEnd();
    giCameraPrepare("MC004");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.5, false);
    giArenaReady();
    giPlayerRunTo(0, 86.3177, -13.7906, -2048.9565, false);
    giPlayerEndMove(0);
    giPlayerSetDir(0, 243.0, false);
    giCameraRunSingle("002", true);
    giWait(0.5);
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：哎～怎么慢吞吞的，到现在才来！", "41547");
    giPlayerDoAction(2, "J07", 1, false);
    giSetPortrait("106B", true);
    giTalk("柳梦璃：云公子，你昨夜休息得可好？", "41548");
    giPlayerEndAction(2);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101F", false);
    giTalk("云天河：好、好……我很好！", "41549");
    giPlayerEndAction(0);
    giSetPortrait("103J", true);
    giTalk("韩菱纱：（……白痴，脸都红了，一看就知道色心又起……）", "41550");
    giPlayerDoAction(2, "C07", -1, true);
    giWait(0.4);
    giSetObjectVisible("MO006", true);
    giSetPortrait("106B", true);
    giTalk("柳梦璃：云公子，你看，这是昨日说要送你的，试试称不称手。", "41551");
    giSetPortrait("101D", false);
    giTalk("云天河：这是……弓？！", "41552");
    giSetPortrait("106B", true);
    giTalk("柳梦璃：我见云公子的弓用得久了，似乎有些破旧，所以请人做了把新的，你可喜欢吗？", "41553");
    giSetPortrait("101K", false);
    giTalk("云天河：喜、喜欢！", "41554");
    giPlayerDoAction(0, "C07", -1, true);
    giSetPortrait("101K", false);
    giTalk("云天河：哈哈，这弓不错，简直太好了！木头好，木纹又匀，射出去的箭肯定强劲、箭路不偏，而且木头外面还加了小石头，握着应该很稳！", "41555");
    giSetObjectVisible("MO006", false);
    giPlayerUnHoldAct(2);
    giPlayerEndAction(2);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giAddProperty(3106, 1, true);
    giWait(2.0);
    giPlayerAddSkill(0, 5502, true);
    giWait(2.5);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：什么小石头……明明是玉……", "41556");
    giSetPortrait("106C", true);
    giTalk("柳梦璃：太好了，云公子喜欢就好，其实弓的优劣我不太懂……", "41557");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101K", false);
    giTalk("云天河：喜欢、我当然喜欢！", "41558");
    giPlayerSetDir(1, 131.0, true);
    giWait(0.3);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：梦璃你的眼光不错哦～造这把弓的人可一点也没偷工减料，玉片都是用上好的碧玉打磨，这样一把“玉腰弓”肯定价值不菲了。", "41559");
    giPlayerSetDir(2, 316.0, true);
    giPlayerDoAction(2, "C09", 1, false);
    giSetPortrait("106B", false);
    giTalk("柳梦璃：哪里，我什么都不懂，多亏了<colour red=255 green=187 blue=0 alpha=255>铁泽居的刘老板</colour><dc0>，他手艺精湛，人又热心，实在帮了大忙，我们出城前也可以去他那儿挑几件防身器用——</dc0>", "41560");
    giIMMBegin();
    giNpcSetPos("MN005", 181.4089, -13.7906, -1678.7849);
    giNpcSetAng("MN005", 197.0);
    giSetNpcVisible("MN005", true);
    giSetNpcVisible("MN007", true);
    giSetNpcVisible("MN008", true);
    giSetNpcVisible("MN009", true);
    giIMMEnd();
    giSetPortrait("205A", true);
    giTalk("柳世封：璃儿、璃儿～快来看，爹都给你准备妥当了！！", "41561");
    giIMMBegin();
    giPlayerSetDir(2, 11.0, false);
    giPlayerSetDir(1, 36.0, false);
    giPlayerSetDir(0, 343.0, false);
    giIMMEnd();
    giNpcWalkTo("MN005", 124.7312, -13.7906, -1860.5674, false);
    giNpcWalkTo("MN009", 66.6298, -13.7906, -1761.8845, false);
    giWait(1.2);
    gi2DSoundPlay("WJ045", 1);
    giCameraRunSingle("003", true);
    giNpcEndMove("MN009");
    giWait(0.6);
    giSetPortrait("106D", true);
    giTalk("柳梦璃：爹？这是……？", "41562");
    giNpcDoAction("MN007", "J01", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：哈哈！这是爹特地为你挑的宝马加香车！车上已铺了毯子，放好点心～", "41563");
    giSetPortrait("205A", false);
    giTalk("柳世封：你们不是要去陈州？璃儿你就在里面舒舒服服地睡上一觉，醒来就到了～", "41564");
    giSetPortrait("106A", true);
    giTalk("柳梦璃：…………", "41565");
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：我说……县令大人，这马车看起来是不错，可要乘着它走官道，不知何年何月才到得了陈州啊……", "41566");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("205A", false);
    giTalk("柳世封：什么？你们不要车？！", "41567");
    giNpcSetDir("MN007", 40.0, true);
    giSetPortrait("205A", false);
    giTalk("柳世封：裴剑！你快去牵三匹马来，这车先不要了！", "41568");
    giNpcSetDir("MN005", 212.0, true);
    giNpcDoAction("MN005", "J02", 1, false);
    giSetPortrait("204A", true);
    giTalk("裴剑：是。", "41569");
    giCameraRunSingle("004", true);
    giPlayerWalkTo(2, 42.1157, -13.7906, -2004.6925, false);
    giSetPortrait("106B", true);
    giTalk("柳梦璃：爹～我看都不用了。", "41570");
    giPlayerEndMove(2);
    giNpcFaceToPlayer("MN007", 2, true);
    giSetPortrait("106B", true);
    giTalk("柳梦璃：女儿虽然没有出过远门，但韩姑娘颇有阅历，先听她安排便是，最多多带些银两在身边，不至捉襟见肘。", "41571");
    giPlayerDoAction(2, "J13", 1, false);
    giSetPortrait("106D", true);
    giTalk("柳梦璃：……至于点心……", "41572");
    giWait(0.8);
    giPlayerSetDir(2, 137.0, true);
    giWait(1.8);
    giPlayerSetDir(2, 8.0, true);
    giWait(0.6);
    giSetPortrait("106B", true);
    giTalk("柳梦璃：点心便带在路上吃吧。", "41573");
    giPlayerSetDir(0, 320.0, true);
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101K", false);
    giTalk("云天河：好啊、好啊～点心是好东西！", "41574");
    giPlayerEndAction(0);
    giPlayerDoAction(1, "J04", -1, false);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（唉……我忍，当没听见……）", "41575");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giAddProperty(3012, 15, true);
    giWait(2.5);
    giAddProperty(3018, 15, true);
    giWait(2.5);
    giAddMoney(3000, true);
    giWait(2.5);
    giCameraRunSingle("005", true);
    giWait(0.3);
    giNpcDoAction("MN007", "C08", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：这……好吧，爹都依你，璃儿高兴就好。", "41576");
    giWait(0.3);
    giNpcFaceToNpc("MN008", "MN007", true);
    giSetPortrait("206A", false);
    giTalk("阮慈：唉，我早劝过老爷别又一时动念，看吧，你果然是说不过璃儿～", "41577");
    giPlayerFaceToNpc(2, "MN008", true);
    giWait(0.4);
    giPlayerDoAction(2, "C09", 1, false);
    giSetPortrait("106F", true);
    giTalk("柳梦璃：娘，不妨事的，我知道爹也是为我好，只是这些年来你们已经操心太多，女儿不能再事事都依赖你们。", "41578");
    giNpcSetDir("MN008", 173.0, false);
    giNpcDoAction("MN007", "J02", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：璃儿，你尽管、尽管依赖爹！", "41579");
    giPlayerFaceToNpc(2, "MN007", false);
    giNpcSetDir("MN008", 114.0, true);
    giWait(0.8);
    giSetPortrait("206A", false);
    giTalk("阮慈：老爷，我们就少说两句吧，这样讲下去，可要耽搁他们的时间了。", "41580");
    giSetPortrait("106F", true);
    giTalk("柳梦璃：爹、娘，你们毋须挂心，我又不是永远不回来了。", "41581");
    giPlayerDoAction(2, "C07", -1, false);
    giSetPortrait("106F", true);
    giTalk("柳梦璃：看，这是离香草制成的香囊，我把它带在身边，传说它会离家越远、香气越浓，女儿终有一日也会回到你们身边……", "41582");
    giNpcSetDir("MN008", 173.0, false);
    giPlayerUnHoldAct(2);
    giPlayerEndAction(2);
    giNpcDoAction("MN007", "J02", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：呜～璃儿……", "41583");
    giSetPortrait("106F", true);
    giTalk("柳梦璃：爹，还有一事须记得，我留下的香足够今年进贡了，何况禄珠、禄蓉也手艺渐好，制香之事不必担心，只不过半年之内不可再采摘离香草，无论如何采摘过度都是有害而无益……", "41584");
    giNpcDoAction("MN007", "C08", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：璃儿你放心，爹已经让人贴出告示，裴剑自会管好此事。", "41585");
    giNpcEndAction("MN007", true);
    giIMMBegin();
    giPlayerSetAng(0, 335.0);
    giPlayerSetAng(1, 23.0);
    giIMMEnd();
    giPlayerSetAng(0, 343.0);
    giCameraRunSingle("004", true);
    giWait(0.5);
    giSetPortrait("206A", true);
    giTalk("阮慈：璃儿，还有天河、韩姑娘，你们几个事事都要小心，保重身体。", "41586");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：呵呵，柳波波、柳波母，等我学会乘剑在天上飞之后，再来找你们玩～", "41587");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：（唉，臭美吧你～）", "41588");
    giNpcWalkTo("MN005", 108.756, -13.7906, -1937.4811, false);
    giCameraRunSingle("006", true);
    giNpcEndMove("MN005");
    giNpcSetDir("MN005", 189.0, true);
    giWait(0.3);
    giSetPortrait("204A", false);
    giTalk("裴剑：云公子。", "41589");
    giIMMBegin();
    giPlayerSetDir(0, 0.0, false);
    giPlayerSetDir(2, 64.0, false);
    giNpcSetDir("MN007", 161.0, false);
    giNpcSetDir("MN008", 155.0, false);
    giIMMEnd();
    giWait(0.8);
    giNpcDoAction("MN005", "J02", -1, false);
    giSetPortrait("204A", false);
    giTalk("裴剑：裴剑斗胆说一句，我家小姐从未出过远门，请好好照顾她。", "41590");
    giNpcUnHoldAct("MN005");
    giNpcEndAction("MN005", true);
    giPlayerDoAction(0, "J18", 1, false);
    giSetPortrait("101K", true);
    giTalk("云天河：哈、哈哈哈，包在我身上，我一定、一定不让别人欺负她！", "41591");
    giSetPortrait("106F", false);
    giTalk("柳梦璃：……", "41592");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：（瞎说……连自己都顾不好，还要顾别人？）", "41593");
    giPlayerWalkTo(1, 55.8931, -13.7906, -2059.5422, false);
    giCameraRunSingle("007", false);
    giPlayerEndMove(1);
    giPlayerFaceToNpc(1, "MN007", true);
    giWait(0.7);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：县令大人放宽心吧。", "41594");
    giWait(0.5);
    giIMMBegin();
    giNpcSetDir("MN007", 180.0, false);
    giPlayerFaceToNpc(0, "MN007", false);
    giPlayerFaceToNpc(2, "MN007", false);
    giIMMEnd();
    giWait(0.8);
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：就算别的不行，江湖规矩我可是懂不少，梦璃跟着我不会有事的。", "41595");
    giPlayerEndAction(1);
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：我们走了，嘻嘻！", "41596");
    giWait(0.5);
    giWait(0.9);
    giPlayerDoAction(0, "C08", 1, true);
    giWait(0.6);
    giPlayerWalkTo(1, 60.6981, -13.7906, -2263.7957, false);
    giPlayerWalkTo(0, 92.5916, -13.7906, -2257.3376, false);
    giWait(1.7);
    giPlayerDoAction(2, "J07", 1, false);
    giSetPortrait("106F", false);
    giTalk("柳梦璃：爹、娘、裴大哥，保重……", "41597");
    giPlayerEndAction(2);
    giPlayerWalkTo(2, 37.938, -13.7906, -2268.329, false);
    giWait(3.5);
    giCameraRunSingle("008", true);
    giWait(0.5);
    giNpcDoAction("MN007", "J01", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：……哈哈，夫人你看，璃儿到底还是喜欢天河，这回我绝非乱点鸳鸯。", "41598");
    giNpcSetDir("MN008", 135.0, true);
    giSetPortrait("206A", false);
    giTalk("阮慈：哦？老爷又怎知道的？", "41599");
    giNpcSetDir("MN007", 305.0, false);
    giNpcSetDir("MN005", 284.0, true);
    giWait(0.3);
    giSetPortrait("205A", true);
    giTalk("柳世封：她、璃儿不是还送了把弓给天河？除了你我和裴剑，几时见她为旁人这般费心？", "41600");
    giSetPortrait("206A", false);
    giTalk("阮慈：倘若他们彼此有意，自然是好，只是这种事情谁也说不准，璃儿做事向来有主见，想要如何就随她去吧。", "41601");
    giNpcDoAction("MN007", "J02", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：唉，女儿养这么大，最后还是别人的……", "41602");
    giNpcEndAction("MN007", true);
    giSetPortrait("206A", false);
    giTalk("阮慈：老爷说什么呢～璃儿也还没嫁掉。", "41603");
    giSetPortrait("205A", true);
    giTalk("柳世封：……想到她以前小小的，一晃眼就这般亭亭玉立，却终究也要喜欢上别人，我、我这心里……", "41604");
    giSetPortrait("206A", false);
    giTalk("阮慈：我说老爷啊～雏鸟离巢本是天经地义，儿女养大了，总有一天要离家的。至少……还有我陪着老爷，就算有朝一日老爷的头发牙齿都掉光了，我们两个在一起，总也是有个伴。", "41605");
    giSetPortrait("205A", true);
    giTalk("柳世封：夫人……", "41606");
    giSetPortrait("206A", false);
    giTalk("阮慈：哎，何况裴剑也算你的半子，女儿虽走，儿子总还在吧～", "41607");
    giNpcDoAction("MN007", "C08", 1, false);
    giSetPortrait("205A", true);
    giTalk("柳世封：没错没错，看我老糊涂的！", "41608");
    giNpcEndAction("MN007", true);
    giWait(0.5);
    giIMMBegin();
    giCameraRunSingle("009", false);
    giNpcSetAng("MN007", 77.0);
    giNpcSetAng("MN008", 108.0);
    giNpcFaceToNpc("MN005", "MN007", false);
    giIMMEnd();
    giWait(0.7);
    giSetPortrait("205A", false);
    giTalk("柳世封：来来来，今天你就陪我多喝两杯，我们来个不醉不归！", "41609");
    giNpcDoAction("MN005", "J02", 1, false);
    giSetPortrait("204A", true);
    giTalk("裴剑：是，老爷。", "41610");
    giNpcEndAction("MN005", false);
    giNpcDoAction("MN007", "C09", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：你啊……什么都好，就是太一本正经又太闷，不是说私底下不用喊我“老爷”嘛……", "41611");
    giNpcDoAction("MN005", "J02", 1, false);
    giSetPortrait("204A", true);
    giTalk("裴剑：是，老爷。", "41612");
    giNpcEndAction("MN005", false);
    giNpcDoAction("MN007", "C09", 1, false);
    giSetPortrait("205A", false);
    giTalk("柳世封：你啊……唉，不说了，喝酒去～", "41613");
    giNpcEndAction("MN007", true);
    giNpcWalkTo("MN007", 136.85, -13.7906, -2056.6816, false);
    giNpcWalkTo("MN008", 90.4913, -13.7907, -2050.289, false);
    giWait(1.5);
    giNpcSetDir("MN005", 190.0, true);
    giWait(1.5);
    giIMMBegin();
    giSetNpcVisible("MN007", false);
    giSetNpcVisible("MN008", false);
    giIMMEnd();
    giWait(1.3);
    giCameraRunSingle("010", true);
    giWait(0.5);
    giSetPortrait("204A", false);
    giTalk("裴剑：小姐……你多保重……", "41614");
    giFlashOutBlack(2.0, true, true);
    giIMMBegin();
    giSetNpcVisible("MN005", false);
    giSetNpcVisible("MN009", false);
    giPlayerSetPos(0, 30.1092, -13.7906, -2704.5632);
    giPlayerSetAng(0, 198.0);
    giPlayerSetPos(1, 12.6283, -13.7906, -2757.1846);
    giPlayerSetAng(1, 326.0);
    giPlayerSetPos(2, -23.8358, -13.7906, -2702.1636);
    giPlayerSetAng(2, 147.0);
    giIMMEnd();
    giCameraPrepare("MC005");
    giCameraRunSingle("001", true);
    giScriptMusicStop(0, 2.5);
    giScriptMusicPlay("P24", 2, 0.0, 0.0);
    giFlashInBlack(2.0, true);
    giPlayerDoAction(2, "C07", -1, false);
    giSetPortrait("106B", false);
    giTalk("柳梦璃：菱纱，你适才说不走官道，是有其他办法去陈州吗？", "41615");
    giPlayerUnHoldAct(2);
    giPlayerEndAction(2);
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103J", true);
    giTalk("韩菱纱：那当然！韩女侠自有妙计！", "41616");
    giSetPortrait("101A", false);
    giTalk("云天河：……？", "41617");
    giSetPortrait("103J", true);
    giTalk("韩菱纱：（哼哼，我～偏～不～说～了，想知道就来问呐！）", "41618");
    giPlayerDoAction(2, "J13", 1, true);
    giPlayerDoAction(0, "J14", 1, true);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（…………一个只管笑，一个呆若木鸡，你们、你们都没有好奇心的吗？！）", "41619");
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：……菱纱，你是不是想拉肚子？脸色这么难看……", "41620");
    giPlayerSetDir(1, 22.0, false);
    giCameraRunSingle("002", false);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerDoAction(1, "J17", -1, false);
    giSetPortrait("103I", true);
    giTalk("韩菱纱：不、要、你、管！我正要说下去呢！", "41621");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(1, "J13", -1, false);
    giSetPortrait("103G", true);
    giTalk("韩菱纱：咳、咳咳，其实我早想好了，<colour red=255 green=187 blue=0 alpha=255>我们这次取道淮南王陵地宫，</colour><dc0>顺利的话，要不了多久就能到陈州附近的碗丘山，比起走官道，那是大大的省事了。</dc0>", "41622");
    giSetPortrait("106E", true);
    giTalk("柳梦璃：淮南王陵？！", "41623");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerSetDir(1, 324.0, true);
    giPlayerDoAction(2, "J13", 1, false);
    giSetPortrait("106D", true);
    giTalk("柳梦璃：可是……贸然进入那里，有违法令，怕是不好，何况你的通缉告示才撤下没多久……", "41624");
    giPlayerDoAction(1, "J05", 1, false);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：不用怕啦～凡事都有变通嘛，我们此去又不是搜刮宝器，不过是借人家的地盘当一下过道，堂堂一个王爷，不至于这么小气吧？", "41625");
    giPlayerEndAction(1);
    giSetPortrait("106A", true);
    giTalk("柳梦璃：……嗯，既然你都有打算，就按你说的。", "41626");
    giSetPortrait("101B", false);
    giTalk("云天河：走那个什么陵，就能遇上剑仙？", "41627");
    giPlayerSetDir(1, 22.0, true);
    giWait(0.5);
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：当然不是！御剑之术瞬忽万里，哪里是这样便能追上？如今也只好碰碰运气，盼怀朔他们在陈州多逗留几天了。", "41628");
    giSetPortrait("101A", false);
    giTalk("云天河：哦……", "41629");
    giSetPortrait("103M", true);
    giTalk("韩菱纱：别担心！就算错过他们，天下之大，我就不信没有别的法子找到那个门派的线索！", "41630");
    giWait(0.5);
    giIMMBegin();
    giCameraRunSingle("001", false);
    giPlayerSetAng(2, 113.0);
    giIMMEnd();
    giWait(0.5);
    giSetPortrait("106A", false);
    giTalk("柳梦璃：嗯，天无绝人之路的，我也帮忙一起找。", "41631");
    giWait(0.3);
    giPlayerFaceToPlayer(0, 2, true);
    giWait(0.4);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101K", true);
    giTalk("云天河：一起？好、好啊，一起找，呵呵～", "41632");
    giSetPortrait("106D", false);
    giTalk("柳梦璃：…………", "41633");
    giPlayerSetDir(1, 311.0, true);
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103F", true);
    giTalk("韩菱纱：……梦璃，我们走！别理那个傻笑的家伙！", "41634");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerSetDir(2, 143.0, true);
    giPlayerDoAction(2, "C08", 1, true);
    giWait(0.6);
    giPlayerWalkTo(1, 22.9542, -13.7906, -2875.448, false);
    giPlayerWalkTo(2, -27.1089, -13.7906, -2825.6763, false);
    giWait(1.6);
    giPlayerSetDir(0, 195.0, true);
    giWait(0.3);
    giPlayerDoAction(0, "J02", 1, false);
    giSetPortrait("101D", false);
    giTalk("云天河：啊！你们、等等我啊！", "41635");
    giPlayerEndAction(0);
    giPlayerRunTo(0, 22.272, -13.7906, -2872.4844, true);
    giFlashOutBlack(1.5, true, true);
    giPlayerInTeam(1, false);
    giPlayerInTeam(2, false);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    giPlayerCurrentSetVisible(true);
    giSetNpcVisible("4037", true);
    giSetNpcVisible("4039", true);
    giSetNpcVisible("4042", true);
    giSetNpcVisible("4029", true);
    global_mvar = 40300; // 0x00009D6C, 第一章 / 3-1-2.少年行 / 启程往陈州
    giSetObjectVisible("entrance1", true);
    giAddPlayerFavor(0, 2, 10);
    giAddPlayerFavor(1, 2, 10);
    giIMMEnd();
    giPlayerCurrentSetPos(-2.5091, -13.7906, -3340.3877);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giScriptMusicStop(0, 2.5);
    giPlayerUnLock();
}

void func2013()
{
    int local_3 = 0;

    if (global_mvar != 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        func2099();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetNpcVisible("MN001", true);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giNpcSetEmotion("MN001", "101_wx2");
        giFlashInBlack(1.5, true);
        giSetPortrait("101L", true);
        giTalk("云天河：（……梦璃她、她说要教我认字呢，呵呵～～）", "41538");
        giSetPortrait("101L", true);
        giTalk("云天河：（…………）", "41539");
        giSetPortrait("101L", true);
        giTalk("云天河：（自从下了山，好多人说的话我都不懂……要是多念点书，是不是就能弄懂很多事？……也就能明白菱纱为什么会变来变去了…………）", "41540");
        giSetPortrait("101L", true);
        giTalk("云天河：（想睡了……唔…………烤全猪…………）", "41541");
        giNpcSetEmotion("MN001", "101_by");
        giFlashOutBlack(1.7, true, true);
        local_3 = gi2DSoundPlay("WJ024", -1);
        giWait(1.5);
        gi2DSoundPlay("WJ032", 1);
        giWait(4.0);
        gi2DSoundPlay("WE134", 1);
        giWait(2.0);
        giTalk("禄珠：……公子，您起身了吗？", "41542");
        giSetPortrait("101G", true);
        giTalk("云天河：唔……", "41543");
        giWait(1.0);
        giNpcResetEmotion("MN001");
        giNpcDoAction("MN001", "C10", 0, false);
        giNpcSetAng("MN001", 21.0);
        giCameraRunSingle("002", true);
        gi2DSoundStopID(local_3);
        giFlashInBlack(1.5, true);
        giSetPortrait("101E", true);
        giTalk("云天河：（睏～～被吵醒……这女孩的脚步声真沉，不像菱纱，几乎没啥声息……）", "41544");
        giTalk("禄珠：云公子，小姐猜您大概不喜欢让人服侍，所以请您打理妥当后，<colour red=255 green=187 blue=0 alpha=255>就去柳府大门口准备起程了～</colour>", "41545");
        giSetPortrait("101E", true);
        giTalk("云天河：哦……知道了。", "41546");
        gi2DSoundPlay("WJ062", 1);
        giWait(1.0);
        giFlashOutBlack(1.5, true, true);
        giSetFullHP();
        giSetFullMP();
        giIMMBegin();
        giNpcEndAction("MN001", true);
        giSetNpcVisible("MN001", false);
        giPlayerCurrentSetPos(-16.3966, -0.2, -17.5171);
        giPlayerCurrentSetAng(0.0);
        giPlayerCurrentSetVisible(true);
        global_mvar = 40100; // 0x00009CA4, 第一章 / 3-1-1.少年行 / 门口会合
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giCameraSetMode(3, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2014()
{
    if (global_mvar != 21700 /* 第一章 / 2-1-5.初涉红尘 / 阳春客栈 */)
    {
        if (global_mvar != 21900 /* 第一章 / 2-2-1.徒惹官非 / 拜访柳府 / 寿阳揭榜 */)
        {
            if (global_mvar == 31400 || global_mvar == 31500 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
            {
                giPlayerLock();
                giPlayerSetLeader(0);
                giPlayerWalkTo(0, -1.4269, -13.7906, -3017.6694, true);
                giPlayerSetDir(0, 0.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giSetPortrait("101C", true);
                giTalk("云天河：快到吃晚饭的时间了吧？还是别出城了。", "");
                giPlayerUnLock();
            }
        }
        else
        {
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, -1.4269, -13.7906, -3017.6694, true);
            giPlayerSetDir(0, 0.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("101A", true);
            giTalk("云天河：现在<colour red=255 green=187 blue=0 alpha=255>该去那个老大的家里</colour><dc0>……</dc0>", "");
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -1.4269, -13.7906, -3017.6694, true);
        giPlayerSetDir(0, 0.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101A", true);
        giTalk("云天河：菱纱说<colour red=255 green=187 blue=0 alpha=255>要先去那个叫“客栈”的地方</colour><dc0>……</dc0>", "");
        giPlayerUnLock();
    }
}

void func2015()
{
    if (global_mvar == 21800 /* 第一章 / 2-1-6.初涉红尘 / 等待菱纱 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -372.2943, -13.7906, 1505.427, true);
        giPlayerSetDir(0, 260.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101A", true);
        giTalk("云天河：菱纱说要在客栈门口等她，不要去别的地方。", "");
        giPlayerUnLock();
    }
}

void func2016()
{
    if (global_mvar == 21800 /* 第一章 / 2-1-6.初涉红尘 / 等待菱纱 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -344.9711, -13.7907, 1327.5946, true);
        giPlayerSetDir(0, 276.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101A", true);
        giTalk("云天河：菱纱说要在客栈门口等她，不要去别的地方。", "");
        giPlayerUnLock();
    }
}

void func2017()
{
    if (global_mvar != 21700 /* 第一章 / 2-1-5.初涉红尘 / 阳春客栈 */)
    {
        if (global_mvar >= 50100 /* 离开王墓 */)
        {
            giPlayerLock();
            giCameraSetCollide(false);
            giCameraAutoSeek(false);
            giCameraPrepare("MC006");
            giCameraRunSingle("001", true);
            giNpcPauseBeh("4022");
            giNpcFaceToCurrentPlayer("4022", true);
            giCurrentPlayerFaceToNpc("4022", true);
            giTalk("赵孟坚：柳大人现下不在府中，云公子若是要拜会柳大人，还请改日再来。", "");
            giNpcResetDir("4022");
            giNpcResumeBeh("4022");
            giPlayerWalkTo(0, 229.0182, -13.7906, -2026.875, true);
            giPlayerSetDir(0, 265.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giCameraPrepare("MC006");
        giCameraRunSingle("001", true);
        giNpcPauseBeh("4022");
        giNpcFaceToCurrentPlayer("4022", true);
        giCurrentPlayerFaceToNpc("4022", true);
        giTalk("赵孟坚：县令大人的府邸，不可随意入内！", "");
        giNpcResetDir("4022");
        giNpcResumeBeh("4022");
        giPlayerWalkTo(0, 229.0182, -13.7906, -2026.875, true);
        giPlayerSetDir(0, 265.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giPlayerUnLock();
    }
}

void func2018()
{
    if (global_mvar == 21901 /* 第一章 / 2-3-1.礼请天河 / 应邀去前厅 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -659.7799, -0.6711, 479.4067, true);
        giPlayerSetDir(0, 87.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101A", true);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>那个胖胖的柳波波让我进那间大房子，</colour><dc0>我就跟进去看看好了～</dc0>", "");
        giPlayerUnLock();
    }
}

void func2019()
{
    if (global_mvar == 21901 /* 第一章 / 2-3-1.礼请天河 / 应邀去前厅 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 633.5718, -0.6711, 479.6759, true);
        giPlayerSetDir(0, 268.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101A", true);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>那个胖胖的柳波波让我进那间大房子，</colour><dc0>我就跟进去看看好了～</dc0>", "");
        giPlayerUnLock();
    }
}

void func2099()
{
    int select_dialog_last_select = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.是");
    giSelectDialogAddItem("2.否");
    giSelectDialogSetDefaultSelect(1);
    giShowSelectDialog("　　　　是否要<colour red=255 green=102 blue=0 alpha=255>休息</colour><dc0>一下？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        giPlayerUnLock();
    }
    else
    {
        giFlashOutBlack(1.5, true, true);
        giPlayerTakeARest();
        giWait(3.0);
        giFlashInBlack(1.5, true);
        giShowHint("人物<colour red=255 green=187 blue=0 alpha=255>精</colour><dc0>、</dc0><colour red=255 green=187 blue=0 alpha=255>神</colour><dc0>回复满值</dc0>", 0.5, 0.15);
        giWait(2.0);
        giPlayerUnLock();
    }
}

void func3001()
{
    if ((global_mvar < 100100 && global_mvar >= 90100 || global_mvar <= 101500 && global_mvar >= 100200) && var_zhu == 0 /* 第二章 / 6-3-3.义结金兰 / 歇息一晚 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P72", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -174.4015, 0.9998, 86.1618);
        giPlayerSetAng(0, 116.0);
        giPlayerSetPos(3, -114.5018, 0.9999, 42.8742);
        giPlayerSetAng(3, 34.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("SN001", true);
        giSetNpcVisible("SN002", true);
        giSetNpcVisible("4005", false);
        giSetObjectVisible("sound001", false);
        giIMMEnd();
        giCameraPrepare("yan001");
        giCameraRunSingle("002", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giTalk("？？：喂！我说周老板，客栈里的酒全都被人订下了，这话是你诓人的吧？刚才问你儿子，他可全都说了。", "");
        giWait(0.30000001192092896);
        giNpcFaceToNpc("4079", "SN002", true);
        giWait(0.5);
        giTalk("周金福：小同你这孩子！怎么随便乱讲话！", "");
        giTalk("周小同：哼，我才没乱讲，明明是爹爹骗人……", "");
        giTalk("周金福：你……", "");
        giNpcFaceToNpc("4079", "SN001", true);
        giTalk("周金福：大姐～您瞧瞧，今天能不能暂且放过本店算了？您十次有九次都是赊帐，酒量又大，我这小本生意，怎么经得起啊——", "");
        giNpcDoAction("SN001", "C09", 1, false);
        giTalk("？？：哎！大男人一个，婆婆妈妈做什么，不就是一点酒水吗？！", "");
        giTalk("？？：我可不白喝你的酒！小同一直想要个木头老鼠，我做给他就是了，快快快，去帮我打二十壶酒来～", "");
        giWait(0.5);
        giCameraRunSingle("001", true);
        giWait(0.5);
        giTalk("周小同：会动的木头老鼠～～", "");
        giTalk("周小同：爹爹，我想要那个嘛！", "");
        giNpcFaceToNpc("4079", "SN002", true);
        giTalk("周金福：去去去！今早先生教你的功课做好了没？没做好就给我回后院去！", "");
        giTalk("周小同：……讨厌，爹爹是坏人！", "");
        giWait(0.5);
        giNpcWalkTo("SN002", 77.6199, 19.7592, -169.3609, false);
        giWait(1.5);
        giCameraRunSingle("003", false);
        giTalk("？？：周老板你这样可不好，总让小孩子念书，小心他长大变书呆～", "");
        giNpcFaceToNpc("4079", "SN001", true);
        giTalk("周金福：唉，大姐您饶了我吧，说白了，那木头老鼠要再多有什么用，又不能养家糊口，您、您不还是让我为难吗？", "");
        giTalk("？？：好啦好啦，真是扫兴，看你一副苦脸，不知情的还以为我逼你做啥……这里的酒喝不成，<colour red=255 green=187 blue=0 alpha=255>我改天去陈州喝，</colour><dc0>哼！</dc0>", "");
        giNpcWalkTo("SN001", 8.647, 0.9998, 150.4988, true);
        giTalk("周金福：天呐……这难缠的大姐，到底什么时候才会离开寿阳……", "");
        giWait(1.0);
        giIMMBegin();
        giSetNpcVisible("SN001", false);
        giSetNpcVisible("SN002", false);
        giIMMEnd();
        giCameraRunSingle("004", false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……刚才那人，莫非是夙莘师叔？", "");
        giWait(1.0);
        giCameraRunSingle("005", true);
        giSetPortrait("102K", true);
        giTalk("云天河：紫英，你认识那个女的？能不能帮我找她要个会动的木头老鼠啊？听起来很好玩的样子～", "");
        giPlayerDoAction(3, "C09", 1, true);
        giWait(0.5);
        giPlayerWalkTo(3, -57.0236, 0.9998, 125.1988, true);
        giPlayerSetDir(0, 40.0, true);
        giWait(1.0);
        giPlayerDoAction(0, "J14", 1, true);
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetAng(0.0);
        var_zhu = 1;
        giSetNpcVisible("4005", true);
        giSetObjectVisible("sound001", true);
        giIMMEnd();
        giCameraSetMode(3, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giScriptMusicStop(0, 2.5);
        giPlayerUnLock();
    }
}

void func4001()
{
    giPlayerLock();
    giNpcPauseBeh("4001");
    giNpcFaceToCurrentPlayer("4001", true);
    giCurrentPlayerFaceToNpc("4001", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("刘卫平：前些日子听说巢湖底下有妖怪，城里的渔民都不去捕鱼了，最近才终于明白是湖里漩涡惹的祸，根本就没妖怪嘛！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("刘卫平：这段时间柳大人有事去了京城，现下寿阳的大小事务都由裴护卫管着。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giRandTalkPush("刘卫平：奇怪，“年内都不可再采离香草”……柳大人颁的告示，也不知是怎么回事……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("刘卫平：此地乃寿州州治寿阳城，现由柳世封柳大人所管！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4001");
    giNpcResumeBeh("4001");
    giPlayerUnLock();
}

void func4002()
{
    giPlayerLock();
    giNpcPauseBeh("4002");
    giNpcFaceToCurrentPlayer("4002", true);
    giCurrentPlayerFaceToNpc("4002", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("谭婆：听说了吗？前段时间失踪的渔民不是被妖怪害的，而是被湖里漩涡卷走了！我说呢，这好端端的，哪里会有那么多妖怪……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("谭婆：听说现在山上真没妖怪了，不过我也年纪大了，自从上回闪了腰，就很少再出门啰……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giRandTalkPush("谭婆：前阵子山上有妖怪，衙门也不见动静，如今妖怪被剑仙除去了，柳大人反倒不让大伙上山采离香草，这……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkPush("谭婆：真是作孽啊！听说又有人被妖怪咬了……那妖怪这么厉害，连柳大人都没办法，我们以后可怎么办啊？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("谭婆：唉，我的腰啊……前几天上山采离香草，被山里的妖怪盯上，吓得我拼命跑，结果把这老骨头给闪着了……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4002");
    giNpcResumeBeh("4002");
    giPlayerUnLock();
}

void func4003()
{
    giPlayerLock();
    giNpcPauseBeh("4003");
    giNpcFaceToCurrentPlayer("4003", true);
    giCurrentPlayerFaceToNpc("4003", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("刘小侠：……我好久都没看见柳姐姐了，她到底去了哪里呢……小侠想她……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("刘小侠：爹爹一心想让我成为剑仙那样的大侠，所以给我取名叫刘小侠，可我只喜欢养鸭。嘎嘎嘎～多可爱啊，只要给它们一些糠，它们就会好开心～");
        giRandTalkPush("刘小侠：嘘～告诉你个秘密，县令家的柳姐姐其实是仙女哦！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4003");
    giNpcResumeBeh("4003");
    giPlayerUnLock();
}

void func4004()
{
    giPlayerLock();
    giNpcPauseBeh("4004");
    giNpcFaceToCurrentPlayer("4004", true);
    giCurrentPlayerFaceToNpc("4004", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("刘二嫂：原本听说巢湖里有妖怪害人，现在又说那是水里的漩涡，根本不是妖怪。这到底是怎么一回事啊？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("刘二嫂：山上的妖怪真的没了？我心里总还是觉得不踏实……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("刘二嫂：今天一大早，我看见那张缉拿盗墓贼的告示不见了？难道那贼已经被捉住了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("刘二嫂：你看见我家小侠了吗？是不是又到院子里数鸭子去了？唉！这样怎么会有出息呢！");
        giRandTalkPush("刘二嫂：说也奇了，自从我家搬到寿阳后，我那夜里失眠做恶梦的毛病就再也没犯过，每天晚上都睡得很舒坦。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4004");
    giNpcResumeBeh("4004");
    giPlayerUnLock();
}

void func4005()
{
    giPlayerLock();
    giNpcPauseBeh("4005");
    giNpcFaceToCurrentPlayer("4005", true);
    giCurrentPlayerFaceToNpc("4005", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("李山：连太平村的茶叶也进了京，还卖得特别好？就他们那种穷地方出的茶叶，怎么能和我们寿阳的贡品“宁香”相提并论呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("李山：昨天夜里我睡得不太好，还被一个恶梦给吓醒了！已经十几年没做恶梦，昨天的那个梦，八成不是好兆头……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("李山：客栈门前的缉拿告示撤下来了，看来那女贼已经被擒啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkPush("李山：咦？你不就是那天在客栈外头被裴护卫请走的人吗？看不出你小小年纪，竟然能结识柳大人。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("李山：干炒蒿子，肉丝辣面、糖醋银鱼，还有淮王鱼和八公山豆腐，客官您可都要来点？");
        giRandTalkPush("李山：淮王鱼其实就是打鱼人常说的“江团”，当年淮南王刘安最喜欢吃这鱼，后来我们寿阳人就改叫这鱼作“淮王鱼”。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4005");
    giNpcResumeBeh("4005");
    giPlayerUnLock();
}

void func4006()
{
    giPlayerLock();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("杨铮：近日我便要起程回家一趟，也是该探望探望父母了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkRelease();
        giRandTalkPush("杨铮：没想到那八公山女萝岩上的妖怪被剑仙给除了，否则我还想上山探一探，看看到底是什么样的妖在作怪！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkRelease();
        giRandTalkPush("杨铮：那日在客栈门口被逮住的人，真是那个盗墓贼？怎么可能是个女娃儿？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giTalk("杨铮：唉！虽说我以云游四海为志，但到底离家三年，也不知道家中父母兄妹都如何了？", "");
        giTalk("张严钧：杨兄，我和你不同～家中没有父母弟妹，倒没什么可牵挂。", "");
        giTalk("杨铮：我也是来了此地，听说附近山上长着一种叫离香草的东西，离香草、离乡草，唉，这才伤感起来……", "");
    }
    giPlayerUnLock();
}

void func4007()
{
    giPlayerLock();
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("张严钧：寿阳附近的巢湖、八公山、淝水古战场这些地方，我们已经全都游历过了，看杨兄思家心切的样子，再过几日就起程陪他回一趟宾化吧。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("张严钧：寿阳城东有淝水古战场，西有廉颇墓，北有八公山淮南王陵，南有古刘备城，每个地方都是我想去看的，若要全都游历一番，至少也要在这里住上一、两个月吧。");
        giRandTalkPush("张严钧：我和杨兄初来此地时就听闻女萝岩闹妖怪，原本也打算前去一探，只是那段日子杨兄心情不好，才将此事搁下了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("张严钧：我和杨兄本想结伴去巢湖看看，没想到杨兄却借酒浇愁起来，看来巢湖之游，只能再等几天了。");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4008()
{
    giPlayerLock();
    giNpcPauseBeh("4008");
    giNpcFaceToCurrentPlayer("4008", true);
    giCurrentPlayerFaceToNpc("4008", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("来顺：其实我早就知道巢湖底下没妖怪，可那些渔民硬是不信，现在知道了吧？那只是湖心的漩涡，跟妖怪扯不上半点关系。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("来顺：告诉你！剑仙之所以会帮咱们除去女萝岩上的妖怪，那都是因为柳大人的关系！柳大人的千金是仙女，柳大人当然有办法请剑仙来除妖啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkPush("来顺：嘿嘿，那天在客栈门口被裴护卫带走的那位少侠，其实是柳大人的远房亲戚，这回到咱们寿阳城，是来迎娶柳大小姐的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("来顺：我可是寿阳城里出了名的包打听！凡是城里的事，只要你想知道，我都能帮你打听来！当然啦，这银子可不能少～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4008");
    giNpcResumeBeh("4008");
    giPlayerUnLock();
}

void func4009()
{
    giPlayerLock();
    giNpcPauseBeh("4009");
    giNpcFaceToCurrentPlayer("4009", true);
    giCurrentPlayerFaceToNpc("4009", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("刘平：现在太平村那个穷地方的茶叶也进了京，还卖得不错，不过比咱们寿阳的宁香还差一截～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("刘平：那天我看见县令和夫人坐着马车出了城，还带着家丁丫鬟，一定是去办什么重要的事。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("刘平：缉拿告示撤下来了，这么说盗墓贼已经被抓了吧？但又没听到衙门里有多大动静，真是奇怪……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("刘平：县令柳大人家的小姐不仅是咱寿阳的第一大美人，还是百姓的第一大恩人！要不是柳小姐教城里人制香的法子，咱寿阳人哪能过上现在这等好日子？");
        giRandTalkPush("刘平：你可别小看这家不起眼的铁泽居，听说连剑仙都来请刘师父给他打造宝剑呢！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4009");
    giNpcResumeBeh("4009");
    giPlayerUnLock();
}

void func4010()
{
    giPlayerLock();
    giNpcPauseBeh("4010");
    giNpcFaceToCurrentPlayer("4010", true);
    giCurrentPlayerFaceToNpc("4010", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("周小珊：听匡大叔说，京城里好多人都喜欢我们的宁香，可为什么阿娘现在都不太上山采香草了呢……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("周小珊：八公山上的妖怪被剑仙赶跑了～我和毛毛又可以去山上玩了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("周小珊：阿娘说，自从柳大人来了寿阳，日子就越来越好，柳大人一定是神仙派来帮我们的！");
        giRandTalkPush("周小珊：离香草制的香叫“宁香”，晚上睡不着的时候就在香炉里放上一点，一会就能睡着了～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4010");
    giNpcResumeBeh("4010");
    giPlayerUnLock();
}

void func4011()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4011");
    giCurrentPlayerFaceToNpc("4011", true);
    if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giNpcFaceToCurrentPlayer("4011", true);
        giCurrentPlayerFaceToNpc("4011", true);
        giRandTalkRelease();
        giRandTalkPush("秋荻：全寿阳城卖粉折的摊子倒也不只这一家，但我相公只爱吃这家的粉折，我也拿他没办法。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giNpcFaceToCurrentPlayer("4011", true);
        giRandTalkRelease();
        giRandTalkPush("秋荻：一听说山上的妖怪已经被除去了，我相公就高兴得不得了，一定要我上市集来多买些小菜，说是要庆贺！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4011", true);
            giTalk("秋荻：寿阳粉折是用绿豆混着麦粉和佐料在锅上烙出来的，其实我自己也能做。只是小张这儿的粉折得了城外真武庙里和尚大师父的真传，我自己可烙不出这味道～", "");
        }
        else
        {
            giNpcFaceToNpc("4011", "4012", true);
            giNpcFaceToNpc("4012", "4011", true);
            giTalk("秋荻：呵呵，我相公三天不吃这里的粉折就难受，真拿他没办法。", "");
            giTalk("粉折张：哈哈哈，这也没什么，柳大人家的夫人也喜欢吃粉折，常派丫鬟来买呢！", "");
        }
    }
    giNpcResetDir("4011");
    giNpcResumeBeh("4011");
    giPlayerUnLock();
}

void func4012()
{
    giPlayerLock();
    giNpcPauseBeh("4012");
    giNpcFaceToCurrentPlayer("4012", true);
    giCurrentPlayerFaceToNpc("4012", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("粉折张：今年是不能采离香草了，不过我看大伙的日子也没比从前差，至少我这小摊的生意还是不错～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("粉折张：你……你就是上次来寿阳，住在柳家的小伙子吧？你小子真不赖，几天不见，现在穿得跟什么似的，害我差点就认不出来啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("粉折张：山上妖怪没了是好事，至于能不能上山采草嘛，就跟我没多大关系了。我张家世代卖粉折，我也不必靠什么离香草过活。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("粉折张：我这做粉折的手艺是跟城外真武庙的和尚学的，连县令夫人也爱吃得不得了！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4012");
    giNpcResumeBeh("4012");
    giPlayerUnLock();
}

void func4013()
{
    giPlayerLock();
    giNpcPauseBeh("4013");
    giNpcFaceToCurrentPlayer("4013", true);
    giCurrentPlayerFaceToNpc("4013", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("豆腐西施：城里虽然太平，但外面的世道如何，人家是半点也不晓得的～人家只管做豆腐赚钱，已经很辛苦了～", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("豆腐西施：人家这豆腐是用寿阳城外的珍珠泉水磨的，买些回去煮汤喝，一定比别处的豆腐都鲜美～");
        giRandTalkPush("豆腐西施：做豆腐的方子相传是淮南王留下来的，所以寿阳的豆腐，也叫八公山豆腐～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4013");
    giNpcResumeBeh("4013");
    giPlayerUnLock();
}

void func4014()
{
    giPlayerLock();
    giNpcPauseBeh("4014");
    giNpcFaceToCurrentPlayer("4014", true);
    giCurrentPlayerFaceToNpc("4014", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("沈仕途：沈家现在就指望状元那孩子能好好念书，将来考个状元！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("沈仕途：柳世封的事儿还真多，说要采这离香草的是他，说不要再采的，又是他～这样的父母官，竟然还有那么多老百姓喜欢，真让我想不明白。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("沈仕途：我自问我的文治武功都不比柳世封差，若这寿阳城让我来治理，一定比他管得好！可叹这世道不是唯才是用……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4014");
    giNpcResumeBeh("4014");
    giPlayerUnLock();
}

void func4015()
{
    giPlayerLock();
    giNpcPauseBeh("4015");
    giNpcFaceToCurrentPlayer("4015", true);
    giCurrentPlayerFaceToNpc("4015", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("沈状元：我的名字是爷爷取的，听爹说，是因为爷爷太想我长大能中状元了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("沈状元：爷爷总说他当官能当得比柳大人好，我看这世上才没有比柳大人更好的官呢～");
        giRandTalkPush("沈状元：爷爷经常在屋子里叹气，好像是因为一直没考上状元……其实爷爷可以去找柳大人帮忙，有什么事情是柳大人做不到的呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4015");
    giNpcResumeBeh("4015");
    giPlayerUnLock();
}

void func4016()
{
    giPlayerLock();
    giNpcPauseBeh("4016");
    giNpcFaceToCurrentPlayer("4016", true);
    giCurrentPlayerFaceToNpc("4016", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("莲琪：巢湖另一边的太平村出产一种临睦茶，都已经卖到京里去了……真想尝尝那茶什么味道！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("莲琪：山上的妖怪已经被剑仙除去了，柳县令却发了告示让大家别去采香草，我不明白这是为什么……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("莲琪：离香草是我们寿阳才有的东西，游子带在身上，离故乡越远，香气就会越浓。哥哥，你的故乡在哪里呢？");
        giRandTalkPush("莲琪：吴叔叔总说他卖的月牙蹄味道好，可我只喜欢张叔叔的粉折，粉折下到娘调的汤里面，味道比什么都好！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4016");
    giNpcResumeBeh("4016");
    giPlayerUnLock();
}

void func4017()
{
    giPlayerLock();
    giNpcPauseBeh("4017");
    giNpcFaceToCurrentPlayer("4017", true);
    giCurrentPlayerFaceToNpc("4017", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("童小石：自从剑仙来八公山除了妖，这寿阳城周围，就再也没人见过妖怪啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("童小石：柳大人让大家少采离香草，一定有他的道理！反正寿阳好东西多，明年若是没有宁香可贡，把吴叔叔做的月牙蹄送去京里也行嘛！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("童小石：哈哈，你是不是第一次来寿阳？要不要尝尝五香茶干？炒菜好吃、配茶也好吃！");
        giRandTalkPush("童小石：吴叔叔做的“金边红心月牙蹄”实在美味，我一天不吃就馋得慌！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4017");
    giNpcResumeBeh("4017");
    giPlayerUnLock();
}

void func4018()
{
    giPlayerLock();
    giNpcPauseBeh("4018");
    giNpcFaceToCurrentPlayer("4018", true);
    giCurrentPlayerFaceToNpc("4018", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("心清：魔由心生、障由心生，巢湖中本无妖孽，是人心自生妖孽；心中魔障既除，湖中妖孽亦自然不见。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("心清：阿弥陀佛！善有善报，恶有恶报，山上妖孽为剑仙所铲除，也都是寿阳百姓平日行善积德换来的福报啊。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("心清：柳县令是城中第一大善人，他不仅令所有寿阳百姓衣食无忧，更是慷慨出资重修这东禅寺。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResumeBeh("4018");
    giPlayerUnLock();
}

void func4019()
{
    giPlayerLock();
    giNpcPauseBeh("4019");
    giNpcFaceToCurrentPlayer("4019", true);
    giCurrentPlayerFaceToNpc("4019", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("丁巧儿：最近店里的生意越来越好，爹说要多雇几个伙计来帮忙，到时候可就不用像现在这样整天忙个不停啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("丁巧儿：说起来，八公山上的妖怪也闹了好一阵子，我还担心它们会不会闹进城，多亏有剑仙来除妖，现在终于可以放心了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("丁巧儿：这如意铺的店名，是街坊邻居一块儿想出来的，大伙都说只要有柳县令在，我们寿阳城的家家户户，年年月月都称心如意！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4019");
    giNpcResumeBeh("4019");
    giPlayerUnLock();
}

void func4020()
{
    giPlayerLock();
    giNpcPauseBeh("4020");
    giNpcFaceToCurrentPlayer("4020", true);
    giCurrentPlayerFaceToNpc("4020", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("宋敏春：上次我让施家妹子用檀香提神，没想到她现在用上瘾了，天天都用，整个人都有淡淡的香气～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("宋敏春：昨天还说到妖怪害人，今天山上的妖就已经没了，这都要感谢上天开眼啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkPush("宋敏春：施家妹子她爹，昨天傍晚在山上遇到妖怪啦！现在人是回来了，就不知道有没有受伤……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("宋敏春：我看施家妹子这几天精神很差，该不会是跟她娘一起制香，睡得太少累着了吧？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4020");
    giNpcResumeBeh("4020");
    giPlayerUnLock();
}

void func4021()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4021");
    giCurrentPlayerFaceToNpc("4021", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4021", true);
        giTalk("施青青：我们寿阳的宁香是皇上御封的“天下第五香”，就算太平村的茶叶进京了，也别想和宁香比～", "");
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giNpcFaceToCurrentPlayer("4021", true);
        giTalk("施青青：这阵子精神不太好，本想听宋大姐的话去买些檀香来用，但爹爹又被妖怪咬伤了，我现在哪还有心思顾上檀香的事啊，只好一直跑药铺给爹爹买药。", "");
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giNpcFaceToCurrentPlayer("4021", true);
        giTalk("施青青：那天爹爹一个人上山采草，傍晚下山的时候就真的遇到妖怪了！要不是他腿脚俐落跑得快，就不只是被咬一口那么简单了！", "");
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4021", true);
            giTalk("施青青：涵草堂永家的母女俩，原本不太会制香，都是得了柳小姐指点，如今她们靠自己的手艺，也算是吃穿不愁了。", "");
        }
        else
        {
            giNpcFaceToNpc("4021", "4020", true);
            giNpcFaceToNpc("4020", "4021", true);
            giTalk("施青青：最近我总觉得精神很糟，昨天走在路上差点睡着，还撞了人，被笑话了好一阵。", "");
            giTalk("宋敏春：要真是这样，你可以去涵草堂买些檀香，每天在炉子里放一些，听说这法子是柳大人的千金告诉永馨的，永馨又告诉了我～", "");
            giTalk("施青青：檀香？那东西可不便宜呐……", "");
        }
    }
    giNpcResetDir("4020");
    giNpcResetDir("4021");
    giNpcResumeBeh("4021");
    giPlayerUnLock();
}

void func4022()
{
    giPlayerLock();
    giNpcPauseBeh("4022");
    giNpcFaceToCurrentPlayer("4022", true);
    giCurrentPlayerFaceToNpc("4022", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("赵孟坚：哎？云公子，你怎么来了？可是要找我家大人？大人和夫人一起进京了，一时半会应该回不来。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("赵孟坚：常有人听说我家小姐貌美，找尽理由要见上一面，他们也不看看自己的模样，个个都是纨绔子弟，哪里配得上小姐！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("赵孟坚：此乃县令大人的府邸，若无拜帖，不能随意入内！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4022");
    giNpcResumeBeh("4022");
    giPlayerUnLock();
}

void func4023()
{
    if (global_mvar <= 40100 && var_shop021 == 0 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        giPlayerSetPos(0, 2395.1301, -13.7906, -1348.6891);
        giPlayerSetAng(0, 224.0);
        giCameraPrepare("NPC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, false);
        giCameraRunSingle("002", true);
        giTalk("葛大路：哈哈哈～这城里几乎没人见过柳家千金的容貌，说不准是个丑八怪，我今天就要从这儿游进县令府，看看她到底长什么样！", "");
        giSetNpcVisible("4100", true);
        giCameraWait();
        giCameraRunSingle("003", false);
        giNpcDoAction("4100", "J01", -1, false);
        giWait(0.30000001192092896);
        giTalk("周晨浩：好你个小贼！竟敢在这里偷窥！我要带你回去让柳大人亲自发落！", "");
        giWait(2.0);
        giNpcFaceToNpc("4023", "4100", true);
        giTalk("葛大路：糟了！有官差！好汉不吃眼前亏，我闪～", "");
        giNpcBlendOut("4023", 0.3, false);
        giEffectPlayWithNPC("H_121", 1, "4023");
        giWait(1.5);
        giNpcRunTo("4100", 2253.7327, -11.2906, -1652.4047, false);
        giCameraRunSingle("004", false);
        giTalk("周晨浩：小贼别跑！！", "");
        giNpcEndMove("4100");
        giNpcBlendOut("4100", 0.3, false);
        giEffectPlayWithNPC("H_121", 1, "4100");
        giWait(1.0);
        giCameraRunSingle("005", true);
        giSetPortrait("101C", true);
        giTalk("云天河：……？", "40445; 40632; 41503; 41617; 41674; 41736; 41924; 42558; 42636; 43483; 44255; 46035");
        giFlashOutBlack(1.0, true, true);
        var_shop021 = 1;
        giFlushTailYAngle();
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func4024()
{
    giPlayerLock();
    giNpcPauseBeh("4024");
    giNpcFaceToCurrentPlayer("4024", true);
    giCurrentPlayerFaceToNpc("4024", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("永馨：以前梦璃小姐在，还会和我说说制香的法子，如今她不在城里，要我找谁去问啊？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giRandTalkPush("永馨：衙门那张告示真的让人摸不着头脑啊……这不能再采离香草，不就做不出“宁香”进贡了吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkPush("永馨：店里有些药材都快没了，可山上有妖怪，叫人怎么敢去采药啊？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("永馨：沉香、檀香、龙脑香、麝香是四种最为名贵的香，当今皇上封我们寿阳的香为“天下第五香”，从此“沉檀龙麝”之后，就是“宁香”啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4024");
    giNpcResumeBeh("4024");
    giPlayerUnLock();
}

void func4025()
{
    giPlayerLock();
    giNpcPauseBeh("4025");
    giNpcFaceToCurrentPlayer("4025", true);
    giCurrentPlayerFaceToNpc("4025", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("溪莲：柳家的仙女姐姐离开寿阳好久好久了，到底什么时候才能回来呢？溪莲好想她哦……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("溪莲：离离香草生故乡，临行勿忘备行囊，香气幽幽愿君记，离香散尽是故乡～嘻，莲儿已经会背诗了，很聪明吧？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4025");
    giNpcResumeBeh("4025");
    giPlayerUnLock();
}

void func4026()
{
    giPlayerLock();
    giNpcPauseBeh("4026");
    giNpcFaceToCurrentPlayer("4026", true);
    giCurrentPlayerFaceToNpc("4026", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("郭正忠：自从柳大人进京办事以来，寿阳城里大大小小的事情都是裴捕头在打理，没想到他一个习武之人，竟有这番才干。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkRelease();
        giRandTalkPush("郭正忠：柳大人为官清廉，爱民如子，连上天都受到了感动，所以才派剑仙来帮我们除去了八公山上的妖怪！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giTalk("郭正忠：你在此处张望什么？是要伸冤还是要告状？", "");
        giSetPortrait("101C", true);
        giTalk("云天河：……啥意思？", "");
        giTalk("郭正忠：……都不是的话，就快点离开，衙门乃肃静之地，别在这儿闲逛。", "");
    }
    giNpcResetDir("4026");
    giNpcResumeBeh("4026");
    giPlayerUnLock();
}

void func4027()
{
    giPlayerLock();
    giNpcPauseBeh("4027");
    giNpcFaceToCurrentPlayer("4027", true);
    giCurrentPlayerFaceToNpc("4027", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("宋旭鸣：最近上山采草的人少了，不过寿阳的宁香在京城里的价钱涨了不少，没想到少做宁香也有好处，柳大人真是有先见之明啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("宋旭鸣：听县令府里的柳勤说，为了这妖怪的事，柳大人已经许多天没睡好觉了，如今总算能安心了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("宋旭鸣：柳大人常常会在衙门处理公务到三更半夜，比起那些自称大侠英雄，却整天只会打打杀杀的江湖中人，真心为民的柳大人才是当之无愧的真英雄！");
        giRandTalkPush("宋旭鸣：上回城里莫名其妙闹毒虫，柳小姐说可以燃香驱虫，一试之下果然有效～但小姐她一直都只替柳大人出主意，自己却从不露面，连我都没见过她的长相……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4027");
    giNpcResumeBeh("4027");
    giPlayerUnLock();
}

void func4028()
{
    giPlayerLock();
    giNpcPauseBeh("4028");
    giNpcFaceToCurrentPlayer("4028", true);
    giCurrentPlayerFaceToNpc("4028", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("卓见慈：本来我还担心呐，这采的离香草少了，大伙的日子会不会不好过？没想到现在宁香的价钱涨了，看来还是菩萨保佑～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("卓见慈：我这几天一直在求菩萨保佑，没想到菩萨真的显灵了，不然怎么会有剑仙来除妖？真是要感激菩萨救苦救难啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkPush("卓见慈：上次是谭婆遇妖怪，这回是青青的爹被咬伤！阿弥陀佛！求菩萨多保佑保佑我们寿阳，别再让谁被妖怪咬了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("卓见慈：东禅寺整修也有些时日了，我想等禅寺修好之后，就去寺里给柳大人全家捐长生牌位，求菩萨保佑他们长命百岁。");
        giRandTalkPush("卓见慈：东禅寺的心清方丈确实是个慈眉善目的大好人啊，这次重修寺院，他一个人东奔西走，劳心又劳力。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4028");
    giNpcResumeBeh("4028");
    giPlayerUnLock();
}

void func4029()
{
    giPlayerLock();
    giNpcPauseBeh("4029");
    giNpcFaceToCurrentPlayer("4029", true);
    giCurrentPlayerFaceToNpc("4029", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("成诗京：柳小姐离开寿阳已经很久，听说是修仙去了……要是她真的成了仙人，岂不是从此与我无缘？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("成诗京：我听说柳府里来了个陌生男人！和柳小姐年龄相仿，莫非、莫非他是柳小姐的心上人？！不可能，这绝对不可能！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("成诗京：我对柳小姐仰慕已久，却苦于不能一见……只好在柳府外候着，若能有幸一睹她的芳容，我、我就算死了也甘愿……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4029");
    giNpcResumeBeh("4029");
    giPlayerUnLock();
}

void func4030()
{
    giPlayerLock();
    giNpcPauseBeh("4030");
    giNpcFaceToCurrentPlayer("4030", true);
    giCurrentPlayerFaceToNpc("4030", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("谢媒婆：柳小姐离开寿阳也有些日子了，前阵子我看见柳家夫妇从府里出来，坐上马车出城去了，难不成是要去哪里探望自己的闺女？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("谢媒婆：哎，柳家闺女啊，八成有了心上人，说不定还是自小订的娃娃亲呢！不然柳大人怎么一点也不着急她的终身大事……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("谢媒婆：说也怪了，这城里明明没几个人见过柳家闺女的相貌，偏偏总有人托我去柳府说媒，依我看呐，他们还不是看上她爹是个县令……");
        giRandTalkPush("谢媒婆：从寿阳远嫁别处的闺女啊，出嫁的时候身上都得带着离香草～离故乡越远，那香气越浓。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4030");
    giNpcResumeBeh("4030");
    giPlayerUnLock();
}

void func4031()
{
    giPlayerLock();
    giNpcPauseBeh("4031");
    giNpcFaceToCurrentPlayer("4031", true);
    giCurrentPlayerFaceToNpc("4031", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("尤向石：上回我去柳家提亲，柳大人竟然说他女儿已经离开了寿阳，这……不会是偷偷嫁掉了吧？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("尤向石：想我尤向石也算长得一表人才，要钱有钱，要权嘛～这功名也可以用钱买到！我到底哪里不合柳小姐的意，别说答应嫁给我，她连见我一面都不肯！");
        giRandTalkPush("尤向石：柳小姐总在深闺之中，大门不出，二门不迈，想必是个娴良淑德的女子，若她能嫁给我尤向石，那真是再般配不过了！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4031");
    giNpcResumeBeh("4031");
    giPlayerUnLock();
}

void func4032()
{
    giPlayerLock();
    giNpcPauseBeh("4032");
    giNpcFaceToCurrentPlayer("4032", true);
    giCurrentPlayerFaceToNpc("4032", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("孔三刚：上山采离香草的人越来越少了，不过听柳大人说明年进贡的香料都已经备齐了，如果真是这样，那么少采点倒也没关系～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("孔三刚：这次柳大人离开寿阳城，就把城里的事情都交给裴捕头打点了。不过裴捕头也很能干，柳大人出去这许多天了，城里还真没出什么事。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("孔三刚：从这里出城就上山了，东边山上的是淮南王陵，西边山上的就是女萝岩。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4032");
    giNpcResumeBeh("4032");
    giPlayerUnLock();
}

void func4033()
{
    giPlayerLock();
    giNpcPauseBeh("4033");
    giNpcFaceToCurrentPlayer("4033", true);
    giCurrentPlayerFaceToNpc("4033", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("孙强：本以为柳大人去了京城，这几天稍微偷点懒不打紧，没想到裴捕头管得比柳大人在的时候更严，稍微打个哈欠被看到就要挨骂！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkRelease();
        giRandTalkPush("孙强：八公山之所以叫八公山，好像是因为从前有个淮南王和另外八个人在这里得道成仙，据说当时王府里的鸡犬吃了剩下的仙丹，也都成仙啦！真羡慕～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 21900 /* 第一章 / 2-2-1.徒惹官非 / 拜访柳府 / 寿阳揭榜 */)
    {
        giRandTalkRelease();
        giRandTalkPush("孙强：城里上山采药采草的人，没少被山上的妖怪咬伤！你们几个上山捉妖，可千万要小心！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giTalk("孙强：城北的山上最近不太平，如果没什么重要的事，还是不要出城的好。", "");
    }
    giNpcResetDir("4033");
    giNpcResumeBeh("4033");
    giPlayerUnLock();
}

void func4034()
{
    giPlayerLock();
    giNpcPauseBeh("4034");
    giNpcFaceToCurrentPlayer("4034", true);
    giCurrentPlayerFaceToNpc("4034", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("笑鱼儿：娘说就算不上山采草～我们也过得够好了，每天都能吃到鱼和肉～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giRandTalkPush("笑鱼儿：县令府的仙女姐姐什么都会，一定是她请来了剑仙除了妖！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 30300 /* 第一章 / 2-5-2.女萝平妖 / 柳府故人 */)
    {
        giRandTalkPush("笑鱼儿：娘常常上山去采草，可是现在山上有妖怪了……怎么办？我好怕娘被妖怪吃了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("笑鱼儿：你听说过寿阳城外的八公山吗？我娘说山里藏着长生不老的秘密哦～");
        giRandTalkPush("笑鱼儿：溪莲常念的那首诗是县令府的仙女姐姐作的，我长大了也要和仙女姐姐一样，作首大家都喜欢的诗！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4034");
    giNpcResumeBeh("4034");
    giPlayerUnLock();
}

void func4035()
{
    giPlayerLock();
    giNpcPauseBeh("4035");
    giNpcFaceToCurrentPlayer("4035", true);
    giCurrentPlayerFaceToNpc("4035", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("郭志远：东禅寺修了也有半年多，心清大师每日在寺内寺外照应着，操劳了这么久，也真够辛苦的。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("郭志远：剑仙神通广大，竟然知道我们正为山上妖怪所苦，特地赶来除妖！剑仙慈悲、菩萨慈悲，等东禅寺修好了，我一定去多烧几柱高香。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("郭志远：暮鼓晨钟，指的就是庙里的和尚早晨敲这钟楼的钟，晚上打那边鼓楼的鼓～啥？你问我和尚为什么要打鼓敲钟？我又不是和尚，我怎么会知道。");
        giRandTalkPush("郭志远：钟楼上的巨钟声音洪亮，用力敲击的话，城外都能听见，不过东禅寺正在整修，和尚都住到别处去了，最近也没人敲钟了……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4035");
    giNpcResumeBeh("4035");
    giPlayerUnLock();
}

void func4036()
{
    giPlayerLock();
    giNpcPauseBeh("4036");
    giNpcFaceToCurrentPlayer("4036", true);
    giCurrentPlayerFaceToNpc("4036", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("洛丹霞：当年秦王苻坚战败淝水，就是往八公山方向撤退。我曾沿着八公山麓往东直到淝水，一路上看遍晋时古风，这趟寿阳也不算白来了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("洛丹霞：寿阳附近最多的就是泉水，什么水晶泉、玛瑙泉、还有珍珠泉。城里人说那些泉水的味道都不一样，可惜我还没一一尝过……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("洛丹霞：我这趟来寿阳，是为了瞻仰城东淝水古战场之貌～虽然身为女儿家，但我早就打定主意，要像爹一样走遍所有名山大川，把那些美景都写进书里！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4036");
    giNpcResumeBeh("4036");
    giPlayerUnLock();
}

void func4037()
{
    giPlayerLock();
    giNpcPauseBeh("4037");
    giNpcFaceToCurrentPlayer("4037", true);
    giCurrentPlayerFaceToNpc("4037", true);
    giTalk("周晨浩：我负责在城内巡逻，要是你看到什么可疑人物，可随时向我通报。", "");
    giNpcResetDir("4037");
    giNpcResumeBeh("4037");
    giPlayerUnLock();
}

void func4038()
{
    giPlayerLock();
    giNpcPauseBeh("4038");
    giNpcFaceToCurrentPlayer("4038", true);
    giCurrentPlayerFaceToNpc("4038", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("陆羽恒：爹和娘直到上个月才告诉我，原来我自小定了亲，对方竟然还是武林世家……这、这可如何是好，女子舞刀弄剑，岂不变得性情暴烈？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("陆羽恒：所谓娶妻当娶贤，我虽未及弱冠，但已想好自己未来的妻子一定要温柔贤惠、谨守妇德。若像柳大人的夫人那样，时常在外抛头露面，实在不太好啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4038");
    giNpcResumeBeh("4038");
    giPlayerUnLock();
}

void func4039()
{
    giPlayerLock();
    giNpcPauseBeh("4039");
    giNpcFaceToCurrentPlayer("4039", true);
    giCurrentPlayerFaceToNpc("4039", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("毛令毅：原以为不能多采离香草，会对城里的百姓有很大影响，没想到现在宁香的价钱反而高了，柳县令行事果然英明～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("毛令毅：寿阳西南淮水和颖口相交处原有苍陵城，只是已经毁于战乱，现在只剩下废墟，实在很可惜。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4039");
    giNpcResumeBeh("4039");
    giPlayerUnLock();
}

void func4040()
{
    giPlayerLock();
    giNpcPauseBeh("4040");
    giNpcFaceToCurrentPlayer("4040", true);
    giCurrentPlayerFaceToNpc("4040", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("朱心蕾：对街沈家的那孩子取名叫状元，为的就是想他长大了考个状元回来。不过他家老爷子学问不怎么样，那孩子跟着老爷子学，恐怕到时候也是考不中状元的。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("朱心蕾：先有柳家教我们制香，后有剑仙为我们除妖，寿阳城一定是有神仙保佑的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("朱心蕾：柳家人真是我们寿阳的大恩人呐，要不是他们传给百姓制香的法子，大伙哪有现在的好日子呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4040");
    giNpcResumeBeh("4040");
    giPlayerUnLock();
}

void func4041()
{
    giPlayerLock();
    giNpcPauseBeh("4041");
    giNpcFaceToCurrentPlayer("4041", true);
    giCurrentPlayerFaceToNpc("4041", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("莫如长：那天我看见县令府里走出来一个丫鬟，真是漂亮呀～听说那就是以前柳小姐的贴身丫鬟，名叫禄翠。我这就来找媒婆去提亲，小姐我娶不到，丫鬟总没问题吧？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("莫如长：谢媒婆说县令千金已经有了未婚夫婿，这怎么可能？！分明是推托之辞！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("莫如长：这谢媒婆真是不识抬举，本公子重金请她去县令府上说媒，她却一副爱理不理的样子……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4041");
    giNpcResumeBeh("4041");
    giPlayerUnLock();
}

void func4042()
{
    giPlayerLock();
    giNpcPauseBeh("4042");
    giNpcFaceToCurrentPlayer("4042", true);
    giCurrentPlayerFaceToNpc("4042", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("仇敬：日子越过越太平，县衙大牢里面已经好几个月没犯人啦！要是牢里一直都没犯人，我就不用天天在这儿傻站了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("仇敬：柳大人竟然就这样放走了好不容易才抓到的女贼，真是让人想不明白……不过大人行事一向有他的道理，我们当差的还是不要问太多。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("仇敬：慢！再往里走可就是关押犯人的牢房，难道你是来探监的？裴捕头允许了吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4042");
    giNpcResumeBeh("4042");
    giPlayerUnLock();
}

void func4043()
{
    giPlayerLock();
    giNpcPauseBeh("4043");
    giNpcFaceToCurrentPlayer("4043", true);
    giCurrentPlayerFaceToNpc("4043", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("心净：心清方丈一直想在寺庙中建一座宝塔，好用来供奉他去年偶得的一颗舍利子。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("心净：我跟着方丈来此查看重修大殿的情况，看这情形，应该花不了几个月了，只是如要造塔，没有三、五年是不成的。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("心净：东禅寺香火向来很旺，这次重修也多亏了寿阳百姓的捐助，我们不仅能重修大殿，还能再造一座九层佛塔。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4043");
    giNpcResumeBeh("4043");
    giPlayerUnLock();
}

void func4044()
{
    giPlayerLock();
    giNpcPauseBeh("4044");
    giNpcFaceToCurrentPlayer("4044", true);
    giCurrentPlayerFaceToNpc("4044", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("何常卫：城西南十五里外有座小城，据说是当年刘备被曹操围困的地方，现在只剩下一堆破土墙了，不过倒还能看出原先城墙的样子来。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giRandTalkPush("何常卫：以前淮河发大水时常会冲坏寿阳的城墙，是柳县令带着方圆百里的百姓重修了城墙，许多年了，还是这么牢固啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("何常卫：此门是寿阳通淝门，取“通淝水”的意思，不过由此往南是巢湖，淝水之战的古战场在东边宾阳门外。");
        giRandTalkPush("何常卫：进城时要穿过的那道外城墙叫做“月城”，战时可驻兵，也可将敌人引至月城内，关上两处城门，在城墙上放箭杀敌。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4044");
    giNpcResumeBeh("4044");
    giPlayerUnLock();
}

void func4045()
{
    giPlayerLock();
    giNpcPauseBeh("4045");
    giNpcFaceToCurrentPlayer("4045", true);
    giCurrentPlayerFaceToNpc("4045", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("卢莫石：柳大人和夫人如今都不在府里，据说是去京城办事了，唉，我什么时候也能去趟京里啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("卢莫石：孟坚总想着县令府里的丫鬟禄蓉，那禄蓉长得也没禄翠漂亮，人也没禄翠大方，照我看，要娶就娶禄翠才好！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4045");
    giNpcResumeBeh("4045");
    giPlayerUnLock();
}

void func4046()
{
    giPlayerLock();
    giNpcPauseBeh("4046");
    giNpcFaceToCurrentPlayer("4046", true);
    giCurrentPlayerFaceToNpc("4046", true);
    if (global_mvar >= 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giRandTalkRelease();
        giRandTalkPush("柳奉：原来是您保护小姐上山查妖怪的事，果然是少年英雄，够胆识！也只有您这样的少侠才配得上我们小姐！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giTalk("柳奉：要说我家老爷，那可是寿阳城的第二号人物！城里百姓遇到什么大困难，多半会想到我家老爷！", "");
        giTalk("柳奉：啥？你是不是想问我这第一号人物是谁？嘿嘿，天机不可泄露～", "");
    }
    giNpcResetDir("4046");
    giNpcResumeBeh("4046");
    giPlayerUnLock();
}

void func4047()
{
    giPlayerLock();
    giNpcPauseBeh("4047");
    giNpcFaceToCurrentPlayer("4047", true);
    giCurrentPlayerFaceToNpc("4047", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giRandTalkRelease();
        giRandTalkPush("柳忠：小姐从小在府里长大，什么时候一个人出过远门了？这一路上舟车劳顿，就算有姑爷照顾，也还是很辛苦的事啊。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("柳忠：那年云大侠送小姐来的时候，小姐才那么一丁点儿大！没想到一晃眼就是好多年，小姐也到了该嫁人的时候啦！");
        giRandTalkPush("柳忠：听说老爷为小姐相中的姑爷就是云大侠的公子，只是小姐似乎不怎么中意这位姑爷……唉，女儿家的心思，我们这等粗人当真猜不透……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4047");
    giNpcResumeBeh("4047");
    giPlayerUnLock();
}

void func4048()
{
    giPlayerLock();
    giNpcPauseBeh("4048");
    giNpcFaceToCurrentPlayer("4048", true);
    giCurrentPlayerFaceToNpc("4048", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giTalk("柳诚：禄翠平时总喜欢小姐长小姐短，这回小姐出远门，也不带她一起去，我看她要难受一阵子啦。", "");
    }
    else if (global_mvar >= 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giRandTalkRelease();
        giRandTalkPush("柳诚：我家小姐这样神仙般的人，有谁能配得起她……依我看，就算一辈子不嫁，也好过一朵鲜花插牛粪……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("柳诚：你……你就是老爷故人的儿子？可那从牢里出来的韩姑娘又是谁？县令府上留宿要犯，这……我总觉得不妥当。");
        giRandTalkPush("柳诚：从这儿往西穿过一道门，就是前厅，老爷、夫人，还有小姐，今天早早的就等在那儿了，好像在等什么人的样子……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4048");
    giNpcResumeBeh("4048");
    giPlayerUnLock();
}

void func4049()
{
    giPlayerLock();
    giNpcPauseBeh("4049");
    giNpcFaceToCurrentPlayer("4049", true);
    giCurrentPlayerFaceToNpc("4049", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giRandTalkRelease();
        giRandTalkPush("赵三娘：我也是看着小姐长大的，一想到她要出远门，还不知道什么时候回来，我这心里就有些舍不得……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("赵三娘：夫人呐，就是心地好～她喜欢吃斋，老爷疼夫人，小姐孝顺夫人，所以除非是有贵客来，整个柳府上下都跟着夫人吃素。");
        giRandTalkPush("赵三娘：当年我们老爷刚当上寿阳县令时，曾经结交过一个侠士，那段日子两人常常在前厅喝酒，喝到醉倒才罢休。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4049");
    giNpcResumeBeh("4049");
    giPlayerUnLock();
}

void func4050()
{
    giPlayerLock();
    giNpcPauseBeh("4050");
    giNpcFaceToCurrentPlayer("4050", true);
    giCurrentPlayerFaceToNpc("4050", true);
    if (global_mvar >= 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giRandTalkRelease();
        giRandTalkPush("西山：女萝岩的妖怪真是被你除去的？要说是小姐做的，我倒也相信，至于你嘛，哎，真是人不可貌相……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("西山：小姐住在后院，那地方可不是我们这些粗人能随便去的。其实我在柳家当差半年多，从来都没去过后院呢。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4050");
    giNpcResumeBeh("4050");
    giPlayerUnLock();
}

void func4051()
{
    giPlayerLock();
    giNpcPauseBeh("4051");
    giNpcFaceToCurrentPlayer("4051", true);
    giCurrentPlayerFaceToNpc("4051", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giRandTalkRelease();
        giRandTalkPush("禄蓉：我听府里其他人说，小姐一向是很少出门的，老爷和夫人对小姐更是宝贝得不得了，辟了个后院只她一人住，这回又怎么舍得让她出远门呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("禄蓉：说也奇怪，自从我来了柳家，每天夜里都睡得特别香，连梦也不做，好像还能闻到阵阵花香呢！");
        giRandTalkPush("禄蓉：老爷和夫人脾气都很好，上回我打扫卧房的时候不小心砸坏一个花瓶，他们也没骂我，更没说要扣我的工钱～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4051");
    giNpcResumeBeh("4051");
    giPlayerUnLock();
}

void func4052()
{
    giPlayerLock();
    giNpcPauseBeh("4052");
    giNpcFaceToCurrentPlayer("4052", true);
    giCurrentPlayerFaceToNpc("4052", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giRandTalkRelease();
        giRandTalkPush("柳勤：我倒觉得小姐是应该去外面走走玩玩，每天闷在家里岂不要闷坏了～她那么聪明，什么事都难不倒她，就算出门应该也能照顾好自己。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("柳勤：老爷常在书房里批阅卷宗到深夜，最近城外闹妖怪，老爷更是整夜在此思索对策，到天亮都不合一下眼，这样下去身体怎么受得了……");
        giRandTalkPush("柳勤：城里的百姓都夸赞我家老爷勤政爱民，可谁又知道这几句话是老爷用多少年的劳心劳力换来的啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4052");
    giNpcResumeBeh("4052");
    giPlayerUnLock();
}

void func4053()
{
    giPlayerLock();
    giNpcPauseBeh("4053");
    giNpcFaceToCurrentPlayer("4053", true);
    giCurrentPlayerFaceToNpc("4053", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giRandTalkRelease();
        giRandTalkPush("柳常：老爷也真是的，什么事都顺着小姐，这次小姐出远门，万一有什么闪失可怎么办啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("柳常：看你这打扮，不像是哪家公子，说是大侠嘛，倒也称不上，老爷究竟看上你哪一点？竟想招你做女婿……");
        giRandTalkPush("柳常：这园子的尽头就是小姐平日制香的地方，柳府里的人都知道，尽量不要去打扰小姐。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4053");
    giNpcResumeBeh("4053");
    giPlayerUnLock();
}

void func4054()
{
    giPlayerLock();
    giNpcPauseBeh("4054");
    giNpcFaceToCurrentPlayer("4054", true);
    giCurrentPlayerFaceToNpc("4054", true);
    giTalk("禄珠：小姐虽然不是老爷和夫人的亲生女儿，但平日里对他们俩十分孝顺，老爷治理寿阳城，小姐还私下帮他出了不少主意呢～", "");
    giNpcResetDir("4054");
    giNpcResumeBeh("4054");
    giPlayerUnLock();
}

void func4055()
{
    giPlayerLock();
    giNpcPauseBeh("4055");
    giNpcFaceToCurrentPlayer("4055", true);
    giCurrentPlayerFaceToNpc("4055", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giRandTalkRelease();
        giRandTalkPush("柳心：哈哈，姑爷您真是了不得！女萝岩闹妖怪，您一出马，就啥事都没有了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("柳心：我绝对不是在做梦！这柳府在夜里经常会有奇怪的香气，闻着闻着就睡着了，一觉睡到大天亮，睡得特别香，可我总觉得心里不踏实……这究竟是怎么一回事啊？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4055");
    giNpcResumeBeh("4055");
    giPlayerUnLock();
}

void func4056()
{
    giPlayerLock();
    giNpcPauseBeh("4056");
    giNpcFaceToCurrentPlayer("4056", true);
    giCurrentPlayerFaceToNpc("4056", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giTalk("禄翠：官家小姐出嫁不是都带丫鬟的吗？这次小姐跟着姑爷您走了，跟出嫁有什么不一样？为什么不肯带我一起去？", "");
    }
    else if (global_mvar >= 31400 /* 第一章 / 2-5-7.女萝平妖 / 府中清闲 */)
    {
        giRandTalkRelease();
        giRandTalkPush("禄翠：用离香草制宁香的法子，其实是小姐告诉老爷，老爷再传给寿阳百姓的～她还会制许多其他的香，譬如给夫人用来修禅供佛的瑞脑香～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("禄翠：今天一大早我就见小姐去了前厅，到底是什么事非得她亲自去办呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4056");
    giNpcResumeBeh("4056");
    giPlayerUnLock();
}

void func4057()
{
    giPlayerLock();
    giNpcPauseBeh("4057");
    giNpcFaceToCurrentPlayer("4057", true);
    giCurrentPlayerFaceToNpc("4057", true);
    if (global_mvar >= 31500 /* 第一章 / 2-5-8.女萝平妖 / 回房休息 */)
    {
        giRandTalkRelease();
        giRandTalkPush("禄芙：原以为小姐是不可能嫁给你的，可看她今天的样子，对你似乎又不错～从来也没人能猜中她的心思。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("禄芙：我家小姐向来都很有主意，老爷在衙门里头痛的事情，小姐常常能想到一些不错的法子～");
        giRandTalkPush("禄芙：老爷很少留人在家作客的，难道、难道你真是我家小姐的未婚夫婿？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4057");
    giNpcResumeBeh("4057");
    giPlayerUnLock();
}

void func4101()
{
    giPlayerLock();
    giNpcPauseBeh("4101");
    giNpcFaceToCurrentPlayer("4101", true);
    giCurrentPlayerFaceToNpc("4101", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("阿福：寿阳东有淝水古战场，西有禹王庙，南有巢湖，北有八公山，客官您可以在咱客栈多住几天，把我说的这些地方都看遍了，也算没白来一趟寿阳城～", "");
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giTalk("阿福：前几天城外山上闹妖怪，吓跑了好几个想出城游历的客人，害得我们客栈生意清淡了许多，现在妖怪是没了，可是这跑了的客人，十天半月之内怕是回不来哟～", "");
    }
    else
    {
        giTalk("阿福：嘿哟！客官您一看就知道是外地来的，要不要到我们阳春客栈打个尖儿，歇歇脚？", "");
    }
    giNpcResetDir("4101");
    giNpcResumeBeh("4101");
    giPlayerUnLock();
}

void func4102()
{
    giPlayerLock();
    giNpcPauseBeh("4102");
    giNpcFaceToCurrentPlayer("4102", true);
    giCurrentPlayerFaceToNpc("4102", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("谭七：三年前，江湖上突然出现一位英武少年，使一套自创的“剑指双绝”，那些赫赫有名的少侠如“清风剑”张玉太、“夺命书生”宋笑生等，全都败在他的手下！", "");
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giTalk("谭七：你听说了没有？江淮一带有名的“书剑双侠”前几天来了咱们寿阳城！我猜他们一定是柳县令请来除妖的！", "");
    }
    else
    {
        giTalk("谭七：二十多年前，这寿阳柳县令上任的时候，曾在八公山脚下遇“淮南十三盗”，险些丢了性命！然而江湖上却没人知道当时是哪位大侠出手救了柳大人。", "");
    }
    giNpcResetDir("4102");
    giNpcResumeBeh("4102");
    giPlayerUnLock();
}

void func4103()
{
    giPlayerLock();
    giNpcPauseBeh("4103");
    giNpcFaceToCurrentPlayer("4103", true);
    giCurrentPlayerFaceToNpc("4103", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("茶露：调香和调药其实是一样的，其中需要拿捏的份量、火候等等，全都是细功夫，没有两三年的时间，是学不来的。", "");
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giTalk("茶露：我从小跟着阿爹上山采药，对药理也有些了解，那“离香草”除了能制香之外，也没有别的大用处，即使不能再采摘，也没什么关系。", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("茶露：我猜寿阳城年年进贡的“宁香”之中，除了离香草，一定还用了麝香、苏合香等安心定神的香料，否则这“宁香”可没有那么好的静心宁神之效！");
        giRandTalkPush("茶露：我猜县令小姐一定是个精通药理的人，她调制的“宁香”不但能安心养神，还能通窍活血～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4103");
    giNpcResumeBeh("4103");
    giPlayerUnLock();
}

void func4104()
{
    giPlayerLock();
    giNpcPauseBeh("4104");
    giCurrentPlayerFaceToNpc("4104", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4104", true);
        giTalk("尤向玉：原来秀妹迟迟不肯跟我回京见爹，是担心余家老爷年迈无人照料，这事儿好办，余老爷是秀妹的救命恩人，把他一并接去京里住不就好了？", "");
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giNpcFaceToCurrentPlayer("4104", true);
        giTalk("尤向玉：当年爹被调任上京时，娘刚生下小妹，行动诸多不便，爹无奈带着我和大哥先行赴京，未料后来娘和小妹却在进京途中遭了盗匪，娘被害死，小妹也下落不明……", "");
    }
    else
    {
        giNpcFaceToNpc("4104", "4105", true);
        giNpcFaceToNpc("4105", "4104", true);
        giTalk("尤向玉：秀妹，爹听说寿阳附近在闹妖怪，担心的不得了，特地让我和大哥来接你回京住，你就跟哥哥回去吧！", "");
        giTalk("余竹秀：竹秀自小便没有爹娘，这位公子您认错人了吧？", "");
        giTalk("尤向玉：……", "");
    }
    giNpcResetDir("4105");
    giNpcResetDir("4104");
    giNpcResumeBeh("4104");
    giPlayerUnLock();
}

void func4105()
{
    giPlayerLock();
    giNpcPauseBeh("4105");
    giNpcFaceToCurrentPlayer("4105", true);
    giCurrentPlayerFaceToNpc("4105", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("余竹秀：原来我亲爹真的是当朝一品大员尤大人……可、可我若跟哥哥们回京见爹爹，谁来照顾爷爷呀……", "");
    }
    else if (global_mvar >= 40100 /* 第一章 / 3-1-1.少年行 / 门口会合 */)
    {
        giTalk("余竹秀：爷爷以前说过，我娘当年被凤凰山麓的盗匪所害，爷爷是在上山打柴的时候捡到我的，当时我娘已经去了……", "");
    }
    else
    {
        giTalk("余竹秀：我自小跟着爷爷长大，从来不知道自己还有爹娘，这位尤公子不知道是打哪儿来的，硬是把我当成他家失散的么妹，真是说都说不清！", "");
    }
    giNpcResetDir("4105");
    giNpcResumeBeh("4105");
    giPlayerUnLock();
}

void func4058()
{
    giPlayerLock();
    giNpcPauseBeh("4058");
    gi2DSoundPlay("WB020", 1);
    giNpcResumeBeh("4058");
    giPlayerUnLock();
}

void func4159()
{
    giPlayerLock();
    giNpcPauseBeh("4159");
    gi2DSoundPlay("WB020", 1);
    giNpcResumeBeh("4159");
    giPlayerUnLock();
}

void func5001()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4058", true);
    giStartTradeSystem("shop001", "");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("4059");
    giNpcFaceToCurrentPlayer("4059", true);
    giCurrentPlayerFaceToNpc("4059", true);
    giStartTradeSystem("shop001", "");
    giNpcResetDir("4059");
    giNpcResumeBeh("4059");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("4060");
    giNpcFaceToCurrentPlayer("4060", true);
    giCurrentPlayerFaceToNpc("4060", true);
    giStartTradeSystem("shop001", "");
    giNpcResetDir("4060");
    giNpcResumeBeh("4060");
    giPlayerUnLock();
}

void func5004()
{
    giPlayerLock();
    giNpcPauseBeh("4061");
    giNpcFaceToCurrentPlayer("4061", true);
    giCurrentPlayerFaceToNpc("4061", true);
    if (global_mvar < 90100 || var_shop006 != 0 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        if (var_shop006 != 2)
        {
            giStartTradeSystem("shop021", "");
        }
        else
        {
            giTalk("刘铁山：唉……我早知道，她是不愿意离开即墨的……罢了、罢了，这些玉石是我云游各地时收集的，全都是铸剑的良材，可笑自己还都当宝贝似的舍不得卖，其实除了懂得铸剑的人之外，谁还知道这些石头的珍贵呢……", "");
            var_shop006 = 3;
            giDelProperty(3167, 1, true);
            giWait(2.0);
            gi2DSoundPlay("WA06", 1);
            giShowHint("开启新交易品", 0.5, 0.15);
            giWait(2.0);
            giStartTradeSystem("shop021", "");
        }
    }
    else
    {
        giStartTradeSystem("shop021", "Buiness_Q03_5004");
    }
    giNpcResetDir("4061");
    giNpcResumeBeh("4061");
    giPlayerUnLock();
}

void func5005()
{
    giPlayerLock();
    giNpcPauseBeh("4078");
    giNpcFaceToCurrentPlayer("4078", true);
    giCurrentPlayerFaceToNpc("4078", true);
    giStartTradeSystem("shop011", "");
    giNpcResetDir("4078");
    giNpcResumeBeh("4078");
    giPlayerUnLock();
}

void func5008()
{
    int inn_dialog_result = 0;
    int money_amount = 0;
    int common_dialog_last_select = 0;

    giPlayerLock();
    giNpcPauseBeh("4079");
    giNpcFaceToCurrentPlayer("4079", true);
    giCurrentPlayerFaceToNpc("4079", true);
    giShowInnDialog(false);
    inn_dialog_result = giGetInnDialogResult();
    money_amount = giGetMoney();
    if (giGetInnDialogResult() == 1)
    {
        giShowCommonDialogInSelectMode("花费150文钱住宿吗？", 0.5, 0.4);
        common_dialog_last_select = giCommonDialogGetLastSelect();
        if (giCommonDialogGetLastSelect() == 1)
        {
            if (money_amount >= 150)
            {
                giFlashOutBlack(3.0, true, true);
                giPayMoney(150, true);
                giPlayerTakeARest();
                giWait(2.0);
                giFlashInBlack(3.0, true);
            }
            else
            {
                giTalk("周金福：您身上的钱不够。", "");
            }
        }
    }
    giPlayerSetAttr(-1, -1, 100);
    giNpcResetDir("4079");
    giNpcResumeBeh("4079");
    giPlayerUnLock();
}

void func5007()
{
    bool has_property_3020 = false;
    bool has_property_3014 = false;
    bool has_property_3021 = false;
    bool has_property_3015 = false;
    bool has_property_3022 = false;
    bool has_property_3016 = false;

    giPlayerLock();
    giNpcPauseBeh("4080");
    giNpcFaceToCurrentPlayer("4080", true);
    giCurrentPlayerFaceToNpc("4080", true);
    if (global_mvar < 90100 || var_shop026 != 0 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        if (var_shop026 != 1)
        {
            giStartTradeSystem("shop032", "");
        }
        else
        {
            has_property_3020 = giCheckPackProperty(3020, 1);
            has_property_3014 = giCheckPackProperty(3014, 1);
            has_property_3021 = giCheckPackProperty(3021, 1);
            has_property_3015 = giCheckPackProperty(3015, 1);
            has_property_3022 = giCheckPackProperty(3022, 1);
            has_property_3016 = giCheckPackProperty(3016, 1);
            if (giCheckPackProperty(3020, 1) && has_property_3014 && has_property_3015 && has_property_3016 && has_property_3021 && has_property_3022)
            {
                giTalk("吴丹：哈哈哈哈！小哥你真是个大善人！！辛苦了辛苦了！来，这几样东西你拿好了，算是我吴丹答谢你的！", "");
                giDelProperty(3020, 1, true);
                giWait(2.0);
                giDelProperty(3014, 1, true);
                giWait(2.0);
                giDelProperty(3021, 1, true);
                giWait(2.0);
                giDelProperty(3015, 1, true);
                giWait(2.0);
                giDelProperty(3022, 1, true);
                giWait(2.0);
                giDelProperty(3016, 1, true);
                giWait(2.0);
                giAddEquipment(3670, true);
                giWait(2.0);
                giAddEquipment(3682, true);
                giWait(2.0);
                giAddEquipment(3685, true);
                giWait(2.0);
                var_shop026 = 2;
            }
            giStartTradeSystem("shop032", "");
        }
    }
    else
    {
        giStartTradeSystem("shop032", "Buiness_Q03_5007");
    }
    giNpcResetDir("4080");
    giNpcResumeBeh("4080");
    giPlayerUnLock();
}

void Buiness_Q03_5007()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("我虽然见识了很多食谱，但是却没有吃过寿阳以外的小吃，小哥你如果能帮我带来<colour red=255 green=187 blue=0 alpha=255>醉枣、炸馓子、奶茶、手抓饭、醪酒和红绿八宝饭</colour><dc0>的话，我一定会很感激你的！</dc0><br/><dc0>你愿意帮我去买来吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        var_shop026 = 1;
    }
}

void Buiness_Q03_5004()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("小伙子，看你的样子，不是本地人吧？如果有机会去北方海边的<colour red=255 green=187 blue=0 alpha=255>即墨</colour><dc0>，能不能帮我把这块“九转圣光石”带给一位姑娘？她叫</dc0><colour red=255 green=187 blue=0 alpha=255>张艳</colour><dc0>，常常喜欢</dc0><colour red=255 green=187 blue=0 alpha=255>站在栈桥上</colour><dc0>看海。</dc0><br/><dc0>你愿意帮我把“九转圣光石”带给她吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        var_shop006 = 1;
        giAddProperty(3167, 1, true);
        giWait(2.0);
    }
}

void func8001()
{
    giCameraSetCollide(true);
}

void func8002()
{
    giCameraSetCollide(false);
}
