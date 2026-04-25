// Structured PAL4 reconstruction for Q04.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q04_Q04C_init()
{
    LL_001(global_mvar);
    giGOMTouch("MO003");
    if (global_mvar < 50300 || global_mvar > 51200 || npc_a != 0 /* 第一章 / 3-3-2.弦歌问情 / 客栈休息 */)
    {
        if (global_mvar < 50300 || global_mvar > 51200 || npc_a != 0 || npc_a != 1 /* 第一章 / 3-3-2.弦歌问情 / 客栈休息 */)
        {
            if ((global_mvar < 50300 || global_mvar > 51200 || npc_a != 0 || npc_a != 1) && npc_a == 2 /* 第一章 / 3-3-2.弦歌问情 / 客栈休息 */)
            {
                giSetObjectVisible("SO002", true);
                giSetObjectVisible("SO003", true);
            }
        }
        else
        {
            giSetNpcVisible("SN002", true);
            giSetNpcVisible("SN003", true);
            giSetNpcVisible("SN004", true);
            giSetNpcVisible("SN005", true);
            giSetObjectVisible("SO002", true);
            giSetObjectVisible("SO003", true);
        }
    }
    else
    {
        giSetNpcVisible("SO001", true);
        giSetObjectVisible("SO001", true);
    }
    if (global_mvar < 50300 || global_mvar > 51200 || npc_g != 0 /* 第一章 / 3-3-2.弦歌问情 / 客栈休息 */)
    {
            if (global_mvar >= 120100 && npc_g == 5 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
            {
                giSetNpcVisible("SN009", true);
                giSetObjectVisible("title14", false);
            }
    }
    else
    {
        giSetNpcVisible("SN007", true);
        giSetNpcVisible("SN008", true);
    }
    if (global_mvar < 50300 || global_mvar > 51200 && npc_g == 0 /* 第一章 / 3-3-2.弦歌问情 / 客栈休息 */)
    {
        giEventVolumeVisible("ev_Q04_Q04C_16", false);
        giSetObjectVisible("title14", false);
    }
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        if (global_mvar != 50200 /* 第一章 / 3-3-1.弦歌问情 / 城中寻人 */)
        {
            giIMMBegin();
            giSetObjectVisible("entrance5", false);
            giSetObjectVisible("entrance6", false);
            giSetObjectVisible("entrance7", false);
            giSetObjectVisible("entrance1", true);
            giSetObjectVisible("entrance2", true);
            giSetObjectVisible("entrance3", true);
            giIMMEnd();
        }
        else
        {
            giIMMBegin();
            giSetObjectVisible("entrance1", false);
            giSetObjectVisible("entrance2", false);
            giSetObjectVisible("entrance3", false);
            giSetObjectVisible("entrance5", false);
            giSetObjectVisible("entrance6", false);
            giSetObjectVisible("entrance7", false);
            giIMMEnd();
        }
    }
    else
    {
        giIMMBegin();
        giSetObjectVisible("entrance5", true);
        giSetObjectVisible("entrance6", true);
        giSetObjectVisible("entrance7", true);
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance2", false);
        giSetObjectVisible("entrance3", false);
        giIMMEnd();
    }
    if (global_mvar == 50200 /* 第一章 / 3-3-1.弦歌问情 / 城中寻人 */)
    {
        giIMMBegin();
        giSetNpcVisible("MN003", true);
        giPlayerSetPos(0, 3178.6465, 61.3905, -2168.4373);
        giPlayerSetAng(0, 161.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(2, 3133.487, 61.3358, -2232.1477);
        giPlayerSetAng(2, 109.0);
        giPlayerSetVisible(2, true);
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("MO001", true);
        giIMMEnd();
    }
    if (global_mvar == 51200 /* 第一章 / 3-3-6.弦歌问情 / 城门会合 */)
    {
        giIMMBegin();
        giSetNpcVisible("MN004", true);
        giSetNpcVisible("MN005", true);
        giIMMEnd();
    }
    if (global_mvar == 50100 /* 离开王墓 */)
    {
        func2001();
    }
    giArenaReadyRestore();
}

void Q04_Q04CY_init()
{
    giGOMTouch("MO003");
    if (global_mvar != 50700)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2005();
    }
}

void Q04_Q04HY_init()
{
    if (global_mvar == 50400 /* 第一章 / 3-3-3.弦歌问情 / 夜入千佛塔 */)
    {
        giIMMBegin();
        giSetNpcVisible("MN001", true);
        giSetObjectVisible("entrance2", false);
        giIMMEnd();
        giArenaReadyRestore();
    }
    if (global_mvar < 50401)
    {
        giArenaReadyRestore();
    }
    else
    {
        giEventVolumeVisible("ev_Q04_Q04HY_14", false);
        giArenaReadyRestore();
    }
}

void Q04_CN05C_init()
{
    if (global_mvar != 51000)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2006();
    }
}

void Q04_CN07_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q04_CN11_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q04_HN01_init()
{
    LL_001(global_mvar);
    giArenaReadyRestore();
}

void Q04_CN03_init()
{
    if (global_mvar < 90100 && var_shop012 != 1 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("4021", false);
        giArenaReadyRestore();
    }
}

void Q04_CN22_init()
{
    if (npc_g != 3)
    {
        if (global_mvar >= 120100 && npc_g == 4 || npc_g < 3 || npc_g >= 5 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
        {
            giArenaReadyRestore();
        }
        else
        {
            giSetNpcVisible("SN001", true);
            giSetNpcVisible("SN002", true);
            giNpcSetEmotion("SN001", "306_by");
            giArenaReadyRestore();
        }
    }
    else
    {
        func3005();
    }
}

void LL_001(int arg0)
{
    // typed_typeinfo_hints: primary=void; extras=[int]
    // prototype_hint: void LL_001(int)
    if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giSetNpcVisible("4019", true);
        giSetNpcVisible("4119", false);
    }
    else if (global_mvar >= 50400 /* 第一章 / 3-3-3.弦歌问情 / 夜入千佛塔 */)
    {
        giSetNpcVisible("4019", false);
        giSetNpcVisible("4051", false);
        giSetNpcVisible("4052", false);
    }
    else
    {
        giSetNpcVisible("4019", true);
        giSetNpcVisible("4119", false);
        giSetNpcVisible("4051", false);
        giSetNpcVisible("4052", false);
    }
    if (var_shop012 == 1)
    {
        giSetNpcVisible("4021", false);
    }
}

void func1001()
{
    giArenaLoad("Q04", "CN01", "", true);
    giPlayerCurrentSetPos(74.69709, 0.000008, 48.315605);
    giPlayerCurrentSetAng(280.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-1111.1315, 65.634094, 1786.3954);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    if (npc_a != 2)
    {
        giArenaLoad("Q04", "CN02", "", true);
        giPlayerCurrentSetPos(12.69081, 7.600008, 228.97984);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q04", "CN02", "", true);
        func3003();
    }
}

