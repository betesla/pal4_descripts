// Structured PAL4 reconstruction for Q06.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q06_Q06Q_init()
{
    func7500();
    LL_001(global_mvar);
    if (global_mvar < 101400 && npc_b == 1 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giNpcSetPos("SN001", 7672.3, -1387.9, -8071.3);
        giNpcSetAng("SN001", 74.0);
        giSetNpcVisible("SN001", true);
        giNpcSetPos("SN002", 7734.2, -1387.9, -8051.8);
        giNpcSetAng("SN002", 266.0);
        giSetNpcVisible("SN002", true);
        giSetObjectVisible("Jsound050", true);
    }
    if (global_mvar < 70500 || global_mvar < 90100 && global_mvar >= 70901 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giSetObjectVisible("entrance0", false);
        giSetObjectVisible("entrance1", true);
    }
    else
    {
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance1", false);
    }
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giSetObjectVisible("entrance8", false);
        giSetObjectVisible("entrance6", true);
    }
    else
    {
        giSetObjectVisible("entrance8", true);
        giSetObjectVisible("entrance6", false);
    }
    if (global_mvar == 61300 || global_mvar == 70200 /* 第二章 / 4-3-1.御剑逍遥 / 去弟子房休息 / 初入琼华 */)
    {
        giSetObjectVisible("entrance1", false);
    }
    if (global_mvar < 140100 && global_mvar >= 120800 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giSetObjectVisible("entrance2", false);
    }
    if (global_mvar < 80800 /* 第二章 / 5-3-1.三寒器 / 寻访长老 */)
    {
        giSetObjectVisible("entrance6", false);
    }
    if (global_mvar < 71400 /* 第二章 / 5-1-1.寒剑夜鸣 / 前去禁地 */)
    {
        giSetObjectVisible("entrance7", false);
        giArenaReadyRestore();
    }
    if (global_mvar < 80100 /* 第二章 / 5-1-5.寒剑夜鸣 / 回房睡觉 / 寒剑夜鸣 */)
    {
        giSetObjectVisible("entrance3", false);
    }
    if (global_mvar == 60800 /* 仙山试炼 / 太一仙径 */)
    {
        func2001();
    }
    if (global_mvar == 61300 /* 第二章 / 4-3-1.御剑逍遥 / 去弟子房休息 / 初入琼华 */)
    {
        giSetObjectVisible("entrance2", false);
    }
    if (global_mvar == 70200 /* 第二章 / 4-3-2.御剑逍遥 / 剑舞坪修行 */)
    {
        giIMMBegin();
        giSetNpcVisible("4050", false);
        giSetNpcVisible("4052", false);
        giSetNpcVisible("4019", false);
        giPlayerSetPos(1, 6921.6, -1388.4, -6258.5);
        giPlayerSetAng(1, 5.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, 6964.3, -1388.4, -6226.2);
        giPlayerSetAng(2, 313.0);
        giPlayerSetVisible(2, true);
        giPlayerSetPos(3, 6927.8, -1388.4, -6187.8);
        giPlayerSetAng(3, 191.8477);
        giPlayerSetVisible(3, true);
        giIMMEnd();
    }
    if (global_mvar == 70400 /* 第二章 / 4-3-3.御剑逍遥 / 御剑下山 */)
    {
        giSetNpcVisible("4056", false);
    }
    if (global_mvar == 70500 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giSetNpcVisible("4056", false);
    }
    func2015();
    func2016();
    func2018();
    func2019();
    func2021();
    func2027();
    giArenaReadyRestore();
}

void Q06_QN03_init()
{
    if (global_mvar == 60901 /* 第二章 / 4-1-5.寻仙昆仑 / 入门考验 */)
    {
        giScriptMusicPlay("P26", 2, 0.0, 2.5);
        giIMMBegin();
        giSetNpcVisible("MN001", true);
        giNpcSetAng("MN001", 4.0);
        giIMMEnd();
    }
    if (global_mvar != 61100)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2003();
    }
}

void Q06_Q06QY_init()
{
    func7500();
    if (global_mvar < 80100 /* 第二章 / 5-1-5.寒剑夜鸣 / 回房睡觉 / 寒剑夜鸣 */)
    {
        giSetObjectVisible("entrance3", false);
    }
    if (global_mvar != 80600 || npc_b != 0 /* 第二章 / 5-2-2.心事难明 / 再去禁地 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giNpcSetPos("SN001", 13335.6, -1088.2, -5375.1);
        giNpcSetAng("SN001", 100.0);
        giSetNpcVisible("SN001", true);
        giArenaReadyRestore();
    }
}

void Q06_Q06H_init()
{
    if (global_mvar != 141000)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2028();
    }
}

void Q06_Q06J_init()
{
    if (global_mvar < 120501 /* 第三章 / 7-4-5.仙妖乱 / 追上卷云台 */)
    {
        giSetObjectVisible("Jeffect001", false);
        giSetObjectVisible("MO001", false);
    }
    if (global_mvar >= 120501 /* 第三章 / 7-4-5.仙妖乱 / 追上卷云台 */)
    {
        giEventVolumeVisible("ev_Q06_Q06J_2", false);
    }
    if (global_mvar == 140101 /* 第三章 / 8-3-4.心愿 / 前往妖界 */)
    {
        giSetObjectVisible("entrance2", true);
    }
    if (global_mvar > 120400 || var_shop024 == 1 /* 第三章 / 7-4-2.仙妖乱 / 兄弟话别 */)
    {
        giSetNpcVisible("4022", false);
    }
    if (global_mvar != 120501 /* 第三章 / 7-4-5.仙妖乱 / 追上卷云台 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2025();
    }
}

void Q06_Q06JH_init()
{
    if (global_mvar == 141800 /* 幻瞑界入口 */)
    {
        func2029();
    }
}

void Q06_QN05_init()
{
    if (global_mvar <= 120501 && global_mvar >= 120500 /* 第三章 / 7-4-5.仙妖乱 / 追上卷云台 */)
    {
        giSetNpcVisible("MN003", true);
        giEventVolumeVisible("ev_Q06_QN05_1", false);
        giNpcSetEmotion("MN003", "104_hm");
    }
    if (global_mvar < 120800 && global_mvar >= 70200 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giIMMBegin();
        giSetObjectVisible("MO005", false);
        giSetObjectVisible("MO006", false);
        giSetObjectVisible("effect001", false);
        giIMMEnd();
        giArenaReadyRestore();
    }
}

void LL_001(int arg0)
{
    // typed_typeinfo_hints: primary=void; extras=[int]
    // prototype_hint: void LL_001(int)
    if (global_mvar == 101500 /* 第二章 / 6-5-1.非愿 / 求见掌门 */)
    {
        giSetNpcVisible("4007", false);
        giSetNpcVisible("4008", false);
    }
    if (global_mvar > 110700 /* 第二章 / 7-2-1.相争难休 / 前去长老家 */)
    {
        if (global_mvar < 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
        {
            giSetNpcVisible("4003", false);
            giSetNpcVisible("4015", false);
            giSetNpcVisible("4018", false);
            giSetNpcVisible("4030", false);
            giSetNpcVisible("4036", false);
        }
    }
}

void func1001()
{
    giArenaLoad("Q06", "QN01", "", true);
    giPlayerCurrentSetPos(-35.8, 0.9, 222.6);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(13752.2, -1826.9, -11814.6);
    giPlayerCurrentSetAng(245.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q06", "QN02", "", true);
    giPlayerCurrentSetPos(-22.8, 1.8, 232.9);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(10537.8, -1835.4, -12316.3);
    giPlayerCurrentSetAng(100.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q06", "QN03", "", true);
    giPlayerCurrentSetPos(-0.2, -69.5, 532.5);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    if (global_mvar != 60901 /* 第二章 / 4-1-5.寻仙昆仑 / 入门考验 */)
    {
        giArenaLoad("Q06", "Q06Q", "", true);
        giPlayerCurrentSetPos(11908.7, -1669.7, -10743.2);
        giPlayerCurrentSetAng(170.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 16.0, -69.0, 509.0, true);
        giPlayerSetDir(0, 175.0, true);
        giSetPortrait("101B", true);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>得先去找掌门，通过入门试炼……</colour>", "");
        giPlayerUnLock();
    }
}

void func1007()
{
    giArenaLoad("Q06", "QN04", "", true);
    giPlayerCurrentSetPos(16.4, 0.4, 91.9);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(5530.6, -1383.3, -5928.0);
    giPlayerCurrentSetAng(115.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1009()
{
    if (global_mvar < 70500 || global_mvar >= 101400 || npc_c != 2 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giArenaLoad("Q06", "QN05", "", true);
        giPlayerCurrentSetPos(-56.2, 0.3, 108.9);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(3, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.1, true, true);
        giArenaLoad("Q06", "QN05", "", true);
        func3005();
    }
}

void func1010()
{
    if (global_mvar != 100101 /* 准备动身 */)
    {
        if (global_mvar != 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
        {
            giArenaLoad("Q06", "Q06Q", "", true);
            giPlayerCurrentSetPos(5673.3, -1383.3, -5515.6);
            giPlayerCurrentSetAng(115.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        else
        {
            giFlashOutBlack(1.0, true, true);
            giArenaLoad("Q06", "Q06Q", "", true);
            func2024();
        }
    }
    else
    {
        giArenaLoad("Q06", "Q06Q", "", true);
    }
}

void func1011()
{
    giArenaLoad("Q06", "QN06", "", true);
    giPlayerCurrentSetPos(1.2, 4.6, 116.4);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(6111.8, -1383.3, -4731.7);
    giPlayerCurrentSetAng(115.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("Q06", "QN07", "QN07a", true);
    giPlayerCurrentSetPos(-1.6, 0.6, 120.6);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(6820.9, -1358.2, -4758.0);
    giPlayerCurrentSetAng(204.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("Q06", "QN07", "QN07b", true);
    giPlayerCurrentSetPos(-1.6, 0.6, 120.6);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(8237.0, -1360.6, -5441.0);
    giPlayerCurrentSetAng(204.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1017()
{
    giArenaLoad("Q06", "QN08", "QN08a", true);
    giPlayerCurrentSetPos(-19.1, 0.6, 93.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1018()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(5678.3, -1383.6, -7183.8);
    giPlayerCurrentSetAng(25.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1019()
{
    giArenaLoad("Q06", "QN08", "QN08b", true);
    giPlayerCurrentSetPos(-19.1, 0.6, 93.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1020()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(7812.4, -1383.3, -7794.9);
    giPlayerCurrentSetAng(295.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1021()
{
    giArenaLoad("Q06", "QN08", "QN08c", true);
    giPlayerCurrentSetPos(-19.1, 0.6, 93.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1022()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(7983.0, -1383.3, -7426.7);
    giPlayerCurrentSetAng(294.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1023()
{
    giArenaLoad("Q06", "QN09", "QN09a", true);
    giPlayerCurrentSetPos(1.4, 0.5, 116.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1024()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(8401.7, -1383.3, -6557.1);
    giPlayerCurrentSetAng(292.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1025()
{
    giArenaLoad("Q06", "QN09", "QN09b", true);
    giPlayerCurrentSetPos(1.4, 0.5, 116.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1026()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(8700.3, -1383.3, -5967.9);
    giPlayerCurrentSetAng(293.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1027()
{
    giArenaLoad("Q06", "QN10", "", true);
    giPlayerCurrentSetPos(-5.8, 0.0, 79.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1028()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(7377.1, -1383.3, -8001.5);
    giPlayerCurrentSetAng(25.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1029()
{
    giArenaLoad("Q06", "QN11", "", true);
    giPlayerCurrentSetPos(1.4, 0.7, 129.2);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1030()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(5233.7, -1387.6, -6968.9);
    giPlayerCurrentSetAng(25.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1031()
{
    giArenaLoad("Q06", "QN12", "", true);
    giPlayerCurrentSetPos(158.2, 0.0, 28.9);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1032()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(7015.6, -1383.3, -7848.7);
    giPlayerCurrentSetAng(25.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1033()
{
    giArenaLoad("Q06", "QN13", "", true);
    giPlayerCurrentSetPos(-146.8, 0.5, 121.0);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1034()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(13708.5, -1025.9, -5990.0);
    giPlayerCurrentSetAng(53.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1035()
{
    giArenaLoad("Q06", "QN13", "", true);
    giPlayerCurrentSetPos(120.2, 0.5, 122.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1036()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(13922.8, -1025.9, -6311.9);
    giPlayerCurrentSetAng(55.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1037()
{
    giArenaLoad("Q06", "QN14", "", true);
    giPlayerCurrentSetPos(-146.8, 0.5, 121.0);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1038()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(15962.1, -1025.9, -7091.0);
    giPlayerCurrentSetAng(345.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1039()
{
    giArenaLoad("Q06", "QN14", "", true);
    giPlayerCurrentSetPos(120.2, 0.5, 122.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1040()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(16324.8, -1025.9, -6985.9);
    giPlayerCurrentSetAng(345.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1041()
{
    giArenaLoad("Q06", "QN15", "", true);
    giPlayerCurrentSetPos(-146.8, 0.5, 121.0);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1042()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(17593.4, -1025.9, -5495.2);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1043()
{
    giArenaLoad("Q06", "QN15", "", true);
    giPlayerCurrentSetPos(120.2, 0.5, 122.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1044()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(17596.6, -1025.9, -5117.3);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1045()
{
    giArenaLoad("Q06", "QN16", "", true);
    giPlayerCurrentSetPos(-146.8, 0.5, 121.0);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1046()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(16475.3, -1025.9, -3265.5);
    giPlayerCurrentSetAng(263.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1047()
{
    giArenaLoad("Q06", "QN16", "", true);
    giPlayerCurrentSetPos(120.2, 0.5, 122.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1048()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(16111.2, -1025.9, -3129.9);
    giPlayerCurrentSetAng(144.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1049()
{
    giArenaLoad("Q06", "QN17", "", true);
    giPlayerCurrentSetPos(-146.8, 0.5, 121.0);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1050()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(14092.4, -1025.9, -3754.3);
    giPlayerCurrentSetAng(132.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1051()
{
    giArenaLoad("Q06", "QN17", "", true);
    giPlayerCurrentSetPos(120.2, 0.5, 122.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1052()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(13851.7, -1025.9, -4054.1);
    giPlayerCurrentSetAng(128.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1053()
{
    giArenaLoad("Q06", "QN18", "", true);
    giPlayerCurrentSetPos(-234.3, 0.0, 1.6);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1054()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(25991.2, -1300.6, 1411.5);
    giPlayerCurrentSetAng(22.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1055()
{
    giArenaLoad("Q06", "QN19", "", true);
    giPlayerCurrentSetPos(-31.4, 0.0, 159.5);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1056()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(24399.6, -1514.4, 2597.3);
    giPlayerCurrentSetAng(133.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1057()
{
}

void func1058()
{
}

void func1059()
{
    giArenaLoad("Q06", "QN20", "", true);
    giPlayerCurrentSetPos(-40.8, 0.1, 111.2);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1060()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(26412.5, -1514.4, -879.7);
    giPlayerCurrentSetAng(346.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1061()
{
    giArenaLoad("Q06", "QN21", "", true);
    giPlayerCurrentSetPos(-231.3, 0.1, -2.2);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1062()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(27796.3, -1453.4, 1081.0);
    giPlayerCurrentSetAng(272.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1063()
{
    giArenaLoad("Q06", "QN22", "", true);
    giPlayerCurrentSetPos(0.2, -19.9, 258.2);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1064()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(26723.1, -1424.6, 3110.1);
    giPlayerCurrentSetAng(205.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1065()
{
    if (global_mvar != 61300 /* 第二章 / 4-3-1.御剑逍遥 / 去弟子房休息 / 初入琼华 */)
    {
        if (global_mvar != 120501 /* 第三章 / 7-4-5.仙妖乱 / 追上卷云台 */)
        {
            if (global_mvar < 120800 || global_mvar >= 140100 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
            {
                giArenaLoad("Q06", "Q06J", "", true);
                giPlayerCurrentSetPos(426.5, -0.7, -9.5);
                giPlayerCurrentSetAng(270.0);
                giCameraSetMode(0, true);
                giArenaReady();
            }
            else
            {
                giPlayerLock();
                giPlayerWalkTo(0, 4516.9, -1383.2, -6230.3, true);
                giPlayerSetDir(0, 91.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giSetPortrait("101G", true);
                giTalk("云天河：现在……不是去卷云台的时候……", "");
                giPlayerUnLock();
            }
        }
        else
        {
            giArenaLoad("Q06", "Q06J", "", true);
        }
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 4516.9, -1383.2, -6230.3, true);
        giPlayerSetDir(0, 91.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101C", true);
        giTalk("云天河：师叔让我们<colour red=255 green=187 blue=0 alpha=255>去前山的弟子房休息</colour><dc0>，好像不是这边……</dc0>", "");
        giPlayerUnLock();
    }
}

void func1066()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(4567.7, -1383.7, -6239.6);
    giPlayerCurrentSetAng(92.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1067()
{
    if (global_mvar >= 80100 /* 第二章 / 5-1-5.寒剑夜鸣 / 回房睡觉 / 寒剑夜鸣 */)
    {
        giArenaLoad("Q06", "Q06S", "", true);
        giPlayerCurrentSetPos(880.4, 1.3, -55.3);
        giPlayerCurrentSetAng(283.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else if (global_mvar >= 70200 /* 第二章 / 4-3-2.御剑逍遥 / 剑舞坪修行 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 8934.7, -1383.5, 526.1, true);
        giPlayerSetDir(0, 165.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("102A", true);
        giTalk("云天河：不晓得那边是什么地方，先别过去了……", "");
        giPlayerUnLock();
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 8934.7, -1383.5, 526.1, true);
        giPlayerSetDir(0, 165.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101A", true);
        giTalk("云天河：不晓得那边是什么地方，先别过去了……", "");
        giPlayerUnLock();
    }
}

void func1068()
{
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerCurrentSetPos(8950.5, -1383.8, 441.3);
    giPlayerCurrentSetAng(165.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1069()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 70500 || global_mvar < 90100 && global_mvar >= 70901 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        giArenaLoad("M09", "3", "", true);
        giPlayerCurrentSetPos(-1458.6, 1122.8, 2866.8);
        giPlayerCurrentSetAng(177.0);
        giCameraSetMode(0, true);
        giArenaReady();
        if (global_mvar == 81100 /* 寻访长老 */)
        {
            giPlayerLock();
            giShowTutorial(22);
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去太一仙径");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog(" 准备<colour red=255 green=102 blue=0 alpha=255>去太一仙径</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, 12676.8, -2022.7, -15857.9, true);
                giPlayerSetDir(leader_player_id, 352.0, true);
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
            giArenaLoad("M09", "3", "", true);
            giPlayerCurrentSetPos(-1458.6, 1122.8, 2866.8);
            giPlayerCurrentSetAng(177.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1070()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        if (global_mvar >= 80800 /* 第二章 / 5-3-1.三寒器 / 寻访长老 */)
        {
            giArenaLoad("M12", "1", "", true);
            giPlayerCurrentSetPos(3402.7, 284.0, 1569.3);
            giPlayerCurrentSetAng(298.0);
            giCameraSetMode(5, true);
            giArenaReady();
            if (global_mvar == 81100 /* 寻访长老 */)
            {
                giPlayerLock();
                giShowTutorial(22);
                giPlayerUnLock();
            }
        }
        else
        {
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, 19944.2, -1085.3, -1745.7, true);
            giPlayerSetDir(0, 142.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("102A", true);
            giTalk("云天河：不晓得那边是什么地方，先别过去了……", "");
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去醉花荫  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去醉花荫</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, 19971.6, -1085.0, -1784.5, true);
                giPlayerSetDir(leader_player_id, 144.0, true);
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
            giArenaLoad("M12", "1", "", true);
            giPlayerCurrentSetPos(3402.7, 284.0, 1569.3);
            giPlayerCurrentSetAng(298.0);
            giCameraSetMode(5, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1071()
{
    if (global_mvar >= 71400 /* 第二章 / 5-1-1.寒剑夜鸣 / 前去禁地 */)
    {
            giArenaLoad("M20", "1", "", true);
            giPlayerCurrentSetPos(767.6, 5.2, -462.9);
            giPlayerCurrentSetAng(293.0);
            giCameraSetMode(5, true);
            giArenaReady();
            if (global_mvar == 81100 /* 寻访长老 */)
            {
                giPlayerLock();
                giShowTutorial(22);
                giPlayerUnLock();
            }
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 14970.9, 127.9, -2712.8, true);
        giPlayerSetDir(0, 154.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("102A", true);
        giTalk("云天河：不晓得那边是什么地方，先别过去了……", "");
        giPlayerUnLock();
    }
}

void func1072()
{
    if (global_mvar < 71600 || global_mvar == 71900 || global_mvar == 72200 || global_mvar > 80700 /* 前去禁地 */)
    {
        switch (global_mvar)
        {
            case 71900:
                giArenaLoad("M20", "1Y", "", true);
                giPlayerCurrentSetPos(-254.1, 4.4, 1622.7);
                giPlayerCurrentSetAng(144.1639);
                giCameraSetMode(5, true);
                giArenaReady();
                break;
            case 72200:
                giArenaLoad("M20", "1Y", "", true);
                break;
            case 91400:
                giArenaLoad("M20", "1", "", true);
                break;
            default:
                giArenaLoad("M20", "1", "", true);
                giPlayerCurrentSetPos(-225.6, 3.2, 1634.9);
                giPlayerCurrentSetAng(200.0);
                giCameraSetMode(5, true);
                giArenaReady();
                break;
        }
    }
    else
    {
        giArenaLoad("M20", "1Y", "", true);
        giPlayerCurrentSetPos(-225.6, 3.2, 1634.9);
        giPlayerCurrentSetAng(200.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1073()
{
    giArenaLoad("Q06", "QN12Y", "", true);
    giPlayerCurrentSetPos(158.2, 0.0, 28.9);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1074()
{
    giArenaLoad("Q06", "Q06QY", "", true);
    giPlayerCurrentSetPos(7015.6, -1383.3, -7848.7);
    giPlayerCurrentSetAng(25.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1075()
{
    giArenaLoad("Q06", "QN11Y", "", true);
    giPlayerCurrentSetPos(1.4, 0.7, 129.2);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1076()
{
    giArenaLoad("Q06", "Q06QY", "", true);
    giPlayerCurrentSetPos(5233.7, -1387.6, -6968.9);
    giPlayerCurrentSetAng(25.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1077()
{
    giArenaLoad("Q06", "QN05Y", "", true);
    giPlayerCurrentSetPos(-56.2, 0.3, 108.9);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1078()
{
    giArenaLoad("Q06", "Q06QY", "", true);
    giPlayerCurrentSetPos(5673.3, -1383.3, -5515.6);
    giPlayerCurrentSetAng(115.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1079()
{
    giArenaLoad("M20", "1Y", "", true);
    giPlayerCurrentSetPos(767.6, 5.2, -462.9);
    giPlayerCurrentSetAng(293.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1080()
{
    if (global_mvar >= 80100 /* 第二章 / 5-1-5.寒剑夜鸣 / 回房睡觉 / 寒剑夜鸣 */)
    {
        giArenaLoad("Q06", "Q06SY", "", true);
        giPlayerCurrentSetPos(880.4, 1.3, -55.3);
        giPlayerCurrentSetAng(283.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 8934.7, -1383.5, 526.1, true);
        giPlayerSetDir(0, 165.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("102C", true);
        giTalk("云天河：没什么事要去那边啊……", "");
        giPlayerUnLock();
    }
}

void func1081()
{
    if (global_mvar != 80400 /* 第二章 / 5-2-1.心事难明 / 思过结束 */)
    {
        giArenaLoad("Q06", "Q06QY", "", true);
        giPlayerCurrentSetPos(8950.5, -1383.8, 441.3);
        giPlayerCurrentSetAng(165.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giArenaLoad("Q06", "Q06QY", "", true);
        func2012();
    }
}

void func1082()
{
    if (global_mvar != 71400 /* 第二章 / 5-1-1.寒剑夜鸣 / 前去禁地 */)
    {
        giArenaLoad("M20", "1Y", "", true);
        giPlayerCurrentSetPos(767.6, 5.2, -462.9);
        giPlayerCurrentSetAng(293.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("M20", "1Y", "", true);
    }
}

void func1083()
{
    int local_2 = 0;
    int local_3 = 0;

    if (global_mvar != 61300 /* 第二章 / 4-3-1.御剑逍遥 / 去弟子房休息 / 初入琼华 */)
    {
        giPlayerLock();
        giSelectDialogAddItem("1.剑舞坪    ");
        giSelectDialogAddItem("2.五灵剑阁  ");
        giSelectDialogAddItem("3.承天剑台  ");
        giSelectDialogAddItem("4.太一宫    ");
        giSelectDialogAddItem("5.什么都不做");
        giSelectDialogSetDefaultSelect(4);
        giShowSelectDialog("        这里是<colour red=255 green=102 blue=0 alpha=255>山门</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
        local_2 = giSelectDialogGetLastSelect();
        if (local_2 != 0)
        {
            switch (local_2)
            {
                case 1:
                    giEffectPlayWithCurrentPlayer("H_121", 1);
                    gi2DSoundPlay("wc005", 1);
                    local_3 = giPlayerGetLeader();
                    giPlayerBlendOut(local_3, 0.5, false);
                    giWait(0.3);
                    giFlashOutBlack(0.65, true, true);
                    giWait(0.5);
                    giPlayerCurrentSetPos(15320.6, -1088.7, -2787.8);
                    giPlayerCurrentSetAng(155.0);
                    func7500();
                    giArenaReady();
                    giCameraSetMode(0, true);
                    giFlushTailYAngle();
                    giFlashInBlack(0.65, false);
                    giWait(0.15);
                    giEffectPlayWithCurrentPlayer("H_122", 1);
                    gi2DSoundPlay("wc006", 1);
                    giWait(0.3);
                    giPlayerBlendIn(local_3, 0.5, false);
                    giPlayerUnLock();
                    break;
                case 2:
                    giEffectPlayWithCurrentPlayer("H_121", 1);
                    gi2DSoundPlay("wc005", 1);
                    local_3 = giPlayerGetLeader();
                    giPlayerBlendOut(local_3, 0.5, false);
                    giWait(0.3);
                    giFlashOutBlack(0.65, true, true);
                    giWait(0.5);
                    giPlayerCurrentSetPos(14958.6, 283.0, -5306.5);
                    giPlayerCurrentSetAng(155.0);
                    func7500();
                    giArenaReady();
                    giCameraSetMode(0, true);
                    giFlushTailYAngle();
                    giFlashInBlack(0.65, false);
                    giWait(0.15);
                    giEffectPlayWithCurrentPlayer("H_122", 1);
                    gi2DSoundPlay("wc006", 1);
                    giWait(0.3);
                    giPlayerBlendIn(local_3, 0.5, false);
                    giPlayerUnLock();
                    break;
                case 3:
                    giEffectPlayWithCurrentPlayer("H_121", 1);
                    gi2DSoundPlay("wc005", 1);
                    local_3 = giPlayerGetLeader();
                    giPlayerBlendOut(local_3, 0.5, false);
                    giWait(0.3);
                    giFlashOutBlack(0.65, true, true);
                    giWait(0.5);
                    giPlayerCurrentSetPos(23971.6, -1515.0, -176.5);
                    giPlayerCurrentSetAng(280.0);
                    func7500();
                    giArenaReady();
                    giCameraSetMode(0, true);
                    giFlushTailYAngle();
                    giFlashInBlack(0.65, false);
                    giWait(0.15);
                    giEffectPlayWithCurrentPlayer("H_122", 1);
                    gi2DSoundPlay("wc006", 1);
                    giWait(0.3);
                    giPlayerBlendIn(local_3, 0.5, false);
                    giPlayerUnLock();
                    break;
                default:
                    local_3 = giPlayerGetLeader();
                    giPlayerWalkTo(local_3, 10076.6, -1841.0, -13010.5, true);
                    giPlayerSetDir(local_3, 150.0, true);
                    giCameraAutoSeek(true);
                    giCameraSetMode(0, true);
                    giPlayerUnLock();
                    break;
            }
        }
        else
        {
            giEffectPlayWithCurrentPlayer("H_121", 1);
            gi2DSoundPlay("wc005", 1);
            local_3 = giPlayerGetLeader();
            giPlayerBlendOut(local_3, 0.5, false);
            giWait(0.3);
            giFlashOutBlack(0.65, true, true);
            giWait(0.5);
            giPlayerCurrentSetPos(6085.6, -1387.7, -7309.8);
            giPlayerCurrentSetAng(25.0);
            func7500();
            giArenaReady();
            giCameraSetMode(0, true);
            giFlushTailYAngle();
            giFlashInBlack(0.65, false);
            giWait(0.15);
            giEffectPlayWithCurrentPlayer("H_122", 1);
            gi2DSoundPlay("wc006", 1);
            giWait(0.3);
            giPlayerBlendIn(local_3, 0.5, false);
            giPlayerUnLock();
        }
        giPlayerUnLock();
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.剑舞坪    ");
        giSelectDialogAddItem("2.什么都不做");
        giSelectDialogSetDefaultSelect(1);
        giShowSelectDialog("        这里是<colour red=255 green=102 blue=0 alpha=255>山门</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
        local_2 = giSelectDialogGetLastSelect();
        if (local_2 != 0)
        {
            local_3 = giPlayerGetLeader();
            giPlayerWalkTo(local_3, 10076.6, -1841.0, -13010.5, true);
            giPlayerSetDir(local_3, 150.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giPlayerUnLock();
        }
        else
        {
            giEffectPlayWithCurrentPlayer("H_121", 1);
            gi2DSoundPlay("wc005", 1);
            local_3 = giPlayerGetLeader();
            giPlayerBlendOut(local_3, 0.5, false);
            giWait(0.3);
            giFlashOutBlack(0.65, true, true);
            giWait(0.5);
            giPlayerCurrentSetPos(6085.6, -1387.7, -7309.8);
            giPlayerCurrentSetAng(25.0);
            giArenaReady();
            giCameraSetMode(0, true);
            giFlushTailYAngle();
            giFlashInBlack(0.65, false);
            giWait(0.15);
            giEffectPlayWithCurrentPlayer("H_122", 1);
            gi2DSoundPlay("wc006", 1);
            giWait(0.3);
            giPlayerBlendIn(local_3, 0.5, false);
            giPlayerUnLock();
        }
        giPlayerUnLock();
    }
}

void func1084()
{
    int local_2 = 0;
    int local_3 = 0;

    if (global_mvar != 61300 /* 第二章 / 4-3-1.御剑逍遥 / 去弟子房休息 / 初入琼华 */)
    {
        giPlayerLock();
        giSelectDialogAddItem("1.山门      ");
        giSelectDialogAddItem("2.五灵剑阁  ");
        giSelectDialogAddItem("3.承天剑台  ");
        giSelectDialogAddItem("4.太一宫    ");
        giSelectDialogAddItem("5.什么都不做");
        giSelectDialogSetDefaultSelect(4);
        giShowSelectDialog("      这里是<colour red=255 green=102 blue=0 alpha=255>剑舞坪</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
        local_2 = giSelectDialogGetLastSelect();
        if (local_2 != 0)
        {
            switch (local_2)
            {
                case 1:
                    giEffectPlayWithCurrentPlayer("H_121", 1);
                    gi2DSoundPlay("wc005", 1);
                    local_3 = giPlayerGetLeader();
                    giPlayerBlendOut(local_3, 0.5, false);
                    giWait(0.3);
                    giFlashOutBlack(0.65, true, true);
                    giWait(0.5);
                    giPlayerCurrentSetPos(15320.6, -1088.7, -2787.8);
                    giPlayerCurrentSetAng(155.0);
                    func7500();
                    giArenaReady();
                    giCameraSetMode(0, true);
                    giFlushTailYAngle();
                    giFlashInBlack(0.65, false);
                    giWait(0.15);
                    giEffectPlayWithCurrentPlayer("H_122", 1);
                    gi2DSoundPlay("wc006", 1);
                    giWait(0.3);
                    giPlayerBlendIn(local_3, 0.5, false);
                    giPlayerUnLock();
                    break;
                case 2:
                    giEffectPlayWithCurrentPlayer("H_121", 1);
                    gi2DSoundPlay("wc005", 1);
                    local_3 = giPlayerGetLeader();
                    giPlayerBlendOut(local_3, 0.5, false);
                    giWait(0.3);
                    giFlashOutBlack(0.65, true, true);
                    giWait(0.5);
                    giPlayerCurrentSetPos(14958.6, 283.0, -5306.5);
                    giPlayerCurrentSetAng(155.0);
                    func7500();
                    giArenaReady();
                    giCameraSetMode(0, true);
                    giFlushTailYAngle();
                    giFlashInBlack(0.65, false);
                    giWait(0.15);
                    giEffectPlayWithCurrentPlayer("H_122", 1);
                    gi2DSoundPlay("wc006", 1);
                    giWait(0.3);
                    giPlayerBlendIn(local_3, 0.5, false);
                    giPlayerUnLock();
                    break;
                case 3:
                    giEffectPlayWithCurrentPlayer("H_121", 1);
                    gi2DSoundPlay("wc005", 1);
                    local_3 = giPlayerGetLeader();
                    giPlayerBlendOut(local_3, 0.5, false);
                    giWait(0.3);
                    giFlashOutBlack(0.65, true, true);
                    giWait(0.5);
                    giPlayerCurrentSetPos(23971.6, -1515.0, -176.5);
                    giPlayerCurrentSetAng(280.0);
                    func7500();
                    giArenaReady();
                    giCameraSetMode(0, true);
                    giFlushTailYAngle();
                    giFlashInBlack(0.65, false);
                    giWait(0.15);
                    giEffectPlayWithCurrentPlayer("H_122", 1);
                    gi2DSoundPlay("wc006", 1);
                    giWait(0.3);
                    giPlayerBlendIn(local_3, 0.5, false);
                    giPlayerUnLock();
                    break;
                default:
                    local_3 = giPlayerGetLeader();
                    giPlayerWalkTo(local_3, 6085.6, -1387.7, -7309.8, true);
                    giPlayerSetDir(local_3, 25.0, true);
                    giCameraAutoSeek(true);
                    giCameraSetMode(0, true);
                    giPlayerUnLock();
                    break;
            }
        }
        else
        {
            giEffectPlayWithCurrentPlayer("H_121", 1);
            gi2DSoundPlay("wc005", 1);
            local_3 = giPlayerGetLeader();
            giPlayerBlendOut(local_3, 0.5, false);
            giWait(0.3);
            giFlashOutBlack(0.65, true, true);
            giWait(0.5);
            giPlayerCurrentSetPos(10076.6, -1841.0, -13010.5);
            giPlayerCurrentSetAng(150.0);
            func7500();
            giArenaReady();
            giCameraSetMode(0, true);
            giFlushTailYAngle();
            giFlashInBlack(0.65, false);
            giWait(0.15);
            giEffectPlayWithCurrentPlayer("H_122", 1);
            gi2DSoundPlay("wc006", 1);
            giWait(0.3);
            giPlayerBlendIn(local_3, 0.5, false);
            giPlayerUnLock();
        }
        giPlayerUnLock();
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.山门      ");
        giSelectDialogAddItem("2.什么都不做");
        giSelectDialogSetDefaultSelect(1);
        giShowSelectDialog("      这里是<colour red=255 green=102 blue=0 alpha=255>剑舞坪</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
        local_2 = giSelectDialogGetLastSelect();
        if (local_2 != 0)
        {
            local_3 = giPlayerGetLeader();
            giPlayerWalkTo(local_3, 6085.6, -1387.7, -7309.8, true);
            giPlayerSetDir(local_3, 25.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giPlayerUnLock();
        }
        else
        {
            giEffectPlayWithCurrentPlayer("H_121", 1);
            gi2DSoundPlay("wc005", 1);
            local_3 = giPlayerGetLeader();
            giPlayerBlendOut(local_3, 0.5, false);
            giWait(0.3);
            giFlashOutBlack(0.65, true, true);
            giWait(0.5);
            giPlayerCurrentSetPos(10076.6, -1841.0, -13010.5);
            giPlayerCurrentSetAng(150.0);
            func7500();
            giArenaReady();
            giCameraSetMode(0, true);
            giFlushTailYAngle();
            giFlashInBlack(0.65, false);
            giWait(0.15);
            giEffectPlayWithCurrentPlayer("H_122", 1);
            gi2DSoundPlay("wc006", 1);
            giWait(0.3);
            giPlayerBlendIn(local_3, 0.5, false);
            giPlayerUnLock();
        }
        giPlayerUnLock();
    }
}

void func1085()
{
    int select_dialog_last_select = 0;
    int local_3 = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.山门      ");
    giSelectDialogAddItem("2.剑舞坪    ");
    giSelectDialogAddItem("3.承天剑台  ");
    giSelectDialogAddItem("4.太一宫    ");
    giSelectDialogAddItem("5.什么都不做");
    giSelectDialogSetDefaultSelect(4);
    giShowSelectDialog("  这里是<colour red=255 green=102 blue=0 alpha=255>五灵剑阁</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        switch (select_dialog_last_select)
        {
            case 1:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(6085.6, -1387.7, -7309.8);
                giPlayerCurrentSetAng(25.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 2:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(14961.6, 282.7, -5318.8);
                giPlayerCurrentSetAng(155.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 3:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(23971.6, -1515.0, -176.5);
                giPlayerCurrentSetAng(280.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            default:
                local_3 = giPlayerGetLeader();
                giPlayerWalkTo(local_3, 15320.6, -1088.7, -2787.8, true);
                giPlayerSetDir(local_3, 155.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
                break;
        }
    }
    else
    {
        giEffectPlayWithCurrentPlayer("H_121", 1);
        gi2DSoundPlay("wc005", 1);
        local_3 = giPlayerGetLeader();
        giPlayerBlendOut(local_3, 0.5, false);
        giWait(0.3);
        giFlashOutBlack(0.65, true, true);
        giWait(0.5);
        giPlayerCurrentSetPos(10076.6, -1841.0, -13010.5);
        giPlayerCurrentSetAng(150.0);
        func7500();
        giArenaReady();
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giFlashInBlack(0.65, false);
        giWait(0.15);
        giEffectPlayWithCurrentPlayer("H_122", 1);
        gi2DSoundPlay("wc006", 1);
        giWait(0.3);
        giPlayerBlendIn(local_3, 0.5, false);
        giPlayerUnLock();
    }
    giPlayerUnLock();
}

void func1086()
{
    int select_dialog_last_select = 0;
    int local_3 = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.山门      ");
    giSelectDialogAddItem("2.剑舞坪    ");
    giSelectDialogAddItem("3.五灵剑阁  ");
    giSelectDialogAddItem("4.太一宫    ");
    giSelectDialogAddItem("5.什么都不做");
    giSelectDialogSetDefaultSelect(4);
    giShowSelectDialog("  这里是<colour red=255 green=102 blue=0 alpha=255>承天剑台</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        switch (select_dialog_last_select)
        {
            case 1:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(6085.6, -1387.7, -7309.8);
                giPlayerCurrentSetAng(25.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 2:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(15320.6, -1088.7, -2787.8);
                giPlayerCurrentSetAng(155.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 3:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(23971.6, -1515.0, -176.5);
                giPlayerCurrentSetAng(280.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            default:
                local_3 = giPlayerGetLeader();
                giPlayerWalkTo(local_3, 14958.6, 283.0, -5306.5, true);
                giPlayerSetDir(local_3, 155.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
                break;
        }
    }
    else
    {
        giEffectPlayWithCurrentPlayer("H_121", 1);
        gi2DSoundPlay("wc005", 1);
        local_3 = giPlayerGetLeader();
        giPlayerBlendOut(local_3, 0.5, false);
        giWait(0.3);
        giFlashOutBlack(0.65, true, true);
        giWait(0.5);
        giPlayerCurrentSetPos(10076.6, -1841.0, -13010.5);
        giPlayerCurrentSetAng(150.0);
        func7500();
        giArenaReady();
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giFlashInBlack(0.65, false);
        giWait(0.15);
        giEffectPlayWithCurrentPlayer("H_122", 1);
        gi2DSoundPlay("wc006", 1);
        giWait(0.3);
        giPlayerBlendIn(local_3, 0.5, false);
        giPlayerUnLock();
    }
    giPlayerUnLock();
}

void func1087()
{
    int select_dialog_last_select = 0;
    int local_3 = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.山门      ");
    giSelectDialogAddItem("2.剑舞坪    ");
    giSelectDialogAddItem("3.五灵剑阁  ");
    giSelectDialogAddItem("4.承天剑台  ");
    giSelectDialogAddItem("5.什么都不做");
    giSelectDialogSetDefaultSelect(4);
    giShowSelectDialog("      这里是<colour red=255 green=102 blue=0 alpha=255>太一宫</colour><dc0>，准备</dc0><colour red=255 green=102 blue=0 alpha=255>去哪</colour><dc0>？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        switch (select_dialog_last_select)
        {
            case 1:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(6085.6, -1387.7, -7309.8);
                giPlayerCurrentSetAng(25.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 2:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(15320.6, -1088.7, -2787.8);
                giPlayerCurrentSetAng(155.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            case 3:
                giEffectPlayWithCurrentPlayer("H_121", 1);
                gi2DSoundPlay("wc005", 1);
                local_3 = giPlayerGetLeader();
                giPlayerBlendOut(local_3, 0.5, false);
                giWait(0.3);
                giFlashOutBlack(0.65, true, true);
                giWait(0.5);
                giPlayerCurrentSetPos(14958.6, 283.0, -5306.5);
                giPlayerCurrentSetAng(155.0);
                func7500();
                giArenaReady();
                giCameraSetMode(0, true);
                giFlushTailYAngle();
                giFlashInBlack(0.65, false);
                giWait(0.15);
                giEffectPlayWithCurrentPlayer("H_122", 1);
                gi2DSoundPlay("wc006", 1);
                giWait(0.3);
                giPlayerBlendIn(local_3, 0.5, false);
                giPlayerUnLock();
                break;
            default:
                local_3 = giPlayerGetLeader();
                giPlayerWalkTo(local_3, 23971.6, -1515.0, -176.5, true);
                giPlayerSetDir(local_3, 280.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
                break;
        }
    }
    else
    {
        giEffectPlayWithCurrentPlayer("H_121", 1);
        gi2DSoundPlay("wc005", 1);
        local_3 = giPlayerGetLeader();
        giPlayerBlendOut(local_3, 0.5, false);
        giWait(0.3);
        giFlashOutBlack(0.65, true, true);
        giWait(0.5);
        giPlayerCurrentSetPos(10076.6, -1841.0, -13010.5);
        giPlayerCurrentSetAng(150.0);
        func7500();
        giArenaReady();
        giCameraSetMode(0, true);
        giFlushTailYAngle();
        giFlashInBlack(0.65, false);
        giWait(0.15);
        giEffectPlayWithCurrentPlayer("H_122", 1);
        gi2DSoundPlay("wc006", 1);
        giWait(0.3);
        giPlayerBlendIn(local_3, 0.5, false);
        giPlayerUnLock();
    }
    giPlayerUnLock();
}

void func2001()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, 12538.8, -2023.0, -15172.6);
    giPlayerSetAng(0, 349.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 12506.6, -2023.0, -15223.1);
    giPlayerSetAng(1, 8.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, 12596.8, -2023.0, -15224.1);
    giPlayerSetAng(2, 342.0);
    giPlayerSetVisible(2, true);
    giSetObjectVisible("sound020", false);
    giSetObjectVisible("sound018", false);
    giSetObjectVisible("sound016", false);
    giSetObjectVisible("sound017", false);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giGrantSmithSystem(true, true, true, true);
    giFlashInBlack(2.5, false);
    giArenaReady();
    giWait(1.2);
    giCameraRunSingle("002", true);
    giWait(1.0);
    giCameraRunSingle("003", true);
    giWait(1.0);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：不愧是仙山，连大门也特别气派～", "42424");
    giSetPortrait("101D", true);
    giTalk("云天河：…………", "42425");
    giSetPortrait("103B", false);
    giTalk("韩菱纱：（可怜的野人，没见过这样的气派景象，看傻了都。）", "42426");
    giSetPortrait("101K", true);
    giTalk("云天河：走！哈哈，我们快进去看看里面啥样！", "42427");
    giPlayerRunTo(0, 12498.7, -1955.8, -14941.1, false);
    giWait(0.6);
    giFlashOutBlack(1.2, true, true);
    giIMMBegin();
    giPlayerSetPos(0, 12471.4, -1855.3, -14700.1);
    giPlayerSetAng(0, 307.0);
    giPlayerSetPos(1, 12430.3, -1855.8, -14699.3);
    giPlayerSetAng(1, 338.0);
    giPlayerSetPos(2, 12532.0, -1869.6, -14715.0);
    giPlayerSetAng(2, 308.0);
    giNpcSetPos("4056", 12444.0, -1831.5, -14604.4);
    giNpcSetAng("4056", 154.0);
    giNpcSetPos("4055", 12376.6, -1831.5, -14634.8);
    giNpcSetAng("4055", 124.0);
    giIMMEnd();
    giCameraRunSingle("006", true);
    giCameraSetDistOptEnable(false);
    giFlashInBlack(1.2, true);
    giWait(0.3);
    giTalk("明光：请留步！非本门弟子不得入内！", "42428");
    giPlayerDoAction(2, "J07", 1, false);
    giSetPortrait("106A", true);
    giTalk("柳梦璃：我们是来拜师的，能不能劳驾通禀一声？", "42429");
    giTalk("明光：掌门有令，近日派中诸事甚多，无暇他顾。各位请回吧！", "42430");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：哎？不会吧？我们好辛苦才爬上来的…… ", "42431");
    giTalk("明尘：若不愿下山，可先在太一仙径白灏道盘桓数日——", "42432");
    giSetPortrait("103C", true);
    giTalk("韩菱纱：数日到底是几日啊？", "42433");
    giTalk("明尘：这……我们也是奉命行事，请姑娘莫要为难。", "42434");
    giNpcSetDir("4056", 235.0, true);
    giTalk("明光：师弟，不必跟他们多说！", "42435");
    giNpcSetDir("4055", 61.0, true);
    giTalk("明尘：是……", "42436");
    giFlashOutBlack(1.6, true, true);
    giCameraSetDistOptEnable(true);
    giIMMBegin();
    giPlayerSetPos(0, 12553.9, -2023.0, -15343.3);
    giPlayerSetAng(0, 267.0);
    giPlayerSetPos(1, 12499.2, -2023.0, -15345.3);
    giPlayerSetAng(1, 81.0);
    giPlayerSetPos(2, 12524.3, -2023.0, -15295.9);
    giPlayerSetAng(2, 210.0);
    giNpcSetPos("4056", 12580.4, -1831.6, -14595.5);
    giNpcSetAng("4056", 259.0);
    giNpcSetPos("4055", 12373.3, -1831.5, -14623.7);
    giNpcSetAng("4055", 80.0);
    giIMMEnd();
    giCameraRunSingle("007", true);
    giFlashInBlack(1.5, true);
    giWait(0.6);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：这也太倒霉了吧？那两个门神遮遮掩掩，又不讲清楚，满口推托的话。", "42437");
    giPlayerDoAction(2, "C09", 1, false);
    giSetPortrait("106A", true);
    giTalk("柳梦璃：我看他们神情肃穆，举止也很戒备，或许门派里真的有什么事……", "42438");
    giPlayerDoAction(0, "J15", 0, false);
    giSetPortrait("101E", false);
    giTalk("云天河：现在怎么办？不会要下山吧？", "42439");
    giPlayerEndAction(0);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：来都来了，我可不甘心！", "42440");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：嘻～不如我们先偷溜进去瞧瞧。", "42441");
    giPlayerEndAction(1);
    gi2DSoundPlay("WJ079", 1);
    giWait(2.0);
    giIMMBegin();
    giPlayerSetDir(1, 8.0, false);
    giPlayerSetDir(0, 335.0, false);
    giPlayerSetDir(2, 353.0, false);
    giIMMEnd();
    giWait(0.8);
    giSetNpcVisible("MN001", true);
    giCameraRunSingle("008", false);
    giWait(1.5);
    giPlayerDoAction(1, "J05", 1, false);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：啊！我、我说要溜进去，只是说说而已，还什么都没做呢！", "42442");
    giTalk("虚邑：…………", "42443");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：……咳，我的意思是，这位道长有何指教？", "42444");
    giTalk("虚邑：掌门要召见你们！", "42445");
    giPlayerDoAction(1, "J02", 1, false);
    giSetPortrait("103C", false);
    giTalk("韩菱纱：咦咦咦——？！", "42446");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：掌门？谁啊？", "42447");
    giWait(0.3);
    giPlayerSetDir(1, 82.0, true);
    giWait(0.3);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：笨，就是一派之主，门派里所有人都要听他的！", "42448");
    giPlayerSetDir(0, 269.0, true);
    giWait(0.4);
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：哦～那他一定又厉害又威风。", "42449");
    giTalk("虚邑：……等一下在掌门面前，不可乱说乱动，无论是不是本门弟子，规矩法度总要守的。", "42450");
    giPlayerSetDir(1, 8.0, false);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(0, 335.0, true);
    giWait(0.4);
    giTalk("虚邑：尤其这位……少侠，似乎阅历甚浅，请注意自己的行止庄重。切记！", "42451");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101D", false);
    giTalk("云天河：呃……", "42452");
    giSetPortrait("103J", false);
    giTalk("韩菱纱：嘻嘻，被嫌弃了吧～", "42453");
    giPlayerDoAction(2, "J07", 1, false);
    giSetPortrait("106A", false);
    giTalk("柳梦璃：请问，掌门为什么要见我们呢？", "42454");
    giTalk("虚邑：掌门行事，自有缘由。你们只须跟我来。", "42455");
    giNpcWalkTo("MN001", 12481.9, -2011.7, -15051.4, false);
    giWait(2.0);
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：去就去，名门正派不会把我们怎样的，还能见到掌门，怎么想也不吃亏！", "42456");
    giWait(0.6);
    giIMMBegin();
    giSetNpcVisible("MN001", false);
    giSetNpcVisible("4001", false);
    giSetNpcVisible("4005", false);
    giSetNpcVisible("4004", false);
    giIMMEnd();
    giCameraRunSingle("009", true);
    giWait(0.3);
    giCameraRunSingle("010", false);
    giWait(3.5);
    giFlashOutBlack(1.3, true, true);
    giArenaLoad("Q06", "QN03", "", true);
    giPlayerLock();
    giScriptMusicPlay("P26", 2, 0.0, 2.5);
    giCameraSetCollide(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, -1.0, 0.5, 98.4);
    giPlayerSetAng(0, 176.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 45.4, 0.5, 44.2);
    giPlayerSetAng(1, 201.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, -59.5, 0.5, 51.0);
    giPlayerSetAng(2, 156.0);
    giPlayerSetVisible(2, true);
    giSetNpcVisible("MN001", true);
    giSetNpcVisible("MN002", true);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giArenaReady();
    giFlashInBlack(1.5, false);
    giWait(1.2);
    giCameraRunSingle("002", false);
    giNpcDoAction("MN002", "J01", 1, false);
    giTalk("虚邑：掌门，弟子已将他们带来了。", "42457");
    giNpcEndAction("MN002", true);
    giWait(1.2);
    giTalk("夙瑶：虚邑，你且退下。", "42458");
    giWait(0.5);
    giNpcDoAction("MN002", "J01", 1, false);
    giTalk("虚邑：是！", "42459");
    giNpcEndAction("MN002", true);
    giNpcWalkTo("MN002", 42.8, 0.5, 143.0, true);
    giSetNpcVisible("MN002", false);
    giWait(0.5);
    giCameraRunSingle("006", true);
    giCameraRunSingle("007", true);
    giWait(0.5);
    giNpcSetDir("MN001", 356.0, true);
    giWait(1.3);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：（……掌门是……女的？！）", "42460");
    giWait(0.5);
    giSetPortrait("213A", false);
    giTalk("夙瑶：……你，叫什么名字？", "42461");
    giWait(0.5);
    giIMMBegin();
    giPlayerSetPos(0, -7.7, 0.5, 3.7);
    giPlayerSetAng(0, 179.0);
    giIMMEnd();
    giIMMBegin();
    giNpcSetAng("MN001", 4.0);
    giCameraRunSingle("004", true);
    giIMMEnd();
    giWait(0.5);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101A", true);
    giTalk("云天河：啊？问我？", "42462");
    giSetPortrait("101B", true);
    giTalk("云天河：我、我叫云天河。", "42463");
    giSetPortrait("213A", false);
    giTalk("夙瑶：你爹是云天青？", "42464");
    giSetPortrait("101B", true);
    giTalk("云天河：是啊，你、掌门也认识我爹？", "42465");
    giWait(0.3);
    giCameraRunSingle("003", true);
    giWait(0.5);
    giSetPortrait("213A", true);
    giTalk("夙瑶：今日我在敬天之屋，以天珠占卜，得知会有故人之子前来，想必卦象中说的就是你了。", "42466");
    giWait(0.5);
    giIMMBegin();
    giCameraRunSingle("005", true);
    giPlayerSetAng(0, 173.0);
    giIMMEnd();
    giWait(0.3);
    giSetPortrait("101B", true);
    giTalk("云天河：我爹～他以前真的在这儿待过？", "42467");
    giNpcDoAction("MN001", "C08", 1, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：……不错，你爹确实曾入琼华派，只可惜他修行半途而废，后来就自行下山去了。如今他可是心有遗憾，才嘱咐你上山拜师？", "42468");
    giPlayerDoAction(0, "C09", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：是我自己想来，爹很早就死了，也没交代什么。", "42469");
    giSetPortrait("213C", false);
    giTalk("夙瑶：他……竟已过世了？……怎会如此……", "42470");
    giSetPortrait("101A", true);
    giTalk("云天河：……掌门？", "42471");
    giWait(0.4);
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：……也罢、也罢，死生由命……", "42472");
    giSetPortrait("213A", false);
    giTalk("夙瑶：……近日本门将有大事，我原不想节外生枝，但念及故人情义，且让你们几个试上一试。若能通过考验，我便破例一回，让你们入门又有何妨？", "42473");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101A", true);
    giTalk("云天河：要是没通过呢？", "42474");
    giSetPortrait("213A", false);
    giTalk("夙瑶：那便是几位仙缘浅薄，不适修行，也只能请你们下山去了。", "42475");
    giSetPortrait("101E", true);
    giTalk("云天河：哦……", "42476");
    giSetPortrait("101E", true);
    giTalk("云天河：（原来就算掌门认识我爹，也没什么优待……）", "42477");
    giPlayerDoAction(1, "J13", 1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（掌门竟然只理会天河，当我和梦璃不存在一样……）", "42478");
    giNpcDoAction("MN001", "C07", 1, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：<colour red=255 green=187 blue=0 alpha=255>准备好了，便上前来。</colour>", "42479");
    giFlashOutBlack(1.5, true, true);
    giNpcUnHoldAct("MN001");
    giNpcEndAction("MN001", true);
    giIMMBegin();
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(2, false);
    giNpcSetAng("MN001", 4.0);
    global_mvar = 60901; // 0x0000EDE5, 第二章 / 4-1-5.寻仙昆仑 / 入门考验
    giIMMEnd();
    giCameraSetMode(2, true);
    giPlayerSetLeader(0);
    giPlayerCurrentSetVisible(true);
    giPlayerCurrentSetPos(3.2, 0.5, 35.0);
    giPlayerCurrentSetAng(180.0);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2002()
{
    giPlayerLock();
    giFlashOutBlack(1.5, true, true);
    giCameraSetCollide(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, 8.2, 0.5, -30.9);
    giPlayerSetAng(0, 183.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 45.0, 0.5, -1.2);
    giPlayerSetAng(1, 208.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, -22.4, 0.5, 18.3);
    giPlayerSetAng(2, 172.0);
    giPlayerSetVisible(2, true);
    giNpcSetAng("MN001", 14.0);
    giIMMEnd();
    giCameraPrepare("MC002");
    giCameraRunSingle("001", true);
    giFlashInBlack(1.5, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：我且将你们送往一处境地，如何去而复返，须得自行体悟。", "42480");
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：呵呵，只要不被送下山，去哪都行。", "42481");
    giSetPortrait("213A", false);
    giTalk("夙瑶：若是在其中困得久了，我自会将你们召回，但入门之事也不必再提了。", "42482");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("101B", true);
    giTalk("云天河：意思就是……不凭自己的本事跑回来，就不算数？", "42483");
    giNpcDoAction("MN001", "C08", 1, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：不错。", "42484");
    giPlayerDoAction(0, "J16", 1, false);
    giSetPortrait("101K", true);
    giTalk("云天河：掌门你放心，不管跑路还是爬山，我都可以的！", "42485");
    giSetPortrait("213A", false);
    giTalk("夙瑶：……但愿如此。", "42486");
    giSetPortrait("103F", true);
    giTalk("韩菱纱：（这傻瓜……再继续耍白痴，我们可能会被直接赶出去……）", "42487");
    giSetPortrait("213A", false);
    giTalk("夙瑶：凝神！", "42488");
    giWait(0.3);
    giSetPortrait("213A", false);
    giTalk("夙瑶：玄女有命，普告万灵，自在往来，腾身紫微！", "42489");
    giEffectAttachToNpc("MN001", "H_TL01_1", false);
    giNpcDoAction("MN001", "J02", 1, false);
    giWait(3.2);
    giEffectDetachFromNpc("MN001");
    giIMMBegin();
    giEffectPlayWithPlayer("H_484_X01", 1, 1);
    giEffectPlayWithPlayer("H_484_X01", 1, 0);
    giEffectPlayWithPlayer("H_484_X01", 1, 2);
    giPlayerBlendIn(1, 1.5, false);
    giPlayerBlendIn(0, 1.5, false);
    giPlayerBlendIn(2, 1.5, false);
    giIMMEnd();
    giWait(1.5);
    giFlashOutWhite(2.5, true, true);
    global_mvar = 61000; // 0x0000EE48
    giArenaLoad("M10", "1", "", false);
}

void func2003()
{
    giPlayerLock();
    giScriptMusicPlay("P26", 2, 0.0, 2.5);
    giCameraSetCollide(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, -16.5, 0.5, -29.9);
    giPlayerSetAng(0, 170.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 18.6, 0.5, -4.1);
    giPlayerSetAng(1, 193.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, -50.5, 0.5, -12.8);
    giPlayerSetAng(2, 163.0);
    giPlayerSetVisible(2, true);
    giPlayerSetPos(3, 246.3, -69.5, 436.7);
    giPlayerSetAng(3, 189.8477);
    giPlayerSetVisible(3, true);
    giSetNpcVisible("MN001", true);
    giNpcSetAng("MN001", 357.0);
    giIMMEnd();
    giCameraPrepare("MC003");
    giCameraRunSingle("001", true);
    giFlashInWhite(3.2, false);
    giArenaReady();
    giWait(1.0);
    giIMMBegin();
    giEffectPlayWithPlayer("H_098", 1, 1);
    giEffectPlayWithPlayer("H_098", 1, 2);
    giEffectPlayWithPlayer("H_098", 1, 0);
    giIMMEnd();
    giWait(6.5);
    giSetPortrait("101K", true);
    giTalk("云天河：啊，真的回来了！", "42660");
    giNpcDoAction("MN001", "C08", 1, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：不错，比我想的还要快上许多。", "42661");
    giSetPortrait("101K", true);
    giTalk("云天河：啊？那是因为——", "42662");
    giPlayerDoAction(1, "J16", -1, false);
    giSetPortrait("103I", true);
    giTalk("韩菱纱：因为我们都很认真努力地闯关！", "42663");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：……", "42664");
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（以后还是少跟这野人一起，老实得像个大笨蛋……）", "42665");
    giSetPortrait("106A", true);
    giTalk("柳梦璃：嗯……可是为什么我会觉得，已经过去很久的样子……", "42666");
    giSetPortrait("213A", false);
    giTalk("夙瑶：久？自虚邑带你们踏入琼华宫的大门，连一柱香还未燃尽。", "42667");
    giSetPortrait("106E", true);
    giTalk("柳梦璃：这……是幻术吗？简直太奇妙了。", "42668");
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：人生一场迷梦，又岂知哪些是幻，哪些是真。你们方才不过神识出窍，历经了一场梦中之梦。", "42669");
    giSetPortrait("213A", false);
    giTalk("夙瑶：吾辈修仙，正是要从生死大梦中超脱，才可窥得世间真意。", "42670");
    giPlayerDoAction(0, "J16", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：这太好玩了～醒着也能做梦！", "42671");
    giPlayerEndAction(0);
    giNpcDoAction("MN001", "C07", -1, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：……云天河，你身上佩剑可否让我一观？", "42672");
    giNpcUnHoldAct("MN001");
    giNpcEndAction("MN001", false);
    giWait(0.4);
    giIMMBegin();
    giCameraRunSingle("002", true);
    giPlayerSetAng(1, 198.0);
    giIMMEnd();
    giWait(0.3);
    giSetPortrait("101B", false);
    giTalk("云天河：哦，好。", "42673");
    giGOBAttachToPlayer("MO002", "", 0, true);
    giPlayerDoAction(0, "J09", -1, true);
    giWait(1.0);
    giSetPortrait("213A", true);
    giTalk("夙瑶：此剑……你从何处得来？", "42674");
    giSetPortrait("101C", false);
    giTalk("云天河：（干嘛每个人都问一样的话？连掌门也……）", "42675");
    giSetPortrait("101A", false);
    giTalk("云天河：是爹给我的。", "42676");
    giSetPortrait("213A", true);
    giTalk("夙瑶：威力如何？", "42677");
    giGOBDetachFromPlayer(0);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101A", false);
    giTalk("云天河：还不错吧，用着蛮顺手的……", "42678");
    giSetPortrait("213A", true);
    giTalk("夙瑶：近日内可是有些变化？", "42679");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：原来掌门你这么厉害～连这都看得出来。", "42680");
    giSetPortrait("101B", false);
    giTalk("云天河：有一天这剑突然发光后，变得力量好大，我都险些控制不住……", "42681");
    giWait(0.3);
    giCameraRunSingle("003", true);
    giWait(0.5);
    giSetPortrait("213A", false);
    giTalk("夙瑶：…………", "42682");
    giSetPortrait("106A", true);
    giTalk("柳梦璃：难道……这把剑以前是琼华派的东西？", "42683");
    giSetPortrait("213A", false);
    giTalk("夙瑶：此剑不凡，你须小心收好，切勿怠慢。", "42684");
    giSetPortrait("213A", false);
    giTalk("夙瑶：我派素来以剑为尊，炼剑修仙，至天人合一之境，你初入门，便有神兵在手，自然事半功倍。", "42685");
    giWait(0.3);
    giIMMBegin();
    giCameraRunSingle("001", true);
    giNpcSetAng("MN001", 2.0);
    giIMMEnd();
    giWait(0.3);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：掌门，我们是不是很快就能开始修习仙术呢？", "42686");
    giNpcDoAction("MN001", "C09", 1, false);
    giSetPortrait("213A", false);
    giTalk("夙瑶：你等虽有些修为，但根基不稳，所学甚杂，实是修仙大忌。", "42687");
    giSetPortrait("213A", false);
    giTalk("夙瑶：我本想让一名玄字辈的长老亲自教授，奈何他在外未归，也只得另觅人选，此人名份上虽是你们的师叔，但规矩礼法不可废，须以师道尊之。", "42688");
    giSetPortrait("213A", false);
    giTalk("夙瑶：可都听明白了？", "42689");
    giPlayerDoAction(1, "C08", 1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：是，谢谢掌门！", "42690");
    giSetPortrait("105A", true);
    giTalk("慕容紫英：弟子慕容紫英奉命前来。", "42691");
    giPlayerWalkTo(3, 189.5, 0.5, 187.8, false);
    giWait(1.1);
    giCameraRunSingle("005", true);
    giWait(3.1);
    giFlashOutBlack(1.0, true, true);
    giIMMBegin();
    giPlayerSetAng(0, 40.0);
    giPlayerSetAng(1, 44.0);
    giPlayerSetAng(2, 54.0);
    giNpcSetAng("MN001", 19.0);
    giPlayerSetPos(3, 80.7, 0.5, 46.1);
    giPlayerSetAng(3, 209.0);
    giIMMEnd();
    giCameraRunSingle("006", true);
    giFlashInBlack(1.0, true);
    giPlayerDoAction(3, "J07", 1, false);
    giSetPortrait("105A", false);
    giTalk("慕容紫英：参见掌门！", "42692");
    giPlayerDoAction(1, "J02", 1, false);
    giSetPortrait("103D", true);
    giTalk("韩菱纱：是你？！", "42693");
    giPlayerEndAction(3);
    giPlayerSetDir(3, 242.0, true);
    giSetPortrait("105A", false);
    giTalk("慕容紫英：你们……", "42694");
    giSetPortrait("213A", true);
    giTalk("夙瑶：怎么？", "42695");
    giWait(0.3);
    giPlayerSetDir(3, 209.0, true);
    giWait(0.5);
    giPlayerDoAction(3, "J07", 1, false);
    giSetPortrait("105A", false);
    giTalk("慕容紫英：不，没什么，弟子在山下曾与他们有过数面之缘。", "42696");
    giPlayerEndAction(3);
    giCameraRunSingle("003", true);
    giWait(0.3);
    giNpcDoAction("MN001", "C08", 1, false);
    giSetPortrait("213A", true);
    giTalk("夙瑶：哦？……如此甚好，看来我没有选错人。", "42697");
    giSetPortrait("213A", true);
    giTalk("夙瑶：紫英，这几位初入门的弟子，由你负责教授。你在同辈弟子中亦算出类拔萃，却从无授徒经验，不如将此当作一种历练吧。", "42698");
    giSetPortrait("105A", false);
    giTalk("慕容紫英：是，弟子定会尽心传授，不辱掌门之命！", "42699");
    giNpcDoAction("MN001", "J04", 1, false);
    giSetPortrait("213A", true);
    giTalk("夙瑶：好了，都下去吧。余下事便由紫英安排。", "42700");
    giNpcEndAction("MN001", false);
    giFlashOutBlack(1.5, true, true);
    giArenaLoad("Q06", "Q06Q", "", true);
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giIMMBegin();
    giPlayerSetPos(0, 11881.5, -1670.0, -10764.8);
    giPlayerSetAng(0, 163.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 11914.7, -1670.0, -10790.0);
    giPlayerSetAng(1, 179.0);
    giPlayerSetVisible(1, true);
    giPlayerSetPos(2, 11934.1, -1670.0, -10751.5);
    giPlayerSetAng(2, 186.0);
    giPlayerSetVisible(2, true);
    giPlayerSetPos(3, 11890.1, -1672.0, -10846.8);
    giPlayerSetAng(3, 23.0);
    giPlayerSetVisible(3, true);
    giIMMEnd();
    giCameraPrepare("MC002");
    giCameraRunSingle("002", true);
    giFlashInBlack(2.5, false);
    giArenaReady();
    giWait(0.3);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：哈哈～紫英你是不是吓一跳？我们可是凭自己的实力入门的。", "42701");
    giSetPortrait("105A", false);
    giTalk("慕容紫英：……叫我“师叔”，不可无礼。", "42702");
    giSetPortrait("101A", true);
    giTalk("云天河：那、师叔，你认不认识我爹？他叫云天青，以前也是这儿的人。", "42703");
    giWait(0.3);
    giIMMBegin();
    giCameraRunSingle("003", true);
    giPlayerSetVisible(1, false);
    giIMMEnd();
    giWait(0.5);
    giPlayerDoAction(3, "C09", 1, false);
    giSetPortrait("105A", false);
    giTalk("慕容紫英：从未听过此人。", "42704");
    giSetPortrait("105A", false);
    giTalk("慕容紫英：你们初入本门，理应专心修行，勿念其他杂事。稍后便去前山弟子房歇息，不要错过明日早课。", "42705");
    giPlayerEndAction(3);
    giSetPortrait("101C", true);
    giTalk("云天河：弟子房？……是哪里？", "42706");
    giSetPortrait("105A", false);
    giTalk("慕容紫英：弟子房都在<colour red=255 green=187 blue=0 alpha=255>前山剑舞坪</colour><dc0>旁边，你的房间是</dc0><colour red=255 green=187 blue=0 alpha=255>门口有石狮子的那一间</colour><dc0>。</dc0>", "42707");
    giWait(0.6);
    giPlayerWalkTo(3, 11903.9, -1732.1, -10984.6, false);
    giWait(2.0);
    giIMMBegin();
    giCameraRunSingle("004", true);
    giPlayerSetVisible(1, true);
    giPlayerSetVisible(3, false);
    giIMMEnd();
    giPlayerDoAction(1, "J17", -1, false);
    giSetPortrait("103I", true);
    giTalk("韩菱纱：……什么嘛，一副拽拽的样子，小～人～得～志！", "42708");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101A", false);
    giTalk("云天河：他不认识爹……那块玉的事只有问掌门了……", "42709");
    giWait(0.3);
    giIMMBegin();
    giCameraRunSingle("006", true);
    giPlayerSetPos(1, 11919.9, -1670.0, -10804.8);
    giPlayerSetAng(1, 320.0);
    giPlayerSetAng(2, 238.0);
    giIMMEnd();
    giWait(0.4);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：慢慢慢～我们才刚来，你可别随便乱问啊，好歹先待上一段时间，搞清楚状况再说，这里神神秘秘的，我到现在还是一头雾水。", "42710");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(0, 135.0, true);
    giWait(0.5);
    giPlayerDoAction(2, "C07", -1, false);
    giSetPortrait("106B", true);
    giTalk("柳梦璃：不如先按师叔所说，<colour red=255 green=187 blue=0 alpha=255>回房休息吧，</colour><dc0>有什么事明日再做打算也不迟。</dc0>", "42711");
    giPlayerUnHoldAct(2);
    giPlayerEndAction(2);
    giIMMBegin();
    giPlayerSetDir(0, 72.0, false);
    giPlayerSetDir(1, 17.0, false);
    giIMMEnd();
    giWait(0.8);
    giSetPortrait("101A", false);
    giTalk("云天河：好～～", "42712");
    giPlayerDoAction(1, "J13", -1, false);
    giSetPortrait("103C", true);
    giTalk("韩菱纱：我说，你们两个～别那么正经八百地喊他“师叔”好不好，一想到他那张冰块脸，年纪又和我们差不多，不觉得很奇怪吗？", "42713");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giWait(0.3);
    giPlayerSetDir(2, 196.0, true);
    giWait(0.5);
    giPlayerDoAction(2, "C09", 1, false);
    giSetPortrait("106B", false);
    giTalk("柳梦璃：我……不太在意这个。", "42714");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：我也没差。", "42715");
    giPlayerDoAction(1, "J05", 1, false);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：…………算了，当我什么也没说。", "42716");
    giFlashOutBlack(1.5, true, true);
    giPlayerEndAction(0);
    giPlayerEndAction(1);
    giIMMBegin();
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(2, false);
    global_mvar = 61300; // 0x0000EF74, 第二章 / 4-3-1.御剑逍遥 / 去弟子房休息 / 初入琼华
    giPlayerCurrentSetVisible(true);
    giPlayerCurrentSetPos(11969.9, -1766.4, -11212.5);
    giPlayerCurrentSetAng(168.0);
    giSetObjectVisible("entrance1", false);
    giSetObjectVisible("entrance2", false);
    giIMMEnd();
    giCameraSetMode(0, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giScriptMusicStop(1, 2.5);
    giPlayerUnLock();
}

void func2004()
{
    int local_3 = 0;

    switch (global_mvar)
    {
        case 61300:
            giPlayerLock();
            giFlashOutBlack(1.5, true, true);
            giIMMBegin();
            giCameraSetCollide(false);
            giCameraAutoSeek(false);
            giPlayerCurrentSetVisible(false);
            giSetNpcVisible("MN001", true);
            giSetObjectVisible("MO001", true);
            giIMMEnd();
            giCameraPrepare("MC001");
            giCameraRunSingle("002", true);
            giFlashInBlack(1.5, true);
            giWait(0.5);
            giSetPortrait("101A", false);
            giTalk("云天河：（这房间真大……不习惯……床也硬梆梆的，不够软……）", "42717");
            giWait(0.7);
            giSetPortrait("101B", false);
            giTalk("云天河：（呵呵，爹也睡过这里吗？……我觉得，自己离爹好像又近了些，虽然以前住在一块儿，有时候却觉得爹离得好远……）", "42718");
            giNpcSetEmotion("MN001", "101_by");
            giSetPortrait("101L", false);
            giTalk("云天河：（不知道啥时候才能学御剑？……呼～）", "42719");
            local_3 = gi2DSoundPlay("WJ024", -1);
            gi2DSoundPlay("WJ063", 1);
            giFlashOutBlack(1.5, true, true);
            giWait(2.5);
            giNpcResetEmotion("MN001");
            gi2DSoundStopID(local_3);
            gi2DSoundPlay("WJ025", 1);
            giSetPortrait("101G", false);
            giTalk("云天河：（……唔？有杀气……）", "42720");
            giSetPortrait("105A", true);
            giTalk("慕容紫英：云天河，还不快快起床！", "42721");
            giCameraRunSingle("001", true);
            giIMMBegin();
            giSetNpcVisible("MN001", false);
            giPlayerCurrentSetPos(64.4, 0.7, 4.6);
            giPlayerCurrentSetAng(332.0);
            giPlayerCurrentSetVisible(true);
            giPlayerSetPos(3, 52.4, 0.7, 66.6);
            giPlayerSetAng(3, 169.8561);
            giPlayerSetVisible(3, true);
            giIMMEnd();
            giFlashInBlack(2.0, true);
            giWait(0.5);
            giPlayerDoAction(0, "J14", 1, false);
            giSetPortrait("101D", true);
            giTalk("云天河：紫……不对，师叔？", "42722");
            giPlayerDoAction(3, "J13", 1, false);
            giSetPortrait("105A", false);
            giTalk("慕容紫英：懒散贪睡，不知进取！知不知道早课时辰已过？！", "42723");
            giSetPortrait("101D", true);
            giTalk("云天河：啊？什么……", "42724");
            giSetPortrait("105A", false);
            giTalk("慕容紫英：念你初犯，暂不追究，半柱香内洗漱换衣，<colour red=255 green=187 blue=0 alpha=255>到剑舞坪来</colour><dc0>！</dc0>", "42725");
            giPlayerDoAction(0, "J02", -1, false);
            giSetPortrait("101D", true);
            giTalk("云天河：我、我还没吃早饭……", "42726");
            giPlayerUnHoldAct(0);
            giPlayerEndAction(0);
            giWait(0.5);
            giSetPortrait("105C", false);
            giTalk("慕容紫英：不必吃了，五谷都是浊气，一早就要沾染，你修为永远也无法精进！", "42727");
            giPlayerWalkTo(3, -36.1, 0.7, 142.0, false);
            giWait(1.0);
            giCameraRunSingle("003", false);
            giSetPortrait("101D", true);
            giTalk("云天河：…………", "42728");
            giPlayerDoAction(0, "J15", 0, false);
            giSetPortrait("101D", true);
            giTalk("云天河：饭是浊气？那只能吃肉了？", "42729");
            giPlayerEndAction(0);
            giWait(0.5);
            giPlayerSetDir(0, 33.0, true);
            giWait(0.5);
            giPlayerWalkTo(0, 99.6, 0.7, 47.8, false);
            giCameraRunSingle("004", false);
            giPlayerEndMove(0);
            giWait(0.5);
            giPlayerDoAction(0, "J14", 1, true);
            giSetPortrait("101B", true);
            giTalk("云天河：（换衣服？是说这个吧？……哈哈，看起来还挺不错的～）", "42730");
            giWait(0.3);
            giFlashOutBlack(1.5, true, true);
            giPlayerOutTeam(1, false);
            giPlayerOutTeam(2, false);
            giIMMBegin();
            giPlayerSetVisible(3, false);
            global_mvar = 70200; // 0x00011238, 第二章 / 4-3-2.御剑逍遥 / 剑舞坪修行
            giSetObjectVisible("MO001", false);
            giPlayerCurrentSetPos(-57.7, 0.7, 66.2);
            giPlayerCurrentSetAng(339.0);
            giSetObjectVisible("MO005", true);
            giSetObjectVisible("MO006", true);
            giSetObjectVisible("effect001", true);
            giIMMEnd();
            giAllPlayerGarb2();
            giSetFullHP();
            giSetFullMP();
            giCameraSetMode(3, true);
            giCameraSeekToPlayer();
            giFlashInBlack(1.5, true);
            giPlayerUnLock();
            break;
        case 71200:
            giPlayerLock();
            giFlashOutBlack(1.5, true, true);
            giIMMBegin();
            giCameraSetCollide(false);
            giCameraAutoSeek(false);
            giPlayerCurrentSetVisible(false);
            giSetNpcVisible("MN002", true);
            giIMMEnd();
            giCameraPrepare("MC002");
            giCameraRunSingle("001", true);
            giFlashInBlack(2.0, true);
            giWait(1.2);
            giSetPortrait("102E", false);
            giTalk("云天河：（终于学了御剑……却又开心不起来……）", "43025");
            giWait(0.5);
            giSetPortrait("102E", false);
            giTalk("云天河：（唉～要是爹在，肯定有法子把那个什么水林猪弄到手……）", "43026");
            giWait(1.3);
            giNpcSetEmotion("MN002", "102_by");
            giFlashOutBlack(1.5, true, true);
            giNpcResetEmotion("MN002");
            giSetNpcVisible("MN002", false);
            giArenaLoad("Q06", "QN05Y", "", true);
            giPlayerLock();
            giCameraSetCollide(false);
            giCameraAutoSeek(false);
            giPlayerCurrentSetVisible(false);
            giIMMBegin();
            giPlayerSetPos(1, 86.8, 0.7, 3.9);
            giPlayerSetAng(1, 173.0);
            giPlayerSetVisible(1, true);
            giPlayerSetPos(2, 53.6, 0.7, 25.5);
            giPlayerSetAng(2, 156.0);
            giPlayerSetVisible(2, true);
            giSetNpcVisible("MN001", true);
            giSetObjectVisible("MO001", true);
            giSetObjectVisible("Jeffect001", true);
            giIMMEnd();
            giCameraPrepare("MC001");
            giCameraRunSingle("001", true);
            giArenaReady();
            giWait(1.6);
            gi2DSoundPlay("WJ072", 3);
            giWait(2.5);
            giSetPortrait("102D", true);
            giTalk("云天河：啊？！发生什么事？", "43027");
            giScriptMusicPlay("P03", 2, 2.5, 0.0);
            giFlashInBlack(1.5, true);
            giSetPortrait("104J", false);
            giTalk("韩菱纱：嘻嘻～这“鸣钟符”果然厉害，现在你是不是半点也不想睡了？", "43028");
            giWait(0.4);
            giSetPortrait("102D", true);
            giTalk("云天河：刚才……到底是什么东西？", "43029");
            giSetPortrait("104J", false);
            giTalk("韩菱纱：这是琼华派的符咒之一，专门用来对付静思时打瞌睡的弟子，除了你本人，其他人是听不见的，我见有趣，就摸了几张来玩～", "43030");
            giSetPortrait("107A", false);
            giTalk("柳梦璃：先别说这个了。", "43031");
            giWait(0.4);
            giPlayerSetDir(2, 250.0, true);
            giWait(0.4);
            giPlayerDoAction(2, "C07", -1, false);
            giSetPortrait("107A", false);
            giTalk("柳梦璃：快看看那把剑到底是怎么回事，我有点担心……", "43032");
            gi2DSoundPlay("WJ031", 0);
            giCameraRunSingle("002", true);
            giIMMBegin();
            giSetNpcVisible("MN001", false);
            giPlayerSetPos(0, 32.5, 0.7, 57.0);
            giPlayerSetAng(0, 234.0);
            giPlayerSetVisible(0, true);
            giPlayerSetPos(1, 43.0, 0.7, 8.0);
            giPlayerSetAng(1, 266.0);
            giPlayerSetPos(2, 13.7, 0.7, 34.5);
            giPlayerSetAng(2, 240.0);
            giIMMEnd();
            giPlayerDoAction(2, "C01", 0, false);
            giWait(1.0);
            giPlayerWalkTo(0, -31.2, 0.7, 8.4, true);
            giWait(0.5);
            giSetPortrait("102D", false);
            giTalk("云天河：这剑怎么浮着？", "43033");
            giCameraRunSingle("003", false);
            giWait(0.5);
            giSetPortrait("104A", false);
            giTalk("韩菱纱：问你啊。", "43034");
            giSetPortrait("104A", false);
            giTalk("韩菱纱：我刚才觉得好累，不知不觉在房里睡着了，后来听到一阵奇怪的鸣声，叫了梦璃，一路寻过来，才发觉是这把剑……", "43035");
            giSetPortrait("107A", false);
            giTalk("柳梦璃：奇怪的是，我却半点声音都听不到。", "43036");
            giPlayerDoAction(0, "J14", 1, false);
            giSetPortrait("102H", false);
            giTalk("云天河：好像……真的有声音……", "43037");
            giWait(0.5);
            giPlayerDoAction(0, "C07", -1, true);
            giWait(0.5);
            giIMMBegin();
            gi2DSoundStop();
            giSetObjectVisible("MO001", false);
            giSetObjectVisible("Jeffect001", false);
            giIMMEnd();
            giWait(0.5);
            giPlayerUnHoldAct(0);
            giPlayerEndAction(0);
            giPlayerDoAction(2, "J13", 1, false);
            giSetPortrait("107A", false);
            giTalk("柳梦璃：我总觉得，这剑很不简单，会不会和云叔有关呢？", "43038");
            giWait(0.6);
            giPlayerSetDir(0, 45.0, true);
            giWait(0.6);
            giSetPortrait("102A", true);
            giTalk("云天河：我爹？", "43039");
            giWait(0.5);
            giIMMBegin();
            giCameraRunSingle("004", false);
            giPlayerSetAng(0, 72.0);
            giPlayerSetPos(1, 25.6, 0.7, -0.7);
            giPlayerSetAng(1, 330.0);
            giPlayerSetPos(2, 13.7, 0.7, 34.5);
            giPlayerSetAng(2, 176.0);
            giIMMEnd();
            giWait(0.6);
            giSetPortrait("104A", true);
            giTalk("韩菱纱：梦璃，你为什么会这样想？", "43040");
            giPlayerDoAction(2, "J13", 1, false);
            giSetPortrait("107D", false);
            giTalk("柳梦璃：我……只是一种感觉，而且想想刚才那把剑浮在空中的样子，像不像指着某个方向呢？", "43041");
            giPlayerDoAction(1, "J02", -1, false);
            giSetPortrait("104C", true);
            giTalk("韩菱纱：那边……", "43042");
            giSetPortrait("104C", true);
            giTalk("韩菱纱：是禁地的方向？！", "43043");
            giPlayerUnHoldAct(1);
            giPlayerEndAction(1);
            giWait(0.5);
            giPlayerDoAction(2, "C08", 1, true);
            giWait(0.6);
            giSetPortrait("104A", true);
            giTalk("韩菱纱：我们，<colour red=255 green=187 blue=0 alpha=255>要不要去禁地看看</colour><dc0>？</dc0>", "43044");
            giWait(0.3);
            giPlayerSetDir(0, 102.0, true);
            giWait(0.5);
            giSetPortrait("102A", true);
            giTalk("云天河：可以吗？万一师叔又生气……", "43045");
            giPlayerSetDir(1, 290.0, true);
            giWait(0.3);
            giSetPortrait("104A", false);
            giTalk("韩菱纱：怕什么～要是被发现，就装作在梦游好了。", "43046");
            giPlayerDoAction(0, "J02", -1, false);
            giSetPortrait("102D", true);
            giTalk("云天河：啊？！话这样讲也行啊？三个人一起梦游？！", "43047");
            giPlayerUnHoldAct(0);
            giPlayerEndAction(0);
            giPlayerDoAction(2, "J14", 1, false);
            giSetPortrait("107A", false);
            giTalk("柳梦璃：……还是多加小心为好，这门派似乎有许多隐秘之事……", "43048");
            giWait(0.3);
            giPlayerSetDir(1, 330.0, true);
            giWait(0.5);
            giPlayerDoAction(1, "C08", 1, false);
            giSetPortrait("104B", true);
            giTalk("韩菱纱：嗯，我最喜欢探秘了～走吧、走吧。 ", "43049");
            giFlashOutBlack(1.5, true, true);
            giPlayerEndAction(1);
            giPlayerInTeam(1, false);
            giPlayerInTeam(2, false);
            giSetFullHP();
            giSetFullMP();
            giIMMBegin();
            giPlayerSetVisible(0, false);
            giPlayerSetVisible(1, false);
            giPlayerSetVisible(2, false);
            global_mvar = 71400; // 0x000116E8, 第二章 / 5-1-1.寒剑夜鸣 / 前去禁地
            giPlayerCurrentSetVisible(true);
            giPlayerCurrentSetPos(-61.1, 0.7, 47.8);
            giPlayerCurrentSetAng(14.0);
            giIMMEnd();
            giCameraSetMode(3, true);
            giCameraSeekToPlayer();
            giFlashInBlack(1.5, true);
            giScriptMusicStop(0, 2.5);
            giPlayerUnLock();
            break;
        case 100100:
            giPlayerLock();
            giFlashOutBlack(1.5, true, true);
            gi2DSoundPlay("WJ063", 1);
            giSetFullHP();
            giSetFullMP();
            giPlayerCurrentSetPos(69.0, 0.7, 14.0);
            giPlayerCurrentSetAng(327.0);
            giCameraPrepare("MC006");
            giCameraRunSingle("001", true);
            giWait(2.3);
            giFlashInBlack(1.5, true);
            giWait(0.5);
            giPlayerDoAction(0, "J14", 1, false);
            giSetPortrait("102A", true);
            giTalk("云天河：不晓得梦璃的身体好点没有？总觉得这一觉睡得不踏实……", "43851");
            giWait(0.5);
            giFlashOutBlack(1.5, true, true);
            giPlayerEndAction(0);
            global_mvar = 100101; // 0x00018705, 准备动身
            giCameraSetMode(3, true);
            giCameraSeekToPlayer();
            giFlashInBlack(1.5, true);
            giPlayerUnLock();
            break;
        case 120400:
            func2023();
            break;
        default:
            func2098();
            break;
    }
}

void func2006()
{
    if (global_mvar == 70200 /* 第二章 / 4-3-2.御剑逍遥 / 剑舞坪修行 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P26", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 6940.6, -1388.4, -6499.8);
        giPlayerSetAng(0, 0.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 6932.9, -1388.4, -6279.8);
        giPlayerSetAng(1, 178.0);
        giPlayerSetPos(2, 6962.2, -1388.4, -6294.1);
        giPlayerSetAng(2, 193.0);
        giPlayerSetPos(3, 6877.0, -1388.4, -6206.4);
        giPlayerSetAng(3, 153.0);
        giSetNpcVisible("4049", false);
        giSetObjectVisible("title09", false);
        giSetObjectVisible("title10", false);
        giIMMEnd();
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giPlayerWalkTo(0, 6959.4, -1388.4, -6351.9, false);
        giFlashInBlack(2.0, false);
        giPlayerEndMove(0);
        giWait(1.0);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：咦？云公子好像大不一样了，看起来很精神呢。", "42731");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102F", true);
        giTalk("云天河：是吗？呵呵。", "42732");
        giWait(0.4);
        giCameraRunSingle("002", true);
        giWait(0.4);
        giPlayerDoAction(1, "J14", 1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：唔，果然还是人靠衣装马靠鞍。", "42733");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102F", true);
        giTalk("云天河：梦、梦璃，你穿这样也很好看，像仙女一样。", "42734");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("006", false);
        giPlayerSetAng(2, 204.0);
        giPlayerSetVisible(0, false);
        giPlayerSetPos(1, 6939.5, -1388.4, -6257.9);
        giPlayerSetAng(1, 189.0);
        giIMMEnd();
        giCameraRunSingle("007", false);
        giWait(0.3);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("107C", false);
        giTalk("柳梦璃：真的吗？谢谢云公子的夸奖。", "42735");
        giSetPortrait("104J", false);
        giTalk("韩菱纱：……下山没多久，倒学得油嘴滑舌。", "42736");
        giSetPortrait("102F", true);
        giTalk("云天河：其实……菱纱也蛮漂亮的～", "42737");
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("104J", false);
        giTalk("韩菱纱：……看不出，你还知道左右逢源呢……", "42738");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.3);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：你们几个，言之无聊，成何体统！", "42739");
        giWait(0.3);
        giIMMBegin();
        giPlayerSetPos(0, 6876.3, -1388.4, -6309.1);
        giPlayerSetAng(0, 359.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 6950.2, -1388.4, -6243.4);
        giPlayerSetAng(1, 301.0);
        giPlayerSetPos(2, 6950.1, -1388.4, -6297.2);
        giPlayerSetAng(2, 320.0);
        giPlayerSetAng(3, 130.0);
        giCameraRunSingle("008", false);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：干嘛摆出一副长辈的样子，说不定啊，你只是长得老成，其实年纪比我还小呢，对吧？小～紫～英～", "42740");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……叫我“师叔”。", "42741");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：还有不要拿别人名字开玩笑，很不礼貌。", "42742");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：师叔，今天要练什么？会不会学御剑啊？我想学！", "42743");
        giPlayerEndAction(0);
        giPlayerSetDir(3, 189.0, true);
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我自有安排，等下便知。", "42744");
        giSetPortrait("102A", true);
        giTalk("云天河：哦……", "42745");
        giIMMBegin();
        giCameraRunSingle("009", true);
        giPlayerSetAng(3, 130.0);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(0, false);
        giIMMEnd();
        giCameraRunSingle("010", false);
        giWait(0.3);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：你们几个既入琼华派，自当知晓门派中的一些规矩。", "42746");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：本派前山乃是所有弟子清修之处。铸剑所用之“承天剑台”，位于五灵剑阁上方。后山思返谷为弟子思过之所。剑林则通往禁地，万万不可靠近！切记！", "42747");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：对了，我以前听说过，蜀山仙剑派也是很有名的修仙门派，那除了蜀山、昆仑，是不是还有其他地方也有人修仙呢？", "42748");
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……你所问之事，与你入门修行，似乎没有多大关系吧？", "42749");
        giIMMBegin();
        giCameraRunSingle("011", true);
        giPlayerSetAng(3, 111.0);
        giPlayerSetPos(1, 6923.6, -1388.4, -6230.8);
        giPlayerSetAng(1, 304.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(0, 6886.9, -1388.4, -6291.0);
        giPlayerSetAng(0, 353.0);
        giPlayerSetVisible(0, false);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：都是修仙，怎会没关系，做老师的不就是要替学生解惑？", "42750");
        giSetPortrait("105C", true);
        giTalk("慕容紫英：…………", "42751");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：说嘛～", "42752");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：…………若论到人间仙境，颇成气候的，还有十洲三岛、十大洞天、三十六小洞天、七十二福地，不过彼此之间也并非都有往来。", "42753");
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：哇！这么多修仙的地方，一定都藏得很隐秘吧？", "42754");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：那倒未必，有缘之人自然得见。", "42755");
        giIMMBegin();
        giCameraRunSingle("012", false);
        giPlayerSetAng(3, 142.0);
        giPlayerSetAng(1, 288.0);
        giPlayerSetPos(0, 6889.8, -1388.4, -6275.2);
        giPlayerSetAng(0, 351.0);
        giPlayerSetAng(2, 307.0);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(0, true);
        giIMMEnd();
        giCameraRunSingle("013", false);
        giWait(0.3);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：嗯……掌门说过将有大事发生，请问到底是什么事呢？", "42756");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……你们可知，世间有妖界如星辰运行一般，有其既定的天轨？", "42757");
        giSetPortrait("107E", true);
        giTalk("柳梦璃：……！！", "42758");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：妖界？！", "42759");
        giSetPortrait("102C", true);
        giTalk("云天河：什么意思？是说所有的妖怪都住一起吗？", "42760");
        giPlayerDoAction(3, "C08", 1, true);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：妖与人不同，彼此之间并不亲厚，多半单独隐匿于山林之中，只存有兽性冷血。他们一旦聚集群居，必是由十分强大且残暴的妖所统领，实力深不可测。", "42761");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：分散多处的妖界极难察觉，只有在各处布下八卦灵阵，用以探查妖界所在。", "42762");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我琼华派处于昆仑山巅，本是天地间钟灵毓秀之所，却怎料此地也正是某个妖界运移之天轨，每隔十九年彼此最为接近。", "42763");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：那……岂不是……", "42764");
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不错，十九年前，本派曾与妖界殊死相搏，我虽未亲身经历，但也耳闻状况是何等惨烈。", "42765");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：如今妖界又将降临，那些妖物比寻常精怪更为凶残，法力高深，若琼华派抵御不住，则人间危急，只怕要生灵涂炭……", "42766");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：十九年前昆仑山巅一战，全派弟子死伤过半，前任掌门也不幸战死，甚至听说门派中还有叛徒出现。", "42767");
        giIMMBegin();
        giCameraRunSingle("014", false);
        giPlayerSetPos(0, 6898.0, -1388.4, -6288.2);
        giPlayerSetAng(0, 345.0);
        giPlayerSetPos(1, 6942.0, -1388.4, -6255.4);
        giPlayerSetAng(1, 306.0);
        giPlayerSetPos(2, 6940.9, -1388.4, -6295.3);
        giPlayerSetAng(2, 325.0);
        giIMMEnd();
        giWait(0.3);
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("104D", false);
        giTalk("韩菱纱：啊？！这么惨……", "42768");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：那妖界又是怎样呢？", "42769");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：双方两败俱伤。", "42770");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107F", false);
        giTalk("柳梦璃：……这里竟然有过那样可怕的厮杀……", "42771");
        giSetPortrait("104E", false);
        giTalk("韩菱纱：对啊，想想都觉得心里好不舒服……", "42772");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：还没发生的事，干嘛要去想？想了又不开心。", "42773");
        giIMMBegin();
        giCameraRunSingle("015", false);
        giPlayerSetAng(0, 338.0);
        giPlayerSetAng(1, 337.0);
        giPlayerSetAng(3, 146.0);
        giPlayerSetAng(2, 338.0);
        giIMMEnd();
        giCameraRunSingle("016", false);
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：兹事体大，你们几个更应勤加修炼，不可懈怠。", "42774");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：和妖界打了这么久，我们到底算赢还是输啊？", "42775");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：这并非比武争胜，何来输赢之说？何况琼华派只管一力抵挡，稍有不慎，整个门派与山下百姓都将惨遭横祸，又如何输得起？", "42776");
        giSetPortrait("104E", true);
        giTalk("韩菱纱：（瞧他忧心忡忡的样子，十九年前连掌门都战死了，其实就是输了嘛……）", "42777");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：……听说昆仑山上还有其他的修仙门派，是不是也会同仇敌忾呢？", "42778");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……与妖界抗衡，有性命之危，其他七派处事各有不同，并非都是除魔卫道之士， 与本派也并无同心。", "42779");
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：这么惨呐？就是说即使打不过，也不用指望援兵了？", "42780");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不必过早担忧，你们修为尚浅，若不得已与妖界短兵相接，当以保护自身性命为先。", "42781");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：性命为先……那你呢？难道就要不顾一切冲上去？", "42782");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……", "42783");
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：若有所需，自是不计生死。", "42784");
        giPlayerEndAction(3);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：干嘛要说这种死来死去的话？妖怪打过来，尽力打败他们就是了，我才不信会输！", "42785");
        giWait(0.5);
        giPlayerSetDir(3, 167.0, true);
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不错，正要有此气魄！", "42786");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：你们才刚入门，其实今日本不必跟你们说这些门派旧事，但十九年时限已至，危机迫近，若是觉得心中害怕，可以立即下山去，也不是什么丢脸的事。", "42787");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：没感到杀气就不危险。来都来了，也不用想太多吧？以后危险就以后再下山好了。", "42788");
        giSetPortrait("105D", false);
        giTalk("慕容紫英：你——！ ", "42789");
        giPlayerDoAction(2, "J05", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：师叔别介意，云公子他没别的意思，他说话一向就是……", "42790");
        giSetPortrait("104J", true);
        giTalk("韩菱纱：嘿嘿，就是呆头呆脑、胡说八道。", "42791");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：我……", "42792");
        giSetPortrait("105C", false);
        giTalk("慕容紫英：哼！不必多言。", "42793");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：接下来我便教授你们本派的入门心法，须知，琼华以剑为苍冥间浩然正气，习剑者明是非、遵礼仪，即便手中无剑，心中也要存有慧剑——", "42794");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giWait(1.0);
        giIMMBegin();
        giCameraRunSingle("017", false);
        giPlayerSetPos(0, 6895.2, -1388.4, -6274.0);
        giPlayerSetAng(0, 342.0);
        giPlayerSetAng(1, 310.0);
        giPlayerSetAng(3, 153.0);
        giPlayerSetAng(2, 339.0);
        giIMMEnd();
        giFlashInBlack(2.0, true);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：可都清楚了？", "42795");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：每个字分开来都明白，可是放在一起就……好像有懂，又好像没懂……", "42796");
        giPlayerSetDir(1, 247.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：笨～紫英刚才说的，不就有你最想学的御剑吗？", "42797");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giPlayerSetDir(1, 310.0, false);
        giWait(0.3);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：本派弟子以习剑居多，修炼其他兵器亦可，御剑之道“在于心而不在于形”。", "42798");
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：在于心……而不在于形……", "42799");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：你们几个才刚入门，进境不会太快，先在此练习，把口诀融会贯通。", "42800");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我有事待办，最多两个时辰便会回来。", "42801");
        giWait(0.5);
        giPlayerWalkTo(3, 6723.2, -1388.4, -6327.8, false);
        giWait(1.5);
        giIMMBegin();
        giCameraRunSingle("018", false);
        giPlayerSetAng(0, 236.0);
        giPlayerSetAng(1, 246.0);
        giPlayerSetAng(2, 254.0);
        giIMMEnd();
        giWait(1.0);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：不是吧？这冰块脸说要教人，自己却又跑了……", "42802");
        giWait(0.4);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(1);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P23", 2, 2.5, 0.0);
        giIMMBegin();
        giCameraRunSingle("020", false);
        giPlayerSetPos(0, 6925.7, -1388.4, -6099.3);
        giPlayerSetAng(0, 161.0);
        giPlayerSetPos(1, 6965.0, -1388.4, -6209.5);
        giPlayerSetAng(1, 93.0);
        giPlayerSetPos(2, 7073.3, -1388.4, -6212.4);
        giPlayerSetAng(2, 284.0);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(3, false);
        giIMMEnd();
        giPlayerDoAction(1, "J13", -1, false);
        giWait(1.0);
        giFlashInBlack(2.0, true);
        giWait(0.5);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：不很难嘛～我好像已经能飞了耶。", "42803");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("021", false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：梦璃，你呢？", "42804");
        giCameraWait();
        giWait(0.4);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：嗯，我也是。", "42805");
        giWait(0.5);
        giPlayerSetDir(1, 345.0, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：天河，你还是弄不明白？", "42806");
        giWait(0.3);
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("104D", false);
        giTalk("韩菱纱：咦？", "42807");
        giIMMBegin();
        giCameraRunSingle("022", false);
        giPlayerSetAng(1, 351.0);
        giPlayerSetPos(2, 7074.1, -1388.4, -6213.7);
        giPlayerSetAng(2, 298.0);
        giIMMEnd();
        giWait(1.0);
        giEffectPlayWithPlayer("H_090", 1, 0);
        giPlayerBlendIn(0, 1.5, true);
        giWait(1.6);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：哈哈～真好玩，我在上面绕了几圈，看你和梦璃都变好小！", "42808");
        giSetPortrait("104A", false);
        giTalk("韩菱纱：奇怪……你一会儿说听不懂？一会儿又学得飞快？", "42809");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：我、我也不知怎么回事，在脑子里想着想着就突然飞起来了。", "42810");
        giSetPortrait("102K", true);
        giTalk("云天河：不过爹留下来的这把剑真厉害，我算算～可以打猎、剥皮、切肉、把肉串起来烤，现在我还能站在上面御剑了！", "42811");
        giPlayerWalkTo(2, 6997.0, -1388.4, -6175.1, false);
        giWait(1.2);
        giPlayerSetDir(0, 135.0, false);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 313.0, false);
        giWait(0.6);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107C", true);
        giTalk("柳梦璃：云公子你真有趣，这把剑竟有这么多的妙用。", "42812");
        giIMMBegin();
        giCameraRunSingle("023", false);
        giPlayerSetAng(0, 107.0);
        giPlayerSetPos(1, 7005.1, -1388.4, -6184.4);
        giPlayerSetAng(1, 325.0);
        giPlayerSetPos(2, 7016.1, -1388.4, -6158.2);
        giPlayerSetAng(2, 286.0);
        giIMMEnd();
        giCameraRunSingle("024", false);
        giWait(0.5);
        giSetPortrait("102K", false);
        giTalk("云天河：嗯，这就是梦璃你教过我的“能者多劳”吧～", "42813");
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("107C", true);
        giTalk("柳梦璃：噗……", "42814");
        giSetPortrait("104E", true);
        giTalk("韩菱纱：（傻瓜，什么能者多劳……用来烤肉又用脚踩，恶心……）", "42815");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：……我说啊，也只有你这么活宝，把剑用成这样，亏掌门还讲这是厉害的神兵呢。", "42816");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("102B", false);
        giTalk("云天河：呵呵，东西不就是拿来用的。", "42817");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：这下可好，我们三个都会御剑了，不如飞去山下玩玩？", "42818");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giCameraRunSingle("025", false);
        giPlayerSetPos(0, 6925.7, -1388.4, -6099.3);
        giPlayerSetAng(0, 146.0);
        giPlayerSetPos(1, 6970.2, -1388.4, -6164.4);
        giPlayerSetAng(1, 342.0);
        giPlayerSetPos(2, 6991.4, -1388.4, -6118.4);
        giPlayerSetAng(2, 281.0);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：好啊好啊，上回是被怀朔带着，一点都不过瘾。", "42819");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：……", "42820");
        giWait(0.6);
        giIMMBegin();
        giPlayerSetDir(0, 108.0, false);
        giPlayerSetDir(1, 24.0, false);
        giIMMEnd();
        giWait(1.0);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：梦璃，你怎么了？脸色怪怪的。", "42821");
        giPlayerSetDir(2, 180.0, true);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：我……我还想着妖界的事，不过云公子说得对，没发生的，多想也没用，是我自己太放不开了……", "42822");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：别想啦，难得学会御剑，今天就把烦恼都抛开，开开心心地玩一场！", "42823");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：嗯！", "42824");
        giSetPortrait("104A", false);
        giTalk("韩菱纱：反正我们在这待些日子，一来帮天河打探打探他爹的事，二来那个拽拽的紫英也帮过我们，如果妖界打过来，我们帮帮他算是还人情。", "42825");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102M", false);
        giTalk("云天河：对，滴水之恩必当涌泉以报！", "42826");
        giIMMBegin();
        giCameraRunSingle("026", false);
        giPlayerSetAng(0, 136.0);
        giPlayerSetPos(1, 6963.6, -1388.4, -6154.9);
        giPlayerSetAng(1, 316.0);
        giPlayerSetPos(2, 6969.1, -1388.4, -6124.7);
        giPlayerSetAng(2, 273.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：我说……梦璃才教你一点东西，你就在那边显摆什么呀？", "42827");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：呵呵，我只是想说说看对不对。", "42828");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：哎，别多说了，趁紫英还没回来，<colour red=255 green=187 blue=0 alpha=255>快下山去吧！</colour>", "42829");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(2, false);
        global_mvar = 70400; // 0x00011300, 第二章 / 4-3-3.御剑逍遥 / 御剑下山
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(6803.5, -1387.9, -6605.9);
        giPlayerCurrentSetAng(201.0);
        giSetNpcVisible("4049", true);
        giSetNpcVisible("4056", false);
        giSetObjectVisible("title09", true);
        giSetObjectVisible("title10", true);
        giIMMEnd();
        giPlayerInTeam(1, false);
        giPlayerInTeam(2, false);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giScriptMusicStop(0, 2.5);
        giPlayerUnLock();
    }
}

void func2007()
{
    if (global_mvar != 70400 /* 第二章 / 4-3-3.御剑逍遥 / 御剑下山 */)
    {
        if (global_mvar != 61300 /* 第二章 / 4-3-1.御剑逍遥 / 去弟子房休息 / 初入琼华 */)
        {
            if (global_mvar == 70200 /* 第二章 / 4-3-2.御剑逍遥 / 剑舞坪修行 */)
            {
                giPlayerLock();
                giPlayerSetLeader(0);
                giPlayerWalkTo(0, 12447.8, -1831.3, -14418.8, true);
                giPlayerSetDir(0, 350.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giSetPortrait("102A", true);
                giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>剑舞坪</colour><dc0>应该是</dc0><colour red=255 green=187 blue=0 alpha=255>一出房间的那个平台</colour><dc0>吧？不是这个方向……</dc0>", "");
                giPlayerUnLock();
            }
        }
        else
        {
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerWalkTo(0, 12447.8, -1831.3, -14418.8, true);
            giPlayerSetDir(0, 350.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giSetPortrait("101A", true);
            giTalk("云天河：师叔让我们<colour red=255 green=187 blue=0 alpha=255>去前山的弟子房休息</colour><dc0>，好像不是这边……</dc0>", "");
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 12463.6, -1831.4, -14513.4);
        giPlayerSetAng(0, 190.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 12492.8, -1831.4, -14577.7);
        giPlayerSetAng(1, 260.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, 12422.2, -1831.4, -14512.4);
        giPlayerSetAng(2, 158.0);
        giPlayerSetVisible(2, true);
        giNpcSetPos("4055", 12447.3, -1831.5, -14588.4);
        giNpcSetAng("4055", 70.0);
        giSetNpcVisible("4001", false);
        giIMMEnd();
        giCameraPrepare("MC004");
        giCameraRunSingle("001", true);
        giCameraSetDistOptEnable(false);
        giFlashInBlack(1.5, true);
        giTalk("明尘：各位师弟师妹，请留步！", "42830");
        giSetPortrait("104A", false);
        giTalk("韩菱纱：咦，今天就你一个人啊？又要留步？难道这里不许人随便进，也不许人随便出去吗？", "42831");
        giTalk("明尘：师妹有所不知，你们刚刚入门，资历尚浅，若要下山，须得奉了师长之命——", "42832");
        giSetPortrait("104B", false);
        giTalk("韩菱纱：那就没问题了，正是紫英～师～叔让我们去山下办事呢。", "42833");
        giTalk("明尘：咦？师叔他……", "42834");
        giTalk("明尘：如此多有冒犯了，师弟师妹请多加小心。", "42835");
        giPlayerWalkTo(1, 12564.0, -1891.1, -14757.0, false);
        giWait(0.6);
        giPlayerWalkTo(0, 12564.0, -1891.1, -14757.0, false);
        giWait(0.5);
        giNpcSetDir("4055", 122.0, false);
        giPlayerWalkTo(2, 12482.4, -1831.4, -14509.8, true);
        giPlayerWalkTo(2, 12564.0, -1891.1, -14757.0, false);
        giWait(3.0);
        giCameraRunSingle("002", false);
        giTalk("明尘：……紫英师叔行事当真不拘一格，竟会差入门才一天的弟子下山办事……", "42836");
        giFlashOutBlack(1.5, true, true);
        giCameraSetDistOptEnable(true);
        giIMMBegin();
        giCameraRunSingle("003", false);
        giPlayerSetPos(0, 12581.4, -2023.0, -15422.0);
        giPlayerSetAng(0, 331.0);
        giPlayerSetPos(1, 12549.6, -2023.0, -15363.5);
        giPlayerSetAng(1, 103.0);
        giPlayerSetPos(2, 12600.5, -2023.0, -15369.1);
        giPlayerSetAng(2, 274.0);
        giNpcSetPos("4055", 12373.3, -1831.5, -14623.7);
        giNpcSetAng("4055", 80.0);
        giIMMEnd();
        giPlayerDoAction(1, "J13", -1, false);
        giFlashInBlack(1.5, true);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：想不到这里规矩这么多，幸好我急中生智～", "42837");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：我们私自下山已经有违门规，刚刚还说是师叔之命，我担心……", "42838");
        giPlayerSetDir(0, 2.0, false);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：不用担心啦，先玩再说！", "42839");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：可是……", "42840");
        giIMMBegin();
        giCameraRunSingle("005", false);
        giPlayerSetAng(0, 6.0);
        giPlayerSetPos(1, 12564.8, -2023.0, -15373.6);
        giPlayerSetAng(1, 158.0);
        giPlayerSetAng(2, 206.0);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：梦璃，一起走嘛，少了你就玩得不开心了……", "42841");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：嗯……云公子，梦璃知道了……", "42842");
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：哈哈，快走吧！最好飞去附近山里，好久没打猎，我手都痒了！", "42843");
        giSetPortrait("104B", false);
        giTalk("韩菱纱：谁信，只怕不是手痒，是肚子里的馋虫在闹～", "42844");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：从陈州来时，我见<colour red=255 green=187 blue=0 alpha=255>播仙镇东南烟尘无尽</colour><dc0>，似乎十分广阔，不如我们就去那里看看？</dc0>", "42845");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.5);
        giPlayerSetDir(1, 102.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：好啊，就这么定了！", "42846");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(2, false);
        global_mvar = 70500; // 0x00011364, 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(12621.8, -2023.0, -15541.7);
        giPlayerCurrentSetAng(168.0);
        giSetNpcVisible("4001", true);
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance1", false);
        giIMMEnd();
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2008()
{
    if (global_mvar != 70900 /* 第二章 / 4-4-2.叹沧桑 / 禀报掌门 */)
    {
        if (global_mvar == 101500 /* 第二章 / 6-5-1.非愿 / 求见掌门 */)
        {
            func2020();
        }
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 11885.1, -1705.3, -10936.5);
        giPlayerSetAng(0, 356.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 11974.9, -1704.7, -10921.3);
        giPlayerSetAng(1, 338.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, 11946.1, -1715.3, -10946.0);
        giPlayerSetAng(2, 349.0);
        giPlayerSetVisible(2, true);
        giPlayerSetPos(3, 11932.7, -1715.6, -10948.6);
        giPlayerSetAng(3, 353.0);
        giPlayerSetVisible(3, true);
        giIMMEnd();
        giCameraPrepare("MC005");
        giCameraRunSingle("001", true);
        giPlayerWalkTo(3, 11900.9, -1670.0, -10748.9, false);
        giFlashInBlack(2.0, false);
        giPlayerEndMove(3);
        giWait(1.0);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：掌门，弟子冒昧，有要事求见！ ", "42937");
        giWait(1.5);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerSetDir(3, 169.9914, false);
        giWait(0.3);
        giCameraRunSingle("002", true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：你们随我来。", "42938");
        giPlayerWalkTo(3, 11887.4, -1670.0, -10679.4, false);
        giWait(1.0);
        giIMMBegin();
        giCameraRunSingle("003", false);
        giPlayerSetPos(0, 11916.7, -1707.2, -10928.2);
        giPlayerSetAng(0, 352.0);
        giPlayerSetPos(1, 11969.4, -1699.0, -10900.2);
        giPlayerSetAng(1, 331.0);
        giPlayerSetPos(2, 11963.1, -1725.2, -10953.5);
        giPlayerSetAng(2, 340.0);
        giPlayerSetVisible(3, false);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：掌门说过让我们进去了吗？", "42939");
        giPlayerSetDir(1, 235.0, true);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：你又知道她没说过？说不定她是用传音入密告诉紫英的～", "42940");
        giPlayerSetDir(0, 52.0, false);
        giPlayerSetDir(2, 8.0, true);
        giSetPortrait("102C", false);
        giTalk("云天河：传音……入……密？啥玩意？", "42941");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：是种很高深的功夫，简单来说～譬如我们两个互相讲话，就只有彼此听得到。", "42942");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：这个好玩～能用来说悄悄话。", "42943");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：还不速速进来，门外喧哗，成何体统！", "42944");
        giIMMBegin();
        giCameraRunSingle("004", false);
        giPlayerSetAng(0, 354.0);
        giPlayerSetAng(1, 338.0);
        giPlayerSetAng(2, 343.0);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：哦……", "42945");
        giCameraRunSingle("005", false);
        giWait(2.8);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giIMMEnd();
        giArenaLoad("Q06", "QN03", "", true);
        giPlayerLock();
        giCameraSetCollide(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, -12.0, 0.5, 95.3);
        giPlayerSetAng(0, 162.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 38.9, 0.5, 109.5);
        giPlayerSetAng(1, 196.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, -42.8, 0.5, 130.1);
        giPlayerSetAng(2, 161.0);
        giPlayerSetVisible(2, true);
        giPlayerSetPos(3, 8.3, 0.5, -23.5);
        giPlayerSetAng(3, 192.0);
        giPlayerSetVisible(3, true);
        giNpcSetPos("MN001", 4.6, 40.9, -128.1);
        giNpcSetAng("MN001", 8.0);
        giSetNpcVisible("MN001", true);
        giIMMEnd();
        giCameraPrepare("MC004");
        giCameraRunSingle("001", true);
        giArenaReady();
        giFlashInBlack(1.5, true);
        giCameraRunSingle("002", false);
        giSetPortrait("213A", false);
        giTalk("夙瑶：紫英，你要说的便是此事？", "42946");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：是！弟子恳求掌门，若能以水灵珠施法，则解月牙村之旱并非难事。", "42947");
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("213A", false);
        giTalk("夙瑶：此事我不允。", "42948");
        giScriptMusicPlay("P34", 2, 0.0, 0.0);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：掌门？！", "42949");
        giSetPortrait("213A", false);
        giTalk("夙瑶：水灵珠乃本派宝物，非同一般，岂能做出这等“出借”之举？何况妖界即将来袭，这种时候本就不该节外生枝。", "42950");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：可是……那些村民有此一难，弟子……弟子也想不到其他办法可以帮他们……", "42951");
        giSetPortrait("213A", false);
        giTalk("夙瑶：紫英，你要知道，世间困顿比比皆是，我等修仙得道，扶危济困自是应当，却又如何管尽天下事？", "42952");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：掌门……", "42953");
        giNpcDoAction("MN001", "J04", 1, false);
        giSetPortrait("213A", false);
        giTalk("夙瑶：我意已决，此事休要再提！", "42954");
        giWait(0.6);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……是。", "42955");
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：我且问你，云天河三人初入本门，岂可私自下山？", "42956");
        giPlayerDoAction(3, "J07", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：是弟子管教无方！", "42957");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("003", false);
        giNpcSetAng("MN001", 3.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("102H", true);
        giTalk("云天河：不关师叔的事，是我们——", "42958");
        giWait(0.3);
        giNpcDoAction("MN001", "C07", -1, false);
        giSetPortrait("213B", false);
        giTalk("夙瑶：大胆！我只问紫英，何时问及他人了？", "42959");
        giWait(0.5);
        giSetPortrait("102H", true);
        giTalk("云天河：……", "42960");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", false);
        giSetPortrait("213B", false);
        giTalk("夙瑶：紫英，念你与他们三人都是初犯，本次便不再追究，若有再犯，定不饶恕！", "42961");
        giPlayerDoAction(3, "J07", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：是，多谢掌门！", "42962");
        giSetPortrait("213A", false);
        giTalk("夙瑶：……除了紫英，其他人都退下吧！", "42963");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102H", true);
        giTalk("云天河：可是掌门……那个水林猪……", "42964");
        giWait(0.3);
        giSetPortrait("213B", false);
        giTalk("夙瑶：嗯？", "42965");
        giIMMBegin();
        giCameraRunSingle("004", false);
        giPlayerSetPos(0, -3.3, 0.5, 63.5);
        giPlayerSetAng(0, 169.0);
        giPlayerSetAng(1, 213.0);
        giPlayerSetAng(2, 157.0);
        giPlayerSetAng(3, 356.0);
        giIMMEnd();
        giWait(0.7);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：出去。", "42966");
        giWait(0.5);
        giSetPortrait("102H", true);
        giTalk("云天河：我……", "42967");
        giWait(0.3);
        giPlayerSetDir(2, 140.0, true);
        giWait(0.3);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：云公子……", "42968");
        giIMMBegin();
        giPlayerSetDir(0, 320.0, false);
        giPlayerSetDir(1, 292.0, false);
        giIMMEnd();
        giWait(1.2);
        giPlayerDoAction(2, "C09", 1, true);
        giWait(0.7);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.4);
        giSetPortrait("102E", false);
        giTalk("云天河：好……知道了。", "42969");
        giWait(0.5);
        giPlayerWalkTo(2, -83.1, 0.5, 197.4, false);
        giWait(0.5);
        giPlayerWalkTo(1, -3.7, 0.5, 171.0, false);
        giWait(0.3);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 175.0, true);
        giWait(1.3);
        giPlayerWalkTo(0, -50.9, 0.5, 200.5, false);
        giPlayerEndMove(0);
        giWait(1.0);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P49", 2, 2.5, 2.5);
        giIMMBegin();
        giCameraRunSingle("005", false);
        giNpcSetAng("MN001", 9.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：紫英，你觉得他们三人资质如何？", "42970");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("006", false);
        giPlayerSetAng(3, 183.0);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：他们三人入门之前都曾略涉仙术，触类旁通，对御剑之术与基本心法领悟极快，以此看来，资质都在中上。", "42971");
        giWait(0.3);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：只是那个云天河……看似驽钝，却是深浅不明。", "42972");
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：哦？此话怎讲？", "42973");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……古人云，剑术如琴曲、如心念、如川流、如天地，可随万物而生，故修习剑术亦要顺应四时、吞饮日月，此间之功，非朝夕可成。", "42974");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：云天河虽不懂高深剑术，但是行止间内息清沛，气韵自敛，举手投足分外自如，似乎是多年静心修行方可达到的境界，令弟子也大为不解。", "42975");
        giWait(0.4);
        giSetPortrait("213A", false);
        giTalk("夙瑶：……如此说来，假以时日，他修为突飞猛进，甚至更胜于你，也不是不可能了？", "42976");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……弟子不知，且弟子识见难及掌门一二，适才所言也都是些浅见……", "42977");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.5);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("213A", false);
        giTalk("夙瑶：无妨，还有什么想法，你便一并说了吧，我想听听。", "42978");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……是。", "42955");
        giWait(0.5);
        giCameraRunSingle("006", false);
        giWait(0.5);
        giCameraRunSingle("007", false);
        giWait(0.1);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：就弟子所知，本门铸剑秘术之精，放眼凡间，几乎无人能够相较，但是云天河随身所携那把细长佩剑，铸造技艺之绝，令弟子大感汗颜。", "42980");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：弟子虽未细看，但那把剑的质地绝非乌金或玄铁，要做到如此寒光剔透、冰冷渗骨，而又不伤及手握之人，至少须取得东海海底的沦波净石、天山冰池下的寒珞玉魄，再辅以西北大荒中的上古冥灵木，揉合炼化，而这几样东西，莫说是一人之力如何得到，即便是穷千万人之力，亦是可遇而不可求。", "42981");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：何况剑身看来纤细，想必也是固若玄冰，这却是用了传说中的“百炼之法”，定要反复锻冶，无一次差错！弟子实难想像，那位铸剑之人是何等的神乎奇技……", "42982");
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：……", "42983");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：云天河既能拥有这样一把不世出的宝剑，又能驾驭于它，此人应是大有来历……", "42984");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("008", false);
        giNpcSetAng("MN001", 19.0);
        giPlayerSetAng(3, 203.0);
        giIMMEnd();
        giWait(0.5);
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("213A", false);
        giTalk("夙瑶：……你猜的不错，那把剑确实非同寻常，只不过……", "42985");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：掌门……莫非知晓剑的出处？可否示下，若有机缘，弟子实在很想拜访一下那位铸剑高人！", "42986");
        giWait(0.4);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("213A", false);
        giTalk("夙瑶：据我所知，他早已过世，云天河对此剑来历亦是一无所知。", "42987");
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：……你须谨记，只教授他们三人简单的练气吐纳，其他高深剑术不必涉及，谈及本派秘事，更要谨慎出口。", "42988");
        giWait(0.4);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：……掌门，弟子不明……", "42989");
        giPlayerEndAction(3);
        giSetPortrait("213A", false);
        giTalk("夙瑶：其余不必多问，我令他们入门，乃是另有机缘，日后你自会晓得。", "42990");
        giWait(0.5);
        giPlayerDoAction(3, "J07", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……是。", "42991");
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：其他无事，退下吧。", "42992");
        giWait(1.0);
        giIMMBegin();
        giCameraRunSingle("006", false);
        giPlayerSetAng(3, 183.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……", "42993");
        giSetPortrait("213A", false);
        giTalk("夙瑶：莫非还有其他事想要禀报？", "42994");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：掌门，弟子斗胆一问，水灵珠之事是否还有商榷余地？", "42995");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("009", false);
        giNpcSetAng("MN001", 18.0);
        giPlayerSetPos(3, 12.0, 0.5, -8.6);
        giPlayerSetAng(3, 201.0);
        giIMMEnd();
        giWait(0.7);
        giSetPortrait("213C", false);
        giTalk("夙瑶：哦？这么说来，我适才的决定，你却是口服心不服？", "42996");
        giPlayerDoAction(3, "J07", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：弟子不敢。", "42997");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：弟子只觉修仙之士虽非样样皆能，但毕竟能救一人便是一人，弟子实在不忍看那些村民如此受苦……", "42998");
        giWait(0.3);
        giNpcDoAction("MN001", "J04", 1, false);
        giSetPortrait("213B", false);
        giTalk("夙瑶：慕容紫英！", "42999");
        giWait(0.6);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：弟子在！", "43000");
        giNpcDoAction("MN001", "C07", -1, false);
        giSetPortrait("213B", false);
        giTalk("夙瑶：你可还记得昔日在宗炼长老面前，曾立下怎样的重誓？", "43001");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：弟子一日不敢或忘，弟子曾发誓，终身以修仙积德、捍卫天下为己任，对本门更不可有叛逆之心！若有相违，则要受五雷轰顶、神魂俱灭之祸！", "43002");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("213B", false);
        giTalk("夙瑶：你师父被妖孽所害，早早亡故，宗炼长老虽名义上是你师公，实则待你如徒儿一般，连自己的铸剑秘术都倾囊相授，便是希望有朝一日你能成为本派栋梁，但你今日表现太令我失望了！", "43003");
        giPlayerDoAction(3, "J08", -1, false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：弟子惭愧！", "43004");
        giSetPortrait("213B", false);
        giTalk("夙瑶：你口说惭愧，心中却不知为何惭愧！", "43005");
        giSetPortrait("213B", false);
        giTalk("夙瑶：这世上苦痛之人千千万万，你一日救得一个，数十年下来虽有小成，又怎比得上修成仙身、法力无边之时，倾刻便能解救千百？", "43006");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……掌门说得是，只是……弟子想到那些村民的痛苦，却是半刻也平静不下来，这种心绪纷乱，弟子不知如何是好……", "43007");
        giNpcDoAction("MN001", "C07", -1, false);
        giSetPortrait("213B", false);
        giTalk("夙瑶：你若不知如何是好，便想想十九年前，本门与妖界一战，多少弟子就此埋骨，连前代掌门都未能幸免，你师公宗炼长老亦是身受重创，至死不治……", "43008");
        giSetPortrait("213B", false);
        giTalk("夙瑶：这一回，如有危急，水灵珠蕴涵的法力说不定会成为我们抵挡妖界之助，你刻下的举动，只顾眼前，因小失大，届时我方势弱，昆仑山脚下生灵涂炭，远胜月牙村之灾！", "43009");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：这！弟子太过短视……", "43010");
        giSetPortrait("213B", false);
        giTalk("夙瑶：紫英，你以前从不会这样，莫非短短时间，便沾染了云天河那几人的浮躁？", "43011");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……！！", "43012");
        giWait(0.6);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("213B", false);
        giTalk("夙瑶：也罢，今日我言尽于此，能领悟多少，看你自己的造化了。", "43013");
        giSetPortrait("213B", false);
        giTalk("夙瑶：退下吧。", "43014");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……", "43015");
        giFlashOutBlack(1.5, true, true);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("4005", false);
        giIMMEnd();
        giArenaLoad("Q06", "Q06Q", "", true);
        giPlayerLock();
        giCameraSetCollide(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 12069.9, -1759.3, -12146.8);
        giPlayerSetAng(0, 39.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 12134.9, -1759.3, -12136.9);
        giPlayerSetAng(1, 274.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, 12112.1, -1759.3, -12095.3);
        giPlayerSetAng(2, 227.0);
        giPlayerSetVisible(2, true);
        giIMMEnd();
        giCameraPrepare("MC006");
        giCameraRunSingle("002", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giPlayerDoAction(0, "J15", 0, false);
        giSetPortrait("102H", false);
        giTalk("云天河：怎么办？掌门不肯借那个宝物……", "43016");
        giPlayerEndAction(0);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：我看她心意坚决，怕是很难改变主意了。", "43017");
        giWait(0.5);
        giSetPortrait("102H", false);
        giTalk("云天河：爹说过，做人不能太小气……", "43018");
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：又不是借了就不还她，也不知那只“水林猪”多贵重，大不了拿我们的“土林猪”跟她换，听起来都差不多。", "43019");
        giPlayerEndAction(0);
        giIMMBegin();
        giCameraRunSingle("003", false);
        giPlayerSetAng(0, 68.0);
        giPlayerSetAng(1, 252.0);
        giPlayerSetAng(2, 162.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：差很多好不好……", "43020");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：唉，怎么又觉得好累……算了，<colour red=255 green=187 blue=0 alpha=255>我们先各自回房吧，</colour><dc0>想想还有没有其他办法，不行的话，晚上再偷溜出去，给月牙村的人送些水和吃的～</dc0>", "43021");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：嗯，也只能先这样了。", "43022");
        giWait(0.5);
        giPlayerWalkTo(0, 12011.4, -1759.6, -12259.8, false);
        giWait(1.0);
        giPlayerSetDir(2, 208.0, false);
        giPlayerSetDir(1, 233.0, true);
        giWait(0.7);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：云公子……", "43023");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：别管他，他这人小孩子脾气，过一会儿就好了。", "43024");
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.4);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(2, false);
        giSetObjectVisible("entrance0", false);
        giSetObjectVisible("entrance1", true);
        global_mvar = 71200; // 0x00011620, 第二章 / 4-4-3.叹沧桑 / 回房休息 / 沙地助人
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(11459.0, -1759.3, -12469.1);
        giPlayerCurrentSetAng(277.0);
        giSetNpcVisible("4005", true);
        giIMMEnd();
        giPlayerOutTeam(1, false);
        giPlayerOutTeam(2, false);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2010()
{
    if (global_mvar == 71900 /* 第二章 / 5-1-3.寒剑夜鸣 / 进入山洞 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 1240.6, 131.0, 644.8);
        giPlayerSetAng(0, 10.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 1204.0, 131.0, 690.3);
        giPlayerSetAng(1, 66.0);
        giPlayerSetVisible(1, true);
        giPlayerSetPos(2, 1252.2, 131.0, 719.4);
        giPlayerSetAng(2, 44.0);
        giPlayerSetVisible(2, true);
        giAddPlayerFavor(0, 3, 10);
        giAddPlayerFavor(1, 3, 10);
        giAddPlayerFavor(2, 3, 10);
        giAddPlayerFavor(3, 0, 10);
        giAddPlayerFavor(3, 1, 20);
        giAddPlayerFavor(3, 2, 10);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：一边冷死、一边热死，这究竟是什么怪地方啊……幸好里面没镇着可怕的妖怪。", "43079");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("102A", false);
        giTalk("云天河：这里～和爹的墓室有点像……", "43080");
        giPlayerWalkTo(2, 1279.1, 131.0, 746.8, true);
        giSetPortrait("107E", true);
        giTalk("柳梦璃：你们，快看！", "43081");
        giWait(0.5);
        giPlayerSetDir(0, 28.0, true);
        giPlayerSetDir(1, 56.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：冰……冰里有什么……", "43082");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("002", true);
        giCameraRunSingle("003", true);
        giIMMBegin();
        giPlayerSetPos(0, 1262.5, 131.0, 722.1);
        giPlayerSetAng(0, 28.0);
        giPlayerSetPos(1, 1203.1, 131.0, 699.2);
        giPlayerSetAng(1, 56.0);
        giPlayerSetPos(2, 1279.1, 131.0, 668.8);
        giPlayerSetAng(2, 28.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerWalkTo(0, 1287.0, 131.0, 757.0, true);
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：云公子，小心点……", "43083");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.5);
        gi2DSoundPlay("WE208", 1);
        giSetObjectVisible("effect017", true);
        giWait(3.5);
        giSetObjectVisible("effect017", false);
        giWait(1.2);
        giCameraRunSingle("004", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：咦？那把剑……", "43084");
        giWait(0.5);
        giSetPortrait("102C", false);
        giTalk("云天河：……这个人又是谁？怎么会在冰里？", "43085");
        giScriptMusicPlay("P27", 0, 2.5, 2.5);
        giWait(1.0);
        giTalk("？？：此话应是由我来问，你们不知擅闯琼华禁地乃是重罪？", "43086");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", false);
        giTalk("韩菱纱：呀！尸体、尸体还会说话！", "43087");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：这个人还活着，和我们说话的正是他的生灵，只不过气息很弱……", "43088");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetPos(0, 1262.5, 131.0, 722.1);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.7);
        giTalk("？？：……少年人，你，能否靠近一些？", "43089");
        giSetPortrait("102A", true);
        giTalk("云天河：我吗？", "43090");
        giPlayerWalkTo(0, 1287.0, 131.0, 757.0, true);
        giWait(1.0);
        giTalk("？？：……你的长相，果真……你，可认识一个叫云天青的人？", "43091");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：……他是我爹啊。", "43092");
        giPlayerEndAction(0);
        giWait(0.5);
        giTalk("？？：你……你叫什么名字？", "43093");
        giSetPortrait("102A", true);
        giTalk("云天河：名字？我叫云天河。", "43094");
        giWait(0.8);
        giTalk("？？：……天……河……天悬星河……", "43095");
        giWait(0.8);
        giTalk("？？：你娘是不是叫夙玉？", "43096");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102D", true);
        giTalk("云天河：对啊。", "43097");
        giWait(0.8);
        giTalk("？？：…………", "43098");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102D", true);
        giTalk("云天河：到处都有人认识我爹，这次头一回有人问起我娘呢，娘也是琼华派的人吗？", "43099");
        giSetPortrait("102A", true);
        giTalk("云天河：你又是谁啊？怎会认识我爹娘？", "43100");
        giWait(0.6);
        giCameraRunSingle("007", false);
        giTalk("？？：……吾名玄霄，乃是你爹和你娘的师兄。", "43101");
        giTalk("玄霄：而你身上所携之剑名为“望舒”，与冰中的“羲和”正是一阴一阳的配剑，以日月之神为名，原本都归本派所有。", "43102");
        giSetPortrait("102C", true);
        giTalk("云天河：“望舒”……“羲和” ……", "43103");
        giWait(0.5);
        giDelProperty(3101, 1, false);
        giAddProperty(3102, 1, false);
        giFlashOutBlack(2.3, true, true);
        giCameraRunSingle("001", true);
        giArenaLoad("Q06", "QN05Y", "", true);
        giPlayerLock();
        giPlayerCurrentSetVisible(false);
        giPlayerSetVisible(3, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(3, 37.6, 0.7, 31.2);
        giPlayerSetAng(3, 334.0);
        giCameraPrepare("MC002");
        giCameraRunSingle("002", true);
        giArenaReady();
        giFlashInBlack(1.5, true);
        giWait(0.8);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：（云天河！半夜不在房中，跑去哪里胡闹！）", "43104");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：（……守夜弟子也说无人御剑离去……）", "43105");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：（莫非是………………）", "43106");
        giWait(0.5);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：（禁地？！）", "43107");
        giPlayerDoAction(3, "J13", 1, false);
        giWait(0.3);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：（……以他们的放肆，闯去那里自然也不稀奇，真是太过胡来！）", "43108");
        giWait(0.4);
        giPlayerWalkTo(3, -24.1, 0.7, 102.3, false);
        giWait(0.3);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndMove(3);
        giPlayerSetVisible(3, false);
        giArenaLoad("Q06", "Q06H", "", true);
        giPlayerLock();
        giPlayerSetPos(0, 1274.0, 131.0, 712.1);
        giPlayerSetAng(0, 28.0);
        giPlayerSetPos(1, 1217.1, 131.0, 715.0);
        giPlayerSetAng(1, 56.0);
        giPlayerSetPos(2, 1272.1, 131.0, 659.9);
        giPlayerSetAng(2, 40.0);
        giPlayerCurrentSetVisible(false);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giArenaReady();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giCameraRunSingle("002", false);
        giFlashInBlack(1.5, true);
        giWait(0.8);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：你……你是天河爹娘的师兄？那，我们应该称你为前辈了？", "43109");
        giSetPortrait("104C", false);
        giTalk("韩菱纱：但是，你看起来一点都不老啊……", "43110");
        giTalk("玄霄：……前辈后辈，不过都是些繁文缛节，何必理会。", "43111");
        giTalk("玄霄：我于冰中，不知外界年月流逝，只不过看来容颜未老罢了。", "43112");
        giSetPortrait("102A", true);
        giTalk("云天河：玄霄……你刚才说……这把剑是琼华派的东西，那为什么又会变成爹传给我的呢？", "43113");
        giCameraRunSingle("003", true);
        giCameraRunSingle("004", false);
        giTalk("玄霄：你可是不信？", "43114");
        giTalk("玄霄：望舒、羲和经久重逢，才会发出共鸣。想必你们也并非无缘无故闯入禁地，那便是最好的证明。", "43115");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：不是，我没有不信，只是觉得奇怪，再说……上回菱纱问掌门，她也没告诉我们……", "43116");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giCameraRunSingle("006", false);
        giTalk("玄霄：……是你爹和你娘让你上山来的？", "43117");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：不是，爹早就死了，娘也死了，他们什么也没告诉我。", "43118");
        giWait(0.7);
        giTalk("玄霄：……死了吗？……他们都已经……都已经……唉……", "43119");
        giWait(0.7);
        giTalk("玄霄：……我原以为自己常年于冰中，早已心如止水……不想听到故人噩耗，仍是百感交集……", "43120");
        giWait(0.5);
        giCameraRunSingle("007", true);
        giCameraRunSingle("008", false);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：……我不小心闯进爹和娘的墓室，看到一些东西……我想知道他们以前是什么样的人，才会跑来琼华派。", "43121");
        giTalk("玄霄：哦？你在那墓中所见为何？", "43122");
        giWait(0.5);
        giSetPortrait("102A", true);
        giTalk("云天河：……其实，要是菱纱不说，我也不觉得有多奇怪……那个房间里全都是冰，把我娘的棺木都埋了起来，还有一块会发光的玉……", "43123");
        giCameraRunSingle("009", true);
        giCameraRunSingle("010", false);
        giWait(0.3);
        giTalk("玄霄：……那块玉，你们是否用它打开了禁地石门？", "43124");
        giSetPortrait("102A", true);
        giTalk("云天河：对啊，就是这个～", "43125");
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.6);
        giSetObjectVisible("MO003", true);
        giWait(1.0);
        giTalk("玄霄：……灵光藻玉，想不到我有生之年还能再见……", "43126");
        giWait(0.8);
        giSetObjectVisible("MO003", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giDelProperty(3104, 1, false);
        giAddProperty(3105, 1, false);
        giCameraRunSingle("011", true);
        giTalk("玄霄：人生百岁，终归尘土。当初我们三人一同修炼仙道、参研剑术，正当风华之年，如今却只剩我一人……", "43127");
        giWait(0.5);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：只剩你一个……但是，这儿冷到骨子里了，你干嘛一个人待在这里呢？", "43128");
        giWait(1.0);
        giTalk("玄霄：……云天河，你应该自小就十分畏寒吧？进入此地岂非度日如年？", "43129");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：不会啊，我身体一直好好的，也没觉得这儿很冷～倒是爹和娘，他们都特别怕冷……", "43130");
        giTalk("玄霄：……！！", "43131");
        giTalk("玄霄：这……怎么可能……不可能……", "43132");
        giSetPortrait("102A", false);
        giTalk("云天河：什么？", "43133");
        giWait(0.4);
        giTalk("玄霄：噤声！……又有人闯入，今天可真是热闹。", "43134");
        giIMMBegin();
        giPlayerSetPos(3, 1150.9, 119.9, 490.2);
        giPlayerSetVisible(3, true);
        giIMMEnd();
        giPlayerSetDir(0, 188.0, false);
        giPlayerSetDir(1, 180.0, false);
        giPlayerSetDir(2, 196.0, false);
        giWait(0.5);
        giCameraRunSingle("012", false);
        giPlayerWalkTo(3, 1208.3, 131.0, 563.7, true);
        giCameraWait();
        giWait(0.8);
        giIMMBegin();
        giPlayerSetPos(0, 1233.4, 131.0, 747.1);
        giPlayerSetPos(1, 1202.1, 131.0, 706.9);
        giPlayerSetPos(2, 1241.7, 131.0, 675.5);
        giPlayerSetAng(0, 176.0);
        giPlayerSetAng(1, 174.0);
        giPlayerSetAng(2, 192.0);
        giCameraRunSingle("013", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(3, "J13", 1, false);
        giWait(0.2);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：云天河！你们简直目无规矩！连禁地都敢闯！", "43135");
        giWait(0.5);
        giCameraRunSingle("014", true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.3);
        giSetPortrait("102E", true);
        giTalk("云天河：可是……师叔你不是也来了吗？", "43136");
        giSetPortrait("105F", false);
        giTalk("慕容紫英：岂有此理！", "43137");
        giWait(0.8);
        giTalk("玄霄：既已来了，又何必大呼小叫？这禁地中并无惊世骇俗之物。", "43138");
        giSetPortrait("105C", false);
        giTalk("慕容紫英：……！！", "43139");
        giWait(0.5);
        giPlayerSetDir(3, 30.0, true);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：你是……？", "43140");
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：我们也吓一跳呢，想不到这里会有人，玄霄他还是天河爹娘的师兄！", "43141");
        giWait(0.5);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：玄、霄……", "43142");
        giSetPortrait("105D", false);
        giTalk("慕容紫英：你！你是玄霄师叔？！", "43143");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：啊？！师叔的师叔……", "43144");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerWalkTo(3, 1296.5, 131.0, 681.1, false);
        giWait(0.5);
        giCameraRunSingle("015", true);
        giWait(1.2);
        giPlayerSetDir(0, 138.0, false);
        giPlayerSetDir(1, 110.0, false);
        giPlayerSetDir(2, 90.0, false);
        giPlayerEndMove(3);
        giPlayerSetAng(3, 32.0);
        giPlayerDoAction(3, "J08", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：师叔在上，请受弟子一拜！", "43145");
        giWait(0.7);
        giTalk("玄霄：哦？你是何人门下？竟负有寒月冰魄所铸的剑匣？", "43146");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：弟子慕容紫英。曾蒙宗炼长老传授武功心法、以及铸剑之术。", "43147");
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giCameraRunSingle("016", true);
        giIMMEnd();
        giCameraRunSingle("017", false);
        giWait(0.5);
        giTalk("玄霄：…… 宗炼？他如今……过得如何？", "43148");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：师公……早些年便已过世了……", "43149");
        giWait(0.6);
        giTalk("玄霄：……他曾告知你，我在禁地？", "43150");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：师公并未说过，他只交代，若有生之年得见玄霄师叔，必要恭敬相待。师叔有任何差遣，不问原由，弟子纵然粉身碎骨也要达成。", "43151");
        giWait(0.5);
        giTalk("玄霄：……我不过是个遭弃之人，宗炼未免小题大做。", "43152");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……无论如何，弟子自当谨遵师公之命。", "43153");
        giWait(0.5);
        giTalk("玄霄：不问原由？好、好！", "43154");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giPlayerSetAng(0, 50.0);
        giPlayerSetAng(1, 90.0);
        giPlayerSetAng(2, 70.0);
        giCameraRunSingle("018", true);
        giIMMEnd();
        giTalk("玄霄：既然如此，我便吩咐你两件事，第一，禁地发生这种种事情，不必告知掌门。", "43155");
        giWait(0.5);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：这……", "43156");
        giTalk("玄霄：如何？令你为难？", "43157");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不，弟子听命。", "43158");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giTalk("玄霄：第二，其他几人闯入禁地，依照门规本应重罚，但我命你不可追究此事。", "43159");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……是！", "43160");
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：就是说不用被训？哈哈！", "43161");
        giPlayerEndAction(0);
        giTalk("玄霄：……你们闯入禁地已经很久，<colour red=255 green=187 blue=0 alpha=255>都回去吧，</colour><dc0>即便有种种疑问，也无须再提，只当幻梦一场。</dc0>", "43162");
        giWait(0.5);
        giSetPortrait("102B", false);
        giTalk("云天河：那……还能再来吗？", "43163");
        giWait(0.3);
        giPlayerSetDir(3, 322.0, true);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：云天河！你将本门禁地当成什么地方！", "43164");
        giWait(0.6);
        giTalk("玄霄：…………", "43165");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：不行吗？", "43166");
        giTalk("玄霄：若想来此，改日再说吧。", "43167");
        giWait(0.3);
        giPlayerSetDir(3, 28.0, true);
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：师叔……？", "43168");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：好，改日～呵呵。", "43169");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(1271.0, 131.0, 720.7);
        giPlayerCurrentSetAng(4.5);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        global_mvar = 72200; // 0x00011A08, 第二章 / 5-1-4.寒剑夜鸣 / 离开禁地
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
        giIMMEnd();
        giFlashInBlack(1.5, true);
    }
}

void func2011()
{
    if (global_mvar != 80100 /* 第二章 / 5-1-5.寒剑夜鸣 / 回房睡觉 / 寒剑夜鸣 */)
    {
        func2098();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(0, 82.2, 26.7, -54.0);
        giPlayerSetAng(0, 270.0);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giPlayerOutTeam(1, false);
        giPlayerOutTeam(2, false);
        giPlayerDoAction(0, "C11", 0, false);
        giFlashInBlack(1.5, true);
        giWait(1.0);
        giSetPortrait("102B", false);
        giTalk("云天河：（……玄霄……呵呵，感觉跟爹有点像，可是又不太一样……）", "43224");
        giSetPortrait("102B", false);
        giTalk("云天河：（……他以前和爹、还有娘一定很要好吧？后来为什么会被封在冰里呢？）", "43225");
        giSetPortrait("102B", false);
        giTalk("云天河：（下回见面一定要问他……）", "43226");
        giPlayerSetEmotion(0, "102_by");
        giWait(1.0);
        giFlashOutBlack(1.5, true, true);
        giPlayerTakeARest();
        giWait(3.0);
        giPlayerSetVisible(0, false);
        giArenaLoad("Q06", "QN05", "", true);
        giPlayerLock();
        giScriptMusicPlay("P23", 0, 0.0, 0.0);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 59.3, 0.7, 17.5);
        giPlayerSetAng(0, 336.0);
        giPlayerSetPos(3, -24.8, 0.7, 66.4);
        giPlayerSetAng(3, 132.0);
        giPlayerSetVisible(0, true);
        giSetObjectVisible("MO002", true);
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giPlayerResetEmotion(0);
        giArenaReady();
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：唔……今天好清静，是不是还早？", "43227");
        gi2DSoundPlay("WJ025", 1);
        giWait(1.0);
        giPlayerSetVisible(3, true);
        giCameraRunSingle("002", true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：无人喊你起床，自然清静。", "43228");
        giCameraWait();
        giPlayerSetDir(0, 306.0, true);
        giSetPortrait("102D", false);
        giTalk("云天河：呃……师叔，我、又起晚了？", "43229");
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.8);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：云天河，你一再不上早课，更无悔改之心，今日罚你去思返谷思过，直至子时方可出来！", "43230");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102D", false);
        giTalk("云天河：要去一整天？！那，一日三顿饭怎么办？", "43231");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：思过便是思过，岂能容你存有这些杂念！", "43232");
        giSetPortrait("102D", false);
        giTalk("云天河：…………", "43233");
        giWait(0.5);
        giPlayerDoAction(0, "J15", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：（菱纱，你乱说，他算什么好人……）", "43234");
        giWait(0.8);
        giPlayerSetDir(3, 90.0, true);
        giWait(0.8);
        giCameraRunSingle("004", false);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……你的佩剑为何沾有杂尘？为何不擦拭干净？", "43235");
        giCameraWait();
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：能用就好，反正一剑射出去没射偏就成了……", "43236");
        giWait(0.5);
        giPlayerSetDir(3, 132.0, true);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：什么意思？平时如何使用这把剑？", "43237");
        giWait(0.5);
        giSetPortrait("102A", false);
        giTalk("云天河：我想想啊……", "43238");
        giWait(0.8);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：从小打猎都是把这剑搭在弓上射出去，哈哈～很好用的，这把剑很利，那些猪啊熊啊一下子就……", "43239");
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：停！还有呢？", "43240");
        giWait(0.5);
        giSetPortrait("102K", false);
        giTalk("云天河：剥兽皮，可以做成衣服、被子，很不错的，呵呵。", "43241");
        giWait(0.5);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：……还、还有呢？", "43242");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：有时拿来砍柴啦，但不是很好用，锯木头搭房子倒是不错，唰唰几下木板就切成了，我的树屋就是这么建出来的～", "43243");
        giSetPortrait("105D", true);
        giTalk("慕容紫英：…………还有……吗？", "43244");
        giSetPortrait("102K", false);
        giTalk("云天河：剪发、剃胡子、切肉、削萝卜也靠它，还有用它把肉串起来烤～可惜剑太利了，有时候烤着烤着，肉突然就变两半掉到火里了，真是可惜……唉～～～", "43245");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("005", false);
        giPlayerWalkTo(3, 1.9, 0.7, 49.6, true);
        giPlayerSetAng(3, 134.0);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：…………还……有……没……有？", "43246");
        giCameraWait();
        giWait(0.5);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：唔……总之好处多多啦，最近御剑时也用它，但这剑太细，踩着不舒服。", "43247");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……………………………", "43248");
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：师叔你脸色好差，是不是昨晚没睡好？", "43249");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……………………………", "43250");
        giSetPortrait("102B", false);
        giTalk("云天河：师叔？", "43251");
        giWait(0.5);
        giCameraRunSingle("006", false);
        giPlayerWalkTo(3, 29.9, 0.7, 35.6, true);
        giPlayerSetAng(3, 126.0);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：云、天、河！！", "43252");
        giPlayerBackTo(0, 65.9, 0.7, 11.7, true);
        giSetPortrait("102D", false);
        giTalk("云天河：啊！怎么了？！", "43253");
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：你立刻滚到思返谷思过！立刻！！", "43254");
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("102D", false);
        giTalk("云天河：（好、好凶……为什么突然气成这样…………）", "43255");
        giWait(0.5);
        giPlayerSetDir(3, 324.0, true);
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：（我需要一个人静一静……）", "43256");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(3);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(3, false);
        giIMMEnd();
        giArenaLoad("Q06", "Q06SY", "", true);
        giPlayerLock();
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -19.8, 0.9, -92.1);
        giPlayerSetAng(0, 182.0);
        giPlayerSetVisible(0, true);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giArenaReady();
        giPlayerDoAction(0, "C10", 0, false);
        giWait(3.0);
        giFlashInBlack(2.5, true);
        giSetPortrait("102E", true);
        giTalk("云天河：唉，无聊，天早黑了……什么“思过”，就是让人坐在地上发呆……", "43257");
        giWait(0.8);
        giSetPortrait("202A", true);
        giTalk("璇玑：你啊～抱怨什么呢，小心被紫英师叔听见，罚得更重！", "43258");
        giWait(0.5);
        giCameraRunSingle("002", true);
        giPlayerEndAction(0);
        giWait(0.7);
        giPlayerSetDir(0, 54.0, true);
        giWait(0.8);
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：怀朔、璇玑！是你们？", "43259");
        giPlayerEndAction(0);
        giCameraRunSingle("003", false);
        giPlayerRunTo(0, 109.3, 0.9, -30.8, true);
        giPlayerSetAng(0, 74.0);
        giCameraWait();
        giCameraRunSingle("004", false);
        giSetPortrait("202A", true);
        giTalk("璇玑：怎么不是～", "43260");
        giNpcDoAction("MN001", "J03", 1, false);
        giSetPortrait("202A", true);
        giTalk("璇玑：你入门时间不长，丰功伟绩倒是不少，嘻嘻，能被紫英师叔送来思返谷的，你还是第一个！连我和师兄都忍不住要来看看了。", "43261");
        giWait(0.5);
        giSetPortrait("102K", false);
        giTalk("云天河：……第一个？这么说，我算很厉害啰？", "43262");
        giNpcDoAction("MN001", "J01", 1, false);
        giSetPortrait("202D", true);
        giTalk("璇玑：讨厌～你是真的不懂，还是装傻啊？", "43263");
        giWait(0.6);
        giSetPortrait("203B", true);
        giTalk("怀朔：璇玑，别闹了。", "43264");
        giCameraRunSingle("005", false);
        giSetPortrait("203B", true);
        giTalk("怀朔：天河，恭喜你入门！自那以后我和璇玑也一直在忙，毕竟妖界之事攸关许多人生死，大家都要严阵以待，所以拖到今日才来见你一面。", "43265");
        giNpcDoAction("MN001", "J03", 1, false);
        giSetPortrait("202A", true);
        giTalk("璇玑：想不到呀～就见着一个落难的，哈哈。", "43266");
        giWait(0.8);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：这里好无聊，我什么时候可以出去啊？", "43267");
        giWait(0.6);
        giSetPortrait("203B", true);
        giTalk("怀朔：依照本门规矩，<colour red=255 green=187 blue=0 alpha=255>子时已过，你可以走了，</colour><dc0>要不然我和璇玑也不敢来打扰。</dc0>", "43268");
        giWait(0.5);
        giSetPortrait("102K", false);
        giTalk("云天河：什么敢不敢，你们想找我玩，任何时候都可以的～", "43269");
        giSetPortrait("202A", true);
        giTalk("璇玑：不和你说了～我和师兄也有好多事要忙，来打个招呼就得走，菱纱、梦璃方才都已经见过了。", "43270");
        giSetPortrait("102B", false);
        giTalk("云天河：这么快就要走？", "43271");
        giNpcDoAction("MN002", "C08", 1, false);
        giSetPortrait("203B", true);
        giTalk("怀朔：你多保重，既是同门，见面的机会还很多，不在一时一刻。", "43272");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, true);
        giWait(0.8);
        giNpcWalkTo("MN001", 282.8, 0.9, 43.3, false);
        giNpcWalkTo("MN002", 296.8, 0.9, 19.0, true);
        giNpcEndMove("MN001");
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("001", true);
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giPlayerSetVisible(0, false);
        giCameraSetCollide(true);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(109.3, 0.9, -30.8);
        giPlayerCurrentSetAng(74.0);
        global_mvar = 80400; // 0x00013A10, 第二章 / 5-2-1.心事难明 / 思过结束
        giIMMEnd();
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giScriptMusicStop(2, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2012()
{
    if (global_mvar == 80400 /* 第二章 / 5-2-1.心事难明 / 思过结束 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P25", 2, 0.0, 0.0);
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetObjectVisible("entrance3", false);
        giPlayerSetPos(0, 9156.0, -1382.2, 221.6);
        giPlayerSetPos(1, 10954.7, -1383.1, 271.2);
        giPlayerSetAng(1, 280.0);
        giPlayerSetPos(2, 9333.1, -1382.7, 96.4);
        giPlayerSetAng(2, 294.0);
        giPlayerSetPos(3, 10771.6, -1382.9, 308.1);
        giPlayerSetAng(3, 300.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(2, true);
        giIMMEnd();
        giArenaReady();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(0, 9263.2, -1381.2, 128.0, true);
        giPlayerSetAng(0, 110.0);
        giSetPortrait("102B", true);
        giTalk("云天河：梦璃，你怎么在这？菱纱呢？", "43273");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：她不在房间里，不知去了哪……", "43274");
        giSetPortrait("107B", false);
        giTalk("柳梦璃：我、听说云公子被责罚，有点担心，所以才过来看看。", "43275");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102F", true);
        giTalk("云天河：呵呵，我没什么的～", "43276");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：嗯，没事就好。", "43277");
        giSetPortrait("102A", true);
        giTalk("云天河：……梦、梦璃……", "43278");
        giSetPortrait("107B", false);
        giTalk("柳梦璃：什么？", "43279");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：你这几天……好像都不太开心？", "43280");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：……原来，还是很明显吗？", "43281");
        giPlayerEndAction(2);
        giPlayerDoAction(0, "C08", 1, true);
        giWait(1.0);
        giCameraRunSingle("003", true);
        giPlayerSetVisible(0, false);
        giCameraRunSingle("004", false);
        giSetPortrait("107F", false);
        giTalk("柳梦璃：我自从听说要和妖界开战，便总觉得心里烦闷。", "43282");
        giSetPortrait("107F", false);
        giTalk("柳梦璃：近日看琼华派其他弟子，其实大家都不清楚妖的实力深浅，若像十九年前那场惨烈大战，你、我、菱纱，我们可能都会……", "43283");
        giSetPortrait("102A", true);
        giTalk("云天河：梦璃，你害怕吗？", "43284");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107F", false);
        giTalk("柳梦璃：我不怕死，我怕的是、是……", "43285");
        giSetPortrait("107F", false);
        giTalk("柳梦璃：那种感觉连我自己都不明白，就像脑中有团影子，但却没办法看清是什么……", "43286");
        giSetPortrait("107F", false);
        giTalk("柳梦璃：我也不喜欢看见流血、受伤……不管是人还是妖……", "43287");
        giSetPortrait("102A", true);
        giTalk("云天河：……", "43288");
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107F", false);
        giTalk("柳梦璃：……云公子，记得你说过，人和妖都是一样，不是一定谁要杀谁，你到现在还这么想吗？", "43289");
        giPlayerEndAction(2);
        giWait(0.7);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(2, false);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giCameraRunSingle("008", false);
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102J", true);
        giTalk("云天河：是啊～人和妖就算长相差很多，也不用一见面就斗个你死我活吧？那样多累～", "43290");
        giSetPortrait("102J", true);
        giTalk("云天河：我才不管妖界是怎样的，但他们不能伤害我身边的人！", "43291");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102J", true);
        giTalk("云天河：尤其你和菱纱，是除了爹娘以外跟我最亲的人，我早就想好了，我云天河一定要保护你们一生一世，不管今后发生什么，也都要做到！", "43292");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("107E", false);
        giTalk("柳梦璃：云公子，你……", "43293");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetVisible(2, true);
        giPlayerSetAng(0, 118.0);
        giPlayerSetAng(2, 290.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giCameraRunSingle("010", false);
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：……其实，这些日子以来，和云公子在一起，我会觉得很安心，你和其他很多人都不同，总是那么磊落坦荡……", "43294");
        giSetPortrait("107B", true);
        giTalk("柳梦璃：我从小到大最开心的就是这段日子了，能看到许多风景，跟许多人说话……云公子和菱纱都是很好的人，是最好的伙伴……", "43295");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：我觉得……自己这段时间也变了不少，有时候想着，要是又回山上一个人过日子，会不会不习惯了……", "43296");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giIMMBegin();
        giCameraRunSingle("005", true);
        giIMMEnd();
        giCameraRunSingle("006", false);
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：很谢谢云公子要保护我与菱纱一生一世……我听了真的很高兴……只要云公子不嫌弃我，我们可以一起…………去很多地方玩……", "43297");
        giPlayerEndAction(2);
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("102F", false);
        giTalk("云天河：嫌弃？怎么会啊！梦璃你、你话不要这么说……", "43298");
        giSetPortrait("107D", true);
        giTalk("柳梦璃：咦，怎么了？你脸红成这样。", "43299");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("102F", false);
        giTalk("云天河：没、没有，梦璃，我、我想先走了！", "43300");
        giPlayerEndAction(0);
        giSetPortrait("102F", false);
        giTalk("云天河：（奇怪……看到梦璃笑，心就跳得好快……气也不太顺了，这到底是怎么回事……）", "43301");
        giSetPortrait("107D", true);
        giTalk("柳梦璃：云公子？", "43302");
        giSetPortrait("102F", false);
        giTalk("云天河：没、没什么！我……我离开一下！", "43303");
        giPlayerRunTo(0, 9165.7, -1378.0, 45.2, false);
        giWait(0.5);
        giCameraRunSingle("011", false);
        giWait(1.0);
        giPlayerSetDir(2, 238.0, true);
        giPlayerEndMove(0);
        giPlayerSetVisible(0, false);
        giWait(1.0);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：云公子……谢谢你…… ", "43304");
        giPlayerEndAction(2);
        giPlayerWalkTo(2, 9230.8, -1382.7, 37.3, false);
        giFlashOutBlack(2.0, true, true);
        giPlayerEndMove(2);
        giPlayerSetVisible(2, false);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P35", 2, 2.5, 0.0);
        giIMMBegin();
        giPlayerSetVisible(3, true);
        giPlayerSetVisible(1, true);
        giCameraRunSingle("015", true);
        giIMMEnd();
        giFlashInBlack(1.5, true);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……", "43305");
        giPlayerWalkTo(1, 10839.0, -1383.1, 281.4, false);
        giCameraRunSingle("016", false);
        giPlayerEndMove(1);
        giPlayerSetAng(1, 288.0);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：哈～我看有的人就是不坦率，明明担心自己的师侄，又只会在旁边偷偷看。", "43306");
        giPlayerSetDir(3, 112.0, true);
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……", "43307");
        giWait(0.5);
        giCameraRunSingle("017", true);
        giWait(0.5);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：怎么？", "43308");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, true);
        giWait(0.5);
        giPlayerSetDir(3, 294.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：喂，明明一副若有所思的样子，干嘛不把话讲出来？", "43309");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetAng(3, 112.0);
        giCameraRunSingle("020", true);
        giIMMEnd();
        giWait(0.6);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……不坦率的人是你吧？", "43310");
        giSetPortrait("104C", false);
        giTalk("韩菱纱：……什么意思？", "43311");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……", "43312");
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：哎，讲话又只讲一半，小紫英你不但是个冰块脸，还是个闷葫芦，总这么严肃干嘛？", "43313");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……谨言慎行又何错之有？难道人人都要与你性情相投才好？ ", "43314");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：我可没这么说～要是你自己觉得开心，别人才没话好讲。", "43315");
        giCameraRunSingle("021", false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：可我见你每天守着规矩，眉头却又常常皱起来，你问问自己嘛，到底过得快不快活。", "43316");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：你这话很奇怪，人生数十载，岂能事事都随人所愿？", "43317");
        giPlayerEndAction(3);
        giWait(1.0);
        giCameraRunSingle("019", true);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：就因为人生苦短～不过得开心点，难道死之前才后悔？", "43318");
        giSetPortrait("104B", false);
        giTalk("韩菱纱：像是天河，有时候我都觉得他很胡闹，可又不知不觉羡慕他，说不定就该那样，才不算白过了一辈子……", "43319");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("018", true);
        giWait(0.5);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：岂有这种道理？他那样不过是目无礼法、肆意妄为罢了。", "43320");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我修仙问道，为世间斩妖除魔，没有一样不是自己想要的，又怎会虚耗一世？", "43321");
        giCameraRunSingle("022", true);
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：算了算了，和你真的说不通呐，你觉得好就好。", "43322");
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerWalkTo(1, 10943.0, -1383.2, 288.6, false);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndMove(1);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerSetPos(0, 8421.8, -1382.0, -257.4);
        giPlayerSetAng(0, 36.0);
        giPlayerSetVisible(0, true);
        giCameraRunSingle("023", true);
        giIMMEnd();
        giFlashInBlack(1.5, false);
        giWait(0.8);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：……真奇怪，有时候对着梦璃，就会觉得头晕晕的，话也说得乱七八糟……是不是病了？可是有菱纱在的时候又不会这样……", "43323");
        giSetPortrait("102B", true);
        giTalk("云天河：不管这些了，玄霄说改天再找他，现在应该算是“改天”了吧，呵呵～", "43324");
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("023", true);
        giPlayerEndAction(0);
        giNpcSetPos("SN001", 13335.6, -1088.2, -5375.1);
        giNpcSetAng("SN001", 100.0);
        giSetNpcVisible("SN001", true);
        giPlayerSetPos(0, 9440.1, -1382.2, 91.7);
        giPlayerSetAng(0, 72.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giSetObjectVisible("entrance3", true);
        global_mvar = 80600; // 0x00013AD8, 第二章 / 5-2-2.心事难明 / 再去禁地
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2013()
{
    if (global_mvar == 80600 /* 第二章 / 5-2-2.心事难明 / 再去禁地 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 15366.5, 136.4, -4038.3);
        giPlayerSetPos(1, 15378.5, 136.4, -4067.5);
        giPlayerSetAng(1, 280.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giPlayerWalkTo(0, 15332.4, 136.4, -3871.2, false);
        giFlashInBlack(1.5, true);
        giWait(1.5);
        giPlayerRunTo(1, 15353.5, 136.4, -3994.9, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：天河，等等我！", "43325");
        giPlayerEndMove(1);
        giPlayerSetDir(0, 170.0, true);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(1, 15342.1, 136.4, -3927.9, true);
        giPlayerSetAng(1, 346.0);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：你是想去那个……禁地，对不对？", "43326");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：是啊～", "43327");
        giWait(0.5);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：你啊……真的很喜欢那个人。", "43328");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102F", false);
        giTalk("云天河：我、我喜欢哪个人？！没、没有啊……", "43329");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：就是玄霄嘛，都写在脸上了！虽然你平时就一副没烦恼的样子，可是只要一说到去看那个人，你的眉毛眼睛，说不出哪里，更是显得特别开心。", "43330");
        giWait(0.5);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：玄霄他……是不太一样，我觉得他有点像爹，可是又更像哥哥……唉，我也没有其他兄弟姐妹，不知想得对不对……", "43331");
        giSetPortrait("102A", true);
        giTalk("云天河：反正……我爹娘的事、玄霄被封在冰里的事，总也放不下……但是我看玄霄好像不想多说，我……想问又问不出口……", "43332");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：难得，你这少根筋的家伙也会有放不下的事情。", "43333");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 352.0);
        giPlayerSetAng(0, 158.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giCameraRunSingle("005", false);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：知道吗？白天我去借了琼华派的弟子名录来看，翻遍了也没瞧见你爹、玄霄和你娘的名字，太奇怪了！", "43334");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：名录是啥？再说这个地方的人不是很小气吗？怎么你说借就借？", "43335");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：哎～名录就是记载所有弟子名字的书，至于我如何借来的，你就别管了，姑娘我自有办法，嘻嘻。", "43336");
        giPlayerEndAction(1);
        giSetPortrait("102A", true);
        giTalk("云天河：你是……想和我一起去找玄霄？", "43337");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：嗯，说不定能帮忙查查你爹娘的事呢。", "43338");
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：再说……其实我也一样放不下，玄霄那种孤单……我能体会，真的太可怜了……", "43339");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：好，那就一起去禁地找他吧！", "43340");
        giPlayerEndAction(0);
        giFlashOutBlack(1.5, true, true);
        giPlayerInTeam(1, false);
        giPlayerSetVisible(1, false);
        giSetNpcVisible("SN001", false);
        giPlayerEndAction(0);
        giPlayerSetAng(0, 0.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 80700; // 0x00013B3C, 第二章 / 5-2-3.心事难明 / 再去禁地
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2014()
{
    if (global_mvar == 80700 /* 第二章 / 5-2-3.心事难明 / 再去禁地 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P27", 2, 2.5, 0.0);
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 1178.9, 131.0, 543.1);
        giPlayerSetAng(0, 34.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 1220.1, 131.0, 519.4);
        giPlayerSetAng(1, 24.0);
        giPlayerSetVisible(1, true);
        giIMMEnd();
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(0, 1274.8, 131.0, 712.0, false);
        giPlayerWalkTo(1, 1302.6, 131.0, 680.7, false);
        giFlashInBlack(1.5, true);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giPlayerSetAng(1, 24.0);
        giCameraWait();
        giWait(0.8);
        giTalk("玄霄：是你？", "43341");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：是不是这时候不能来？", "43342");
        giWait(0.8);
        giTalk("玄霄：……无妨，你可是有事想要问我？", "43343");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：我想知道，我爹和我娘为什么又离开琼华派了？他们已经不想做剑仙了吗？", "43344");
        giSetPortrait("102A", true);
        giTalk("云天河：还有……你，怎么会被封在冰里？", "43345");
        giWait(0.8);
        giTalk("玄霄：……这些前尘往事，你知道了又如何？不知又如何？", "43346");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102G", true);
        giTalk("云天河：我、我也不清楚，就是心里很记挂，想要弄明白。", "43347");
        giWait(0.6);
        giTalk("玄霄：……", "43348");
        giWait(0.7);
        giCameraRunSingle("003", false);
        giTalk("玄霄：……你爹性情不羁，门中诸多清规戒律，委实不适于他。", "43349");
        giTalk("玄霄：至于你娘，她的性子外柔内刚，既已打定主意随你爹下山，便是不会再留。", "43350");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：哦，原来爹和我一样，也受不了这儿这么多规矩～", "43351");
        giWait(0.5);
        giTalk("玄霄：人各有志，修仙半途而止，并不出奇。", "43352");
        giSetPortrait("102A", true);
        giTalk("云天河：但是……那把剑和那块玉，是我爹和我娘带下山的？", "43353");
        giTalk("玄霄：望舒剑与灵光藻玉虽是本门之物，但你娘还在山上时，这两样东西都为她所用，她便一并带走了……这里面的因由也不必多提。", "43354");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：是不是离开门派的弟子，在名录上就找不到了？", "43355");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("玄霄：……正是。", "43356");
        giWait(0.5);
        giSetPortrait("102A", true);
        giTalk("云天河：那你呢？又怎么会在这里？", "43357");
        giWait(0.7);
        giTalk("玄霄：我吗？", "43358");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P28", 2, 0.0, 0.0);
        giWait(0.5);
        giCameraRunSingle("004", true);
        giCameraRunSingle("005", false);
        giWait(0.8);
        giTalk("玄霄：我是罪有应得。", "43359");
        giSetPortrait("102D", true);
        giTalk("云天河：……！", "43360");
        giWait(0.3);
        giTalk("玄霄：琼华派虽是人人修道，但所练不尽相同。昔时我修炼的乃是天下至阳至烈之功，不想一时走火入魔，将派中弟子打成重伤。", "43361");
        giTalk("玄霄：其他人顾及门规，更念同门之谊，不会杀我，却也不能放我，于是想出这个冰封的法子，让我静思自省。", "43362");
        giSetPortrait("102H", true);
        giTalk("云天河：都过了这么久，还不能让你出来吗？", "43363");
        giTalk("玄霄：如今琼华派中，又有几人还记得当年旧事？若等他们想起，放我出来，只怕要等到海枯石烂。", "43364");
        giSetPortrait("102H", true);
        giTalk("云天河：那怎么办？我们去求掌门——", "43365");
        giCameraRunSingle("006", true);
        giWait(0.7);
        giTalk("玄霄：夙瑶吗？求她何用？", "43366");
        giTalk("玄霄：这些年来我内息流转不断，同于苦修，区区寒冰又怎会放在眼里？之所以至今未破冰而出，却是有所顾忌。", "43367");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：顾忌？是什么？", "43368");
        giWait(0.8);
        giTalk("玄霄：……我身中阳炎炽烈，自被冰封，便苦修自创的“凝冰诀”加以制衡。若是破冰，我自信不会再重蹈覆辙，但为保万无一失，还需三样至阴至寒之物从旁相辅。", "43369");
        giWait(0.4);
        giSetPortrait("102K", true);
        giTalk("云天河：三样至阴至寒之物？在哪里呢？", "43370");
        giTalk("玄霄：我也不知究竟在何处，只是当年曾有耳闻。", "43371");
        giWait(0.5);
        giCameraRunSingle("007", true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：这可惨了～天下那么大，就算用御剑来找，也要花上很久，说不定一辈子都找不完！", "43372");
        giWait(0.5);
        giTalk("玄霄：你……", "43373");
        giWait(0.5);
        giPlayerSetDir(1, 340.0, true);
        giWait(0.3);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：……天河，你想帮忙吗？", "43374");
        giWait(0.5);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102J", true);
        giTalk("云天河：当然！", "43375");
        giPlayerEndAction(0);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：可是……这毕竟不算小事，说不定还涉及派中秘辛，我怕……", "43376");
        giTalk("玄霄：你们不必插手，生死之事，尚要听天由命，何况这等去留，又岂随我意。", "43377");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：玄霄，别这么说……我是真的想帮忙，你是爹和娘的师兄，爹在的话，也肯定要管！", "43378");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("玄霄：…………", "43379");
        giWait(0.5);
        giSetPortrait("102A", false);
        giTalk("云天河：再说，就算你伤了人，被关在这儿这么久，还不够吗？", "43380");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 24.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("102B", true);
        giTalk("云天河：我打定主意了，让我帮你吧！", "43381");
        giWait(0.5);
        giTalk("玄霄：……你已这样说，我再推托，便显矫情。但你随时都可反悔，我不会怨怪。", "43382");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：我答应你了，就不会反悔！", "43383");
        giWait(0.7);
        giTalk("玄霄：……若有意帮我，可以<colour red=255 green=187 blue=0 alpha=255>穿过本派后山的醉花荫，去往一处叫作“清风涧”的地方</colour><dc0>。那里隐居的两位长老青阳、重光，应该知道何处能找到“三寒器”。</dc0>", "43384");
        giTalk("玄霄：报上我姓名，他们愿意相助，自然是好，若是不愿，也不必强求……", "43385");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：好～不等了，我这就去！", "43386");
        giWait(0.5);
        giTalk("玄霄：慢！", "43387");
        giCameraRunSingle("008", false);
        giTalk("玄霄：上回我问你，可是自小畏寒，你说没有？此言不虚？", "43388");
        giSetPortrait("102B", true);
        giTalk("云天河：是啊，我从小到大都不怕冷，也不怕热～", "43389");
        giWait(0.5);
        giTalk("玄霄：……奇了，以你的体质，本不该……", "43390");
        giTalk("玄霄：你爹……有没有告诉过你什么？", "43391");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：没有啊。", "43392");
        giWait(0.8);
        giTalk("玄霄：……无论如何，你气色如常，应可修炼我所创的“凝冰诀”，这虽然只是心法，并不能使功力一日千里，但时日久了，便可固你根基，令你修行事半功倍。", "43393");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：真的吗？听起来像是很厉害～", "43394");
        giWait(0.8);
        giTalk("玄霄：你先记下口诀——", "43395");
        giFlashOutBlack(1.5, true, true);
        giWait(3.0);
        giCameraRunSingle("009", true);
        giFlashInBlack(2.0, true);
        giWait(0.5);
        giTalk("玄霄：不错，你心无杂念，学来倒不费力。", "43396");
        giWait(0.5);
        giCameraRunSingle("010", true);
        giWait(0.5);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：真的耶！说不出哪里不一样了，可就是觉得全身很舒畅。", "43397");
        giWait(0.5);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：这么厉害？我也能学吗？", "43398");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("玄霄：不可。", "43399");
        giTalk("玄霄：……你性喜动，而修炼此功务必要意沉如水、心无旁鹜，于你并不合适，若是练了，反而有害无益。", "43400");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：……怎么会呢？天河才是一刻都静不下来，他却能学？", "43401");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("玄霄：他看来好动，其实最无杂念，不然也不会一听口诀，便能心随意动，立时有感。", "43402");
        giSetPortrait("104E", false);
        giTalk("韩菱纱：（……有听没懂……就是说，要脑袋空空才能学这个心法？）", "43403");
        giCameraRunSingle("011", true);
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：唉，算了吧……那我还是跟着紫英学功夫好了。", "43404");
        giTalk("玄霄：慕容紫英？夙瑶命他来教你们？", "43405");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：掌门原本想让其他人做我们的师父，可那人又正好下山，这才换了紫英……", "43406");
        giWait(0.6);
        giTalk("玄霄：下山去了？夙瑶这推托之辞未免太不高明。", "43407");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102H", true);
        giTalk("云天河：我就说嘛，掌门一向小气……", "43408");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.8);
        giTalk("玄霄：哦？夙瑶如何小气了？", "43409");
        giWait(0.5);
        giCameraRunSingle("012", false);
        giSetPortrait("102H", true);
        giTalk("云天河：……山下有个村子没水了，我们想找她借水林猪用一下，她都不肯——", "43410");
        giWait(0.3);
        giTalk("玄霄：你们几个～当真是初生牛犊，要知水灵珠乃是琼华至宝，依夙瑶的性子，她如何会轻易拿出？", "43411");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：……她不想教我们，干嘛还让我们入门？难道是怕和妖界拼命的时候人不够？", "43412");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("102A", true);
        giTalk("云天河：对了，玄霄，紫英说马上会有妖界飞来这里，那个妖界很厉害吗？", "43413");
        giWait(0.5);
        giTalk("玄霄：……妖界降临，便是又过了十九年啊……", "43414");
        giWait(0.8);
        giTalk("玄霄：十九年前，我的师父，前代掌门太清真人正是被妖界之主所害，此仇不报，琼华派何以雪耻？！", "43415");
        giPlayerDoAction(1, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：怪不得……掌门还有紫英，提到妖界都那样小心戒备，妖怪那么强，我们又怎么赢得了？", "43416");
        giWait(0.8);
        giCameraRunSingle("013", true);
        giWait(1.0);
        giTalk("玄霄：倒也未必，办法还是有的，却要看天意是否能成了……", "43417");
        giWait(0.5);
        giCameraRunSingle("014", true);
        giWait(0.3);
        giSetPortrait("102H", true);
        giTalk("云天河：我们先去找长老了，玄霄，你就等好消息吧！", "43418");
        giWait(0.5);
        giTalk("玄霄：去吧，万事小心，若是凶险，不用勉强而为。", "43419");
        giPlayerDoAction(0, "C08", 1, true);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(1271.0, 131.0, 720.7);
        giPlayerCurrentSetAng(4.5);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        global_mvar = 80800; // 0x00013BA0, 第二章 / 5-3-1.三寒器 / 寻访长老
        giIMMEnd();
        giPlayerUnLock();
        giScriptMusicStop(1, 2.5);
        giFlashInBlack(1.5, true);
    }
}

void func2015()
{
    if (global_mvar == 80800 /* 第二章 / 5-3-1.三寒器 / 寻访长老 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 15331.6, 136.4, -3751.5);
        giPlayerSetPos(1, 15387.4, 136.4, -3747.3);
        giPlayerSetPos(3, 15342.1, 136.4, -4003.2);
        giPlayerSetAng(3, 12.0);
        giPlayerSetPos(2, 15564.1, 136.4, -4033.1);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giIMMEnd();
        giArenaReady();
        giCameraPrepare("MC007");
        giCameraRunSingle("001", true);
        giPlayerWalkTo(0, 15315.1, 136.4, -3925.8, false);
        giPlayerWalkTo(1, 15365.6, 136.4, -3918.8, false);
        giFlashInBlack(1.5, true);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 152.0);
        giPlayerEndMove(1);
        giPlayerSetAng(1, 204.0);
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：你们，又去师叔那里？", "43420");
        giSetPortrait("104E", true);
        giTalk("韩菱纱：（……完了，被他看见……这冰块脸八成要搬出大道理来教训人……）", "43421");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：往来禁地须得小心，若是被其他弟子看到，却也不好解释。", "43422");
        giWait(0.5);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：咦？！你你你——你是慕容紫英吧？", "43423");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：真的慕容紫英，不是应该立刻板起脸来，训斥一番吗？", "43424");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……师叔已经吩咐过，不要把禁地之事告诉其他人，而你们过去他并不阻拦，我便不该多说什么。", "43425");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：这样的话，你也跟我们一起去找三寒器吧！", "43426");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：三寒器？", "43427");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 166.0);
        giPlayerSetAng(1, 196.0);
        giPlayerSetAng(3, 342.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：听玄霄说，就是天底下至阴至寒的三样东西，能压制他身体里的阳炎，令他破冰而出～", "43428");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：此话当真？！", "43429");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：哼，骗你不成～他还让我们<colour red=255 green=187 blue=0 alpha=255>去清风涧找隐居的两位长老</colour><dc0>，打听三寒器下落呢！</dc0>", "43430");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……此事、此事掌门却又不知，这……", "43431");
        giSetPortrait("104A", false);
        giTalk("韩菱纱：玄霄好像也不想让掌门知道呢。", "43432");
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：师叔，你不是很担心妖界要来了吗？玄霄如果从冰里出来，一定能帮上忙吧！", "43433");
        giWait(0.5);
        giCameraRunSingle("006", true);
        giCameraRunSingle("007", false);
        giWait(2.0);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：好，我跟你们一起去！", "43434");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……宗炼师公命我无论如何也要达成师叔所愿，说不定……正是为了今日。", "43435");
        giSetPortrait("104M", true);
        giTalk("韩菱纱：那你们先等一下，我去叫上梦璃，去去就来～", "43436");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 100.0);
        giPlayerSetAng(3, 70.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giPlayerWalkTo(1, 15433.1, 136.4, -4021.6, false);
        giPlayerEndMove(1);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetDir(0, 157.0, false);
        giPlayerSetPos(1, 15550.2, 136.4, -4083.6);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("102A", true);
        giTalk("云天河：……师叔，学了基本心法和御剑之后，你怎么都不再教其他东西了？", "43437");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 338.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：琼华道法博大精深，短短几日又能传授多少，你稍安毋躁，先将根基打好。", "43438");
        giPlayerDoAction(0, "C07", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：不对，是掌门根本不想教我们厉害的道法吧？", "43439");
        giSetPortrait("105D", true);
        giTalk("慕容紫英：……！", "43440");
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：休要胡说，掌门乃是一派之主，行事非你我能够猜臆！", "43441");
        giPlayerEndAction(3);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：……不教就不教，我上山只是想学御剑，对其他的也不稀罕。", "43442");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("008", true);
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：唉，我说过了，不必心急，如今妖界将临，许多事情千头万绪，一时顾不上你们，也在情理之中。", "43443");
        giWait(0.4);
        giSetPortrait("102C", true);
        giTalk("云天河：……", "43444");
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerWalkTo(1, 15424.9, 136.4, -4014.0, false);
        giPlayerWalkTo(2, 15428.7, 136.4, -3978.1, false);
        giWait(0.6);
        giIMMBegin();
        giPlayerSetAng(0, 124.0);
        giPlayerSetAng(3, 60.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giPlayerEndMove(1);
        giPlayerSetAng(1, 310.0);
        giPlayerEndMove(2);
        giPlayerSetAng(2, 288.0);
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：事情我都听菱纱说了，要能帮上玄霄，真是再好不过。<colour red=255 green=187 blue=0 alpha=255>我们这就动身去清风涧吧。</colour>", "43445");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：好！", "43446");
        giWait(0.5);
        giPlayerInTeam(3, true);
        giWait(2.0);
        giShowTutorial(20);
        giSetPlayerLevel(3, 36);
        giAddPlayerEquip(3, 3511);
        giAddPlayerEquip(3, 3594);
        giAddPlayerEquip(3, 3564);
        giAddPlayerEquip(3, 3629);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giPlayerInTeam(2, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giPlayerEndAction(0);
        giPlayerSetPos(0, 15125.3, 136.4, -4289.1);
        giPlayerSetAng(0, 280.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 81100; // 0x00013CCC, 寻访长老
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2016()
{
    if (global_mvar == 91200 /* 第二章 / 6-2-4.万家同庆 / 御剑回山 / 狐仙之乱 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 12562.1, -1831.3, -14355.0);
        giPlayerSetAng(0, 306.0);
        giPlayerSetPos(1, 12513.6, -1831.3, -14384.1);
        giPlayerSetAng(1, 64.0);
        giPlayerSetPos(2, 12463.5, -1831.3, -14347.5);
        giPlayerSetAng(2, 96.0);
        giPlayerSetPos(3, 12495.8, -1831.3, -14278.5);
        giPlayerSetAng(3, 142.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giPlayerSetVisible(2, true);
        giIMMEnd();
        giCameraPrepare("MC008");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(0.9);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giSetPortrait("102K", true);
        giTalk("云天河：终于到了～快走！我想马上去找玄霄，告诉他好消息！", "43793");
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, true);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107G", false);
        giTalk("柳梦璃：我……", "43794");
        giIMMBegin();
        giPlayerSetPos(3, 12500.0, -1831.3, -14299.3);
        giPlayerSetPos(1, 12494.4, -1831.3, -14378.8);
        giPlayerSetPos(0, 12541.0, -1831.3, -14357.8);
        giPlayerSetAng(3, 226.0);
        giPlayerSetAng(1, 320.0);
        giPlayerSetAng(0, 280.0);
        giCameraRunSingle("003", false);
        giIMMEnd();
        gi2DSoundPlay("WJ033", 1);
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giCGEffPlay(1);
        giWait(0.05);
        giCGEffStop();
        giWait(0.5);
        giCameraRunSingle("004", false);
        giWait(0.5);
        giSetPortrait("102D", false);
        giTalk("云天河：梦璃？", "43795");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：有什么、有什么东西……我的头……好晕……", "43796");
        giPlayerDoAction(1, "C07", -1, true);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：很不舒服吗？是不是海风吹久了？我扶你回房！", "43797");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……你们两个先回去吧，<colour red=255 green=187 blue=0 alpha=255>我与天河去见师叔就行了。</colour>", "43798");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 2.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：好，那我和梦璃先走了，她看起来脸色很苍白，得好好休息才行……", "43799");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("001", true);
        giPlayerOutTeam(2, false);
        giPlayerOutTeam(1, false);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giIMMEnd();
        giPlayerSetPos(0, 12402.4, -1831.4, -14221.2);
        giPlayerSetAng(0, 280.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 91300; // 0x000164A4, 第二章 / 6-3-1.义结金兰 / 禁地交图
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2017()
{
    if (global_mvar == 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P27", 2, 2.5, 0.0);
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 1146.1, 131.0, 562.3);
        giPlayerSetAng(0, 34.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(3, 1188.8, 131.0, 534.2);
        giPlayerSetAng(3, 36.0);
        giPlayerSetVisible(3, true);
        giIMMEnd();
        giCameraPrepare("MC004");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giPlayerDoAction(0, "J19", 1, false);
        giWait(0.3);
        giSetPortrait("102K", false);
        giTalk("云天河：玄霄～", "43800");
        giWait(0.9);
        giPlayerRunTo(0, 1237.5, 131.0, 687.4, false);
        giPlayerWalkTo(3, 1285.5, 131.0, 647.7, true);
        giPlayerSetAng(3, 22.0);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 32.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：弟子参见师叔。", "43801");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giCameraAutoSeek(false);
        giCameraRunSingle("002", true);
        giWait(0.9);
        giTalk("玄霄：何事如此高兴？", "43802");
        giPlayerDoAction(0, "C07", -1, false);
        giWait(0.6);
        giIMMBegin();
        giSetObjectVisible("MO004", true);
        giSetObjectVisible("Jeffect002", true);
        giIMMEnd();
        giSetPortrait("102M", true);
        giTalk("云天河：你看！我们已经找到了三寒器其中一个，光纪寒图！", "43803");
        giWait(1.0);
        giIMMBegin();
        giSetObjectVisible("MO004", false);
        giSetObjectVisible("Jeffect002", false);
        giIMMEnd();
        giWait(0.6);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giDelProperty(3111, 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：不算太难，只要再得到另外两个，你就能从冰里出来了！", "43804");
        giWait(0.5);
        giTalk("玄霄：……你怎么……看来比我还高兴？", "43805");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：呵呵，不可以吗？ ", "43806");
        giWait(0.8);
        giTalk("玄霄：只是没想到，这世上竟还有人会为我如此耗费心力…………", "43807");
        giWait(0.8);
        giTalk("玄霄：好、好，天河，你很好，你看我们结为义兄弟如何？", "43808");
        giSetPortrait("105D", true);
        giTalk("慕容紫英：……！", "43809");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：义兄弟？啥意思？", "43810");
        giWait(0.8);
        giTalk("玄霄：便是没有血缘之人彼此认作兄弟，你尊我为兄长，我视你为亲弟，从今往后，你就是我在世上唯一的亲人了。", "43811");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：好啊！", "43812");
        giWait(0.5);
        giSetPortrait("102K", true);
        giTalk("云天河：我下了山后才知道，人也会有兄弟姐妹的，可惜我没有……现在有你做我大哥，真是再好不过～", "43813");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：师叔，弟子斗胆……你与天河父亲同辈，这……这只怕于礼法不合。", "43814");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giTalk("玄霄：礼法？什么东西？", "43815");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：师叔……", "43816");
        giTalk("玄霄：琼华派便是事事都合礼数，才会教出些迂腐不堪的弟子。何况我如何行止，却要后辈来管吗？", "43817");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：弟子不敢！", "43818");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giCameraRunSingle("007", false);
        giWait(0.8);
        giTalk("玄霄：天河，这回怎未见其他两位姑娘？", "43819");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：她们啊，身体不太舒服，就先回去休息了。", "43820");
        giWait(0.5);
        giTalk("玄霄：不太舒服…………大哥问你，那其中可有你的心上人吗？", "43821");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……", "43822");
        giWait(0.5);
        giSetPortrait("102A", true);
        giTalk("云天河：大哥，怎么你也这样问？我、我不太懂……", "43823");
        giWait(0.5);
        giTalk("玄霄：不懂便罢了，只是……那带着琴的女孩子相当特别。", "43824");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：梦璃她……她人很好的……", "43825");
        giWait(0.5);
        giTalk("玄霄：你误会了，我是说她……", "43826");
        giWait(0.5);
        giTalk("玄霄：罢了，此事日后再说。我教过你的心法练得如何？", "43827");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 332.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("102K", true);
        giTalk("云天河：早晚都练啊，最近总觉得身体变得越来越轻了～", "43828");
        giTalk("玄霄：很好，眼下务必勤加苦修，勿要牵扯儿女私情，否则只会生出无穷烦恼。", "43829");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：好！", "43830");
        giWait(0.8);
        giTalk("玄霄：……刚才你将光纪寒图直接拿在手中，竟也不觉寒冷？", "43831");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：不会啊，好像别人都说冷，就只有我没啥感觉。", "43832");
        giWait(0.5);
        giTalk("玄霄：…………", "43833");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 22.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.8);
        giTalk("玄霄：……<colour red=255 green=187 blue=0 alpha=255>你们都出去吧，</colour><dc0>我想静心一段时间，若是找到另外两样寒器，再一并拿来。</dc0>", "43834");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：是。", "43835");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：大哥你放心，我一定尽快找到另外两样东西。", "43836");
        giWait(1.5);
        giCameraRunSingle("010", true);
        giWait(0.8);
        giTalk("玄霄：天河，日后大哥必会报答你今日之恩……", "43837");
        giWait(0.5);
        giFlashOutBlack(2.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerSetPos(0, 1077.0, 67.0, 359.0);
        giPlayerSetAng(0, 200.0);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        global_mvar = 91400; // 0x00016508, 第二章 / 6-3-2.义结金兰 / 离开禁地 / 结拜兄弟
        giIMMEnd();
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2018()
{
    if (global_mvar == 100101 /* 准备动身 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 5844.8, -1383.6, -5535.0);
        giPlayerSetAng(0, 158.0);
        giPlayerSetPos(1, 5908.6, -1387.9, -5742.9);
        giPlayerSetAng(1, 98.0);
        giPlayerSetPos(2, 5962.1, -1387.9, -5760.8);
        giPlayerSetAng(2, 290.0);
        giPlayerSetPos(3, 5985.5, -1387.9, -5695.6);
        giPlayerSetAng(3, 244.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giPlayerSetVisible(2, true);
        giIMMEnd();
        giCameraPrepare("MC009");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, true);
        giArenaReady();
        giWait(1.1);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：菱纱，我看你今天还是别出门了吧。", "43852");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：的确……", "43853");
        giWait(0.5);
        giSetPortrait("102B", true);
        giTalk("云天河：你们都起来了啊？", "43854");
        giWait(0.5);
        giPlayerWalkTo(0, 5887.5, -1383.6, -5665.2, false);
        giIMMBegin();
        giPlayerSetDir(1, 346.0, false);
        giPlayerSetDir(2, 324.0, false);
        giPlayerSetDir(3, 278.0, false);
        giIMMEnd();
        giCameraRunSingle("003", true);
        giPlayerEndMove(0);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：嘻～大懒虫都爬起来了，我们还不快走？", "43855");
        giWait(0.3);
        giPlayerSetDir(0, 180.0, false);
        giPlayerSetDir(2, 290.0, false);
        giPlayerSetDir(3, 244.0, false);
        giWait(0.8);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：<colour red=255 green=187 blue=0 alpha=255>今天就去炎帝神农洞了！</colour><dc0>那地方我也知道在哪里～</dc0>", "43856");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：不行……你昨天只顾关照我，自己反而累坏了……", "43857");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerSetDir(1, 98.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：那算什么？以前闯荡江湖，什么大病小病没生过，现在只是手脚有些发软，没那么容易倒下的。", "43858");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：那如果你在路上撑不住，我们就马上回来！", "43859");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(1, 346.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：好了，别人念叨也就罢了，怎么连你都爱操心……走啦、走啦！", "43860");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：有吗？我是关心你啊……", "43861");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giPlayerInTeam(2, false);
        giPlayerInTeam(1, false);
        giPlayerInTeam(3, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giPlayerEndAction(0);
        giPlayerSetAng(0, 200.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 100200; // 0x00018768, 第二章 / 6-3-4.义结金兰 / 炎帝神农洞
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2019()
{
    if (global_mvar == 101400 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P36", 2, 0.0, 0.0);
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 12272.8, -1743.3, -13641.1);
        giPlayerSetAng(0, 158.0);
        giPlayerSetPos(1, 12301.7, -1743.5, -13642.2);
        giPlayerSetAng(1, 98.0);
        giPlayerSetPos(2, 12406.7, -1743.8, -13632.3);
        giPlayerSetAng(2, 290.0);
        giPlayerSetPos(3, 12357.4, -1743.0, -13625.3);
        giPlayerSetAng(3, 244.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("MN003", true);
        giSetNpcVisible("MN004", true);
        giSetNpcVisible("MN005", true);
        giSetNpcVisible("MN006", true);
        giSetNpcVisible("MN007", true);
        giSetNpcVisible("4004", false);
        giSetNpcVisible("4005", false);
        giSetNpcVisible("4002", false);
        giIMMEnd();
        giArenaReady();
        giCameraPrepare("MC010");
        giCameraRunSingle("001", true);
        giPlayerWalkTo(0, 12242.3, -1759.3, -13431.2, false);
        giPlayerWalkTo(1, 12276.9, -1759.3, -13445.1, false);
        giPlayerWalkTo(2, 12366.9, -1759.3, -13414.5, false);
        giPlayerWalkTo(3, 12326.0, -1759.3, -13397.7, false);
        giWait(0.7);
        giFlashInBlack(1.5, false);
        giWait(0.7);
        giNpcWalkTo("MN006", 12296.9, -1759.3, -13279.6, false);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 16.0);
        giPlayerEndMove(1);
        giPlayerSetAng(1, 0.0);
        giPlayerEndMove(2);
        giPlayerSetAng(2, 324.0);
        giPlayerEndMove(3);
        giPlayerSetAng(3, 344.0);
        giSetPortrait("202E", false);
        giTalk("璇玑：师叔！不好了、不好了！", "44033");
        giTalk("明靖：紫英师叔！你终于回来了！", "44034");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：你们怎么了？", "44035");
        giWait(0.5);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giNpcDoAction("MN002", "C07", -1, false);
        giTalk("明桓：师叔，你还不知道吗？！这韩菱纱在入门前是个偷东西的贼！有人已经认出她来了！", "44036");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", false);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：……！！", "44037");
        giTalk("怀溪：师叔，我们琼华派收徒甚严，怎能允许这种身份的人混在其中！", "44038");
        giTalk("明采：没错，刚才怀安师兄已去禀报掌门，请掌门将这个女贼逐出门墙！", "44039");
        giWait(0.5);
        giIMMBegin();
        giNpcSetPos("MN006", 12285.8, -1759.3, -13224.7);
        giNpcSetPos("MN007", 12248.8, -1759.3, -13191.6);
        giNpcSetAng("MN006", 166.0);
        giNpcSetAng("MN007", 162.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giTalk("明靖：现在逐下山去说不定都为时已晚！谁知道本派有没有丢过什么——", "44040");
        giWait(0.3);
        giCameraRunSingle("004", false);
        giPlayerRunTo(0, 12281.0, -1759.3, -13348.3, true);
        giPlayerSetAng(0, 352.0);
        giPlayerDoAction(0, "Z01", 0, false);
        giWait(0.5);
        giSetPortrait("102I", true);
        giTalk("云天河：你刚才说什么？再说一遍看看！", "44041");
        giTalk("明靖：你、你疯啦！竟对同门兵刃相向！", "44042");
        giSetPortrait("102I", true);
        giTalk("云天河：我管你是不是同门！不许有人这样说菱纱，谁再说一句，我就要他好看！", "44043");
        giNpcDoAction("MN002", "C07", 1, false);
        giTalk("明桓：岂有此理——", "44044");
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：都给我退开！", "44045");
        giPlayerEndAction(3);
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.5);
        giTalk("明靖：紫英师叔，你看他如此嚣张——", "44046");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：闭嘴！通通给我回去！", "44047");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：既然你们将此事禀报了掌门，便该由掌门定夺！", "44048");
        giTalk("怀溪：师叔——", "44049");
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：回去！！", "44050");
        giPlayerEndAction(3);
        giTalk("怀溪：可恶！", "44051");
        giNpcWalkTo("MN005", 12293.0, -1759.3, -13040.7, false);
        giNpcWalkTo("MN004", 12175.4, -1759.3, -13034.5, false);
        giNpcWalkTo("MN003", 12293.0, -1759.3, -13040.7, false);
        giNpcWalkTo("MN002", 12175.4, -1759.3, -13034.5, false);
        giNpcEndMove("MN002");
        giIMMBegin();
        giPlayerDoAction(0, "C01", 1, false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN004", false);
        giSetNpcVisible("MN005", false);
        giPlayerSetPos(0, 12278.2, -1759.3, -13351.3);
        giPlayerSetAng(0, 6.0);
        giPlayerSetPos(1, 12248.7, -1759.3, -13367.5);
        giPlayerSetAng(1, 26.0);
        giPlayerSetPos(2, 12356.3, -1759.3, -13355.0);
        giPlayerSetAng(2, 318.0);
        giPlayerSetPos(3, 12322.7, -1759.3, -13368.8);
        giPlayerSetAng(3, 344.0);
        giNpcSetPos("MN006", 12292.7, -1759.3, -13254.5);
        giNpcSetAng("MN006", 166.0);
        giNpcSetPos("MN007", 12252.6, -1759.3, -13240.8);
        giNpcSetAng("MN007", 162.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("202D", true);
        giTalk("璇玑：紫英师叔，师兄他们太过份了……", "44052");
        giSetPortrait("202D", true);
        giTalk("璇玑：我和怀朔师兄一直阻止，他们还是要去找掌门……", "44053");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……璇玑，你与怀朔也先回去吧，此事我自会去求见掌门……", "44054");
        giSetPortrait("202D", true);
        giTalk("璇玑：我也去——", "44055");
        giNpcSetDir("MN007", 114.0, true);
        giWait(0.5);
        giSetPortrait("203A", false);
        giTalk("怀朔：师妹，听师叔的话吧，你去了，也不一定能帮上忙。", "44056");
        giSetPortrait("202D", true);
        giTalk("璇玑：……好吧……", "44057");
        giWait(0.6);
        giNpcWalkTo("MN007", 12223.9, -1759.3, -13060.8, false);
        giNpcWalkTo("MN006", 12264.8, -1759.3, -13055.1, false);
        giWait(1.6);
        giIMMBegin();
        giPlayerSetPos(0, 12296.0, -1759.3, -13292.1);
        giPlayerSetAng(0, 176.0);
        giPlayerSetPos(1, 12261.0, -1759.3, -13358.8);
        giPlayerSetAng(1, 28.0);
        giPlayerSetPos(2, 12350.0, -1759.3, -13332.5);
        giPlayerSetAng(2, 286.0);
        giPlayerSetPos(3, 12319.6, -1759.3, -13396.8);
        giPlayerSetAng(3, 322.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(0.6);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102H", true);
        giTalk("云天河：菱纱，你别理那些人，他们再敢乱说，我就直接打人了！", "44058");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：天河……你冷静点……", "44059");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：对啊，那些人根本什么都不明白，只是一派胡言……", "44060");
        giPlayerEndAction(2);
        giIMMBegin();
        giSetNpcVisible("MN006", false);
        giSetNpcVisible("MN007", false);
        giPlayerSetAng(1, 86.0);
        giPlayerSetAng(3, 308.0);
        giPlayerSetVisible(0, false);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：谢谢你们，我不在意的。", "44061");
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：一想到炎帝神农洞的事，心里就难过得不得了，和那一比，这些小事又算得了什么呢？", "44062");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.6);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：菱纱，你以前……真的是……？", "44063");
        giCameraRunSingle("009", false);
        giWait(0.5);
        giPlayerSetDir(1, 138.0, true);
        giCameraWait();
        giSetPortrait("104A", true);
        giTalk("韩菱纱：……是什么？如果我真的是贼，你会怎样？也要看不起我吗？", "44064");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……我……我不知道，偷窃虽是品行不端，但或许你有你的理由……", "44065");
        giSetPortrait("104B", true);
        giTalk("韩菱纱：哈，有你这句话，也不枉我们相识一场～", "44066");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：你放心，我啊，只是拿死人的钱财去接济一下活着的人，伤天害理的事情是绝对不做的，更看不上琼华派的什么书本刀剑。", "44067");
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……走！<colour red=255 green=187 blue=0 alpha=255>我们去琼华宫找掌门，</colour><dc0>请她宽待此事！</dc0>", "44068");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：不用了吧？我不想去……", "44069");
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不行！", "44070");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：你们如想继续修行，此事一定要妥善而为，我们势必得见掌门一面。", "44071");
        giPlayerDoAction(1, "J04", 1, true);
        giWait(1.3);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：……好吧，也许你说的没错。", "44072");
        giPlayerEndAction(1);
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("4004", true);
        giSetNpcVisible("4005", true);
        giSetNpcVisible("4002", true);
        giIMMEnd();
        giPlayerSetVisible(0, true);
        giPlayerEndAction(0);
        giPlayerSetAng(0, 360.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 101500; // 0x00018C7C, 第二章 / 6-5-1.非愿 / 求见掌门
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2020()
{
    if (global_mvar == 101500 /* 第二章 / 6-5-1.非愿 / 求见掌门 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 11924.6, -1766.4, -11087.0);
        giPlayerSetAng(0, 14.0);
        giPlayerSetPos(1, 12007.8, -1766.4, -11091.7);
        giPlayerSetAng(1, 358.0);
        giPlayerSetPos(2, 11910.5, -1766.4, -11131.0);
        giPlayerSetAng(2, 20.0);
        giPlayerSetPos(3, 11951.1, -1766.4, -11051.9);
        giPlayerSetAng(3, 8.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("MN001", true);
        giNpcSetPos("MN001", 11942.2, -1670.8, -10865.8);
        giNpcSetAng("MN001", 170.0);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("4008", false);
        giSetNpcVisible("4007", false);
        giIMMEnd();
        giCameraPrepare("MC011");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giNpcDoAction("MN001", "J01", 1, false);
        giTalk("虚邑：紫英师兄，掌门有命，任何人都不得靠近琼华宫。", "44073");
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……何事如此慎重？", "44074");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giTalk("虚邑：掌门只说有要事待办，不能打扰，或许半日，或许一日。", "44075");
        giPlayerDoAction(3, "J07", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：知道了，多谢。", "44076");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcDoAction("MN001", "J01", 1, true);
        giWait(1.0);
        giNpcWalkTo("MN001", 11903.6, -1670.8, -10692.3, false);
        giWait(1.5);
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giPlayerSetPos(3, 11974.1, -1766.4, -11051.7);
        giPlayerSetAng(3, 132.0);
        giPlayerSetAng(1, 314.0);
        giPlayerSetAng(2, 60.0);
        giPlayerSetAng(0, 66.0);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giWait(0.7);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：实在不巧，我们且在这里等一等吧。", "44077");
        giFlashOutBlack(2.0, true, true);
        giNpcEndMove("MN001");
        giArenaLoad("Q06", "Q06QY", "", true);
        giScriptMusicPlay("P49", 2, 0.0, 0.0);
        giIMMBegin();
        giPlayerSetPos(0, 12632.6, -1769.2, -10249.2);
        giPlayerSetAng(0, 322.0);
        giPlayerSetPos(1, 12520.8, -1769.2, -10263.3);
        giPlayerSetAng(1, 30.0);
        giPlayerSetPos(2, 12561.4, -1769.2, -10288.7);
        giPlayerSetAng(2, 12.0);
        giPlayerSetPos(3, 12574.9, -1769.2, -10225.1);
        giPlayerSetAng(3, 2.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("MO001", true);
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4002", false);
        giIMMEnd();
        giArenaReady();
        giPlayerDoAction(0, "C10", 0, false);
        giPlayerDoAction(2, "C10", 0, false);
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giCameraRunSingle("002", true);
        giSetPortrait("102A", true);
        giTalk("云天河：……月亮好大，像个饼……", "44078");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 304.0);
        giPlayerSetAng(1, 78.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giCameraRunSingle("004", false);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：什么饼……难道你又肚子饿了？", "44079");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(3, 244.0, true);
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……回去吧，已经这么晚了，掌门是不会见我们了。不如一早我再来求见……", "44080");
        giPlayerEndAction(3);
        giPlayerSetDir(3, 50.0, true);
        giWait(0.5);
        giSetPortrait("102A", false);
        giTalk("云天河：紫英……", "44081");
        giWait(0.5);
        giPlayerSetDir(3, 100.0, true);
        giWait(0.5);
        giSetPortrait("102A", false);
        giTalk("云天河：你觉得，在山上很快乐吗？", "44082");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(3, 12533.8, -1769.2, -10178.0);
        giPlayerSetAng(3, 124.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giCameraRunSingle("010", false);
        giPlayerEndAction(0);
        giWait(1.0);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……", "44083");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：菱纱也问过我一样的话，我的回答还是不变。", "44084");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：求仙问道、斩妖除魔，乃是我一生所向，能做自己想做的事，又怎会不快乐？", "44085");
        giSetPortrait("102A", true);
        giTalk("云天河：可是，修仙好像就是些心法口诀，无聊透了，要想行侠仗义，更是不修仙也能做，干嘛不能过以前那种日子呢？", "44086");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：并非如此……", "44087");
        giWait(1.5);
        giIMMBegin();
        giPlayerSetAng(0, 314.0);
        giCameraRunSingle("012", true);
        giIMMEnd();
        giCameraRunSingle("015", false);
        giWait(1.0);
        giSetPortrait("102A", true);
        giTalk("云天河：我之前总想不通，既然御剑这么好玩，为什么爹来了又要走？可如今我算明白了……", "44088");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：一路上看了许多事，像是琴姬离开了自己最重要的人，去山上做剑仙，可是她一点也不开心……炎帝神农洞的那对姐妹，更是很惨很惨……", "44089");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：我这才知道，原来修仙并不是那么好的事，它也会要人伤心、要人性命的……", "44090");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不对！你怎能以偏概全？", "44091");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：……可能我比较笨吧，只能想成这样。", "44092");
        giPlayerEndAction(0);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 280.0);
        giPlayerSetPos(1, 12553.7, -1769.2, -10235.5);
        giPlayerSetAng(1, 105.0);
        giPlayerSetAng(2, 50.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giCameraRunSingle("016", false);
        giWait(1.0);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：什么？！那你的意思是我和你一样笨？", "44093");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：我也觉得仙山上和自己想的差好多啊，长生之法一点着落都没，我是不是该去其他的修仙门派看看？这里不但没有一个不老不死的仙人，还跟山下一样，有许多让人开心不起来的事……不，是更不开心！ ", "44094");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：哦～原来菱纱你也这么想？", "44095");
        giPlayerEndAction(0);
        giPlayerSetDir(0, 238.0, true);
        giSetPortrait("102A", false);
        giTalk("云天河：那梦璃呢？", "44096");
        giWait(0.5);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：我？我原本就是想要出门游历，并不在乎修不修仙，只要和你们一起，去哪里也是一样的…… ", "44097");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：琼华派确实很强大，但注重的并非菱纱所求的长生之道。既然云公子不想待这里，梦璃也不会想留下。", "44098");
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：……那好，就这么定了！帮完大哥之后，我们一起下山吧！", "44099");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：天河？！", "44100");
        giPlayerEndAction(0);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, 12662.3, -1769.2, -10222.7);
        giPlayerSetAng(0, 280.0);
        giPlayerSetPos(1, 12590.0, -1770.2, -10254.5);
        giPlayerSetAng(1, 346.0);
        giPlayerSetPos(2, 12654.9, -1769.2, -10273.0);
        giPlayerSetAng(2, 312.0);
        giPlayerSetPos(3, 12568.5, -1769.2, -10198.7);
        giPlayerSetAng(3, 106.0);
        giPlayerDoAction(2, "C10", 0, false);
        giCameraRunSingle("017", true);
        giIMMEnd();
        giWait(0.6);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：你别担心，我们就先住在山下，万一那个什么妖界打过来了，还能帮到你！", "44101");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……我哪里是担心这个？妖界实力之强，凭你们几人对战局又能有多少影响？", "44102");
        giWait(1.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我不过是……", "44103");
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：嘻，知道了，小紫英是舍不得我们，对吧？", "44104");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.2);
        giIMMBegin();
        giPlayerSetPos(2, 12636.6, -1769.2, -10285.3);
        giPlayerSetAng(2, 315.0);
        giPlayerSetAng(3, 106.0);
        giPlayerSetAng(0, 290.0);
        giCameraRunSingle("018", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……你们如此来去匆匆，可确实想清楚了？", "44105");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：紫英，你听我说……如果修仙是你觉得最快乐的事，那你就一直一直坚持下去。", "44106");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetVisible(3, false);
        giPlayerSetVisible(2, false);
        giCameraRunSingle("019", true);
        giIMMEnd();
        giCameraRunSingle("020", false);
        giWait(1.0);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：我、天河，还有梦璃，我们也要去找其它更想做的事。", "44107");
        giWait(0.3);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……", "44108");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：以前，我因为一些事情，偶尔会很消沉很难过，自从认识你们，想了很多，不少事反而豁然开朗了，最重要的不是周围的人和物，而是一个人自己的心境吧～", "44109");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：紫英，你要答应我，即使我们都下山了，你也要过得开开心心，做一个最厉害的剑侠～", "44110");
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：如果哪天剑侠变成了剑仙，不要忘了来看看我啊～", "44111");
        giPlayerEndAction(1);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetVisible(3, true);
        giPlayerSetVisible(2, true);
        giPlayerSetAng(3, 148.0);
        giPlayerSetVisible(0, true);
        giPlayerSetAng(1, 340.0);
        giCameraRunSingle("021", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：对！也不要忘记我，我请你吃好吃的烤猪，哈哈～", "44112");
        giPlayerEndAction(0);
        giWait(0.2);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetPos(3, 12533.8, -1769.2, -10178.0);
        giPlayerSetAng(3, 124.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giCameraRunSingle("008", false);
        giWait(1.0);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……", "44113");
        giWait(1.0);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我答应你们…………承君此诺，必守一生。", "44114");
        giPlayerEndAction(3);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(0, 12647.7, -1769.2, -10188.5);
        giPlayerSetAng(0, 254.0);
        giPlayerSetPos(1, 12560.6, -1769.2, -10248.4);
        giPlayerSetAng(1, 22.0);
        giPlayerSetPos(2, 12623.8, -1769.2, -10235.6);
        giPlayerSetAng(2, 302.0);
        giPlayerSetPos(3, 12553.8, -1769.2, -10175.4);
        giPlayerSetAng(3, 104.0);
        giPlayerSetVisible(1, true);
        giCameraRunSingle("022", true);
        giIMMEnd();
        giCameraRunSingle("023", false);
        giWait(0.7);
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：哎～今天讲了好多平时不会讲的话，一点都不像我了～", "44115");
        giPlayerEndAction(1);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：人世生离，难免有些伤感……", "44116");
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：别这样啦，我们又不是马上就走，还得帮大哥找到第三样寒器呢！", "44117");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：对啊，<colour red=255 green=187 blue=0 alpha=255>只差最后一件在巢湖附近的了，天亮以后就去找吧，</colour><dc0>一定没问题的！</dc0>", "44118");
        giPlayerEndAction(1);
        giWait(3.0);
        giFlashOutBlack(3.0, true, true);
        giCameraRunSingle("022", true);
        giArenaLoad("Q06", "Q06Q", "", true);
        giPlayerSetPos(0, 12278.0, -1759.3, -13195.1);
        giPlayerSetAng(0, 180.0);
        giArenaReady();
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 110200; // 0x0001AE78, 第二章 / 6-5-2.非愿 / 前往巢湖 / 月夜惜别
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2021()
{
    if (global_mvar == 120100 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 12538.5, -1894.5, -14766.9);
        giPlayerSetAng(0, 244.0);
        giPlayerSetPos(1, 12476.5, -1893.4, -14774.3);
        giPlayerSetAng(1, 300.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giSetNpcVisible("4056", false);
        giIMMEnd();
        giArenaReady();
        giNpcSetAng("4055", 110.0);
        giCameraPrepare("MC012");
        giCameraRunSingle("001", true);
        giPlayerWalkTo(0, 12484.1, -1831.5, -14630.0, false);
        giPlayerWalkTo(1, 12447.5, -1841.5, -14677.7, false);
        giCameraRunSingle("002", false);
        giFlashInBlack(1.5, false);
        giWait(3.0);
        giTalk("明尘：咦？！你不就是那个女飞贼师妹？怎么紫英师叔还允许你下山吗？", "44301");
        giPlayerEndMove(1);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 260.0, false);
        giPlayerSetDir(1, 302.0, true);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102I", true);
        giTalk("云天河：你说什么？！", "44302");
        giPlayerEndAction(0);
        giNpcSetDir("4055", 90.0, true);
        giTalk("明尘：没、没什么！其实啊，我觉得师妹肯定不是那样的人，其他人也未免太疑神疑鬼了！", "44303");
        giIMMBegin();
        giPlayerSetPos(1, 12456.0, -1841.5, -14672.0);
        giPlayerSetAng(1, 310.0);
        giPlayerSetPos(0, 12471.2, -1831.5, -14601.8);
        giPlayerSetAng(0, 256.0);
        giNpcSetPos("4055", 12404.3, -1831.5, -14628.3);
        giNpcSetAng("4055", 105.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104F", false);
        giTalk("韩菱纱：少来……你有没有看见紫英？", "44304");
        giPlayerEndAction(1);
        giTalk("明尘：师叔？", "44305");
        giTalk("明尘：有啊有啊，我看到他御剑回来，不过那个时候师叔的表情真可怕，从来没见他那么生气的样子，吓得其他弟子都不敢靠近……", "44306");
        giSetPortrait("104F", false);
        giTalk("韩菱纱：那现在呢？他在哪里？", "44307");
        giTalk("明尘：这个嘛，掌门突然把长老和一些弟子都召了去，好像有什么大事要说，师叔他也去了。", "44308");
        giIMMBegin();
        giPlayerSetPos(1, 12485.0, -1831.5, -14601.2);
        giPlayerSetAng(1, 356.0);
        giPlayerSetPos(0, 12485.2, -1831.5, -14545.1);
        giPlayerSetAng(0, 178.0);
        giNpcSetAng("4055", 60.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：天河，<colour red=255 green=187 blue=0 alpha=255>我们还是先去找玄霄吧……</colour>", "44309");
        giCameraRunSingle("006", true);
        giTalk("明尘：玄……霄？玄霄是谁？是本派玄字辈的？可是也从没听过这名字……", "44310");
        giPlayerSetDir(0, 222.0, false);
        giPlayerSetDir(1, 244.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：管那么多干嘛？又不是你认识的人……而且我明明说那么小声，居然还拉长了耳朵听……", "44311");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("104I", true);
        giTalk("韩菱纱：真、讨、厌！", "44312");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giTalk("明尘：…………我只是……只是……", "44313");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 10.0);
        giPlayerSetAng(0, 186.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.3);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：天河，我们走。", "44314");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102G", false);
        giTalk("云天河：……菱纱，让我一个人去好吗？", "44315");
        giSetPortrait("102E", false);
        giTalk("云天河：我心里还是不舒坦，想要单独和大哥说说话……", "44316");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：……好吧，我去打听打听到底发生了什么大事，待会儿再见。", "44317");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：好……", "44318");
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerWalkTo(1, 12362.9, -1831.3, -14537.4, false);
        giWait(1.0);
        giNpcSetAng("4055", 328.0);
        giCameraRunSingle("007", true);
        giPlayerEndMove(1);
        giTalk("明尘：师妹！", "44319");
        giWait(0.5);
        giPlayerFaceToNpc(1, "4055", true);
        giWait(0.3);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：嗯？有事？", "44320");
        giWait(0.5);
        giTalk("明尘：师妹你别再犯错了……要是惹得掌门发怒，你真会被逐下山的！", "44321");
        giWait(0.7);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：……", "44322");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：我知道了，谢谢你的关心～～", "44323");
        giPlayerEndAction(1);
        giPlayerWalkTo(1, 12323.2, -1831.3, -14466.3, true);
        giWait(1.2);
        giTalk("明尘：师妹……", "44324");
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(1, false);
        giPlayerOutTeam(1, false);
        giPlayerSetPos(0, 12157.8, -1841.3, -14195.0);
        giPlayerSetAng(0, 290.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giNpcResetDir("4055");
        giSetNpcVisible("4006", true);
        giFlushTailYAngle();
        global_mvar = 120200; // 0x0001D588, 第三章 / 7-2-4.相争难休 / 单独去禁地
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2022()
{
    if (global_mvar == 120200 /* 第三章 / 7-2-4.相争难休 / 单独去禁地 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P27", 2, 2.5, 0.0);
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giPlayerSetPos(0, 1105.1, 78.9, 562.3);
        giPlayerSetAng(0, 24.0);
        giPlayerSetVisible(0, true);
        giIMMEnd();
        giCameraPrepare("MC005");
        giCameraRunSingle("001", true);
        giPlayerWalkTo(0, 1237.5, 131.0, 687.4, false);
        giFlashInBlack(2.0, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 32.5, true);
        giWait(1.0);
        giTalk("玄霄：天河……怎么回事？你气息混乱、神色不定，出了什么事？", "44325");
        giSetPortrait("102E", true);
        giTalk("云天河：…………", "44326");
        giWait(0.7);
        giTalk("玄霄：莫非……是修炼凝冰诀，寒气侵入经络……", "44327");
        giIMMBegin();
        giCameraAutoSeek(false);
        giPlayerSetPos(0, 1276.7, 131.0, 742.6);
        giPlayerSetAng(0, 46.0);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102G", false);
        giTalk("云天河：大哥，我身体没事，好得很……", "44328");
        giWait(0.8);
        giTalk("玄霄：嗯……看来你的体质的确非同一般，实在令人……", "44329");
        giWait(0.8);
        giTalk("玄霄：……既然无恙，为何气息如此混乱？", "44330");
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.8);
        giSetPortrait("102E", true);
        giTalk("云天河：……大哥，你以前……和别人吵过架吗？是和自己很要好的朋友……", "44331");
        giWait(0.5);
        giTalk("玄霄：……为何有此一问？", "44332");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：我和紫英……发生了一些事情，我们都很生对方的气，我不知道……要怎样才能变回以前那样……", "44333");
        giWait(0.5);
        giTalk("玄霄：慕容紫英？那定是他的不对了！", "44334");
        giWait(0.7);
        giSetPortrait("102E", true);
        giTalk("云天河：……虽然我觉得自己没有错，可是对紫英说了那些话，又觉得后悔……我这人不大会说话，有时越搞越糟……", "44335");
        giSetPortrait("102E", true);
        giTalk("云天河：大哥，你说我该怎么办？", "44336");
        giWait(0.5);
        giCameraRunSingle("004", false);
        giWait(1.0);
        giTalk("玄霄：人既有七情六欲，彼此相处，发生争执乃是寻常，不过只要今生今世还能见面，就一定有挽回的余地……", "44337");
        giWait(0.7);
        giTalk("玄霄：……最怕黯然分别，从此天各一方，直至老死，就算想求得对方的原谅，也永远没有机会了……", "44338");
        giWait(0.5);
        giSetPortrait("102E", true);
        giTalk("云天河：大哥，你……遇到过那种事吗？", "44339");
        giWait(0.8);
        giTalk("玄霄：…………以前年少气盛，曾经伤了一个人的心，等到许久之后冷静下来，才明白大错已成……", "44340");
        giWait(0.5);
        giSetPortrait("102E", true);
        giTalk("云天河：你破冰出来以后，可以再去找那个人吗？", "44341");
        giWait(0.8);
        giTalk("玄霄：……她死了……", "44342");
        giWait(0.3);
        giSetPortrait("102D", true);
        giTalk("云天河：……！", "44343");
        giWait(0.5);
        giTalk("玄霄：……阴阳两隔便已无解，除非时光倒流，不然一切都只是枉然……", "44344");
        giWait(0.5);
        giSetPortrait("102D", true);
        giTalk("云天河：……", "44345");
        giWait(0.5);
        giTalk("玄霄：所以……你与慕容紫英之事，倒不必如此沮丧，与其茫然无措，不如鼓足勇气与他说上几句话，或许事情会有意想不到的转机。", "44346");
        giWait(0.5);
        giSetPortrait("102A", true);
        giTalk("云天河：…………", "44347");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.8);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：我明白了！谢谢大哥，我一定在下山之前去找紫英！", "44348");
        giWait(0.5);
        giTalk("玄霄：下山？", "44349");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：大哥，我、我不打算继续待在琼华派了，今天是最后一次来禁地。", "44350");
        giTalk("玄霄：……！", "44351");
        giTalk("玄霄：夙瑶逐你们下山？！", "44352");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：没有啊……是我自己不喜欢这里。", "44353");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giCameraRunSingle("006", false);
        giWait(0.8);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：以前我住在青鸾峰上，还以为天底下所有的地方都一个样，后来菱纱告诉我，山下和山上完全不同，我觉得新鲜好玩，又想打听爹和娘的事，就高高兴兴跑了出来。", "44354");
        giWait(0.5);
        giSetPortrait("102J", false);
        giTalk("云天河：一路上也挺不错，但是进了琼华派，我有点讨厌这里的人……当然不是大哥你，也不是紫英，而是其他弟子，他们骂菱纱是小贼，还想把她赶下山，我实在很生气……", "44355");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giTalk("玄霄：……这么说来，你要走，却是为了那个姑娘？", "44356");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：也不全是吧，反正我待在琼华派就觉得浑身不自在……再说，要帮大哥找的三件寒器也全找到了，这事才是我最挂心的，现在总算有个交代。", "44357");
        giWait(0.8);
        giCameraRunSingle("008", true);
        giWait(0.8);
        giTalk("玄霄：……！至阴至寒之物，都已找全？！", "44358");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P28", 2, 0.0, 2.5);
        giSetPortrait("102B", false);
        giTalk("云天河：是啊，我进来时脑子里一团乱，竟然忘了说……", "44359");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：大哥，你看！这就是长老说的另外两样东西，梭罗果和鲲鳞～", "44360");
        giWait(1.2);
        giDelProperty(3109, 1, true);
        giWait(2.5);
        giDelProperty(3110, 1, true);
        giWait(2.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("010", true);
        giWait(0.8);
        giTalk("玄霄：……好、好！我等这一日，已等了太久太久！天河，你帮了大哥很多！帮了琼华派很多！", "44361");
        giTalk("玄霄：以时机来说，确是分毫不差……", "44362");
        giWait(0.5);
        giCameraRunSingle("011", true);
        giWait(0.8);
        giSetPortrait("102A", true);
        giTalk("云天河：时机？", "44363");
        giCameraRunSingle("012", false);
        giWait(0.5);
        giTalk("玄霄：……没什么。天河，若是大哥希望你留下，你也不愿吗？", "44364");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：啊？…………大哥，这里真的不是我喜欢的地方，你破冰以后要是想见我，就来山下播仙镇吧，我和菱纱、梦璃都有点担心妖界的事，暂时不会走远的。", "44365");
        giWait(0.7);
        giTalk("玄霄：如此说来，你下山的心意已决，大哥多说也无用了……", "44366");
        giWait(0.5);
        giSetPortrait("102E", true);
        giTalk("云天河：大哥，对不起……", "44367");
        giWait(0.5);
        giTalk("玄霄：无妨。人各有志，岂能相强。", "44368");
        giWait(0.5);
        giCameraRunSingle("013", true);
        giWait(0.8);
        giTalk("玄霄：妖界之事你不必过于担心，我有凝冰诀护体，再收融三寒器之力，往昔修为定能毫无顾忌地施展，其他小妖都不足为虑，唯一要注意的只有那妖界之主……", "44369");
        giSetPortrait("102H", false);
        giTalk("云天河：那是谁？比大哥你还厉害吗？……比我爹呢？", "44370");
        giTalk("玄霄：……我当年另有他事分心，并未亲眼所见，但我师父，前代掌门太清真人与那妖物缠斗，竟也不敌身死……有弟子说，妖界之主身法诡秘，如幻影飘忽，一招一式尽是俐落狠毒，绝非易与之辈……", "44371");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102H", false);
        giTalk("云天河：听起来很厉害……那要怎么样才能打赢他？", "44372");
        giWait(0.8);
        giTalk("玄霄：……以我今日之力，也未必会居于下风。", "44373");
        giTalk("玄霄：不过……大哥尚有一事相求，不知你能否答应？", "44374");
        giSetPortrait("102H", false);
        giTalk("云天河：什么事？大哥你尽管说。", "44375");
        giWait(0.5);
        giTalk("玄霄：你身上望舒剑可否借我一用？因羲和、望舒原是配剑，我运功破冰，除去三寒器之外，还需双剑的阴阳之力配合。", "44376");
        giSetPortrait("102B", false);
        giTalk("云天河：这个啊～大哥尽管拿去，反正这本来就是琼华派的东西，与其留给那个小气掌门，不如留给你比较好。", "44377");
        giPlayerDoAction(0, "J09", -1, false);
        giWait(0.5);
        giGOBAttachToPlayer("MO007", "", 0, true);
        giWait(2.5);
        giGOBDetachFromPlayer(0);
        giWait(1.0);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giDelProperty(3102, 1, true);
        giWait(2.5);
        giCameraRunSingle("014", false);
        giTalk("玄霄：……多谢。", "44378");
        giWait(0.5);
        giTalk("玄霄：天河，你助我良多，玄霄永志难忘。", "44379");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：说什么……我们都是兄弟了，帮你是应该的吧？", "44380");
        giWait(0.7);
        giTalk("玄霄：是啊，兄弟……", "44381");
        giWait(0.5);
        giTalk("玄霄：……你且走吧，此地玄冰非一时半刻能够破除，而我运功定会波及四周，恐怕要误伤于你。", "44382");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：好。", "44383");
        giSetPortrait("102K", false);
        giTalk("云天河：大哥你从禁地出来以后，要是我已经不在琼华派，千万别忘了来山下看看我～", "44384");
        giWait(0.5);
        giTalk("玄霄：…………我相信，你我缘分不会如此之浅……", "44385");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：（……呃，大哥这样讲，到底是答应了还是没答应呢？）", "44386");
        giWait(0.5);
        giTalk("玄霄：你去吧……", "44387");
        giWait(0.4);
        giPlayerDoAction(0, "C08", 1, true);
        giWait(0.8);
        giPlayerWalkTo(0, 1199.1, 131.0, 652.2, true);
        giPlayerSetVisible(0, false);
        giCameraWait();
        giWait(1.0);
        giCameraRunSingle("015", false);
        giSetPortrait("216F", true);
        giTalk("玄霄：…………", "44388");
        giWait(0.5);
        giSetPortrait("216F", true);
        giTalk("玄霄：十九年的遗憾……", "44389");
        giWait(0.5);
        giSetPortrait("216E", true);
        giTalk("玄霄：为前人所不能为之事，否则人生一世，还有何意！ ", "44390");
        giWait(0.5);
        giSetPortrait("216A", true);
        giTalk("玄霄：玄、霄、誓、灭、妖、界！！！", "44391");
        giWait(0.5);
        giCameraRunSingle("016", true);
        giWait(1.5);
        giCameraRunSingle("017", false);
        giSetObjectVisible("effect017", true);
        giGOMTouch("Jeffect001");
        giWait(10.5);
        giFlashOutWhite(1.5, true, true);
        giSetObjectVisible("effect017", false);
        global_mvar = 120300; // 0x0001D5EC, 第三章 / 7-4-1.仙妖乱 / 离开禁地
        giPlayerForbidenSkill(0, 5501, true);
        giPlayerForbidenSkill(0, 5502, true);
        giPlayerForbidenSkill(0, 5503, true);
        giPlayerForbidenSkill(0, 5504, true);
        giPlayerForbidenSkill(0, 5506, true);
        giArenaLoad("M20", "1", "", true);
    }
}

void func2023()
{
    if (global_mvar == 120400 /* 第三章 / 7-4-2.仙妖乱 / 兄弟话别 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 69.3, 0.7, 4.3);
        giPlayerSetAng(0, 212.0);
        giPlayerSetVisible(0, true);
        giCameraPrepare("MC004");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：（……对啊，都打算走了，这身衣服干脆换下来，虽然料子软软的，有点舍不得……）", "44396");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giPlayerGarb1(0);
        giPlayerGarb1(2);
        giIMMBegin();
        giPlayerSetPos(0, 85.8, 22.7, -55.0);
        giPlayerSetAng(0, 270.0);
        giPlayerSetPos(2, -59.4, 0.7, 66.0);
        giPlayerSetAng(2, 118.0);
        giPlayerSetVisible(2, true);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giPlayerDoAction(0, "C11", 0, false);
        giPlayerSetEmotion(0, "101_by");
        gi2DSoundPlay("WJ025", 1);
        giWait(1.0);
        giFlashInBlack(2.5, true);
        giWait(1.7);
        giPlayerResetEmotion(0);
        giWait(0.3);
        giPlayerDoAction(0, "J20", -1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：……这个香气……是梦璃？", "44397");
        giWait(0.5);
        giCameraRunSingle("003", true);
        giPlayerSetPos(0, 65.4, 0.7, -2.8);
        giPlayerSetAng(0, 302.0);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giPlayerSetEmotion(2, "106_yy");
        giCameraRunSingle("004", true);
        giWait(0.4);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……对不起，云公子，我并不是有意吵醒你的……", "44398");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：没、没什么，我睡得也不是很熟啊。", "44399");
        giPlayerEndAction(0);
        giPlayerWalkTo(0, 24.4, 0.7, 21.3, true);
        giPlayerSetAng(0, 308.0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：咦？你这身打扮……哈哈！我们俩想到一块去了，都不肯再穿琼华派的衣服～", "44400");
        giPlayerEndAction(0);
        giCameraRunSingle("005", false);
        giPlayerWalkTo(2, -26.1, 0.7, 47.8, true);
        giPlayerSetAng(2, 108.0);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：云公子……", "44401");
        giWait(0.5);
        giSetPortrait("101D", false);
        giTalk("云天河：梦璃？你怎么了？是不是去了寿阳，事情办得不顺？", "44402");
        giScriptMusicPlay("P31", 2, 0.0, 0.0);
        giWait(0.5);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：我……", "44403");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.3);
        giSetPortrait("101H", false);
        giTalk("云天河：那是……有人欺负你？！", "44404");
        giPlayerEndAction(0);
        giCameraRunSingle("006", true);
        giCameraRunSingle("007", false);
        giWait(0.6);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……云公子，你喜欢梦璃吗？", "44405");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：我、我……这个……", "44406");
        giWait(0.7);
        giSetPortrait("101F", false);
        giTalk("云天河：喜、喜欢啊……你怎么、突然问这个……", "44407");
        giPlayerDoAction(2, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……现在我的心里好乱，我不知道该怎么说，我……舍不得许多人……", "44408");
        giWait(0.5);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：我唯一能想到的，就是来见云公子……", "44409");
        giSetPortrait("101H", false);
        giTalk("云天河：舍不得很多人？梦璃你、到底怎么了？", "44410");
        giIMMBegin();
        giPlayerSetAng(0, 290.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giCameraRunSingle("009", false);
        giWait(0.3);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：云公子，你……真的喜欢梦璃吗？", "44411");
        giSetPortrait("101E", true);
        giTalk("云天河：喜欢……还分真的假的？", "44412");
        giPlayerDoAction(2, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……还记不记得在须臾幻境的酒仙翁那里……云公子听不懂仙翁说的话……", "44413");
        giSetPortrait("106F", false);
        giTalk("柳梦璃：那如今呢……云公子明白了吗？明白我说的又是什么？", "44414");
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：……", "44415");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：我……还是不太明白……", "44416");
        giSetPortrait("101E", true);
        giTalk("云天河：只是……每次单独和你在一起，好像总是很紧张……气都有些不顺……", "44417");
        giWait(0.5);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：是吗……真是对不起……", "44418");
        giWait(0.3);
        giCameraRunSingle("010", true);
        giWait(0.5);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不是不是，你别误会。我只是觉得你……很好看，对我又很好……我大概像菱纱说的，是个傻瓜，所以搞不清对着你该说什么…… ", "44419");
        giWait(0.6);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：真的吗……", "44420");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：嗯……只是你平时教我很多东西，我学的越多，越觉得……", "44421");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：觉得什么？", "44422");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：……我……还是好多事都不懂……", "44423");
        giSetPortrait("101G", false);
        giTalk("云天河：你又聪明，又好看……我们两个真是差太多了……", "44424");
        giWait(1.0);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……", "44425");
        giWait(1.0);
        giSetPortrait("101F", false);
        giTalk("云天河：…………我、我也不清楚自己在说什么……", "44426");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101F", false);
        giTalk("云天河：哈、哈哈……现在又觉得气都有点不顺呢……", "44427");
        giPlayerEndAction(0);
        giPlayerDoAction(2, "C09", 1, false);
        giWait(0.8);
        giCameraRunSingle("011", false);
        giWait(0.5);
        giPlayerWalkTo(2, 8.8, 0.7, 31.2, true);
        giPlayerSetAng(2, 122.0);
        giCameraRunSingle("012", false);
        giPlayerSetEmotion(2, "106_bk");
        giPlayerDoAction(2, "J10", -1, false);
        giWait(0.4);
        giSetPortrait("101D", false);
        giTalk("云天河：……！！", "44428");
        giSetPortrait("101D", false);
        giTalk("云天河：梦梦梦、梦璃！！！", "44429");
        giWait(0.5);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……云公子，你还记得吗？你曾经说过，我们要永远在一起……", "44430");
        giSetPortrait("101F", false);
        giTalk("云天河：记、记得！", "44431");
        giWait(0.5);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：我好后悔……总以为相处的时间还很多，总是自己一个人默默地想着、看着……我有好多话想跟云公子说……", "44432");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：云公子，你是一个很特别的人，从小到大我从没有跟任何一个人能相处得如此开心……很谢谢你说要保护我……可惜一切都是这么短暂…………", "44433");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：我终于能体会琴姬姐姐的心情……人和人的缘分真是注定的，上天要收回的时候，一时一刻都不会多等……", "44434");
        giSetPortrait("101C", false);
        giTalk("云天河：什么？", "44435");
        giWait(0.5);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：呜……", "44436");
        giSetPortrait("101H", false);
        giTalk("云天河：梦璃，你、你怎么哭了？！到底怎么了？是不是身体不舒服？", "44437");
        gi2DSoundPlay("WJ025", 1);
        giWait(2.0);
        giSetPortrait("104I", true);
        giTalk("韩菱纱：天河你在吗？我听其他弟子说，不得了了——", "44438");
        giIMMBegin();
        giPlayerSetPos(1, -37.4, 0.7, 88.1);
        giPlayerSetAng(1, 154.0);
        giPlayerSetVisible(1, true);
        giCameraRunSingle("013", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：你们？……", "44439");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerSetDir(0, 302.0, true);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：云公子……对不起，我……", "44440");
        giWait(0.5);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：多保重，梦璃会将你永远放在心里记着……永远记着……", "44441");
        giWait(0.6);
        giPlayerSetEmotion(2, "106_yy");
        giPlayerRunTo(2, 1.8, 0.7, 130.4, false);
        giWait(0.6);
        giPlayerSetDir(0, 350.0, false);
        giPlayerSetDir(1, 18.0, false);
        giPlayerSetVisible(2, false);
        giSetPortrait("101H", false);
        giTalk("云天河：梦璃！", "44442");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.8);
        giPlayerSetDir(1, 152.0, true);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：这是……怎么一回事？", "44443");
        giWait(0.5);
        giPlayerSetDir(0, 332.0, true);
        giWait(0.3);
        giSetPortrait("101H", false);
        giTalk("云天河：你问我、我也不知道啊……", "44444");
        giCameraRunSingle("014", false);
        giPlayerWalkTo(1, -6.5, 0.7, 57.8, true);
        giPlayerSetAng(1, 142.0);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：你装傻啊？梦璃抱着你，然后又哭着跑了出去……", "44445");
        giSetPortrait("104F", true);
        giTalk("韩菱纱：你、你是不是欺负她了？", "44446");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：没有啊，我真的不知道！", "44447");
        giSetPortrait("101H", false);
        giTalk("云天河：她……", "44448");
        giPlayerEndAction(0);
        giPlayerDoAction(0, "J15", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：感觉不太对劲……说话怪怪的……我现在就去找她，问清楚怎么回事。", "44449");
        giPlayerEndAction(0);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P42", 2, 0.0, 2.5);
        giGOMTouch("Jeffect001");
        giWait(0.4);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：呀——！", "44450");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101H", false);
        giTalk("云天河：房子、房子怎么会动？！", "44451");
        giSetPortrait("104I", true);
        giTalk("韩菱纱：不是房子！是整个山在震啊！大概真像其他弟子说的那样！妖界已经出现了！", "44452");
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：妖界出现了？！大哥不知现在怎样了！", "44453");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不对，我要赶紧出去追梦璃，万一她遇到危险怎么办！", "44454");
        giPlayerEndAction(0);
        giPlayerWalkTo(0, 2.9, 0.7, 123.0, false);
        giWait(0.5);
        giCameraRunSingle("015", true);
        giWait(0.3);
        giSetPortrait("104L", false);
        giTalk("韩菱纱：唔……", "44455");
        giPlayerEndMove(0);
        giWait(0.5);
        giPlayerSetDir(0, 186.0, true);
        giPlayerSetPos(1, -26.9, 0.7, 12.0);
        giPlayerSetAng(1, 142.0);
        giPlayerDoAction(1, "C11", 0, false);
        giSetPortrait("101D", true);
        giTalk("云天河：菱纱？！！", "44456");
        giPlayerRunTo(0, -29.4, 0.7, 61.5, false);
        giWait(0.2);
        giCameraRunSingle("016", true);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 194.0);
        giPlayerDoAction(0, "J03", -1, false);
        giCameraRunSingle("017", false);
        giSetPortrait("101H", true);
        giTalk("云天河：菱纱！菱纱你怎么了？！", "44457");
        giFlashOutBlack(2.5, true, true);
        giPlayerEndAction(1);
        giPlayerSetVisible(1, false);
        giSetNpcVisible("MN003", true);
        giPlayerSetPos(0, 50.4, 0.7, 1.6);
        giPlayerSetAng(0, 142.0);
        giCameraRunSingle("018", true);
        giWait(1.5);
        giNpcSetEmotion("MN003", "104_hm");
        giCameraRunSingle("020", true);
        giFlashInBlack(1.5, true);
        giWait(2.0);
        giSetPortrait("104H", true);
        giTalk("韩菱纱：嗯……", "44458");
        giWait(0.5);
        giNpcSetEmotion("MN003", "104_ss2");
        giSetPortrait("101H", true);
        giTalk("云天河：菱纱！你醒了？", "44459");
        giWait(2.0);
        giSetPortrait("104H", false);
        giTalk("韩菱纱：……我、我昏倒了吗？", "44460");
        giWait(0.5);
        giSetPortrait("104H", false);
        giTalk("韩菱纱：刚才有一瞬间，突然全身的力气都没了……", "44461");
        giSetPortrait("101H", true);
        giTalk("云天河：我现在就去找琼华派的大夫、不，还是先去找紫英，让他来看看怎么回事！", "44462");
        giSetPortrait("104H", false);
        giTalk("韩菱纱：不用了……我到底昏过去多久？你有没有找到梦璃？", "44463");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：我还没有去，你这样，我不敢离开。", "44464");
        giSetPortrait("104H", false);
        giTalk("韩菱纱：什么？那你快点、快点去找她呀……", "44465");
        giSetPortrait("104H", false);
        giTalk("韩菱纱：妖界来了，外面说不定很危险——", "44466");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：可是……我走了，你怎么办？", "44467");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giNpcSetEmotion("MN003", "104_hm");
        giWait(0.5);
        giSetPortrait("104H", false);
        giTalk("韩菱纱：我没事的……最近几个月常常头晕，一时半会儿又不会怎样，<colour red=255 green=187 blue=0 alpha=255>你先去找梦璃……</colour>", "44468");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：话是这么说没错，但是……", "44469");
        giSetPortrait("104H", false);
        giTalk("韩菱纱：快去吧……我在这儿等你们回来，妖怪……妖怪就算再怎么厉害，也不可能马上就杀到屋子里来吧？", "44470");
        giWait(0.7);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：……好吧，你自己小心。", "44471");
        giSetPortrait("104H", false);
        giTalk("韩菱纱：哎，别多说了，走吧……", "44472");
        giFlashOutBlack(1.5, true, true);
        giPlayerSetEmotion(2, "106_zc");
        giNpcSetEmotion("MN003", "104_hm");
        global_mvar = 120500; // 0x0001D6B4, 第三章 / 7-4-4.仙妖乱 / 寻找梦璃
        giCameraSetMode(3, true);
        giEventVolumeVisible("ev_Q06_QN05_1", false);
        giSetFullHP();
        giSetFullMP();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2024()
{
    if (global_mvar == 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 5844.1, -1383.6, -5731.8);
        giPlayerSetVisible(0, true);
        giSetNpcVisible("MN008", true);
        giSetNpcVisible("MN009", true);
        giSetNpcVisible("MN010", true);
        giSetNpcVisible("MN011", true);
        giIMMEnd();
        giArenaReady();
        giCameraPrepare("MC013");
        giCameraRunSingle("001", true);
        giPlayerRunTo(0, 5886.8, -1387.9, -5966.6, false);
        giFlashInBlack(1.5, false);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 176.0);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：喂！你有没有看见梦璃？！", "44473");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("怀砚：师弟！你怎么跑出来了？还这副打扮？！", "44474");
        giNpcDoAction("MN008", "C07", -1, false);
        giTalk("怀砚：唉！快快回屋！如今妖界的入口在卷云台现身不久，妖风正盛，修为低一些的弟子抵御不住，便会心神混乱，你千万莫要出来！", "44475");
        giNpcUnHoldAct("MN008");
        giNpcEndAction("MN008", false);
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：先告诉我！你到底有没有看见梦璃？！", "44476");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("怀砚：你、你是说柳师妹？没有啊，她——", "44477");
        giPlayerRunTo(0, 5709.0, -1383.6, -6133.8, false);
        giWait(1.0);
        giNpcSetDir("MN008", 232.0, true);
        giWait(0.5);
        giNpcDoAction("MN008", "C07", -1, false);
        giTalk("怀砚：师弟！师弟——！！", "44478");
        giNpcUnHoldAct("MN008");
        giNpcEndAction("MN008", false);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("002", true);
        giFlashInBlack(1.5, true);
        giTalk("明应：天呐！那那那、那就是妖界！入口好像一张狰狞的妖怪脸，实在可怕！", "44479");
        giTalk("明石：对啊！原本好好的，万里无云，后来只见卷云台上飞出一蓝一赤两道剑光，纠结于半空，紧接着一声巨响，像是从天上硬生生撕开一个大口子，然后就凭空出现了那张妖怪脸……", "44480");
        giTalk("明应：我、我听师父说过，十九年前那场大战，妖界一出现，天上就落下许多像巨蛋一样的怪东西，从里面出来的妖怪凶恶无比，残杀我派不知多少弟子……", "44481");
        giTalk("明石：如今不见什么妖怪出来，却已经妖风四起！那些妖物肯定有阴谋！难怪掌门不许我们靠近卷云台！", "44482");
        giTalk("怀理：可、可是……我刚才好像看见有个女孩子跑上了卷云台……", "44483");
        giNpcSetDir("MN010", 30.0, false);
        giNpcSetDir("MN011", 320.0, false);
        giWait(0.5);
        giTalk("明石：怎么可能！你眼花了吧？我怎么没看到！", "44484");
        giTalk("怀理：不骗你！就是那个新来没多久的女弟子柳梦璃！说不定你正好走神，才会没看见……", "44485");
        giTalk("明应：怀理师兄，我看这妖风果然不一般，竟能令人产生幻觉，我们还是早早离开为妙！", "44486");
        giTalk("明石：是啊是啊！快点走吧！", "44487");
        giWait(0.5);
        giTalk("怀理：可是……", "44488");
        giWait(0.3);
        giTalk("明应：走吧！师兄！难道你还要亲自上卷云台察看？！", "44489");
        giNpcFaceToNpc("MN009", "MN010", true);
        giTalk("怀理：我……唉…………", "44490");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, 5441.6, -1387.9, -6163.5);
        giPlayerSetAng(0, 236.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giPlayerDoAction(0, "J04", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：（梦璃她……她跑上了<colour red=255 green=187 blue=0 alpha=255>卷云台</colour><dc0>？！</dc0><colour red=255 green=187 blue=0 alpha=255>我要跟去看看！</colour><dc0>）</dc0>", "44491");
        giPlayerEndAction(0);
        giFlashOutBlack(1.5, true, true);
        giSetNpcVisible("MN008", false);
        giSetNpcVisible("MN009", false);
        giSetNpcVisible("MN010", false);
        giSetNpcVisible("MN011", false);
        giPlayerSetPos(0, 5085.0, -1387.9, -6273.6);
        giPlayerSetAng(0, 270.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giSetNpcVisible("", false);
        giFlushTailYAngle();
        global_mvar = 120501; // 0x0001D6B5, 第三章 / 7-4-5.仙妖乱 / 追上卷云台
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2025()
{
    if (global_mvar == 120501 /* 第三章 / 7-4-5.仙妖乱 / 追上卷云台 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P42", 2, 0.0, 2.5);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetObjectVisible("entrance1", false);
        giPlayerSetPos(0, 643.7, -1.4, -5.5);
        giPlayerSetAng(0, 268.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(2, 204.8, -0.5, -7.1);
        giPlayerSetAng(2, 286.0);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(1.5, false);
        giArenaReady();
        giWait(0.5);
        giCameraRunSingle("002", true);
        giWait(1.0);
        giPlayerDoAction(0, "J13", -1, false);
        giIMMBegin();
        giPlayerSetVisible(2, true);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giSetPortrait("101H", true);
        giTalk("云天河：（……这是什么……像有一种无形的气，让人连眼睛都睁不开……）", "44492");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerRunTo(0, 369.3, -1.5, -10.4, false);
        giWait(0.3);
        giCameraRunSingle("004", true);
        giPlayerEndMove(0);
        giWait(0.3);
        giSetPortrait("101H", false);
        giTalk("云天河：梦璃！", "44493");
        giWait(0.7);
        giPlayerSetDir(2, 82.0, true);
        giWait(0.3);
        giCameraRunSingle("005", false);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：云公子，你别过来！请你不要过来！", "44494");
        giSetPortrait("101H", false);
        giTalk("云天河：……！", "44495");
        giSetPortrait("101H", false);
        giTalk("云天河：梦璃……？", "44496");
        giWait(0.8);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：……云公子，在我小的时候，时常会做一个梦，梦见一种不属于人间的景象，那里常年有紫色的雾气弥漫……", "44497");
        giWait(0.5);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：偶尔……我会猜想自己是从哪里来的，发生过什么事，为什么会被云叔救下呢？", "44498");
        giPlayerSetEmotion(2, "106_yy");
        giSetPortrait("101H", false);
        giTalk("云天河：梦、梦璃，我们先回去吧，菱纱还在房里等着你！这儿离妖界太近、太危险了！", "44499");
        giWait(0.8);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……那些事情、梦里的事情，除了爹和娘，我只向你说过……", "44500");
        giCameraRunSingle("007", true);
        giCameraRunSingle("008", false);
        giWait(0.7);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：那一天，在柳家的庭院里，和你随意地聊着……如今想来，都还是觉得很开心。", "44501");
        giSetPortrait("106F", false);
        giTalk("柳梦璃：幸好，曾经留下了这些回忆……", "44502");
        giSetPortrait("101H", true);
        giTalk("云天河：……梦璃？你到底在说什么？", "44503");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", false);
        giTalk("柳梦璃：……我现在想起来了，从之前只是一个模糊的影子，到如今很清晰地出现在我脑海里……", "44504");
        giWait(0.6);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：这个妖界……我就是从这个妖界来的。", "44505");
        giSetPortrait("101D", true);
        giTalk("云天河：什么？！", "44506");
        giWait(0.8);
        giCameraRunSingle("009", true);
        giCameraRunSingle("010", false);
        giWait(0.7);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：云公子，请你快点带着菱纱下山去吧，若是你不走，或许有一天我们会兵刃相向，我……实在不想那样……", "44507");
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：梦璃，你说什么？我们怎么可能会互斗呢？不可能！ ", "44508");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：云公子，你保重……", "44509");
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106I", true);
        giTalk("柳梦璃：梦璃真的很舍不得云公子……", "44510");
        giPlayerEndAction(2);
        giPlayerRunTo(2, 69.2, -2.2, 7.0, true);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：梦璃！你、你回来！！", "44511");
        giFlashOutBlack(1.0, true, true);
        giPlayerSetEmotion(2, "106_zc");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerEndMove(2);
        giCameraRunSingle("001", true);
        giIMMBegin();
        giSetObjectVisible("entrance1", true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(2, false);
        global_mvar = 120800; // 0x0001D7E0, 第三章 / 7-5-1.往事 / 再寻玄霄
        giIMMEnd();
        giSetObjectVisible("sound003", false);
        giScriptMusicPause();
        giPlayMovie("12F.bik");
        giOpenMovieFlag(7);
        giScriptMusicResume();
        giSetObjectVisible("sound003", true);
        giArenaLoad("Q06", "QN05", "", true);
        giPlayerLock();
        giScriptMusicPlay("P32", 2, 2.5, 0.0);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giPlayerSetPos(0, 86.0, 22.7, -57.0);
        giPlayerSetAng(0, 324.0);
        giPlayerSetPos(1, 63.0, 4.7, 9.1);
        giPlayerSetAng(1, 154.0);
        giPlayerSetPos(3, -10.7, 0.7, 74.6);
        giPlayerSetAng(3, 134.0);
        giIMMEnd();
        giArenaReady();
        giPlayerGarb1(1);
        giCameraPrepare("MC005");
        giCameraRunSingle("001", true);
        giPlayerDoAction(1, "C10", 0, false);
        giPlayerDoAction(0, "C10", 0, false);
        giWait(0.3);
        giCGEffPlay(5);
        giCameraRunSingle("002", false);
        giFlashInBlack(1.2, false);
        giWait(2.0);
        giCameraRunSingle("003", false);
        giWait(2.0);
        giCameraRunSingle("002", true);
        giWait(1.5);
        giSetPortrait("101D", true);
        giTalk("云天河：……菱纱……？", "44512");
        giWait(0.5);
        giSetPortrait("101D", true);
        giTalk("云天河：还有紫英？这……是哪里？", "44513");
        giIMMBegin();
        giCGEffStop();
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.6);
        giPlayerSetVisible(0, true);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：天河你太过胡闹！！那妖界入口处布有结界，人若想强行穿过，必定会受重伤！所以掌门才不许弟子靠近！", "44514");
        giSetPortrait("105F", false);
        giTalk("慕容紫英：要是我再晚个半刻，你早就性命难保！", "44515");
        giPlayerDoAction(1, "C01", 1, false);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetPos(1, 69.2, 0.7, 21.8);
        giPlayerSetAng(1, 174.0);
        giPlayerSetAng(3, 148.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.4);
        giSetPortrait("101H", true);
        giTalk("云天河：……会受重伤？可是、可是梦璃她进去了，什么事都没有发生……", "44516");
        giSetPortrait("105D", false);
        giTalk("慕容紫英：……！！", "44517");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：梦璃？！怎么可能？你说她跑进了妖界？！", "44518");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101H", true);
        giTalk("云天河：真的！我没有看错！她还说了一堆很奇怪的话，她说自己是……", "44519");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：是什么？", "44520");
        giWait(0.5);
        giSetPortrait("101C", true);
        giTalk("云天河：……没什么……", "44521");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(1, 67.6, 0.7, 44.9);
        giPlayerSetAng(1, 206.0);
        giPlayerSetPos(0, 40.4, 0.7, -13.9);
        giPlayerSetAng(0, 335.0);
        giPlayerSetAng(3, 112.0);
        giPlayerDoAction(0, "C01", 1, false);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.3);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：……莫非……梦璃和妖界有什么关系？不然为何只有她能够通过那个结界？", "44522");
        giPlayerSetDir(1, 296.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：紫英，你不要乱猜！又没有什么凭据！", "44523");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("007", false);
        giPlayerWalkTo(0, 11.6, 0.7, 25.3, true);
        giPlayerSetAng(0, 336.0);
        giSetPortrait("101H", false);
        giTalk("云天河：……紫英，我问你，要是梦璃真的是妖，你会怎么办？", "44524");
        giWait(0.5);
        giPlayerSetDir(3, 148.0, true);
        giWait(0.5);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……梦璃是妖？", "44525");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：你回答我，你是不是也要杀了她？", "44526");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：梦璃不可能是妖！她身上没有任何妖气，掌门与长老也未察觉，连师叔都没有说什么，你不要乱想。", "44527");
        giSetPortrait("101G", false);
        giTalk("云天河：可是梦璃她自己说……", "44528");
        giWait(0.8);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：你让开，我要去找梦璃。", "44529");
        giIMMBegin();
        giPlayerSetPos(1, 52.7, 0.7, 42.5);
        giPlayerSetAng(1, 246.0);
        giPlayerSetAng(3, 164.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：胡闹！你被弹开之后，那妖界入口根本纹丝不动！凭你想要穿过那个结界，根本是不可能的！", "44530");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：……那我去找大哥，他以前和妖界交过手，一定有办法的！", "44531");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：我也和你一起去！", "44532");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("009", false);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetDir(0, 64.0, false);
        giPlayerSetDir(3, 114.0, false);
        giIMMEnd();
        giCameraWait();
        giSetPortrait("105A", false);
        giTalk("慕容紫英：你身体尚虚，最好再多静养。", "44533");
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：我、我没关系，梦璃的事更重要吧？", "44534");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：如果不是我突然晕倒……也许……天河就能拦住她了……", "44535");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：……和那没关系。", "44536");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 162.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：好吧，要是你们执意去找玄霄师叔，我也一起。", "44537");
        giCameraRunSingle("012", false);
        giPlayerSetDir(0, 322.0, false);
        giPlayerSetDir(1, 300.0, false);
        giWait(0.8);
        giSetPortrait("101H", true);
        giTalk("云天河：……好，但是不管真相是怎样的，你都不可以伤害梦璃！", "44538");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……往后的事情，多说无益，如今我只想弄清楚这到底是怎么一回事。", "44539");
        giCameraWait();
        giWait(0.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：喂！我说你们两个，与其花时间在这里互看，倒不如快点走！", "44540");
        giSetPortrait("103F", true);
        giTalk("韩菱纱：什么都还没做，自己人就先闹起来啦？", "44541");
        giCameraWait();
        giCameraRunSingle("013", false);
        giWait(1.0);
        giPlayerDoAction(3, "C07", -1, false);
        giWait(0.9);
        giSetObjectVisible("MO003", true);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：天河，这个给你，拿好。", "44542");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P33", 2, 0.0, 2.5);
        giSetPortrait("101C", true);
        giTalk("云天河：这是……？", "44543");
        giSetPortrait("105E", false);
        giTalk("慕容紫英：我替你打造了一把剑——", "44544");
        giSetPortrait("101D", true);
        giTalk("云天河：……！", "44545");
        giPlayerDoAction(0, "J09", -1, false);
        giWait(0.8);
        giIMMBegin();
        giSetObjectVisible("MO003", false);
        giSetObjectVisible("MO004", true);
        giPlayerSetAng(1, 272.0);
        giCameraRunSingle("014", true);
        giIMMEnd();
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giCameraRunSingle("015", false);
        giWait(0.3);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：你且收着。如今妖界降临，任何事情都得小心谨慎，就算你用的是望舒剑，将这支剑带在身边亦无坏处。", "44546");
        giSetPortrait("101A", false);
        giTalk("云天河：……望舒剑……我已经给了大哥，他破冰要用到。", "44547");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：咦？那不是正好能用这把？", "44548");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：我瞧瞧，这剑和望舒长得好像，连颜色都差不多呢。", "44549");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：不过是形似罢了，望舒剑所用之材可遇而不可求，何况终我一生，铸剑之术也难及宗炼师公，又如何能再造一把“望舒”……", "44550");
        giPlayerSetDir(1, 294.0, true);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：别这么说，我知道，你已经很厉害了，而且以你的性情，如果是给朋友用的剑，你一定更会费尽心思去打造……", "44551");
        giWait(0.8);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……", "44552");
        giWait(0.4);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：我说对了吧？", "44553");
        giSetPortrait("101A", false);
        giTalk("云天河：……", "44554");
        giSetObjectVisible("MO004", false);
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(0, 326.0);
        giPlayerSetPos(0, 14.1, 0.7, 17.5);
        giPlayerSetAng(1, 294.0);
        giPlayerSetPos(1, 38.6, 0.7, 47.5);
        giCameraRunSingle("016", true);
        giIMMEnd();
        giCameraRunSingle("017", false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我隐隐觉得，掌门有朝一日必会索回望舒剑，所以在闲暇之时打造了这把剑，希望天河能够用上……却想不到是玄霄师叔破冰会需要望舒……", "44555");
        giSetPortrait("101A", true);
        giTalk("云天河：紫英，谢谢你……", "44556");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：不必言谢，我只要求一件事，请善待这把剑。", "44557");
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.3);
        giSetPortrait("101A", true);
        giTalk("云天河：……呃，我、我答应你，绝不用它来烧烤……", "44558");
        giWait(0.7);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：紫英，它有名字吗？", "44559");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：剑的名字，自然是由剑的主人来取。", "44560");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.3);
        giSetPortrait("101A", true);
        giTalk("云天河：我、我想叫它“天河剑”，可以吗？……", "44561");
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：当然。", "44562");
        giSetPortrait("101A", true);
        giTalk("云天河：……谢谢你，紫英……", "44563");
        giSetPortrait("101A", true);
        giTalk("云天河：在妖界入口也是你救了我，刚才……我不应该那样对你说话……", "44564");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：紫英啊，就是不坦率，说不定他担心天河，就一直跟在后面呢。", "44565");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：…………", "44566");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：咦？我说中了？紫英你的脸有点红哎！", "44567");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：休要胡闹，当务之急，我们快些去找师叔。", "44568");
        giSetPortrait("103A", true);
        giTalk("韩菱纱：可是，天河已经把三寒器都交给了玄霄，玄霄又说他要破冰而出，现在他人到底在哪里呢？会不会已经不在禁地了？", "44569");
        giSetPortrait("101A", true);
        giTalk("云天河：不管怎样，<colour red=255 green=187 blue=0 alpha=255>我们还是先去禁地看看。</colour>", "44570");
        giWait(0.3);
        giPlayerDoAction(3, "C08", 1, true);
        giWait(0.2);
        giAddProperty(3112, 1, true);
        giWait(2.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerForbidenSkill(0, 5501, false);
        giPlayerForbidenSkill(0, 5502, false);
        giPlayerForbidenSkill(0, 5503, false);
        giPlayerForbidenSkill(0, 5504, false);
        giPlayerForbidenSkill(0, 5506, false);
        giPlayerInTeam(1, false);
        giPlayerInTeam(3, false);
        giIMMEnd();
        giSetFullHP();
        giSetFullMP();
        giArenaLoad("Q06", "Q06Q", "", true);
        giSetObjectVisible("entrance2", false);
        giPlayerCurrentSetPos(5673.3, -1383.3, -5515.6);
        giPlayerCurrentSetAng(115.0);
        giCameraSetMode(0, true);
        giArenaReady();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2027()
{
    if (global_mvar == 140800)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetNpcVisible("4050", false);
        giSetNpcVisible("4052", false);
        giSetNpcVisible("4017", false);
        giSetNpcVisible("4019", false);
        giSetNpcVisible("4018", false);
        giSetNpcVisible("4049", false);
        giSetNpcVisible("4020", false);
        giSetNpcVisible("4051", false);
        giNpcCreate("MN012", "231", 6995.0, -1388.4, -6112.0);
        giSetNpcVisible("MN012", true);
        giNpcSetAng("MN012", 228.0);
        giNpcCreate("MN013", "233", 7013.1, -1388.4, -6159.8);
        giSetNpcVisible("MN013", true);
        giNpcSetAng("MN013", 254.0);
        giNpcCreate("MN014", "234", 6910.9, -1388.4, -6150.5);
        giSetNpcVisible("MN014", true);
        giNpcSetAng("MN014", 74.0);
        giIMMEnd();
        giArenaReady();
        giCGEffPlay(11);
        giCameraPrepare("MC014");
        giCameraRunSingle("001", true);
        giFlashInWhite(1.5, false);
        giCameraRunSingle("002", true);
        giSetPortrait("234A", false);
        giTalk("太清真人：玄霄、天青，你二人既是由我亲自教授，切不可懒惰倦怠，何况你们根骨清奇，一看便知是修仙之才，只要勤奋努力，假以时日，必有大成！", "45557");
        giNpcDoAction("MN012", "J02", -1, false);
        giSetPortrait("231A", true);
        giTalk("玄霄：是！师父！", "45558");
        giNpcUnHoldAct("MN012");
        giNpcEndAction("MN012", false);
        giSetPortrait("233D", true);
        giTalk("云天青：是，师父。", "45559");
        giSetPortrait("234A", false);
        giTalk("太清真人：入门之初，基本的心法最为重要，把我昨日教授你们的，练至第三重境时，再来琼华宫找我。", "45560");
        giSetPortrait("231A", true);
        giTalk("玄霄：是！", "45561");
        giWait(0.6);
        giNpcWalkTo("MN014", 6839.7, -1388.4, -6202.7, true);
        giNpcUnHoldAct("MN012");
        giNpcEndAction("MN012", true);
        giIMMBegin();
        giNpcSetPos("MN013", 7021.5, -1388.4, -6167.5);
        giNpcSetAng("MN013", 282.0);
        giCameraRunSingle("004", true);
        giNpcDelete("MN014");
        giIMMEnd();
        giCameraRunSingle("003", false);
        giWait(0.3);
        giSetPortrait("233C", true);
        giTalk("云天青：唉……第三重境，那要练到哪一天啊，累也累死了……", "45562");
        giSetPortrait("231C", false);
        giTalk("玄霄：……", "45563");
        giNpcSetDir("MN013", 318.0, true);
        giSetPortrait("233A", true);
        giTalk("云天青：我说师兄～你我入门两天，吃睡都在一起，好歹也有过同床共枕之谊，可你跟我说话的次数，连十根手指都数不满，也太不够意思了吧？", "45564");
        giSetPortrait("231C", false);
        giTalk("玄霄：……", "45565");
        giSetPortrait("233A", true);
        giTalk("云天青：师兄你倒是说句话啊……", "45566");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN012", 152.0);
        giNpcSetAng("MN013", 336.0);
        giCameraRunSingle("005", false);
        giIMMEnd();
        giWait(1.5);
        giSetPortrait("231D", true);
        giTalk("玄霄：如你这般性情浮躁，说不定几天之后，便受不了练功之苦而放弃，与你说话也是多余。 ", "45567");
        giNpcWalkTo("MN012", 6974.2, -1388.4, -6074.2, false);
        giCameraRunSingle("006", false);
        giSetPortrait("233B", false);
        giTalk("云天青：哎！师兄你去哪里？", "45568");
        giNpcEndMove("MN012");
        giSetPortrait("231A", true);
        giTalk("玄霄：……练功！找个清静之地。", "45569");
        giNpcWalkTo("MN012", 6921.7, -1388.4, -5937.1, true);
        giCameraRunSingle("007", true);
        giSetPortrait("233C", true);
        giTalk("云天青：好诈……你想扔下师弟，自己一个人偷偷努力……", "45570");
        giSetPortrait("233D", true);
        giTalk("云天青：不行，我也要加油！不然和师兄实力相差太远，岂不要被师父念死……", "45571");
        giSetPortrait("233A", true);
        giTalk("云天青：师兄也真是把人看扁了，居然说我受不了练功之苦……怎么可能，我就努力练功跟你玩玩，哈哈！", "45572");
        giWait(0.5);
        giFlashOutWhite(1.5, true, true);
        giIMMBegin();
        giNpcSetPos("MN012", 7068.8, -1388.4, -6145.5);
        giNpcSetPos("MN013", 7016.2, -1388.4, -6200.0);
        giNpcSetAng("MN012", 232.0);
        giNpcSetAng("MN013", 38.0);
        giNpcCreate("MN015", "232", 6891.1, -1388.4, -6015.8);
        giSetNpcVisible("MN015", true);
        giNpcCreate("MN016", "487", 6913.7, -1388.4, -6002.5);
        giSetNpcVisible("MN016", true);
        giIMMEnd();
        giNpcDoAction("MN012", "J01", 0, false);
        giCameraRunSingle("008", true);
        giFlashInWhite(1.5, true);
        giWait(0.6);
        giSetPortrait("233C", true);
        giTalk("云天青：唉～～～都练了两个多月，还没到师父说的第三重境，他老人家是不是存心整我们啊……", "45573");
        giWait(0.5);
        giSetPortrait("231D", false);
        giTalk("玄霄：胡闹！自己不够努力，却怪到师父头上！", "45574");
        giSetPortrait("233C", true);
        giTalk("云天青：是是是……你和夙瑶师姐、玄震师兄都是一板一眼的人，就我总犯错……", "45575");
        giWait(0.5);
        giSetPortrait("231D", false);
        giTalk("玄霄：我看你待在思返谷，却是很快活。", "45576");
        giSetPortrait("233A", true);
        giTalk("云天青：思返谷好哇！少了一堆训斥唠叨～不过就是没饭吃，让人有点受不了……", "45577");
        giNpcWalkTo("MN015", 6949.9, -1388.4, -6117.8, false);
        giNpcWalkTo("MN016", 7001.5, -1388.4, -6109.1, false);
        giCameraRunSingle("009", true);
        giNpcSetDir("MN012", 280.0, false);
        giNpcSetDir("MN013", 318.0, false);
        giWait(0.6);
        giNpcEndMove("MN015");
        giNpcSetAng("MN015", 148.0);
        giNpcEndMove("MN016");
        giNpcSetAng("MN016", 152.0);
        giWait(0.5);
        giTalk("夙汐：两位师兄。", "45578");
        giSetPortrait("233A", true);
        giTalk("云天青：哟，是夙汐师妹啊，有何贵干？", "45579");
        giIMMBegin();
        giNpcSetPos("MN015", 6985.3, -1388.4, -6094.5);
        giNpcSetPos("MN016", 7031.1, -1388.4, -6087.4);
        giNpcSetAng("MN015", 130.0);
        giNpcSetAng("MN016", 236.0);
        giNpcSetPos("MN013", 7037.9, -1388.4, -6197.8);
        giNpcSetPos("MN012", 7070.7, -1388.4, -6161.7);
        giNpcSetAng("MN013", 338.0);
        giNpcSetAng("MN012", 296.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.5);
        giTalk("夙汐：这位是刚入门的夙玉师妹，也已被掌门师伯收入门下。但这几日掌门师伯另有要事忙碌，玄震师兄和夙瑶师姐又都不在门派中，所以请两位师兄多关照她一下。", "45580");
        giWait(0.5);
        giTalk("夙汐：夙玉，这便是我说过的玄霄师兄与天青师兄。", "45581");
        giNpcDoAction("MN015", "C08", 1, false);
        giSetPortrait("232A", false);
        giTalk("夙玉：玄霄师兄、天青师兄。", "45582");
        giWait(0.7);
        giIMMBegin();
        giCameraRunSingle("011", true);
        giNpcSetAng("MN016", 178.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("233B", false);
        giTalk("云天青：哇！你长这么漂亮也来修仙，岂不可惜了？", "45583");
        giNpcFaceToNpc("MN012", "MN013", true);
        giSetPortrait("231A", false);
        giTalk("玄霄：天青，休得胡言乱语。", "45584");
        giSetPortrait("232A", true);
        giTalk("夙玉：……容貌美丑，皆是皮下白骨，表象声色，又有什么分别？", "45585");
        giSetPortrait("233C", false);
        giTalk("云天青：唉，你年纪轻轻，便看这么透，岂不是一点也不好玩了……", "45586");
        giSetPortrait("231D", false);
        giTalk("玄霄：天青！", "45587");
        giNpcFaceToNpc("MN013", "MN012", true);
        giSetPortrait("233C", true);
        giTalk("云天青：好，我不说了，还是师兄懂得怜香惜——", "45588");
        giSetPortrait("233B", true);
        giTalk("云天青：啊！我真的不说了！你别瞪我啊……", "45589");
        giSetPortrait("232C", true);
        giTalk("夙玉：……", "45590");
        giTalk("夙汐：嘻嘻，夙玉，这两位师兄就是这样的，不过他们人都很好，久了你便知道了。", "45591");
        giNpcDoAction("MN015", "C08", 1, false);
        giSetPortrait("232A", true);
        giTalk("夙玉：嗯……", "45592");
        giNpcEndAction("MN015", true);
        giFlashOutWhite(1.5, true, true);
        giCGEffStop();
        giNpcDelete("MN012");
        giNpcDelete("MN013");
        giNpcDelete("MN015");
        giNpcDelete("MN016");
        giArenaLoad("Q06", "QN03", "", true);
        giScriptMusicPlay("P26", 2, 2.5, 2.5);
        giSetNpcVisible("MN003", true);
        giSetNpcVisible("MN004", true);
        giSetNpcVisible("MN005", true);
        giSetNpcVisible("MN006", true);
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giArenaReady();
        giCGEffPlay(11);
        giCameraPrepare("MC005");
        giCameraRunSingle("001", true);
        giFlashInWhite(1.5, true);
        giWait(0.4);
        giSetPortrait("234A", false);
        giTalk("太清真人：玄霄、夙玉，我今日命你二人前来，乃是有一件关乎本派的大事要交托！", "45593");
        giSetPortrait("231A", true);
        giTalk("玄霄：……！", "45594");
        giCameraRunSingle("002", false);
        giSetPortrait("234A", false);
        giTalk("太清真人：宗炼，便由你来说吧。", "45595");
        giWait(0.5);
        giWait(0.5);
        giNpcWalkTo("MN006", -30.2, 40.8, -151.7, true);
        giNpcSetAng("MN006", 28.0);
        giSetPortrait("235A", false);
        giTalk("宗炼：你们都已知道，昆仑诸峰之巅，有天光投下的地方，便是传说中的通仙之途，若能通过，则可白日飞升成仙，只是那里灵气充沛，彼此激荡，绝非一人之力能够靠近。", "45596");
        giSetPortrait("235A", false);
        giTalk("宗炼：吾派修仙，虽日积月累，勤奋不懈，可惜成效甚微……", "45597");
        giSetPortrait("235A", false);
        giTalk("宗炼：直至第二十代掌门道胤真人，这位绝世之才的先辈，悟出以人养剑，万物分阴阳，而阴阳生万物，若能修炼一对雌雄双剑，以巨大灵力形成剑柱，直冲云霄，至昆仑山上天光投下处，则门派中诸人皆可抛却肉体凡胎，成为仙身！ ", "45598");
        giWait(0.5);
        giSetPortrait("235A", false);
        giTalk("宗炼：自那之后，吾派穷三代之力，于我手中，终成羲和、望舒两剑！", "45599");
        giWait(1.1);
        giIMMBegin();
        giSetObjectVisible("MO001", true);
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("effect010", true);
        giSetObjectVisible("effect011", true);
        giIMMEnd();
        giWait(1.5);
        giCameraRunSingle("003", true);
        giWait(1.1);
        giSetPortrait("231A", true);
        giTalk("玄霄：这……！确是绝世的神兵利器！", "45600");
        giWait(0.5);
        giSetPortrait("235A", false);
        giTalk("宗炼：如今双剑还是死物，若能灌注生人灵气，则力量之巨不可想像！", "45601");
        giWait(0.5);
        giSetPortrait("234A", false);
        giTalk("太清真人：玄霄、夙玉，你二人已被选为羲和剑、望舒剑之宿体，从今往后，便要人剑同修，助我琼华派早日升仙！", "45602");
        giNpcDoAction("MN004", "J02", -1, false);
        giSetPortrait("231A", true);
        giTalk("玄霄：弟子、弟子担此重任，定会勤加修行，不辱使命！", "45603");
        giNpcUnHoldAct("MN004");
        giNpcEndAction("MN004", true);
        giSetPortrait("232D", true);
        giTalk("夙玉：…………", "45604");
        giWait(0.3);
        giSetPortrait("234A", false);
        giTalk("太清真人：夙玉，你似乎有话要说？", "45605");
        giWait(0.7);
        giNpcDoAction("MN003", "J01", 1, false);
        giSetPortrait("232D", true);
        giTalk("夙玉：弟子惶恐！若是望舒剑需要女子作为宿体，如此重任，为何不交给夙瑶师姐呢？弟子修为浅薄，只怕承担不来……", "45606");
        giSetPortrait("234A", false);
        giTalk("太清真人：……先不说夙瑶资质并不及你，单是这双剑宿体，须得是生辰之中、阴阳极盛之人，我于山下寻访多年，才发现了你与玄霄……", "45607");
        giSetPortrait("232A", true);
        giTalk("夙玉：原来如此……所以师父才会来到夙玉所居的小城……", "45608");
        giSetPortrait("234A", false);
        giTalk("太清真人：不错，万里挑一，自然要费一番心思，所幸最后终于找到你们两个，这亦是上天怜我琼华啊！", "45609");
        giWait(0.5);
        giSetPortrait("235A", false);
        giTalk("宗炼：你二人此三年中，务必刻苦修行，三年之后便是一个绝佳的机会……", "45610");
        giWait(0.3);
        giSetPortrait("231A", true);
        giTalk("玄霄：机会？……弟子愚昧，请长老明示。", "45611");
        giCameraRunSingle("004", true);
        giWait(0.5);
        giSetPortrait("235A", false);
        giTalk("宗炼：若要做成剑柱，单凭你二人灵力、与附近山峰之灵气，尚且远远不够，其余的便要从妖界取来。", "45612");
        giSetPortrait("231D", true);
        giTalk("玄霄：妖界？！ ", "45613");
        giSetPortrait("234A", false);
        giTalk("太清真人：不错，道胤真人这位前辈确有惊天动地之才，他夜观星象，发现有一妖界如天轨运移一般，每隔十九年，便接近一次琼华派……", "45614");
        giSetPortrait("234A", false);
        giTalk("太清真人：只是此界形迹隐去，本派须以双剑之力冲击而上，令其现形，将其网缚，再想方设法取得其中灵力，同时亦可将妖物除去，岂不是两全之策？", "45615");
        giWait(0.3);
        giCameraRunSingle("005", true);
        giWait(0.4);
        giSetPortrait("231A", true);
        giTalk("玄霄：网缚妖界？请长老指教，这要如何行事？", "45616");
        giSetPortrait("235A", false);
        giTalk("宗炼：同样要借助双剑之力！详细情形，我过些时日再与你们说。", "45617");
        giWait(0.5);
        giNpcDoAction("MN004", "J02", 1, false);
        giSetPortrait("231A", true);
        giTalk("玄霄：是。", "45618");
        giWait(0.5);
        giSetPortrait("234A", false);
        giTalk("太清真人：从今日起，你二人便每日去禁地修行，禁地之门须由灵光藻玉开启，你们各持一块，切不可交由其他弟子！", "45619");
        giSetPortrait("231A", true);
        giTalk("玄霄：是！", "45620");
        giWait(0.3);
        giNpcDoAction("MN003", "J01", 1, false);
        giSetPortrait("232A", true);
        giTalk("夙玉：是！", "45621");
        giWait(0.5);
        giFlashOutWhite(1.5, true, true);
        giCGEffStop();
        global_mvar = 140801; // 0x00022601
        giArenaLoad("M12", "1", "", true);
    }
}

void func2028()
{
    if (global_mvar == 141000)
    {
        giPlayerLock();
        giScriptMusicPlay("P27", 2, 2.5, 2.5);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN004", true);
        giSetObjectVisible("MO001", false);
        giSetObjectVisible("MO002", false);
        giCameraPrepare("MC006");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giArenaReady();
        giCGEffPlay(11);
        giFlashInWhite(1.5, true);
        giWait(1.0);
        giCameraRunSingle("002", true);
        giCameraRunSingle("003", true);
        giCameraRunSingle("004", false);
        giWait(0.8);
        giSetPortrait("213B", true);
        giTalk("夙瑶：玄霄！为何将给你送饭的弟子打成重伤？！", "45649");
        giWait(0.5);
        giSetPortrait("216D", false);
        giTalk("玄霄：他们看了便让人觉得碍眼，以后都不必再来。", "45650");
        giSetPortrait("213B", true);
        giTalk("夙瑶：你！你这样让我如何向同门交代，本派禁地之中养了一只会伤人的怪物吗？！", "45651");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.7);
        giSetPortrait("216D", true);
        giTalk("玄霄：我是怪物？！", "45652");
        giWait(0.8);
        giSetPortrait("216D", true);
        giTalk("玄霄：你说的没错！我如今人不人、鬼不鬼地被囚在这里，自然比不上你做了掌门，风光无限！", "45653");
        giCameraRunSingle("006", false);
        giWait(1.7);
        giSetPortrait("213B", false);
        giTalk("夙瑶：……玄霄，你早已被阳炎噬心，神智不清了。", "45654");
        giWait(0.3);
        giSetPortrait("216D", true);
        giTalk("玄霄：可笑！换你被关在这种暗无天日的地方，你又会多清醒！", "45655");
        giSetPortrait("213B", false);
        giTalk("夙瑶：多说无益。", "45656");
        giWait(0.5);
        giSetPortrait("213B", false);
        giTalk("夙瑶：三位长老，请出来！", "45657");
        giCameraWait();
        giWait(0.5);
        giIMMBegin();
        giEffectPlayWithNPC("H_097", 1, "MN002");
        giEffectPlayWithNPC("H_097", 1, "MN003");
        giEffectPlayWithNPC("H_097", 1, "MN005");
        giNpcBlendIn("MN002", 1.5, false);
        giNpcBlendIn("MN003", 1.5, false);
        giNpcBlendIn("MN005", 1.5, false);
        giIMMEnd();
        giWait(1.5);
        giCameraRunSingle("007", true);
        giWait(0.5);
        giSetPortrait("216C", false);
        giTalk("玄霄：你们……？", "45658");
        giSetPortrait("213B", true);
        giTalk("夙瑶：玄霄，你如今走火入魔、丧失清明，我只有与三位长老合力，将你封入玄冰之中！", "45659");
        giWait(0.5);
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN006", true);
        giIMMEnd();
        giCameraRunSingle("008", false);
        giWait(0.5);
        giSetObjectVisible("Jeffect006", true);
        giSetPortrait("216J", false);
        giTalk("玄霄：什么？！你们敢！！", "45660");
        giSetPortrait("213B", true);
        giTalk("夙瑶：动手！！", "45661");
        giSetPortrait("235A", true);
        giTalk("宗炼：…………", "45662");
        giSetPortrait("218A", true);
        giTalk("重光：…………", "45663");
        giSetPortrait("217A", true);
        giTalk("青阳：…………", "45664");
        giWait(0.5);
        giSetPortrait("213C", true);
        giTalk("夙瑶：诸位长老还等什么！莫非到此时还存有妇人之仁？！", "45665");
        giWait(0.5);
        giSetPortrait("216J", false);
        giTalk("玄霄：夙瑶，你莫要做的太绝！", "45666");
        giWait(0.5);
        giNpcDoAction("MN002", "C09", 1, false);
        giSetPortrait("217A", true);
        giTalk("青阳：……玄霄，琼华派数百年基业，有如国有国法，不可相违，今日虽愧对于你，却是不可不为！若有他法能够救你，我等断不会行这下下之策！", "45667");
        giNpcSetDir("MN006", 176.0, true);
        giSetPortrait("216J", false);
        giTalk("玄霄：长老！青阳长老！为何连你也——！", "45668");
        giWait(0.5);
        giNpcDoAction("MN002", "J01", -1, false);
        giWait(0.1);
        giNpcDoAction("MN005", "J01", -1, false);
        giWait(0.1);
        giNpcDoAction("MN003", "J01", -1, false);
        giWait(1.0);
        giSetObjectVisible("Jeffect005", true);
        giWait(0.1);
        giSetObjectVisible("Jeffect004", true);
        giWait(0.1);
        giSetObjectVisible("Jeffect003", true);
        giNpcDoAction("MN004", "J02", 1, false);
        giWait(3.05);
        giFlashOutWhite(1.5, true, true);
        giIMMBegin();
        giSetObjectVisible("Jeffect005", false);
        giSetObjectVisible("Jeffect003", false);
        giSetObjectVisible("Jeffect004", false);
        giSetObjectVisible("Jeffect006", false);
        giIMMEnd();
        giTalk("玄霄：住手——！！", "45669");
        giNpcEndAction("MN004", true);
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", true);
        giNpcUnHoldAct("MN003");
        giNpcEndAction("MN003", true);
        giNpcUnHoldAct("MN005");
        giNpcEndAction("MN005", true);
        giIMMBegin();
        giSetNpcVisible("MN006", false);
        giSetObjectVisible("MO001", true);
        giNpcSetPos("MN002", 1331.2, 131.0, 637.8);
        giNpcSetAng("MN002", 2.0);
        giNpcSetPos("MN003", 1280.7, 131.0, 647.8);
        giNpcSetAng("MN003", 26.0);
        giNpcSetPos("MN004", 1294.7, 131.0, 721.1);
        giNpcSetAng("MN004", 24.0);
        giNpcSetPos("MN005", 1213.4, 131.0, 698.3);
        giNpcSetAng("MN005", 48.0);
        giIMMEnd();
        giCameraRunSingle("010", true);
        giFlashInBlack(1.5, true);
        giWait(0.8);
        giSetPortrait("216C", true);
        giTalk("玄霄：夙瑶！你竟如此对我！！", "45670");
        giWait(0.5);
        giCameraRunSingle("011", true);
        giWait(0.5);
        giSetPortrait("213A", true);
        giTalk("夙瑶：师弟……我这样做也是为了你好，不然你狂性大发，出去伤人，却要如何是好？", "45671");
        giWait(0.6);
        giSetPortrait("213A", true);
        giTalk("夙瑶：你不该恨我，要恨就恨云天青和夙玉，若不是他们出逃，你又怎会落到这样的下场！", "45672");
        giSetPortrait("216C", false);
        giTalk("玄霄：一派胡言！放我出去！！", "45673");
        giWait(1.2);
        giNpcSetDir("MN004", 180.0, true);
        giIMMBegin();
        giCameraRunSingle("010", true);
        giNpcSetAng("MN002", 334.0);
        giNpcSetAng("MN003", 6.0);
        giNpcSetAng("MN005", 88.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("213A", true);
        giTalk("夙瑶：几位长老，你们也都看到了，如今师弟成狂，若是放他出去，必定酿成大祸！", "45674");
        giWait(0.5);
        giSetPortrait("213A", true);
        giTalk("夙瑶：诸位须得谨守禁地的秘密，绝不能存有不必要的恻隐之心！", "45675");
        giSetPortrait("235A", false);
        giTalk("宗炼：…………", "45676");
        giWait(0.5);
        giCameraRunSingle("012", true);
        giWait(0.5);
        giNpcDoAction("MN002", "C09", 1, false);
        giSetPortrait("217A", true);
        giTalk("青阳：……经历这场大战，我与重光身心俱疲，早已有意隐居后山，不再过问派中诸事，掌门尽可放心，我二人也不会再来禁地。", "45677");
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：与妖界之争，伤亡惨重，门派中正值用人之际，长老何出此言？依我之见，此事再从长计议不迟。", "45678");
        giSetPortrait("217A", true);
        giTalk("青阳：……", "45679");
        giWait(0.5);
        giNpcSetDir("MN004", 26.0, true);
        giIMMBegin();
        giSetNpcVisible("MN005", false);
        giCameraRunSingle("013", true);
        giIMMEnd();
        giWait(0.9);
        giSetPortrait("213A", true);
        giTalk("夙瑶：师弟，你的灵光藻玉暂且由我保管，剑林之中我也会布下符灵。若是弟子们寻到夙玉和望舒剑的下落，我自会放你出来！", "45680");
        giSetPortrait("216C", false);
        giTalk("玄霄：夙瑶！！我要杀了你！", "45681");
        giWait(0.5);
        giNpcSetDir("MN004", 200.0, true);
        giWait(0.7);
        giSetPortrait("213A", false);
        giTalk("夙瑶：诸位长老，我们走。", "45682");
        giWait(0.8);
        giNpcWalkTo("MN004", 1265.8, 131.0, 652.2, true);
        giCameraRunSingle("014", false);
        giSetPortrait("216C", false);
        giTalk("玄霄：回来！你们放我出去——！！", "45683");
        giFlashOutWhite(3.5, true, true);
        giCGEffStop();
        giCameraRunSingle("013", true);
        giIMMBegin();
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN004", false);
        giIMMEnd();
        global_mvar = 141100; // 0x0002272C
        giArenaLoad("Q14", "LN01", "", true);
    }
}

void func2029()
{
    if (global_mvar == 141800 /* 幻瞑界入口 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P28", 2, 0.0, 0.0);
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -1447.0, 145.4, -21.2);
        giPlayerSetAng(0, 86.0);
        giPlayerSetPos(1, -1463.1, 150.1, -40.5);
        giPlayerSetAng(1, 70.0);
        giPlayerSetPos(2, -1456.7, 148.8, 9.8);
        giPlayerSetAng(2, 94.0);
        giPlayerSetPos(3, -1452.0, 147.5, 39.1);
        giPlayerSetAng(3, 104.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giFlashInBlack(1.5, false);
        giArenaReady();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giCameraRunSingle("002", false);
        giWait(6.0);
        giCameraRunSingle("004", true);
        giWait(1.5);
        giSetPortrait("106G", true);
        giTalk("柳梦璃：归邪将军！", "45837");
        giWait(0.5);
        giSetObjectVisible("Jeffect003", true);
        giNpcBlendOut("MN003", 2.7, false);
        giCameraRunSingle("005", true);
        giWait(2.5);
        giSetObjectVisible("Jeffect005", true);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：想要伺机杀死我与玄霄？哼！单凭他一个，怎可能！", "45838");
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：以为琼华派还会如十九年前一般，掌门死了就门派大乱吗？！", "45839");
        giSetPortrait("216H", true);
        giTalk("玄霄：哼、夙瑶你很得意？", "45840");
        giNpcSetDir("MN002", 175.0, true);
        giSetPortrait("213C", false);
        giTalk("夙瑶：你…………", "45841");
        giIMMBegin();
        giPlayerSetPos(0, -980.3, 6.6, -21.2);
        giPlayerSetAng(0, 90.0);
        giPlayerSetPos(1, -998.2, 5.5, -51.7);
        giPlayerSetAng(1, 68.0);
        giPlayerSetPos(2, -973.1, 7.9, 13.2);
        giPlayerSetAng(2, 92.0);
        giPlayerSetPos(3, -992.4, 12.7, 49.4);
        giPlayerSetAng(3, 100.0);
        giIMMEnd();
        giWait(0.2);
        giCameraRunSingle("006", true);
        giSetPortrait("202E", false);
        giTalk("璇玑：……紫英师叔！你、你什么时候进去妖界的？我怎么都没看见？", "45842");
        giNpcSetAng("MN002", 266.0);
        giWait(1.0);
        giCameraRunSingle("007", true);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：…………", "45843");
        giPlayerWalkTo(0, -885.2, 14.0, -30.2, true);
        giPlayerSetAng(0, 90.0);
        giWait(1.0);
        giSetPortrait("101H", true);
        giTalk("云天河：大哥……", "45844");
        giWait(0.5);
        giNpcWalkTo("MN001", -792.8, 21.0, -38.2, false);
        giGOBMovment("Jeffect005", 1.5, -792.8, 21.0, -38.2, true);
        giCameraRunSingle("008", true);
        giSetPortrait("216G", false);
        giTalk("玄霄：天河，有一阵子不见了，大哥很是挂念你。", "45845");
        giNpcEndMove("MN001");
        giCameraRunSingle("009", false);
        giWait(3.5);
        giSetPortrait("101H", true);
        giTalk("云天河：……大哥，一切……都是你骗我吗？", "45846");
        giWait(1.5);
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：你和掌门都在骗我？！其实……你只想取回望舒剑，只想升仙，只想强夺幻瞑界的灵力？！", "45847");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("216G", false);
        giTalk("玄霄：……有些事，我确实没有对你说真话，但也未必说了假话，事到如今，真真假假又有什么重要，最重要的是——", "45848");
        giSetPortrait("216G", false);
        giTalk("玄霄：我还是把你当兄弟，绝无害你之心。", "45849");
        giIMMBegin();
        giPlayerSetAng(0, 88.0);
        giNpcSetAng("MN001", 270.0);
        giNpcSetPos("MN002", -785.9, 25.4, 3.9);
        giNpcSetAng("MN002", 250.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.3);
        giSetPortrait("101I", false);
        giTalk("云天河：可恶！我是那么相信你！！", "45850");
        giWait(0.3);
        giEffectAttachToPlayer(0, "H_130", false);
        giPlayerDoAction(0, "J31", 1, false);
        giNpcDoAction("MN002", "J03", 1, false);
        giSetObjectVisible("Jeffect004", true);
        giEffectDetachFromPlayer(0);
        giWait(0.1);
        giGOBAttachToNpc("MO004", "H_080", "MN002", false);
        giGOBDetachFromNPC("MN002");
        giSetPortrait("213B", true);
        giTalk("夙瑶：不自量力！！", "45851");
        giPlayerSetAng(1, 118.0);
        giPlayerDoAction(1, "Z12", 0, false);
        giPlayerSetPos(2, -986.0, 7.9, -17.7);
        giPlayerSetAng(2, 206.0);
        giPlayerDoAction(2, "J03", -1, true);
        giSetPortrait("103L", false);
        giTalk("韩菱纱：唔……", "45852");
        giSetPortrait("106G", true);
        giTalk("柳梦璃：菱纱！", "45853");
        giIMMBegin();
        giPlayerDoAction(0, "C01", 0, false);
        giPlayerSetAng(0, 256.0);
        giPlayerSetAng(3, 188.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giSetPortrait("101H", true);
        giTalk("云天河：怎么会……？！", "45854");
        giPlayerRunTo(0, -956.9, 7.8, -46.2, true);
        giPlayerSetAng(0, 256.0);
        giPlayerDoAction(0, "J03", -1, true);
        giWait(1.0);
        giIMMBegin();
        giSetObjectVisible("Jeffect009", true);
        giSetObjectVisible("Jeffect008", true);
        giIMMEnd();
        giWait(1.0);
        giSetPortrait("216G", true);
        giTalk("玄霄：天河，你运功只能救她一时，却不能救她一世，你若再与夙瑶斗下去，那位姑娘只会更惨。", "45855");
        giWait(0.5);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：云公子，我先把菱纱送回幻瞑宫，我的族人会照顾她。", "45856");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：……好。", "45857");
        giIMMBegin();
        giSetObjectVisible("Jeffect009", false);
        giSetObjectVisible("Jeffect008", false);
        giIMMEnd();
        giWait(0.7);
        giSetObjectVisible("Jeffect007", true);
        giPlayerBlendOut(1, 1.0, true);
        giWait(1.5);
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giEffectPlayWithPlayer("H_097", 1, 2);
        giPlayerBlendOut(2, 1.0, false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.7);
        giIMMBegin();
        giPlayerSetPos(0, -885.2, 14.0, -30.2);
        giPlayerSetAng(0, 90.0);
        giPlayerSetPos(2, -948.6, 7.9, -33.2);
        giPlayerSetAng(2, 90.0);
        giPlayerSetPos(3, -952.1, 14.0, 30.7);
        giPlayerSetAng(3, 110.0);
        giNpcSetPos("MN002", -770.7, 23.4, 28.4);
        giNpcSetAng("MN002", 248.0);
        giCameraRunSingle("019", true);
        giIMMEnd();
        giCameraRunSingle("020", false);
        giWait(0.6);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：刚才说的什么意思？！", "45858");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giSetPortrait("216G", true);
        giTalk("玄霄：……你一点也未觉察到吗？", "45859");
        giWait(0.5);
        giSetPortrait("216G", true);
        giTalk("玄霄：望舒剑以至阴女体为宿体，方可激发灵力。它的前主人夙玉死后，望舒剑力量顿失，从此陷入长眠。", "45860");
        giWait(0.5);
        giSetPortrait("216G", true);
        giTalk("玄霄：直到有个女子，亦是阴时阴刻出生，命中带水，命相乃是罕见的天水违行，才可令望舒剑复苏。", "45861");
        giSetPortrait("101D", false);
        giTalk("云天河：……！", "45862");
        giWait(0.5);
        giSetPortrait("216G", true);
        giTalk("玄霄：越是使用此剑，新的宿体越会体虚畏寒，如不懂得修行之法，情形更是不妙。", "45863");
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：新的宿体，是指菱纱？！", "45864");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("021", true);
        giCameraRunSingle("022", false);
        giWait(0.5);
        giSetPortrait("216K", false);
        giTalk("玄霄：不错，我不清楚她怎样机缘巧合，竟会碰触到沉眠中的望舒剑，但她成为宿体确是事实，恐怕云天青也料不到天下会有这等巧合之事。", "45865");
        giWait(0.5);
        giSetPortrait("216K", false);
        giTalk("玄霄：韩菱纱来到琼华派后，夙瑶命慕容紫英传她修行心法，便是令她吐纳运气、强身健体，虽不是很有用，却也聊胜于无。", "45866");
        giWait(0.5);
        giSetPortrait("216G", false);
        giTalk("玄霄：……不过，我破冰而出，又以双剑网缚妖界，对她而言，是极大耗损。", "45867");
        giWait(0.5);
        giSetPortrait("216G", false);
        giTalk("玄霄：适才我与夙瑶合力破除结界，则又是耗去许多望舒之力，韩菱纱的身体怕是已经支撑不住了。", "45868");
        giPlayerDoAction(0, "J04", -1, false);
        giWait(0.7);
        giIMMBegin();
        giPlayerSetVisible(2, false);
        giCameraRunSingle("023", true);
        giIMMEnd();
        giCameraRunSingle("024", false);
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：……因为这样，所以在墓室里，菱纱碰了那把剑，剑才会发光……", "45869");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：所以青阳和重光长老才会让我少用望舒剑……", "45870");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：所以重光长老才会传她心法、送出暖玉……", "45871");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：所以菱纱的身体才会越来越差，越来越怕冷……", "45872");
        giWait(1.0);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("025", true);
        giCameraRunSingle("026", false);
        giWait(0.5);
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：这所有一切，都是有原因的！你们通通知道，却从来不说！！", "45873");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("216G", false);
        giTalk("玄霄：天河，你莫焦急，待我成仙，救回韩菱纱不过是举手之劳。", "45874");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：……待你成仙……那是什么时候？", "45875");
        giPlayerEndAction(0);
        giSetPortrait("216G", false);
        giTalk("玄霄：如今妖界灵力衰竭，而琼华派剑柱将成，飞升指日可待，再慢也是一月之内的事。", "45876");
        giWait(0.7);
        giSetPortrait("216G", false);
        giTalk("玄霄：……天河，你体质特异，能够天生不受寒冰之气侵扰，想必是万中无一的资质，不如与我一同修行，不久即可白日飞升，从此逍遥天地间，岂不是很好？", "45877");
        giWait(1.0);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：……大哥，你明明说过的，只要找到那三件至阴至寒的东西，你就不会被阳炎侵蚀！", "45878");
        giWait(0.7);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giSetPortrait("101H", true);
        giTalk("云天河：是不是那些东西根本没用？没用的话，我再去帮你找，直到找到为止！", "45879");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：你、你不该是这样的啊，简直就像变了一个人……", "45880");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P29", 2, 0.0, 0.0);
        giWait(0.8);
        giIMMBegin();
        giSetNpcVisible("MN002", false);
        giPlayerSetVisible(0, false);
        giCameraRunSingle("027", true);
        giIMMEnd();
        giCameraRunSingle("028", false);
        giWait(0.5);
        giSetPortrait("216J", false);
        giTalk("玄霄：变了？这却是从何说起？", "45881");
        giWait(0.5);
        giSetPortrait("216J", false);
        giTalk("玄霄：那三件寒器自然管用，我十九年来从未这样清醒过……以前在禁地之中，每时每刻都有许多景象出现在脑海里，简直快要把我逼疯了……", "45882");
        giWait(0.5);
        giSetPortrait("216J", false);
        giTalk("玄霄：所以，现在这样就很好……我失去了太多，如今的琼华派与妖界更是令我大失所望。", "45883");
        giWait(0.5);
        giSetPortrait("216J", false);
        giTalk("玄霄：天河，你能了解吗？凝冰诀与三寒器，最终还是抵不过人从空虚中生出的欲望……", "45884");
        giWait(0.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：……", "45885");
        giWait(0.5);
        giSetPortrait("216I", false);
        giTalk("玄霄：你看，我如今能够自如地操纵火焰，却不会被它吞噬，再加上凝冰诀之力，我已将这两种力量融为一体，功力更胜往昔！", "45886");
        giWait(1.0);
        giIMMBegin();
        giSetNpcVisible("MN002", true);
        giPlayerSetVisible(0, true);
        giCameraRunSingle("017", true);
        giIMMEnd();
        giCameraRunSingle("018", false);
        giPlayerDoAction(0, "J30", -1, false);
        giWait(0.3);
        giSetPortrait("101H", true);
        giTalk("云天河：那你还要什么呢？除了升仙……你说要给老掌门报仇，如今妖界变成这样，仇也报了！要是你还恨我爹娘，干脆把我也杀了算了！", "45887");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("216H", false);
        giTalk("玄霄：天河，你不要搞错了，我对报仇一点兴趣都没有，太清的死活与我何干！", "45888");
        giSetPortrait("101H", true);
        giTalk("云天河：……！", "45889");
        giSetPortrait("213C", false);
        giTalk("夙瑶：玄霄！你……！", "45890");
        giWait(0.3);
        giSetPortrait("216H", false);
        giTalk("玄霄：我想得很清楚了，以我今时之力，杀这些小妖根本是对我的污辱！琼华雪耻也是多此一举！", "45891");
        giWait(0.5);
        giSetPortrait("216H", false);
        giTalk("玄霄：只要取了紫晶石，不久即可白日飞升，为前人所不能为，做到历代掌门梦寐之事！这是我如今唯一要做的！", "45892");
        giSetPortrait("216I", false);
        giTalk("玄霄：哈哈、哈哈哈～", "45893");
        giWait(1.0);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：……大哥……我当初不该帮你……", "45894");
        giSetPortrait("216K", false);
        giTalk("玄霄：……而且，我虽然讨厌云天青，却不讨厌你。起初利用剑鸣引你们来禁地，只是想见见云天青和夙玉的后人，看一眼便是，却没想到你说要帮我……", "45895");
        giWait(0.5);
        giSetPortrait("216K", false);
        giTalk("玄霄：你为我破冰四处奔波，我们相处时日虽短，情份却如师徒如兄弟，世上我最感激的人便是你，又怎可能杀你？", "45896");
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "45897");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN002", 202.0);
        giCameraRunSingle("029", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("216K", true);
        giTalk("玄霄：如何？还是与我一同升仙吧？", "45898");
        giWait(0.3);
        giSetPortrait("213B", false);
        giTalk("夙瑶：玄霄，你莫太过份了，升仙乃是琼华派之事，云天河已被我逐出门派，于情于理都不可留下！", "45899");
        giWait(0.5);
        giSetPortrait("216G", true);
        giTalk("玄霄：……夙瑶，多年过去，你忌才之心，还是一点未变。", "45900");
        giSetPortrait("213B", false);
        giTalk("夙瑶：你！你胡说什么！", "45901");
        giSetPortrait("216G", true);
        giTalk("玄霄：哈哈，胡说吗？", "45902");
        giSetPortrait("216G", true);
        giTalk("玄霄：太清的弟子之中，以你资质最不出奇，到头来却阴差阳错做了掌门，你大权在握，难免患得患失，深恐哪一日便会被抢去手中一切，为此连长老都不愿晋升。", "45903");
        giSetPortrait("216J", true);
        giTalk("玄霄：以慕容紫英铸剑之才，数年来却也未得重用，凭他资质，应该早有所成，难道不是你心鬼做祟？你是担心他胜过你吗？哈哈、哈哈哈～", "45904");
        giNpcDoAction("MN002", "J04", 1, false);
        giSetPortrait("213B", false);
        giTalk("夙瑶：放肆！你竟如此羞辱一派掌门！", "45905");
        giNpcEndAction("MN002", true);
        giSetPortrait("216J", true);
        giTalk("玄霄：掌门？琼华一系被你经营成什么样子？！自身资质平平，又忌才妒能！你不妨看一看其他弟子，可还将你当作掌门？！", "45906");
        giWait(0.5);
        giCameraRunSingle("030", true);
        giCameraRunSingle("031", false);
        giNpcSetAng("MN002", 68.0);
        giWait(3.6);
        giSetPortrait("213C", true);
        giTalk("夙瑶：你们！你们！……", "45907");
        giWait(0.5);
        giSetPortrait("202D", false);
        giTalk("璇玑：掌门……", "45908");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN002", 202.0);
        giCameraRunSingle("033", true);
        giIMMEnd();
        giWait(0.5);
        giNpcSetEmotion("MN001", "216_lj");
        giSetPortrait("216I", true);
        giTalk("玄霄：强者为王，乃是天经地义，如今他们或臣服、或惧怕于我，又哪里还会听从你半句话！", "45909");
        giSetPortrait("213B", false);
        giTalk("夙瑶：…………", "45910");
        giWait(0.6);
        giSetPortrait("216H", true);
        giTalk("玄霄：我竟被你这无能之辈冰封十九年，实乃此生大耻……所以你最好闭嘴！不然休怪我对你不客气！", "45911");
        giSetPortrait("216H", true);
        giTalk("玄霄：望舒剑之事，我根本不屑与你合谋！你以为我不知吗？你在禁地门口对云天河他们说了不少多余的话！", "45912");
        giSetPortrait("213C", false);
        giTalk("夙瑶：你！……", "45913");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN001", 270.0);
        giCameraRunSingle("034", true);
        giIMMEnd();
        giWait(1.2);
        giIMMBegin();
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("Jeffect001", true);
        giIMMEnd();
        giWait(1.0);
        giSetPortrait("216G", false);
        giTalk("玄霄：天河，这便是你曾经想要的水灵珠，我如今把它取了出来，便送予你吧。", "45914");
        giWait(0.7);
        giSetPortrait("101E", true);
        giTalk("云天河：……水灵珠……你还记得？……", "45915");
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("216K", false);
        giTalk("玄霄：自然记得，你说过想找夙瑶要水灵珠，她却不允，你的事，大哥一定替你作主！", "45916");
        giWait(0.5);
        giCameraRunSingle("036", true);
        giPlayerSetVisible(0, false);
        giWait(0.5);
        giNpcDoAction("MN002", "C07", 1, false);
        giSetPortrait("213C", false);
        giTalk("夙瑶：不可！玄霄，你疯了？本派宝物岂容你如此糟蹋？！", "45917");
        giWait(0.3);
        giSetPortrait("216H", true);
        giTalk("玄霄：多话！给我滚！", "45918");
        giNpcSetEmotion("MN001", "216_zd");
        giIMMBegin();
        giNpcDoAction("MN001", "J02", 1, false);
        giNpcDoAction("MN002", "J01", -1, false);
        giIMMEnd();
        giWait(0.3);
        gi2DSoundPlay("WJ057", 1);
        giEffectPlayWithNPC("H_TM01_4", 1, "MN002");
        giWait(1.0);
        giNpcSetEmotion("MN001", "216_zc");
        giSetPortrait("213C", false);
        giTalk("夙瑶：啊……！", "45919");
        giWait(0.5);
        giNpcRunTo("MN004", -724.1, 24.3, 39.1, true);
        giNpcSetAng("MN004", 258.0);
        giNpcDoAction("MN004", "J04", -1, false);
        giSetPortrait("202E", true);
        giTalk("璇玑：掌门！", "45920");
        giSetPortrait("216H", true);
        giTalk("玄霄：夙瑶，昔日你将我冰封，令我日夜痛苦煎熬，时常想将你千刀万剐！", "45921");
        giNpcDoAction("MN001", "J01", 1, false);
        giSetPortrait("216H", true);
        giTalk("玄霄：如今我破冰而出，碍于情势，要与你共使双剑，但你最好识相，凡事只管点头去做，不然我连你都杀！", "45922");
        giSetPortrait("213C", false);
        giTalk("夙瑶：…………", "45923");
        giSetPortrait("216H", true);
        giTalk("玄霄：听、到、没、有！", "45924");
        giWait(1.0);
        giSetPortrait("213B", false);
        giTalk("夙瑶：……是……", "45925");
        giWait(0.5);
        giSetPortrait("216I", true);
        giTalk("玄霄：哈哈～～～哈哈哈～～～", "45926");
        giWait(0.5);
        giIMMBegin();
        giNpcDoAction("MN002", "C01", 0, false);
        giNpcDoAction("MN004", "C01", 0, false);
        giNpcSetAng("MN002", 247.0);
        giPlayerSetVisible(0, true);
        giCameraRunSingle("015", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("216G", true);
        giTalk("玄霄：天河，水灵珠你拿去吧。", "45927");
        giIMMBegin();
        giGOBMovment("MO002", 3.0, -849.9, 63.4, -39.5, true);
        giGOBMovment("Jeffect001", 3.0, -849.9, 55.4, -39.5, true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("MO002", false);
        giSetObjectVisible("Jeffect001", false);
        giIMMEnd();
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giAddProperty(3116, 1, true);
        giWait(2.0);
        giSetPortrait("101G", false);
        giTalk("云天河：…………", "45928");
        giSetPortrait("216G", true);
        giTalk("玄霄：你要用水灵珠救人，尽管去救！还需什么，尽量开口。待那些俗事了却之后，便与我一同飞升吧！", "45929");
        giCameraRunSingle("016", false);
        giWait(1.0);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：…………大哥，你知道吗？……当初我娘她……她最喜欢的人其实是你啊……", "45930");
        giPlayerEndAction(0);
        giSetPortrait("216G", true);
        giTalk("玄霄：…………是吗？", "45931");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：真的！是爹亲口告诉我的！我去鬼界见了爹的魂魄，他还一直在等你，他说害得你这么惨，他一定要当面跟你说对不起，才去投胎……", "45932");
        giPlayerEndAction(0);
        giSetPortrait("216G", true);
        giTalk("玄霄：那云天青定是要等上千年万年了！要知我成仙之后，寿命岂止短短数十载！", "45933");
        giSetPortrait("101H", false);
        giTalk("云天河：大哥！", "45934");
        giWait(0.5);
        giSetPortrait("216G", true);
        giTalk("玄霄：……罢了，过往之事，何必再提。", "45935");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：不对！那天在禁地里，你明明说过的，你说很后悔伤了一个人的心，可是那个人已经死了，你再也没有机会说对不起，那个人……就是我娘吧？！", "45936");
        giNpcDoAction("MN001", "J01", 1, false);
        giSetPortrait("216H", true);
        giTalk("玄霄：云天河！你烦是不烦！", "45937");
        giSetPortrait("216H", true);
        giTalk("玄霄：我邀你一同飞升成仙，你却尽是提些前尘旧事，令人不快！", "45938");
        giSetPortrait("101H", false);
        giTalk("云天河：……大哥……", "45939");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P27", 2, 2.5, 2.5);
        giWait(1.0);
        giIMMBegin();
        giSetNpcVisible("MN002", false);
        giCameraRunSingle("037", true);
        giIMMEnd();
        giCameraRunSingle("038", false);
        giWait(1.1);
        giPlayerDoAction(0, "C09", 1, false);
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：……这是我最后一次喊你大哥了……", "45940");
        giSetPortrait("216H", false);
        giTalk("玄霄：你？！", "45941");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：你说你控制了羲和剑的力量，我却觉得，你这个样子，好像爹说过的心魔深种，已经完全不是你了……", "45942");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：你我从此再无关系！你把望舒剑给我，我不能让你再害菱纱！", "45943");
        giSetPortrait("216H", false);
        giTalk("玄霄：你说什么？！", "45944");
        giSetPortrait("101J", true);
        giTalk("云天河：你做的不对，我不要你当我大哥了！ 把望舒剑还来，我不想借你！就这么简单！", "45945");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("216H", false);
        giTalk("玄霄：你！！", "45946");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, -885.2, 13.0, -30.2);
        giPlayerSetPos(3, -956.2, 13.0, 24.2);
        giPlayerSetAng(3, 110.0);
        giCameraRunSingle("039", true);
        giIMMEnd();
        giIMMBegin();
        giSetObjectVisible("Jeffect005", false);
        giSetObjectVisible("Jeffect006", true);
        giIMMEnd();
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：天河！快快退后！那阳炎会将人焚成灰烬！！", "45947");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giCameraRunSingle("041", false);
        giWait(5.0);
        giSetPortrait("101J", false);
        giTalk("云天河：……", "45948");
        giWait(1.0);
        giSetPortrait("216H", true);
        giTalk("玄霄：…………", "45949");
        giCameraWait();
        giIMMBegin();
        giSetObjectVisible("Jeffect005", true);
        giSetObjectVisible("Jeffect006", false);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("216I", true);
        giTalk("玄霄：哈哈哈！好、好！", "45950");
        giWait(0.8);
        giSetPortrait("216H", true);
        giTalk("玄霄：云天河，你三番两次顶撞，我本不该姑息！", "45951");
        giSetPortrait("216G", true);
        giTalk("玄霄：只是我还记得在禁地说过的那些话，你助我良多，玄霄永志难忘。", "45952");
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN015", true);
        giPlayerSetVisible(3, false);
        giCameraRunSingle("040", true);
        giIMMEnd();
        giWait(1.0);
        giNpcDoAction("MN015", "J03", 1, false);
        giWait(2.0);
        giSetObjectVisible("Jeffect002", true);
        gi2DSoundPlay("WJ083", 1);
        giWait(4.0);
        giSetObjectVisible("Jeffect010", false);
        giNpcEndAction("MN015", true);
        giIMMBegin();
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN015", false);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MN002", true);
        giNpcSetAng("MN002", 262.0);
        giNpcSetPos("MN004", -759.4, 28.4, 96.5);
        giNpcSetAng("MN004", 258.0);
        giPlayerSetPos(3, -998.2, 12.8, 42.6);
        giPlayerSetAng(3, 110.0);
        giCameraRunSingle("042", true);
        giIMMEnd();
        giWait(0.6);
        giSetPortrait("216G", true);
        giTalk("玄霄：紫晶石既已足够，我就再让你一次，也是最后一次！现在妖界束缚已除，妖界之主的命也送给你吧！", "45953");
        giWait(0.5);
        giSetPortrait("216G", true);
        giTalk("玄霄：你不愿修仙，爱去哪里便去哪里！只是要将望舒剑归还，却是万万不能！", "45954");
        giEffectPlayWithPlayer("H_097", 1, 2);
        giPlayerBlendIn(2, 2.0, false);
        giWait(1.0);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：束缚除去，妖界入口马上就要消失了！", "45955");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(3, -1085.5, 12.8, 36.4);
        giPlayerSetAng(3, 88.0);
        giPlayerSetPos(2, -1088.7, 10.4, -5.0);
        giPlayerSetAng(2, 72.0);
        giPlayerSetPos(1, -1078.2, 9.5, -61.3);
        giPlayerSetAng(1, 118.0);
        giPlayerSetPos(0, -1078.9, 4.1, -35.5);
        giPlayerSetAng(0, 62.0);
        giSetNpcVisible("MN002", false);
        giCameraRunSingle("044", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "Z12", 0, false);
        giNpcDoAction("MN004", "J05", -1, false);
        giSetPortrait("202E", false);
        giTalk("璇玑：师叔！紫英师叔！你快点过来啊！", "45956");
        giNpcUnHoldAct("MN004");
        giNpcEndAction("MN004", true);
        giCameraRunSingle("045", true);
        giWait(1.0);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：……璇玑，你可知道……怀朔他已经死了，就是被你说的那些同门杀了！", "45957");
        giWait(0.5);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：我不会再回琼华派！", "45958");
        giWait(0.5);
        giSetPortrait("202E", false);
        giTalk("璇玑：师、叔……你、说什么？能不能再说一遍？！师叔——！", "45959");
        giWait(0.7);
        giPlayerDoAction(3, "C09", 1, true);
        giWait(0.5);
        giPlayerWalkTo(3, -1416.6, 138.4, 34.9, false);
        giCameraRunSingle("048", false);
        giFlashOutBlack(2.0, true, true);
        giSetObjectVisible("Jeffect002", false);
        giSetObjectVisible("Jeffect003", false);
        giSetObjectVisible("Jeffect005", false);
        giSetObjectVisible("Jeffect004", false);
        giSetObjectVisible("Jeffect007", false);
        giScriptMusicPause();
        giPlayMovie("14S.bik");
        giOpenMovieFlag(9);
        global_mvar = 150100; // 0x00024A54, 噩梦纷争
        giScriptMusicResume();
        giArenaLoad("Q14", "BN06", "", true);
    }
}

void func2030()
{
    if (global_mvar == 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giPlayerSetPos(0, -824.0, 16.5, -34.0);
        giPlayerSetAng(0, 266.0);
        giPlayerSetPos(1, -805.0, 20.5, 10.9);
        giPlayerSetAng(1, 270.0);
        giPlayerSetPos(3, -871.9, 20.5, 45.9);
        giPlayerSetAng(3, 252.0);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：奇怪……为何妖风散去了不少，入口所散发出来的妖力似乎比之前要弱……", "45384");
        giSetPortrait("101C", true);
        giTalk("云天河：对啊，没有像上回一样，冲出很多道光……", "45385");
        giWait(0.5);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：不管了，反正先冲进去再说！", "45386");
        giPlayerEndAction(0);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：…………", "445387");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 314.0);
        giPlayerSetAng(1, 292.0);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giWait(0.7);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……紫英，一路上我都忍住不问……可现在已经在妖界入口了，你……是不是仍然没办法放开梦璃是妖的事……", "45388");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……我……不知道。", "45389");
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：或许在真正见到梦璃之前，我都无法想像，也不知要如何面对她……", "45390");
        giSetPortrait("101A", true);
        giTalk("云天河：……", "45391");
        giCameraRunSingle("003", false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我十几年来在此修行，我的师弟、师妹、师侄，还有所有的长辈，都在这里……", "45392");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：若是琼华派和妖界兵刃相向，我绝不会坐看本派弟子死伤……", "45393");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：何况……彼此之间早已结下血海深仇，我们此去妖界，恐怕亦是凶多吉少……", "45394");
        giWait(0.5);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：为什么一定要打？不能让妖界离开吗？！", "45395");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(3, 154.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giCameraRunSingle("005", false);
        giSetPortrait("101H", false);
        giTalk("云天河：我虽然不像紫英你，有很多师兄、师弟，但也不想看你和菱纱、还有怀朔、璇玑出什么事啊！", "45396");
        giSetPortrait("101H", false);
        giTalk("云天河：爹说过，只要不再用双剑网住妖界，妖界就会离开了！ ", "45397");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……羲和、望舒双剑此刻正在掌门和玄霄师叔手中，要让他们罢手，谈何容易？", "45398");
        giSetPortrait("101H", false);
        giTalk("云天河：不试试怎么知道，也许会有办法的。", "45399");
        giSetPortrait("101H", false);
        giTalk("云天河：见了梦璃以后，我一定要问问她，如果有办法让妖界离开，是不是就不用杀来杀去了！", "45400");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 134.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giCameraRunSingle("007", false);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：我觉得，天河的想法也不是没有道理。", "45401");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：进去<colour red=255 green=187 blue=0 alpha=255>妖界</colour><dc0>之后，我们见机行事吧，要是见了梦璃，能找到其他法子化解这场争斗，就再好不过了。</dc0>", "45402");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……", "45403");
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：什么都别想，越想越怕，倒不如<colour red=255 green=187 blue=0 alpha=255>用翳影枝一口气冲进去</colour><dc0>，发生什么事就再说了！</dc0>", "45404");
        giPlayerSetDir(0, 268.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：对，拼了！", "47006");
        giFlashOutBlack(1.5, true, true);
        giPlayerEndAction(0);
        giCameraRunSingle("001", true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-906.8, 12.8, 7.2);
        giPlayerCurrentSetAng(264.0);
        giSetObjectVisible("entrance2", true);
        giIMMEnd();
        giCameraSetMode(0, true);
        global_mvar = 140101; // 0x00022345, 第三章 / 8-3-4.心愿 / 前往妖界
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2031()
{
    if (global_mvar == 140101 /* 第三章 / 8-3-4.心愿 / 前往妖界 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(0, -1710.2, 185.1, -1.9);
        giPlayerSetAng(0, 269.0);
        giIMMEnd();
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giWait(0.6);
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.6);
        giSetObjectVisible("MO002", true);
        giWait(0.6);
        giSetObjectVisible("Jeffect002", true);
        giWait(1.0);
        giSetObjectVisible("Jeffect002", false);
        giSetObjectVisible("MO002", false);
        giWait(0.9);
        giDelProperty(3114, 3, false);
        giFlashOutWhite(1.5, true, true);
        giArenaLoad("Q14", "Q14W", "", true);
    }
}

void func2098()
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

void func2099()
{
    if (global_mvar == 71900 /* 第二章 / 5-1-3.寒剑夜鸣 / 进入山洞 */)
    {
        func2010();
    }
    if (global_mvar == 80700 /* 第二章 / 5-2-3.心事难明 / 再去禁地 */)
    {
        func2014();
    }
    if (global_mvar != 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        func3001();
    }
    else
    {
        func2017();
    }
    if (global_mvar == 120200 /* 第三章 / 7-2-4.相争难休 / 单独去禁地 */)
    {
        func2022();
    }
}

void func2101()
{
    if (global_mvar == 61300 /* 第二章 / 4-3-1.御剑逍遥 / 去弟子房休息 / 初入琼华 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 6384.7, -1382.8, -3585.9, true);
        giPlayerSetDir(0, 183.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101C", true);
        giTalk("云天河：师叔让我们<colour red=255 green=187 blue=0 alpha=255>去前山的弟子房休息</colour><dc0>，好像不是这边……</dc0>", "");
        giPlayerUnLock();
    }
}

void func2102()
{
    int select_dialog_last_select = 0;

    if (global_mvar == 60901 /* 第二章 / 4-1-5.寻仙昆仑 / 入门考验 */)
    {
        giPlayerLock();
        giSelectDialogAddItem("1.是");
        giSelectDialogAddItem("2.否");
        giSelectDialogSetDefaultSelect(1);
        giShowSelectDialog("　准备好要<colour red=221 green=27 blue=0 alpha=255>接受入门试炼</colour><dc0>了吗？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            giPlayerUnLock();
        }
        else
        {
            func2002();
        }
    }
}

void func2103()
{
    giPlayerLock();
    giPlayerFaceToNpc(0, "4001", true);
    giNpcFaceToPlayer("4001", 0, true);
    giTalk("怀守：没有掌门的命令，入夜以后，任何弟子不得下山！", "");
    giPlayerWalkTo(0, 12453.2, -1831.3, -14419.7, true);
    giPlayerSetDir(0, 0.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giNpcResetDir("4001");
    giPlayerUnLock();
}

void func2104()
{
    giPlayerLock();
    giPlayerSetLeader(0);
    giPlayerWalkTo(0, 19951.5, -1085.3, -1759.9, true);
    giPlayerSetDir(0, 146.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giSetPortrait("102A", true);
    giTalk("云天河：没什么事要去那边啊……", "");
    giPlayerUnLock();
}

void func2105()
{
    giPlayerLock();
    giPlayerSetLeader(0);
    giPlayerWalkTo(0, 4535.3, -1383.2, -6232.9, true);
    giPlayerSetDir(0, 91.0, true);
    giCameraAutoSeek(true);
    giCameraSetMode(0, true);
    giSetPortrait("102A", true);
    giTalk("云天河：没什么事要去那边啊……", "");
    giPlayerUnLock();
}

void func3001()
{
    if (global_mvar < 91400 || global_mvar > 101400 || npc_d != 0 /* 第二章 / 6-3-2.义结金兰 / 离开禁地 / 结拜兄弟 */)
    {
        if (global_mvar <= 101400 && global_mvar >= 91400 && npc_d != 0 && npc_d == 2 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
        {
            giPlayerLock();
            giScriptMusicPlay("P27", 2, 0.0, 0.0);
            giFlashOutBlack(1.5, true, true);
            giIMMBegin();
            giCameraSetCollide(false);
            giCameraAutoSeek(false);
            giPlayerCurrentSetVisible(false);
            giPlayerSetPos(0, 1296.3, 131.0, 726.9);
            giPlayerSetAng(0, 34.0);
            giPlayerSetVisible(0, true);
            giIMMEnd();
            giCameraPrepare("feng3");
            giCameraRunSingle("001", true);
            giFlashInBlack(1.5, false);
            giCameraRunSingle("002", false);
            giWait(1.5);
            giPlayerDoAction(0, "C07", -1, false);
            giSetPortrait("102K", false);
            giTalk("云天河：大哥，你看～你要的凤凰花我摘来了！", "");
            giWait(0.5);
            giIMMBegin();
            giSetObjectVisible("feng01", true);
            giSetObjectVisible("feng-01", true);
            giIMMEnd();
            giPlayerUnHoldAct(0);
            giPlayerEndAction(0);
            giWait(0.2);
            giPlayerDoAction(0, "J14", 1, false);
            giSetPortrait("102B", false);
            giTalk("云天河：……唔，这么说也不对，应该是有人送给我了……", "");
            giDelProperty(3243, 1, false);
            giPlayerEndAction(0);
            giIMMBegin();
            giGOBMovment("feng01", 4.0, 1315.6, 240.8, 735.1, false);
            giGOBMovment("feng-01", 4.0, 1316.3, 225.7, 734.0, false);
            giIMMEnd();
            giWait(2.0);
            giCameraRunSingle("003", false);
            giTalk("玄霄：……凤凰花开，依旧如霞似锦……可惜夙玉却再也看不到了……", "");
            giWait(1.0);
            giSetPortrait("102B", false);
            giTalk("云天河：我娘？她喜欢这花吗？", "");
            giWait(0.7);
            giTalk("玄霄：是啊，闲暇之时她最爱赏花……只是……人会老去、花会衰败，但花开罢一季又一季，人却再也不会归来……", "");
            giWait(1.0);
            giTalk("玄霄：…………你且出去吧，让大哥一个人静一静。", "");
            giWait(0.5);
            giSetPortrait("102A", false);
            giTalk("云天河：大哥……", "");
            giTalk("玄霄：去吧，莫要扰我。", "");
            giPlayerDoAction(0, "J14", 1, false);
            giSetPortrait("102A", false);
            giTalk("云天河：好，那我走了，等找齐所有寒器，我再来找大哥。", "");
            giPlayerEndAction(0);
            giWait(0.3);
            giPlayerWalkTo(0, 1215.0, 131.0, 589.6, false);
            giWait(1.5);
            giCameraRunSingle("006", true);
            giCameraRunSingle("004", true);
            giCameraRunSingle("005", false);
            giWait(1.0);
            giTalk("玄霄：……杳杳灵凤，绵绵长归。悠悠我思，永与愿违。万劫无期，何时来飞？", "");
            giWait(0.7);
            giTalk("玄霄：夙玉，如今你一缕魂魄又在何处？要是早知今日之境，你悔也不悔？……", "");
            giWait(0.6);
            giCameraRunSingle("007", true);
            giWait(0.5);
            giIMMBegin();
            giSetObjectVisible("feng-02", true);
            giSetObjectVisible("feng-01", false);
            giIMMEnd();
            giWait(0.5);
            giCameraRunSingle("008", false);
            giOBJBlendOut("feng01", 0.2, false);
            giSetObjectVisible("feng-02", false);
            giWait(0.2);
            giFlashOutBlack(1.5, true, true);
            npc_d = 3;
            giArenaLoad("Q06", "Q06Q", "", true);
            giPlayerCurrentSetPos(15184.6, 128.2, -3331.9);
            giPlayerCurrentSetAng(160.0);
            giCameraSetMode(0, true);
            giArenaReady();
            giScriptMusicStop(1, 2.5);
            giPlayerUnLock();
            giFlashInBlack(1.5, true);
        }
    }
    else
    {
        giPlayerLock();
        giScriptMusicPlay("P27", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 1215.0, 131.0, 589.6);
        giPlayerSetAng(0, 34.0);
        giPlayerSetVisible(0, true);
        giIMMEnd();
        giCameraPrepare("feng1");
        giCameraRunSingle("003", true);
        giPlayerWalkTo(0, 1311.7, 131.0, 758.9, false);
        giCameraRunSingle("004", false);
        giFlashInBlack(1.5, true);
        giPlayerEndMove(0);
        giPlayerSetAng(0, 36.0);
        giTalk("玄霄：……天河，是你？不是交代过暂时不必来禁地吗？", "");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：大哥……我、我老觉得放心不下……", "");
        giPlayerEndAction(0);
        giTalk("玄霄：有何放心不下？是担心寻找三寒器之事？", "");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：不是啊……大哥，你在这里待了这么久，不会觉得闷吗？都没人和你说话……", "");
        giPlayerEndAction(0);
        giWait(0.5);
        giCameraRunSingle("001", true);
        giCameraRunSingle("002", false);
        giWait(0.5);
        giTalk("玄霄：原来……你是担心我百无聊赖，想要陪我讲话……", "");
        giWait(1.0);
        giTalk("玄霄：你这份心，大哥领受了……我长年被冰封于此，早已习惯这种寂寥，若是不能做到心如止水，只怕已经……", "");
        giWait(1.0);
        giTalk("玄霄：……只怕已经疯了……", "");
        giWait(1.0);
        giCameraRunSingle("007", true);
        giCameraRunSingle("008", false);
        giWait(0.5);
        giSetPortrait("102A", false);
        giTalk("云天河：大哥，我一定快点找齐那三样东西，让你从冰里出来。", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：不过在那以前，你要是还有其他事想交代我去做，都可以跟我讲～ ", "");
        giPlayerEndAction(0);
        giTalk("玄霄：…………我如今的心愿唯有破冰而出、屠灭妖界，一雪昔日之耻，除此以外再无其他。", "");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：紫英说要和妖界打，大哥你也要和妖界打，真的打起来，我一定帮你们。", "");
        giTalk("玄霄：……你且去吧。洞中阴寒，即便你不畏寒气，待得久了，也无益处。", "");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：哦，好……", "41181; 44881; 46377");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giCameraRunSingle("006", false);
        giWait(0.5);
        giPlayerWalkTo(0, 1296.3, 131.0, 726.9, false);
        giWait(0.5);
        giTalk("玄霄：……天河。", "");
        giPlayerEndMove(0);
        giPlayerSetDir(0, 36.0, true);
        giWait(0.3);
        giSetPortrait("102A", true);
        giTalk("云天河：大哥，怎么了？", "");
        giTalk("玄霄：你去了长老隐居的清风涧，定然经过<colour red=255 green=187 blue=0 alpha=255>醉花荫</colour><dc0>，那里的</dc0><colour red=255 green=187 blue=0 alpha=255>凤凰花</colour><dc0>……可都还在吗？</dc0>", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：凤凰花？我不知道是哪一种，那里到处都是红红的花……", "");
        giPlayerEndAction(0);
        giTalk("玄霄：……你若是愿意，便<colour red=255 green=187 blue=0 alpha=255>去后山摘些凤凰花来</colour><dc0>，许多年未见了，我有些怀念……</dc0>", "");
        giSetPortrait("102B", true);
        giTalk("云天河：呵呵，这好办，我现在就去！大哥你等我。", "");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("005", true);
        giIMMBegin();
        npc_d = 1;
        giPlayerSetPos(0, 1077.0, 67.0, 359.0);
        giPlayerSetAng(0, 200.0);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giIMMEnd();
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func3002()
{
    if (global_mvar == 80600 && npc_b == 0 /* 第二章 / 5-2-2.心事难明 / 再去禁地 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P23", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 13348.0, -1088.2, -5201.8);
        giPlayerSetAng(0, 190.0);
        giPlayerSetVisible(0, true);
        giIMMEnd();
        giCameraPrepare("xia001");
        giCameraRunSingle("001", true);
        giNpcDoAction("SN001", "J04", -1, false);
        giWait(0.8);
        giFlashInBlack(1.5, true);
        giWait(1.0);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giSetPortrait("102K", false);
        giTalk("云天河：哈哈～怀朔，你在做什么？有好玩的？", "");
        giSetPortrait("203C", true);
        giTalk("怀朔：啊，逃了……", "");
        giSetPortrait("102B", false);
        giTalk("云天河：怀朔。", "");
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giCameraRunSingle("003", true);
        giNpcSetDir("SN001", 18.0, true);
        giCameraRunSingle("004", false);
        giPlayerWalkTo(0, 13348.7, -1088.2, -5315.7, true);
        giPlayerSetAng(0, 202.0);
        giSetPortrait("102B", false);
        giTalk("云天河：什么东西逃了？怎么你脸上都是汗？", "");
        giCameraWait();
        giSetPortrait("203D", true);
        giTalk("怀朔：我……我要捉的虫子，被你惊跑了……", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：虫子？什么样的？", "");
        giWait(0.6);
        giNpcDoAction("SN001", "C07", -1, false);
        giWait(2.0);
        giSetObjectVisible("Jeffect001", true);
        giSetPortrait("203D", true);
        giTalk("怀朔：就是这个，我守了一个时辰，也才捉到一只……", "");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.5);
        giSetPortrait("102C", true);
        giTalk("云天河：这虫子这么瘦，身上没肉，会好吃吗？", "");
        giSetPortrait("203C", false);
        giTalk("怀朔：吃？……不不不，你误会了，我不是要捉来吃。", "");
        giSetObjectVisible("Jeffect001", false);
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giSetPortrait("203C", false);
        giTalk("怀朔：这虫子叫“夏鸣”，只有在琼华派中才有，山下是见不到的，近几日璇玑忽然说它们的叫声好听，让我捉几只给她，她要送给紫英师叔。", "");
        giSetPortrait("102A", true);
        giTalk("云天河：师叔？他要这东西干嘛？", "");
        giNpcDoAction("SN001", "C09", 1, false);
        giSetPortrait("203C", false);
        giTalk("怀朔：师叔要不要倒没什么，但若是不理璇玑，她一定会每日缠着我，不肯罢休……", "");
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：呵呵，那我来帮你，我最擅长捉虫了～", "");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("203A", false);
        giTalk("怀朔：不如你将其中诀窍传授我一些，我再试试……刚才想用仙术把虫子定住，却是一碰就死了……", "");
        giWait(0.5);
        giCameraRunSingle("006", false);
        giSetPortrait("102B", true);
        giTalk("云天河：你从小到大都没捉过虫子玩吗？", "");
        giNpcDoAction("SN001", "C09", 1, false);
        giSetPortrait("203A", false);
        giTalk("怀朔：……惭愧，我幼时在家乡，爹是个私塾先生，管教得甚严，是不许我和其他小孩一起玩闹的。", "");
        giSetPortrait("102D", true);
        giTalk("云天河：什么？不能出去玩？！这样说起来，你爹比我爹还厉害，你真可怜……", "");
        giWait(0.5);
        giSetPortrait("203C", false);
        giTalk("怀朔：你莫要误会……", "");
        giSetPortrait("102B", true);
        giTalk("云天河：来吧！我帮你，捉虫子不能像你那样。你等一下，我做个虫笼先～", "");
        giFlashOutBlack(1.5, true, true);
        giCameraWait();
        giWait(1.2);
        giFlashInBlack(1.5, true);
        giSetPortrait("102K", true);
        giTalk("云天河：好了！", "");
        giWait(0.4);
        giCameraRunSingle("007", false);
        giPlayerWalkTo(0, 13393.8, -1088.2, -5365.5, true);
        giPlayerSetAng(0, 156.0);
        giPlayerDoAction(0, "J03", -1, true);
        giSetObjectVisible("SO001", true);
        giNpcWalkTo("SN001", 13367.6, -1088.2, -5414.9, true);
        giNpcSetDir("SN001", 80.0, true);
        giNpcDoAction("SN001", "J04", -1, false);
        giCameraRunSingle("008", true);
        giCameraRunSingle("009", true);
        giSetObjectVisible("Jeffect003", true);
        giWait(0.3);
        giSetObjectVisible("Jeffect004", true);
        giWait(0.3);
        giSetObjectVisible("Jeffect005", true);
        giGOBMovment("Jeffect003", 3.5, 13385.2, -1136.2, -5400.6, false);
        giGOBMovment("Jeffect004", 4.0, 13385.2, -1136.2, -5400.6, false);
        giGOBMovment("Jeffect005", 4.5, 13385.2, -1136.2, -5400.6, true);
        giWait(2.0);
        giSetPortrait("203C", false);
        giTalk("怀朔：这！……夏鸣虫为何会自己往里飞？！", "");
        giSetPortrait("102B", true);
        giTalk("云天河：呵呵～我在笼子里放了干花粉，以前在青鸾峰时，我也常常拿这个引虫子，看来对琼华派的虫子一样行啊～", "");
        giWait(0.8);
        giIMMBegin();
        giSetObjectVisible("Jeffect003", false);
        giSetObjectVisible("Jeffect004", false);
        giSetObjectVisible("Jeffect005", false);
        giIMMEnd();
        giWait(0.4);
        giSetObjectVisible("SO001", false);
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giNpcSetDir("SN001", 38.0, true);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 194.0, true);
        giWait(0.5);
        giSetPortrait("102B", true);
        giTalk("云天河：一、二、三……一共三只，加上你捉到的，就是四只，够了吗？", "");
        giNpcDoAction("SN001", "C08", 1, false);
        giSetPortrait("203B", false);
        giTalk("怀朔：够了、够了，真想不到捉虫也是一门学问。", "");
        giSetPortrait("102K", true);
        giTalk("云天河：不够的话再来找我，我还帮你捉！其实还有其他很多办法的～", "");
        giNpcDoAction("SN001", "J01", 1, false);
        giSetPortrait("203B", false);
        giTalk("怀朔：多谢，没有你帮忙的话，我还不知要在这里凝神闭气守上多久……", "");
        giNpcEndAction("SN001", true);
        giSetPortrait("203B", false);
        giTalk("怀朔：我先回房去了，本门禁止入夜后喧哗、随意出外，我……我是趁房里其他人都睡着了，才出来的。", "");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：哦～这里规矩就是多，你放心，你偷跑出来的事我不告诉别人～", "");
        giWait(0.5);
        giSetPortrait("203B", false);
        giTalk("怀朔：咳咳……你也早点回房吧，我知道你玩心重，耐不住性子，不过今日才被师叔罚去思过，还是莫要再犯错了。", "");
        giWait(0.8);
        giNpcWalkTo("SN001", 13295.6, -1088.2, -5214.8, false);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, true);
        giFlashOutBlack(1.5, true, true);
        npc_b = 1;
        giSetNpcVisible("SN001", false);
        giPlayerSetVisible(0, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(13393.8, -1088.2, -5365.5);
        giPlayerCurrentSetAng(194.0);
        giCameraSetMode(0, true);
        giScriptMusicStop(0, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func3003()
{
    if (global_mvar < 101400 && npc_b == 1 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giPlayerLock();
        giSetObjectVisible("Jsound050", false);
        giScriptMusicPlay("P23", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 7789.4, -1387.9, -7879.1);
        giPlayerSetAng(0, 202.0);
        giPlayerSetVisible(0, true);
        giNpcSetPos("SN003", 7541.0, -1387.9, -8008.0);
        giNpcSetAng("SN003", 106.0);
        giSetObjectVisible("title04", false);
        giSetNpcVisible("4017", false);
        giSetNpcVisible("4049", false);
        giIMMEnd();
        giCameraPrepare("xia001");
        giCameraRunSingle("001", true);
        gi2DSoundPlay("WB017", 1);
        giFlashInBlack(1.5, true);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：怀朔师兄，想不到你颇有闲情，养了这些叫声好听的虫子～", "");
        giSetPortrait("203B", true);
        giTalk("怀朔：哪里……我本想将它们放了，但自己又有些喜欢，想留下多养几日，正在犹豫，倒让你见笑了。", "");
        gi2DSoundPlay("WB017", 1);
        giPlayerWalkTo(0, 7725.1, -1387.9, -8000.7, true);
        giPlayerSetAng(0, 218.0);
        giSetPortrait("102B", false);
        giTalk("云天河：这叫声……不是上回夜里捉的那些夏鸣虫吗？你还没给璇玑啊？", "");
        giWait(0.5);
        giNpcSetDir("SN001", 38.0, true);
        giWait(0.3);
        giNpcDoAction("SN001", "C09", 1, false);
        giSetPortrait("203B", true);
        giTalk("怀朔：璇玑不知又从哪里听说，紫英师叔不喜这些小东西，所以她不要了。", "");
        giNpcEndAction("SN001", true);
        giNpcDoAction("SN001", "C07", -1, false);
        giTalk("怀朔：对了，天河，上次你帮我捉虫，还没有谢谢你，恰好昨日从虚合师叔处得来一些养神的灵药，就送给你吧。", "");
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giWait(0.5);
        giAddProperty(3009, 5, true);
        giWait(1.8);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：给我？呵呵，谢谢！", "");
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("202D", true);
        giTalk("璇玑：师兄，原来你在这儿，我找你好久了！", "");
        giSetNpcVisible("SN003", true);
        giNpcWalkTo("SN003", 7636.7, -1387.9, -8055.6, false);
        giWait(1.0);
        giNpcSetDir("SN001", 300.0, false);
        giNpcSetDir("SN002", 280.0, false);
        giPlayerSetDir(0, 250.0, false);
        giNpcEndMove("SN003");
        giIMMBegin();
        giNpcSetAng("SN003", 108.0);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giWait(0.3);
        giSetPortrait("203B", false);
        giTalk("怀朔：什么找好久，刚才可是你让我离开，你不是说要静心练剑，不许别人打扰吗？", "");
        giSetPortrait("202D", true);
        giTalk("璇玑：那人家现在练完了，来找你不行吗？", "");
        giSetPortrait("203B", false);
        giTalk("怀朔：行行行，怎样都是你说了算。", "");
        giWait(0.3);
        giSetPortrait("202A", true);
        giTalk("璇玑：嘻嘻，那师兄你陪我去承天剑台，听说虚冶师伯那儿新出炉了几柄宝剑，我要去挑一把！我的紫灵剑在上回除妖时，被那只厉害的蜈蚣精毁了，如今用的这把一点都不称手……", "");
        giSetPortrait("203B", false);
        giTalk("怀朔：虚冶师伯？可你之前不是说要请紫英师叔替你铸剑——", "");
        giNpcDoAction("SN003", "J01", 1, false);
        giSetPortrait("202C", true);
        giTalk("璇玑：师兄你故意气我是不是？！你明知道我求师叔铸剑也不止一年半载了，可他一直都不理我，你还偏要提这个……", "");
        giNpcEndAction("SN003", true);
        giNpcDoAction("SN001", "C09", 1, false);
        giSetPortrait("203B", false);
        giTalk("怀朔：好吧、好吧，都是我不对，师兄给你陪礼了，我们这就去承天剑台吧。", "");
        giNpcEndAction("SN001", true);
        giSetPortrait("202C", true);
        giTalk("璇玑：嗯，这还差不多～～～", "");
        gi2DSoundPlay("WB017", 1);
        giWait(0.8);
        giSetPortrait("202D", true);
        giTalk("璇玑：这些虫子师兄你怎么还没扔掉啊？叫个不停，听了就心烦。", "");
        giWait(0.3);
        giSetPortrait("203B", false);
        giTalk("怀朔：会吗？我觉得这声音还挺好听的，不如我先回房一趟，把虫笼放下，再去承天剑台找你。", "");
        giSetPortrait("202A", true);
        giTalk("璇玑：怎样都好啦，那你等会儿一定要来～", "");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("SN003", 94.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giSetPortrait("202A", true);
        giTalk("璇玑：天河、梦璃，今天我和师兄有事，不能陪你们了～", "");
        giPlayerDoAction(0, "C08", 1, true);
        giNpcRunTo("SN003", 7541.0, -1387.9, -8008.0, true);
        giSetNpcVisible("SN003", false);
        giNpcSetDir("SN001", 66.0, true);
        giCameraRunSingle("004", false);
        giNpcDoAction("SN001", "J01", -1, false);
        giSetPortrait("203B", true);
        giTalk("怀朔：抱歉……先告辞了。", "");
        giNpcUnHoldAct("SN001");
        giNpcEndAction("SN001", true);
        giNpcDoAction("SN002", "J07", 1, true);
        giWait(0.5);
        giNpcSetDir("SN001", 308.0, true);
        giWait(0.5);
        giNpcDoAction("SN001", "C09", 1, false);
        giSetPortrait("203A", false);
        giTalk("怀朔：唉，小师妹这横冲直撞的性子，什么时候才能改一改啊……", "");
        giNpcEndAction("SN001", true);
        giNpcWalkTo("SN001", 7581.7, -1383.6, -7884.7, false);
        giWait(1.5);
        giPlayerSetDir(0, 314.0, false);
        giNpcSetDir("SN002", 324.0, false);
        giNpcEndMove("SN001");
        giSetNpcVisible("SN001", false);
        giCameraRunSingle("005", true);
        giNpcDoAction("SN002", "J13", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：怀朔对璇玑真好，处处替她着想、顺她心意，想来亲兄长也不过如此了吧。", "");
        giWait(0.5);
        giSetPortrait("102A", false);
        giTalk("云天河：…………", "40120; 40328; 41095; 41282; 41413; 41449; 41494; 41759; 42155; 42164; 42425; 42728; 43233; 44244; 44326; 44347; 44623; 44642; 44661; 44834; 44838; 44921; 44966; 45198; 45224; 45230; 45272; 45274; 45353; 45356; 45358; 45360; 45827; 45897; 45928; 45982; 45986; 46003; 46010; 46016; 46220; 46407; 46505; 46507; 46538; 46776; 46778; 46868");
        giNpcSetDir("SN002", 338.0, true);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：云公子，你怎么了？一直都不说话。", "");
        giWait(0.5);
        giPlayerSetDir(0, 154.0, true);
        giCameraRunSingle("006", false);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.4);
        giSetPortrait("102A", false);
        giTalk("云天河：我……我觉得怀朔好了不起，天天和璇玑待在一起，都不会头晕……为什么女孩子的主意总是变来变去？认定一个不就好了？", "");
        giWait(0.5);
        giNpcDoAction("SN002", "J14", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：云公子，女孩子会时常改变主意，多半是有了喜欢的人，想要在那个人面前表现出最好的一面，才会患得患失、反反复复。", "");
        giNpcEndAction("SN002", true);
        giSetPortrait("102E", false);
        giTalk("云天河：……我知道，你说的“喜欢”，又是我不明白的那种，是不是因为我念的书太少？", "");
        giWait(0.3);
        giNpcDoAction("SN002", "C09", 1, false);
        giWait(0.5);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：云公子，我觉得你这样坦坦荡荡的就很好了，不用强迫自己去改变什么。", "");
        giSetPortrait("107B", true);
        giTalk("柳梦璃：“情”之一物，原本就是世上最难解的东西，譬如怀朔对璇玑的拂照之情，璇玑对怀朔的依赖之情，爹娘对我的养育之情，我和你……还有菱纱在一起的感情，这之间原本就有千千万万的不同，没有谁讲得清楚。", "");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：梦璃你说的对，想不透就别想了，爹也说过，想太多容易掉头发，还不如吃饱睡、睡饱吃，呵呵～", "");
        giWait(0.3);
        giNpcDoAction("SN002", "J14", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：嗯，云叔说的也对～", "");
        giNpcEndAction("SN002", true);
        giFlashOutBlack(1.5, true, true);
        npc_b = 2;
        giSetNpcVisible("SN002", false);
        giSetObjectVisible("title04", true);
        giPlayerSetVisible(0, false);
        giSetNpcVisible("4017", false);
        giSetNpcVisible("4049", false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(7734.2, -1387.9, -8051.8);
        giPlayerCurrentSetAng(338.0);
        giCameraSetMode(0, true);
        giScriptMusicStop(0, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func3004()
{
    if (global_mvar < 101400 && global_mvar >= 70500 && npc_c == 1 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P23", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 5719.2, -1383.6, -5551.6);
        giPlayerSetAng(0, 284.0);
        giPlayerSetPos(1, 5662.6, -1387.9, -5726.0);
        giPlayerSetPos(2, 5612.3, -1387.9, -5723.6);
        giNpcSetPos("SN005", 5766.3, -1313.9, -5574.2);
        giNpcSetAng("SN005", 280.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("SN005", true);
        giSetObjectVisible("title12", false);
        giIMMEnd();
        giCameraPrepare("wu001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：天河你、你身后那是什么？", "");
        giWait(0.3);
        giPlayerSetDir(0, 176.0, false);
        giNpcSetDir("SN005", 202.0, true);
        giPlayerWalkTo(1, 5701.8, -1387.9, -5620.0, false);
        giPlayerWalkTo(2, 5647.2, -1387.9, -5625.8, false);
        giPlayerEndMove(1);
        giPlayerSetAng(1, 14.0);
        giPlayerSetAng(2, 56.0);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102M", true);
        giTalk("云天河：一只会飞的猪，叫作“勇气”。", "");
        giWait(0.5);
        giNpcSetEmotion("SN005", "339_jj");
        giNpcDoAction("SN005", "C09", 1, false);
        gi2DSoundPlay("WJ092", 1);
        giNpcEndAction("SN005", true);
        giNpcSetEmotion("SN005", "339_zc");
        giWait(0.3);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：你有点常识好不好？猪长这副模样吗？而且猪怎么可能会飞？！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcSetEmotion("SN005", "339_kx");
        giNpcDoAction("SN005", "C08", 1, false);
        gi2DSoundPlay("WJ086", 1);
        giNpcEndAction("SN005", true);
        giNpcSetEmotion("SN005", "339_zc");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：不是猪？我看它跟山猪哦咿～哦咿～差不多的声音啊！", "");
        giWait(0.3);
        giPlayerSetDir(1, 56.0, true);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：它真的好可爱哦～嘻，能让我摸摸看吗？", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerWalkTo(1, 5740.3, -1383.6, -5603.5, false);
        giWait(0.6);
        gi2DSoundPlay("WJ092", 1);
        giNPCFlyTo("SN005", 5708.5, -1321.9, -5598.4, true);
        giNpcSetDir("SN005", 126.0, true);
        giPlayerSetDir(1, 294.0, true);
        giPlayerSetDir(0, 188.0, true);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：哟……它还不愿意呢。", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        gi2DSoundPlay("WJ093", 1);
        giWait(1.4);
        giPlayerDoAction(2, "J14", 1, true);
        giIMMBegin();
        giPlayerSetPos(2, 5663.8, -1387.9, -5613.1);
        giPlayerSetAng(2, 56.0);
        giPlayerSetAng(0, 200.0);
        giPlayerSetAng(1, 298.0);
        giNpcSetPos("SN005", 5687.4, -1321.9, -5595.1);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：云公子，你是不是从怪物手里救下了它？", "");
        giWait(0.3);
        giNpcSetDir("SN005", 190.0, true);
        giWait(0.3);
        giSetPortrait("102K", true);
        giTalk("云天河：是可以这么说啦，应该是抢下它，哈哈！", "");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：这便是了。它说你救过它一命，它很感激呢。", "");
        giWait(0.5);
        giNpcSetEmotion("SN005", "339_kx");
        giNpcDoAction("SN005", "C08", 1, false);
        gi2DSoundPlay("WJ086", 1);
        giNpcEndAction("SN005", true);
        giWait(0.3);
        giPlayerSetDir(1, 256.0, true);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：梦璃你……你能听懂这小东西说的话？！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(2, 82.0, true);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：嗯……我自幼就能辨识一些常人听不见的声音、听不懂的话，小时候还不觉得，渐渐长大了，才明白我和别人不太一样……", "");
        giSetPortrait("104M", true);
        giTalk("韩菱纱：好梦璃，这有什么的，天赋异禀是好事啊。", "");
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：嘻嘻，你快告诉我，这只小东西唧唧啾啾的还说了什么，我好想知道～", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：它说……它是一只五毒兽，因为想让自己变得强一点，才来太一仙径修炼的。", "");
        giWait(0.3);
        giNpcDoAction("SN005", "C08", 1, false);
        gi2DSoundPlay("WJ086", 1);
        giNpcEndAction("SN005", true);
        giWait(0.3);
        giPlayerDoAction(0, "J17", 1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：（无毒兽？怎么会有这种东西？看起来确实没有毒，应该很好吃吧……）", "");
        giWait(0.3);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：五毒兽？原来这就是五毒兽呀！我以前听族里的人说过，那是一种很了不得的仙兽呢，它们孕育的五毒珠能解世间百毒。真没想到就是这样小小一只～", "");
        giNpcSetDir("SN005", 126.0, true);
        giNpcDoAction("SN005", "J01", 1, false);
        gi2DSoundPlay("WJ087", 1);
        giWait(1.8);
        giSetPortrait("102D", true);
        giTalk("云天河：（无毒兽能生出无毒猪？越听越不懂……）", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102D", true);
        giTalk("云天河：那它到底是不是猪呀，我都搞糊涂了……它干嘛要跟着我？", "");
        giWait(0.7);
        giNpcSetEmotion("SN005", "339_zc");
        gi2DSoundPlay("WJ093", 1);
        giWait(1.2);
        giNPCFlyTo("SN005", 5687.4, -1307.9, -5595.1, true);
        giNpcSetDir("SN005", 120.0, true);
        giNpcDoAction("SN005", "C02", 0, false);
        giNpcSetEmotion("SN005", "339_fn");
        gi2DSoundPlay("WJ090", 1);
        giWait(2.0);
        giNpcSetEmotion("SN005", "339_zc");
        giWait(0.5);
        giNPCFlyTo("SN005", 5717.4, -1323.9, -5613.2, true);
        giNpcSetDir("SN005", 286.0, true);
        giNpcSetEmotion("SN005", "339_jj");
        giNpcDoAction("SN005", "C09", 1, false);
        gi2DSoundPlay("WJ089", 1);
        giWait(2.0);
        giNpcEndAction("SN005", true);
        giNpcSetDir("SN005", 218.0, true);
        giNpcSetEmotion("SN005", "339_bs");
        gi2DSoundPlay("WJ091", 1);
        giWait(1.3);
        giNpcSetEmotion("SN005", "339_zc");
        giNPCFlyTo("SN005", 5735.0, -1321.9, -5556.3, true);
        giNpcSetDir("SN005", 198.0, true);
        giPlayerSetDir(1, 352.0, false);
        giPlayerSetDir(2, 42.0, false);
        giWait(0.5);
        giNpcSetEmotion("SN005", "339_kx");
        giNpcDoAction("SN005", "J03", 1, false);
        gi2DSoundPlay("WJ086", 1);
        giWait(2.0);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：它说，它在太一仙径里惹到打不过的怪物，幸好被你救了，它想——", "");
        giSetPortrait("102C", true);
        giTalk("云天河：想什么？", "");
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("107C", false);
        giTalk("柳梦璃：它想认你作老大。", "");
        gi2DSoundPlay("WJ086", 1);
        giNpcDoAction("SN005", "C08", 1, false);
        giWait(1.0);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：真是太可爱了，它还懂得知恩图报呢～", "");
        giWait(0.5);
        giNpcDoAction("SN005", "J01", 1, false);
        gi2DSoundPlay("WJ087", 1);
        giWait(1.5);
        giSetPortrait("102C", true);
        giTalk("云天河：老大？就是像柳波波那样的？", "");
        giNpcSetEmotion("SN005", "339_mr");
        gi2DSoundPlay("WJ088", 1);
        giWait(0.3);
        giNpcEndAction("SN005", true);
        giNpcSetDir("SN005", 294.0, true);
        giPlayerDoAction(1, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：可是……我不想当什么老大啊，我还以为它是会飞的猪，想把它烤来吃，不过那个什么仙兽，也一样可以烤吧？", "");
        giWait(0.3);
        giNpcSetEmotion("SN005", "339_jj");
        giNpcDoAction("SN005", "C09", 1, false);
        gi2DSoundPlay("WJ089", 1);
        giWait(1.0);
        gi2DSoundPlay("WJ091", 1);
        giWait(1.0);
        giPlayerSetAng(1, 342.0);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：有没搞错啊！你这野人，它这么可爱，你居然想吃它！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, true);
        giNpcSetEmotion("SN005", "339_bs");
        gi2DSoundPlay("WJ093", 1);
        giNPCFlyTo("SN005", 5686.5, -1309.9, -5569.6, true);
        giNpcDoAction("SN005", "C09", 1, true);
        gi2DSoundPlay("WJ091", 1);
        giNPCFlyTo("SN005", 5734.5, -1309.9, -5744.7, false);
        giWait(1.3);
        giPlayerSetDir(1, 170.0, false);
        giPlayerSetDir(0, 172.0, false);
        giPlayerSetDir(2, 136.0, false);
        giWait(0.8);
        giPlayerSetDir(1, 344.0, true);
        giPlayerDoAction(1, "J15", 1, false);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：讨厌！都是你，把它吓跑了，我还没有好好瞧上一眼呢！", "");
        giWait(0.3);
        giPlayerSetDir(2, 42.0, true);
        giPlayerSetAng(0, 162.0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：……不会吧？刚才你都一直盯着它看……", "");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104F", true);
        giTalk("韩菱纱：我！……不和你说了，免得被气死……", "");
        giPlayerEndAction(1);
        giPlayerWalkTo(1, 5810.3, -1383.6, -5598.2, true);
        giPlayerSetVisible(1, false);
        giSetNpcVisible("SN005", false);
        giSetPortrait("102A", false);
        giTalk("云天河：飞走就飞走，有什么好气的……", "");
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：菱纱大概是想跟那只五毒兽多玩一会儿吧，我也觉得它很可爱呢。", "");
        giWait(0.6);
        giPlayerSetDir(0, 206.0, true);
        giWait(0.5);
        giSetPortrait("102B", true);
        giTalk("云天河：那好办，下回我再去太一仙径把它捉回来不就行了？", "");
        giWait(0.3);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：不用了，它也不一定会再去太一仙径吧，而且让它自由自在地飞，不是更好吗？", "");
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102F", true);
        giTalk("云天河：好……我听你的……", "");
        giSetPortrait("107B", false);
        giTalk("柳梦璃：嗯，还有一件事希望云公子能答应我……", "");
        giSetPortrait("102F", true);
        giTalk("云天河：啊？什么事？", "");
        giWait(0.3);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：可不可以……那只仙兽……", "");
        giWait(0.5);
        giSetPortrait("102F", true);
        giTalk("云天河：……", "40185; 40365; 40671; 40744; 41093; 41330; 42664; 42960; 43288; 43444; 44023; 44283; 44290; 44345; 44415; 44425; 44554; 45013; 45223; 45349; 45372; 45391; 45948; 45978; 45980; 46135; 46191; 46199; 46270; 46336; 46450; 46587; 46787");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102F", true);
        giTalk("云天河：好！我知道了，梦璃你心肠好。我不会再想烤了它填肚子，以后这种什么兽呀猪呀，我都不烤就是了……", "");
        giSetPortrait("107B", false);
        giTalk("柳梦璃：云公子，谢谢你，你能明白……我真的很高兴。 ", "");
        giPlayerEndAction(2);
        giWait(0.7);
        giPlayerWalkTo(2, 5601.5, -1387.9, -5633.9, true);
        giPlayerSetVisible(2, false);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102G", true);
        giTalk("云天河：（……话是这么说没错，但说完后感觉……好后悔……）", "");
        giPlayerEndAction(0);
        giFlashOutBlack(1.5, true, true);
        npc_c = 2;
        giNpcSetEmotion("SN005", "339_zc");
        giSetObjectVisible("title12", true);
        giPlayerSetVisible(0, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(5719.2, -1383.6, -5551.6);
        giPlayerCurrentSetAng(302.0);
        giCameraSetMode(0, true);
        giPetShow(false);
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func3005()
{
    if (global_mvar < 101400 && global_mvar >= 70500 && npc_c == 2 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P23", 2, 0.0, 0.0);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 5.2, 0.7, 45.4);
        giPlayerSetAng(0, 144.0);
        giNpcSetPos("SN001", -49.3, 0.7, -32.9);
        giPlayerSetVisible(0, true);
        giSetNpcVisible("SN001", true);
        giSetObjectVisible("SO001", true);
        giSetObjectVisible("SO002", true);
        giSetObjectVisible("SO003", true);
        giSetObjectVisible("SO004", true);
        giSetObjectVisible("SO005", true);
        giIMMEnd();
        giArenaReady();
        giCameraPrepare("wu001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", false);
        giTalk("云天河：奇怪，床上什么时候多了这些东西？", "");
        giWait(0.7);
        gi2DSoundPlay("WJ085", 1);
        giWait(2.0);
        giNPCFlyTo("SN001", 18.0, 56.7, 10.6, true);
        giNpcSetDir("SN001", 322.0, true);
        giNpcSetEmotion("SN001", "339_kx");
        gi2DSoundPlay("WJ085", 1);
        giWait(1.3);
        giPlayerSetDir(0, 164.0, true);
        giSetPortrait("102D", false);
        giTalk("云天河：啊？！原来是勇气啊！", "");
        giNpcSetEmotion("SN001", "339_zc");
        gi2DSoundPlay("WJ093", 1);
        giWait(1.5);
        giSetPortrait("102C", false);
        giTalk("云天河：啥意思？这堆东西和你有关？……", "");
        giNPCFlyTo("SN001", 17.2, 48.7, -12.1, true);
        giNpcSetDir("SN001", 332.0, true);
        giNpcDoAction("SN001", "J03", 1, false);
        gi2DSoundPlay("WJ093", 1);
        giWait(1.6);
        giPlayerDoAction(0, "J15", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：好晕～～～～根本什么都听不懂！", "");
        giPlayerEndAction(0);
        giSetPortrait("102A", false);
        giTalk("云天河：对了！梦璃！我去找梦璃，她一定知道你在说什么！", "");
        giNpcSetEmotion("SN001", "339_kx");
        giNpcDoAction("SN001", "C08", 1, false);
        gi2DSoundPlay("WJ086", 1);
        giWait(1.5);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetPos(0, -17.8, 0.7, 23.7);
        giPlayerSetAng(0, 122.0);
        giPlayerSetPos(2, 29.9, 0.7, 48.6);
        giPlayerSetAng(2, 180.0);
        giPlayerSetPos(1, 64.0, 0.7, 31.8);
        giPlayerSetAng(1, 250.0);
        giNpcSetPos("SN001", 20.4, 56.7, 0.9);
        giNpcSetAng("SN001", 12.0);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giNpcSetEmotion("SN001", "339_zc");
        giCameraRunSingle("002", true);
        giFlashInBlack(1.5, true);
        gi2DSoundPlay("WJ093", 1);
        giWait(1.6);
        giNpcDoAction("SN001", "J03", 1, false);
        gi2DSoundPlay("WJ093", 1);
        giWait(1.5);
        giNpcEndAction("SN001", true);
        giPlayerSetDir(1, 316.0, true);
        giWait(0.3);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：梦璃，它到底在讲什么呀？为什么又回来了呢？", "");
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：天河床上的那些，都是它搜集的漂亮宝石，据说是要送给天河，让天河不要吃自己，然后……带它一起修炼，教它怎样才能变强。", "");
        giWait(0.4);
        giPlayerDoAction(1, "c08", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：它可真是有心，太了不起了～不过……宝石送给天河这家伙，实在糟蹋，他又不懂欣赏……", "");
        giSetPortrait("104J", true);
        giTalk("韩菱纱：（还不如给我呢，嘻嘻……）", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：对啊，我要这些石头又没用，也不能当饭吃。", "");
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(2, 190.0);
        giPlayerSetAng(1, 250.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giNpcSetEmotion("SN001", "339_bs");
        gi2DSoundPlay("WJ091", 1);
        giWait(1.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：你不要伤心，人和仙兽的修炼之法应该颇有不同，原本就是不能在一起的。我感觉的到，其实你的灵力很强，不需要羡慕任何人。", "");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giNpcSetEmotion("SN001", "339_mr");
        gi2DSoundPlay("WJ088", 1);
        giWait(1.2);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：只不过你的潜力还没有发挥出来，只要多加修炼，一定会变成一只强大的仙兽。", "");
        giWait(0.3);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：嗯，梦璃说得对，你要有信心～你现在就这么懂事，以后肯定会很强的。", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcSetDir("SN001", 50.0, true);
        giNpcSetEmotion("SN001", "339_kx");
        giNpcDoAction("SN001", "C08", 1, false);
        gi2DSoundPlay("WJ086", 1);
        giWait(1.9);
        giNpcSetEmotion("SN001", "339_zc");
        giNPCFlyTo("SN001", 9.9, 56.7, 10.0, true);
        giNpcSetDir("SN001", 306.0, true);
        gi2DSoundPlay("WJ093", 1);
        giWait(1.8);
        giPlayerSetDir(0, 39.0, true);
        giWait(0.5);
        giSetPortrait("102A", true);
        giTalk("云天河：……？", "40445; 40632; 41503; 41617; 41674; 41736; 41924; 42558; 42636; 43483; 44255; 46035");
        giWait(0.3);
        giPlayerSetDir(2, 239.0, true);
        giWait(0.3);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：它说它决定了，现在先离开，等到炼成五毒珠，变得像老大一样厉害时，再回来报答你。", "");
        giPlayerDoAction(0, "J14", 1, true);
        giPlayerSetDir(0, 122.0, true);
        giCameraRunSingle("004", true);
        giWait(0.4);
        giSetPortrait("102C", true);
        giTalk("云天河：变得像我一样厉害？那多猎山猪不就好了，又练臂力又练脚力。", "");
        giNpcDoAction("SN001", "C08", 1, false);
        gi2DSoundPlay("WJ086", 1);
        giNpcEndAction("SN001", true);
        giNpcDoAction("SN001", "J02", 1, false);
        gi2DSoundPlay("WJ093", 1);
        giNpcEndAction("SN001", true);
        giWait(0.5);
        giNpcSetEmotion("SN001", "339_bs");
        gi2DSoundPlay("WJ091", 1);
        giWait(0.6);
        giNPCFlyTo("SN001", -34.6, 56.7, 110.1, true);
        giPlayerFaceToNpc(0, "SN001", false);
        giPlayerFaceToNpc(1, "SN001", false);
        giPlayerFaceToNpc(2, "SN001", false);
        giWait(0.8);
        giSetNpcVisible("SN001", false);
        giCameraRunSingle("005", true);
        giWait(0.7);
        giPlayerSetDir(1, 270.0, true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104F", false);
        giTalk("韩菱纱：喂，你不要随便乱说好不好，它那么认真，会被教坏的！", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(0, 86.0, true);
        giPlayerSetDir(2, 236.0, true);
        giSetPortrait("102D", true);
        giTalk("云天河：我是说真的，哪有乱说……", "");
        giWait(0.3);
        giSetPortrait("104F", false);
        giTalk("韩菱纱：野人……跟你说不通，也不知道那小东西干嘛那么粘你，难不成……你真有当老大的潜力？", "");
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("107C", false);
        giTalk("柳梦璃：噗……", "42569; 42814");
        giWait(0.3);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：是有此可能，云公子是个好人，它很喜欢云公子，所以想要认个好老大。", "");
        giSetPortrait("104E", false);
        giTalk("韩菱纱：……", "40351; 40378; 40403; 40453; 40590; 40820; 41359; 41517; 41972; 41994; 42130; 42631; 42648; 43704; 44221; 44322; 44866; 45106; 45128; 46014; 46059; 46067; 46108; 46170; 46354; 46570; 46583");
        giWait(0.3);
        giPlayerSetDir(1, 304.0, true);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：好梦璃，我发现你现在越来越常笑了，说话也比较有趣了。", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("107E", false);
        giTalk("柳梦璃：啊？！", "");
        giPlayerSetDir(2, 152.0, true);
        giWait(0.3);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：我……有吗……", "");
        giWait(1.0);
        giIMMBegin();
        giPlayerSetAng(1, 272.0);
        giPlayerSetAng(0, 122.0);
        giPlayerSetPos(0, -4.0, 0.7, 23.6);
        giPlayerSetVisible(2, false);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：（这个野人，简直跟木头似的，不知现在脑子里又在想什么，笨死了……）", "");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("007", false);
        giWait(1.3);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.8);
        giSetPortrait("102G", true);
        giTalk("云天河：（……无毒兽……无毒猪……不晓得吃起来是什么感觉？可惜已经答应梦璃了，唉……）", "");
        giWait(0.5);
        giAddProperty(3164, 10, true);
        giWait(1.5);
        giAddProperty(3157, 5, true);
        giWait(1.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(0, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-57.7, 0.7, 66.2);
        giPlayerCurrentSetAng(339.0);
        giSetObjectVisible("SO001", false);
        giSetObjectVisible("SO002", false);
        giSetObjectVisible("SO003", false);
        giSetObjectVisible("SO004", false);
        giSetObjectVisible("SO005", false);
        giIMMEnd();
        npc_c = 3;
        giCameraSetMode(3, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giAddPlayerFavor(1, 0, 30);
        giAddPlayerFavor(2, 0, 20);
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
    }
}

void func3006()
{
    if (global_mvar <= 101400 && global_mvar >= 90100 && var_zhu == 3 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giPlayerLock();
        giArenaLoad("Q06", "QN03", "", true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetVisible(0, false);
        giPlayerSetPos(3, 0.9, 0.5, 20.9);
        giPlayerSetAng(3, 188.0);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MN001", true);
        giIMMEnd();
        giCameraPrepare("yan004");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, false);
        giArenaReady();
        giWait(1.5);
        giSetPortrait("213A", false);
        giTalk("夙瑶：紫英，何事禀报？", "");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：掌门，弟子于山下偶遇夙莘师叔，师叔不愿随弟子回来，只托付将一样东西带给您。", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.3);
        giNpcSetDir("MN001", 0.0, true);
        giWait(0.5);
        giSetPortrait("213C", false);
        giTalk("夙瑶：夙莘？！你在何处见到她？她为何不肯回来？", "");
        giPlayerDoAction(3, "J03", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：师叔吩咐，若是掌门询问，便打开这个箱子。", "");
        giWait(0.7);
        giSetObjectVisible("SO001", true);
        giSetPortrait("213A", false);
        giTalk("夙瑶：哦？故弄玄虚，这可不似夙莘的性子。", "");
        giSetPortrait("213A", false);
        giTalk("夙瑶：也罢，便依她所言，看看究竟何意……", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：是。", "");
        giWait(0.5);
        giObjectDoAction("SO001", "OM07", -1, true);
        giWait(0.3);
        giSetNpcVisible("SN001", true);
        giNPCFlyTo("SN001", 5.8, 70.5, -32.3, false);
        giWait(0.5);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giDelProperty(3244, 1, false);
        giWait(1.5);
        giSetPortrait("213B", false);
        giTalk("夙瑶：这是何物？！", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……", "42783; 42993; 43015; 43178; 43305; 43307; 43312; 43592; 43697; 43822; 43865; 44083; 44108; 44113; 44175; 44552; 44633; 44896; 44975; 45086; 45373; 45403; 45502; 45522; 45748; 46353; 46355; 46372; 46379");
        giCameraRunSingle("002", false);
        giNPCFlyTo("SN001", -22.2, 82.5, -138.3, true);
        giCameraWait();
        giNpcSetAng("SN001", 146.0);
        giNpcSetDir("MO001", 346.0, true);
        giTalk("夙莘：师姐，是我呀，你是不是吓一跳？", "");
        giSetPortrait("213C", false);
        giTalk("夙瑶：夙莘？", "");
        giTalk("夙莘：这机关鹰是我自己做的，很不错吧～", "");
        giSetPortrait("213B", false);
        giTalk("夙瑶：……", "42983; 45885; 46685");
        giCameraRunSingle("003", false);
        giTalk("夙莘：师姐，你先别生气，我知道……当初我为了一点小事和其他弟子争执，一气之下竟然离开了昆仑山，让你很是为难……", "");
        giTalk("夙莘：在山上，你是对我最好的人，可能因为我们性情相近，一样争强好胜，一样不肯服输……夙莘别的都可以不在乎，只是一想到这些年来辜负了师姐的期望，早将修仙所学荒废，就更加不敢回来了……", "");
        giSetPortrait("213B", false);
        giTalk("夙瑶：……", "42983; 45885; 46685");
        giTalk("夙莘：不过……师姐你不用替我担心，我如今过得很好……", "");
        giTalk("夙莘：刚下山时脾气还是一样倔，不懂江湖规矩，吃了亏，差点丢了性命，是一位老人做的机关兽救了我，后来我就跟着他学做机关，他是“偃师”一脉的传人，知识很渊博。", "");
        giTalk("夙莘：我走遍五湖四海，才发现世间比想像的更加广大，就算不修仙道，一样可以遨游宇内、乘奔御风，在无尽的天地间，人是那样渺小，许多原本看得很重的东西，都变得不那么重要了……", "");
        giTalk("夙莘：所以……还是现在每天喝酒、行走江湖的日子更适合我，我们……相见不如不见，我但愿永远是你心目中那个横冲直撞的小师妹……", "");
        giTalk("夙莘：师姐，保重……", "");
        giNPCFlyTo("SN001", -43.2, 126.5, -54.5, true);
        giSetNpcVisible("SN001", false);
        giWait(1.0);
        giCameraRunSingle("004", true);
        giWait(1.0);
        giSetPortrait("213B", false);
        giTalk("夙瑶：……紫英……", "");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：弟子在。", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("213B", false);
        giTalk("夙瑶：你见到夙莘时，她真如刚才所言，自甘堕落，不但荒废所学，竟还酗酒伤身？", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：掌门……", "42953; 46856");
        giSetPortrait("213B", false);
        giTalk("夙瑶：如实答来。", "");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：是……师叔她确有饮酒——", "");
        giNpcDoAction("MN001", "J04", 1, false);
        giSetPortrait("213B", false);
        giTalk("夙瑶：够了！你且退下。我自会告知掌管名录的弟子，将夙莘之名除去。", "");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……！掌门，您的意思是……要将师叔逐出门墙？！", "");
        giNpcSetDir("MN001", 170.0, true);
        giWait(0.5);
        giSetPortrait("213B", false);
        giTalk("夙瑶：不错。本派正值用人之际，她却如此行止，兼之言行不端，习旁门左道之术，我留她何用？", "");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：…………", "42751; 44030; 44566; 44797; 45022; 45199; 45299; 45387; 45554; 45687; 45774; 45776; 45786; 45820; 45823; 45843; 46182; 46311; 46456");
        giSetPortrait("213B", false);
        giTalk("夙瑶：去吧，我意已决，不必多言。", "");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……是。", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giPlayerWalkTo(3, 116.0, 0.5, 153.7, false);
        giWait(1.0);
        giCameraRunSingle("005", true);
        giWait(0.5);
        giSetPortrait("213C", true);
        giTalk("夙瑶：……夙莘，竟连你都如此，世情变迁，令人齿冷……可叹妖界将临，身边无一人足以信任，上天何以如此待我琼华……", "");
        giWait(2.0);
        giCameraRunSingle("006", false);
        giWait(2.0);
        giSetPortrait("213B", true);
        giTalk("夙瑶：……满座衣冠犹胜雪，更无一人是知音……", "");
        giWait(2.0);
        giFlashOutBlack(2.5, true, true);
        var_zhu = 4;
        giArenaLoad("Q06", "Q06Q", "", true);
        giPlayerCurrentSetPos(11908.7, -1669.7, -10743.2);
        giPlayerCurrentSetAng(170.0);
        giCameraSetMode(0, true);
        giArenaReady();
        giAddPlayerFavor(1, 3, 15);
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("明如：掌门似乎已在禁地闭关多日，据说是与我派的另一位前辈高人一同修炼歼灭妖界之法，届时我们一切听掌门吩咐即可！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("明如：据说卷云台旁边那个庞然大物便是妖界的入口，其中妖物都是穷凶极恶的！掌门说万万不可莽撞行事，先静观其变！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("明如：昆仑山其他几派似乎无意与我们一同对抗妖界，唉！早知如此，又何必请他们来商议什么？！本派弟子注定是要背水一战的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 70900 /* 第二章 / 4-4-2.叹沧桑 / 禀报掌门 */)
    {
        giRandTalkPush("明如：师父曾说我资质不好，当年收我入门，是看在我为人老实又心诚，可你们几个呢？一入门就擅自下山，真不知道掌门是为什么才破例收你们入门的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("明如：虚寂师叔让我来此等候昆仑山其他几派的道友，共同商议那件了不得的大事，可我等了许久，却也没见他们来……");
        giRandTalkPush("明如：昆仑山中共有八个修仙门派，琼华派乃是其中之一。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("虚忘：掌门在禁地闭关也有一些日子了，妖界却也虚实莫测，毫无动静，越是这样，我们越不能掉以轻心！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("虚忘：妖界已经现身，却也没什么可怕的了，只要一心守住琼华派、不让妖孽为祸人间，即使为此抛却性命也是值得的。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("虚忘：我曾听长老说过，十九年前那场大战十分惨烈，连前代掌门太清真人都亡于妖界之手，如今妖界又将进犯，我辈弟子宁可头断血流，也不能让妖物祸害山下百姓。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("虚忘：山门的这四座神兽像乃是昆仑山的守护神，分别为陆吾、开明、离朱、英招。陆吾虎身九尾，而开明则虎身九头，每个头都是一张人面。");
        giRandTalkPush("虚忘：琼华派修行讲求“人剑合一”，人的修为与剑的品级须相辅相成，我修行似乎过于躁进，三年内已换了五把剑，这样反而无甚进展啊。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("元通：掌门闭关多日，一定是在修行厉害的仙法，等到她出关，多半就是我派与妖界开战之时。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkRelease();
        giRandTalkPush("元通：护卫世间，斩妖除魔乃是琼华弟子职责所在，我们就算与那妖界拼个两败俱伤，也不能让它们危害世间！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("元通：肃武长老说我体质极弱，宜静不宜动，所以我修炼的这套剑法叫做“静剑”，剑动而人不动，我只需站定，以气御剑，使剑自行出招。", "");
        giTalk("元通：“静剑”修炼的最高境界是御剑于千里之外，但我的修行尚浅，操控的剑还只能飞出三里，唉！这样若是妖界来时，我岂不是半分力都使不上？", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("元通：难得，派中近日已不再收徒，你竟能入得山门，想必是有什么过人之处吧！");
        giRandTalkPush("元通：掌门素来治理门派有方，她决定的事，自是所有弟子听令，不会有违。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("怀思：平时看紫英师叔一脸严肃，好像很厉害又很认真的样子，没想到妖界一出现，他跑得比谁都快，整日都不见踪影！真是的……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("怀思：卷云台上那是什么东西，看起来好可怕！还好、还好没有一群妖怪从里面冲出来，不然我吓都吓死了……");
        giRandTalkPush("怀思：掌门和长老们都那么厉害，万一那些妖怪从妖界杀出来，也有他们顶着，我这种辈份低微的弟子嘛，只要乖乖躲在后头就行了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("怀思：最近师父对我越来越严厉，说是什么妖界就要来了，再不用心修行，到时候只有被杀的份！我、我是来修仙的，不是想跟妖怪打架、更不是想被妖怪杀啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 70900 /* 第二章 / 4-4-2.叹沧桑 / 禀报掌门 */)
    {
        giRandTalkPush("怀思：我可听说了，你的胆子也太大了吧？偷跑下山还跑那么远？！上回我只是偷偷溜去播仙镇喝了两口葡萄酒，就被罚面壁思过七天六夜！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("怀思：师父说我们琼华派修仙的法子，比蜀山派高明不知多少倍，可我入门之后，练来练去也就这么一套剑法，完全不觉得是在修仙～");
        giRandTalkPush("怀思：同样都在昆仑山，为什么我们不能学学人家悬圃派和玉英派，炼出仙丹一吃就升仙，根本不用练什么剑法，多轻松啊～");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("璇叶：妖界……一点动静都没有，这样反而让人更害怕，它们一定是有什么诡计，偏偏我们又看不破……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("璇叶：掌门有令，任何人都不要靠近卷云台上的妖界入口。");
        giRandTalkPush("璇叶：掌门这个时候闭关，我猜她一定是得到了玄女娘娘的指点，在修炼一种对付妖界的仙法！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("璇叶：那妖界……似乎是很厉害的，十九年前不知有多少前辈被妖怪害死了，我虽然害怕，但也绝不会给琼华派丢脸，一定会拼死一搏的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("璇叶：新入门的弟子的卧房，一般都在剑舞坪周围，从这儿往西北走，过一座长桥就能看见剑舞坪了。");
        giRandTalkPush("璇叶：掌门的外表看起来好年轻，但仙法却十分高深，我猜她不是普通人，说不定就是九天玄女娘娘派来引领我们升仙的仙子呢～");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("灵修：妖怪这么久还没有出现，是不是因为怕了本派……已经回去了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("灵修：卷云台上那个奇怪的东西就是妖界吗？！师父说里面的妖怪都很凶，会冲出来吃人！所以本派弟子要保护其他人，可我法力那么低，一定第一个被吃，怎么办啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("灵修：师父带我上山的时候，我还以为可以学炼仙丹，没想到天天都要打扫房间，琼华派那么大，打扫一遍下来，天都黑了……");
        giRandTalkPush("灵修：师兄他们跟我说……过段日子会有妖怪出现，让我加紧修行，这不是真的吧？要是真的，不如我现在就下山去算了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("灵修：师父叫我来打扫祭地宫，可这里有点阴气，我好害怕～怎么办？");
        giRandTalkPush("灵修：祭地宫是平时祭拜地下鬼神的地方，究竟怎么祭拜，我也不知道……");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("静言：妖界久无动静，也不知在盘算些什么，但愿掌门仙法早成，带大家杀入妖界，一举铲除那些邪恶的妖物！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("静言：如今妖界已现，掌门却并不急于攻入，反而去了禁地，莫非禁地中有对抗妖界之法？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120100 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        giRandTalkPush("静言：掌门正召集长老与众弟子在宫中议事，未奉掌门之令者，不得入内。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("静言：掌门律己律人皆十分严格，我入门修行三年之后，便开始侍奉在她左右，却还是有很多事无法令她满意……");
        giRandTalkPush("静言：这几日我即将晋入第八重“得道”之境，却在关键之处停滞不前，我只盼在妖界来犯前能够有所成，或许还能为本派稍尽绵薄之力。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("静言：琼华宫乃是掌门处理派中大小事务之所，若无要事，请勿打扰。");
        giRandTalkPush("静言：我自入门始，按道家十六境界修行，从“入道”“求道”修行至如今第七重的“养道”境界，用了十年时间，不算长，却也不算短了。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4007");
    giNpcResumeBeh("4007");
    giPlayerUnLock();
}

void func4008()
{
    giPlayerLock();
    giNpcPauseBeh("4008");
    giNpcFaceToCurrentPlayer("4008", true);
    giCurrentPlayerFaceToNpc("4008", true);
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("虚清：原来禁地里一直都住着我派的前辈高人，掌门和他一起修炼，出关之时一定能威慑妖界！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("虚清：原来卷云台上的庞然大物就是妖界，外面看来像是妖兽的脸，很是狰狞，想必里面的妖怪一定也是穷凶极恶，不好对付。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120100 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        giRandTalkPush("虚清：掌门召集众人在琼华宫中议事，其他人等不得入内。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("虚清：师父收我入门，养我长大，这份恩德没齿难忘，若妖界真的来犯，我只有拼死相搏以报师门之恩。");
        giRandTalkPush("虚清：我拜入师门已经十八年了，修行却仍只到第四重“学道”的境界，不像静言师妹，短短十年就修炼到第七重“养道”的境界。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("虚清：就算资质稍欠，只要用心修行，总会有所精进，修仙求道须得保持着这种“心”才行。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("虚寂：紫英师弟平日行事孤僻古怪也就罢了，如今我派和妖界大战在即，所有弟子都在备战，只有他却忽然没了踪影，实在太不像样！");
        giRandTalkPush("虚寂：掌门定是找到了对付妖界的办法，才会在禁地苦修多日，待她出关之日，便是我琼华派杀入妖界之时！前代掌门的大仇一定要报！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("虚寂：听闻十九年前，我们与妖界一战，死伤惨重，这些年掌门苦心经营门派，想必为的就是妖界再临之时，能有万全的应对之法！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("虚寂：妖界随时可能出现，我派弟子当务之急就是加紧修行！无关紧要的事都可暂时搁置。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("虚寂：这“敬天”之中供奉的宝珠，乃是九天玄女赐于我琼华派先祖的“天珠”，普通弟子虽不知它的用处，但想必是十分玄妙了得的宝物。");
        giRandTalkPush("虚寂：在昆仑八派之中，唯有昆仑派和我琼华派主张炼剑修仙，因而两派之间算是有所往来。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("怀见：现在琼华派所有的弟子都准备和妖界死战，只有紫英师叔却不见踪影，不知发生了什么事……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("怀见：我只知琼华派剑法了得，对妖界用的法术却是一无所知，若是双方交战，妖物又大都狡猾奸诈，我们恐怕很难占上风……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giRandTalkPush("怀见：卷云台上突然出现了一个可怕的巨物！掌门已下令不准大家靠近，可我刚才远远看见柳师妹跑上了卷云台，不知她想干嘛。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("怀见：因为每天采药的缘故，我已经用惯了锄头，师父就专为我创了一套修仙的锄法，现在就算外出我也是御锄，别的倒没什么，就是难看了点……");
        giRandTalkPush("怀见：最近整个门派都在议论妖界之事，依我看，既然十九年前没有赢过它们，反而损兵折将，如今只怕更是凶多吉少啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("怀见：我刚采药回来，正要去前面的龙芽道丹，把草药拿给师父炼丹呢。");
        giRandTalkPush("怀见：我和其他师兄弟就住在剑舞坪附近，离龙芽道丹也不远，平时在外面受了小伤，去师父那儿取了药回房，很是方便。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("怀宁：原来禁地中还有本派的前辈高人，之前不让弟子随意进入，定是怕打扰前辈清修，如今妖界降临，掌门在禁地闭关，应是在接受高人指点，以御妖界强敌。");
        giRandTalkPush("怀宁：我派和妖界的大战一触即发，我的修为虽不出众，却也绝无退缩之理！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("怀宁：掌门身上所佩之玉，蕴有无限灵气，是一件仙家至宝，修仙者将其带在身上，若是修炼得当，可得事半功倍之效。");
        giRandTalkPush("怀宁：妖界已临，掌门于此时去禁地，一定是另有打算，与禁地中不为人知的秘密相关吧。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("怀宁：少年人血气方刚，行事冲动鲁莽是难免的，你可以在这里挑几件宁神静气的饰品，戴在身上有平和心境之功用。");
        giRandTalkPush("怀宁：璇玑师妹最喜欢到这里来，每次看到新鲜的小饰物，便会磨着师父送她几件，师父说不过她，自然也就只能送她了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("怀宁：本派擅铸剑炼铁之术，此间玄珠心镜的饰物，也多出于门下弟子之手。");
        giRandTalkPush("怀宁：昆仑八派之中，碧玉、紫翠两派重炼凝神，因而两派弟子多佩宁神静心的饰物，其材质、造工都是上上之品。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("明丹：此间已备足金创药、还神丹，和妖界的大战无论何时开始，我派受伤的弟子都绝不会无药可用。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("明丹：自妖界现形以来，怀见师弟常在剑舞坪一练一整日，他的那套锄法也越练越熟，师父已命我教授他下一套锄法了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("明丹：道门仙丹炼制，有外丹、内丹之说。昆仑八派之中，悬圃、玉英两派所炼丹药俱为外丹，而以炼气为主的阆风、天墉两派，则修内丹。");
        giRandTalkPush("明丹：怀见常常采药，用惯了药锄，师父就干脆让他使锄，还为他创了锄法，由剑入锄，虽然招式不同，但归其根本，同我琼华剑法并无两样。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("明丹：道家仙丹之要，在神水华池，得神水而后生白金，白金返黄金，黄金返紫金，紫金流液熏结而成丹。此等仙丹之法，炼制之时尚需观天地阴阳五行之气，其中繁复，便是昆仑八派中最擅长炼丹的悬圃、玉英两派，亦无法完全掌控。");
        giRandTalkPush("明丹：所谓还丹，乃炼水银而返为丹者。此间丹炉中只炼雄黄雌黄，不炼水银丹砂，治病治伤的丹药不少，修仙炼气的大小还丹是很少的。");
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
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("璇云：我好怕妖界……可我不会逃走的，如果琼华派的弟子都逃了，那山下的人怎么办，不是只能等着被妖怪吃吗……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("璇云：掌门这几日茶饭不思，如今索性去了禁地，怕是要闭关吧……可惜我没用，根本帮不上她什么忙……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("璇云：听说不久妖怪就会来了……派里其他弟子都很用心地在修炼，可我只会做菜，剑术练得不好……万一、万一那些妖怪伤害到山下的人怎么办……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("璇云：修行讲究辟谷之术，其实吃东西已是不多，但斋菜总还是要备着。");
        giRandTalkPush("璇云：我以前住在山下播仙镇，因为感念山上神仙赐清水给我们，就想上山来拜谢神仙，没想到竟留在这儿修行了，“璇云”这个号也是师父帮我取的。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("怀心：妖界现形也有一阵子了，却不见有妖怪跑出来，也不见它离开，不知道里面的妖怪在盘算什么阴谋诡计？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("怀心：现在只要走出屋门就能感到一阵阵阴风从卷云台上吹下来，风里还夹杂着妖气，定是那妖界散发出来的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("怀心：我终于把琼华派入门的剑法和心法练好了！师父叫我自己去承天剑台找虚冶师伯铸一把新的剑，你说我要什么样的剑才好呢？");
        giRandTalkPush("怀心：如今妖界即将出现，听说其中都是强大残忍的妖！即使这样，我也不会退缩的，修仙问道本就是为了保护黎民百姓！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("怀心：听说本门收了三名新弟子，我入门一年多了，一直都是小师弟，现在终于能当师兄啦，哈哈～");
        giRandTalkPush("怀心：因为我入门较晚，所以打扫卧室的事都归我做，师父说修行不只是练气练剑，在山上做的任何一件事情都是修行。");
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
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("静语：其他弟子或许不知，但我却知道，掌门已逐你下山！为何还留在山上？！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("静语：这次掌门前往禁地，一定是与对付妖界的事情有关，听师父说过，后山禁地十多年来从未有人入内，不知其中到底藏有什么秘密？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giRandTalkPush("静语：卷云台上出现的庞然大物正是妖界，不少弟子还不知道，但掌门已下令，所有弟子都不得靠近卷云台！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("静语：十九年一度、妖界将临的日子近了，掌门正忙于对付妖界的大事，其他弟子也应做好殊死一战的准备！此妖界凶残成性，连前代掌门都是被它们害死的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 70900 /* 第二章 / 4-4-2.叹沧桑 / 禀报掌门 */)
    {
        giRandTalkPush("静语：前日里才关照过你不要随意行事，你就私自下山！若不是掌门有令不再追究，我必上报正法长老，罚你面壁！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("静语：我乃本派威仪长老座下的执事弟子，协助长老督促弟子言行举止，你初入本派，凡事皆须谨遵师命，切不可随意行事。");
        giRandTalkPush("静语：掌门在此时收你入门，一定是非常看重你的天资，切勿令她失望啊！");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("灵观：那个妖界在天上已经好久了，掌门又去禁地闭关，我们到底什么时候才能把妖界打跑？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("灵观：大家都说卷云台上那个怪物就是妖界，掌门还吩咐大家不要靠近，可我们琼华派有这么多厉害的弟子，还有法力无边的掌门和长老，还会怕妖怪吗？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("灵观：上回我在这儿不小心砸碎了一个茶杯！本以为长老一定会责骂我，没想到他只是让我收拾完了就离开，一定是妖界快要来了，长老心事重，顾不上这种小事了……");
        giRandTalkPush("灵观：师兄师姐们本来话就不多，最近听说有大妖怪要出现了，大家更是只顾修炼，和我说话的人越来越少了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("灵观：这里是正法长老的卧房～哎？你不会以为我是正法长老吧？怎么可能嘛？我只是来打扫的～");
        giRandTalkPush("灵观：正法长老有事不在山上，但他的房间却还是天天都要打扫，要是他回来以后，发现房间不干净的话，我会挨骂的。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("明常：所谓临危之时见人心，以前大家都说紫英师叔心性稳重，能成大器，现在妖界一出现，他就跑得没影了，这不是胆小怕事是什么？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("明常：妖界确实非同一般，只是站在这儿，就能感到妖风阵阵，心思稍有不稳，气息就紊乱了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giRandTalkPush("明常：刚才卷云台上突然黑云翻滚、阴风怒号，一定是出大事啦！莫非、莫非是妖界……");
        giRandTalkPush("明常：我见柳师妹从这儿往卷云台的方向跑了！她跑得飞快，我叫也叫不住！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 101400 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giRandTalkPush("明常：哼！要是那个女贼胆敢把歪主意打到我头上，我就让她尝尝手中这柄八卦剑的厉害！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("明常：我终于明白了！原来练这“八卦剑”的要领全在手腕和手臂的方位，只要方位正确，就能使好剑法！");
        giRandTalkPush("明常：自从领悟了八卦剑修炼的十字要诀，我的剑术和修为都一日千里般精进，如此下去，即便是妖界，我也不怕它了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("明常：师父教我的剑法叫作“八卦剑”，师父说其要诀在于“挑托抹挂扁，搜闭扫顺截”，可这十个字什么意思啊？我耍起剑来，还是完全不得要领……");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("静慈：我这套剑法已练得不错，趁现在和妖界的大战没开始，先去承天剑台找虚冶师兄把我手里的剑重铸一番，到时候就能用最厉害的剑法和最称手的宝剑杀妖！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("静慈：妖界果然是说来就来，一个时辰前卷云台边还什么都没有，现在却突然出现了这么一个面目狰狞的庞然大物！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giRandTalkPush("静慈：掌门吩咐，不可靠近卷云台，莫非那柳梦璃不知道？我见她竟往那个方向跑去！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 101400 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giRandTalkPush("静慈：我派门下弟子皆为品性端正、光明磊落之人，何时出过盗贼？但愿掌门能早日将那女贼逐出师门，以免污了琼华派的清誉！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("静慈：听师父说，西北面的卷云台便是十九年前我派和妖界大战的地方。如我辈弟子，是想像不出当年的场面是何等惨烈的。");
        giRandTalkPush("静慈：我正在修习的这套剑法，相传是春秋时一位隐居山林的大师所创，后来虽经琼华派先人琢磨修改，但最初的要诀，却从未更动过。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("静慈：师父曾说，现任掌门论才华资质，皆不是当年最优秀的弟子，只是十多年前派中发生剧变，现任掌门只得临危受命，挑起了这副重担。");
        giRandTalkPush("静慈：“夫剑之道，甚微而易，其意甚幽而深。”我修习剑术九年有余，剑法愈是精进，对这句要旨体会愈深。");
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
    giNpcPauseBeh("4019");
    giNpcFaceToCurrentPlayer("4019", true);
    giCurrentPlayerFaceToNpc("4019", true);
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("元开：紫英师弟的剑术仙法向来有过人之处，此时我派和妖界的大战一触即发，他却又跑去哪里了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("元开：近日派中很多弟子的修为都一日千里，若那妖界来犯，形势或许不如想像中那般严峻。");
        giRandTalkPush("元开：本派剑法看似纷繁复杂，路数极多，实则万宗归一，只要将“走、转、裹、翻、穿、撩、提、按”八字要诀融会贯通，配合心法，便能练好。 ");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 101400 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giRandTalkPush("元开：我琼华派弟子向来都是正直坦荡之人，怎可收一个贼人入门？此等偷鸡摸狗之徒，根本不配修习本派的剑术仙法！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("元开：现今派中弟子加紧习剑原是好事，但习剑本当适度，切忌练之过劳，否则不仅对修行无益，更可能伤身伤神，最后得不偿失。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("元开：我师从本派肃武长老，如今负责在此指点其他弟子习武，是本派的肃武执事弟子之一。");
        giRandTalkPush("元开：习剑之法，贵在“因剑习义”，心剑合一，剑随意走，此乃我琼华派练剑修仙的要旨。");
        giRandTalkPush("元开：剑术三不传中有云，“无礼无节者不传”，所以剑意也是礼节，剑是修身养性之道。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("明弈：如今妖界与我们开战在即，我相信紫英师叔绝不会在这种时候弃师门而不顾，他、他一定是下山寻找对抗妖界的方法去了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("明弈：不久前卷云台上黑云翻滚，我抬头一看，就看见现在的这个庞然大物了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giRandTalkPush("明弈：那个柳梦璃是怎么了？从房间里冲出来就往卷云台上跑！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120100 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        giRandTalkPush("明弈：掌门刚才召集了很多师叔师伯去议事，元开师伯、静慈师叔、连紫英师叔都被召集去了，看来掌门一定是要宣布重要的事。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("明弈：真是不公平，掌门为什么不叫紫英师叔来指点我的剑法呢？如果是师叔教我的话，我绝对不会像你一样天天偷懒、惹师叔生气的！");
        giRandTalkPush("明弈：我师父人是很好，待我也很不错，可是如今妖界快要来了，他却还是整日沉迷于古剑典籍，一点新的仙术剑法都不教我，真是急死人了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("明弈：我最仰慕紫英师叔的剑法，做梦都想请他指点几招，可惜我一和他说话就紧张……");
        giRandTalkPush("明弈：我师父是个爱剑胜过爱习剑的人，上次他带我看了五灵剑阁里的宝剑，每一把剑的来历他都能说的清清楚楚，毫不含糊！你也想去看的话，五灵剑阁就从南边的桥往东南走，很容易找到～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4020");
    giNpcResumeBeh("4020");
    giPlayerUnLock();
}

void func4021()
{
    giPlayerLock();
    giNpcPauseBeh("4021");
    giNpcFaceToCurrentPlayer("4021", true);
    giCurrentPlayerFaceToNpc("4021", true);
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("璇玉：禁地里面藏的应该是一件能够破除妖界结界的宝物吧？掌门去禁地，一定就是为了那件宝贝！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("璇玉：掌门到后山禁地去干什么呢？难道是禁地里藏着对付妖界的宝物，掌门要亲自去取？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giRandTalkPush("璇玉：刚才那个是梦璃师妹吧？急急忙忙跑去卷云台，还差点撞到我身上！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120100 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        giRandTalkPush("璇玉：我刚才去找师父，没想到师父被掌门召了去，听说掌门还召集了很多其他弟子，看来是有重要的事情要宣布。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("璇玉：这几天我加紧修炼，终于把师父教给我的第一套剑法练好了，师父说我现在手里的这把剑要拿去重铸，等剑铸好了，再教我新的剑法。");
        giRandTalkPush("璇玉：我娘就是被山里的妖怪咬死的，幸好当时师父路过，才救了我一条命。我练好仙术，也要像其他师兄师姐一样下山除妖！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("璇玉：从这儿往上走就是卷云台，听派中的前辈们说，以前经常有弟子上卷云台静思，但自从十九年前本派与妖界在卷云台一场大战之后，就很少有人上去了。");
        giRandTalkPush("璇玉：掌门一直是个很严厉的人，派中弟子都很敬畏她，从来没有人敢违抗她的命令。我入门资历尚浅，每次看见掌门都会觉得有些害怕……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4021");
    giNpcResumeBeh("4021");
    giPlayerUnLock();
}

void func4024()
{
    giPlayerLock();
    giNpcPauseBeh("4024");
    giNpcFaceToCurrentPlayer("4024", true);
    giCurrentPlayerFaceToNpc("4024", true);
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("虚尘：我最近钻研典籍，找到一种剑符，将此符附于剑刃之上，那些妖怪只要被剑刺伤，便会顷刻毙命！这确是我们对抗妖界的利器啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("虚尘：卷云台旁出现的就是妖界，只是那妖界之外有层结界，任凭我用何种符咒都无法破除，因而掌门只让我们先多加戒备，不要随意靠近。");
        giRandTalkPush("虚尘：也许禁地之中藏有我派失传已久的“九天玄女破甲神咒”的咒文符法，掌门此去禁地，正是要取那符法来大破妖界。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("虚尘：西蜀的百姓多使用蜀山仙剑派的符箓，其实蜀山派的符箓哪里比得上我们琼华派的？");
        giRandTalkPush("虚尘：“太上台星，应变无停，驱邪缚魅，保命护身。智慧明净，心神安宁，三魂永久，魄无丧倾。”");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("虚尘：我派向来着重于练剑修仙，因而祥符阁中所收符箓，大都是剑符。所谓剑符，便是符上咒言排布如一利剑，只要是被鬼邪附体，或沾染阴气邪气等引起的病症，都可以剑符驱之。");
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
    giRandTalkRelease();
    if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("灵意：妖界真的来了，过了十九年，我们能打赢吗？……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("灵意：万安殿里有些灵位，听说是十九年前我派和妖界大战时死去的人……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("灵意：万安殿里供奉的，都是琼华派历代先辈，进去祭拜一定要恭敬！");
        giRandTalkPush("灵意：万安殿内供奉着历代掌门用过的法器，那可都是了不起的法宝呢！");
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
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("静离：我在山下除妖之时，常遇穷凶极恶的妖物荼毒生灵，想必这妖界中的妖物更为凶残，只等掌门一声令下，我们定要将它们全部铲除！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("静离：九天玄女娘娘是西王母的弟子，曾授神将轩辕氏兵信神符以破蚩尤，若我派能得玄女娘娘授意，定能大破妖界，全胜而归！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("静离：我梦中见玄女娘娘指点我修习心法，醒来之后，按梦中之法运气修习，果然有所精进！多谢玄女娘娘显灵指点！");
        giRandTalkPush("静离：入门至今我也曾经多次下山除妖，若那妖界来犯，我也绝不会对它们心慈手软！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("静离：我派先祖梦中得九天玄女娘娘指引，创出人剑合一的修仙之法，因而玄女娘娘便是我派尊神，派中弟子皆应供奉参拜。");
        giRandTalkPush("静离：师父传授的心法我似乎不甚明了，因而到此静心思索，希望能借玄女娘娘的智慧，让我快些领会。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("虚止：要是那些妖怪真的杀来，我可用经卷中记载的无上咒法将它们击退！凭我的修为，保证比其他人用剑杀妖更加厉害！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("虚止：我派修习之法，讲求人剑合一之术，但我钻研道家典籍那么多年，却鲜少见典籍之中提起这类修仙之法，想来这是当年玄女娘娘梦中授意的吧？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("虚止：阁中收录之典籍史册我大都已经念过，但觉其编目颠倒，篇章混乱，有些典籍甚至还有残缺，看来我得花些时间将其重写整理，以便日后其他弟子借阅。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("虚止：云经阁乃我派收藏各类道家经书之处，你们是刚入门的弟子，就先从《道德经》念起吧。");
        giRandTalkPush("虚止：掌门要求派中弟子恪守道家修习之法则，因此所有弟子都会在习剑之余来此翻阅典籍，修心养性。");
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
    giCurrentPlayerFaceToNpc("4028", true);
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giNpcFaceToCurrentPlayer("4028", true);
        giRandTalkRelease();
        giRandTalkPush("明觉：原来师父给我的这本《琼华符咒录》是他亲自编撰的，里面这些拗口难背的句子，都是很厉害的降妖之术！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giNpcFaceToCurrentPlayer("4028", true);
        giRandTalkRelease();
        giRandTalkPush("明觉：自从妖界在卷云台边出现，师父就扔给我一本《琼华符咒录》，让我每天都背诵一段出来，这上面写的都是些我看不明白的东西，怎么背呀！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giNpcFaceToCurrentPlayer("4028", true);
        giRandTalkRelease();
        giRandTalkPush("明觉：妖界随时会来，我问师父到底什么时候教我剑术，师父竟然说跟他修习只要背书，不用学剑！我、我能不能去找掌门要求换一个师父啊！");
        giRandTalkPush("明觉：我整日跟着师父只念书，不学剑，如果妖界真的杀来，我岂不是只有被杀的份？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcFaceToNpc("4028", "4027", true);
        giNpcFaceToNpc("4027", "4028", true);
        giTalk("明觉：师父，这本《道德经》我已经背完了。", "");
        giTalk("虚止：很好很好，你将这本《三皇经》拿去，背熟了再来见我。", "");
        giTalk("明觉：……师父，你整天只教我背书，到底什么时候才能让我学剑？", "");
        giTalk("虚止：呵呵，莫要着急，念书是最基础的修行，如果你连书都背不好，怎么修习高深的仙术？", "");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("怀真：听明觉师弟说，其实虚止师叔会一种很厉害的咒法，只要念几句咒，就能杀妖怪！我怎么从来不知道本派还有那么厉害的仙术？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("怀真：妖界都已经出现了，虚止师叔还不打算教明觉师弟剑术！难道真的要等妖界攻来，让明觉师弟被那些妖怪吃了不成？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120100 /* 第二章 / 7-2-3.相争难休 / 送寒器回琼华 */)
    {
        giRandTalkPush("怀真：师父和很多师叔师伯都被掌门召去了，看样子是有重大的事情要说，我猜这一定又是和妖界有关！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("怀真：明觉师弟一直很想练剑，可谁叫他命不好，拜了一个只会读书从不练剑的师父？没有掌门的命令，除了他师父之外，没人能教他剑术。");
        giRandTalkPush("怀真：都说妖界随时会来，这几天师父盯着我练剑，练得我腰酸腿也疼，晚上做梦都在挥剑！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("怀真：师父叫我来云经阁取一本《太玄经》，可虚止师叔却说那本书太旧了，再多翻会坏，若我真的要借，就帮他抄一本出来！我不想抄书啊！");
        giRandTalkPush("怀真：掌门真是个严厉的人，上次我练剑偷懒被她看见了，当下就被罚在最西南的思返谷面壁三天，从那之后我再也不敢偷懒了！");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("虚宜：原来禁地之中另有高人……想来本派为了对抗妖界，从十九年前便已深谋远虑，立下了种种对策。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("虚宜：妖界来犯乃是大事，为何掌门不请青阳、重光两位长老出山相助呢？我听师父说过，他们就隐居在后山清风涧。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("虚宜：太一宫乃是掌门修行之所，若无要事，请勿随意闯入。");
        giRandTalkPush("虚宜：刚入门的弟子，须熟知门规，若有违背，视情形而定，可能会交由本派的正法执事弟子处置。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("虚宜：自从十九年前，本派遭逢巨变，长老之位有不少至今仍然空悬，派中以修为尚浅的年轻弟子居多。");
        giRandTalkPush("虚宜：本派长老分为威仪、肃武、慎行、执剑，所司各有不同，而在这之上，另有正法长老，负责监督其他长老，各长老之下，又设执事弟子，协助长老。");
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
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("璇谨：掌门闭关那么多天了，到底什么时候才能出关啊？");
        giRandTalkPush("璇谨：妖界太平得不寻常！里面那些妖怪一定是在打什么坏主意，我们可得多防着些！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("璇谨：这几天一抬头就能看见妖界，偏偏又杀不进去，害得我一直想着它们什么时候会杀出来，整天都定不下心。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("璇谨：璇铁师妹拜在虚冶师伯门下快一年了，师伯只教她铸剑之法，不久前才开始教她剑术，想来也是因为妖界即将来犯……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("璇谨：承天剑台乃是派中重要的铸剑之所，像你这样新入门的弟子一定还没去过吧？通过这里的法阵可直接过去。");
        giRandTalkPush("璇谨：那日我奉命下山除妖，未料遇到一个道士，还说要卖给我一把好剑，我只看一眼，就知道那是骗人的，琼华派弟子又怎会被这种把戏所骗？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4031");
    giNpcResumeBeh("4031");
    giPlayerUnLock();
}

void func4032()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4032");
    giCurrentPlayerFaceToNpc("4032", true);
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giNpcFaceToCurrentPlayer("4032", true);
        giRandTalkRelease();
        giRandTalkPush("元现：妖界按兵不动，我派弟子不如趁此机会再加紧修炼，无论如何，此战只许胜不许败，不然山下生灵涂炭，我们又如何向十九年前过世的掌门和长老交代呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giNpcFaceToCurrentPlayer("4032", true);
        giRandTalkRelease();
        giRandTalkPush("元现：虚冶师兄的铸剑之术已是不错，与前代执剑长老宗炼亲传的紫英师弟各有千秋，但这二人加起来，只怕也还是比不过宗炼长老啊。");
        giRandTalkPush("元现：剑之五灵，一般是由铸剑的原石所定，但也不全是如此，本阁之中所藏之莫邪剑，同火阁中的干将剑，原出一石，却有两种截然不同的属性。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4032", true);
            giTalk("元现：阁中所存的断水、鱼肠、惊鲵、莫邪、照胆五柄神剑，都是青铜铸成，而如今的剑，却都是百炼青钢。", "");
        }
        else
        {
            giNpcFaceToNpc("4032", "4033", true);
            giNpcFaceToNpc("4033", "4032", true);
            giTalk("元现：明穹，你最近练剑虽很用心，但修为精进的速度却不比从前，是不是遇到什么困难了？", "");
            giTalk("明穹：我只是觉得，越是加紧练剑，从剑中渡来的灵力仙气却越少……师父，这到底是怎么回事？", "");
            giTalk("元现：呵呵，这是好事，因为你的修为已经加深，所以你手中的这柄剑已不合你用了，自己去承天剑台，找你虚冶师伯为你重铸一把新剑吧！", "");
        }
    }
    else
    {
        giNpcFaceToCurrentPlayer("4032", true);
        giRandTalkRelease();
        giRandTalkPush("元现：我派仙法讲求修习剑术以吸取天地元灵，只有使用同自身修为相符的剑器，才能有最好的修习成果。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4032");
    giNpcResumeBeh("4032");
    giPlayerUnLock();
}

void func4033()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4033");
    giCurrentPlayerFaceToNpc("4033", true);
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giNpcFaceToCurrentPlayer("4033", true);
        giRandTalkRelease();
        giRandTalkPush("明穹：我已经把师父传授的剑法都融会贯通，真想马上跟着掌门杀入妖界，让那些妖怪尝尝我的厉害！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giNpcFaceToCurrentPlayer("4033", true);
        giRandTalkRelease();
        giRandTalkPush("明穹：终于有了一把适合我自己用的好剑，如今练剑，再也没有那种灵力不足、怎么练都无法精进的感觉了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giNpcFaceToCurrentPlayer("4033", true);
        giRandTalkRelease();
        giRandTalkPush("明穹：我最喜欢的剑就是此阁之中的“照胆”剑，只是我一个小小的入门弟子，仙法低微，根本无力驾驭此剑。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4033", true);
            giTalk("明穹：师父说我派五大剑阁中所藏之剑，都是古时宝剑真身，除非这些剑自己“认主”，否则谁也无法使用它们。", "");
        }
        else
        {
            giNpcFaceToNpc("4032", "4033", true);
            giNpcFaceToNpc("4033", "4032", true);
            giTalk("明穹：师父，为何这把鱼肠剑只有半截？只有半截的剑也算宝剑？", "");
            giTalk("元现：鱼肠剑乃勇绝之剑，当年专诸以之刺王僚，鱼肠剑刺穿两层狻猊铠甲，刺穿第三层时剑断，然而却还是直直地刺入了王僚的心脏。", "");
            giTalk("明穹：如此说来，鱼肠之所以是名剑，正是因为它虽断却依旧勇往直前，不休不止？", "");
            giTalk("元现：正是此意。", "");
        }
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("静修：掌门已在禁地闭关，看来不日就可练成新的仙法，到时候我们攻入妖界，定然能为十九年前死去的前辈们报仇！");
        giRandTalkPush("静修：我不怕那些妖怪，我只相信邪不胜正，上天不会让我们落败的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("静修：我相信掌门！她一定有万全之策，能带领我们对抗妖界！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("静修：我从小就被师父带上山，记事起就在修习剑法仙术，偶尔也会被掌门派下山去除妖，除此之外就再无其他杂念了。");
        giRandTalkPush("静修：妖界……小时候好像听师父提过，师父说妖界里面有众多残忍的妖孽，十九年前就残杀了许多本派的前辈！连前代掌门和长老都被……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("静修：听说当年宗炼长老曾打造出两把剑，剑气灵力都不输于本阁中收藏的宝剑，但是我却从没见过那两把剑，师父在世的时候也很少提起。");
        giRandTalkPush("静修：琼华派以剑为至尊至祥之物，门下弟子即使不会铸剑，却也懂得识剑、相剑之法。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("元观：我所用的佩剑是“雷剑”，雷灵是妖怪最害怕的东西之一，估计这妖界之中的妖怪也一样会怕！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("元观：禁地之中一定藏着一柄专用来降妖的宝剑！不然为什么要叫禁地呢？那把宝剑说不定威力过大，寻常人连看一眼都承受不了，只有掌门才能驾驭！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("元观：修道之人多半要使用法器，用的久了，便有可能成为法宝，派中大部分弟子虽然都是用剑，但用其他兵器的也不是没有。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("元观：唉……真为这里藏着的宝剑感到可惜！就算是再好再厉害，却从来没人去用，没人用的话，那跟一般士大夫屋子里挂墙用的劣剑，又有什么区别？");
        giRandTalkPush("元观：人有五灵，剑亦有五灵，我派弟子修习仙剑之术，所用之剑除了需同自身修为相匹配之外，自然还需同自身的五灵相同。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("静悟：掌门闭关那么多天，也不见妖界有什么动静，如果我是那些妖怪，就趁现在赶快逃跑，不然掌门出关，就是它们的死期了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("静悟：那妖界入口黑气腾腾，一看就知道是不祥之地，其中的妖怪就算再凶残邪恶也不稀奇了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("静悟：我所用的剑，是仿此阁中大夏龙雀的外形而铸，其实世间大多宝剑，都已不是真身了，后人仿制的东西，即使再不错，又哪里还有真身的灵气呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("静悟：听，阁中是不是有龙吟虎啸之声？这是阁中所藏“腾空剑”发出的声音哦～");
        giRandTalkPush("静悟：我喜欢剑，但不喜欢铸剑。会练剑也是因为喜欢剑，如果不好好练，修为不提升，就不能用更好的剑嘛～");
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
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("元安：妖界至今只是与我派对峙，到底要到何时才能打破僵局？难道打破僵局之时，就是血流成河之日？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("元安：掌门吩咐大家不要靠近妖界，看来暂时还不打算进攻？……为什么一定要打呢？难道没有办法以仁义说退妖界？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("元安：大家本来安安定定的，该什么时候练功就什么时候练功，该什么时候诵经就什么时候诵经，可一听说妖界要来，大家从早到晚都练剑，已经很少有人来诵经了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("元安：在五灵剑阁之中，此处的剑气最为祥和，那是由于主天下仁道的湛卢剑，正存于此处，湛卢剑虽能削金断玉，无坚不摧，本身却没有丝毫杀气～");
        giRandTalkPush("元安：相传湛卢剑乃“君有道，剑在侧，国兴旺。君无道，剑飞弃，国破败。”如此说来，既然此剑存于我派，我派必然能够日益壮大。");
        giRandTalk();
        giRandTalkRelease();
    }
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
    giRandTalkRelease();
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("怀望：妖界一直留在卷云台不走，一定有诡计！我们真应该先下手为强，等他们攻过来，岂不是被动了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("怀望：师父说我的资质好，如果用心修行，大概五十年以后就能超过现在的长老，可是五十年耶？五十年一过，我都变成白胡子的老头了！");
        giRandTalkPush("怀望：妖界已经来了！听说里面的妖怪又厉害又凶狠！所以我要趁现在还没开战的时候，更加努力地修炼！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("怀望：琼华派的剑术真的好厉害，我入门也不算久，每日修习，就感到体内真气充盈，身子也比以前轻了许多。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("怀望：我一直很奇怪，为什么剑阁里放着这么多好剑，却从来没有人用呢？难道所谓的宝剑就是只能看，不能用的……");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("怀忍：我这几日完全不能平心静气，只想着能快点与妖界对上，痛痛快快地打一场，即使战死，也比现在这样干着急的好！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("怀忍：我已做好与妖界殊死相搏的准备，就算为此丢了性命，只要其他同门能击退妖界，我也算死得其所了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("怀忍：只要一想到妖界即将来犯，我就心烦意乱，师父让我到处走走，平平心气再练剑，不然一定会走火入魔。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("怀忍：修仙讲求炼气化神，我派以剑修仙，其实也是通过习剑来吸收天地元灵。");
        giRandTalkPush("怀忍：听说蜀山仙剑派也有剑阁，但其中收藏，不能与我派相提并论。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("元志：紫英师弟以前常来剑台，最近却不出现了，难道真的像有些弟子传言的那样，他被逐出师门了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("元志：掌门派了许多弟子把守禁地，但我记得，以前禁地似乎是无人把守的，其中的秘密怕是只有掌门与长老知道。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("元志：修仙之事，其实也是各凭资质。只有天资极高，且心无杂念者才能修炼成仙。如我这般天资不高之人，即使再怎样用心，尽这一生，恐怕也难窥天道。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("元志：虚冶师兄的铸剑之术是我派中数一数二的，但我所用的佩剑仍是由自己亲手打造，我常来此处，也是为了向虚冶师兄多讨教些铸剑之术。");
        giRandTalkPush("元志：我入门多年，或许是资质不佳，最近几年来修为一直在道家第五重境界徘徊，无论如何修习，也难有寸进。");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("虚冶：与妖界开战在即，届时长剑的损毁定然不计其数，我一定要再多铸一些，以备不时之需！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("虚冶：铸剑之术需配合地利，我派有灵力守护，四季如春，外邪不侵，灵气充盈，是铸剑的最佳场所。");
        giRandTalkPush("虚冶：一日之中，辰时乃铸剑的最佳时辰，通常我都是在辰时将金石或旧剑入炉，开始冶炼的。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("虚冶：近日派中弟子都在加紧修习，前来我处要我帮忙重铸他们手中长剑的，也不在少数。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("虚冶：你是紫英师弟的师侄，铸剑之事自然可以由他出马，就不须我班门弄斧了。");
        giRandTalkPush("虚冶：五灵剑阁之中所藏的很多青铜宝剑，其铸造之法都十分高明。只是古人造剑之术大都失传，如今只能看着这些剑，却很难从中参悟出什么来了。");
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
    giCurrentPlayerFaceToNpc("4042", true);
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giNpcFaceToCurrentPlayer("4042", true);
        giRandTalkRelease();
        giRandTalkPush("明炼：妖界和琼华派对峙已久，所有弟子都在备战，我和师妹虽然只是以铸剑术见长，但要斩妖除魔，我们也是义不容辞的！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giNpcFaceToCurrentPlayer("4042", true);
        giRandTalkRelease();
        giRandTalkPush("明炼：师父好像很中意璇铁师妹带回来的并州剑，不过师父也说那剑只是材质好，铸剑的人功夫不怎么样。");
        giRandTalkPush("明炼：为了和妖界对抗，很多同门都到承天剑台来重铸宝剑，师父、师妹和我三个人加起来，好不容易才忙完那些事。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giNpcFaceToCurrentPlayer("4042", true);
        giRandTalkRelease();
        giRandTalkPush("明炼：最近一直帮师父铸剑，现在我的铸剑术也有很大的精进～看，我身上的这把剑，就是自己铸的，连师父都夸我呢！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcFaceToNpc("4042", "4043", true);
        giNpcFaceToNpc("4043", "4042", true);
        giTalk("明炼：嘻嘻，我乃执剑执事弟子——座下的大弟子明炼是也～师傅铸剑的功夫，我已经学了七、八分了～", "");
        giTalk("璇铁：明炼你少骗人了！谁都知道你才刚入门两年～整日跟在师父身边就知道偷懒～上次还把师父好不容易找来的一块铜石给炼坏了！", "");
        giTalk("明炼：嘿嘿，璇铁师妹，你别总是揭我老底呀～而且上次那块铜石，后来还不是让师父给炼成了一把好剑？", "");
        giTalk("璇铁：我只是说实话而已！师父炼得好是师父的本事，你毁了好石头，是你闯的祸，少把这两件事儿扯到一块儿～", "");
    }
    giNpcResetDir("4042");
    giNpcResumeBeh("4042");
    giPlayerUnLock();
}

void func4043()
{
    giPlayerLock();
    giNpcPauseBeh("4043");
    giCurrentPlayerFaceToNpc("4043", true);
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giNpcFaceToCurrentPlayer("4043", true);
        giRandTalkRelease();
        giRandTalkPush("璇铁：师父说自己用的剑最好亲手铸造，因为只有自己才最明白自己想用怎样的剑。");
        giRandTalkPush("璇铁：最近都见不到紫英师叔了，有人说他是因为触犯门规被掌门罚下山了……我不相信！紫英师叔才不是这样的人！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giNpcFaceToCurrentPlayer("4043", true);
        giRandTalkRelease();
        giRandTalkPush("璇铁：上次我替师父去并州买剑，师父看了我买来的剑，说是铁很好，铸剑的技艺却不怎么样，说来也是，那些人的铸剑术怎会比得上师父呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giNpcFaceToNpc("4042", "4043", true);
        giNpcFaceToNpc("4043", "4042", true);
        giTalk("璇铁：师父终于教我琼华剑术了！师父还说，等我这套剑法练好了，就让我下山去看看，不过条件就是要去并州帮他买些刀剑……", "");
        giTalk("明炼：这你就不懂了～师父想让你下山去帮他买剑，所以教了你御剑，又怕你不会武艺遭人欺负，所以才教你别的剑术呀～", "");
        giTalk("璇铁：说了半天，师父教我武艺，还是为了帮他买剑啊？那并州的刀剑难道比师父造的更好吗？", "");
        giTalk("明炼：这我就不太清楚了，听闻并州的刀剑号称和春秋时的铸剑大师欧冶子所造的神剑一般厉害！师父一定是听了这种传闻，所以才很想见识一番。", "");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4043", true);
        giRandTalkRelease();
        giRandTalkPush("璇铁：我拜在虚冶师父门下，师父给我取了个名字叫“璇铁”，说什么音同“玄铁”，是上好的造剑之材，可、可哪有女孩子家叫这种名字的呀！");
        giRandTalkPush("璇铁：虚冶师父人很和气，待我们也好，就是整日沉迷铸剑炼铁，教了我御剑术之后，就只教辨石采石、熔炼铸造，再也没教过我别的剑法！");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giRandTalkPush("静空：现在大家都等着掌门出关，好带领我们一起对抗妖界，为十九年前死去的前辈们报仇！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giRandTalkPush("静空：妖界既然来了，我们更是要平心静气，不可乱了方寸，给那些妖物可趁之机！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giRandTalkPush("静空：如今本派弟子的佩剑，大多出自虚冶师兄之手。新入门的弟子会遵师命来此选剑。若已铸好的剑中没有合用的，虚冶师兄便会根据新弟子的资质性格，为他量身定做一把剑。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("静空：虽说紫英师弟的铸剑之法得了前代执剑长老的真传，可能比虚冶师兄更胜一筹，但他平时不太亲自铸剑，其他同门好像也更喜欢找虚冶师兄帮助铸剑。");
        giRandTalkPush("静空：承天剑台以太极为形，分为极寒和极热两边，一边用来熔铁，另一边用来淬剑，若是修为不深的弟子来了这里，单是冷热交加便受不住了。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4044");
    giNpcResumeBeh("4044");
    giPlayerUnLock();
}

void func4049()
{
    giPlayerLock();
    giNpcPauseBeh("4049");
    giNpcFaceToCurrentPlayer("4049", true);
    giCurrentPlayerFaceToNpc("4049", true);
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giTalk("璇慈：掌门闭关，妖界亦久无动静，我看派中有些师兄弟已经有些着急，却不知越是要紧的时刻，越是需要保持心宁如水，“以不变应万变”才是上上之策。", "");
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giTalk("璇慈：妖界降临势必为祸人间，我们修道中人虽不喜争斗，但斩妖除魔却是我们份内之事，为了天下苍生，琼华派也绝不可在妖界面前退却！", "");
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("璇慈：上回见到新入门的菱纱师妹在剑舞坪习剑，身手十分灵巧迅捷，一套双剑舞得非常漂亮，却似乎并非紫英师叔所授……", "");
    }
    else
    {
        giTalk("璇慈：所谓“心宁如水，方可映世间万物”，琼华派习剑之要也和修道一样，需心宁气和，才能通过手中长剑，让自身魂魄与天地灵气融为一体。", "");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giTalk("静贤：妖界现形多日，却始终没有动静，不知它们到底在做何打算，如今掌门已经闭关，余下弟子更须小心应对。", "");
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giTalk("静贤：很多弟子嚷着要杀进妖界为派中前辈血仇，却不知情、爱、怨、仇皆是妄念，修道中人应当心怀苍生，而不是只为一己之私。", "");
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("静贤：年轻弟子容易心浮气躁，实乃修道之大忌。琼华派的习剑心法有助于平心静气，如果你感到无法安静下来，不如回房打坐，多修心法。", "");
    }
    else
    {
        giTalk("静贤：习剑、修道，虽是一动一静，但都需心神宁和，如能进入“物我两忘”的境界，无论是剑术境界，还是仙法修为，都能一日千里般精进。", "");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giTalk("灵思：为什么师兄师姐都说妖界很可怕呢？虽然现在风大了一点，但是那个妖界……好像也没什么呀？", "");
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giTalk("灵思：上回，我问师父，既然不能杀生，为什么却要杀妖怪？结果师父大发雷霆，罚我在思返谷面壁了整整三天……我、我到底哪里做错了呢……", "");
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("灵思：杀妖怪是行善积德……可是师父教导我的戒律，不是说不能杀生吗？好奇怪哦……灵思不明白，你能明白吗？", "");
    }
    else
    {
        giTalk("灵思：师父说修仙要没有“欲求”……可是灵思很想变成仙人，踩着云在天上飞，这个……算不算师父说的“欲求”呢？", "");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giTalk("静澈：不管那妖界到底想做什么，妖孽留在世上总是祸患！就算它们现在没有敌意，也不能保证它们日后不会为祸人间！", "");
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giTalk("静澈：哼！这妖界简直胆大包天，竟敢欺到我琼华派的头上来！若是让它们大摇大摆地走出来为祸人间，我昆仑琼华派的颜面何存？！", "");
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("静澈：斩妖除魔是修行之人应尽之责，我昆仑琼华派虽然不像蜀山仙剑派那样经常入世除妖，但弟子偶有下山，遇到妖孽也会尽力除之。", "");
    }
    else
    {
        giTalk("静澈：听闻蜀山仙剑派有锁妖塔，门下弟子入世除妖，却仅是将妖投入塔中而已。依我看，妖孽留在世上终是祸害，该全都杀了才是，何必如此麻烦？", "");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giTalk("元贤：许多前辈都死于十九年前的那场大战，如今我琼华派中，弟子的修为大都并不精深，否则的话，区区妖界，又何足为惧？！", "");
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giTalk("元贤：即使是神兵利刃，如果没有与之匹配的人来使用，也和凡铁无异。虽说宝剑难求，然而真正懂得养剑用剑的人，却也未必比宝剑更多。", "");
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("元贤：派中的师叔师伯大都已经过世，即使仍然健在，也常年云游在外，很少露面。", "");
    }
    else
    {
        giTalk("元贤：我派“人剑合一”的修仙之术，对人和剑的五灵相配极其倚重，对新入门的弟子来说，头等大事就是选择自己的佩剑。", "");
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
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giTalk("明幽：我也想像明炼那样亲手铸造自己的宝剑，可惜师父却说如今和妖界的大战在即，没有时间让我去琢磨铸剑之法……", "");
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giTalk("明幽：听说本派之中流传着一种特殊的文字，乃是九天玄女娘娘亲传，专用以记载铸剑秘法的，即使是派中的弟子，也很少有人能读懂。", "");
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("明幽：派中弟子大都用剑，但也有用其他兵刃修行的，比如怀见师弟用的是一柄药锄。不过那位新入门的柳师妹，却用一架箜篌当作兵刃，实在非常罕见。", "");
    }
    else
    {
        giTalk("明幽：看你手中这柄长剑，质地奇异，剑芒流转，一定是把来头不小的宝剑！只不过剑身却有些污浊……你是不是很久没有拭剑了？", "");
    }
    giNpcResetDir("4054");
    giNpcResumeBeh("4054");
    giPlayerUnLock();
}

void func4056()
{
    giPlayerLock();
    giNpcPauseBeh("4056");
    giNpcFaceToCurrentPlayer("4056", true);
    giCurrentPlayerFaceToNpc("4056", true);
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giTalk("明光：妖界已经现形，大家都那么紧张，紫英师叔却还是经常下山，真不知道他到底在干什么！", "");
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giTalk("明光：我琼华派弟子一直都是见妖便除的，如今这么大一个妖界竟然欺到我们头上来，掌门却下令不得靠近，这到底是为什么？！", "");
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("明光：上回你们私自下山，惹得紫英师叔很不高兴，没想到掌门却没有处置你们……", "");
    }
    else
    {
        giTalk("明光：派中不收弟子已经很久了，倒是不知掌门为何要破例召见你们，还收你们入门？", "");
    }
    giNpcResetDir("4056");
    giNpcResumeBeh("4056");
    giPlayerUnLock();
}

void func4055()
{
    giPlayerLock();
    giNpcPauseBeh("4055");
    giNpcFaceToCurrentPlayer("4055", true);
    giCurrentPlayerFaceToNpc("4055", true);
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giTalk("明尘：等掌门出关，我们就要和妖界正面交锋了吧？如果这次能顺利打退妖界，而且我也能活下来，我一定要下山，回播仙镇上的家里看看爹娘……", "");
    }
    else if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giTalk("明尘：我上仙山修行，为的就是能像天神一样保护山下的人，就算我死了，也绝不让妖怪伤及播仙镇分毫！", "");
    }
    else if (global_mvar >= 101400 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giTalk("明尘：好像很多师兄弟都很在意韩师妹在上山前的行止，但那都是过去的事情了，韩师妹在派中虽然经常闯祸，但也没惹到他们，他们干嘛非要赶走人家？", "");
    }
    else if (global_mvar >= 91300 /* 第二章 / 6-3-1.义结金兰 / 禁地交图 */)
    {
        giTalk("明尘：韩师妹他们年纪小，又是刚刚入门，稍微闯一下祸也是情有可原的，希望紫英师叔不要总是罚他们才好……", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("明尘：你们是从播仙镇来的吗？镇上的人现在过得好不好？自从上山之后，我还从来没有回去看过呢……");
        giRandTalkPush("明尘：小的时候仰慕山上的天神，我一个人上了仙山，没想到真的被师父收入了门下，只不过山上住的却不是天神，和山下人想的完全不一样，呵呵～");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4055");
    giNpcResumeBeh("4055");
    giPlayerUnLock();
}

void func4100()
{
    if (global_mvar <= 120400 && var_shop024 == 0 /* 第三章 / 7-4-2.仙妖乱 / 兄弟话别 */)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giFlashOutBlack(1.0, true, true);
        giPlayerSetPos(0, -71.9, -5.1, -207.7);
        giPlayerSetAng(0, 278.0);
        giSetNpcVisible("4023", true);
        giCameraPrepare("NPC001");
        giCameraRunSingle("003", true);
        giFlashInBlack(1.0, true);
        giTalk("璇枢：师父整天盯着我练剑，练得我烦也烦死了！这卷云台平常没什么人来，我偷偷溜上来喘口气，师父一定找不着我～", "");
        giTalk("元隐：璇枢！我让你在剑舞坪习剑，你怎么跑这里来偷懒？！", "");
        giCameraRunSingle("001", true);
        giCameraRunSingle("002", false);
        giNpcWalkTo("4023", -222.8, -7.1, -102.2, true);
        giNpcSetAng("4023", 182.0);
        giTalk("璇枢：啊！师父！我……我练剑时有些地方想不通，所以找个地方静一静！", "");
        giTalk("元隐：此地灵气混乱、煞气颇重，不要长时间留在这里。跟师父下去吧，有不明白的地方，为师的教你便是。", "");
        giTalk("璇枢：可、可我想自己静思一会！师父你先下去吧，等我想明白了就来。", "");
        giTalk("元隐：跟你说了不要待在卷云台上，如果一定要静思，就去思返谷！", "");
        giTalk("璇枢：啊？思返谷？！那我、我还是跟师父你下去，向师父讨教就行了……", "");
        giWait(0.5);
        giNpcWalkTo("4023", -192.6, -7.1, -19.4, false);
        giNpcWalkTo("4022", -192.6, -7.1, -19.4, false);
        giWait(2.0);
        giFlashOutBlack(1.0, true, true);
        var_shop024 = 1;
        giNpcEndMove("4022");
        giSetNpcVisible("4022", false);
        giSetNpcVisible("4023", false);
        giFlushTailYAngle();
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giFlashInBlack(1.0, true);
        giPlayerUnLock();
    }
}

void func5001()
{
    giPlayerLock();
    giNpcPauseBeh("4048");
    giNpcFaceToCurrentPlayer("4048", true);
    giCurrentPlayerFaceToNpc("4048", true);
    if (var_shop009 != 0)
    {
        if (var_shop009 != 1)
        {
            giStartTradeSystem("shop004", "");
        }
        else
        {
            if (giCheckPackProperty(3066, 1))
            {
                giTalk("虚合：哈哈，《钉耙秘笈》！真是太好啦！师侄你为寻此物，想必是费了一番功夫吧？日后若需什么灵丹妙药，便到龙芽道丹来看看，师叔我定然不会亏待于你！", "");
                giDelProperty(3066, 1, true);
                giWait(2.0);
                var_shop009 = 2;
                gi2DSoundPlay("WA06", 1);
                giShowHint("开启新交易品", 0.5, 0.15);
                giWait(2.0);
            }
            giStartTradeSystem("shop004", "");
        }
    }
    else
    {
        giStartTradeSystem("shop004", "Buiness_Q06_5001");
    }
    giNpcResetDir("4048");
    giNpcResumeBeh("4048");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("4045");
    giNpcFaceToCurrentPlayer("4045", true);
    giCurrentPlayerFaceToNpc("4045", true);
    giStartTradeSystem("shop014", "");
    giNpcResetDir("4045");
    giNpcResumeBeh("4045");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("4046");
    giNpcFaceToCurrentPlayer("4046", true);
    giCurrentPlayerFaceToNpc("4046", true);
    giStartTradeSystem("shop014", "");
    giNpcResetDir("4046");
    giNpcResumeBeh("4046");
    giPlayerUnLock();
}

void func5004()
{
    giPlayerLock();
    giNpcPauseBeh("4047");
    giNpcFaceToCurrentPlayer("4047", true);
    giCurrentPlayerFaceToNpc("4047", true);
    giStartTradeSystem("shop014", "");
    giNpcResetDir("4047");
    giNpcResumeBeh("4047");
    giPlayerUnLock();
}

void func5005()
{
    giPlayerLock();
    giNpcPauseBeh("4057");
    giNpcFaceToCurrentPlayer("4057", true);
    giCurrentPlayerFaceToNpc("4057", true);
    if (var_shop030 != 0)
    {
        if (var_shop030 != 1)
        {
            giStartTradeSystem("shop024", "");
        }
        else
        {
            if (giCheckEquipInInventory(3509))
            {
                giTalk("明锻：玉柄龙吟剑！真的是玉柄龙吟剑！这把剑果然是以奇石所铸，其造剑技艺，不在我师父之下！太感谢了！这几张图谱是我和师弟师妹一起参详所得，送给你当谢礼吧！", "");
                giRemoveEquipment(3509, true);
                giWait(2.0);
                giAddPrescription(8106, true);
                giWait(2.0);
                giAddPrescription(8108, true);
                giWait(2.0);
                giAddPrescription(8119, true);
                giWait(2.0);
                giAddPrescription(8120, true);
                giWait(2.0);
                giAddPrescription(8155, true);
                giWait(2.0);
                giAddPrescription(8156, true);
                giWait(2.0);
                var_shop030 = 2;
                giWait(2.0);
            }
            giStartTradeSystem("shop024", "");
        }
    }
    else
    {
        giStartTradeSystem("shop024", "Buiness_Q06_5005");
    }
    giNpcResetDir("4057");
    giNpcResumeBeh("4057");
    giPlayerUnLock();
}

void Buiness_Q06_5001()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("我那怀见徒儿用惯了药锄，我特地为他创了一套锄法。以剑法入锄法虽然可行，但两者到底有所区别，若能找到一本<colour red=255 green=187 blue=0 alpha=255>《钉耙秘笈》</colour><dc0>，于我新创锄法必然大有助益！师侄你若有闲，能否帮我找一本《钉耙秘笈》来？</dc0><br/><dc0>你愿意帮我去找吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        var_shop009 = 1;
    }
}

void Buiness_Q06_5005()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("我听说有<colour red=255 green=187 blue=0 alpha=255>一把剑名“玉柄龙吟”</colour><dc0>，挥剑便有龙吟清啸，十分神奇了得。如果能借来一看，说不定能铸出更好的宝剑。如果你找到这把剑，能拿来此处给我看看吗？</dc0><br/><dc0>你愿意帮我去找吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        var_shop030 = 1;
    }
}

void func7001()
{
    float current_player_pos_x = 0.0;
    float current_player_pos_z = 0.0;
    float local_6 = 0.0;

    giPlayerLock();
    giIMMBegin();
    current_player_pos_x = giPlayerCurrentGetPosX();
    current_player_pos_z = giPlayerCurrentGetPosZ();
    giPlayerCurrentWalkTo(current_player_pos_x, 283.0, local_6, true);
    giPlayerUnLock();
}

void func7002()
{
    float current_player_pos_x = 0.0;
    float current_player_pos_z = 0.0;

    giPlayerLock();
    giIMMBegin();
    current_player_pos_x = giPlayerCurrentGetPosX();
    current_player_pos_z = giPlayerCurrentGetPosZ();
    giIMMEnd();
    giPlayerCurrentWalkTo(current_player_pos_x, 283.0, current_player_pos_z, true);
    giPlayerUnLock();
}

void func7003()
{
    float current_player_pos_x = 0.0;
    float current_player_pos_z = 0.0;

    giPlayerLock();
    giIMMBegin();
    current_player_pos_x = giPlayerCurrentGetPosX();
    current_player_pos_z = giPlayerCurrentGetPosZ();
    giIMMEnd();
    giPlayerCurrentWalkTo(current_player_pos_x, 283.0, current_player_pos_z, true);
    giPlayerUnLock();
}

void func7004()
{
    float current_player_pos_x = 0.0;
    float current_player_pos_z = 0.0;

    giPlayerLock();
    giIMMBegin();
    current_player_pos_x = giPlayerCurrentGetPosX();
    current_player_pos_z = giPlayerCurrentGetPosZ();
    giIMMEnd();
    giPlayerCurrentWalkTo(current_player_pos_x, 283.0, current_player_pos_z, true);
    giPlayerUnLock();
}

void func7500()
{
    float current_player_pos_y = 0.0;

    current_player_pos_y = giPlayerCurrentGetPosY();
    if (giPlayerCurrentGetPosY() < 0.0)
    {
        giSetMinimapLevel(1);
    }
    else
    {
        giSetMinimapLevel(0);
    }
}