void func1004()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-962.8746, 65.634094, 6.456719);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q04", "CN03", "", true);
    giPlayerCurrentSetPos(124.78994, 1.120152, 26.674963);
    giPlayerCurrentSetAng(225.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-1895.0731, 65.634094, 347.84503);
    giPlayerCurrentSetAng(135.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("Q04", "CN04", "", true);
    giPlayerCurrentSetPos(-321.6662, 1.538618, 50.760086);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1008()
{
    if (global_mvar != 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giArenaLoad("Q04", "CN03", "", true);
        giPlayerCurrentSetPos(-172.1814, 85.3291, 4.65992);
        giPlayerCurrentSetAng(1.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q04", "CN03", "", true);
        func2007();
    }
}

void func1009()
{
    giArenaLoad("Q04", "CN05", "CN05a", true);
    giPlayerCurrentSetPos(91.99575, 0.378605, -18.898693);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q04", "CN04", "", true);
    giPlayerCurrentSetPos(-278.26822, 1.538614, -48.653587);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("Q04", "CN05", "CN05b", true);
    giPlayerCurrentSetPos(91.99575, 0.378605, -18.898693);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("Q04", "CN04", "", true);
    giPlayerCurrentSetPos(-25.777931, 1.538834, -40.127083);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("Q04", "CN05", "CN05c", true);
    giPlayerCurrentSetPos(91.99575, 0.378605, -18.898693);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("Q04", "CN04", "", true);
    giPlayerCurrentSetPos(234.20459, 1.538895, -48.221893);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("Q04", "CN06", "", true);
    giPlayerCurrentSetPos(52.656425, -0.588026, -14.276082);
    giPlayerCurrentSetAng(225.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-906.1233, 65.634094, -645.9457);
    giPlayerCurrentSetAng(315.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1017()
{
    if (var_zhu != 1)
    {
        giArenaLoad("Q04", "CN07", "", true);
        giPlayerCurrentSetPos(13.714065, 0.72278, 132.36157);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q04", "CN07", "", true);
        func3008();
    }
}

void func1018()
{
    giArenaLoad("Q04", "CN06", "", true);
    giPlayerCurrentSetPos(-205.19926, 53.989258, -14.055206);
    giPlayerCurrentSetAng(0.2);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1019()
{
    giArenaLoad("Q04", "CN08", "", true);
    giPlayerCurrentSetPos(5.341835, 0.128139, 118.453186);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1020()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(4655.924, -1.606714, 2299.6348);
    giPlayerCurrentSetAng(225.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1021()
{
    giArenaLoad("Q04", "CN09", "", true);
    giPlayerCurrentSetPos(10.765401, -0.210001, 77.387085);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1022()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(1196.7229, -1.606712, 2432.5327);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1023()
{
    giArenaLoad("Q04", "CN101", "", true);
    giPlayerCurrentSetPos(1.852708, 0.607513, 196.51608);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1024()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(4263.7446, -1.606712, 436.57645);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1025()
{
    giArenaLoad("Q04", "CN102", "", true);
    giPlayerCurrentSetPos(92.54916, 0.202101, -134.03833);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1026()
{
    giArenaLoad("Q04", "CN101", "", true);
    giPlayerCurrentSetPos(141.56056, 99.3686, -174.93459);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1027()
{
    giArenaLoad("Q04", "CN11", "", true);
    giPlayerCurrentSetPos(241.93051, 1.113054, -78.100624);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1028()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(1390.3528, 28.935947, -177.19295);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1029()
{
    giArenaLoad("Q04", "CN12", "", true);
    giPlayerCurrentSetPos(23.010763, 0.051014, 71.46186);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1030()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-2219.997, 119.63409, 2207.7734);
    giPlayerCurrentSetAng(171.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1031()
{
    giArenaLoad("Q04", "CN13", "CN13a", true);
    giPlayerCurrentSetPos(-1.125762, 1.040564, 71.03138);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1032()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-3873.557, 69.09943, 1850.0635);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1033()
{
    giArenaLoad("Q04", "CN13", "CN13b", true);
    giPlayerCurrentSetPos(-1.125762, 1.040564, 71.03138);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1034()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-742.38464, 68.825096, 2387.9583);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1035()
{
    giArenaLoad("Q04", "CN22", "", true);
    giPlayerCurrentSetPos(-1.125762, 1.040564, 71.03138);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1036()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(2814.6064, 1.437197, 2507.9807);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1037()
{
    giArenaLoad("Q04", "CN13", "CN13d", true);
    giPlayerCurrentSetPos(-1.125762, 1.040564, 71.03138);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1038()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(4938.7295, 0.638273, 1129.7843);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1039()
{
    giArenaLoad("Q04", "CN14", "CN14a", true);
    giPlayerCurrentSetPos(1.240404, -0.02688, 44.839836);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1040()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(1735.3728, -1.606714, 1936.8632);
    giPlayerCurrentSetAng(0.3);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1041()
{
    giArenaLoad("Q04", "CN14", "CN14b", true);
    giPlayerCurrentSetPos(1.240404, -0.02688, 44.839836);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1042()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(4877.7227, -1.60671, 94.5688);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1043()
{
    giPlayerCurrentSetPos(-590.0, 60.0, -491.0);
    giPlayerCurrentSetAng(0.0);
}

void func1044()
{
    giPlayerCurrentSetPos(-53.0, 0.0, 1.0);
    giPlayerCurrentSetAng(0.0);
}

void func1045()
{
    giPlayerCurrentSetPos(-53.0, 0.0, 1.0);
    giPlayerCurrentSetAng(0.0);
}

void func1046()
{
    int leader_player_id = 0;

    giPlayerLock();
    giNpcPauseBeh("4050");
    giNpcFaceToCurrentPlayer("4050", true);
    giCurrentPlayerFaceToNpc("4050", true);
    giTalk("凌天守：府衙重地，闲杂人等速速离开！", "");
    giNpcResetDir("4050");
    giNpcResumeBeh("4050");
    leader_player_id = giPlayerGetLeader();
    giPlayerWalkTo(leader_player_id, -1434.6628, 65.634094, -1182.2399, true);
    giPlayerSetDir(leader_player_id, 358.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giPlayerUnLock();
}

void func1047()
{
    giArenaLoad("Q04", "Q04H", "", true);
    giPlayerCurrentSetPos(3257.4922, -260.35083, 647.98883);
    giPlayerCurrentSetAng(230.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1048()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-3614.9785, -1.606714, -239.23138);
    giPlayerCurrentSetAng(359.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1049()
{
    giArenaLoad("Q04", "HN01", "", true);
    giPlayerCurrentSetPos(-0.901351, 0.177786, 201.48352);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1050()
{
    giArenaLoad("Q04", "Q04H", "", true);
    giPlayerCurrentSetPos(59.2763, -126.7565, -1674.2913);
    giPlayerCurrentSetAng(28.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1051()
{
    giArenaLoad("Q04", "HN03", "HN03a", true);
    giPlayerCurrentSetPos(77.76124, 0.054794, 64.146706);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1052()
{
    giArenaLoad("Q04", "Q04H", "", true);
    giPlayerCurrentSetPos(-1485.041, -193.26831, -3059.0417);
    giPlayerCurrentSetAng(26.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1053()
{
    giArenaLoad("Q04", "HN03", "HN03b", true);
    giPlayerCurrentSetPos(77.76124, 0.054794, 64.146706);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1054()
{
    giArenaLoad("Q04", "Q04H", "", true);
    giPlayerCurrentSetPos(-1190.0438, -193.26831, -3214.5974);
    giPlayerCurrentSetAng(20.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1055()
{
    giArenaLoad("Q04", "HN03", "HN03c", true);
    giPlayerCurrentSetPos(77.76124, 0.054794, 64.146706);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1056()
{
    giArenaLoad("Q04", "Q04H", "", true);
    giPlayerCurrentSetPos(-1557.4684, -189.50406, -918.79956);
    giPlayerCurrentSetAng(28.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1057()
{
    giArenaLoad("Q04", "HN04", "", true);
    giPlayerCurrentSetPos(35.39349, 5.621849, 62.29818);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1058()
{
    giArenaLoad("Q04", "Q04H", "", true);
    giPlayerCurrentSetPos(-1751.975, -193.26831, -93.080505);
    giPlayerCurrentSetAng(186.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1059()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("M07", "9", "", true);
        giPlayerCurrentSetPos(638.1492, -306.25473, -2187.8877);
        giPlayerCurrentSetAng(327.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giSelectDialogAddItem("1.去碗丘山  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去碗丘山</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -1439.1438, 65.634094, 2975.9912, true);
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
                giArenaLoad("M07", "9", "", true);
                giPlayerCurrentSetPos(638.1492, -306.25473, -2187.8877);
                giPlayerCurrentSetAng(327.0);
                giCameraSetMode(5, true);
                giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1060()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-563.16437, -133.26353, -394.26077, true);
    giPlayerCurrentSetAng(120.0);
    giSetPortrait("101A", true);
    giTalk("云天河：还是不要进去为好。", "");
    giPlayerUnLock();
}

void func1061()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-1872.6686, -189.50406, -828.9999, true);
    giPlayerCurrentSetAng(31.0);
    giSetPortrait("101A", true);
    giTalk("云天河：房门锁住了……", "");
    giPlayerUnLock();
}

void func1062()
{
}

void func1063()
{
    giArenaLoad("Q04", "CN03", "", true);
    giPlayerCurrentSetPos(-151.22731, 0.724012, 222.1686);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1064()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-1753.5145, 65.634094, 695.7863);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1065()
{
    giArenaLoad("Q04", "CN03", "", true);
    giPlayerCurrentSetPos(313.4339, 0.723986, -260.54935);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1066()
{
    giArenaLoad("Q04", "Q04C", "", true);
    giPlayerCurrentSetPos(-2239.7124, 65.63409, 191.011);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1067()
{
    giArenaLoad("Q04", "CN04", "", true);
    giPlayerCurrentSetPos(336.58377, 1.538961, -30.477602);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1068()
{
    if (global_mvar != 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giArenaLoad("Q04", "CN03", "", true);
        giPlayerCurrentSetPos(93.61445, 92.2138, -262.79703);
        giPlayerCurrentSetAng(90.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q04", "CN03", "", true);
        func2007();
    }
}

void func1069()
{
    giArenaLoad("M08", "1", "", true);
    giPlayerCurrentSetPos(1287.653, 0.000071, 359.4184);
    giPlayerCurrentSetAng(257.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1070()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(2746.0022, 4.060002, -1848.0006, true);
    giPlayerCurrentSetAng(88.6);
    giSetPortrait("101A", true);
    giTalk("云天河：房门锁住了……", "");
    giPlayerUnLock();
}

void func1071()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(3675.0022, 4.060002, -1844.0006, true);
    giPlayerCurrentSetAng(265.0);
    giSetPortrait("101A", true);
    giTalk("云天河：房门锁住了……", "");
    giPlayerUnLock();
}

void func1072()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-2294.0022, 65.060005, -286.00064, true);
    giPlayerCurrentSetAng(358.0);
    giSetPortrait("101A", true);
    giTalk("云天河：还是不要进去为好。", "");
    giPlayerUnLock();
}

void func1073()
{
    giArenaLoad("Q04", "Q04CY", "", true);
    giPlayerCurrentSetPos(-3614.9785, -1.606714, -239.23138);
    giPlayerCurrentSetAng(359.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1074()
{
    giArenaLoad("Q04", "Q04HY", "", true);
    giPlayerCurrentSetPos(3257.4922, -260.35083, 647.98883);
    giPlayerCurrentSetAng(230.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1075()
{
    giArenaLoad("Q04", "CN11Y", "", true);
    giPlayerCurrentSetPos(241.93051, 1.113054, -78.100624);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1076()
{
    giArenaLoad("Q04", "Q04CY", "", true);
    giPlayerCurrentSetPos(1390.3528, 28.935947, -177.19295);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1077()
{
    giArenaLoad("Q04", "CN09Y", "", true);
    giPlayerCurrentSetPos(10.765401, -0.210001, 77.387085);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1078()
{
    giArenaLoad("Q04", "Q04CY", "", true);
    giPlayerCurrentSetPos(1196.7229, -1.606712, 2432.5327);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1079()
{
    giArenaLoad("Q04", "CN08Y", "", true);
    giPlayerCurrentSetPos(5.341835, 0.128139, 118.453186);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1080()
{
    giArenaLoad("Q04", "Q04CY", "", true);
    giPlayerCurrentSetPos(4655.924, -1.606714, 2299.6348);
    giPlayerCurrentSetAng(225.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1081()
{
    giArenaLoad("Q04", "CN03Y", "", true);
    giPlayerCurrentSetPos(124.78994, 1.120152, 26.674963);
    giPlayerCurrentSetAng(225.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1082()
{
    giArenaLoad("Q04", "Q04CY", "", true);
    giPlayerCurrentSetPos(-1895.0731, 65.634094, 347.84503);
    giPlayerCurrentSetAng(135.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1083()
{
    giArenaLoad("Q04", "CN03Y", "", true);
    giPlayerCurrentSetPos(-151.22731, 0.724012, 222.1686);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1084()
{
    giArenaLoad("Q04", "Q04CY", "", true);
    giPlayerCurrentSetPos(-1753.5145, 65.634094, 695.7863);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1085()
{
    giArenaLoad("Q04", "CN03Y", "", true);
    giPlayerCurrentSetPos(313.4339, 0.723986, -260.54935);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1086()
{
    giArenaLoad("Q04", "Q04CY", "", true);
    giPlayerCurrentSetPos(-2239.7124, 65.63409, 191.011);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1087()
{
    giArenaLoad("Q04", "CN04Y", "", true);
    giPlayerCurrentSetPos(-321.6662, 1.538618, 50.760086);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1088()
{
    giArenaLoad("Q04", "CN03Y", "", true);
    giPlayerCurrentSetPos(-172.1814, 85.3291, 4.65992);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1089()
{
    giArenaLoad("Q04", "CN04Y", "", true);
    giPlayerCurrentSetPos(336.58377, 1.538961, -30.477602);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1090()
{
    giArenaLoad("Q04", "CN03Y", "", true);
    giPlayerCurrentSetPos(93.61445, 92.2138, -262.79703);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1091()
{
    giArenaLoad("Q04", "CN05Y", "CN05Ya", true);
    giPlayerCurrentSetPos(91.99575, 0.378605, -18.898693);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1092()
{
    giArenaLoad("Q04", "CN04Y", "", true);
    giPlayerCurrentSetPos(-278.26822, 1.538614, -48.653587);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1093()
{
    giArenaLoad("Q04", "CN05Y", "CN05Yb", true);
    giPlayerCurrentSetPos(91.99575, 0.378605, -18.898693);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1094()
{
    giArenaLoad("Q04", "CN04Y", "", true);
    giPlayerCurrentSetPos(-25.777931, 1.538834, -40.127083);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1095()
{
    giArenaLoad("Q04", "CN05Y", "CN05Yc", true);
    giPlayerCurrentSetPos(91.99575, 0.378605, -18.898693);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1096()
{
    giArenaLoad("Q04", "CN04Y", "", true);
    giPlayerCurrentSetPos(234.20459, 1.538895, -48.221893);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1097()
{
    giArenaLoad("Q04", "CN01Y", "", true);
    giPlayerCurrentSetPos(74.69709, 0.000008, 48.315605);
    giPlayerCurrentSetAng(280.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1098()
{
    giArenaLoad("Q04", "Q04CY", "", true);
    giPlayerCurrentSetPos(-1111.1315, 65.634094, 1786.3954);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1099()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("M07", "9", "", true);
        giPlayerCurrentSetPos(638.1492, -306.25473, -2187.8877);
        giPlayerCurrentSetAng(327.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giSelectDialogAddItem("1.去碗丘山  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去碗丘山</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -1722.1438, 65.634094, 2975.9912, true);
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
                giArenaLoad("M07", "9", "", true);
                giPlayerCurrentSetPos(638.1492, -306.25473, -2187.8877);
                giPlayerCurrentSetAng(327.0);
                giCameraSetMode(5, true);
                giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1100()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("M07", "9", "", true);
        giPlayerCurrentSetPos(638.1492, -306.25473, -2187.8877);
        giPlayerCurrentSetAng(327.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giSelectDialogAddItem("1.去碗丘山  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去碗丘山</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -1143.1438, 65.634094, 2975.9912, true);
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
                giArenaLoad("M07", "9", "", true);
                giPlayerCurrentSetPos(638.1492, -306.25473, -2187.8877);
                giPlayerCurrentSetAng(327.0);
                giCameraSetMode(5, true);
                giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func2001()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giIMMBegin();
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(1, -1436.1659, 65.6341, 2784.957);
    giPlayerSetAng(1, 180.0);
    giPlayerSetVisible(1, true);
    giSetNpcVisible("MN001", true);
    giSetNpcVisible("MN002", true);
    giSetObjectVisible("entrance1", false);
    giSetObjectVisible("entrance2", false);
    giSetObjectVisible("entrance3", false);
    giIMMEnd();
    giCameraSetDistOptEnable(false);
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giPlayerWalkTo(1, -1436.1107, 65.6341, 2583.813, false);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giCameraRunSingle("002", false);
    giWait(0.7);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：说起来，陈州才算得上是淮河岸边真正的宝地～传说天神伏羲在这儿设下了先天八卦之阵，再厉害的妖魔也不能作乱。而且历朝历代的皇亲国戚都特别偏爱这里，最最有名的要数那个才高很多斗的曹、曹……曹子佳？", "41956");
    giSetPortrait("103A", true);
    giTalk("韩菱纱：不对、不对，梦璃你在书上读过吧？那人叫什么来着？", "41957");
    giPlayerEndMove(1);
    giWait(0.3);
    giPlayerSetDir(1, 8.0, false);
    giWait(0.4);
    giCameraRunSingle("003", false);
    giWait(2.0);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：…………", "41958");
    giPlayerDoAction(1, "J15", -1, false);
    giSetPortrait("103I", true);
    giTalk("韩菱纱：云～天～河——！！竟然又给我乱跑，还把梦璃一起拐走！", "41959");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(1, "J04", -1, false);
    giSetPortrait("103F", true);
    giTalk("韩菱纱：（真是被他气累了……）", "41960");
    gi2DSoundPlay("WJ022", 1);
    giWait(1.0);
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerSetDir(1, 88.0, false);
    giCameraRunSingle("004", true);
    gi2DSoundPlay("WJ022", 1);
    giNpcDoAction("MN002", "J01", 1, true);
    giSetPortrait("103F", true);
    giTalk("韩菱纱：…………", "41961");
    giPlayerWalkTo(1, -1258.6998, 65.6341, 2588.6611, true);
    gi2DSoundPlay("WJ022", 1);
    giNpcDoAction("MN002", "J01", 1, false);
    giNpcDoAction("MN001", "J01", 1, false);
    giTalk("书生：姑娘息怒，姑娘息怒！我家的小黄胆子特别小，别人一吼它就害怕……", "41962");
    giNpcEndAction("MN001", false);
    giSetPortrait("103F", true);
    giTalk("韩菱纱：……胆子这么小，还做什么狗。", "41963");
    giTalk("书生：岂、岂有此理……脾气这么坏，还当什么女人……", "41964");
    giPlayerDoAction(1, "J15", 1, false);
    giSetPortrait("103F", true);
    giTalk("韩菱纱：你说什么？有胆子再说一遍！", "41965");
    giNpcDoAction("MN001", "J01", 1, false);
    giTalk("书生：没有，不敢、不敢，小生先走一步！", "41966");
    giNpcUnHoldAct("MN001");
    giNpcEndAction("MN001", true);
    giNpcWalkTo("MN001", -1184.5175, 65.6341, 2396.0266, false);
    giNpcWalkTo("MN002", -1166.1631, 65.6341, 2434.555, false);
    giWait(1.5);
    giPlayerSetDir(1, 144.0, true);
    giWait(0.5);
    giSetPortrait("103F", true);
    giTalk("韩菱纱：（云天河！不要让我<colour red=255 green=187 blue=0 alpha=255>找到你</colour><dc0>，姑娘我自从遇到你以后衰事连连，现在连狗都欺负我！）</dc0>", "41967");
    giFlashOutBlack(1.5, true, true);
    giCameraSetDistOptEnable(true);
    giPlayerSetLeader(1);
    giIMMBegin();
    giPlayerSetVisible(1, false);
    giPlayerCurrentSetVisible(true);
    giSetNpcVisible("MN001", false);
    giSetNpcVisible("MN002", false);
    giSetNpcVisible("MN003", true);
    giPlayerSetPos(0, 3178.6465, 61.3905, -2168.4373);
    giPlayerSetAng(0, 161.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(2, 3133.487, 61.3358, -2232.1477);
    giPlayerSetAng(2, 109.0);
    giPlayerSetVisible(2, true);
    giSetObjectVisible("MO002", true);
    giSetObjectVisible("MO001", true);
    global_mvar = 50200; // 0x0000C418, 第一章 / 3-3-1.弦歌问情 / 城中寻人
    giIMMEnd();
    giPlayerOutTeam(0, false);
    giPlayerOutTeam(2, false);
    giPlayerCurrentSetPos(-1352.571, 65.6341, 2408.9512);
    giPlayerCurrentSetAng(196.0);
    giCameraSetMode(0, true);
    giCameraSeekToPlayer();
    giFlashInBlack(2.0, true);
    giGrantSmithSystem(true, true, true, false);
    giPlayerUnLock();
}

void func2002()
{
    if (global_mvar == 50200 /* 第一章 / 3-3-1.弦歌问情 / 城中寻人 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(1, 3233.323, 61.3413, -1987.2211);
        giPlayerSetAng(1, 204.0);
        giPlayerSetVisible(1, true);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：好哇！总算给我找到了！", "41968");
        giWait(0.3);
        giIMMBegin();
        giPlayerSetDir(0, 19.0, false);
        giPlayerSetDir(2, 25.0, false);
        giNpcSetDir("MN003", 2.0, false);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：菱纱，你快来～ ", "41969");
        giPlayerWalkTo(1, 3168.3865, 61.4078, -2113.1748, false);
        giCameraRunSingle("002", true);
        giWait(0.8);
        giPlayerSetDir(0, 350.0, true);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 170.0, true);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：来什么来！你又到处乱跑！嫌以前闯的祸不够多是不是！", "41970");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：我、我也不知道，不知不觉就走到这里来了……呵呵。", "41971");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：……", "41972");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：菱纱，是我不好……我见云公子看新奇的东西看得入迷了，越走越远，本想把他喊回来，结果却也……", "41973");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 197.0, true);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：好梦璃，你别事事都替这傻瓜担待。四处逛逛也没什么啦，可千万别不打招呼就消失，害我担心……", "41974");
        giSetPortrait("101B", true);
        giTalk("云天河：菱纱，我想买样好东西～可身上没钱，你有吗？能不能给我？", "41975");
        giPlayerSetDir(1, 170.0, true);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：…………居然还有脸说，一点不知反省……真服了你……", "41976");
        giSetPortrait("101A", true);
        giTalk("云天河：反省？", "41977");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：我知道啊，爹说过有句话叫“一日三省吾身”，意思是一天要反省三次，今天的三次我都用完了，所以剩下的留到明天再做。", "41978");
        giSetPortrait("103D", false);
        giTalk("韩菱纱：你…………", "41979");
        giSetPortrait("106B", true);
        giTalk("柳梦璃：我看……不如先听听云公子说的吧，他这次倒也是一番好意呢。", "41980");
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：唉，说吧，你到底想买什么？", "41981");
        giPlayerEndAction(1);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giNpcSetAng("MN003", 344.0);
        giIMMBegin();
        giPlayerSetDir(2, 115.0, false);
        giPlayerSetDir(0, 170.0, false);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("101B", false);
        giTalk("云天河：那个……", "41982");
        giWait(0.3);
        giPlayerWalkTo(1, 3139.925, 61.4562, -2181.1125, false);
        giCameraRunSingle("003", false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 144.0, true);
        giNpcSetDir("MN003", 317.0, true);
        giCameraWait();
        giWait(0.7);
        giNpcDoAction("MN003", "J01", 1, true);
        giWait(0.7);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：这是……", "41983");
        giPlayerSetDir(1, 85.0, true);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：你想买琴？要送给梦璃？", "41984");
        giPlayerSetDir(2, 33.0, false);
        giPlayerSetDir(0, 250.0, true);
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：不是、不是，就是买她！", "41985");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：她？……她？！你要买的竟然是……太胡闹了！你这色心不死的野人！不行！我绝不同意！", "41986");
        giSetPortrait("101E", true);
        giTalk("云天河：可是……", "41987");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：少废话！不行就是不行！", "41988");
        giSetPortrait("211A", true);
        giTalk("？？：姑娘莫要误会。", "41989");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetDir(1, 144.0, false);
        giPlayerSetDir(0, 170.0, false);
        giPlayerSetDir(2, 115.0, false);
        giIMMEnd();
        giWait(0.8);
        giCameraRunSingle("004", true);
        giWait(0.4);
        giSetPortrait("211A", true);
        giTalk("？？：我只是答应为云少侠唱上一曲，还未来得及告诉他不纳金银，我只想求他帮我一个忙。", "41990");
        giCameraRunSingle("005", true);
        giWait(0.3);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……真的？只是唱歌？还不要钱？我看要帮的忙肯定麻烦……", "41991");
        giPlayerSetDir(0, 253.0, false);
        giPlayerSetDir(2, 19.0, true);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：……菱纱，我刚才听这位姑娘抚琴，曲意凄婉哀伤，好像有莫大的痛苦。我们要是力所能及，就帮帮她吧。好吗？", "41992");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：对、对啊，我也觉得是要帮她！", "41993");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……", "41994");
        giSetPortrait("211A", true);
        giTalk("？？：两位姑娘，还有云少侠，若是愿意耽搁片刻，我自会把前因后果都告诉你们……", "41995");
        giPlayerSetDir(0, 170.0, false);
        giPlayerSetDir(2, 109.0, true);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：我们自然愿意听。", "41996");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（……如果很麻烦，不就耽误了找怀朔的事……）", "41997");
        giPlayerEndAction(2);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……说了这么久，还不知道怎么称呼这位姑娘？", "41998");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("004", true);
        giPlayerSetAng(0, 159.0);
        giSetPortrait("211A", true);
        giTalk("？？：三位叫我“琴姬”便好，已为人妇，又哪敢再以姑娘自居。", "41999");
        giSetPortrait("211A", true);
        giTalk("琴姬：这位柳姑娘说我曲意哀伤，心中痛苦，倒是言重了……", "42000");
        giScriptMusicPlay("P35", 2, 0.0, 0.0);
        giNpcDoAction("MN003", "C09", 1, false);
        giSetPortrait("211A", true);
        giTalk("琴姬：人生在世，难免有许多妄念，我有个心愿未了，怕是到死都看不破……", "42001");
        giCameraRunSingle("006", true);
        giWait(0.3);
        giSetPortrait("101A", true);
        giTalk("云天河：心愿？是什么？", "42002");
        giSetPortrait("211A", false);
        giTalk("琴姬：这可得从头说起——", "42003");
        giSetPortrait("211A", false);
        giTalk("琴姬：我自幼喜爱音律，却更是仰慕世间的高人侠士，及笄之后便出门闯荡，仗着一身武艺惩奸除恶，倒也十分痛快。", "42004");
        giPlayerDoAction(1, "J16", 1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：呀，了不起！你竟是个锄强扶弱的女侠！", "42005");
        giPlayerEndAction(1);
        giNpcDoAction("MN003", "C09", 1, false);
        giSetPortrait("211A", false);
        giTalk("琴姬：什么女侠，也不过是年少时的胡闹……后来我因音律结识了陈州秦家的独子，他虽不懂武功，也很文弱，却是我见过最好的人，没过多久他就将我迎娶入门。", "42006");
        giNpcEndAction("MN003", false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：那很好啊，能和自己喜欢的人在一起～ ", "42007");
        giSetPortrait("211A", false);
        giTalk("琴姬：…………", "42008");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：莫非……他有负于你？", "42009");
        giSetPortrait("211A", false);
        giTalk("琴姬：不，他对我很好，我们在一起钻研曲谱，他还教我读书写字……那真是、是我一生中最快乐的一段日子……", "42010");
        giNpcDoAction("MN003", "C09", 1, false);
        giSetPortrait("211A", false);
        giTalk("琴姬：可惜……不管我怎么做，也做不来知书达理的大家闺秀，让公公婆婆开心……", "42011");
        giNpcEndAction("MN003", false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：那你相公呢？这些事他知道吗？", "42012");
        giSetPortrait("211A", false);
        giTalk("琴姬：他？他那样孝顺的一个人，当初为了娶我，却不惜违逆家里的意思……只是这种事又怎能一而再、再而三地犯……", "42013");
        giSetPortrait("211A", false);
        giTalk("琴姬：渐渐地，就算有相公陪伴，日子也变得越来越难熬……我那时就有了重出江湖的念头……直到有一天，我又惹得婆婆不高兴……那一次连相公也责怪了我几句，我一怒之下留书出走……", "42014");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：……与其在家里受气，当女侠说不定还自在很多呢。", "42015");
        giCameraRunSingle("007", true);
        giWait(0.3);
        giNpcDoAction("MN003", "C09", 1, false);
        giSetPortrait("211A", true);
        giTalk("琴姬：岂止是女侠？每个学剑的人都梦想成为上天入地的剑仙，我也是一样，离家以后就遍访名山大川，求仙问道……", "42016");
        giNpcEndAction("MN003", false);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：哦～原来你也喜欢在天上飞。", "42017");
        giSetPortrait("211A", true);
        giTalk("琴姬：……可能人心就是这么不知足，当我剑术大进，反而常常想念相公，他的身子本来就不是特别好，我很担心……我为自己找了很多理由，想回到陈州来看看他……", "42018");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：那后来呢？你见到他了吗？", "42019");
        giNpcDoAction("MN003", "C09", 1, false);
        giSetPortrait("211A", true);
        giTalk("琴姬：我回到陈州时，才知他已过世好几个月了……", "42020");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：他、你相公是怎么了？！怎么会……？", "42021");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("211A", true);
        giTalk("琴姬：听说相公在我离开后身子更是糟糕，婆婆为他定下一门亲事冲喜，但新妇过门没多久，他还是去了……", "42022");
        giSetPortrait("211A", true);
        giTalk("琴姬：我曾经想过千百遍和他重逢的情形，我宁可他骂我、不原谅我，也不要这个样子……", "42023");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……那，我们要怎么做才能帮你？", "42024");
        giWait(0.5);
        giNpcSetDir("MN003", 289.0, true);
        giWait(0.5);
        giSetPortrait("211A", false);
        giTalk("琴姬：……如今后悔也没用了，我根本不知道秦家把相公葬在哪里，我只想去千佛塔，在他的牌位前上柱香，请他原谅我以前的不懂事……", "42025");
        giSetPortrait("101A", false);
        giTalk("云天河：点柱香有什么难的？我天天都会点给我爹啊。", "42026");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("004", false);
        giNpcSetAng("MN003", 336.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("211A", true);
        giTalk("琴姬：云少侠有所不知，陈州的千佛塔中供有佛门圣物，塔顶有圣光投下，所以不单是本城，许多有钱人都千里迢迢把亲眷的牌位送来此地，想要他们的魂灵受佛祖保佑。", "42027");
        giSetPortrait("211A", true);
        giTalk("琴姬：秦家当然也是一样，他们还曾经捐钱修塔，和方丈也颇有交情，或许是秦家知会过什么，那些僧人根本不让我进塔，我也想过在夜里进去，可是为了守护圣物，那儿夜里更是有武僧把守……", "42028");
        giSetPortrait("211A", true);
        giTalk("琴姬：我看得出诸位身手不凡，只想请你们帮我，让我进入塔内，祭拜亡夫。", "42029");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：可是，以你的剑术竟然打不过那些和尚？", "42030");
        giNpcSetDir("MN003", 317.0, true);
        giWait(0.8);
        giNpcDoAction("MN003", "C09", 1, false);
        giWait(0.5);
        giSetPortrait("211A", true);
        giTalk("琴姬：……说来也是阴差阳错，当初听到相公过世，我伤心欲绝，想到他生前不喜我舞刀弄剑，便立下重誓再也不使用一身武艺，谁又料到后来有这许多波折……", "42031");
        giSetPortrait("211A", true);
        giTalk("琴姬：……那以后我一直在陈州街头弹琴，想要找到心地善良又身怀武艺的人帮帮我。", "42032");
        giWait(0.4);
        giCameraRunSingle("006", true);
        giWait(0.5);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：那秦家人也太过份了，人都入土了，祭拜一下又不会怎样。这个忙我是帮定了！", "42033");
        giScriptMusicStop(1, 2.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：对，我也要去！", "42034");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：既然这样，是否需要我们今夜就进入千佛塔？", "42035");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("008", false);
        giNpcSetAng("MN003", 292.0);
        giIMMEnd();
        giWait(0.8);
        giNpcDoAction("MN003", "J01", 1, false);
        giSetPortrait("211A", false);
        giTalk("琴姬：有劳各位，你们的大恩大德我一生一世都铭记在心。", "42036");
        giSetPortrait("106B", true);
        giTalk("柳梦璃：你太客气了，我还想听你弹琴唱歌呢，所以也不算白帮你～", "42037");
        giSetPortrait("211A", false);
        giTalk("琴姬：……多谢。这样，<colour red=255 green=187 blue=0 alpha=255>今日戌时我便在湖心岛的千佛塔下等你们。</colour>", "42038");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：嗯，一言为定。", "42039");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giNpcDoAction("MN003", "J01", 1, true);
        giWait(0.5);
        giNpcSetDir("MN003", 25.0, true);
        giWait(1.0);
        giSetObjectVisible("MO002", false);
        giWait(0.85);
        giNpcWalkTo("MN003", 3307.8145, 61.2674, -2248.0251, true);
        giNpcWalkTo("MN003", 3346.448, 61.2674, -2136.6445, false);
        giCameraRunSingle("009", false);
        giWait(1.3);
        giIMMBegin();
        giPlayerSetDir(0, 66.0, false);
        giPlayerSetDir(1, 81.0, false);
        giPlayerSetDir(2, 48.0, false);
        giIMMEnd();
        giCameraWait();
        giWait(0.8);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……哎，老天爷也太会作弄人了吧？明明是一段好姻缘，偏偏变成这样。", "42040");
        giPlayerSetDir(2, 358.0, true);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：这次也多亏云公子误打误撞，不然我们可能就错过了……", "42041");
        giPlayerSetDir(0, 204.0, true);
        giWait(0.4);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：是吗？呵呵～", "42042");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：少得意，琴姬的事和你乱跑胡闹根本是两回事……", "42043");
        giPlayerSetDir(2, 358.0, false);
        giPlayerSetDir(0, 260.0, true);
        giWait(0.7);
        giSetPortrait("101E", false);
        giTalk("云天河：哦…………", "42044");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：到戌时还早，不如我们先在城里四处看看。", "42045");
        giPlayerSetDir(0, 207.0, false);
        giPlayerSetDir(1, 193.0, true);
        giWait(0.7);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：好啊，被这样一闹，我精神又好些了呢～去逛一逛，要是能遇上怀朔他们就太好了。", "42046");
        giSetPortrait("106B", true);
        giTalk("柳梦璃：嗯，若是累了，再<colour red=255 green=187 blue=0 alpha=255>去客栈歇息</colour><dc0>。</dc0>", "42047");
        giWait(0.5);
        giPlayerInTeam(0, true);
        giWait(2.3);
        giPlayerInTeam(2, true);
        giWait(2.3);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giSetObjectVisible("MO001", false);
        giSetNpcVisible("SO001", true);
        giSetObjectVisible("SO001", true);
        giSetNpcVisible("SN007", true);
        giSetNpcVisible("SN008", true);
        giEventVolumeVisible("ev_Q04_Q04C_16", true);
        giSetObjectVisible("title14", true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetLeader(0);
        giSetNpcVisible("MN003", false);
        global_mvar = 50300; // 0x0000C47C, 第一章 / 3-3-2.弦歌问情 / 客栈休息
        giSetObjectVisible("entrance1", true);
        giSetObjectVisible("entrance2", true);
        giSetObjectVisible("entrance3", true);
        giIMMEnd();
        giPlayerCurrentSetPos(3222.566, -1.6067, -1198.0209);
        giPlayerCurrentSetAng(282.0);
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2003()
{
    giSetFullHP();
    giSetFullMP();
    giWait(2.0);
    giArenaLoad("Q04", "CN03Y", "", true);
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(0, 152.1313, 1.0647, -66.7801);
    giPlayerSetAng(0, 227.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 117.6712, 1.5618, -96.0254);
    giPlayerSetAng(1, 356.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, 107.5627, 1.1526, -51.795);
    giPlayerSetAng(2, 172.0);
    giPlayerSetVisible(2, true);
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giWait(0.6);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：刚刚好耶～快到戌时了。", "42048");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：走吧！<colour red=255 green=187 blue=0 alpha=255>从客栈西边的渡口乘船，就能去湖心岛了。</colour>", "42049");
    giWait(0.3);
    giPlayerDoAction(2, "C08", 1, true);
    giPlayerRunTo(0, 239.9219, 0.7727, -47.8266, false);
    giWait(0.5);
    giSetPortrait("101K", false);
    giTalk("云天河：哟嚯～去打坏人啰！", "42050");
    giWait(0.5);
    giPlayerSetDir(2, 90.0, false);
    giPlayerSetDir(1, 58.0, true);
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：……白痴，哪来的坏人……", "42051");
    giPlayerDoAction(2, "J14", 1, false);
    giSetPortrait("106C", true);
    giTalk("柳梦璃：云公子真是好心人。", "42052");
    giWait(0.4);
    giFlashOutBlack(1.5, true, true);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    global_mvar = 50400; // 0x0000C4E0, 第一章 / 3-3-3.弦歌问情 / 夜入千佛塔
    giIMMEnd();
    giArenaLoad("Q04", "Q04CY", "", false);
    giPlayerLock();
    giCameraSetMode(0, true);
    giPlayerCurrentSetPos(-1846.0101, 65.6341, 202.0232);
    giPlayerCurrentSetAng(187.0);
    giPlayerCurrentSetVisible(true);
    giArenaReady();
    giCameraSeekToPlayer();
    giCameraSetMode(0, true);
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2004()
{
    if (global_mvar == 50400 /* 第一章 / 3-3-3.弦歌问情 / 夜入千佛塔 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 3073.069, 133.3833, -3642.9482);
        giPlayerSetAng(0, 195.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 3009.5303, 133.3833, -3647.7305);
        giPlayerSetAng(1, 152.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, 2981.4128, 133.3833, -3705.4048);
        giPlayerSetAng(2, 108.0);
        giPlayerSetVisible(2, true);
        giNpcSetAng("MN001", 328.0);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giNpcDoAction("MN001", "J01", 1, false);
        giSetPortrait("211A", false);
        giTalk("琴姬：……一切就有劳了。", "42053");
        giNpcEndAction("MN001", false);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：呵呵，包在我身上！", "42054");
        giSetPortrait("103C", true);
        giTalk("韩菱纱：太奇怪了吧？这一路上竟没遇见半个和尚。", "42055");
        giPlayerSetDir(0, 307.0, true);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：对啊，坏人呢？在哪里？", "42056");
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("211A", false);
        giTalk("琴姬：出家人讲究六根清静，无论何时都是空门大开，只不过塔中的圣物实在很重要，寺院才会派人把守。", "42057");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 195.0, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：……塔门似乎关着，我们要如何进去呢？", "42058");
        giIMMBegin();
        giPlayerSetDir(1, 234.0, false);
        giPlayerSetDir(2, 252.0, false);
        giPlayerSetDir(0, 241.0, false);
        giNpcSetDir("MN001", 266.0, false);
        giIMMEnd();
        giWait(0.3);
        giCameraRunSingle("003", false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：我瞧瞧～", "42059");
        giCameraWait();
        giWait(1.2);
        giCameraRunSingle("004", true);
        giCameraRunSingle("005", true);
        giWait(0.5);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：有了，看那边！", "42060");
        giIMMBegin();
        giPlayerSetAng(0, 202.0);
        giPlayerSetAng(1, 185.0);
        giPlayerSetAng(2, 179.0);
        giNpcSetAng("MN001", 202.0);
        giIMMEnd();
        giCameraRunSingle("001", true);
        giWait(0.3);
        giSetPortrait("101C", false);
        giTalk("云天河：什么那边？", "42061");
        giPlayerSetDir(0, 258.0, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：菱纱，你是不是又要学老鼠打洞？", "42062");
        giIMMBegin();
        giPlayerSetDir(1, 89.0, false);
        giPlayerSetDir(2, 48.0, false);
        giNpcSetDir("MN001", 7.0, false);
        giIMMEnd();
        giWait(0.6);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106C", true);
        giTalk("柳梦璃：……噗～", "42063");
        giSetPortrait("103F", true);
        giTalk("韩菱纱：打、打洞？！", "42064");
        giSetPortrait("103F", true);
        giTalk("韩菱纱：（……我倒觉得比较想打人……）", "42065");
        giNpcSetDir("MN001", 334.0, true);
        giSetPortrait("211A", false);
        giTalk("琴姬：韩姑娘可是想从窗子进去？", "42066");
        giIMMBegin();
        giPlayerSetDir(1, 152.0, false);
        giPlayerSetDir(2, 111.0, false);
        giPlayerSetDir(0, 205.0, false);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：嗯～正门看起来又厚又沉，从那儿走八成会打草惊蛇，不如赌一把，试试窗户啰！", "42067");
        giSetPortrait("211A", false);
        giTalk("琴姬：……也好。", "42068");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("MN001", false);
        global_mvar = 50401; // 0x0000C4E1
        giSetObjectVisible("entrance2", true);
        giEventVolumeVisible("ev_Q04_Q04HY_14", false);
        giIMMEnd();
        giArenaLoad("M08", "1", "", false);
    }
}

void func2005()
{
    giPlayerLock();
    giScriptMusicPlay("P35", 2, 0.0, 0.0);
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, -3630.2341, -1.6067, -328.155);
    giPlayerSetAng(0, 246.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, -3679.7368, -1.6067, -302.2357);
    giPlayerSetAng(1, 217.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, -3695.429, -1.6067, -257.5588);
    giPlayerSetAng(2, 192.0);
    giPlayerSetVisible(2, true);
    giSetNpcVisible("MN001", true);
    giSetObjectVisible("entrance4", false);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("004", true);
    giFlashInBlack(2.5, false);
    giArenaReady();
    giWait(1.5);
    giSetPortrait("211A", false);
    giTalk("琴姬：……", "42112");
    giSetPortrait("103F", true);
    giTalk("韩菱纱：那个女的，好讨厌！陈州又不是她家大院，要由她做主！", "42113");
    giWait(0.3);
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("211A", false);
    giTalk("琴姬：……别说了，她也不过是个可怜人……", "42114");
    giSetPortrait("103F", true);
    giTalk("韩菱纱：她……她说的那些，你不生气吗？", "42115");
    giNpcSetDir("MN001", 18.0, true);
    giWait(0.3);
    giSetPortrait("211A", false);
    giTalk("琴姬：……生气又有什么用……一切都是我咎由自取……如果当初没有意气用事，再和相公想想别的法子，或许……或许很多事情就会不同了……", "42116");
    giCameraRunSingle("005", true);
    giWait(0.3);
    giPlayerDoAction(2, "J13", 1, false);
    giSetPortrait("106F", false);
    giTalk("柳梦璃：嗯……我看那女子满面怨怼……她说的，也未必全是真的……", "42117");
    giPlayerEndAction(2);
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("211A", true);
    giTalk("琴姬：……生人已逝，真的还是假的，已无所谓了……若她令相公开开心心过完那段日子，我反倒只有说不尽的感激和惭愧……", "42118");
    giNpcEndAction("MN001", false);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101J", false);
    giTalk("云天河：……你这么说，和我爹说过的好像…… ", "42119");
    giIMMBegin();
    giNpcSetDir("MN001", 57.0, true);
    giPlayerSetDir(1, 123.0, false);
    giPlayerSetDir(2, 136.0, false);
    giIMMEnd();
    giWait(0.7);
    giSetPortrait("101J", false);
    giTalk("云天河：他说真心为一个人好，就是要让她天天高兴，就算那个人不喜欢自己，甚至根本不认识自己也没关系。", "42120");
    giWait(0.5);
    giSetPortrait("211A", true);
    giTalk("琴姬：……这话一点都没错……世人只盼做神仙的好，却不知心有牵挂，无论圆满不圆满，也胜过孑然一身……", "42121");
    giWait(0.5);
    giPlayerSetDir(1, 217.0, true);
    giWait(0.5);
    giSetPortrait("103C", false);
    giTalk("韩菱纱：琴姬姐姐，以后……你要去哪里呢？", "42122");
    giIMMBegin();
    giNpcSetDir("MN001", 18.0, true);
    giPlayerSetDir(2, 192.0, false);
    giPlayerSetDir(0, 246.0, false);
    giIMMEnd();
    giWait(0.6);
    giSetPortrait("211A", true);
    giTalk("琴姬：……与琴相伴，四海为家，走到哪里便是哪里了。", "42123");
    giWait(0.5);
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("211A", true);
    giTalk("琴姬：其实……记不清有多少次，我真想放下尘世一切，就这样随相公去了……", "42124");
    giWait(0.5);
    giSetPortrait("103H", false);
    giTalk("韩菱纱：琴姬姐姐……", "42125");
    giWait(0.5);
    giSetPortrait("211A", true);
    giTalk("琴姬：……可是，我对不起相公……我没有脸去见他……", "42126");
    giSetPortrait("211A", true);
    giTalk("琴姬：我告诉自己，至少……要放下武功，尽心搜集历代的乐曲残谱，替相公了却生前心愿，或许……或许这样……他才愿意在梦中与我见上一面……", "42127");
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103H", false);
    giTalk("韩菱纱：琴姬姐姐，别这样，你……", "42128");
    giWait(0.3);
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("211A", true);
    giTalk("琴姬：不用担心……该怎么做，我心里很清楚……我不在相公身边的时候，他一定也很痛苦、很伤心……如今，我不过是尝到昔日的苦果，又凭什么一死以求解脱呢……", "42129");
    giNpcEndAction("MN001", false);
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103H", false);
    giTalk("韩菱纱：……", "42130");
    giNpcDoAction("MN001", "J01", 1, false);
    giSetPortrait("211A", true);
    giTalk("琴姬：……各位的热血心肠，琴姬不胜感佩，既已说过为你们歌唱一曲，自当信守诺言——", "42131");
    giFlashOutBlack(1.5, true, true);
    giWait(1.0);
    giScriptMusicStop(0, 2.5);
    giScriptMusicPlay("P61", 0, 0.0, 0.0);
    giWait(1.5);
    giIMMBegin();
    giPlayerSetPos(0, -3876.913, 65.6341, 1129.0115);
    giPlayerSetAng(0, 198.0);
    giPlayerSetPos(1, -3835.3213, 65.6341, 1093.6616);
    giPlayerSetAng(1, 239.0);
    giPlayerSetPos(2, -3821.5283, 65.6341, 1055.0161);
    giPlayerSetAng(2, 265.0);
    giSetNpcVisible("MN001", false);
    giSetNpcVisible("MN002", true);
    giSetObjectVisible("sound010", false);
    giSetObjectVisible("sound011", false);
    giSetObjectVisible("sound009", false);
    giIMMEnd();
    giPlayerDoAction(0, "C10", 0, false);
    giPlayerDoAction(1, "C10", 0, false);
    giPlayerDoAction(2, "C10", 0, false);
    giNpcDoAction("MN002", "J03", 0, false);
    giCameraPrepare("MC002");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.3, true);
    giCameraRunSingle("002", true);
    giCameraRunSingle("003", true);
    giCameraRunSingle("004", true);
    giWait(0.5);
    giCameraRunSingle("005", true);
    giWait(0.3);
    giSetPortrait("106F", true);
    giTalk("柳梦璃：……细雨飘，轻风摇，凭藉痴心般情长……", "42132");
    giWait(0.5);
    giSetPortrait("103H", false);
    giTalk("韩菱纱：琴姬姐姐……她是用自己全部的心和命在唱这首歌啊……太悲伤了……为什么上天要让两个人有缘，却又无份……", "42133");
    giWait(0.5);
    giSetPortrait("106F", true);
    giTalk("柳梦璃：……或许人和人之间的缘份，都是注定的……等到上天要收回的时候，连一天一刻都不会多等……", "42134");
    giSetPortrait("103H", false);
    giTalk("韩菱纱：……这样，好残忍……要我选的话，我宁可一开始就不认识那个人，也好过相识以后却要生离死别……", "42135");
    giCameraRunSingle("006", true);
    giWait(0.3);
    giSetPortrait("101J", false);
    giTalk("云天河：话是这么说没错，但是……就算我们三个明天就会分开，我也不后悔认识你和梦璃。", "42136");
    giSetPortrait("101J", false);
    giTalk("云天河：爹说过，活着的时候要尽欢，死的时候才没有遗憾，要是因为害怕以后的事，一直避开当下的事，那活着也不会开心的，还有什么意思。", "42137");
    giCameraRunSingle("005", true);
    giWait(0.3);
    giSetPortrait("106F", true);
    giTalk("柳梦璃：……我想、我明白云叔说的……与其担心人生无常，不如多珍惜眼前时光……多珍惜和重要的人在一起的时光啊……", "42138");
    giCameraRunSingle("006", true);
    giWait(0.3);
    giSetPortrait("101J", false);
    giTalk("云天河：差不多吧，反正每天都要过得开心，以后想起来也就没什么遗憾了。", "42139");
    giCameraRunSingle("007", true);
    giWait(0.5);
    giSetPortrait("103H", true);
    giTalk("韩菱纱：……是吗？……生尽欢、死无憾……", "42140");
    giCameraRunSingle("008", false);
    giWait(20.0);
    giFlashOutBlack(1.5, true, true);
    giPlayerEndAction(0);
    giPlayerEndAction(1);
    giPlayerEndAction(2);
    giNpcEndAction("MN002", false);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    giSetNpcVisible("MN002", false);
    global_mvar = 50800; // 0x0000C670
    giIMMEnd();
    giArenaLoad("M08", "5", "", false);
}

void func2006()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(0, 134.1436, 0.3786, -84.7588);
    giPlayerSetAng(0, 329.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 104.0159, 0.3786, -44.8146);
    giPlayerSetAng(1, 173.0);
    giPlayerSetVisible(1, true);
    giCameraPrepare("MC001");
    giCameraRunSingle("002", true);
    giArenaReady();
    giWait(3.2);
    giSetPortrait("103H", true);
    giTalk("韩菱纱：……天河，醒醒！", "42148");
    giWait(0.5);
    giSetPortrait("101G", false);
    giTalk("云天河：唔……", "42149");
    giSetPortrait("103H", true);
    giTalk("韩菱纱：出事了！", "42150");
    giFlashInBlack(2.0, false);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101E", false);
    giTalk("云天河：……什么……好睏哦……", "42151");
    giPlayerDoAction(1, "J04", -1, false);
    giSetPortrait("103H", true);
    giTalk("韩菱纱：……昨天，我们在千佛塔里见过的那个人……她……她自尽了…… ", "42152");
    giPlayerDoAction(0, "J02", 1, false);
    giSetPortrait("101D", false);
    giTalk("云天河：啊？！", "42153");
    giSetPortrait("103H", true);
    giTalk("韩菱纱：想不到……她的性情那么烈，……也许……我昨天不应该那样讲……我……我实在是……", "42154");
    giSetPortrait("101C", false);
    giTalk("云天河：…………", "42155");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103H", true);
    giTalk("韩菱纱：你……怎么都不说话？", "42156");
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101A", false);
    giTalk("云天河：……我觉得，那个女的说不定是个很了不起的人……", "42157");
    giSetPortrait("103H", true);
    giTalk("韩菱纱：了不起？", "42158");
    giSetPortrait("101J", false);
    giTalk("云天河：她……是想去陪那个男的吧？那是她自己的愿望。我爹说过，人能够按自己的愿望选择生死，不管对错，都是一件了不起的事。", "42159");
    giSetPortrait("101J", false);
    giTalk("云天河：所以我想……要是我们可怜那个女的，她大概也不会高兴……", "42160");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("103H", true);
    giTalk("韩菱纱：…………也许，你是对的吧……", "42161");
    giPlayerDoAction(1, "C08", 1, false);
    giSetPortrait("103H", true);
    giTalk("韩菱纱：……她生前不一定被相公所爱，死后却一定要去争，这份心意，也很让人动容了……", "42162");
    giWait(0.5);
    giPlayerSetDir(1, 5.0, true);
    giWait(0.5);
    giPlayerDoAction(1, "J04", -1, false);
    giSetPortrait("103H", true);
    giTalk("韩菱纱：……不过发生了这种事，总是让人难过……一个人，昨天明明还和你说话、还会动，今天却哪里都找不到了，这样的感觉……一点都不好受……", "42163");
    giSetPortrait("101A", false);
    giTalk("云天河：…………", "42164");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerSetDir(1, 173.0, true);
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103H", true);
    giTalk("韩菱纱：……算了，不说了……<colour red=255 green=187 blue=0 alpha=255>我们还是下楼去找梦璃吧，</colour><dc0>她都起来好久了。</dc0>", "42165");
    giPlayerEndAction(1);
    giPlayerWalkTo(1, 94.4256, 0.3786, 29.0078, true);
    giFlashOutBlack(1.5, true, true);
    giIMMBegin();
    giPlayerSetVisible(1, false);
    global_mvar = 51100; // 0x0000C79C, 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃
    giIMMEnd();
    giSetFullHP();
    giSetFullMP();
    giPlayerOutTeam(1, false);
    giPlayerOutTeam(2, false);
    giPlayerSetLeader(0);
    giCameraSetMode(2, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giScriptMusicStop(0, 2.5);
    giPlayerUnLock();
}

void func2007()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, 86.2966, 95.2266, -254.4587);
    giPlayerSetAng(0, 315.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 114.0395, 75.3779, -269.6497);
    giPlayerSetAng(1, 319.0);
    giPlayerSetVisible(1, true);
    giSetNpcVisible("MN001", true);
    giSetNpcVisible("MN002", true);
    giSetNpcVisible("MN003", true);
    giSetNpcVisible("MN004", true);
    giSetNpcVisible("MN005", true);
    giSetNpcVisible("4022", false);
    giSetNpcVisible("4018", false);
    giSetNpcVisible("4020", false);
    giSetNpcVisible("4021", false);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(3.0, false);
    giArenaReady();
    giWait(3.0);
    giTalk("客人甲：听说没？城里首富家中又出大事了！", "42166");
    giTalk("客人乙：你说那个秦家？！", "42167");
    giTalk("客人甲：不然还有谁！他们家的媳妇昨夜在千佛塔里自尽了！仵作看过，说是吞毒死的！更奇怪的是，守塔的僧人都说昨天夜里有人闯进去，偏偏又讲不出贼人相貌，方丈已经决定关闭禅寺三个月，秦家的人恐怕也不会善罢甘休！", "42168");
    giTalk("客人乙：竟有这等事？！你又如何知道的？", "42169");
    giTalk("客人甲：嘿嘿，我表弟是禅寺的伙头，这事当然比别人都清楚。", "42170");
    giTalk("客人丙：唉，可叹世上痴情女，丈夫死后竟如此贞烈……", "42171");
    giSetPortrait("202B", true);
    giTalk("璇玑：——哎，那个女的好可怜哦……", "42172");
    giCameraRunSingle("002", true);
    giIMMBegin();
    giPlayerSetPos(0, 238.5497, 0.8082, -215.5401);
    giPlayerSetAng(0, 306.0);
    giPlayerSetPos(1, 202.1824, 1.1076, -211.1264);
    giPlayerSetAng(1, 319.0);
    giIMMEnd();
    giWait(2.5);
    giPlayerWalkTo(1, 142.0276, 1.5132, -160.4527, true);
    giPlayerSetDir(1, 338.0, false);
    giPlayerWalkTo(0, 179.4021, 1.5196, -173.975, true);
    giPlayerSetDir(0, 317.0, false);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：两位，想不到真的会在这里遇上，我们找你们好久了。", "42173");
    giNpcSetDir("MN004", 154.0, false);
    giNpcSetDir("MN005", 162.0, true);
    giSetPortrait("202D", true);
    giTalk("璇玑：找我们？难怪到哪都会遇上……你们干嘛要跟着我和师兄啊？", "42174");
    giNpcSetDir("MN004", 205.0, true);
    giSetPortrait("203A", true);
    giTalk("怀朔：璇玑！", "42175");
    giPlayerDoAction(1, "J05", 1, false);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：没关系，其实小妹妹说的也对。", "42176");
    giNpcSetDir("MN004", 162.0, false);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：我叫韩菱纱，他叫云天河，我们特意赶来陈州，便是想拜入二位的师门！", "42177");
    giSetPortrait("202D", true);
    giTalk("璇玑：什么？要入我们琼华派？！", "42178");
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：穷华派？是啊，我最想学那招御……对了，御剑飞仙！", "42179");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("202D", true);
    giTalk("璇玑：不行不行，修仙哪有你们想得那么容易！", "42180");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：小妹妹，我们自然知道不容易，但早已下定决心了。", "42181");
    giNpcDoAction("MN005", "J02", 1, false);
    giSetPortrait("202E", true);
    giTalk("璇玑：什么小妹妹，总这么喊，人家哪里小啦！", "42182");
    giNpcEndAction("MN005", false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：那……璇玑姑娘，你和你师兄能不能带我们入门拜师呢？当日在巢湖，多亏你师叔仗义相助，不然我们早成了妖怪的口粮，那之后对剑仙之风更是仰慕——", "42183");
    giSetPortrait("202C", true);
    giTalk("璇玑：师叔？你、你不会也看上我师叔了吧？", "47003");
    giNpcSetDir("MN004", 205.0, true);
    giSetPortrait("203C", true);
    giTalk("怀朔：璇玑，怎可这样讲话！", "42184");
    giNpcSetDir("MN004", 162.0, true);
    giNpcDoAction("MN004", "J01", 1, false);
    giSetPortrait("203A", true);
    giTalk("怀朔：实在抱歉，小师妹她——", "42185");
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：没什么，我们求仙是一片诚心的，更感激剑仙出手相救，怎敢有其他念头，璇玑姑娘也不过是心直口快。", "42186");
    giPlayerDoAction(1, "J13", -1, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：……我见璇玑姑娘聪明伶俐，一定很得令师叔的喜爱吧？", "42187");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("202A", true);
    giTalk("璇玑：哼，算你有见识。", "42188");
    giNpcDoAction("MN005", "J03", -1, false);
    giSetPortrait("202A", true);
    giTalk("璇玑：……喜爱，嘻嘻～", "42189");
    giNpcUnHoldAct("MN005");
    giNpcEndAction("MN005", false);
    giNpcSetDir("MN004", 212.0, true);
    giSetPortrait("203A", true);
    giTalk("怀朔：璇玑……", "42190");
    giNpcSetDir("MN005", 45.0, true);
    giSetPortrait("202A", false);
    giTalk("璇玑：师兄，不如就帮他们一把好了～师父不是常说做人要时存善念吗？反正最后能不能入门还要看他们自己。", "42191");
    giNpcDoAction("MN005", "C09", 1, false);
    giSetPortrait("203A", true);
    giTalk("怀朔：……唉，你啊，真是个孩子。", "42192");
    giNpcEndAction("MN005", true);
    giSetPortrait("203B", true);
    giTalk("怀朔：好吧，既然三番五次有缘相遇，或许也是天意……", "42193");
    giPlayerDoAction(1, "J16", 1, false);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：真的？！你们答应了？", "42194");
    giNpcSetDir("MN004", 154.0, false);
    giNpcSetDir("MN005", 162.0, true);
    giWait(0.8);
    giNpcDoAction("MN004", "C08", 1, true);
    giWait(0.3);
    giCameraRunSingle("003", true);
    giPlayerDoAction(1, "J16", -1, false);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：太谢谢了！", "42195");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerSetDir(1, 131.0, true);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：天河，叫上梦璃，我们一起走吧！", "42196");
    giPlayerSetDir(0, 310.0, true);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：……对啊，梦璃呢？", "42197");
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101A", false);
    giTalk("云天河：我也不知道，没看见她。", "42198");
    giPlayerEndAction(0);
    giIMMBegin();
    giNpcSetAng("MN005", 127.0);
    giNpcSetAng("MN004", 151.0);
    giIMMEnd();
    giCameraRunSingle("005", true);
    giSetPortrait("203B", true);
    giTalk("怀朔：你们是说上回在女萝岩见过的那位姑娘？", "42199");
    giSetPortrait("103C", false);
    giTalk("韩菱纱：嗯，可是她不知去哪里了……", "42200");
    giIMMBegin();
    giPlayerSetAng(0, 310.0);
    giPlayerSetAng(1, 353.0);
    giIMMEnd();
    giNpcDoAction("MN005", "C09", 1, false);
    giSetPortrait("203B", true);
    giTalk("怀朔：无妨，我和璇玑没追上紫英师叔，正要赶回门派中，不如就御剑带你们过去，费不了多少工夫。", "42201");
    giSetPortrait("103M", false);
    giTalk("韩菱纱：多谢。那，什么时候动身呢？", "42202");
    giSetPortrait("203B", true);
    giTalk("怀朔：待那位姑娘来了，<colour red=255 green=187 blue=0 alpha=255>你们就到城门口去吧，</colour><dc0>我和璇玑在那儿等着。</dc0>", "42203");
    giCameraRunSingle("006", true);
    giPlayerDoAction(1, "C08", 1, false);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：好！", "42204");
    giPlayerEndAction(1);
    giNpcWalkTo("MN004", 144.1128, 1.2104, 46.8916, false);
    giWait(1.0);
    giNpcWalkTo("MN005", 90.7009, 1.454, 60.6271, false);
    giWait(1.2);
    giPlayerSetPos(2, 232.2292, 0.724, -212.5404);
    giPlayerSetAng(2, 284.0);
    giPlayerSetVisible(2, true);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：……想不到竟然会这样顺利。", "42205");
    giSetPortrait("106A", false);
    giTalk("柳梦璃：菱纱、云公子。", "42206");
    giCameraRunSingle("007", false);
    giPlayerSetDir(0, 125.0, false);
    giWait(0.5);
    giPlayerWalkTo(1, 181.1169, 1.1969, -207.4256, true);
    giPlayerSetDir(1, 88.0, true);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：好梦璃，你到底跑哪去了？ ", "42207");
    giCameraRunSingle("008", true);
    giWait(0.3);
    giPlayerDoAction(2, "J13", 1, false);
    giSetPortrait("106A", false);
    giTalk("柳梦璃：我见你们迟迟不下来，就去买了些香……", "42208");
    giPlayerEndAction(2);
    giAddProperty(3095, 15, true);
    giWait(2.5);
    giAddProperty(3097, 15, true);
    giWait(2.5);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：那，我们快些<colour red=255 green=187 blue=0 alpha=255>去城门口找怀朔师兄妹吧</colour><dc0>～</dc0> ", "42209");
    giSetPortrait("106E", false);
    giTalk("柳梦璃：你们，已经见过面了？", "42210");
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：是啊，那个人是好人～答应带我们飞去仙山。", "42211");
    giPlayerEndAction(0);
    giSetPortrait("106F", false);
    giTalk("柳梦璃：…………", "42212");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：怎么了？你好像一点都不高兴呢。", "42213");
    giPlayerDoAction(2, "C09", 1, false);
    giSetPortrait("106F", false);
    giTalk("柳梦璃：我……只是想到这两天发生的事，心里总是不舒坦……", "42214");
    giPlayerEndAction(2);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：……别再想了……昨晚你不是已经说过了吗？我们都要珍惜当下，在一起时就要开开心心的，别辜负了来世上走一遭。", "42215");
    giPlayerDoAction(2, "C08", 1, false);
    giSetPortrait("106F", false);
    giTalk("柳梦璃：嗯……", "42216");
    giPlayerEndAction(2);
    giFlashOutBlack(1.5, true, true);
    giPlayerInTeam(1, false);
    giPlayerInTeam(2, false);
    giIMMBegin();
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    giSetNpcVisible("MN001", false);
    giSetNpcVisible("MN002", false);
    giSetNpcVisible("MN003", false);
    giSetNpcVisible("MN004", false);
    giSetNpcVisible("MN005", false);
    giSetNpcVisible("4022", true);
    giSetNpcVisible("4018", true);
    giSetNpcVisible("4020", true);
    global_mvar = 51200; // 0x0000C800, 第一章 / 3-3-6.弦歌问情 / 城门会合
    giIMMEnd();
    if (var_shop012 == 0)
    {
        giSetNpcVisible("4021", true);
    }
    giPlayerSetLeader(0);
    giPlayerSetPos(0, 235.6328, 1.0075, -202.9702);
    giPlayerSetAng(0, 95.0);
    giCameraSetMode(2, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2008()
{
    if (global_mvar == 51200 /* 第一章 / 3-3-6.弦歌问情 / 城门会合 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, -1835.2701, 65.6341, 2591.7393);
        giPlayerSetAng(0, 318.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, -1807.46, 65.6341, 2608.4714);
        giPlayerSetAng(1, 314.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, -1867.2319, 65.6341, 2554.9424);
        giPlayerSetAng(2, 354.0);
        giPlayerSetVisible(2, true);
        giNpcSetAng("MN004", 171.0);
        giNpcSetAng("MN005", 147.0);
        giIMMEnd();
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giCameraSetDistOptEnable(false);
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：刚才为等我耽搁了，实在过意不去。", "42217");
        giSetPortrait("203B", true);
        giTalk("怀朔：姑娘多礼了。其实倒没耽搁什么，我也正好陪璇玑去买糖葫芦——", "42218");
        giWait(0.5);
        giCameraRunSingle("002", false);
        giNpcSetAng("MN005", 40.0);
        giWait(0.5);
        giSetPortrait("202B", false);
        giTalk("璇玑：师～兄～～", "42219");
        giNpcSetDir("MN004", 220.0, true);
        giNpcDoAction("MN005", "J03", 1, false);
        giSetPortrait("202B", false);
        giTalk("璇玑：这么丢脸的事不要拿出来说嘛～", "42220");
        giSetPortrait("203B", true);
        giTalk("怀朔：好～不说不说。", "42221");
        giNpcEndAction("MN005", true);
        giNpcSetDir("MN005", 119.0, false);
        giNpcSetDir("MN004", 149.0, true);
        giWait(0.5);
        giSetPortrait("203B", false);
        giTalk("怀朔：诸位，本派虽距陈州有万里之遥，但以御剑术一盏茶的工夫即可到了，只不过我与师妹只得两把佩剑，这么多人怕是不行，所以想借云兄弟的佩剑一用。", "42222");
        giCameraRunSingle("003", true);
        giWait(0.5);
        giSetPortrait("101B", false);
        giTalk("云天河：好啊，你拿去。", "42223");
        giPlayerDoAction(0, "J09", -1, true);
        giGOBAttachToPlayer("MO004", "", 0, true);
        giWait(0.8);
        giSetPortrait("203A", true);
        giTalk("怀朔：……！！这把剑造型十分特异……", "42224");
        giSetPortrait("101A", false);
        giTalk("云天河：唔，我以前也不觉得，爹把剑给了我以后，我就一直用它了，下山后见的多了，才知道它确实和其他剑长得不太一样……", "42225");
        giSetPortrait("202A", true);
        giTalk("璇玑：师兄，这剑怪模怪样，连剑格都没有，和寻常的样子差太多了，说不定铸它的人只是想哗众取宠……", "42226");
        giNpcDoAction("MN004", "C09", 1, false);
        giSetPortrait("203A", true);
        giTalk("怀朔：这……倒也不能妄下定论…… 此剑灵力强大，并且其中蕴有巨大寒气……", "42227");
        giGOBDetachFromPlayer(0);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("203A", true);
        giTalk("怀朔：云兄弟难道没有察觉？平日使剑不会被寒气伤身？", "42228");
        giCameraRunSingle("004", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：伤身？没有啊，这剑我耍着玩好久了。", "42229");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：这野人身体强壮、四肢发达，那点寒气对他来说不算什么吧……", "42230");
        giPlayerEndAction(1);
        giSetPortrait("203A", true);
        giTalk("怀朔：……这便奇了，莫非云兄弟修炼了何种高深的内功或法术？", "42231");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：没啊。", "42232");
        giPlayerEndAction(0);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：他最擅长猎野猪还有吃饭，其他都不会。", "42233");
        giSetPortrait("103J", false);
        giTalk("韩菱纱：（哼！讽刺你一下。）", "42234");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：对对对！还是菱纱知道我。", "42235");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（……白痴……讽刺你一点用都没有……）", "42236");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106D", false);
        giTalk("柳梦璃：如此说来，这是一把很不同寻常的宝剑？", "42237");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giIMMBegin();
        giNpcSetAng("MN004", 141.0);
        giNpcSetAng("MN005", 116.0);
        giIMMEnd();
        giCameraRunSingle("005", true);
        giWait(0.3);
        giNpcDoAction("MN004", "C08", 1, false);
        giSetPortrait("203A", true);
        giTalk("怀朔：不错。", "42238");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……有的时候是怪怪的，可平时也不见它特别厉害呐……", "42239");
        giSetPortrait("101B", false);
        giTalk("云天河：这剑我从小就用，也没啥特别，前些日子突然变得有点怪……威力大了些，摸起来更冰凉，夏天用最好，呵呵。", "42240");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（真是糟蹋宝贝……）", "42241");
        giPlayerEndAction(1);
        giSetPortrait("203A", true);
        giTalk("怀朔：姑且不论此剑，即便宝剑有灵，所持之人也要有与之匹配的力量方可激发，否则人不可役剑，剑无以护人，也是无可奈何的事。", "42242");
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：哦～听着就很有道理，不愧是修仙练剑的人。", "42243");
        giPlayerEndAction(1);
        giSetPortrait("203A", true);
        giTalk("怀朔：云兄弟，令尊可是一位高人前辈？ ", "42244");
        giSetPortrait("101C", false);
        giTalk("云天河：令尊？……啥东西？", "42245");
        giPlayerSetDir(1, 264.0, true);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：哎，就是你爹……", "42246");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：哦，爹就是爹，不是其他什么人，不过我知道他很了不起的～呵呵。", "42247");
        giPlayerSetDir(1, 314.0, true);
        giSetPortrait("203A", true);
        giTalk("怀朔：……可惜我相剑之术所学不精，看不透此剑深浅。", "42248");
        giSetPortrait("203A", true);
        giTalk("怀朔：罢了……我们即刻起程吧，青冥之中务必要心无杂念，不然——", "42249");
        giSetPortrait("202A", true);
        giTalk("璇玑：不然从天上掉下来，我和师兄可不管哦，嘻～", "42250");
        giNpcSetDir("MN004", 228.0, true);
        giNpcDoAction("MN004", "C09", 1, false);
        giSetPortrait("203B", true);
        giTalk("怀朔：你啊……", "42251");
        giFlashOutBlack(1.5, true, true);
        giCameraSetDistOptEnable(true);
        giNpcEndAction("MN004", true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("MN004", false);
        giSetNpcVisible("MN005", false);
        global_mvar = 51400; // 0x0000C8C8, 陈州行侠
        giIMMEnd();
        giScriptMusicPause();
        giPlayMovie("5M.bik");
        giOpenMovieFlag(4);
        giScriptMusicResume();
        giArenaLoad("Q05", "Q05", "", true);
    }
}

void func2009()
{
    giPlayerLock();
    giPlayerSetLeader(0);
    giPlayerWalkTo(0, -1144.9812, 65.634, 2685.0615, true);
    giPlayerSetDir(0, 180.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giSetPortrait("101J", true);
    giTalk("云天河：该去<colour red=255 green=187 blue=0 alpha=255>千佛塔</colour><dc0>打坏人了！</dc0>", "");
    giPlayerUnLock();
}

void func2010()
{
    giPlayerLock();
    giPlayerSetLeader(0);
    giPlayerWalkTo(0, -1437.954, 65.6342, 2692.601, true);
    giPlayerSetDir(0, 180.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giSetPortrait("101J", true);
    giTalk("云天河：该去<colour red=255 green=187 blue=0 alpha=255>千佛塔</colour><dc0>打坏人了！</dc0>", "");
    giPlayerUnLock();
}

void func2011()
{
    giPlayerLock();
    giPlayerSetLeader(0);
    giPlayerWalkTo(0, -1724.0535, 65.6341, 2704.183, true);
    giPlayerSetDir(0, 180.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giSetPortrait("101J", true);
    giTalk("云天河：该去<colour red=255 green=187 blue=0 alpha=255>千佛塔</colour><dc0>打坏人了！</dc0>", "");
    giPlayerUnLock();
}

void func2012()
{
    if (global_mvar == 50200 /* 第一章 / 3-3-1.弦歌问情 / 城中寻人 */)
    {
        giPlayerLock();
        giPlayerWalkTo(1, -1145.6809, 65.6341, 2693.0923, true);
        giPlayerSetDir(1, 180.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：不出城了……<colour red=255 green=187 blue=0 alpha=255>先在城里找到云天河</colour><dc0>那个野人！</dc0>", "");
        giPlayerUnLock();
    }
}

void func2013()
{
    if (global_mvar == 50200 /* 第一章 / 3-3-1.弦歌问情 / 城中寻人 */)
    {
        giPlayerLock();
        giPlayerWalkTo(1, -1439.0037, 65.6341, 2691.226, true);
        giPlayerSetDir(1, 180.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：不出城了……<colour red=255 green=187 blue=0 alpha=255>先在城里找到云天河</colour><dc0>那个野人！</dc0>", "");
        giPlayerUnLock();
    }
}

void func2014()
{
    if (global_mvar == 50200 /* 第一章 / 3-3-1.弦歌问情 / 城中寻人 */)
    {
        giPlayerLock();
        giPlayerWalkTo(1, -1726.5122, 65.6341, 2692.697, true);
        giPlayerSetDir(1, 180.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：不出城了……<colour red=255 green=187 blue=0 alpha=255>先在城里找到云天河</colour><dc0>那个野人！</dc0>", "");
        giPlayerUnLock();
    }
}

void func3001()
{
    if (global_mvar <= 51200 && global_mvar >= 50300 && npc_a == 0 /* 第一章 / 3-3-6.弦歌问情 / 城门会合 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P23", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 4673.6772, -1.6067, 374.2034);
        giPlayerSetAng(0, 56.0);
        giPlayerSetPos(1, 4800.77, -1.6067, 279.2688);
        giPlayerSetAng(1, 326.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giSetNpcVisible("SN001", true);
        giSetNpcVisible("4035", false);
        giSetObjectVisible("title11", false);
        giIMMEnd();
        giCameraPrepare("shu001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giSetPortrait("101A", false);
        giTalk("云天河：这是什么？上面有画、还有字，不过画的不是菱纱了……", "");
        giPlayerWalkTo(1, 4738.7915, -1.6067, 374.0964, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：天河，在看什么呢？我瞧瞧～", "");
        giPlayerEndMove(1);
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：芙蓉转圈舞蹈处，左摇右摆好似鸭。挥袖扭腰真窈窕，看得我心花怒放……", "");
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：哈、哈哈～～太好笑了，哪有人这样写诗的？“左摇右摆好似鸭”，到底是在夸人还是在损人啊？还有这个……难道就是那个“芙蓉”？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.30000001192092896);
        giTalk("？？：好大胆子！竟敢嘲笑本少爷的墨宝！", "");
        giWait(0.5);
        giPlayerSetDir(1, 208.0, false);
        giPlayerSetDir(0, 170.0, false);
        giCameraRunSingle("002", true);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：墨～～宝～～？在哪里？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcDoAction("SN001", "C07", -1, false);
        giTalk("？？：可恶！你们不是刚刚才拜读过！", "");
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：……不是吧？你说马车背后贴的这张纸？", "");
        giTalk("？？：当然！本少爷的卓然文采一定要公布出来，让全城的人都能看到！", "");
        giSetPortrait("103D", true);
        giTalk("韩菱纱：……………………", "");
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giPlayerSetDir(1, 284.0, true);
        giWait(0.5);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：天河，我们走吧，我想起还有些东西要买呢。", "");
        giPlayerSetDir(0, 100.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：哦，好。", "");
        giPlayerEndAction(0);
        giWait(0.30000001192092896);
        giCameraRunSingle("004", true);
        giWait(0.30000001192092896);
        giNpcDoAction("SN001", "J01", -1, false);
        giTalk("？？：等一下！！", "");
        giTalk("？？：你竟然小瞧我！告诉你们，我爹当年金榜题名，连中三元，如今官拜礼部尚书！虽然我景阳现下没有功名，可谁人不知本少爷是陈州第一才子？！", "");
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giWait(0.30000001192092896);
        giIMMBegin();
        giPlayerSetAng(1, 208.0);
        giPlayerSetAng(0, 170.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：姓景？又是礼部尚书？……难道你爹是景桓、景大人？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("景阳：哈哈，没错，看不出你还有点见识，知道我爹大名～～", "");
        giWait(0.5);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：喂，我说小少爷，你爹又不是你，你的那点本事就不要拿出来显摆了好不好～要是这也算陈州第一才子，那我还是中原第一美少女呢……", "");
        giNpcDoAction("SN001", "J01", -1, false);
        giTalk("景阳：你！可恶！什么中原第一美少女，你敢与我拼一拼诗文吗？！", "");
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：少来，我没空陪小孩子玩。", "");
        giPlayerEndAction(1);
        giTalk("景阳：胆小鬼！你怕了——", "");
        giCameraRunSingle("006", true);
        giTalk("仆人：少爷！你在哪里？夫人说我们要走了！", "");
        giTalk("景阳：……哼，娘在找我，今日就算了，下回再比试！", "");
        giNpcWalkTo("SN001", 4669.284, -1.6067, 154.243, false);
        giCameraRunSingle("007", false);
        giWait(2.0);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：真是无聊的小鬼，写那么乱七八糟的诗，谁答应要和他比了……", "");
        giPlayerSetDir(0, 90.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：那几句话是他写的？我觉得还挺有趣的～", "");
        giPlayerEndAction(0);
        giPlayerSetDir(1, 282.0, true);
        giWait(0.30000001192092896);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：嘻，有趣是有趣，刚看到时简直笑死我了。哎，枉费景大人这样一位治世能臣，他的儿子却是个绣花枕头…… ", "");
        giSetPortrait("101A", false);
        giTalk("云天河：哦……", "");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：别哦了，陪我去买点东西吧～<colour red=255 green=187 blue=0 alpha=255>改天有空再来看看这小少爷</colour><dc0>，到底有没有成为陈州第一才子～</dc0>", "");
        giFlashOutBlack(1.5, true, true);
        giSetNpcVisible("SO001", false);
        giSetObjectVisible("SO001", false);
        giPlayerEndAction(1);
        giPlayerSetVisible(1, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(4548.9663, -1.6067, 361.957);
        giPlayerCurrentSetAng(180.0);
        giSetNpcVisible("SN001", false);
        giSetNpcVisible("4035", true);
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giSetObjectVisible("title11", true);
        npc_a = 1;
        giScriptMusicStop(0, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func3002()
{
    if (npc_a == 1)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -1532.3586, 65.6341, 1240.9602);
        giPlayerSetAng(0, 56.0);
        giPlayerSetPos(1, -1466.4623, 65.6341, 1265.9639);
        giPlayerSetAng(1, 112.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giSetNpcVisible("4003", false);
        giSetNpcVisible("4073", false);
        giSetObjectVisible("title06", false);
        giSetObjectVisible("title03", false);
        giIMMEnd();
        giCameraPrepare("shu002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giCameraRunSingle("002", false);
        giWait(1.7000000476837158);
        giTalk("少女：那个是“小鸡啄米图”？鸡是长这样吗？", "");
        giTalk("少年：这座亭子上压着一块大石头，亭子怎么没塌呀？哈哈哈！好奇怪！ ", "");
        giTalk("书生：待我看看～“芙蓉转圈舞蹈处，左摇右摆好似鸭”……不妥、不妥！玉芙蓉的舞姿窈窕婀娜，怎能用笨拙的“鸭”来比拟？这、这分明是在侮辱玉芙蓉姑娘！！", "");
        giTalk("景阳：你们不买就走开！不要在这里挡我做生意！", "");
        giTalk("少年：哈哈，骗人！这摊子摆了好几天，卖出过一幅画吗？", "");
        giNpcFaceToNpc("SN002", "SN003", true);
        giWait(0.30000001192092896);
        giTalk("景阳：你、你胡说……本少爷是陈州第一才子，我的字画怎会没人买！", "");
        giPlayerWalkTo(0, -1363.2325, 65.6341, 1244.1239, false);
        giWait(1.5);
        giCameraRunSingle("004", false);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 110.0);
        giWait(1.0);
        giCameraWait();
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：那个……我能用钱换你的画吗？", "");
        giPlayerEndAction(0);
        giNpcFaceToPlayer("SN002", 0, true);
        giTalk("景阳：你看中我的墨宝？果然有眼光！", "");
        giTalk("景阳：说吧！到底是哪一幅？", "");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：唔，就是这个，芙蓉跳舞的这张～", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("书生：怎、怎可能……如此拙劣的字画竟会有人赏识？而我十年苦读，所著之书居然未有知音，真是苍天无眼呐！", "");
        giTalk("景阳：哈，英雄所见略同，这也是我最为得意之作呢。我忍痛割爱，就卖……卖二十文钱好了。", "");
        giSetPortrait("102C", false);
        giTalk("云天河：二十文？", "");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：（那是多少？我算算先……）", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("景阳：是不是嫌多？那……十五文也可以，或者十文——", "");
        giSetPortrait("104A", false);
        giTalk("韩菱纱：在卖什么东西呀？掉价掉得这样厉害？", "");
        giWait(0.5);
        giPlayerSetDir(0, 270.0, false);
        giCameraRunSingle("003", true);
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：菱纱，你快来～上回你说很有趣的那幅画，我买下来送给你～", "");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J16", 1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：嘻，什么有趣的画？", "");
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetPos(0, -1367.7175, 65.6341, 1208.6495);
        giPlayerSetAng(0, 334.0);
        giNpcSetPos("SN002", -1235.3867, 65.6341, 1195.1053);
        giNpcSetAng("SN002", 294.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giCameraRunSingle("006", false);
        giPlayerWalkTo(1, -1383.3888, 65.6341, 1262.2661, true);
        giPlayerSetAng(1, 114.0);
        giCameraWait();
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：“芙蓉转圈舞蹈处，左摇右摆好似鸭”……这、这不是那首蠢蠢的诗？怎么到哪都看见……", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcDoAction("SN002", "J01", -1, false);
        giTalk("景阳：你、你是那个冒牌的中原第一美少女！", "");
        giNpcUnHoldAct("SN002");
        giNpcEndAction("SN002", true);
        giPlayerSetDir(0, 54.0, false);
        giPlayerSetDir(1, 136.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104J", false);
        giTalk("韩菱纱：哦～原来是任性的景大才子，这一次又在玩什么？难道是要全城的人都来买你字画、见识见识你的文采？", "");
        giPlayerEndAction(1);
        giTalk("景阳：要、要你管！", "");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104J", false);
        giTalk("韩菱纱：不管、不管～", "");
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(1, 182.0, true);
        giWait(0.5);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：天河，走啦，这画虽然有趣，但我又不喜欢，不买了。", "");
        giNpcFaceToPlayer("SN002", 0, true);
        giTalk("景阳：不买？不行，说好了的，你一定要买！", "");
        giPlayerSetDir(1, 136.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：哪有这道理？又没银货两讫，刚才还在讲价呢。", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("书生：做生意竟有如此强买强卖的……", "");
        giTalk("少女：是啊，那种字画送我也不要……", "");
        giTalk("景阳：你们……你们都走开！", "");
        giTalk("书生：散了、散了，留下也是无趣。", "");
        giNpcWalkTo("SN003", -1414.7566, 65.6341, 1346.0885, false);
        giNpcWalkTo("SN004", -1451.9263, 65.6341, 1129.3856, false);
        giNpcWalkTo("SN005", -1423.2472, 65.6341, 1098.1943, false);
        giNpcEndMove("SN003");
        giNpcEndMove("SN004");
        giNpcEndMove("SN005");
        giIMMBegin();
        giSetNpcVisible("SN003", false);
        giSetNpcVisible("SN004", false);
        giSetNpcVisible("SN005", false);
        giIMMEnd();
        giIMMBegin();
        giPlayerSetAng(0, 98.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giTalk("景阳：……你，真的不买了？不再想想？", "");
        giTalk("巧婶：少爷！我说少爷啊，你……你怎么又跑来这里卖字画？", "");
        giSetNpcVisible("SN006", true);
        giNpcFaceToNpc("SN002", "SN006", false);
        giCameraRunSingle("008", true);
        giTalk("景阳：巧婶？……你来干嘛？ ", "");
        giTalk("巧婶：唉，少爷，你这不是让我和夫人心里难过吗？你从小过得娇贵，怎么吃得起这种苦？", "");
        giNpcDoAction("SN002", "C07", -1, false);
        giTalk("景阳：谁说不行？我可以的！要是……要是这笔生意谈成了，至少能赚到十文钱……不，一文也好，攒下来给爹买药！", "");
        giNpcUnHoldAct("SN002");
        giNpcEndAction("SN002", true);
        giTalk("景阳：你回去吧，你出来找我，娘一个人要照顾爹，忙不过来的。", "");
        giTalk("巧婶：……少爷……", "");
        giTalk("景阳：走！你走啊。", "");
        giTalk("巧婶：……唉，那我先回去帮夫人了，少爷你也早点回来，夫人她会担心……", "");
        giNpcSetDir("SN002", 284.0, true);
        giWait(1.0);
        giNpcWalkTo("SN006", -1162.3859, 65.6341, 1039.5836, true);
        giIMMBegin();
        giPlayerSetPos(1, -1314.0989, 65.6341, 1220.7573);
        giPlayerSetAng(1, 114.0);
        giPlayerSetPos(0, -1369.6132, 65.6341, 1206.3284);
        giPlayerSetAng(0, 74.0);
        giSetNpcVisible("SN006", false);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：喂……景少爷，你爹不是礼部尚书吗？怎么会——", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("景阳：我爹当然是礼部尚书！他是最好的官，从来不收贿赂的！他、他被右丞相陷害，丢了官，还生了大病……", "");
        giSetPortrait("102A", true);
        giTalk("云天河：你爹生病了？那一定要赶快治，治不好的话就会像我爹那样……", "");
        giTalk("景阳：……大夫开出来的方子……那上面的药都很贵，家里已经没多少钱了，能卖的也卖差不多了……", "");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：所以，你才想卖字画、赚钱给你爹抓药？", "");
        giTalk("景阳：……哼，你、你尽管笑话我好了！", "");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：我干嘛要笑话你？好啦，我承认刚才嘲笑你是我不对，要是……我说有办法帮你呢？", "");
        giPlayerEndAction(1);
        giTalk("景阳：帮我？……我才不要别人施舍！", "");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：少爷脾气还真不小，我又没说要施舍你，是借你钱，有借就要有还，懂吗？", "");
        giTalk("景阳：……真的吗？", "");
        giTalk("景阳：可是……我爹的病不是一点点钱就能治好的……", "");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：这你不用担心，<colour red=255 green=187 blue=0 alpha=255>尽管和我去宝气钱庄取钱好了</colour><dc0>。要是单靠卖字画赚钱，你想想，又得卖到何年何月啊？</dc0>", "");
        giPlayerEndAction(1);
        giTalk("景阳：我…………好，我这就去钱庄！信你一回，哼，大不了被骗，也没什么损失……", "");
        giNpcWalkTo("SN002", -1223.3423, 65.6341, 956.5059, false);
        giWait(1.5);
        giIMMBegin();
        giPlayerSetPos(1, -1358.5896, 65.6341, 1224.8499);
        giPlayerSetAng(1, 138.0);
        giPlayerSetPos(0, -1422.276, 65.6341, 1236.4019);
        giPlayerSetAng(0, 108.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：可恶……对好心帮他的人就是这种态度？这脾气不改，很容易得罪人的好不好？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：菱纱，你要是不喜欢那个人，干嘛还帮他？", "");
        giPlayerEndAction(0);
        giPlayerSetDir(1, 278.0, true);
        giWait(0.5);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：哎，他那样也不算什么啦，就是个任性少爷，从小到大没吃过什么苦头，但至少还有一份孝心。", "");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：……再说，我也不是为他……他爹景大人真的是个清官、好官……", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("102A", false);
        giTalk("云天河：清官？……不懂，总之他爹是好人对吧？", "");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：嗯，你说的没错。好人怎么能不救？所以既然这事被我遇上了，一定要管！", "");
        giPlayerEndAction(1);
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(1, false);
        giSetNpcVisible("4003", true);
        giSetNpcVisible("4073", true);
        giSetObjectVisible("title06", true);
        giSetObjectVisible("title03", true);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetAng(180.0);
        giSetNpcVisible("SN002", false);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        npc_a = 2;
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func3003()
{
    if (npc_a == 2)
    {
        giPlayerLock();
        giScriptMusicPlay("P24", 2, 0.0, 0.0);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, -66.6261, 7.6, 206.2717);
        giPlayerSetAng(0, 118.0);
        giPlayerSetPos(1, -2.0201, 7.6, 170.6883);
        giPlayerSetAng(1, 192.0);
        giSetNpcVisible("SN001", true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(0, true);
        giIMMEnd();
        giCameraPrepare("shu003");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giArenaReady();
        giCameraRunSingle("002", false);
        giWait(1.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：掌柜的～麻烦帮我换成一百两的票面。", "");
        giWait(0.5);
        giSetObjectVisible("SO001", true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("曾福达：好，姑娘稍等，待我点一下。", "");
        giNpcDoAction("4023", "C07", -1, true);
        giWait(0.5);
        giSetObjectVisible("SO001", false);
        giWait(0.5);
        giNpcUnHoldAct("4023");
        giNpcEndAction("4023", true);
        giWait(0.5);
        giNpcSetDir("4023", 180.0, true);
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giTalk("景阳：原来，你真的有钱……", "");
        giWait(0.5);
        giNpcResetDir("4023");
        giWait(0.5);
        giTalk("曾福达：是啊，没想到这位姑娘年纪轻轻，却是身家不菲。", "");
        giWait(0.5);
        giNpcDoAction("4023", "C07", -1, true);
        giIMMBegin();
        giSetObjectVisible("SO002", true);
        giSetObjectVisible("SO003", true);
        giSetObjectVisible("SO004", true);
        giSetObjectVisible("SO005", true);
        giIMMEnd();
        giWait(0.5);
        giNpcUnHoldAct("4023");
        giNpcEndAction("4023", true);
        giTalk("曾福达：姑娘你收好，一张一百，一共五张，就是五百两～", "");
        giPlayerDoAction(1, "C07", -1, false);
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("SO002", false);
        giSetObjectVisible("SO003", false);
        giSetObjectVisible("SO004", false);
        giSetObjectVisible("SO005", false);
        giIMMEnd();
        giWait(0.5);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("景阳：五百两？！", "");
        giWait(0.5);
        giCameraRunSingle("004", true);
        giPlayerSetDir(1, 54.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, true);
        giIMMBegin();
        giSetObjectVisible("SO006", true);
        giSetObjectVisible("SO007", true);
        giIMMEnd();
        giSetPortrait("104A", true);
        giTalk("韩菱纱：这些钱你拿着，给你爹买药，剩下的可以买些吃穿，但是记住哦～千万不许挥霍浪费，再有多下来的，宁可去救济其他人。", "");
        giWait(0.5);
        giNpcWalkTo("SN001", 23.4672, 7.6, 198.3006, true);
        giNpcSetAng("SN001", 234.0);
        giWait(0.5);
        giNpcDoAction("SN001", "C07", -1, false);
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("SO006", false);
        giSetObjectVisible("SO007", false);
        giIMMEnd();
        giWait(0.5);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giTalk("景阳：……就算是借的，你、你为什么要平白无故给我这么多钱？", "");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：对啊，菱纱说过，一千文钱是一两银子，那五百两就是……就是……", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("102B", true);
        giTalk("云天河：总之～菱纱，你真的有好多好多文钱！", "");
        giWait(0.5);
        giPlayerSetDir(1, 314.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：嘻嘻，我平日也算出入宝山，当然不能空手而归。", "");
        giSetPortrait("104M", false);
        giTalk("韩菱纱：那些东西换成了银子，一时也用不上，就先存着，有人需要帮忙时就拿出来，也不用四处筹钱了～", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("景阳：……爹以前说做好事会有好报，可是他病倒以后，没有一个亲戚愿意借钱给我们……娘说……不会有人无缘无故对我们好的……", "");
        giTalk("景阳：你，要我怎么报答——", "");
        giWait(0.5);
        giPlayerSetDir(1, 50.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：我说小少爷，你才几岁，哪来这么多功利的想法呀？别说你现在一文不名，就算富可敌国，我也没什么稀罕的。", "");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：反正钱财如那个什么土啦，生不带来、死不带去的，哪比得上活生生一条人命重要？", "");
        giPlayerEndAction(1);
        giTalk("景阳：可是……你我萍水相逢，并没有什么交情，你却对我、对我——", "");
        giTalk("景阳：难道说！……本少爷才貌双全，你一早就对我芳心暗许？", "");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：什么什么什么？！我对你？！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("景阳：哈哈，我明白了，你叫“菱纱”是吗？", "");
        giTalk("景阳：我会记住！看在今日这份患难之情的份上，日后我一定会明媒正娶，让你嫁给我，作正房夫人！就算你年纪大了些，又是江湖草莽，我也绝不会让你受半点委屈的！", "");
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("104I", true);
        giTalk("韩菱纱：你～说～什～么？！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("102H", true);
        giTalk("云天河：菱纱你要嫁他？就是以后一直都在一起？那我怎么办？就没人陪我玩了……", "");
        giWait(0.5);
        giPlayerSetDir(1, 314.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("104I", false);
        giTalk("韩菱纱：你给我闭嘴啦！少来添乱！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetAng(1, 62.0);
        giNpcSetPos("SN001", 47.6507, 7.6, 193.4689);
        giNpcSetAng("SN001", 234.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("104I", true);
        giTalk("韩菱纱：臭小鬼！你你你、你到底是吃什么长大的？！想法乱七八糟！", "");
        giSetPortrait("104I", true);
        giTalk("韩菱纱：姑娘我才看不上你！五百两银子以十年为限，利五十，到时候你要连本带利还给我！听到没有？！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("景阳：哈，菱纱你别这样，我娘说姑娘家就是喜欢口是心非，十年后你来城外龙湖西岸的景家找我，我一定不搬家！", "");
        giTalk("景阳：至于那些银子，不成问题，我九岁时算命，道士说景家由我开始，往后数代之中必有一人会成为蜀中巨富～区区五百两银子，不足挂齿！", "");
        giTalk("景阳：就这么说定啰～这块宝玉就送给你当定情信物，平时想我的话，也可以来看看我呀～", "");
        giWait(0.5);
        giAddProperty(3165, 1, true);
        giWait(2.5);
        giNpcWalkTo("SN001", -32.6697, 7.6, 257.223, false);
        giWait(2.0);
        giPlayerSetDir(1, 350.0, true);
        giSetPortrait("104I", false);
        giTalk("韩菱纱：……………………", "");
        giTalk("曾福达：唉～想不到本钱庄竟会成为小儿女私定终生的地方……不行，我得找个读书人把这事记下来，日后定会传为一段佳话啊。", "");
        giNpcEndMove("SN001");
        giIMMBegin();
        giSetNpcVisible("SN001", false);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("104F", false);
        giTalk("韩菱纱：……早知道……早知道我就不给他钱了，那个臭小鬼根本脑袋有问题！", "");
        giSetPortrait("104F", false);
        giTalk("韩菱纱：我又不指望他还钱，可他竟然要把还钱的日子拖到下辈子、下下辈子、下下下辈子！谁知道他们家到哪一代才会出什么蜀中巨富……", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：菱纱，你、你不会真的要嫁给他吧？", "");
        giPlayerEndAction(0);
        giPlayerSetDir(1, 308.0, true);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104I", false);
        giTalk("韩菱纱：没有啦！我都快气死了，你别再气我了……", "");
        giPlayerEndAction(1);
        giPlayerRunTo(1, 85.0164, 7.6, 257.9183, false);
        giCameraRunSingle("008", false);
        giWait(1.0);
        giPlayerSetDir(0, 80.0, true);
        giCameraWait();
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：我不想气你啊，我只是问问……", "");
        giPlayerEndAction(0);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(1, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetAng(0.0);
        giCameraSetMode(2, true);
        giCameraSeekToPlayer();
        npc_a = 3;
        giAddPlayerFavor(0, 1, 30);
        giScriptMusicStop(0, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func3004()
{
    if ((global_mvar < 120100 && npc_g == 4 || npc_g != 4 && npc_g != 7) && global_mvar >= 120100 && npc_g == 5 || global_mvar >= 120100 && npc_g == 4 || npc_g == 7 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        if (global_mvar <= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
        {
            giPlayerLock();
            giPlayerCurrentWalkTo(2814.6106, -1.6067, 2141.7114, true);
            giPlayerCurrentSetAng(178.0);
            giSetPortrait("102J", true);
            giTalk("云天河：房子里面，应该已经没有人了……", "");
            giCameraSetMode(0, true);
            giPlayerUnLock();
        }
        else
        {
            giPlayerLock();
            giPlayerCurrentWalkTo(2814.6106, -1.6067, 2141.7114, true);
            giPlayerCurrentSetAng(178.0);
            giSetPortrait("101J", true);
            giTalk("云天河：房子里面，应该已经没有人了……", "");
            giCameraSetMode(0, true);
            giPlayerUnLock();
        }
    }
    if (global_mvar <= 51200 && global_mvar >= 50300 && npc_g == 0 /* 第一章 / 3-3-6.弦歌问情 / 城门会合 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P25", 0, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 2812.2952, 1.4372, 2345.1943);
        giPlayerSetVisible(0, true);
        giSetObjectVisible("title14", false);
        giSetNpcVisible("SN007", true);
        giSetNpcVisible("SN008", true);
        giIMMEnd();
        giCameraPrepare("ming001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giTalk("钟伯：……那告示在路边贴了也有将近九年了，渐渐无人问津，没想到还有柳姑娘这样的有心人，特地来一趟，这份心意老朽真是感激不尽呐。", "");
        giSetPortrait("106B", true);
        giTalk("柳梦璃：钟伯伯，您别这么说，我只不过略通法术，也不晓得能不能帮上忙……", "");
        giTalk("钟伯：唉，无论如何，或许都是小姐的命了，谁也不知上天到底是怎样安排的……", "");
        giNpcDoAction("SN007", "J13", 1, false);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：嗯……不知欧阳姑娘现在何处？", "");
        giWait(0.5);
        giTalk("钟伯：请跟我来。", "");
        giPlayerWalkTo(0, 2807.1936, 1.4372, 2405.688, true);
        giPlayerSetAng(0, 12.0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：梦璃，你要去哪？有什么事吗？", "");
        giWait(0.5);
        giNpcSetDir("SN007", 208.0, false);
        giNpcSetDir("SN008", 154.0, false);
        giWait(0.5);
        giNpcDoAction("SN007", "C08", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：是云公子，你来得正巧……", "");
        giWait(0.5);
        giTalk("钟伯：这位——", "");
        giNpcSetDir("SN007", 272.0, false);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：钟伯，他是我朋友，也是身怀异能之人，方便的话，能否让他一起见一见欧阳姑娘呢？", "");
        giTalk("钟伯：不妨事的，便请这位公子也进屋吧。", "");
        giNpcSetDir("SN007", 208.0, true);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：云公子，这家的小姐似乎生了很不寻常的病，我虽不懂医术，却也想略尽绵薄之力。云公子也一起来帮忙吧。", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：帮忙？好、好啊，可是要怎么帮？我也不会替人看病啊……", "");
        giWait(0.5);
        giNpcDoAction("SN007", "C09", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：或许……那根本不是病，我看了告示所言，心中已经有些计量，但总要见过欧阳小姐才知道自己猜的对不对……", "");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：好，那我们一起去见她，你要我怎么帮忙，尽管说就是！", "");
        giNpcDoAction("SN007", "C08", 1, true);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(0, false);
        giSetNpcVisible("SN007", false);
        giSetNpcVisible("SN008", false);
        npc_g = 1;
        giArenaLoad("Q04", "CN22", "", true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giSetNpcVisible("SN001", true);
        giSetNpcVisible("SN002", true);
        giNpcSetEmotion("SN001", "306_by");
        giNpcSetAng("SN002", 232.0);
        giPlayerSetPos(0, -101.2866, 1.0506, -45.218);
        giPlayerSetAng(0, 234.0);
        giPlayerSetPos(2, -151.8768, 1.0531, -55.231);
        giPlayerSetAng(2, 220.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(2, true);
        giArenaReady();
        giCameraPrepare("ming001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giTalk("钟伯：这便是我家小姐了……唉，她这样昏迷不醒也有九年了，各方名医看过都束手无策……奇怪的是，这么久了，小姐的容貌一点都不见老去……", "");
        giPlayerWalkTo(2, -153.7582, 1.0531, -93.5414, true);
        giPlayerSetDir(2, 198.0, true);
        giPlayerDoAction(2, "C07", -1, true);
        giSetObjectVisible("Jeffect002", true);
        gi2DSoundPlay("WE054", 1);
        giWait(1.2);
        giSetObjectVisible("Jeffect002", false);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：……！！", "41366; 42758; 43724");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：果然如我所想，她这样不是生病，而是睡着了，这些年来一直都在梦中……", "");
        giNpcSetDir("SN002", 266.0, true);
        giTalk("钟伯：睡着？可是，小姐怎么会一睡就是九年？！", "");
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：她是不是太累了，才睡那么久不醒？", "");
        giWait(0.6);
        giPlayerSetDir(2, 48.0, true);
        giWait(0.3);
        giPlayerDoAction(2, "C09", 1, false);
        giWait(0.5);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：她被人施了咒术，只要咒术不解，便会一直昏睡下去……", "");
        giNpcDoAction("SN002", "C09", 1, false);
        giTalk("钟伯：咒术！天啊，难道自从老爷暴毙，这个家就被妖魔缠上了？！为什么连小姐也……", "");
        giPlayerSetDir(2, 80.0, true);
        giTalk("钟伯：柳姑娘，既然你知道小姐是被人害的，请你一定要救救她！老朽求你了！", "");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：钟伯你莫要着急，我现在就施法进入她的梦中，看看究竟是怎样一回事。", "");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giTalk("钟伯：好，一切就托付给柳姑娘了……", "");
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：梦璃，你会不会有危险啊？", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(2, 60.0, true);
        giPlayerDoAction(2, "J13", 1, false);
        giWait(0.5);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：放心，我自有办法，不会有事的。", "");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101A", false);
        giTalk("云天河：好，我知道了。", "");
        giWait(0.5);
        giPlayerSetDir(2, 196.0, true);
        giWait(0.5);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：梦影雾花，尽是虚空，因心想念动，方化生幻境，令吾～往～梦～之～中！", "");
        giEffectAttachToPlayer(2, "H_TL03.2", false);
        giPlayerDoAction(2, "J12", 1, true);
        giEffectDetachFromPlayer(2);
        giFlashOutWhite(1.5, true, true);
        npc_g = 2;
        giArenaLoad("M13", "1", "", true);
    }
    if (npc_g == 5)
    {
        giPlayerLock();
        giScriptMusicPlay("P35", 0, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 2819.387, 1.4372, 2398.2676);
        giPlayerSetAng(0, 324.0);
        giPlayerSetPos(2, 2780.8286, 1.4372, 2393.1765);
        giPlayerSetAng(2, 358.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(2, true);
        giSetObjectVisible("title14", false);
        giIMMEnd();
        giNpcFaceToPlayer("SN008", 2, false);
        giCameraPrepare("ming002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：钟伯……", "");
        giTalk("钟伯：是柳小姐，还有云公子……", "");
        giWait(0.5);
        giNpcDoAction("SN008", "C09", 1, false);
        giTalk("钟伯：唉，这也是天意吧，让你们见我家小姐最后一面……大夫……大夫说小姐是神魂耗尽而亡……明日，她便要入土了……", "");
        giWait(0.5);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：……钟伯，我……我对不起你，救不了欧阳小姐……", "");
        giTalk("钟伯：此话怎讲，这真是折煞老朽了……欧阳家的命数啊，又怎能怪别人……", "");
        giPlayerDoAction(0, "C09", 1, false);
        giWait(0.6);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：我们……能见一见欧阳小姐吗？", "");
        giWait(0.5);
        giTalk("钟伯：当然，请随我进屋……", "");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        npc_g = 6;
        giArenaLoad("Q04", "CN22", "", true);
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giSetNpcVisible("SN001", true);
        giSetNpcVisible("SN002", true);
        giNpcSetEmotion("SN001", "306_by");
        giNpcSetPos("SN002", 67.1385, 1.039, -77.5312);
        giNpcSetAng("SN002", 302.0);
        giPlayerSetPos(0, -138.1663, 1.0506, -66.1964);
        giPlayerSetAng(0, 188.0);
        giPlayerSetPos(2, -163.7547, 1.0531, -87.0808);
        giPlayerSetAng(2, 188.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(2, true);
        giArenaReady();
        giNpcDoAction("SN001", "J04", 0, false);
        giCameraPrepare("ming002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giWait(1.0);
        giCameraRunSingle("002", true);
        giWait(2.0);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("003", true);
        giPlayerSetPos(0, 9.9037, 1.0441, -84.3937);
        giPlayerSetAng(0, 54.0);
        giPlayerSetPos(2, 14.6106, 1.0408, -40.3923);
        giPlayerSetAng(2, 130.0);
        giWait(1.5);
        giFlashInBlack(1.5, true);
        giWait(1.0);
        giTalk("钟伯：该打理的东西我都打理好了，明日便将小姐葬在欧阳家的祖坟，陪着老爷、夫人……", "");
        giSetPortrait("107F", true);
        giTalk("柳梦璃：……那，钟伯往后有何打算？", "");
        giWait(0.5);
        giNpcDoAction("SN002", "C09", 1, false);
        giTalk("钟伯：我侍奉欧阳家一辈子，如今连最后一位主人也不在了……再也没有其他牵挂，等小姐后事办妥，就要回乡下养老去了……", "");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：您要保重。", "");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giTalk("钟伯：一把老骨头了，怎么过还不都一样……唉，我这辈子最大的遗憾，就是没能看到小姐披上嫁衣，她那么善良的一个姑娘，连新娘子都没做过，就这样去了……老天、老天真是无眼呐……", "");
        giCameraRunSingle("004", false);
        giWait(0.5);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：……钟伯，您莫要伤心过度，坏了身体……", "");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giCameraRunSingle("006", false);
        giWait(0.8);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：……", "41250; 41592; 41824; 41879; 41939; 42103; 42309; 42571; 42820; 46024; 46044; 46111; 46119");
        giWait(0.5);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：我想……在那个奇异的梦里，欧阳小姐她……一定做过世上最美的新娘子……", "");
        giCameraWait();
        giFlashOutBlack(2.0, true, true);
        giSetNpcVisible("SN001", false);
        giSetNpcVisible("SN002", false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(2, false);
        giArenaLoad("Q04", "Q04C", "", true);
        giSetNpcVisible("SN009", true);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(2824.6106, -1.6067, 2091.7114);
        giPlayerCurrentSetAng(178.0);
        giCameraSetMode(0, true);
        giArenaReady();
        npc_g = 7;
        giSetObjectVisible("title14", false);
        giFlashInBlack(1.5, true);
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
    }
    if (global_mvar < 100200 && global_mvar >= 91300 && npc_g == 5 /* 第二章 / 6-3-4.义结金兰 / 炎帝神农洞 */)
    {
        giPlayerLock();
        giPlayerCurrentWalkTo(2814.6106, -1.6067, 2141.7114, true);
        giPlayerCurrentSetAng(178.0);
        giSetPortrait("102A", true);
        giTalk("云天河：下回叫上梦璃，再来这里看钟伯吧。", "");
        giCameraSetMode(0, true);
        giPlayerUnLock();
    }
}

void func3005()
{
    if (npc_g == 3)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giSetNpcVisible("SN001", true);
        giSetNpcVisible("SN002", true);
        giNpcSetEmotion("SN001", "306_by");
        giNpcSetAng("SN002", 266.0);
        giPlayerSetPos(0, -101.2866, 1.0506, -45.218);
        giPlayerSetAng(0, 234.0);
        giPlayerSetPos(2, -153.7582, 1.0531, -93.5414);
        giPlayerSetAng(2, 196.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(2, true);
        giArenaReady();
        giCameraPrepare("ming001");
        giCameraRunSingle("001", true);
        giFlashInWhite(0.5, true);
        giSetObjectVisible("Jeffect001", true);
        giWait(6.5);
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giTalk("柳梦璃：啊！——", "");
        giSetObjectVisible("Jeffect001", false);
        giWait(0.5);
        giCGEffStop();
        giSetPortrait("101H", false);
        giTalk("云天河：梦璃，你怎么了？！", "");
        giWait(0.5);
        giPlayerSetDir(2, 34.0, false);
        giCameraRunSingle("002", false);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：……没事，只不过一时不慎，被法术弹出了梦境……", "");
        giWait(0.3);
        giTalk("钟伯：小姐、小姐她到底怎么样？", "");
        giWait(0.3);
        giPlayerSetDir(2, 86.0, true);
        giWait(0.5);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：我见到了她，可是她好像只记得梦中的事，那个咒术太过强大，她的意识几乎被吞噬了……", "");
        giTalk("钟伯：那还有没有办法救我家小姐？", "");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……很难。", "");
        giCameraRunSingle("002", false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：让一个人沉睡九年，在梦中度日，如此霸道的咒术必定要布下法阵，若是不知对方在何处布阵，根本无从破解……", "");
        giTalk("钟伯：也就是说，小姐还是只能继续这样睡下去……", "");
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：对不起……钟伯，我什么忙也没帮上……", "");
        giWait(0.5);
        giNpcDoAction("SN002", "C09", 1, false);
        giTalk("钟伯：不不不，柳姑娘，你千万别这么说，要不是你，我还一直以为小姐是生了病，连她被人害了都不知道……", "");
        giWait(0.5);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：钟伯，恕我冒昧，请问欧阳家是不是曾经与人结仇？而且并非中原人？还有，您说过欧阳小姐的父亲，乃是暴毙而亡，这究竟是怎么回事？", "");
        giWait(0.5);
        giPlayerSetDir(0, 178.0, true);
        giTalk("钟伯：这……老爷他是很本份的商人，做买卖五湖四海都要跑的，生意场上难免得罪了谁，可是也不至于有什么血海深仇吧……", "");
        giWait(0.5);
        giNpcDoAction("SN002", "C09", 1, false);
        giTalk("钟伯：……说到老爷过世，那真是天塌了一般……九年前的一个夜里，是小姐先发现了老爷的尸首……那简直、简直惨不忍睹……老爷的整个身体上都爬满了毒虫，被咬得面目全非……", "");
        giSetPortrait("106E", true);
        giTalk("柳梦璃：……！", "41895; 44194; 46150");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：……真是太可怜了，比我爹还要惨多了……", "");
        giWait(0.5);
        giTalk("钟伯：从那时起，小姐就好像神魂出窍了一样，不吃不喝、也完全不说话……没过几日，突然昏睡过去，再也没有醒来……夫人的身子本来就不太好，她伤心欲绝，没过半年便跟着老爷去了……", "");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：钟伯，我觉得你家老爷的过世、还有小姐昏睡，这之间绝对不会毫无关系……", "");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：如今我虽救不了欧阳姑娘，但若是有朝一日，见到那个法阵，我一定能认出来，到时候无论如何都要破阵，救醒欧阳姑娘。", "");
        giTalk("钟伯：大恩大德，老朽先在这里谢过了……唉，事到如今，也只能听天由命……", "");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：钟伯你自己也要保重，不然还有谁能照顾欧阳小姐……我想一定天无绝人之路的……", "");
        giPlayerEndAction(2);
        giPlayerSetDir(2, 210.0, true);
        giCameraRunSingle("003", true);
        giCameraRunSingle("004", false);
        giWait(2.0);
        giFlashOutBlack(2.0, true, false);
        giWait(2.0);
        giCameraRunSingle("001", true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        npc_g = 4;
        giArenaLoad("Q04", "Q04C", "", true);
        giPlayerCurrentSetPos(2814.6064, 1.437197, 2507.9807);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(0, true);
        giArenaReady();
        giAddPlayerFavor(0, 2, 30);
        giFlashInBlack(1.5, true);
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
    }
}

void func3006()
{
    giPlayerLock();
    giNpcFaceToCurrentPlayer("SN002", true);
    giCurrentPlayerFaceToNpc("SN002", true);
    giRandTalkRelease();
    giRandTalkPush("钟伯：柳姑娘，还有云公子，老朽在这里先谢过了！");
    giRandTalkPush("钟伯：老爷夫人双双辞世，小姐又长睡不醒，上天怎能如此对待好人呐！");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("SN002");
    giPlayerUnLock();
}

void func3007()
{
    giPlayerLock();
    giNpcFaceToCurrentPlayer("SN009", true);
    giCurrentPlayerFaceToNpc("SN009", true);
    giRandTalkRelease();
    giRandTalkPush("陈妈：钟老先生侍奉欧阳家一辈子，现今欧阳家最后一口人也去了，钟老先生也算尽了人事了。");
    giRandTalkPush("陈妈：欧阳一家实在太可怜了……管家钟伯也回乡养老了，大家都说这宅子戾气太重，住不得人。");
    giRandTalk();
    giRandTalkRelease();
    giNpcResetDir("SN009");
    giPlayerUnLock();
}

void func3008()
{
    if (var_zhu == 1)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 7.7284, 0.7228, 105.4453);
        giPlayerSetAng(0, 126.0);
        giPlayerSetPos(1, 73.0266, 0.7228, 66.4865);
        giPlayerSetAng(1, 160.0);
        giPlayerSetPos(3, 96.0309, 14.0085, -202.066);
        giPlayerSetAng(3, 92.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("SN001", true);
        giSetNpcVisible("4028", false);
        giSetNpcVisible("4029", false);
        giSetNpcVisible("4078", false);
        giSetNpcVisible("4068", false);
        giSetObjectVisible("SO001", true);
        giSetObjectVisible("SO002", true);
        giSetObjectVisible("SO003", true);
        giSetObjectVisible("SO004", true);
        giSetObjectVisible("SO005", true);
        giSetObjectVisible("SO006", true);
        giIMMEnd();
        giCameraPrepare("yan002");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giPlayerDoAction(3, "C10", 0, false);
        giWait(2.5);
        giCameraRunSingle("002", true);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：菱纱～", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.30000001192092896);
        giPlayerSetDir(1, 316.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104J", false);
        giTalk("韩菱纱：嘘！小点儿声～～紫英这家伙，终于被我看到了不得的事，他居然和一位漂亮大姐在酒坊见面，还出钱请对方喝酒耶～", "");
        giPlayerEndAction(1);
        giWait(0.30000001192092896);
        giPlayerSetDir(1, 160.0, true);
        giSetPortrait("102D", true);
        giTalk("云天河：那是……？", "");
        giCameraRunSingle("004", true);
        giWait(1.0);
        giTalk("夙莘：哈哈～真是好酒！可惜一壶太少了，喝着总觉得不过瘾，能不能让她们上大坛子的那种？", "");
        giCameraRunSingle("005", false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：师叔，饮酒伤身——", "");
        giTalk("夙莘：哎，我记得你才十八、不、十九岁，又不是六十九岁，怎会如此婆妈？还是小时候可爱些，会追在我后面要糖吃——", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：夙莘师叔，弟子冒昧！请问师叔何时可以启程，与我返回昆仑山？掌门一直很是记挂于您。", "");
        giTalk("夙莘：哟～小紫英，你脸红了，难不成听到自己以前的事，还会不好意思～", "");
        giSetPortrait("104B", true);
        giTalk("韩菱纱：嘻嘻！", "");
        giIMMBegin();
        giPlayerSetPos(1, 109.1178, 0.7228, -31.2398);
        giPlayerSetAng(1, 202.0);
        giPlayerSetPos(0, 63.955, 0.7228, -2.414);
        giPlayerSetAng(0, 158.0);
        giIMMEnd();
        giWait(0.5);
        giCameraRunSingle("006", true);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：菱纱？！", "");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：呃，糟糕……听到有人也会叫“小紫英”，不小心笑出来了……", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerDoAction(3, "C01", 0, false);
        giNpcDoAction("SN001", "C01", 0, false);
        giPlayerSetPos(3, 144.8216, 0.7229, -107.2306);
        giPlayerSetAng(3, 352.0);
        giNpcSetPos("SN001", 146.9341, 11.9593, -144.7367);
        giIMMEnd();
        giNpcWalkTo("SN001", 95.0487, 0.7228, -91.4805, true);
        giNpcSetAng("SN001", 25.0);
        giWait(0.5);
        giTalk("夙莘：你们是……？", "");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("007", false);
        giPlayerSetAng(3, 300.0);
        giIMMEnd();
        giCameraWait();
        giWait(0.30000001192092896);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：他们乃是……弟子的师侄，初入门派，不太懂规矩，以至冒犯师叔……", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcSetDir("SN001", 101.0, true);
        giWait(0.5);
        giNpcDoAction("SN001", "C09", 1, false);
        giTalk("夙莘：好了好了，随口问问罢了，何必一本正经的～", "");
        giNpcEndAction("SN001", true);
        giNpcSetDir("SN001", 25.0, true);
        giWait(0.5);
        giTalk("夙莘：你们是下山办事来的？跟着这种一板一眼的师叔，日子想必不太好过吧～", "");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：不会啦，其实小紫英人很好的，又爱操心又常常害羞，平日里只是顶着一张冰块脸骗人～", "");
        giPlayerEndAction(1);
        giPlayerSetDir(3, 342.0, true);
        giWait(0.20000000298023224);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：菱纱，休要胡言乱语！", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giTalk("夙莘：…………哈哈……哈哈哈！想不到、真想不到，你这小姑娘有点意思，来来来，陪大姐我喝上两杯！", "");
        giWait(0.20000000298023224);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：我、我不喝酒的——", "");
        giPlayerEndAction(1);
        giSetNpcVisible("SN002", true);
        giNpcWalkTo("SN002", 23.2218, 0.7228, -49.4814, false);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(0, 105.0562, 0.7228, -18.3077);
        giPlayerSetAng(0, 228.0);
        giPlayerSetPos(1, 124.0994, 0.7228, -50.0341);
        giPlayerSetAng(1, 268.0);
        giPlayerSetPos(3, 129.6605, 0.7229, -98.872);
        giPlayerSetAng(3, 322.0);
        giNpcSetPos("SN001", 75.4964, 0.7228, -74.2322);
        giNpcSetAng("SN001", 317.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giNpcEndMove("SN002");
        giNpcSetAng("SN002", 142.0);
        giWait(0.20000000298023224);
        giTalk("夙莘：冷毅，你跑哪里去了～这么久不见人影，害我一个人喝酒，旁边这个师侄实在太正经，连个笑话都不会讲……", "");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：哇～大姐，这个人好高大，他是你相公吗？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：菱纱！", "44681; 45692");
        giNpcSetDir("SN001", 76.0, true);
        giWait(0.30000001192092896);
        giTalk("夙莘：相公？哈哈～也差不多啦。", "");
        giWait(0.8999999761581421);
        giNpcSetDir("SN001", 317.0, true);
        giTalk("夙莘：什么？！你说碗丘山有野兽伤人？快走！我们去看看！", "");
        giWait(0.30000001192092896);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：师叔，弟子与您同去！", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giTalk("夙莘：那就来吧。", "");
        giWait(0.699999988079071);
        giNpcWalkTo("SN002", -14.1778, 0.7228, 131.9954, false);
        giWait(0.30000001192092896);
        giNpcWalkTo("SN001", -14.1778, 0.7228, 131.9954, false);
        giPlayerWalkTo(3, -70.0499, 0.7228, 91.2631, false);
        giWait(2.5);
        giPlayerSetDir(0, 314.0, false);
        giPlayerSetDir(1, 334.0, false);
        giCameraRunSingle("009", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：那个人……和那女的说话了吗？我怎么没听到声音，难道又是什么“传音入密”？", "");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：呆子，这种事情等一下再想！<colour red=255 green=187 blue=0 alpha=255>我们也快点赶去碗丘山，</colour><dc0>看能不能帮上忙！</dc0>", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(0, 132.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：哦、好……反正我还要找那女的要会动的木头老鼠……", "");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetPos(0, 48.8495, 0.7228, -14.0708);
        giPlayerSetAng(0, 0.0);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("SN001", false);
        giSetNpcVisible("SN002", false);
        var_zhu = 2;
        giIMMEnd();
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(2, true);
        giFlashInBlack(1.0, true);
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("陈靖风：这些驯象人在我们陈州待了大半年，眼看着就快要走了，我也觉得有些舍不得，不过新的杂耍班子应该很快就来了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("陈靖风：那日琴姬在弦歌台弹唱，那曲子到现在还在我耳边回响，只是之后就再也没有见过她了，可叹呐……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("陈靖风：陈州就是春秋时期的陈国，当年陈国的王是以国为姓，称为陈胡公，陈胡公便是我们陈姓人的始祖了。");
        giRandTalkPush("陈靖风：前面的杂耍台好像是一群外地人搭起来的，他们来陈州一个多月了，台上的表演天天都有新花样～");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("钱婆婆：以前的秦家也不知道搬去哪里了，一家人整天愁眉苦脸，也怪可怜的，钱再多又有什么用啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("钱婆婆：天呐！千佛塔里死了人，听说还是陈州大户人家的媳妇，那家人也真够可怜的，儿子媳妇都已经不在了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("钱婆婆：儿子前几天刚把我接来陈州，今天一大早就又出门办货去了。他跟我说什么酒坊在湖西，布庄在湖东，医馆在湖的东南边，让我四处逛逛，可这陈州这么大，我哪走得过来啊？");
        giRandTalkPush("钱婆婆：杂货铺我认识，就在我家隔壁不远处，可是那儿的东西太贵了，一团粗线就要十文钱，这不是坑人嘛！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4002");
    giNpcResumeBeh("4002");
    giPlayerUnLock();
}

void func4003()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4003");
    giNpcFaceToCurrentPlayer("4003", true);
    giCurrentPlayerFaceToNpc("4003", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("方琦：安溪的商人又来过了，这回带了银镯子来，还嵌着珍珠！阿娘花大价钱买了那镯子，却说是要给哥哥娶媳妇时当聘礼，不能给我戴……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("方琦：唉，想想那秦家少夫人，嫁过去也没多久，到底为什么会在千佛塔里自尽……真是好可怜……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4004", true);
            giTalk("方琦：璎珞斋里有西域的银镯子、京城的翡翠簪，每一件都好看得不得了！只可惜太贵了……", "");
        }
        else
        {
            giNpcFaceToNpc("4004", "4005", true);
            giNpcFaceToNpc("4005", "4004", true);
            giTalk("方琦：上一次，我在璎珞斋里看见两支珍珠簪，那簪头上的珍珠又大又圆，可漂亮呢！听老板娘说那是跟一个安溪来的茶叶商买的，一共也才两支。", "");
            giTalk("方琦：后来这两支簪子，我看到秦家的媳妇戴了一支，另外一支就在倚栏歌榭的玉芙蓉身上。", "");
        }
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("伏纳：我们差不多要离开陈州了，接下来会坐船沿着淮河走，女娲娘娘保佑～如果找到合适的地方，就再待上几个月。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("伏纳：我们兄弟俩跟着这个杂耍团很久了，女娲娘娘保佑～团里的生意一直都不错。");
        giRandTalkPush("伏纳：想看杂耍表演吗？戏台就在路对面呐，不过今天还没开场，得再等等。");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("伏辞：在这里待得够久了，过几天我们就启程，到城外找几条大船，把东西都搬上去就走。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("伏辞：城里好像有个叫琴姬的女人，唱歌好听，团里其他人都很想跟着她学。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("伏辞：我们的家乡在离这里很远很远的南边，家乡的大海，比陈州的龙湖大的多！");
        giRandTalkPush("伏辞：从西南到中原，这一路上走过的城镇也不少，但没有哪儿比陈州更繁华了，这里不单是人多，连店里卖的东西也比别处多。");
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
    giNpcPauseBeh("4006");
    giNpcFaceToCurrentPlayer("4006", true);
    giCurrentPlayerFaceToNpc("4006", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("张小燕：跟大象在一起的大哥哥说，他们就要离开陈州了，那样的话我以后就再也看不到大象了，怎么办？呜呜呜……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("张小燕：大哥哥，昨天晚上，你听见有人唱歌了吗？我一直睡不着，就听见一个声音很好听的仙女在唱歌～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("张小燕：我要看大象～我要看大象～");
        giRandTalkPush("张小燕：娘说大象住的地方又臭又脏，不许我来，嘻嘻，我跑出来不告诉娘就好了！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4006");
    giNpcResumeBeh("4006");
    giPlayerUnLock();
}

void func4007()
{
    giPlayerLock();
    giNpcPauseBeh("4007");
    giNpcFaceToCurrentPlayer("4007", true);
    giCurrentPlayerFaceToNpc("4007", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("许碧依：听爹说，在南方的苗寨里有女娲娘娘庙，可女娲娘娘不是在我们陈州造的人吗？为什么苗寨里才有供奉她的庙呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("许碧依：除了女娲娘娘，连天神伏羲都在陈州待过呢，听说他还创了一个先天八卦阵，我们凡人想都想不到那有多厉害～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("许碧依：人都是很久很久以前，女娲娘娘用泥巴捏出来的，你知道她是在什么地方捏的吗？没错啦，就是陈州！");
        giRandTalkPush("许碧依：湖上的弦歌台人比平时多些，是不是那个人又在那里唱歌呢？……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4007");
    giNpcResumeBeh("4007");
    giPlayerUnLock();
}

void func4008()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4008");
    giCurrentPlayerFaceToNpc("4008", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToNpc("4008", "4009", true);
        giNpcFaceToNpc("4009", "4008", true);
        giTalk("沈倩：桑克颉，上次的那串大红珠子，什么时候再有卖啊？ ", "");
        giTalk("桑克颉：哈哈，那得等我回一趟家，才能把货给带来。 ", "");
        giTalk("沈倩：那你什么时候回家？什么时候能再来呢？", "");
        giTalk("桑克颉：唉，昆仑山脚下离这里很远很远，我的年纪也不小了，这次回家乡，大概不会再出远门了……", "");
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4008", true);
            giTalk("沈倩：这摊子上的小玩意儿是璎珞斋里都没见过的呢！好多好看的银簪子呀，还有那条红珠子项链，到底买哪件好？", "");
        }
        else
        {
            giNpcFaceToNpc("4008", "4009", true);
            giNpcFaceToNpc("4009", "4008", true);
            giTalk("沈倩：桑克颉，你说你的家乡养了很多骆驼，那你一定是住在西边的沙漠里啰？", "");
            giTalk("桑克颉：呵呵，我的家乡离沙漠很近，在昆仑山脚下，那山上住了仙人，我家就是靠着山上流下来的河水，才没有变成沙漠。", "");
        }
    }
    giNpcResetDir("4008");
    giNpcResetDir("4009");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("桑克颉：中原再好，毕竟不是自己的家。出门两三年，也是该回去了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("桑克颉：我来到这儿以后，最喜欢听琴姬弹琴，她一弹，我就想起了家乡……可惜以后再也听不到了，听说她离开了陈州……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("桑克颉：在西域的时候，我还以为我们镇是天底下最热闹的地方，到了中原才知道，那样根本算不上什么～");
        giRandTalkPush("桑克颉：我们家乡的那条河，河水都不过膝，卷起裤角走过去就行了，哪像这陈州，去趟湖心岛还得到城西的码头去坐船。");
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
        giRandTalkPush("朱荷莲：城里的杂耍班子就要走了，我家小燕看起来很舍不得，害我也不忍心说她。罢了，这几天就让她多看几眼大象吧。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("朱荷莲：秦家是不是撞了邪啊，儿子没死多久，媳妇又在千佛塔里自尽了，我看他们家最好请个道士来做法，不然以后可怎么办……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("朱荷莲：你看见我家小燕了吗？我不过是去酒坊打了些酒，回家就不见她人影！八成又跑去看大象，真是太不听话了，那种动物脏脏的，有什么好看！");
        giRandTalkPush("朱荷莲：城里来了杂耍班子，听说还是从西蜀来的，带着大象，我女儿天天都要去摸大象，管也管不住！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4010");
    giNpcResumeBeh("4010");
    giPlayerUnLock();
}

void func4011()
{
    giPlayerLock();
    giNpcPauseBeh("4011");
    giNpcFaceToCurrentPlayer("4011", true);
    giCurrentPlayerFaceToNpc("4011", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("余笑才：秦家的房子也卖了，人也都迁走了，新搬来的那户人家，儿子常年在外经商，只有老爷夫人住在那撞邪的宅子里，这……恐怕不妥吧？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("余笑才：千佛塔里闹出了人命，庙里的僧人说圣物染了秽气，要过些日子才能散，让我家娘子把塔中供奉的爹娘牌位先请回家一段日子，娘子好像不是很愿意……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("余笑才：娘子坐船去湖心岛的庙里拜佛了，我本想和她一起去，可是我见船就晕，只能在渡口这儿等她回来。");
        giRandTalkPush("余笑才：我娘子除了日日到庙里进香之外，还经常朝湖心岛方向合十念佛，求千佛塔上的圣物舍利保佑全家。");
        giRandTalk();
        giRandTalkRelease();
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("武元甸：知府大人的公子每天晚上都在倚栏歌榭听玉芙蓉唱歌，我倒是觉得，那玉芙蓉漂亮是挺漂亮，歌唱得却实在不怎么样。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("武元甸：死在塔里的姜氏，好像是秦家的媳妇，可秦家少爷死了有些日子了，她要跟着相公去，干嘛等到现在呢？何况年纪轻轻的，怎会这么想不开……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("武元甸：近来四海升平，年年五谷丰登，陈州附近从来没有闹过饥荒，粮仓里的储粮，足够供整个城里的百姓吃上三年的！");
        giRandTalkPush("武元甸：都说湖心佛塔里供着舍利子，晚上还有武艺高强的僧人负责把守，也不晓得是不是真的。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4012");
    giNpcResumeBeh("4012");
    giPlayerUnLock();
}

void func4015()
{
    giPlayerLock();
    giNpcPauseBeh("4015");
    giNpcFaceToCurrentPlayer("4015", true);
    giCurrentPlayerFaceToNpc("4015", true);
    if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("陈丹：这些姑娘唱的歌就是好听，老听歌榭里的小调，我都快听腻了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("陈丹：这些女子个个浓眉大眼，头上还戴着珠贝～她们唱的歌、跳的舞，和中原姑娘完全不一样～");
        giRandTalkPush("陈丹：刚才出门的时候，我听见弦歌台上传来一阵琴声，实在好听，不过我更喜欢来这儿看杂耍……鱼和熊掌不可兼得啊。");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("恭丽霞：前几个月我来过一趟陈州，就迷上了杂耍班的表演，谁料到这回再来，他们已经打算迁去别处了，那我以后要去哪儿看呐？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("恭丽霞：其实台上姑娘在唱些什么，我一点都听不懂，可就是觉得好听～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("恭丽霞：我第一次来陈州，没想到就看见这西蜀来的杂耍班，还带着大象，真新鲜！");
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
    if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("肖庆：我在大理城也见过大象，只是那儿的大象可不会杂耍～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("肖庆：昨天我一进城就看见两头大象在街上走，开始还以为在做梦，梦见了大理城呢！后来才知道，大象是杂耍班子带来的～");
        giRandTalkPush("肖庆：传说女娲娘娘造人的地方，就是这陈州，怎么这儿却连座女娲庙都没有？");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("阿升：倚栏歌榭里玉芙蓉唱的曲子，都是一个杨姓书生填的词，那书生词是写得不错，只可惜玉芙蓉唱得就……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("阿升：千佛塔……那里不是佛门圣地吗？怎会有人死在里面？想想都觉得可怕……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("阿升：客官您是第一次来陈州？要不要尝尝“圣人菜”？“圣人菜”就是当年孔圣人在弦歌台绝粮时吃的东西。");
        giRandTalkPush("阿升：我们客栈里，除了南来北往的商贾旅人，还常常有和尚来，那些和尚都是来参拜千佛塔上的舍利子的，得专门给他们做斋菜。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4018");
    giNpcResumeBeh("4018");
    giPlayerUnLock();
}

void func4019()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4019", true);
    giNpcFaceToCurrentPlayer("4019", true);
    if (var_shop035 != 1)
    {
        if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
        {
            giRandTalkRelease();
            giRandTalkPush("云遥庆：最近的茶叶卖得特别好，除了能天天去倚栏歌榭听玉芙蓉的曲儿，还能买些首饰捎回去，让家里的娘子也高兴高兴，这就是齐人之福啊，哈哈！");
            giRandTalk();
            giRandTalkRelease();
        }
        else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
        {
            giTalk("云遥庆：玉芙蓉的舞，实在是跳得好，可惜这倚栏歌榭的酒钱太贵，我卖茶叶的钱都已经快花光了，回家怎么跟娘子交代……", "");
        }
        else if (global_mvar >= 50300 /* 第一章 / 3-3-2.弦歌问情 / 客栈休息 */)
        {
            giTalk("云遥庆：玉芙蓉的舞，实在是跳得好，可惜这倚栏歌榭的酒钱太贵，我卖茶叶的钱都已经快花光了，回家怎么跟娘子交代……", "");
        }
        else
        {
            giRandTalkRelease();
            giRandTalkPush("云遥庆：玉芙蓉不愧是倚栏歌榭的花魁～唱的曲儿好听，跳的舞更是能赶上那赵飞燕！");
            giRandTalk();
            giRandTalkRelease();
        }
    }
    else
    {
        giTalk("云遥庆：我也知道自己对不起娘子，可是那倚栏歌榭的玉芙蓉实在太迷人，上回卖茶叶的钱，都在歌榭花完啦！", "");
        giTalk("云遥庆：不过，最近茶叶的价格忽然涨了，<colour red=255 green=187 blue=0 alpha=255>麻烦你回去告诉我娘子</colour><dc0>，再做一笔大买卖，我就立即动身回村！</dc0>", "");
        var_shop035 = 2;
    }
    giNpcResetDir("4019");
    giNpcResumeBeh("4019");
    giPlayerUnLock();
}

void func4020()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4020", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("张玉太：千斗酒坊的赛乃慕小姐看起来好像对我有意思，可我中意的是歌榭里的月桂啊……");
        giRandTalkPush("张玉太：去年在金陵城外的玄武湖畔和林少侠一战，我虽负于林少侠半招，但那次比武真是痛快至极、痛快至极啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51300)
    {
        giTalk("张玉太：我师父说过，三十年前，有一位名满江湖的铁琴女侠，练就一身好武艺不算，还弹得一手好琴，我猜那琴姬就是这位铁琴女侠的后辈弟子！", "");
    }
    else if (global_mvar < 50300 || var_shop012 != 0 /* 第一章 / 3-3-2.弦歌问情 / 客栈休息 */)
    {
        giRandTalkRelease();
        giRandTalkPush("张玉太：其实千佛塔上守舍利的武僧也没什么了不起，只要是单打独斗，他们没一个能赢得了我手中这柄宝剑！");
        giRandTalkPush("张玉太：骆家公子年纪虽小，于剑术上却很有天赋。上次我见他在湖边舞剑，已隐有大家之风，再过几年，他的剑术，恐怕会在我之上。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giFlashOutBlack(1.0, true, true);
        giPlayerSetPos(0, 98.9698, 1.491, -32.3463);
        giPlayerSetAng(0, 106.0);
        giCameraPrepare("NPC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, true);
        giTalk("张玉太：哈哈，这不就是“神刀铁胳臂”胡得朔胡大侠嘛？好久不见～", "");
        giTalk("胡得朔：哈哈，原来是“清风剑”张玉太张大侠啊～幸会、幸会～～", "");
        giTalk("张玉太：却不知胡大侠此来陈州，所为何事？", "");
        giTalk("胡得朔：这个嘛～我听说陈州千佛塔上，那守护舍利的僧人，个个都武艺高强！所以我想去和他们切磋一番。", "");
        giTalk("张玉太：这好办，我跟寺里的方丈也有些交情，我们现在就渡船去湖心岛，只要方丈师父点头，胡大侠你想跟谁切磋就跟谁切磋！", "");
        giTalk("胡得朔：啊？！这～这这这～～我突然想起来还有别的事要办，先告辞了！这以武会友之事，反正来日方长，还是改天再说吧……", "");
        giIMMBegin();
        giNpcSetAng("4020", 310.0);
        giNpcWalkTo("4021", 163.2942, 0.724, 46.4173, false);
        giCameraRunSingle("002", false);
        giIMMEnd();
        giTalk("张玉太：胡大侠？", "");
        giWait(1.5);
        giPlayerSetDir(0, 70.0, true);
        giFlashOutBlack(1.0, true, true);
        giNpcEndMove("4021");
        giSetNpcVisible("4021", false);
        var_shop012 = 1;
        giFlushTailYAngle();
        giCameraAutoSeek(true);
        giCameraSetMode(2, true);
        giFlashInBlack(1.0, true);
        giPlayerUnLock();
    }
    giPlayerUnLock();
}

void func4021()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4021", true);
    giRandTalkRelease();
    giRandTalkPush("胡得朔：听说千佛塔上的舍利子一到夜里就会闪闪发亮，绝对是件值钱的宝贝！要是能把它偷过来，那可就发啦～哈哈哈哈！");
    giRandTalk();
    giRandTalkRelease();
    giPlayerUnLock();
}

void func4022()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4022", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("陆寿：要不是我带来的寿阳香料卖得好，我可住不起这么贵的客栈！可惜八公山上的离香草再也不能多采，以后也就没香料卖了，唉……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("陆寿：升平客栈的菜是好，房间睡得也舒坦，就是价钱贵！别的不说，单一碗豆腐汤，寿阳只卖三文钱，这里竟然要六文！");
        giRandTalkPush("陆寿：不去倚栏歌榭，那真是枉来陈州了！只是那里的酒水钱实在太贵，我、我怕是还要攒上一段日子……");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4023()
{
    giPlayerLock();
    giNpcPauseBeh("4023");
    giNpcFaceToCurrentPlayer("4023", true);
    giCurrentPlayerFaceToNpc("4023", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("曾福达：秦家老爷和夫人在我这儿存了一大笔银子，然后就搬出了陈州，想必他们一定是怕身上带太多现银出门不方便，才都换成了银票。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("曾福达：说起那个琴姬，我倒还有点印象，秦家少爷在世的时候，他俩经常泛舟龙湖，一个弹琴、一个吹萧，看起来真像是神仙眷侣啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("曾福达：宝气钱庄在淮水以北所有的大城里都有分号，我这儿开的银票，到京城里都能兑现银！");
        giRandTalkPush("曾福达：客官您要是手头紧，我们钱庄也可以借银两给您。不过这事儿空口无凭可不行，至少您得拿些房屋地契来押着，没有地契，值钱的金玉首饰也行啊～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4023");
    giNpcResumeBeh("4023");
    giPlayerUnLock();
}

void func4024()
{
    giPlayerLock();
    giNpcPauseBeh("4024");
    giNpcFaceToCurrentPlayer("4024", true);
    giCurrentPlayerFaceToNpc("4024", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("陈婆婆：要不要买几只泥泥狗？它能保佑你没病没灾，长命百岁！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("陈婆婆：年轻人，你可别小看我摊上这泥泥狗，它是当年女娲娘娘造人时传下来的模子，还有这人面猴，也跟当年女娲娘娘造的一个样～");
        giRandTalkPush("陈婆婆：泥泥狗就是泥娃娃，只有咱们陈州人才这么叫～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4024");
    giNpcResumeBeh("4024");
    giPlayerUnLock();
}

void func4025()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4025");
    giNpcFaceToCurrentPlayer("4025", true);
    giCurrentPlayerFaceToNpc("4025", true);
    if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("郭小明：我知道的！琴姬姐姐是很好的人，还有秦大哥也是，以前娘生过几次重病，都是他们送药给我家。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giTalk("郭小明：湖里的塔上真的有宝贝吗？我想要～～", "");
        }
        else
        {
            giTalk("郭小明：“老斋公，你别走，给个泥泥狗，活到九十九”。", "");
            giTalk("郭小明：哥哥姐姐在陈婆婆这里买了泥泥狗，都会送给我玩呢！", "");
        }
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
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("洪九：秦家从陈州搬走了，新住进来的那户人家，夫人好像是吃斋的，每天早上都要去庙里，路过我这儿时，总会给几个钱，倒也不错～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("洪九：原来昨天就是那个琴姬在弦歌台上唱曲子，所以才引了一堆人围着，这也难怪，她唱的曲子，实在是太好听了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("洪九：陈州好哇，人多又热闹～我在寿阳要饭的时候，每天要来的也只够填肚子，哪像现在，在街口坐上一整天，除了能吃饱吃好，还有多下来的钱买酒！");
        giRandTalk();
        giRandTalkRelease();
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
        giRandTalkPush("赛乃慕：倚栏歌榭里的女儿红竟然卖那么贵？！那我这酒肆里，如果能请来我的姐妹跳舞，葡萄酒不是可以卖三十两银子一壶了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("赛乃慕：楼上的两位公子总喜欢谈论一个叫琴姬的女人，说她弹的曲子好听，有机会让我的姐妹和她比一比！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("赛乃慕：我们千斗酒坊不止有上好的女儿红，还有高昌的葡萄酒、波斯的三勒浆和龙膏酒，客官您想来点什么？");
        giRandTalkPush("赛乃慕：知府家的公子现在就在楼上，他经常和朋友来我们酒坊，一坐就是一下午，要的也常常是龙膏酒、三勒浆，从来不喝女儿红。");
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
    giCurrentPlayerFaceToNpc("4028", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("公孙异：我每次和苏兄一起去歌榭时，那玉芙蓉总会多看我几眼，可她也只是看，从来没有别的表示，真让人捉摸不透……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("公孙异：我这几日正在钻研乐理，古乐多是“清乐”，歌榭里那些曲子是“燕乐”，两者各有千秋，本就做不得比较。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 50400 /* 第一章 / 3-3-3.弦歌问情 / 夜入千佛塔 */)
    {
        giTalk("公孙异：苏兄啊，那玉芙蓉的眼神，怎么老往我们这儿飘？", "");
        giTalk("苏俊青：玉芙蓉向来眼高于顶，我来这倚栏歌榭也好多次了，她对我一直都是不冷不热的，看今日这情形，也许是她是看上公孙兄你了也说不定！", "");
        giTalk("公孙异：哈哈哈哈，苏兄你尽会说笑～", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("公孙异：苏公子总说陈州的花魁玉芙蓉如何如何～害我从京城一路赶来，今夜怎么也要见识见识！");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4029()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4029", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("苏俊青：最近什么事也提不起劲来，爹让我好好念书，求个功名，可那些书……我哪里看得进去啊，光是念上几句就想打瞌睡了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("苏俊青：听说陈州另有一位弹唱俱佳的姑娘，叫作琴姬，为何我与她有缘无份，她早早地就离开了这儿……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 50400 /* 第一章 / 3-3-3.弦歌问情 / 夜入千佛塔 */)
    {
        giRandTalkPush("苏俊青：今日这玉芙蓉好奇怪，怎么老是看着我们这边，脸上的笑也有点怪……难道她真的对公孙兄一见倾心了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("苏俊青：公孙兄，今日你远道而来，小弟也没什么好招待的。除了这家酒坊的葡萄酒不能不喝之外，倚栏歌榭的舞，也是不能不看呐！");
        giRandTalk();
        giRandTalkRelease();
    }
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
        giRandTalkPush("张铁口：搬进秦家大宅的那一家我见过，老爷夫人都是福泽深厚的面相，也只有那种人，才能在那房子住得久。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("张铁口：死在塔里的，那是秦家的少奶奶。我以前就说过，秦家那大宅子煞气重，风水不好，可秦老爷偏不信，这下可惨了，儿子媳妇都去了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("张铁口：我张铁口算的卦，说一不二，百算百准！昨天夜里我就算准了，今日弦歌台上会有异象哇！");
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
        giRandTalkPush("赖小雯：爹从京城回来了，给小雯带了漂亮衣裳，还给娘买了首饰，可是娘一点都不开心，因为爹还带了个二娘回来……");
        giRandTalkPush("赖小雯：骆家哥哥剑法厉害，人也好，上回在碗丘山帮小雯打跑了地洞里爬出来的鬼怪，还送小雯回家……小雯最喜欢骆家哥哥了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("赖小雯：这个龙湖里，有种蒲草的根能吃～孔夫子来我们陈州的时候没东西吃，就靠吃这蒲根过活，还每天都在弦歌台讲学呢！");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("洪三：三教九流、各门各派都有自己的规矩，咱丐帮的规矩就是帮里的兄弟们不准沿着同一条大街要饭～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("洪三：这陈州好心的有钱人就是多，淮水南北所有丐帮的兄弟当中，只有我和老九的日子过得最舒坦，哈哈！");
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
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("单百川：我儿子捎了口信给我，说他不求仙了，过几天就回来，在外面吃了苦头，总算死心了吧？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("单百川：唉，秦老爷还没抱上孙儿，儿子媳妇就……秦家的香火眼看就这么断了，真不知道是造了什么孽。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("单百川：我那傻儿子听说黄山有剑仙，就千里迢迢跑去寻访，一走就是大半年，连个音信都没有……");
        giRandTalkPush("单百川：单家三代单传，我就指望儿子能多娶几房媳妇，为家里留后，没想到那小子竟然迷上了修仙，不娶媳妇不说，如今连人都不知去了哪！");
        giRandTalk();
        giRandTalkRelease();
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
    if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("陆风：要我说啊，秦家少奶奶自从相公过世后，就一直郁郁寡欢，久而久之气血也跟着郁结了，说不定就是得了什么怪病死的～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("陆风：千佛塔上供着舍利，那是真的，但要说那舍利能延年益寿、去病消灾，那八成就是假的了。");
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
        giRandTalkPush("萍儿：小姐的新衣裳做好了，董师傅正在店里等我去取，就不知道那衣裳合不合小姐的意。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("萍儿：那个姜氏，我以前也见过，她娘家是大户的好人家，算起来还是秦府的表亲，我见到她的时候，她还没嫁人，谁想到几年一过，竟然这样薄命……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("萍儿：我家小姐喜欢上了那几个跳舞姑娘的裙子，我正要去布庄给小姐裁布做裙子呢！");
        giRandTalkPush("萍儿：小姐挑剔得很，只信前头董广号里董师傅的手艺，不是董师傅裁的衣裳，小姐她看都不看一眼。");
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
        giRandTalkPush("颜红英：单家老伯说，单公子过段日子就能回陈州了，等他回来，就遣人来提亲……这，我还没见过单公子，不知他是怎样的人？能不能与我过那只羡鸳鸯不羡仙的日子……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("颜红英：“梧桐相待老，鸳鸯会双死。贞妇贵殉夫，舍生亦如此。”那个在塔里自尽的女子，听说是殉夫而死，真乃贞烈女子也。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("颜红英：我看城门处杂耍班姑娘的衣裳很漂亮，而且也不像酒坊老板娘那般露肩露臂的，所以就让萍儿去裁缝店，请董师傅帮我也裁一件。");
        giRandTalkPush("颜红英：陈州府中的年轻公子虽多，但行止道德却都不尽人意，倒是那位骆家公子，年纪虽小，却正直无私、嫉恶如仇，远非那些富贵人家的纨绔子弟可比。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4036");
    giNpcResumeBeh("4036");
    giPlayerUnLock();
}

void func4037()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4037");
    giCurrentPlayerFaceToNpc("4037", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToNpc("4037", "4038", true);
        giNpcFaceToNpc("4038", "4037", true);
        giTalk("晋晖昭：小晶～上回我爹找了人去你家提亲，你爹现在都没有给回音，你倒是告诉我，这事到底成是不成？", "");
        giTalk("贺晶：真是的，晖昭大哥你也不想想，若我爹真的不答应，今天我还能来这儿见你吗？", "");
        giTalk("晋晖昭：哈哈哈，那就太好了！咦？小晶你怎么脸红了？怕什么羞呀？反正你迟早都得嫁给我！", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giNpcFaceToNpc("4037", "4038", true);
        giNpcFaceToNpc("4038", "4037", true);
        giTalk("晋晖昭：小晶啊，若爹娘反对我们成亲，或者以后我娘待你不好，你会不会像琴姬那样……那样……", "");
        giTalk("贺晶：什么是好，什么又是不好？我同晖昭大哥你从小一起长大，我的心思，晖昭大哥你还不清楚吗？", "");
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4037", true);
            giTalk("晋晖昭：我同小晶是从小一起长大的，我们两人青梅竹马，门当户对……可小晶总喜欢研习佛法，近年来对我越来越冷淡了！", "");
        }
        else
        {
            giNpcFaceToNpc("4037", "4038", true);
            giNpcFaceToNpc("4038", "4037", true);
            giTalk("晋晖昭：小晶，湖上的荷花开了，我们不如到城东的码头去租条船，两个人在湖上好好游历一番？", "");
            giTalk("贺晶：看荷花又未必要坐船。", "");
            giTalk("晋晖昭：这……那小晶你说，想上哪儿去，我就陪你上哪儿去。", "");
            giTalk("贺晶：我也想坐船，不过我想去湖心的庙里找方丈大师论佛法，你要不要一起去？", "");
            giTalk("晋晖昭：……小晶，你能不能不要整天都想着佛法？我真担心，你哪天想不开就出家当了尼姑！", "");
        }
    }
    giNpcResetDir("4037");
    giNpcResetDir("4038");
    giNpcResumeBeh("4037");
    giPlayerUnLock();
}

void func4038()
{
    giPlayerLock();
    giNpcPauseBeh("4038");
    giNpcFaceToCurrentPlayer("4038", true);
    giCurrentPlayerFaceToNpc("4038", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("贺晶：前日晋伯伯让媒婆来我家提亲，我爹想了好久才答应，我知道他也是为我好，不想我嫁得不如意。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("贺晶：其实那姜氏又是何苦，她为秦家少爷自尽，只会加重秦家少爷的罪孽……说不定投胎也寻不到好人家了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("贺晶：湖心岛上的方丈大师精通佛法，我经常乘船去岛上与他谈经论道，每次都深得启发。");
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
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("董师傅：真正的胡装，其实是千斗酒坊老板娘穿的那样，露肩露臂，裙摆宽大，和汉人女子的衣裳完全不一样。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("董师傅：秦家公子少年风流，死后还有红颜知己对他念念不忘，要是换成我，我才舍不得死！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("董师傅：你问我身上带着这两把刀是干嘛的？不会吧，这个你都不知道？刀嘛，当然就是用来……裁衣服的啊！");
        giRandTalkPush("董师傅：在陈州开布庄当裁缝，最大的好处就是每天都能看到年轻漂亮的女子在我面前晃来晃去，真是“人生如此，夫复何求”啊！");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("杨景庄：这段日子我都在为倚栏歌榭的姑娘们作些唱词，其实风尘女子最多辛酸，远没有其他人看起来那般快乐无忧。");
        giRandTalkPush("杨景庄：听说城中有一位骆先生，也是精通音律之辈，其琴艺不在那琴姬之下，若有机会，真想拜会拜会这位骆先生……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("杨景庄：三国时候，“独占天下八斗才”的曹植被封为陈王，封地便是陈州。我应该在此地多逗留几日，也好沾沾昔日陈王的才气，免得下回赶考再落第。");
        giRandTalkPush("杨景庄：当年孔圣人在陈州弦歌台上绝粮七日，就靠蒲根度日，亦没有停止讲学，我只是一次科举未中，怎可轻言放弃？");
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
        giRandTalkPush("月桂：最近啊，只要苏公子和公孙公子一块儿来我们歌榭，玉芙蓉的心情就特别好，曲儿也会多唱几首～可她到底是喜欢苏公子，还是喜欢公孙公子呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("月桂：秦家的那个少夫人，也太想不开了！不就是死了相公嘛？又不愁吃穿，干嘛要寻死呀！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("月桂：我们的花魁玉芙蓉，不只是能歌善舞，连她唱的曲，还都是她自己谱乐填词的呢！");
        giRandTalkPush("月桂：玉芙蓉眼界可高了，普通富贵人家的公子，她可看不上眼，只有苏俊清苏公子，才稍微能博她一笑。");
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
        giRandTalkPush("玉芙蓉：反正都是要陪人饮酒作乐，与其对着一群秃头的胖子，不如对着两个年轻俊秀的公子，所以我才喜欢苏少爷和公孙少爷～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("玉芙蓉：城里人都说我唱的曲儿不如琴姬唱的，但他们却不知道，我唱的是“燕乐”，她唱的是“清乐”，怎能放在一起比呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("玉芙蓉：来我们倚栏歌榭的，大都是腰缠万贯的富贵之人，温言细语是假，寻欢作乐才是真。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4042");
    giNpcResumeBeh("4042");
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
        giRandTalkPush("殷函月：那日我去了千佛塔，想找那些武僧来切磋一番，谁知道守在塔外的和尚根本不让我进去，说什么佛门清净之地，不接待女客！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("殷函月：我曾远远见过琴姬一面，她的武艺一定不弱，却已誓言封剑，真是太令人惋惜了……");
        giRandTalkPush("殷函月：琴姬当年从夫家出走，我倒也能明白她的心情，江湖儿女过惯了自由自在的日子，一时间要拘束起来，谁也受不了啊。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("殷函月：原来“清风剑”张玉太张大侠也在陈州，我刚才遇到他，他还邀我共游龙湖，可惜我一见男人，就会浑身不自在，所以只能拒绝了他……");
        giRandTalkPush("殷函月：听说陈州董广号的老板年轻时也是一代大侠，玉树临风，曾博得无数江湖女子的青睐，却不知他到底为何要弃剑封刀，还在陈州开了布庄？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4044");
    giNpcResumeBeh("4044");
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
        giRandTalkPush("查七娃：我喜欢看大象，如果能骑在大象背上，一定更好玩～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("查七娃：娘说我们要从塔里把爷爷的牌位接回来啦，这样以后我就再也不用爬那么高的塔去拜爷爷～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("查七娃：爷爷说，弦歌台是从前孔圣人教书时待的地方～可那样的话，不是应该叫念书台吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4043");
    giNpcResumeBeh("4043");
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
        giRandTalkPush("陈泗：“清风剑”张玉太张大侠说，他可以收我为徒，可条件却是要我能一手举起千斤之物……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("陈泗：我从小喜欢习武，本想去龙湖边的百炼清钢打一把剑，可是刘铁匠说我气力不够，根本提不动他打的剑！");
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
    if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("三顺：原来那天在弦歌台上弹琴的女人是秦家的媳妇，不过已经被逐出家门了，难怪有点落魄。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("三顺：我觉得那弹琴的女人有点脸熟，就是想不起来在哪儿见过……没道理啊，她长那么漂亮……");
        giRandTalk();
        giRandTalkRelease();
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
    if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("陈久：听说前阵子在弦歌台上唱曲的女子已经走了，真是太可惜了……就算花大价钱去倚栏歌榭，都听不到那么好的曲子啊！", "");
    }
    else
    {
        giTalk("陈久：那女子弹的曲子真好听，不知跟城里歌榭的玉芙蓉比起来，谁的琴技更好？", "");
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
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("洛梅：玉芙蓉的曲子也是越唱越好听了，不过和琴姬比起来，总觉得缺了些什么……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("洛梅：原来那琴姬是秦家的媳妇，难怪我总觉得面善，没想到她走了那么多年，竟然还会回来。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("洛梅：在前面弦歌台上弹唱的女子，我看着有点面善……是不是在哪里见过？");
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
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("金盏：清风拂柳絮，箜篌指尖唱，歌榭栏杆，酒不醉人人自醉。");
        giRandTalkPush("金盏：流水逐落红，琵琶因情动，飞燕轻舞，明月曾照彩云归。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("金盏：提起秦少爷，我也见过几面，那时候他还没成亲，为人温文尔雅，待我们歌榭的姑娘也不像别人那般轻浮，很多姐妹都喜欢他。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("金盏：弦歌台上那女子，弹唱都有几分能耐，凭她的本事，就算去了京城，也是不愁吃穿的。");
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
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("凌天守：知府大人三天两头不在府里，也不知道去了哪儿，我手里需要呈上去的拜帖已经有一叠了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("凌天守：千佛塔里闹了桩人命，这事一定不简单，官府要好好查查！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("凌天守：此地是陈州府衙，知府大人现下不在府中，若你有拜帖，可先给我，待大人回来了，我会呈交于他。");
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
    giRandTalkRelease();
    giRandTalkPush("周慈：原先住在城里的秦老夫人，我也见过几次，看她家不像是落魄的样子，倒不知为什么要把房子卖了。");
    giRandTalkPush("周慈：买宅子的时候，风水先生说那宅子煞气重～我就说了，这煞气不煞气的，都是人心里的鬼，多拜菩萨，多捐香火钱，心里的鬼跑了，就万事吉利了。");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    giRandTalkPush("柴忠：我们老爷和夫人是不久前才搬来这里的，听说这宅子不吉利，但是夫人很喜欢，老爷便买下了。");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("穆婉蓉：城里新搬来的那户人家，夫人也经常来拜菩萨，上次我还在旁边的祖师庙里见到她，看样子是在为出门在外的少爷求签。");
        giRandTalkPush("穆婉蓉：骆家父子感情真好，骆少爷还小的时候，骆先生常来寺里为骆少爷上香，如今骆先生出远门去了，换骆少爷日日来此，为爹爹上香求平安。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("穆婉蓉：佛门圣地有了血光之象，太不吉利了……那姜氏一定是个苦命的女子……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("穆婉蓉：这里的塔上有佛门圣物舍利子，所以这里的菩萨也特别灵，我每天都会来参拜。");
        giRandTalkPush("穆婉蓉：我相公的身子有些弱，一上船就晕，所以平时都不和我一起来庙里。");
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
    if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("净慧：千佛塔上供奉牌位，原本也只是想借舍利圣光令死者求得宁静，如今染了秽气，真是罪过啊！阿弥陀佛！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("净慧：阿弥陀佛，善哉善哉，施主若是来拜佛，就请去佛堂，勿要随意乱闯，扰我佛门清净。");
        giRandTalk();
        giRandTalkRelease();
    }
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
    giRandTalkRelease();
    giRandTalkPush("净虚：阿弥陀佛，善哉善哉。我看施主身携刀剑，难道是来此和塔中师兄们切磋武艺？出家人六根清净，不会轻易向施主动武，施主还是请回吧。");
    giRandTalk();
    giRandTalkRelease();
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
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("净觉：最近有位女施主常来庙中参拜。贫僧看她面带和善之气，是富贵有福之人，加上她诚心向佛，日后必有善报。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("净觉：方丈大师曾欲点化那位在塔中自尽的女施主，无奈女施主执念太重，终究无法明白方丈的一片苦心。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("净觉：祖师殿是寺僧做早课晚课、静思的地方，施主请勿入内。");
        giRandTalkPush("净觉：本寺修持，本着禅宗“不立文字，直指人心，见性成佛”之意，寺中经书不多，若心中有惑，就直接请方丈大师解惑。");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("智圆：贫僧在此打扰甚久，每日同方丈大师对弈论禅，受益良多，如今也该启程回去了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("智圆：此地方丈不仅精通佛法，更是善弈，其弈之法，不着痕迹，不露杀意，却将贫僧的执念看的通透，真乃高人也！");
        giRandTalkPush("智圆：贫僧在此地数日，每日同方丈大师手谈数局，每次皆以一、二子落败，但都深得启发。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4057");
    giNpcResumeBeh("4057");
    giPlayerUnLock();
}

void func4058()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4058");
    giCurrentPlayerFaceToNpc("4058", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4058", true);
        giTalk("净念：常来找贫僧论佛的贺家女施主几日前和一名公子同来，原来他们俩佳期将近，她果然还是尘缘未断。", "");
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4058", true);
            giTalk("净念：城里贺家的女施主是个清心寡欲之人，常来此找贫僧谈经论佛，言语间很有见地。贫僧看她也是与佛有缘，只是心中尚有放不下的事，才迟迟没有出家罢了。", "");
        }
        else
        {
            giNpcFaceToNpc("4058", "4057", true);
            giNpcFaceToNpc("4057", "4058", true);
            giTalk("净念：智圆你须知道，一味猛斗狠杀，终究流于下品，你我空门中人，原就讲求无欲而欢，如你般行棋，无益修禅。", "");
            giTalk("智圆：智圆与大师多番对弈，心中亦明白这个道理。只是一旦开局，总不能放下心中的执念，还请方丈大师指点。", "");
            giTalk("净念：你当记得，棋盘是禅堂，是山林，不是沙场。对弈之乐在于坐隐，在于忘忧，而不是自寻烦恼。", "");
        }
    }
    giNpcResetDir("4058");
    giNpcResetDir("4057");
    giNpcResumeBeh("4058");
    giPlayerUnLock();
}

void func4059()
{
    giPlayerLock();
    giNpcPauseBeh("4059");
    giNpcFaceToCurrentPlayer("4059", true);
    giCurrentPlayerFaceToNpc("4059", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("净善：前几日贺姓的女施主带一名公子来寺里，说那位公子前年刚开始学棋，棋力尚浅，让贫僧与他切磋一二，没想到贫僧跟方丈学棋那么多年，却是一败涂地……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("净善：城中的秦施主是有善心之人，以前时常陪他母亲来寺里参拜，十分孝顺，没想到生了场大病，就这么过世了，佛说死生无常，贫僧似乎还是放不下……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("净善：方丈师父好弈，棋力很高，贫僧跟他学了几年，现在同师父下棋，需师父授贫僧七子，才可勉强下出平局。");
        giRandTalkPush("净善：经常有棋力高强的人来寺里找方丈师父切磋，不过除了城里来的一位贺姓女施主，别人的棋艺都不能和师父相提并论。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4059");
    giNpcResumeBeh("4059");
    giPlayerUnLock();
}

void func4060()
{
    giPlayerLock();
    giNpcPauseBeh("4060");
    giNpcFaceToCurrentPlayer("4060", true);
    giCurrentPlayerFaceToNpc("4060", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("净慈：寿阳的东禅寺正在修缮，寺中诸人如今住在寿阳城外的真武庙，真武庙离陈州不远，所以常有东禅寺的僧人来这里同论佛法。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("净慈：阿弥陀佛，善哉善哉！那位女施主在塔里守灵不少时日，原以为她能感悟我佛教诲，没想到却还是执迷啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("净慈：贫僧曾得一本菜谱，才知即便是素斋，亦有千变万化之理，以前所想未免太过肤浅！阿弥陀佛！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4060");
    giNpcResumeBeh("4060");
    giPlayerUnLock();
}

void func4061()
{
    giPlayerLock();
    giNpcPauseBeh("4061");
    giNpcFaceToCurrentPlayer("4061", true);
    giCurrentPlayerFaceToNpc("4061", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("方勇杰：唉，知府大人既然不在，不如放我们几天假吧？……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("方勇杰：千佛塔上都闹出人命来了，知府大人他、他……到底是什么重要的贵人，让知府大人出城那么多天还不回来？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("方勇杰：知府大人离开陈州，是去见一位从京城来的贵人。听说那位贵人是来陈州附近游历，不肯入城，知府大人只能出城相见。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4061");
    giNpcResumeBeh("4061");
    giPlayerUnLock();
}

void func4062()
{
    int random_1_4 = 0;

    giPlayerLock();
    giCurrentPlayerFaceToNpc("4062", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("牡丹：杨景庄杨公子人生得俊，又懂音律，还写得一首好诗词，常为歌榭里的姑娘填词，我们每唱一曲杨公子的新词，来歌榭的客人便是平日的两三倍，他真是有才！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("牡丹：以前秦家少爷未成亲的时候，常来歌榭里和我们谈曲论调，言语间温文有礼，不知比其他轻薄的公子好多少，后来他娶亲了，就再也没来过歌榭。听说他过世的时候，歌榭里认识他的姐妹都很伤心呢。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giTalk("牡丹：司马公子总赞我弹奏的曲子比京里教坊司的还动人，若真是如此，我还会坐在这里吗？这些有钱男人的话，没半句是真心的。", "");
        }
        else
        {
            giTalk("牡丹：说什么“昆山玉碎凤凰叫，芙蓉泣露香兰笑”～…我奏的曲子哪有这能耐呀！司马公子最爱说笑了！", "");
            giTalk("司马朝文：我可是认真的！牡丹小姐的箜篌弹奏得如此绝妙无双，即使是京城教坊司里，在皇上面前奏乐的姑娘也比不上你啊！", "");
        }
    }
    giPlayerUnLock();
}

void func4063()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4063", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("司马朝文：哼！那个姓杨的书生不就是凭着自己略通音律，作些浮艳的诗词，把这里的姑娘哄得服服贴贴，个个都对他推崇得不得了！这种“以才谋艳”的书生，简直就是读书人中的败类！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("司马朝文：不知那琴姬本名为何，家住何处？我若能寻她到皇上面前弹唱一曲，一定能博得龙颜大悦，说不定还能立刻让我加官进爵！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("司马朝文：牡丹姑娘弹奏的曲子自然是很好听，但真要去皇上面前弹奏，就稍欠几分火候了。不过能在陈州这地方听到这样的曲子，也算不容易～");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4064()
{
    int random_1_4 = 0;

    giPlayerLock();
    giCurrentPlayerFaceToNpc("4064", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("朱长风：牡丹姑娘最近又喜欢上了一个姓杨的书生，说什么杨公子所作之曲甚合她心……唉，她眼中有谁却也没有我啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("朱长风：我送你那么多玉佩首饰，天天来此听你弹曲、陪你喝酒，你就不能多念几句我的好，少说几句那个秦逸吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giTalk("朱长风：别看牡丹姑娘一介女流，流落风尘，就凭她同我玩分曹射覆之戏时的眼力，只要有名师指点，不出三年，牡丹姑娘一定是一流的暗器好手！", "");
        }
        else
        {
            giTalk("朱长风：牡丹小姐，别理这家伙的胡言乱语！来！猜猜我把玉佩放在哪只酒杯下了？猜对了玉佩就送你，猜错了可要罚酒！", "");
            giTalk("牡丹：嘻嘻，朱大侠在此数日，同我耍玩这分曹射覆之戏，已经让我赢得三枚玉佩，十多锭银子了，还要继续玩？这次若我猜对了，不仅那玉佩是我的，朱大侠你还得连罚三十杯！", "");
        }
    }
    giPlayerUnLock();
}

void func4065()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4065", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("海棠：司马大人和朱公子每天都缠着牡丹，苏公子和公孙少爷同玉芙蓉的交情也不错，为什么看上我的却都是些又胖又臭的老男人？……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("海棠：秦家有财有势，秦少爷又用情专一，真想不通那个琴姬当年有什么不满意，要离家出走！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("海棠：来我们这里的，管你长得俊还是丑，有钱就是大爷～");
        giRandTalkPush("海棠：听说皇上要来咱陈州，妈妈整天催着我练舞，可是那跳给皇上看的八佾舞要六十四个姐妹一起呢，光叫我一个人练有什么用！");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4066()
{
    int random_1_4 = 0;

    giPlayerLock();
    giCurrentPlayerFaceToNpc("4066", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("王福海：听说这歌榭里的姑娘跳起舞来，好比天上的仙女！我从安溪来陈州，一为茶叶生意，再为了就是想看这儿的姑娘跳舞！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("王福海：喝一杯酒要三两银子？没弄错吧？！", "");
        giTalk("海棠：哎呀～王老爷您这就不懂了，所谓酒不醉人人自醉嘛～好酒也须美人斟～", "");
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giTalk("王福海：哼！不就是一群卖艺的下贱女子吗？！口气排场大得跟什么似的，我找一个姑娘弹曲，竟然让我在这儿等了整整一个时辰！", "");
        }
        else
        {
            giTalk("王福海：你们倚栏歌榭是怎么搞的！我一个人在这里坐了老半天才有个姑娘来招呼！不知道我是安溪第一茶商吗？！", "");
            giTalk("海棠：哟！我还道是哪位员外大人呢！原来是王老爷呀～真是不好意思了，让您久等～", "");
        }
    }
    giPlayerUnLock();
}

void func4067()
{
    giPlayerLock();
    giNpcPauseBeh("4067");
    giNpcFaceToCurrentPlayer("4067", true);
    giCurrentPlayerFaceToNpc("4067", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("秋英：不懂音律的人常分不清琴和筝，其实听音即可分辨，琴声低而绵长，绕梁不绝于耳，筝音脆而动人，如泉流淌不息。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("秋英：陈州的年轻公子，也就只有秦逸秦少爷是个好人，以前来我们歌榭，待姐妹们也都不错，可惜好人偏偏不长命啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("秋英：其实姐妹们跳得最好的舞是佾舞，由歌榭里六十四个姐妹一起演，那场面可漂亮啦！");
        giRandTalkPush("秋英：金盏一大早就跑出去了，说是待在船上闷得慌，非要出去走走，我猜她一定是看上哪家的公子，私会去了～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4067");
    giNpcResumeBeh("4067");
    giPlayerUnLock();
}

void func4068()
{
    giPlayerLock();
    giNpcPauseBeh("4068");
    giNpcFaceToCurrentPlayer("4068", true);
    giCurrentPlayerFaceToNpc("4068", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("慕蒂：你们中原的诗人说“葡萄美酒夜光杯”，葡萄酒和夜光杯我们千斗酒坊都有，客人要不要尝尝看？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("慕蒂：中原女人唱的曲子好听是好听，但却很悲伤，歌不是快乐的时候才唱吗？为什么要那么伤心呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("慕蒂：我们听说中原繁华，就跟着大姐赛乃慕从西域到这里来，卖掉家乡带来的一些首饰，开了这家酒肆～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4068");
    giNpcResumeBeh("4068");
    giPlayerUnLock();
}

void func4069()
{
    int local_2 = 0;

    giPlayerLock();
    giCurrentPlayerFaceToNpc("4069", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        local_2 = giGetRandnum(1, 4);
        if (local_2 != 2)
        {
            giTalk("宋豪书：再不启程上京，就要赶不上殿试开考了！可这位唐女侠武功了得，三两下就能把我制得动也动不了……", "");
        }
        else
        {
            giTalk("宋豪书：唐女侠，你放我上路去京城吧！再耽搁，我就要赶不上今年的殿试啦！", "");
            giTalk("唐含秋：这有何难？凭你夺命书生的本事，要抵挡我手中的长剑，根本不费吹灰之力！", "");
            giTalk("宋豪书：我说了几千几万遍了，我不是女侠你找的什么夺命书生，半点武功都不会，女侠你就不要再为难小生了！……天呐……", "");
        }
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("宋豪书：读书人最好还是不要和那些江湖人扯上关系，否则都会和秦府那个少爷一样，自己被江湖女子累死不说，还辜负了秦夫人这般痴情的烈女子……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        local_2 = giGetRandnum(1, 4);
        if (local_2 != 2)
        {
            giTalk("宋豪书：我上京赶考，路过此地见酒肆有葡萄美酒，所以进来喝上一杯，没想到就被这位女侠误认为是什么“夺命书生”了，这……可如何是好呀！", "");
        }
        else
        {
            giTalk("宋豪书：唐女侠，我只是一个手无缚鸡之力的书生，并非是你所说的什么“夺命书生”，根本不可能和你一起去闯什么王陵，你一定是认错人了！", "");
            giTalk("唐含秋：我不管，反正就是夺命书生约我今日此时在千斗酒坊相见，你生得这么俊，还背着一把伞，跟江湖传闻的夺命书生完全一个样，不可能不是他！", "");
            giTalk("宋豪书：全天下的书生出门赶考，总会带着伞，女侠你不能因为我带着伞，就说我是那什么夺命书生啊！女侠真拉我去闯江湖，我必是一命呜呼的！", "");
        }
    }
    giPlayerUnLock();
}

void func4070()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4070", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("唐含秋：这夺命书生真是气死人！他竟然说要去赶考，当什么狗官，一身武功不就荒废了？！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("唐含秋：琴姬八成是被那个秦少爷迷昏了头，不然好好的江湖儿女，怎么会看上那种又呆又蠢的迂腐少爷？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("唐含秋：这夺命书生好奇怪，明明就是他用飞鸽传书约我来此处相见，我来找他，他却硬说自己是不懂武功的读书人，他这葫芦里到底卖的什么药！");
        giRandTalkPush("唐含秋：就算我面前这人真不是夺命书生，我也要逼他承认是！我唐含秋认错人的事情要是传了出去，今后可怎么在江湖上混！");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4071()
{
    giPlayerLock();
    giNpcPauseBeh("4071");
    giNpcFaceToCurrentPlayer("4071", true);
    giCurrentPlayerFaceToNpc("4071", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("露丽尔：酒肆的生意好，大姐打算回一趟家乡，多带几个姐妹出来，然后再盖一间更大的酒肆，夜夜唱歌跳舞，把那个倚栏歌榭比下去！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("露丽尔：夜里……我好像听到一首很哀伤的曲子，到底是谁在弹琴呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("露丽尔：哟～客人，我正忙着，你先去旁边坐一坐好吗？我马上就来～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4071");
    giNpcResumeBeh("4071");
    giPlayerUnLock();
}

void func4072()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4068", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToNpc("4071", "4072", true);
        giTalk("安尼瓦尔：姑娘，你的家乡是哪？是疏勒镇还是碎叶镇？", "");
        giTalk("露丽尔：我说了你也不一定知道～反正姐妹们都是在龟兹认识的，后来就跟着商队来了中原。", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("安尼瓦尔：这是怎么搞的！这么点酒居然这样贵！在我的家乡可不是这样的……");
        giRandTalkPush("安尼瓦尔：没想到中原的葡萄酒这么大价钱，还有许多人喝……以后我也来中原开酒坊好了！");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4073()
{
    giPlayerLock();
    giNpcPauseBeh("4073");
    giNpcFaceToCurrentPlayer("4073", true);
    giCurrentPlayerFaceToNpc("4073", true);
    giRandTalkRelease();
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("孙碧露：年轻的女孩子好像都喜欢吃小食，我就常在这小摊前看见倚栏歌榭的姑娘买醉枣。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkPush("孙碧露：那秦家少夫人也太想不开啦！吃穿不愁的，寻什么死？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("孙碧露：罗老板卖的炸馓子香酥可口，远近闻名，别处可吃不着。");
        giRandTalkPush("孙碧露：戏台对面小摊的罗聪很爱喝酒，连他的醉枣也特别好吃！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4073");
    giNpcResumeBeh("4073");
    giPlayerUnLock();
}

void func4074()
{
    giPlayerLock();
    giNpcPauseBeh("4074");
    gi2DSoundPlay("WB020", 1);
    giNpcResumeBeh("4074");
    giPlayerUnLock();
}

void func4075()
{
    giPlayerLock();
    giNpcPauseBeh("4075");
    gi2DSoundPlay("WB021", 1);
    giNpcResumeBeh("4075");
    giPlayerUnLock();
}

void func4076()
{
    giPlayerLock();
    giNpcPauseBeh("4076");
    gi2DSoundPlay("WB020", 1);
    giNpcResumeBeh("4076");
    giPlayerUnLock();
}

void func4077()
{
    giPlayerLock();
    giNpcPauseBeh("4077");
    giNpcFaceToCurrentPlayer("4077", true);
    giCurrentPlayerFaceToNpc("4077", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("谭八：川蜀唐门以毒功闻名江湖，武林中人对他们通常都是敬而远之，倒是想不通最近为什么会传出那夺命书生约唐家堡三小姐在陈州相会之事？", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giRandTalkRelease();
        giRandTalkPush("谭八：话说二十多年前，我曾在陈州遇到过当时赫赫有名的铁琴女侠，那风姿、那琴艺，都和这琴姬如出一辙，我敢肯定琴姬就是铁琴女侠的后人！");
        giRandTalkPush("谭八：骆家少爷小小年纪就使得一手好剑法，连我都看不出他的师承来历！听说这位少爷的师父是骆先生的至交好友……说不定骆先生以前就是江湖中了不得的人物！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giTalk("谭八：十八年前，江湖上曾出现过一名人称“影煞孤魂”的杀手，他在一夜之间连杀四十名白道高手，之后力竭而亡！不过最近好像又有传闻说那“影煞孤魂”并没有死，而且已经在陈州隐居很久啦！", "");
    }
    giNpcResetDir("4077");
    giNpcResumeBeh("4077");
    giPlayerUnLock();
}

void func4078()
{
    giPlayerLock();
    giNpcPauseBeh("4078");
    giNpcFaceToCurrentPlayer("4078", true);
    giCurrentPlayerFaceToNpc("4078", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("艾米拉：中原的英俊男子真是多，可惜却都不怎么强壮高大，看起来都是一副不可靠的样子。", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("艾米拉：这几天来来往往的客人都在说一个名叫“琴姬”的女人，说她唱的歌儿好听，我们酒坊的姐妹也会唱歌，改天一定要和那个“琴姬”比一比！", "");
    }
    else
    {
        giTalk("艾米拉：苏少爷是知府大人的公子，他经常会带许多朋友来我们酒坊喝酒，二楼里间的那几个座位，几乎是苏少爷包了的。", "");
    }
    giNpcResetDir("4078");
    giNpcResumeBeh("4078");
    giPlayerUnLock();
}

void func4079()
{
    giPlayerLock();
    giNpcPauseBeh("4079");
    giNpcFaceToCurrentPlayer("4079", true);
    giCurrentPlayerFaceToNpc("4079", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("拜合蒂：从我们家乡来的人都说我们酒坊的葡萄酒没有家乡的好，可这也不是我们的错呀！中原的葡萄不比家乡的葡萄甜，酿出来的酒，味道当然也会不一样。", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("拜合蒂：中原的女人真是太奇怪了，情郎死了可以再找一个啊！年纪轻轻的就殉情，多不划算呀！", "");
    }
    else
    {
        giTalk("拜合蒂：我们酒坊的葡萄酒、三勒浆，那可是别的店里喝不到的，客人您既然都已经来了，就进去喝两杯吧～～", "");
    }
    giNpcResetDir("4079");
    giNpcResumeBeh("4079");
    giPlayerUnLock();
}

void func4080()
{
    giPlayerLock();
    giNpcPauseBeh("4080");
    giNpcFaceToCurrentPlayer("4080", true);
    giCurrentPlayerFaceToNpc("4080", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("帕夏：大姐已经托商队捎消息回家乡，请家乡的姐妹跟着商队一起来陈州，那样我们千斗酒坊以后也能像那个倚栏歌榭一样，每天夜里都唱歌跳舞！", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("帕夏：听说那个在城里唱歌的女人已经走了，不知道她还会不会回来？真想再听她弹唱的曲子呀……", "");
    }
    else
    {
        giTalk("帕夏：最近城里常常有个中原女人在唱歌，唱的真是好听极了！可惜我每次等酒坊打烊了去找她，却总也找不到……", "");
    }
    giNpcResetDir("4080");
    giNpcResumeBeh("4080");
    giPlayerUnLock();
}

void func4081()
{
    giPlayerLock();
    giNpcPauseBeh("4081");
    giNpcFaceToCurrentPlayer("4081", true);
    giCurrentPlayerFaceToNpc("4081", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("来奉：嘿！告诉你一个秘密！陈州董广号的师傅可是昔日江湖上的大人物！他手中那对裁布刀——哦不，锋锐的匕首，曾经杀了不知道多少江湖中人呢！", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("来奉：一大早就听说湖心岛上死了人，还是死在千佛塔里的……这佛门圣地闹了血光之灾，真是不吉利啊！", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("来奉：咱升平客栈有淮河两岸最好的厨子、最上等的美酒、最舒服的上房！客官您可要歇息一下再上路呀？");
        giRandTalkPush("来奉：什么？你问我那边猪肉摊的老板哪儿去了？哈哈，八成又在哪儿喝醉了酒，不记得回来照顾生意啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4081");
    giNpcResumeBeh("4081");
    giPlayerUnLock();
}

void func4082()
{
    giPlayerLock();
    giNpcPauseBeh("4082");
    giNpcFaceToCurrentPlayer("4082", true);
    giCurrentPlayerFaceToNpc("4082", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("杜鹃：我听人说，董广号的裁缝师傅其实是个武林高手！可上次我去裁衣服，他那双眼睛直勾勾地盯着我瞧，哪里有什么高手的样子呀～～", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("杜鹃：秦家少爷我倒是认得，当年他也常来歌榭和我们姐妹评曲论调，半分富家公子的架子也没有……可惜这样的好人却不长命……", "");
    }
    else
    {
        giTalk("杜鹃：这湖面上传来的曲声……不像是我们歌榭里姐妹弹奏的……那么好听的曲子……到底是谁呢？", "");
    }
    giNpcResetDir("4082");
    giNpcResumeBeh("4082");
    giPlayerUnLock();
}

void func4083()
{
    int leader_player_id = 0;

    giPlayerLock();
    giNpcPauseBeh("4083");
    giNpcFaceToCurrentPlayer("4083", true);
    giCurrentPlayerFaceToNpc("4083", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("春梅：其实也有些富家公子老爷帮歌榭的姑娘赎身的，只是那些被带走的姑娘，真正过得快乐的，却也没有几个……", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("春梅：什么“贞妇贵殉夫，舍生亦如此”，我看全都是胡说的！要真如此，天下的青楼女子都可以不用活了！", "");
    }
    else
    {
        leader_player_id = giPlayerGetLeader();
        if (giPlayerGetLeader() != 0)
        {
            giTalk("春梅：哟！真是个可爱的女娃儿～不过小姑娘家的，最好还是不要随便出入这种风月之地啦～", "");
        }
        else
        {
            giTalk("春梅：小哥儿生得真俊俏，让姐姐我看了好生喜欢，要不要姐姐陪你进歌榭喝两杯呀？", "");
        }
    }
    giNpcResetDir("4083");
    giNpcResumeBeh("4083");
    giPlayerUnLock();
}

void func4090()
{
    giPlayerLock();
    giNpcPauseBeh("4090");
    giCurrentPlayerFaceToNpc("4090", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4090", true);
        giTalk("李常贵：罢了、罢了，只要茉莉她喜欢，跟谁走也都是一样的，现在只盼望这赵员外以后能善待茉莉……", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giNpcFaceToCurrentPlayer("4090", true);
        giTalk("李常贵：看茉莉的样子，似乎挺中意这位赵员外的，但是这门不当户不对的，就像那个琴姬和秦少爷一样，不会有好结果的呀！", "");
    }
    else
    {
        giNpcFaceToNpc("4090", "4092", true);
        giNpcFaceToNpc("4092", "4090", true);
        giTalk("李常贵：小茉，我是你哥哥啊！当年家里穷，爹娘没法子才把你卖到青楼，现今哥哥有钱替你赎身了，跟哥哥回家吧！", "");
        giTalk("茉莉：哼，当年家里穷便要卖了我，现在才想到还有我这个妹妹？这若是家里再出什么事，是不是还要把我卖第二回？！", "");
    }
    giNpcResetDir("4090");
    giNpcResetDir("4092");
    giNpcResumeBeh("4090");
    giPlayerUnLock();
}

void func4091()
{
    giPlayerLock();
    giNpcPauseBeh("4091");
    giCurrentPlayerFaceToNpc("4091", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4091", true);
        giTalk("赵员外：上次去京城做了一笔大生意，还在京城置办了一处房舍，这回替茉莉赎了身，也不愁没地方安置她了。", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giNpcFaceToNpc("4091", "4092", true);
        giTalk("赵员外：茉莉啊，我看这个郎中的样子根本就不像是你的什么哥哥，我不在陈州的时候，你可要千万别被他骗了去！", "");
    }
    else
    {
        giNpcFaceToNpc("4091", "4092", true);
        giNpcFaceToNpc("4092", "4091", true);
        giTalk("赵员外：茉莉啊茉莉～～我这次去京城做生意，回来之后就立即为你赎身，带你走！", "");
        giTalk("茉莉：哦？是吗？那妾身真是要多谢赵员外的厚爱了～～～", "");
    }
    giNpcResetDir("4091");
    giNpcResetDir("4092");
    giNpcResumeBeh("4091");
    giPlayerUnLock();
}

void func4092()
{
    giPlayerLock();
    giNpcPauseBeh("4092");
    giNpcFaceToCurrentPlayer("4092", true);
    giCurrentPlayerFaceToNpc("4092", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("茉莉：赵员外常来歌榭听我唱曲儿，虽然年纪有些大了，人倒是还不坏。", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("茉莉：唉……如果我有那琴姬的能耐，就算不去闯荡江湖，也能上京城进教坊司，横竖都不用待在这儿看这群臭男人的脸色～", "");
    }
    else
    {
        giTalk("茉莉：这陈州富庶繁华，歌舞升平，就算要看着一群臭男人的脸色过日子，也比回乡下老家好～", "");
    }
    giNpcResetDir("4092");
    giNpcResumeBeh("4092");
    giPlayerUnLock();
}

void func4093()
{
    giPlayerLock();
    giNpcPauseBeh("4093");
    giNpcFaceToCurrentPlayer("4093", true);
    giCurrentPlayerFaceToNpc("4093", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("贺敏：晶姐姐要嫁给晋家那傻小子了……不过好歹也还是在这城里，即使嫁了，也还是能见面的……倒是文秀姐要嫁去京里，怕是再难相见了……", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("贺敏：情之为物，当真叫人难以猜度。想那琴姬，看来是如此飘逸出尘，想不到也为情所困……", "");
    }
    else
    {
        giTalk("贺敏：师儿的诗固然作的好，可又怎比得上我晶姐姐的文才？可惜晶姐姐如今一心都只在晋家那傻小子的身上，已经很久都没来和我们一起作诗了～", "");
    }
    giNpcResetDir("4093");
    giNpcResumeBeh("4093");
    giPlayerUnLock();
}

void func4094()
{
    giPlayerLock();
    giNpcPauseBeh("4094");
    giCurrentPlayerFaceToNpc("4094", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("苏文秀：日暮湖畔自凭栏，弦歌莲叶无穷碧。他日南望淮河畔，千山万水路遥遥。", "");
        giNpcFaceToNpc("4095", "4094", true);
        giTalk("楚师儿：文秀姐，远嫁京师，路途遥远，你……一路保重……", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giNpcFaceToCurrentPlayer("4094", true);
        giTalk("苏文秀：前些天还在想，贺晶妹妹那么冰雪聪明的人，怎会喜欢上一个愣头愣脑的傻小子，今日又听说千佛塔里的秦夫人殉情自尽……情之为物，实在叫人看不明白……", "");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4094", true);
        giTalk("苏文秀：此处的亭台临水而建，优雅清净，我们姐妹几个常来这里吟诗作对。不过只有师儿和小晶的诗文才是最好的。", "");
    }
    giNpcResetDir("4094");
    giNpcResetDir("4095");
    giNpcResumeBeh("4094");
    giPlayerUnLock();
}

void func4095()
{
    giPlayerLock();
    giNpcPauseBeh("4095");
    giNpcFaceToCurrentPlayer("4095", true);
    giCurrentPlayerFaceToNpc("4095", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("楚师儿：先是小晶将要出阁，如今连文秀姐姐也即将远嫁……所谓天下无不散的宴席，我们姐妹几人也许再难像如今一般聚在一起了吧……", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("楚师儿：忆昔初会龙湖上，萧音清越琴悠扬。问情一曲忘江湖，旧船空横乱荷塘。", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("楚师儿：最近几日，弦歌台上常有曲声传来……我总觉耳熟，似乎数年前在这龙湖之畔，曾有听过……");
        giRandTalkPush("楚师儿：荷叶碧连天，柳絮随风扬。弦歌丝竹唱，歌榭燕舞翩。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4095");
    giNpcResumeBeh("4095");
    giPlayerUnLock();
}

void func4096()
{
    giPlayerLock();
    giNpcPauseBeh("4096");
    giNpcFaceToCurrentPlayer("4096", true);
    giCurrentPlayerFaceToNpc("4096", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("陈嫂：唉……阿泗那孩子……上回竟然去找“清风剑”张大侠，还说要拜人家为师！真是拿他一点办法都没有啊……", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("陈嫂：阿泗他听说那琴姬是个女侠，就吵着要拜人家为师！还好琴姬已经离开陈州了，否则还不知道那孩子会闹出什么事来！", "");
    }
    else
    {
        giTalk("陈嫂：我家那个阿泗，整天想着练武功，偏偏又自小多病，连只鸡也抓不住，练什么武呀！", "");
    }
    giNpcResetDir("4096");
    giNpcResumeBeh("4096");
    giPlayerUnLock();
}

void func4097()
{
    giPlayerLock();
    giNpcPauseBeh("4097");
    giCurrentPlayerFaceToNpc("4097", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4097", true);
        giTalk("穆南娃尔：过几天我就要跟爹一起回西域了，这回特地请董师傅替我多裁几件裙子，回到家乡穿给姐妹们看，姐妹们一定羡慕死我了！", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giNpcFaceToCurrentPlayer("4097", true);
        giTalk("穆南娃尔：旁边的这个差爷整天阴着一张脸，看起来真可怕！不是说千佛塔里面死了人吗？他为什么不去办那个案子……", "");
    }
    else
    {
        giNpcFaceToNpc("4097", "4039", true);
        giNpcFaceToNpc("4039", "4097", true);
        giTalk("穆南娃尔：中原的丝绸卖得真便宜，在西域做一条裙子的钱，在中原可以做整整三套漂亮的衣服，董师傅的手艺更是比得过我们家乡手最巧的姑娘家～", "");
        giTalk("董师傅：嘿嘿，哪里哪里～只要姑娘喜欢，什么样的衣裳是我做不来的？", "");
    }
    giNpcResetDir("4097");
    giNpcResetDir("4039");
    giNpcResumeBeh("4097");
    giPlayerUnLock();
}

void func4098()
{
    giPlayerLock();
    giNpcPauseBeh("4098");
    giNpcFaceToCurrentPlayer("4098", true);
    giCurrentPlayerFaceToNpc("4098", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("刘捕快：最近有传闻说，十八年前江湖上那令人闻风丧胆的杀手“影煞孤魂”正是陈州布庄的这位董师傅？可这董师傅横看竖看都只是个有点好色的裁缝而已……", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("刘捕快：秦家媳妇死在千佛塔里之事，我原本以为定是那琴姬所为，不过今早仵作前去查看，却一口咬定是自杀身亡……", "");
    }
    else
    {
        giTalk("刘捕快：我一直怀疑十八年前陈州前任知府大人灭门惨案和此间布庄有所牵连，然而董师傅似乎只喜欢和年轻女子说话，对我不甚理睬，这事情可真是不好办呐～", "");
    }
    giNpcResetDir("4098");
    giNpcResumeBeh("4098");
    giPlayerUnLock();
}

void func4099()
{
    giPlayerLock();
    giNpcPauseBeh("4099");
    giNpcFaceToCurrentPlayer("4099", true);
    giCurrentPlayerFaceToNpc("4099", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("菊香：别人都说董师傅其实是武林高手，那两把佩刀曾经杀人无数……依我看那些人全都是胡说八道的，董师傅那么和蔼亲切，怎么会杀人？", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("菊香：上个月我还在这儿遇见秦家的丫鬟，说要给少奶奶裁件新衣裳，没想到一转眼那个少奶奶竟然就死了……唉……", "");
    }
    else
    {
        giTalk("菊香：楼下那捕快好可怕，一大早就带着刀冲进布庄，吓得我连大气都不敢出，倒是董师傅一点都不害怕，理都不理那个人～", "");
    }
    giNpcResetDir("4099");
    giNpcResumeBeh("4099");
    giPlayerUnLock();
}

void func4100()
{
    giPlayerLock();
    giNpcPauseBeh("4100");
    giNpcFaceToCurrentPlayer("4100", true);
    giCurrentPlayerFaceToNpc("4100", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("荆丽：董师傅为人热情，眼光独到，裁衣服的手艺也好，上回就是他帮我挑的布、裁的衣裳，穿起来又合身、又漂亮！", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("荆丽：那位姜氏，明明嫁入豪门，就算死了丈夫，公婆对她也还是不错的，却为什么要寻死呢？", "");
    }
    else
    {
        giTalk("荆丽：这里的布每一匹都那么漂亮，摸起来也都那么柔滑，我到底要选哪一匹布来裁新衣裳呢？", "");
    }
    giNpcResetDir("4100");
    giNpcResumeBeh("4100");
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
        giTalk("骆建勋：上次在苏州和吴公子比剑，我虽然险胜一招，但其实我也紧张得要命，一套剑法使得破绽百出，真是惭愧……", "");
    }
    else if (global_mvar >= 51100 /* 第一章 / 3-3-5.弦歌问情 / 下楼找梦璃 */)
    {
        giTalk("骆建勋：琴姬姐姐唱的那首曲子，和爹弹奏的一首曲子真像！可惜近日爹爹出门在外，否则他定然会和琴姬姐姐切磋一番琴艺呢！", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("骆建勋：最近要跟师父去江南拜会一位剑术超群的老前辈，听说这位前辈有一独子，年龄和我相当，剑术也十分厉害……我真想跟他切磋一番！");
        giRandTalkPush("骆建勋：爹爹既精通音律，又喜习剑，我就是常看爹在院中舞剑，才喜欢上剑术的！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4101");
    giNpcResumeBeh("4101");
    giPlayerUnLock();
}

void func5001()
{
    giPlayerLock();
    giNpcPauseBeh("4086");
    giNpcFaceToCurrentPlayer("4086", true);
    giCurrentPlayerFaceToNpc("4086", true);
    giStartTradeSystem("shop002", "");
    giNpcResetDir("4086");
    giNpcResumeBeh("4086");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("4085");
    giNpcFaceToCurrentPlayer("4085", true);
    giCurrentPlayerFaceToNpc("4085", true);
    giStartTradeSystem("shop022", "");
    giNpcResetDir("4085");
    giNpcResumeBeh("4085");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("4084");
    giNpcFaceToCurrentPlayer("4084", true);
    giCurrentPlayerFaceToNpc("4084", true);
    if (var_shop027 != 0)
    {
        if (var_shop027 != 1)
        {
            giStartTradeSystem("shop012", "");
        }
        else
        {
            if (giCheckEquipInInventory(3577))
            {
                giTalk("郑灿英：唉呀呀！真的是银角梳！这、我也不好白拿你的东西，要不然这样，这顶紫阳冠你拿去，当是换梳子的就成！", "");
                giRemoveEquipment(3577, true);
                giWait(2.0);
                giAddEquipment(3563, true);
                giWait(2.0);
                var_shop027 = 2;
            }
            giStartTradeSystem("shop012", "");
        }
    }
    else
    {
        giStartTradeSystem("shop012", "Buiness_Q04_5003");
    }
    giNpcResetDir("4084");
    giNpcResumeBeh("4084");
    giPlayerUnLock();
}

void func5004()
{
    giPlayerLock();
    giNpcPauseBeh("4088");
    giNpcFaceToCurrentPlayer("4088", true);
    giCurrentPlayerFaceToNpc("4088", true);
    giStartTradeSystem("shop033", "");
    giNpcResetDir("4088");
    giNpcResumeBeh("4088");
    giPlayerUnLock();
}

void func5005()
{
    int local_2 = 0;
    int local_3 = 0;
    int local_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4087");
    giNpcFaceToCurrentPlayer("4087", true);
    giCurrentPlayerFaceToNpc("4087", true);
    if (global_mvar != 50300 /* 第一章 / 3-3-2.弦歌问情 / 客栈休息 */)
    {
        giShowInnDialog(false);
        local_4 = giGetInnDialogResult();
        local_2 = giGetMoney();
        if (giGetInnDialogResult() == 1)
        {
            giShowCommonDialogInSelectMode("花费300文钱住宿吗？", 0.5, 0.4);
            local_3 = giCommonDialogGetLastSelect();
            if (giCommonDialogGetLastSelect() == 1)
            {
                if (local_2 >= 300)
                {
                    giFlashOutBlack(3.0, true, true);
                    giPayMoney(300, true);
                    giPlayerTakeARest();
                    giWait(2.0);
                    giFlashInBlack(3.0, true);
                }
                else
                {
                    giTalk("周娟：您身上的钱不够。", "");
                }
            }
        }
        giPlayerSetAttr(-1, -1, 100);
        giNpcResetDir("4087");
        giNpcResumeBeh("4087");
        giPlayerUnLock();
    }
    else
    {
        giShowInnDialog(false);
        local_2 = giGetInnDialogResult();
        local_3 = giGetMoney();
        if (giGetInnDialogResult() != 1)
        {
            giNpcResetDir("4087");
            giNpcResumeBeh("4087");
            giPlayerUnLock();
        }
        else
        {
            giShowCommonDialogInSelectMode("花费300文钱住宿吗？", 0.5, 0.4);
            local_4 = giCommonDialogGetLastSelect();
            if (giCommonDialogGetLastSelect() != 1)
            {
                if (local_4 == 0)
                {
                    giNpcResetDir("4087");
                    giNpcResumeBeh("4087");
                    giPlayerUnLock();
                }
            }
            else if (local_3 >= 300)
            {
                giFlashOutBlack(3.0, true, true);
                giPayMoney(300, false);
                func2003();
            }
            else
            {
                giTalk("周娟：您身上的钱不够。", "");
                giPlayerSetAttr(-1, -1, 100);
                giNpcResetDir("4087");
                giNpcResumeBeh("4087");
                giPlayerUnLock();
            }
        }
    }
}

void Buiness_Q04_5003()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("我那儿子看上了扬州太守的千金，正准备下聘定亲呢！这聘礼也定下了，是一套银器，只不过还缺了一件，如果小哥你能帮我找一把<colour red=255 green=187 blue=0 alpha=255>银角梳</colour><dc0>来，我就能找人下聘去啦！</dc0><br/><dc0>你愿意帮我去找吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        var_shop027 = 1;
    }
}
