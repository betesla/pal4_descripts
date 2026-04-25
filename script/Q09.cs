// Structured PAL4 reconstruction for Q09.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q09_Q09_init()
{
    if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giSetNpcVisible("40161", true);
    }
    if (global_mvar < 90500 /* 隐香寻人 */)
    {
        giSetObjectVisible("entrance2", false);
        giSetObjectVisible("entrance3", true);
    }
    else
    {
        giSetObjectVisible("entrance2", true);
        giSetObjectVisible("entrance3", false);
    }
    if (global_mvar == 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        func2001();
    }
    if (global_mvar == 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        func2002();
    }
    if (global_mvar <= 140100 && npc_e == 2 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        func3001();
    }
    giArenaReadyRestore();
}

void Q09_N06_init()
{
    if (global_mvar < 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("4015", false);
        giSetNpcVisible("4016", false);
        giSetNpcVisible("4028", false);
        giArenaReadyRestore();
    }
}

void Q09_N09c_init()
{
    if (global_mvar < 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("281", true);
        giArenaReadyRestore();
    }
}

void Q09_N10b_init()
{
    if (global_mvar < 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giSetNpcVisible("40151", false);
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("40151", true);
        giArenaReadyRestore();
    }
}

void Q09_N11a_init()
{
    if (global_mvar != 91000 /* 第二章 / 6-2-3.万家同庆 / 夜市花灯 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giNpcSetAng("MN002", 334.0);
        giArenaReadyRestore();
    }
}

void func1001()
{
    giArenaLoad("Q09", "N01", "", true);
    giPlayerCurrentSetPos(-9.287807, 0.18609, 128.62198);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(-2122.607, 375.54358, -1826.6333);
    giPlayerCurrentSetAng(37.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q09", "n02", "N02a", true);
    giPlayerCurrentSetPos(-3.125885, 0.114094, 82.32782);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q09", "N01", "", true);
    giPlayerCurrentSetPos(-140.66122, 130.22214, -120.27545);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q09", "N02", "N02b", true);
    giPlayerCurrentSetPos(-3.125885, 0.114094, 82.32782);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q09", "N01", "", true);
    giPlayerCurrentSetPos(142.98541, 130.22214, -122.8136);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("Q09", "N03", "", true);
    giPlayerCurrentSetPos(-6.47584, 0.113779, 56.293682);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(-2230.7803, 279.6721, -534.41626);
    giPlayerCurrentSetAng(109.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("Q09", "N05", "", true);
    giPlayerCurrentSetPos(0.207852, 0.104124, 74.03581);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(1475.2817, 337.1493, -792.2172);
    giPlayerCurrentSetAng(241.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("Q09", "N06", "", true);
    giPlayerCurrentSetPos(117.4992, 0.300018, -1.979863);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1012()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(736.3193, 703.4747, -2052.4019);
    giPlayerCurrentSetAng(340.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1013()
{
    giArenaLoad("Q09", "N09", "N09a", true);
    giPlayerCurrentSetPos(115.87037, 1.0, -6.925385);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1014()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(-3672.9648, 282.72937, -924.7274);
    giPlayerCurrentSetAng(131.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1015()
{
    giArenaLoad("Q09", "N09", "N09b", true);
    giPlayerCurrentSetPos(115.87037, 1.0, -6.925385);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(-3054.8245, 308.44574, -1244.5721);
    giPlayerCurrentSetAng(348.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1017()
{
    giArenaLoad("Q09", "N09", "N09c", true);
    giPlayerCurrentSetPos(115.87037, 1.0, -6.925385);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1018()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(-1013.8833, 327.9304, -1466.571);
    giPlayerCurrentSetAng(87.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1019()
{
    if (global_mvar != 90900 /* 第二章 / 6-2-1.万家同庆 / 回到即墨 */)
    {
        giArenaLoad("Q09", "N10", "N10a", true);
        giPlayerCurrentSetPos(0.630434, 0.055927, 62.860065);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(3, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("Q09", "N10", "N10a", true);
        func2003();
    }
}

void func1020()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(-226.50018, 279.6253, -1475.6106);
    giPlayerCurrentSetAng(80.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1021()
{
    if (global_mvar != 90900 /* 第二章 / 6-2-1.万家同庆 / 回到即墨 */)
    {
        giArenaLoad("Q09", "N10", "N10a", true);
        giPlayerCurrentSetPos(-50.76055, 0.091368, -51.74451);
        giPlayerCurrentSetAng(0.1);
        giCameraSetMode(3, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("Q09", "N10", "N10a", true);
        func2003();
    }
}

void func1022()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(-514.6144, 283.84103, -1489.2979);
    giPlayerCurrentSetAng(268.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1023()
{
    giArenaLoad("Q09", "N10", "N10b", true);
    giPlayerCurrentSetPos(0.630434, 0.055927, 62.860065);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1024()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(1106.9326, 438.15488, -1157.3243);
    giPlayerCurrentSetAng(230.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1025()
{
    giArenaLoad("Q09", "N10", "N10b", true);
    giPlayerCurrentSetPos(-50.76055, 0.091368, -51.74451);
    giPlayerCurrentSetAng(0.1);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1026()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(1289.39, 438.49725, -973.5719);
    giPlayerCurrentSetAng(132.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1027()
{
    if (global_mvar != 90901 /* 第二章 / 6-2-2.万家同庆 / 上楼取图 */)
    {
        giArenaLoad("Q09", "N11", "N11a", true);
        giPlayerCurrentSetPos(-70.32538, 1.510431, 46.8051);
        giPlayerCurrentSetAng(90.0);
        giCameraSetMode(3, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("Q09", "N11", "N11a", true);
        func2004();
    }
}

void func1028()
{
    if (global_mvar != 91000 /* 第二章 / 6-2-3.万家同庆 / 夜市花灯 */)
    {
        giArenaLoad("Q09", "Q09", "", true);
        giPlayerCurrentSetPos(-245.87228, 341.61984, -1612.1509);
        giPlayerCurrentSetAng(345.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("Q09", "Q09Y", "", true);
        func2005();
    }
}

void func1029()
{
    giArenaLoad("Q09", "N11", "N11b", true);
    giPlayerCurrentSetPos(-70.32538, 1.510431, 46.8051);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1030()
{
    giArenaLoad("Q09", "Q09", "", true);
    giPlayerCurrentSetPos(1243.661, 499.15552, -1210.8973);
    giPlayerCurrentSetAng(272.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1031()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-2842.9844, 157.4746, 585.0203, true);
    giPlayerCurrentSetAng(139.0);
    giSetPortrait("102C", true);
    giTalk("云天河：屋子里没人，还是不要进去为好。", "");
    giPlayerUnLock();
}

void func1032()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-53.862263, 0.100002, 1.000633, true);
    giPlayerCurrentSetAng(0.0);
    giSetPortrait("102C", true);
    giTalk("云天河：还是不要进去为好。", "");
    giPlayerUnLock();
}

void func1033()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(563.2346, -3.245329, 528.57794, true);
    giPlayerCurrentSetAng(257.0);
    giSetPortrait("102C", true);
    giTalk("云天河：屋子里没人，还是不要进去为好。", "");
    giPlayerUnLock();
}

void func1034()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(566.43665, -23.542336, 1207.8035, true);
    giPlayerCurrentSetAng(331.0);
    giSetPortrait("102C", true);
    giTalk("云天河：屋子里没人，还是不要进去为好。", "");
    giPlayerUnLock();
}

void func1035()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90500 /* 隐香寻人 */)
    {
        if (global_mvar == 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
        {
            giFlashOutBlack(1.5, true, true);
            giArenaLoad("M13", "1", "", true);
        }
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去狐仙居  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去狐仙居</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, 2411.6062, 568.238, -2215.612, true);
                giPlayerSetDir(leader_player_id, 306.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(0, true);
                giPlayerUnLock();
            }
            else
            {
                giShowWorldMap();
            }
        }
        else if (global_mvar > 140100 || npc_e != 1 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
        {
            giArenaLoad("M13", "1", "", true);
            giPlayerCurrentSetPos(-1995.0, -182.0, 4668.0);
            giPlayerCurrentSetAng(180.0);
            giCameraSetMode(5, true);
            giArenaReady();
        }
        else
        {
            giFlashOutBlack(1.5, true, true);
            giArenaLoad("M13", "1", "", true);
        }
        giPlayerUnLock();
    }
}

void func1036()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    giPlayerLock();
    giSelectDialogAddItem("1.御剑飞行  ");
    giSelectDialogAddItem("2.什么都不做");
    giSelectDialogSetDefaultSelect(1);
    giShowSelectDialog("              准备<colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>吗？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        leader_player_id = giPlayerGetLeader();
        giPlayerWalkTo(leader_player_id, -3543.5164, 219.42624, -2397.742, true);
        giPlayerSetDir(leader_player_id, 65.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giPlayerUnLock();
    }
    else
    {
        giShowWorldMap();
    }
    giPlayerUnLock();
}

void func2001()
{
    if (global_mvar == 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetNpcVisible("4033", false);
        giSetObjectVisible("entrance1", false);
        giPlayerSetPos(0, -3366.4058, 219.0762, -2030.1519);
        giPlayerSetAng(0, 49.0);
        giPlayerSetPos(1, -3359.7588, 219.0762, -1971.5242);
        giPlayerSetAng(1, 73.0);
        giPlayerSetPos(2, -3416.0688, 219.0762, -2052.2083);
        giPlayerSetAng(2, 46.0);
        giPlayerSetPos(3, -3417.34, 219.0762, -1974.1602);
        giPlayerSetAng(3, 70.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giNpcPauseBeh("4001");
        giNpcSetPos("4001", -3201.1697, 219.1803, -1693.0015);
        giNpcSetAng("4001", 248.0);
        giSetNpcVisible("MN003", true);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.3, false);
        giArenaReady();
        giWait(0.699999988079071);
        giCameraRunSingle("012", false);
        giWait(7.0);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：哇～张灯结彩的，好像有什么庆典！", "43526");
        giCameraWait();
        giCameraRunSingle("002", true);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("102M", false);
        giTalk("云天河：让我想起了粽子！哪里、在哪里？", "43527");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：…………", "43528");
        giCameraRunSingle("003", false);
        giWait(1.5);
        giIMMBegin();
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giIMMEnd();
        giNpcWalkTo("MN001", -3219.346, 219.0761, -1914.1755, false);
        giNpcWalkTo("MN002", -3180.5552, 219.0761, -1941.7466, false);
        giWait(2.5);
        giPlayerWalkTo(0, -3285.4233, 219.0762, -1958.7302, true);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：你，听过有个叫光纪寒图的东西吗？", "43529");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giNpcEndMove("MN001");
        giNpcEndMove("MN002");
        giIMMBegin();
        giPlayerSetPos(0, -3285.4233, 219.0762, -1958.7302);
        giPlayerSetAng(0, 69.0);
        giPlayerSetPos(1, -3285.2712, 219.0762, -1902.7748);
        giPlayerSetAng(1, 101.0);
        giPlayerSetPos(2, -3307.9268, 219.0762, -2005.6057);
        giPlayerSetAng(2, 50.0);
        giPlayerSetPos(3, -3328.7476, 219.0762, -1947.4749);
        giPlayerSetAng(3, 74.0);
        giNpcSetPos("MN001", -3188.5947, 219.0762, -1907.6262);
        giNpcSetAng("MN001", 262.0);
        giNpcSetPos("MN002", -3152.7383, 219.0762, -1935.0737);
        giNpcSetAng("MN002", 260.0);
        giCameraRunSingle("004", false);
        giIMMEnd();
        giTalk("青年甲：哎呀，别和我说话了，我得赶去狐仙庙，要是不快点把贡品送过去，可不晓得会出什么事！", "43530");
        giTalk("青年乙：对，要是误了时辰，惹得狐仙不高兴就惨了……", "43531");
        giWait(0.6000000238418579);
        giSetNpcVisible("MN005", true);
        giNpcWalkTo("MN005", -3267.3015, 219.3401, -1664.3792, false);
        giNpcWalkTo("MN001", -3272.3538, 219.1059, -1797.8075, false);
        giNpcWalkTo("MN002", -3202.2478, 219.0762, -1789.3328, false);
        giCameraRunSingle("006", true);
        giWait(0.6000000238418579);
        giIMMBegin();
        giPlayerSetPos(0, -3350.761, 219.0762, -1966.7235);
        giPlayerSetAng(0, 4.0);
        giPlayerSetPos(1, -3409.8774, 219.0762, -1939.7894);
        giPlayerSetAng(1, 41.0);
        giPlayerSetPos(2, -3401.0674, 219.0762, -2023.4242);
        giPlayerSetAng(2, 16.0);
        giPlayerSetPos(3, -3462.2534, 219.0762, -1979.753);
        giPlayerSetAng(3, 35.0);
        giIMMEnd();
        giNpcEndMove("MN001");
        giNpcEndMove("MN002");
        giNpcEndMove("MN005");
        giIMMBegin();
        giNpcSetDir("MN001", 27.0, false);
        giNpcSetDir("MN002", 352.0, false);
        giNpcSetDir("MN003", 75.0, false);
        giNpcSetDir("4001", 279.0, false);
        giIMMEnd();
        giNpcDoAction("MN005", "J01", 1, false);
        giSetPortrait("220C", true);
        giTalk("夏元辰：你们！你们有谁看见我女儿莲宝了？！", "43532");
        giNpcEndAction("MN005", true);
        giCameraRunSingle("005", false);
        giTalk("青年甲：我说夏书生，你自己的女儿当然要自己顾好，丢了怎么还来问我们？", "43533");
        giSetPortrait("220A", true);
        giTalk("夏元辰：刚刚、刚刚她还跟在我身边，一晃眼就不见了……", "43534");
        giTalk("屠夫张：不急，俺帮你一起找找！", "43535");
        giTalk("青年乙：……今天可是即墨要办庆典的大日子，所有人都要给狐仙贺寿，为什么偏偏这个时候……", "43536");
        giTalk("青年乙：要是惹恼了狐仙，我们全部人都得遭殃……", "43537");
        giSetPortrait("220C", true);
        giTalk("夏元辰：狐仙……说不定、说不定就是他把莲宝带走了！", "43538");
        giTalk("屠夫张：啥？！你说小莲宝是被狐仙……那、那俺可能帮不了你了……", "43539");
        giTalk("青年乙：……夏书生啊，狐仙大寿你是不是没诚心庆贺？不然这倒霉的事，怎会落在你头上……", "43540");
        giTalk("老者：元辰，莲宝她真是被狐仙带走了？", "43541");
        giNpcSetDir("MN005", 107.0, true);
        giWait(0.5);
        giNpcDoAction("MN005", "C09", 1, false);
        giSetPortrait("220C", false);
        giTalk("夏元辰：我……我不知道、我只是猜的……", "43542");
        giSetPortrait("220C", false);
        giTalk("夏元辰：莲宝她向来很乖，不会随便乱跑……", "43543");
        giTalk("老者：……你说是，那就是了……你好像总能感应到什么，大多时候也都灵验了，大伙儿都是靠你才躲过了不少祸事啊……", "43544");
        giTalk("老者：可是这回……你让大伙儿怎么帮忙……", "43545");
        giTalk("屠夫张：……", "43546");
        giTalk("青年乙：……", "43547");
        giNpcSetDir("MN005", 202.0, true);
        giWait(1.0);
        giNpcSetDir("MN005", 155.0, true);
        giSetPortrait("220C", true);
        giTalk("夏元辰：你们别为难，我自己去把莲宝找回来！", "43548");
        giTalk("老者：唉………… ", "43549");
        giWait(0.5);
        giCameraRunSingle("008", true);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：……狐仙带走那个书生的女儿，已经够怪了，难道是抢亲？其他人也不帮他找，更是怪上加怪……", "43550");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：你们看那个人，急得脸都惨白了……我想帮他一起找找看……", "43551");
        giPlayerEndAction(2);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：理应如此！", "43552");
        giPlayerEndAction(3);
        giIMMBegin();
        giNpcSetAng("MN005", 27.0);
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("4001", false);
        giIMMEnd();
        giIMMBegin();
        giCameraRunSingle("009", true);
        giPlayerSetPos(0, -3204.9062, 219.0788, -1832.7305);
        giPlayerSetPos(1, -3243.4248, 219.0788, -1836.339);
        giPlayerSetPos(2, -3300.9668, 219.0799, -1841.1023);
        giPlayerSetPos(3, -3403.7363, 219.0799, -1823.7355);
        giIMMEnd();
        giPlayerWalkTo(3, -3317.3247, 219.0762, -1719.7035, false);
        giPlayerWalkTo(1, -3262.774, 219.0762, -1745.6891, false);
        giPlayerWalkTo(2, -3283.0002, 219.0762, -1732.8892, false);
        giPlayerWalkTo(0, -3226.5247, 219.0762, -1755.5682, false);
        giCameraRunSingle("010", false);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giPlayerEndMove(2);
        giPlayerEndMove(3);
        giIMMBegin();
        giPlayerSetAng(0, 346.0);
        giPlayerSetAng(1, 7.0);
        giPlayerSetAng(2, 20.0);
        giPlayerSetAng(3, 40.0);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：这位公子——", "43553");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcSetDir("MN005", 207.0, true);
        giSetPortrait("220A", true);
        giTalk("夏元辰：你们是……？", "43554");
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：我们有事探访，初来乍到，恰巧见到你……你的女儿走失了，不知能帮上什么忙？", "43555");
        giPlayerEndAction(2);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我等乃是昆仑琼华派的弟子，略通剑术，有什么事请尽管开口！", "43556");
        giSetPortrait("220C", true);
        giTalk("夏元辰：竟是修道之人！这太好了！", "43557");
        giSetPortrait("220C", true);
        giTalk("夏元辰：我女儿莲宝十有八九是被隐香山的狐仙带走了，诸位若是愿意，请随我去救救她，<colour red=255 green=187 blue=0 alpha=255>隐香山就在狐仙庙的东北</colour><dc0>！</dc0>", "43558");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：可是，那个狐仙为什么要抓走你女儿呢？狐仙不是应该佑护一方的吗？", "43559");
        giNpcSetDir("MN005", 169.0, false);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcDoAction("MN005", "C09", 1, false);
        giSetPortrait("220C", true);
        giTalk("夏元辰：这……恐怕一言难尽，眼下我只想快点找到莲宝，看她安然无恙！", "43560");
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：不用多说了，一切等找到你的女儿，再说也不迟。", "43561");
        giPlayerEndAction(2);
        giNpcDoAction("MN005", "J02", 1, false);
        giSetPortrait("220C", true);
        giTalk("夏元辰：谢谢，大恩大德，夏元辰铭记在心！", "43562");
        giNpcEndAction("MN005", true);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("MN005", false);
        giSetNpcVisible("4001", true);
        giNpcResetDir("4001");
        giNpcResumeBeh("4001");
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giSetNpcVisible("4033", true);
        giSetObjectVisible("entrance1", true);
        global_mvar = 90300; // 0x000160BC, 第二章 / 6-1-1.为祸一方 / 书生寻女
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetObjectVisible("entrance2", false);
        giPlayerSetPos(0, 2358.6287, 544.1628, -2158.9812);
        giPlayerSetAng(0, 312.0);
        giPlayerSetPos(1, 2334.162, 548.428, -2203.2615);
        giPlayerSetAng(1, 332.0);
        giPlayerSetPos(2, 2386.311, 569.8336, -2251.3838);
        giPlayerSetAng(2, 319.0);
        giPlayerSetPos(3, 2409.1628, 563.7145, -2203.6736);
        giPlayerSetAng(3, 286.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giNpcPauseBeh("4001");
        giNpcSetPos("4001", 2121.2722, 502.1881, -1869.605);
        giNpcSetPos("MN001", 2201.0527, 501.4373, -1881.3538);
        giNpcSetPos("MN002", 2074.2747, 508.5467, -1914.9688);
        giNpcSetPos("MN003", 2157.2383, 498.5118, -1905.809);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("MN003", true);
        giSetNpcVisible("MN006", true);
        giSetNpcVisible("MN007", true);
        giSetNpcVisible("4019", false);
        giSetNpcVisible("4018", false);
        giSetNpcVisible("4021", false);
        giNpcSetAng("MN001", 178.0);
        giNpcSetAng("MN002", 142.0);
        giNpcSetAng("MN003", 183.0);
        giNpcSetAng("4001", 166.0);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("003", true);
        giFlashInBlack(2.2, false);
        giArenaReady();
        giPlayerWalkTo(0, 2206.23, 506.252, -1994.2611, false);
        giWait(0.5);
        giPlayerWalkTo(1, 2129.867, 512.7651, -2012.8846, false);
        giWait(0.5);
        giPlayerWalkTo(3, 2205.1707, 518.1685, -2047.4674, false);
        giWait(0.5);
        giPlayerWalkTo(2, 2139.395, 522.8633, -2076.7822, false);
        giCameraRunSingle("002", false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 312.0, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 1.0, false);
        giPlayerEndMove(3);
        giPlayerSetDir(3, 315.0, true);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 352.0, false);
        giCameraWait();
        giWait(1.0);
        giCameraRunSingle("004", true);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：怎么了……他们那种眼神，不会又像上回在太平村一样吧……", "43659");
        giCameraRunSingle("006", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：呃……我、我什么也没做……", "43660");
        giPlayerEndAction(0);
        giCameraRunSingle("005", true);
        giTalk("青年甲：你们真的把狐仙打跑了？！", "43661");
        giSetPortrait("102E", true);
        giTalk("云天河：是、是啊……", "43662");
        giTalk("青年乙：恩公！！", "43663");
        giPlayerDoAction(1, "J02", 1, false);
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("102D", true);
        giTalk("云天河：啊？！", "43664");
        giCameraRunSingle("007", true);
        giTalk("老者：恩公你有所不知，那狐仙强迫我们每年供奉他，却只会做些阴损的事……", "43665");
        giTalk("老者：向他祈祷风平浪静，他就让海上风浪大起，向他祈祷风调雨顺，他就带来大旱……我们、我们都是苦不堪言呐……", "43666");
        giTalk("屠夫张：俺们几个正要上山帮忙找小莲宝，没想到夏书生带着小莲宝回来啦，还说你们打跑了狐仙，俺真不敢相信自己的耳朵！一定要再来问问才能放心！", "43667");
        giCameraRunSingle("006", true);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：咦？你们打算上山？可你们不是很怕那只臭狐狸吗？", "43668");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("008", true);
        giTalk("屠夫张：……俺、俺们当然还是怕，但是想来想去，总觉得心里不踏实，做人不能只顾自己啊……", "43669");
        giTalk("屠夫张：所以俺们也只有豁出去了！总好过一辈子心里都有个疙瘩。", "43670");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：你们……？", "43671");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("009", false);
        giTalk("青年乙：是啊，再说……夏书生帮过我们不少忙，要是不管他，不就变忘恩负义了……", "43672");
        giTalk("青年甲：我、我是怕死狐仙了，去隐香山惊扰大仙，这事我平时连想都不敢想，但我更不愿意被人骂不讲义气！", "43673");
        giTalk("屠夫张：对对对！俺是没读过啥书，但也明白做人要讲义气，俺还喊上了邻居王家和孙家的人，他们也打算上山去咧！不过，哪晓得你们已经把狐仙打跑了，呵呵……", "43674");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：嘻嘻，没关系，能有这份心，已经很了不起了，也不枉夏书生那样帮你们。", "43675");
        giPlayerEndAction(1);
        giTalk("青年乙：……那狐仙……他还会再回来吗？", "43676");
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：各位安心，他元气大伤，应会收敛许多。", "43677");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：我们还说了狠话吓那只臭狐狸，他现在一定怕死了，哈～", "43678");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("青年乙：真、真的吗？！亲耳听到这话，我就放心了！", "43679");
        giTalk("青年乙：这天大的好事，大伙儿快去告诉其他人！", "43680");
        giTalk("青年甲：对对对，让所有人都知道！", "43681");
        giNpcWalkTo("MN007", 2124.7046, 505.4178, -1670.5232, false);
        giNpcWalkTo("MN001", 2124.7046, 505.4178, -1670.5232, false);
        giNpcWalkTo("MN006", 2009.5232, 508.6967, -1714.9739, false);
        giNpcWalkTo("MN002", 1896.9738, 529.015, -1865.2815, false);
        giNpcWalkTo("MN003", 1896.9738, 529.015, -1865.2815, false);
        giWait(3.5);
        giNpcWalkTo("4001", 2141.8376, 502.1881, -1948.2529, false);
        giCameraRunSingle("010", false);
        giNpcEndMove("4001");
        giPlayerSetDir(0, 300.0, false);
        giPlayerSetDir(2, 350.0, false);
        giTalk("老者：恩公，你们是即墨的大恩人，请一定要留下来，看看今晚的花灯啊！", "43682");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：老伯，我们一定去～我最喜欢漂亮的花灯了！", "43683");
        giPlayerEndAction(1);
        giTalk("老者：好、好好～", "43684");
        giNpcWalkTo("4001", 2039.1481, 511.6198, -1865.5304, false);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetDir(0, 310.0, false);
        giPlayerSetDir(1, 350.0, false);
        giPlayerSetDir(2, 340.0, false);
        giPlayerSetDir(3, 320.0, false);
        giIMMEnd();
        giWait(0.6000000238418579);
        giPlayerDoAction(0, "J13", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：呵呵，这，就是爹说过的行侠仗义吗？", "43685");
        giWait(0.6000000238418579);
        giIMMBegin();
        giPlayerSetAng(2, 10.0);
        giPlayerSetAng(3, 343.0);
        giPlayerSetAng(1, 71.0);
        giCameraRunSingle("011", false);
        giIMMEnd();
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104J", true);
        giTalk("韩菱纱：是哦～和某些人在太平村的遭遇也差太多了～～", "43686");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(0, 248.0, true);
        giSetPortrait("102K", false);
        giTalk("云天河：这样的，比较好～", "43687");
        giSetPortrait("104J", true);
        giTalk("韩菱纱：废话，有谁喜欢被人又打又骂的……", "43688");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：唉，妖害人不稀奇，料不到连仙也会为祸一方，今日所见，实在令人心惊。", "43689");
        giPlayerEndAction(3);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：<colour red=255 green=187 blue=0 alpha=255>……我们快些去夏家吧，</colour><dc0>不然天可要黑了。</dc0>", "43690");
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN003", false);
        giSetNpcVisible("MN006", false);
        giSetNpcVisible("MN007", false);
        giSetNpcVisible("4019", true);
        giSetNpcVisible("4018", true);
        giSetNpcVisible("4021", true);
        giSetObjectVisible("entrance2", true);
        giNpcSetPos("4001", -3215.0095, 224.4759, -1550.4702);
        giNpcResetDir("4001");
        giNpcResumeBeh("4001");
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 90900; // 0x00016314, 第二章 / 6-2-1.万家同庆 / 回到即墨
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2003()
{
    if (global_mvar == 90900 /* 第二章 / 6-2-1.万家同庆 / 回到即墨 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -42.9392, 1.3925, -37.8811);
        giPlayerSetAng(0, 42.0);
        giPlayerSetPos(1, 20.8638, 1.3925, -8.1284);
        giPlayerSetAng(1, 354.0);
        giPlayerSetPos(2, -23.3518, 1.3925, -7.8965);
        giPlayerSetAng(2, 40.0);
        giPlayerSetPos(3, -67.5766, 1.3925, -4.7951);
        giPlayerSetAng(3, 66.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MN001", true);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.0);
        giSetPortrait("220B", false);
        giTalk("夏元辰：你们来了？", "43691");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：夏书生，我该收回在山上讲的话啰！", "43692");
        giNpcSetDir("MN001", 183.0, true);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：那些人还是很不错的嘛，有心去找你和小莲宝～", "43693");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("220A", false);
        giTalk("夏元辰：是啊，我早说过，无论如何都不会怪他们。", "43694");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：哎，同样是仙，你和臭狐狸对人的态度也差太多了。", "43695");
        giPlayerEndAction(1);
        giSetPortrait("220A", false);
        giTalk("夏元辰：……因为，我很喜欢人，才会愿意隐瞒身份，在人间过上百年、千年……六界之中，虽以神、魔最强，但天上寂寥千载、瑶宫寒苦，又怎及得上人与人相依的暖意。 ", "43696");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……", "43697");
        giCameraRunSingle("003", true);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：……山神，是不是就可以长生不老呢？凡人到底要怎样，才能活得更久一点？", "43698");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("220A", false);
        giTalk("夏元辰：仙的寿命虽然动辄千年，却依然会有走到尽头的一天，凡人由生到死不过百年，自然会羡慕仙人，但是比起蜉蝣蝼蚁，人又何尝不是寿命长久？", "43699");
        giWait(0.5);
        giSetPortrait("220A", false);
        giTalk("夏元辰：阳寿天定，强弱自分，这原本就是所谓的“天道”啊，为何要去打破它？", "43700");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：可是……", "43701");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("001", false);
        giNpcSetAng("MN001", 215.0);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("220A", false);
        giTalk("夏元辰：好了，不说这些了，以几位资质，修道定然有成，说不定假以时日会与我一样位列仙班呢。", "43702");
        giSetPortrait("220B", false);
        giTalk("夏元辰：你们，<colour red=255 green=187 blue=0 alpha=255>随我去楼上吧</colour><dc0>。</dc0>", "43703");
        giNpcWalkTo("MN001", 12.0, 1.0, 77.0, false);
        giWait(0.30000001192092896);
        giCameraRunSingle("002", true);
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：……", "43704");
        giSetNpcVisible("MN001", false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：菱纱，别心急，你村里的人……你担心的那件事，一定会有办法的。", "43705");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, -25.7664, 1.3925, -26.8267);
        giPlayerSetAng(0, 49.0);
        giPlayerSetPos(2, -32.5903, 1.3925, 5.3731);
        giPlayerSetAng(2, 98.0);
        giPlayerSetPos(3, 38.3964, 1.3925, 27.253);
        giPlayerSetAng(3, 239.0);
        giCameraRunSingle("004", false);
        giIMMEnd();
        giPlayerEndAction(1);
        giPlayerSetDir(1, 288.0, true);
        giSetPortrait("102A", true);
        giTalk("云天河：对，可能你问他，他刚好不知道……", "43706");
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：没什么啦，你们俩不用担心，我才没那么容易放弃！", "43707");
        giPlayerEndAction(1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：村里人？……到底何事？", "43708");
        giPlayerSetDir(1, 22.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：……别问，好吗？", "43709");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：其实连天河、梦璃也不是很清楚，不过总有一天我会全告诉你们的，但不是现在……", "43710");
        giPlayerEndAction(1);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……我知道了，若是有能帮上忙的，你一定要说出来。", "43711");
        giPlayerEndAction(3);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：好，一定。", "43712");
        giPlayerEndAction(1);
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giCameraSetMode(3, true);
        global_mvar = 90901; // 0x00016315, 第二章 / 6-2-2.万家同庆 / 上楼取图
        giPlayerUnLock();
        giFlashInBlack(0.5, true);
    }
}

void func2004()
{
    if (global_mvar == 90901 /* 第二章 / 6-2-2.万家同庆 / 上楼取图 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -19.3766, 1.5104, -47.3662);
        giPlayerSetAng(0, 352.0);
        giPlayerSetPos(1, -8.1652, 1.5104, -19.3815);
        giPlayerSetAng(1, 346.0);
        giPlayerSetPos(2, -71.901, 1.5104, -36.3884);
        giPlayerSetAng(2, 38.0);
        giPlayerSetPos(3, -50.1598, 1.5104, -74.0752);
        giPlayerSetAng(3, 9.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.0);
        giSetPortrait("220B", false);
        giTalk("夏元辰：你们来看，这便是光纪寒图。", "43713");
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("MO001", true);
        giSetObjectVisible("Jeffect001", true);
        giIMMEnd();
        giPlayerSetDir(1, 300.0, false);
        giPlayerSetDir(0, 332.0, true);
        giWait(1.5);
        giSetPortrait("220A", false);
        giTalk("夏元辰：相传此乃冬神遗落人间之物，我也是偶然得到。", "43714");
        giPlayerDoAction(1, "J16", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：闪闪的、好漂亮！一看就是了不起的宝贝！", "43715");
        giPlayerEndAction(1);
        giNpcSetDir("MN001", 171.0, true);
        giSetPortrait("220A", false);
        giTalk("夏元辰：看来，女孩子都差不多，静兰也最喜欢这个呢。", "43716");
        giPlayerSetDir(1, 346.0, false);
        giPlayerSetDir(0, 3.0, true);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：静兰？", "43717");
        giSetPortrait("220B", false);
        giTalk("夏元辰：啊、她、她是我的恋人。", "43718");
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：嘻，你脸红了～她一定是个很好的人吧？", "43719");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("220A", false);
        giTalk("夏元辰：静兰她又温柔又漂亮……", "43720");
        giSetPortrait("220A", false);
        giTalk("夏元辰：以前，我住在即墨附近的山里，每到夜晚，我就把光纪寒图展开，置于山巅，看起来犹如星尘下凡一般，那是静兰最喜欢的光景。", "43721");
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giWait(0.5);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：那她现在在哪儿？没有和你住一起吗？", "43722");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giNpcSetDir("MN001", 227.0, true);
        giWait(0.6000000238418579);
        giSetPortrait("220A", false);
        giTalk("夏元辰：她？她已经过世几百年了……", "43723");
        giSetPortrait("107E", true);
        giTalk("柳梦璃：……！！", "43724");
        giSetPortrait("220A", false);
        giTalk("夏元辰：……说不定都投胎转世、几度轮回，我是地仙，而她只是一介凡人，人仙殊途啊……", "43725");
        giSetPortrait("107A", true);
        giTalk("柳梦璃：对不起……让你想起伤心事……", "43726");
        giWait(0.5);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("220A", false);
        giTalk("夏元辰：不必介意。至少那一世我和静兰相守到老，我一直陪着她，看着她归于尘土。", "43727");
        giSetPortrait("220A", false);
        giTalk("夏元辰：世间多少有情人磨难重重，终究有缘无份，我和静兰已足够幸福，又怎敢再有更多奢求？", "43728");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：呵呵，对啊，只要这辈子过得开心就好，其他许多事想也没用～ ", "43729");
        giWait(0.4000000059604645);
        giNpcSetDir("MN001", 185.0, true);
        giWait(0.5);
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("220B", false);
        giTalk("夏元辰：小兄弟倒是豁达得很～", "43730");
        giSetPortrait("220A", false);
        giTalk("夏元辰：来，这光纪寒图你们收好。", "43731");
        giWait(0.5);
        giSetPortrait("219A", true);
        giTalk("莲宝：爹爹……星星、莲宝喜欢……", "43732");
        giNpcSetDir("MN001", 169.0, true);
        giWait(0.5);
        giSetPortrait("220B", false);
        giTalk("夏元辰：莲宝，你也喜欢光纪寒图吗？", "43733");
        giWait(0.4000000059604645);
        giNpcSetDir("MN002", 351.0, true);
        giWait(0.5);
        giNpcDoAction("MN002", "C08", 1, false);
        giWait(1.5);
        giSetPortrait("220A", false);
        giTalk("夏元辰：可这些哥哥姐姐是我们的恩人，爹爹一定要报答他们，莲宝听话好不好？", "43734");
        giWait(0.699999988079071);
        giNpcDoAction("MN002", "C08", 1, false);
        giWait(1.600000023841858);
        giSetPortrait("220A", false);
        giTalk("夏元辰：乖孩子～", "43735");
        giIMMBegin();
        giPlayerSetPos(0, -16.0842, 1.5104, -30.0693);
        giPlayerSetAng(0, 334.0);
        giPlayerSetPos(1, 0.4942, 1.5104, 3.2426);
        giPlayerSetAng(1, 306.0);
        giPlayerSetPos(3, -44.0778, 1.5104, -38.4789);
        giPlayerSetAng(3, 359.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……抱歉，君子不夺人所好，实是事出有因——", "43736");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcSetDir("MN001", 207.0, true);
        giSetPortrait("220A", false);
        giTalk("夏元辰：没关系，光纪寒图留在我身边并无用处，倒不如赠给急需之人。", "43737");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：多谢！", "43738");
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：……！", "43739");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("220B", false);
        giTalk("夏元辰：啊！我倒忘了，光纪寒图性属阴冷，寻常人碰触恐有不适，入手便有天寒地冻之感……", "43740");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：那怎么办？是不是要找东西把它包起来再拿？", "43741");
        giPlayerDoAction(1, "C07", 1, false);
        giWait(1.0);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：呀——！好冰……", "43742");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcSetDir("MN001", 171.0, true);
        giSetPortrait("220A", false);
        giTalk("夏元辰：姑娘切莫动手，女子体寒，更不可执拿此物，待我想想如何是好……", "43743");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：还好……不会冷啊。", "43744");
        giPlayerSetDir(1, 239.0, false);
        giPlayerSetDir(2, 86.0, false);
        giPlayerSetDir(3, 62.0, false);
        giNpcSetDir("MN001", 186.0, true);
        giSetPortrait("220A", false);
        giTalk("夏元辰：小兄弟你……！", "43745");
        giSetPortrait("220A", false);
        giTalk("夏元辰：难道……竟不会觉得寒气渗骨？！", "43746");
        giIMMBegin();
        giSetObjectVisible("MO001", false);
        giSetObjectVisible("Jeffect001", false);
        giIMMEnd();
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giAddProperty(3111, 1, true);
        giWait(2.5);
        giPlayerSetDir(0, 10.0, false);
        giPlayerSetDir(1, 352.0, false);
        giPlayerSetDir(2, 31.0, false);
        giPlayerSetDir(3, 14.0, false);
        giWait(1.600000023841858);
        giPlayerDoAction(0, "J17", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：还好吧……摸上去是比其他东西要凉一点，不过也就是一点点。", "43747");
        giSetPortrait("220A", false);
        giTalk("夏元辰：……这、这可太好了！", "43748");
        giSetPortrait("220A", false);
        giTalk("夏元辰：我虽不知为何，这位小兄弟天赋异禀，居然不畏寒气，但光纪寒图可以由他拿着，就不成问题了。", "43749");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：是吗？呵呵～", "43750");
        giPlayerEndAction(0);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：（……少得意，真不晓得你到底吃什么长大的，连这么冷都受得了……）", "43751");
        giSetPortrait("220A", false);
        giTalk("夏元辰：我看这位小兄弟似乎擅使弓箭，这把“开元追月弓”不如一并送给你吧。", "43752");
        giWait(0.5);
        giSetObjectVisible("MO002", true);
        giIMMBegin();
        giPlayerSetDir(0, 342.0, false);
        giPlayerSetDir(1, 300.0, false);
        giPlayerSetDir(3, 360.0, false);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J02", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：啊？这么好的弓，送给我？", "43753");
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("220B", false);
        giTalk("夏元辰：无妨，我不懂使弓，赠给小兄弟，也算是为它找到真正的主人。", "43754");
        giSetPortrait("102K", true);
        giTalk("云天河：哈、哈哈！谢谢！", "43755");
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.5);
        giSetObjectVisible("MO002", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giAddProperty(3249, 1, true);
        giWait(2.5);
        giPlayerAddSkill(0, 5504, true);
        giWait(2.5);
        giIMMBegin();
        giPlayerSetDir(0, 10.0, false);
        giPlayerSetDir(1, 352.0, false);
        giPlayerSetDir(3, 14.0, false);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……感激不尽，既然此间事了，我们便告辞了。", "43756");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giNpcSetDir("MN001", 206.0, true);
        giWait(0.5);
        giNpcDoAction("MN001", "J02", 1, false);
        giSetPortrait("220A", false);
        giTalk("夏元辰：保重，今日一别，不知何时有缘再见了。", "43757");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giPlayerDoAction(1, "C07", 1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：夏书生，你告诉其他人了吗？你要离开即墨的事……", "43758");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.30000001192092896);
        giNpcSetDir("MN001", 171.0, true);
        giWait(0.5);
        giSetPortrait("220A", false);
        giTalk("夏元辰：待会儿我想带莲宝<colour red=255 green=187 blue=0 alpha=255>去夜市看花灯</colour><dc0>，到时候再说吧，还真是有点舍不得……</dc0>", "43759");
        giSetPortrait("104M", true);
        giTalk("韩菱纱：舍不得就再回来看看大家嘛，等莲宝变成大姑娘，把他们都吓一跳！", "43760");
        giSetPortrait("220B", false);
        giTalk("夏元辰：哈哈，到时候我还是老样子，一点没变，才真的让人吓一跳。", "43761");
        giSetPortrait("104B", true);
        giTalk("韩菱纱：嘻～那倒也是。", "43762");
        giFlashOutBlack(1.5, true, true);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giCameraSetMode(3, true);
        giNpcSetAng("MN002", 334.0);
        giNpcResetDir("MN001");
        global_mvar = 91000; // 0x00016378, 第二章 / 6-2-3.万家同庆 / 夜市花灯
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2005()
{
    if (global_mvar == 91000 /* 第二章 / 6-2-3.万家同庆 / 夜市花灯 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -134.3295, 278.8892, -1501.9304);
        giPlayerSetAng(0, 50.0);
        giPlayerSetPos(1, -132.7005, 278.8892, -1462.8456);
        giPlayerSetAng(1, 60.0);
        giPlayerSetPos(2, -171.5145, 279.5085, -1457.4014);
        giPlayerSetAng(2, 72.0);
        giPlayerSetPos(3, -180.1913, 279.5085, -1421.8102);
        giPlayerSetAng(3, 92.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giSetObjectVisible("sound004", false);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("003", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giNpcWalkTo("MN001", -49.6717, 275.8441, -1424.1523, false);
        giNpcWalkTo("MN002", -27.8758, 274.4037, -1446.644, false);
        giNpcEndMove("MN001");
        giNpcSetDir("MN001", 234.0, true);
        giNpcEndMove("MN002");
        giNpcSetDir("MN002", 267.0, true);
        giNpcDoAction("MN001", "C07", -1, false);
        giTalk("男孩：大哥哥、大姐姐～这些东西送给你们！", "43763");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", false);
        giSetObjectVisible("MO001", true);
        giSetObjectVisible("MO002", true);
        giCameraRunSingle("004", false);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：咦？你们是谁家的小孩？干嘛要送东西给我们啊？", "43764");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("少年：我听祝爷爷说了，你们是打跑狐仙的大英雄！", "43765");
        giTalk("少年：这些东西本来都是给狐仙的供品，现在通通送给你们～", "43766");
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：我们不缺这些，你们还是自己留下吧。", "43767");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：小朋友～狐仙跑了，是因为他自己做坏事遭报应，不用特地来谢我们。", "43768");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("006", true);
        giNpcDoAction("MN001", "C09", 1, false);
        giTalk("少年：不、不行，祝爷爷说一定要知恩图报，不然不算男子汉！", "43769");
        giNpcEndAction("MN001", true);
        giTalk("少年：小海，我、我们走。", "43770");
        giNpcWalkTo("MN001", 251.2683, 274.5948, -1344.2021, false);
        giWait(1.5);
        giTalk("男孩：大哥哥、大姐姐，等我长大以后，也要做像你们这样的英雄！帮很多很多的人！", "43771");
        giWait(0.5);
        giNpcWalkTo("MN002", 251.2683, 274.5948, -1344.2021, false);
        giWait(2.0);
        giIMMBegin();
        giPlayerSetAng(0, 51.0);
        giPlayerSetPos(1, -137.356, 278.8892, -1461.1978);
        giPlayerSetAng(1, 78.0);
        giPlayerSetPos(2, -189.9577, 278.8892, -1471.0289);
        giPlayerSetAng(2, 74.0);
        giPlayerSetPos(3, -183.1786, 279.5085, -1415.4491);
        giPlayerSetAng(3, 97.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：呵呵，有鱼～能烤来吃哦～", "43772");
        giIMMBegin();
        giPlayerSetDir(1, 170.0, false);
        giPlayerSetDir(2, 118.0, false);
        giPlayerSetDir(3, 143.0, false);
        giIMMEnd();
        giWait(0.699999988079071);
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：谢谢你们～～", "43773");
        giWait(0.5);
        giPlayerDoAction(1, "J14", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：呆子！人家一番心意，你居然只注意到鱼……", "43774");
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetPos(0, -138.1382, 278.9457, -1499.0583);
        giPlayerSetAng(0, 36.0);
        giPlayerSetPos(1, -114.7356, 278.8892, -1450.5088);
        giPlayerSetAng(1, 14.0);
        giPlayerSetPos(2, -200.9347, 278.8892, -1464.2117);
        giPlayerSetAng(2, 33.0);
        giPlayerSetPos(3, -181.9041, 279.5085, -1424.6874);
        giPlayerSetAng(3, 28.0);
        giCameraSetDistOptEnable(false);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：你们看～那些花灯，是不是就是白天说的——", "43775");
        giCameraRunSingle("007", true);
        giWait(2.0);
        giFlashOutBlack(2.0, true, true);
        giScriptMusicPause();
        giPlayMovie("9K.bik");
        giOpenMovieFlag(5);
        giScriptMusicResume();
        giScriptMusicPlay("P18", 2, 2.5, 2.5);
        giSetObjectVisible("sound004", true);
        giCameraRunSingle("005", true);
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giSetObjectVisible("MO001", false);
        giSetObjectVisible("MO002", false);
        giPlayerLock();
        giIMMBegin();
        giCameraSetDistOptEnable(false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 1617.4359, 527.3745, -1218.063);
        giPlayerSetAng(0, 354.0);
        giPlayerSetPos(1, 1588.7761, 527.3742, -1179.8849);
        giPlayerSetAng(1, 349.0);
        giPlayerSetPos(2, 1632.9985, 525.3743, -1172.8837);
        giPlayerSetAng(2, 345.0);
        giPlayerSetPos(3, 1668.7135, 527.3745, -1159.3015);
        giPlayerSetAng(3, 323.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giIMMEnd();
        giPlayerDoAction(2, "C10", 0, false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giCameraRunSingle("003", false);
        giWait(2.0);
        giSetPortrait("102B", false);
        giTalk("云天河：……我的心里，头一次有这样暖暖的感觉，像是什么东西在跳动一样。", "43776");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：原来……让别人开心，自己也能这么开心啊～", "43777");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giCameraRunSingle("004", false);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：为侠者一生所求，除魔卫道，可不正是为了此情此景、为了这些人脸上的笑容？", "43778");
        giPlayerEndAction(3);
        giPlayerSetDir(0, 39.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：嗯，你说的对，紫英！", "43779");
        giPlayerEndAction(0);
        giPlayerSetEmotion(3, "105_wx");
        giIMMBegin();
        giPlayerSetAng(3, 233.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：你不叫我“师叔”了？", "43780");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 46.0);
        giPlayerSetAng(1, 85.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：哈，忘了——", "43781");
        giWait(0.5);
        giSetPortrait("105B", true);
        giTalk("慕容紫英：无妨。", "43782");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 327.0);
        giPlayerSetAng(0, 39.0);
        giPlayerSetAng(1, 65.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giCameraRunSingle("009", false);
        giSetPortrait("105B", false);
        giTalk("慕容紫英：云天河，我以前或许错看了你，只当你是个任性妄为之人，如今看来，你和菱纱、还有梦璃，却当真有副侠义心肠，抛却辈份之别，让我说不出的敬重！", "43783");
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：嘻～看来即墨的花灯庆典真不得了，连冰块脸都被融化了。", "43784");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(3, 247.0, false);
        giPlayerSetDir(0, 331.0, true);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：菱纱，别这么说，我觉得紫英并不是——", "43785");
        giPlayerSetDir(1, 143.0, true);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：我开玩笑呢，当什么真！", "43786");
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 259.0);
        giCameraRunSingle("007", false);
        giIMMEnd();
        giPlayerSetDir(1, 81.0, true);
        giCameraRunSingle("011", false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：好了，说正经的，今天真是好高兴，我但愿我们四个人，一生一世都有这样的机会聚在一起，做自己应做之事！", "43787");
        giPlayerDoAction(0, "J17", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：哈哈，这有什么难的？一定可以！", "43788");
        giPlayerEndAction(0);
        giPlayerSetEmotion(3, "105_zc");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：希望如此。", "43789");
        giSetPortrait("107B", false);
        giTalk("柳梦璃：嗯，我也希望我们能永远在一起，永远都不分开。", "43790");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：紫英你别皱眉头了，是不是担心妖界的事？我相信只要玄霄能破冰而出，我们不会输的！", "43791");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(0, 30.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：对，<colour red=255 green=187 blue=0 alpha=255>马上把光纪寒图给玄霄，</colour><dc0>他一定很开心，哈哈。</dc0>", "43792");
        giPlayerEndAction(0);
        giCameraRunSingle("012", false);
        giWait(2.5);
        giFlashOutBlack(3.0, true, true);
        giCameraRunSingle("001", true);
        global_mvar = 91200; // 0x00016440, 第二章 / 6-2-4.万家同庆 / 御剑回山 / 狐仙之乱
        giArenaLoad("Q09", "N01", "", true);
        giPlayerCurrentSetPos(58.2264, 0.18609, 41.4262);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(2, true);
        giArenaReady();
        giCameraSetDistOptEnable(true);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2006()
{
    giPlayerLock();
    giNpcFaceToCurrentPlayer("MN001", true);
    giCurrentPlayerFaceToNpc("MN001", true);
    giSetPortrait("220A", true);
    giTalk("夏元辰：估计<colour red=255 green=187 blue=0 alpha=255>晚上的庆典就要开始了</colour><dc0>，小兄弟不妨也去凑个热闹。</dc0>", "");
    giNpcResetDir("MN001");
    giPlayerUnLock();
}

void func2007()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("MN002", true);
    giSetPortrait("219A", true);
    giTalk("莲宝：爹爹……", "43625; 43627");
    giPlayerUnLock();
}

void func3001()
{
    if (global_mvar <= 140100 && npc_e == 2 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P35", 2, 0.0, 0.0);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giSetNpcVisible("4024", false);
        giSetNpcVisible("4032", false);
        giSetNpcVisible("4031", false);
        giPlayerSetPos(0, 113.5991, -3.3745, 326.4479);
        giPlayerSetPos(1, 158.8807, -3.3745, 361.2892);
        giPlayerSetPos(3, 116.6827, -3.3745, 413.9091);
        giNpcSetPos("SN001", 97.8469, -3.3745, 484.1043);
        giNpcSetAng("SN001", 348.0);
        giSetNpcVisible("SN001", true);
        giPlayerSetVisible(3, true);
        giPlayerCurrentSetVisible(false);
        giCameraPrepare("ZI001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giArenaReady();
        giNpcWalkTo("SN001", 49.1029, -3.3745, 635.7193, false);
        giFlashInBlack(1.5, false);
        giWait(1.3);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：你，为何要说谎？", "");
        giNpcEndMove("SN001");
        giPlayerWalkTo(3, 71.6969, -3.3745, 532.855, false);
        giWait(1.2);
        giCameraRunSingle("002", true);
        giPlayerEndMove(3);
        giPlayerSetAng(3, 336.0);
        giNpcSetDir("SN001", 174.0, true);
        giWait(0.5);
        giTalk("道臻：……何出此言？", "");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……听闻赤雪流珠丹乃蜀山至宝，非掌门不可动用，但蜀山如此大派，素来以斩妖除魔为己任，甚至以锁妖塔关押妖物，态度之强硬比琼华派有过之而无不及，掌门怎会将贵重的丹药用在一个半人半妖的孩子身上？", "");
        giCameraRunSingle("003", false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：何况你说到尊师禀报掌门、取得丹药时，似乎急于掩饰，未免太不自然。", "");
        giWait(0.7);
        giTalk("道臻：这只是你的猜测，并无实据。", "");
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：不错……但我越想越是心惊，若我所言不差，尊师和你便是私自取走了赤雪流珠丹，你们为了道闰，竟不惜铤而走险？！", "");
        giWait(0.7);
        giNpcSetDir("SN001", 310.0, true);
        giWait(1.2);
        giTalk("道臻：…………盗取丹药乃是我一人所为，师父并不知情。", "");
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……！果然……你不愿道闰痛苦，所以假意怒斥，再将丹药给他，最后拂袖而去，他更不会起疑……", "");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.8);
        giTalk("道臻：我并非假意，一念之差，我便会杀了那女妖，将道闰带回蜀山。", "");
        giWait(0.5);
        giNpcSetDir("SN001", 166.0, false);
        giWait(0.5);
        giTalk("道臻：可是，这样做又有什么意义？道闰往后一生都不会再快乐了……", "");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 352.0);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：在你心中，他一人之愿终究胜过了门规道义。", "");
        giCameraRunSingle("005", false);
        giWait(0.5);
        giTalk("道臻：……道闰很小的时候，我们爹娘便枉死于妖物手中，后来我与他拜入蜀山门下，我发誓遵师门之命，斩妖除魔、守护黎民百姓。", "");
        giWait(0.5);
        giTalk("道臻：……可是在更早以前……我也发过誓，要尽我所能照顾这个唯一的弟弟，让他一世幸福。我从未想过，有朝一日，要守住其中一个誓言，便要毁去另一个……", "");
        giWait(0.5);
        giTalk("道臻：如今尘埃落定，我心中反而平静下来，剩下的……便是回师门领罪。", "");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……盗取了蜀山至宝，会被如何定罪？", "");
        giTalk("道臻：既然大错已成，我听候发落，不作他想。", "");
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……", "42783; 42993; 43015; 43178; 43305; 43307; 43312; 43592; 43697; 43822; 43865; 44083; 44108; 44113; 44175; 44552; 44633; 44896; 44975; 45086; 45373; 45403; 45502; 45522; 45748; 46353; 46355; 46372; 46379");
        giWait(0.5);
        giNpcWalkTo("SN001", 36.7637, -3.3745, 674.6843, false);
        giCameraRunSingle("006", true);
        giWait(0.5);
        giTalk("道臻：此事请勿告诉道闰，若说起于私念，也是我的，而非他的，所有罪孽由我一人承担，与他无关。", "");
        giWait(0.5);
        giNpcWalkTo("SN001", 19.3958, -3.3745, 747.1397, true);
        giSetNpcVisible("SN001", false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……", "42783; 42993; 43015; 43178; 43305; 43307; 43312; 43592; 43697; 43822; 43865; 44083; 44108; 44113; 44175; 44552; 44633; 44896; 44975; 45086; 45373; 45403; 45502; 45522; 45748; 46353; 46355; 46372; 46379");
        giWait(1.0);
        giPlayerSetDir(3, 328.0, false);
        giWait(0.5);
        giCameraRunSingle("007", false);
        giWait(5.9);
        giCameraRunSingle("008", false);
        giWait(1.2);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(0, true);
        giPlayerRunTo(0, 74.4067, -3.3753, 445.5561, false);
        giPlayerRunTo(1, 118.6989, -3.3789, 482.2947, true);
        giPlayerSetAng(1, 334.0);
        giWait(0.5);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：紫英，原来你在这里。", "");
        giPlayerSetDir(3, 132.0, true);
        giCameraRunSingle("009", true);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……道闰呢？", "");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：他……他和妻子打算去居巢国隐居，已经走了……", "");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：是我告诉他们可以去那里的……这一次我又帮了妖，你是不是不高兴了？……我知道你讨厌妖，可是——", "");
        giPlayerDoAction(3, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：不必再说了……", "");
        giPlayerEndAction(3);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……紫英，你怎么了？神色好像怪怪的……刚才，我好像看见道臻从这儿离开，他和你说了什么吗？", "");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：没什么……他只说该办的事都已经办完了，要回蜀山复命。", "");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：哦，这样也好，我还以为……会闹到不可收拾的地步呢，幸好道臻他是真的很疼弟弟，他们的师父心肠也很好……", "");
        giPlayerEndAction(1);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：…………", "42751; 44030; 44566; 44797; 45022; 45199; 45299; 45387; 45554; 45687; 45774; 45776; 45786; 45820; 45823; 45843; 46182; 46311; 46456");
        giCameraRunSingle("010", false);
        giPlayerSetDir(3, 326.0, true);
        giCameraWait();
        giFlashOutBlack(2.5, true, true);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(71.6969, -3.3745, 532.855);
        giPlayerCurrentSetAng(326.0);
        giSetNpcVisible("4024", true);
        giSetNpcVisible("4032", true);
        giSetNpcVisible("4031", true);
        giCameraSetMode(0, true);
        npc_e = 3;
        giAddPlayerFavor(0, 3, 20);
        giAddPlayerFavor(1, 3, 15);
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
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
        giRandTalkPush("徐威：狐仙被赶跑后，就再也没回来生事，这都是你们的大恩大德啊～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("徐威：听夏元辰说你们把那狐仙狠狠教训了一顿？！这、这真是太好了！以后是不是都可以安心过日子了？！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("徐威：看你们的样子，是外乡人吧？即墨背靠大山，面向大海，两边的路都不好走，外人不怎么来的。");
        giRandTalkPush("徐威：今天可是狐仙大寿的好日子！所有人都要去庙里给他老人家贺寿的！");
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
        giRandTalkPush("殷大娘：最近的日子好起来了，卖了这阵子晒的鱼干，就可以给儿子裁一件新衣裳。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("殷大娘：哎呀！大侠，多亏了你！我们以后再也不用受那只狐狸的欺压了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("殷大娘：狐三太爷可是真神仙～我特地准备了这些鲜果肥鸡给他做寿礼，不知道还合不合他的心意？");
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
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("王进辉：那狐狸自从被打跑后，就再也没敢回来，真是太感激你了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("王进辉：托你们的福！酒窖里的陈年老酒再也不用供奉给那只狐狸啦！店里特别开了三坛十年陈的好酒庆贺，大侠们可要来两杯？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("王进辉：我这儿最好的酒是醪酒，酒香浓郁，口味醇厚，传说春秋时齐国公朝拜崂山仙人～用的就是这酒。");
        giRandTalkPush("王进辉：今天是狐仙他老人家的寿辰，待会儿我得让娘子带几大坛醪酒送去狐仙庙，这事可不能忘了！");
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
    giCurrentPlayerFaceToNpc("4004", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("马开：老赵那人就是怕这怕那的，我早说狐仙不会再回来生事，可他偏偏不信！瞧，现在大伙儿不都过得好好的？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giTalk("马开：老赵，听说了没？那个神气活现的狐仙被几位奇人打得毫无还手之力，真是大快人心！", "");
        giTalk("赵大山：唉……救得了一时救不了一世啊～他们总不可能在这儿待一辈子吧？万一狐仙又回来，那可怎么办？", "");
    }
    else
    {
        giTalk("马开：老赵，这次狐仙大寿，你供了什么啊？", "");
        giTalk("赵大山：我？还不是花生、干果、蜜饯，还有狐仙最爱的醪酒！", "");
        giTalk("马开：我说你怎么年年都供这些东西啊？我这回特地弄了一条十斤重的大黄鱼，还在鱼肚里塞上对虾、扇贝、蟹肉，包准讨他欢心！", "");
        giTalk("赵大山：我们凡人哪里猜得准狐仙的心思呐～还是安稳一些，既然往年的供品都没啥问题，那今年还是如此吧！ ", "");
    }
    giPlayerUnLock();
}

void func4005()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4005", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("赵大山：都过这么久了，狐仙竟然真的没回来！总算是天下太平啦～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("赵大山：我总觉得现在高兴还太早了，那狐仙未必就不敢再生事端，还是少说点话，安安份份过日子吧……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("赵大山：别人总说我做事瞻前顾后、怕这怕那，其实我只想安安稳稳过日子，所谓“小心驶得万年船”嘛。");
        giRandTalkPush("赵大山：即墨最有名的东西就是花生、对虾和醪酒，不过每年县里最好的干果海产、酒馆里最好的酒，都得供奉给狐仙才是。");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4006()
{
    giPlayerLock();
    giNpcPauseBeh("4006");
    giNpcFaceToCurrentPlayer("4006", true);
    giCurrentPlayerFaceToNpc("4006", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("宋福：没有那臭狐狸生事，心情都爽朗不少，人人都说我面泛红光，一脸喜色，还以为我要成亲了，哈哈哈！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("宋福：那只狐狸被打跑了！从此以后再也不用担心糕点会突然变石头了，哈哈！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("宋福：香糯甜润的八宝饭～快来买呀！这位小哥，可要来一个？像今天这么喜庆的日子，买个八宝饭回去，团团圆圆，多好呀！");
        giRandTalkPush("宋福：宋师父做的糕点可是整个即墨出了名的！不但八宝饭做得好吃，像是糖煎藕、蜜枣包、江米面炸糕……个个色香味俱全！");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("邹师父：小毛那孩子前几日来找我打刀，说是要练武，虽然有志气是不错，但是就他那样瞎练，哪天才能学成啊？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("邹师父：狐三太爷平时常捉弄大家，这回总算被人教训了！哈哈哈！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("邹师父：最早的时候，即墨可没有狐仙庙，后来，为了让狐仙知道咱们是诚心拜他的，所以就为他建了座庙。");
        giRandTalkPush("邹师父：我那徒儿小时候总是笨手笨脚的，做事总比别人慢半拍，当时我就跟他说了，人笨不要紧，只要勤快些，不怕学不会！");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4008", true);
        giCurrentPlayerFaceToNpc("4008", true);
        giRandTalkRelease();
        giRandTalkPush("秋兰：娘托人给我捎来村里的茶叶，听说这茶只有县里的青天大老爷才喝得起，婆婆知道了，笑得嘴都合不拢，这好像是她唯一一次夸我了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giNpcFaceToCurrentPlayer("4008", true);
        giCurrentPlayerFaceToNpc("4008", true);
        giRandTalkRelease();
        giRandTalkPush("秋兰：狐仙被打跑了，大伙儿都很高兴，可我没买糕点，婆婆还是不高兴，我到底要怎么做才能讨婆婆喜欢呢？……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (var_shop037 != 0)
    {
        giNpcFaceToCurrentPlayer("4008", true);
        giCurrentPlayerFaceToNpc("4008", true);
        giRandTalkRelease();
        giRandTalkPush("秋兰：婆婆让我到市集买糕点，但却只给了我一文钱，怎么买啊……");
        giRandTalkPush("秋兰：我是从很远的地方嫁过来的，虽然这儿的隐香山不比太平村旁的黄山秀美，但这里东南临海，站在海边望过去，可比巢湖开阔得多，唯一不顺心的，就是婆婆她……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giFlashOutBlack(1.0, true, true);
        giPlayerSetPos(0, -2162.56, 161.9709, -54.727);
        giPlayerSetAng(0, 72.0);
        giSetNpcVisible("4200", true);
        giSetNpcVisible("4037", false);
        giCameraPrepare("NPC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, true);
        giNpcWalkTo("4200", -2068.3289, 161.7094, -88.2195, true);
        giTalk("王大婶：秋兰！让你出来买糕点，送到狐仙庙！你怎么还在这儿？！是不是又在偷懒？！", "");
        giNpcFaceToNpc("4008", "4200", true);
        giWait(0.5);
        giTalk("秋兰：啊！婆婆……您、您只给了我一文钱，买几个白面馒头都不够，让我怎么——", "");
        giTalk("王大婶：好啊，过门没几天，别的不会，顶嘴的功夫倒是长进了，啊？！要是天黑之前还没把糕点供上，你就自己看着办吧！", "");
        giWait(0.5);
        giNpcWalkTo("4200", -1979.0367, 166.0179, -131.0298, false);
        giCameraRunSingle("002", true);
        giWait(1.5);
        giNpcSetDir("4008", 134.0, true);
        giWait(0.5);
        giTalk("秋兰：……", "");
        giWait(0.5);
        giFlashOutBlack(1.0, true, true);
        giSetNpcVisible("4200", false);
        giSetNpcVisible("4037", true);
        var_shop037 = 1;
        giFlushTailYAngle();
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giFlashInBlack(1.0, true);
        giPlayerUnLock();
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
        giRandTalkPush("汤二娘：菩萨保佑，千万别让那狐三太爷又回来欺压大伙儿……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("汤二娘：狐三太爷不在了？那狐仙庙要来何用？依我看倒不如重新修一下，换尊观音娘娘进去，也好让大家求个吉利～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("汤二娘：方正这人，小时候傻楞楞的，干什么都比别人慢一拍。现在做起事来倒也有模有样，不光打铁，他连木匠的活也会干呢！");
        giRandTalkPush("汤二娘：想起那时修建狐仙庙，全县的男人，能干活的都出了力，一木一石，都是大伙儿的汗水啊！");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("桑碧荷：狐仙被赶跑了，大家的日子都好过了，明年若是还有灯会，一定比今年更热闹，欢迎你们再来～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("桑碧荷：狐仙真的被教训了吗？上回，大半夜的我相公突然就被变到了隐香山的树林里，第二天早晨醒来，吓都吓死了，幸好没被野兽吃了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("桑碧荷：相公是海上打鱼的人，不过他喜欢扎花灯，每年给狐仙贺寿的时候，整个即墨的花灯，一大半是他扎的～");
        giRandTalkPush("桑碧荷：现在整个即墨，家家户户都挂着花灯，等到晚上点起来，那场面～可比上元节更热闹。");
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
    giCurrentPlayerFaceToNpc("4011", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("霍全：上次带回去的醪酒一下子就卖空了，只可惜路途太遥远，我这一来一回，盘缠就花费不少，若能想办法要到酿酒的方子，那就最好～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("霍全：哈哈～我就说嘛，哪有仙人会被凡人打得一败涂地？那狐狸分明就是一只骗人的畜生！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("霍全：我走南闯北几十年，去过的地方无数，还从来没见过哪个城镇，这样看重一只狐狸的……难不成它还真是法力无边的大仙？");
        giRandTalkPush("霍全：这儿的醪酒香醇浓厚，实在是不可多得的佳酿，带回江南去卖一定能赚不少，嘿嘿！");
        giRandTalk();
        giRandTalkRelease();
    }
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
        giRandTalkPush("阿奉：那天庆贺狐仙被赶跑的场面，到现在还在我的脑子里呢，都多少年了，大家从没那么开怀过！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("阿奉：狐仙跑了？！哈哈哈哈！他跑大家才高兴啊！总比以前强颜欢笑强多了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("阿奉：客官，你们来得可真巧……今天正好是狐仙的寿辰，晚上有花灯可看，爱凑热闹的就出去瞧瞧吧。");
        giRandTalkPush("阿奉：在我们即墨，一年当中也就只有狐仙的寿辰最热闹，为了给他老人家准备寿礼，很多人都攒了一整年的银钱，就等今天了。");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("乐陵：再也不用把好吃的东西都送到狐仙庙去了～昨天我吃了娘煮的肉，真开心，嘻嘻！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("乐陵：……以后我们都不用给狐仙祝寿了？也就是说不用把烧肉省给他吃了？～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
    {
        giRandTalkPush("乐陵：夏叔叔是好人，上次爹上山被狼咬了，就是夏叔叔背他回来的～莲宝平时虽然不和我们一起玩，但她是夏叔叔的女儿，一定也是好人，为什么狐仙要把她带走呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("乐陵：奶奶让我把烧肉送去狐仙庙里，让在庙里的阿娘把烧肉给狐仙供上，可是我刚才摔了一跤，那块烧肉被大黄狗叼了去，怎么办？呜……");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("刘天宝：我现在已经正式拜入飞鹰帮门下，师从江湖上有名的“神刀铁胳臂”胡得朔胡大侠，以后再有人来欺负我们，就一点都不怕啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("刘天宝：听说你们不费吹灰之力就把狐仙打得满地找牙？！有这么厉害？大侠～能不能收我为徒啊？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
    {
        giRandTalkPush("刘天宝：你们别不知天高地厚，狐仙的事也敢管！我看还是少管闲事，免得惹祸上身！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("刘天宝：要是你打算在即墨住上一段日子，就一定得进这里的狐仙庙拜拜，庙就修在东北面的山上。");
        giRandTalkPush("刘天宝：我们能够得到狐仙的庇护，真是三生有幸啊，绝对不能对他无礼，你们外来人也是，言语中一定要千万注意！");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcPauseBeh("40151");
        giNpcFaceToCurrentPlayer("40151", true);
        giCurrentPlayerFaceToNpc("40151", true);
        giRandTalkRelease();
        giRandTalkPush("王永芝：我儿子白白胖胖，别提有多可爱了！家里上上下下都把他当宝贝，我就怕长久下去会把他给宠坏了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giNpcPauseBeh("40151");
        giNpcFaceToCurrentPlayer("40151", true);
        giCurrentPlayerFaceToNpc("40151", true);
        giRandTalkRelease();
        giRandTalkPush("王永芝：那莲宝也是傻人有傻福，命大得很，不过她跟着穷书生，还不是穷命……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
    {
        giNpcPauseBeh("4015");
        giNpcFaceToCurrentPlayer("4015", true);
        giCurrentPlayerFaceToNpc("4015", true);
        giRandTalkRelease();
        giRandTalkPush("王永芝：大伙儿平时总劝那书生夏元辰来拜拜狐仙，可他从来不听，迟早会遭报应的啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcPauseBeh("4015");
        giNpcFaceToCurrentPlayer("4015", true);
        giCurrentPlayerFaceToNpc("4015", true);
        giRandTalkRelease();
        giRandTalkPush("王永芝：这庙里供奉的狐仙是很灵验的，拜他一定要诚心诚意！");
        giRandTalkPush("王永芝：狐仙在上～小女王永芝祝狐仙福如东海，寿比南山，求您保佑我一家无病无灾，保佑我这一胎一定生个男孩。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4015");
    giNpcResetDir("40151");
    giNpcResumeBeh("4015");
    giNpcResumeBeh("40151");
    giPlayerUnLock();
}

void func4016()
{
    giPlayerLock();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcPauseBeh("40161");
        giNpcFaceToCurrentPlayer("40161", true);
        giCurrentPlayerFaceToNpc("40161", true);
        giRandTalkRelease();
        giRandTalkPush("叶馨儿：夏元辰带着女儿离开了，大伙儿这才念起他的好，说他总是帮别人不少忙，莲宝也还是很乖的，哼，马后炮……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giNpcPauseBeh("40161");
        giNpcFaceToCurrentPlayer("40161", true);
        giCurrentPlayerFaceToNpc("40161", true);
        giRandTalkRelease();
        giRandTalkPush("叶馨儿：莲宝平安回来就好，她已经够可怜了，千万别再出事……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
    {
        giNpcPauseBeh("4016");
        giCurrentPlayerFaceToNpc("4016", true);
        giRandTalkRelease();
        giRandTalkPush("叶馨儿：狐仙啊～求您保佑我爹爹妈妈没病没痛，弟弟平安无事，家中别出意外……");
        giRandTalkPush("叶馨儿：照说夏元辰家的莲宝是个痴儿，要了去也得不了什么好处，狐仙他到底为什么要带走莲宝呢？但愿莲宝平安无事……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcPauseBeh("4016");
        giNpcFaceToCurrentPlayer("4016", true);
        giCurrentPlayerFaceToNpc("4016", true);
        giRandTalkRelease();
        giRandTalkPush("叶馨儿：平时常来庙里拜拜，到了狐仙寿辰的时候，再多供奉些上等的瓜果鱼肉，这一年差不多也就能平安度过了。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4016");
    giNpcResetDir("40161");
    giNpcResumeBeh("4016");
    giNpcResumeBeh("40161");
    giPlayerUnLock();
}

void func4017()
{
    giPlayerLock();
    giNpcPauseBeh("4017");
    giNpcFaceToCurrentPlayer("4017", true);
    giCurrentPlayerFaceToNpc("4017", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("姚冠华：啊哈哈～老天有眼呐，我媳妇连生三个女孩，这胎终于生了个男孩！我姚家有后了！我姚家有后了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("姚冠华：那狐狸就喜欢捉弄人，我媳妇对他一向诚心，每次上香都毕恭毕敬，每次上供都给最好的东西，可狐狸有哪一次保佑我们家生男孩了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
    {
        giRandTalkPush("姚冠华：夏元辰也是个可怜人……一个大男人，带个女儿不容易，偏偏还遇到这种事……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("姚冠华：哎，我家这房子，真是风水宝地，就在狐仙庙旁边，还对着上山的道，所以家里蒙狐仙照应的次数，也是最多的……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4017");
    giNpcResumeBeh("4017");
    giPlayerUnLock();
}

void func4018()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4018");
    giCurrentPlayerFaceToNpc("4018", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4018", true);
        giRandTalkRelease();
        giRandTalkPush("何知润：这些日子天气好，我也上山去了一趟，原来这山路不难走，只是被那狐狸施了障眼法……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giNpcFaceToCurrentPlayer("4018", true);
        giRandTalkRelease();
        giRandTalkPush("何知润：原来那狐狸四处害人，根本就是个妖怪！可惜我晚了一步，没能亲自收拾它！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToNpc("4018", "4019", true);
            giNpcFaceToNpc("4019", "4018", true);
            giTalk("何知润：姑娘，往隐香山狐仙居是不是就从这里上山？", "");
            giTalk("李秀华：问这个做什么？狐仙不喜欢有人上山打扰他，你最好别去啊。", "");
            giTalk("何知润：嘿嘿，听说狐仙就住在山上，我只是想参拜参拜～", "");
            giTalk("李秀华：想参拜去前面的狐仙庙就行了，这山上的路本来就不好走，你要是迷路了，可是自找的。", "");
        }
        else
        {
            giNpcFaceToCurrentPlayer("4018", true);
            giTalk("何知润：这里人人都把那狐狸说的像神仙，害我想上山看看它到底长什么样，说不定根本就只是一狐狸精！", "");
        }
    }
    giNpcResetDir("4018");
    giNpcResetDir("4019");
    giNpcResumeBeh("4018");
    giPlayerUnLock();
}

void func4019()
{
    giPlayerLock();
    giNpcPauseBeh("4019");
    giNpcFaceToCurrentPlayer("4019", true);
    giCurrentPlayerFaceToNpc("4019", true);
    if (maze_var4 != 1)
    {
        giRandTalkRelease();
        if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
        {
            giRandTalkPush("李秀华：夏元辰带着莲宝去了外地，长途跋涉的，他真懂怎么照顾小孩吗？");
            giRandTalk();
            giRandTalkRelease();
        }
        else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
        {
            giRandTalkPush("李秀华：我们受那狐狸的坑害，苦了好多年啦！有人把狐狸赶跑，他们真是即墨的大恩人！");
            giRandTalk();
            giRandTalkRelease();
        }
        else
        {
            giRandTalkPush("李秀华：夏元辰的年纪也不轻了，他也不是长得貌丑，只是带着那样一个养女，哪家闺女愿意嫁他呢……");
            giRandTalk();
            giRandTalkRelease();
        }
    }
    else
    {
        giTalk("李秀华：这、发带……是我留在方大哥铺子里的……我想送给方大哥，可是我一个女孩子家，怎么好意思嘛～你、<colour red=255 green=187 blue=0 alpha=255>你帮我去告诉方大哥</colour><dc0>，发带他自己留着用就好了，我、我改天再去看他……</dc0>", "");
        maze_var4 = 2;
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("余小童：我看都这么久了，狐三太爷也没再回来，八成是被吓破了胆，爬回他的老窝去啦！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("余小童：那个讨厌的狐三太爷终于被赶跑了！店里上好的长白人参再也不会被换成萝卜干了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("余小童：即墨人经常会莫名其妙患些小毛小病，也不用什么特别的药，几钱巴豆下肚，清了肠胃就什么都好了，师父说这都是因为有狐三太爷保佑！");
        giRandTalkPush("余小童：狐三太爷保佑，师父刚从行商那儿高价买来的云南田七，千万别变成树干片啊！");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("丁浩：萍儿丫头嘴里老叨念着夏元辰那小子，不会是看上他了吧？反正人家现在已经离开即墨了，她也好死了这条心！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("丁浩：哇～这不是杀狐大英雄吗？我看不如在庙里给你们立个像吧，这样也好常去拜拜！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("丁浩：夏小弟人是不错，善良热心，可惜带着个累赘，至今都没成亲……");
        giRandTalkPush("丁浩：萍儿那丫头，叫她去草棚拿鱼干，怎么到现在还没回来？要是误了给狐三太爷贺寿的吉时，可是不得了！");
        giRandTalk();
        giRandTalkRelease();
    }
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("孙光：呵呵，这段日子海上风平浪静，大伙儿每回出海都能收获很多鱼虾。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("孙光：听说狐仙被你们打跑了？看不出来你们竟这样厉害！了不起！英雄出少年！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("孙光：即墨紧挨着海，大多数人都以捕鱼为生，要是一个不小心遇上突然来的暴风雨，那可就完了……");
        giRandTalkPush("孙光：今天晚上有为狐仙祝寿的庆典，到时我一定得诚心祷告，请他保佑海上风平浪静，大家都别出什么意外。");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4022");
    giNpcResumeBeh("4022");
    giPlayerUnLock();
}

void func4023()
{
    giPlayerLock();
    giNpcPauseBeh("4023");
    giNpcFaceToCurrentPlayer("4023", true);
    giCurrentPlayerFaceToNpc("4023", true);
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("丁萍：夏大哥离开即墨也有一段日子了，不知道他们父女俩现在过得怎么样？我好想他……不，好想他们……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("丁萍：看到夏大哥他们平安回来，我真是松了一口气～娘说好人有好报，真是应了这句话。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
    {
        giRandTalkPush("丁萍：夏大哥平时常常帮我晒网收网，哥哥病了，夏大哥还带我一起出海，虽然他也帮不上什么忙……但是现在他的女儿被狐仙带走了，我却一点忙都帮不上，我真是太没用了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("丁萍：刚才我看见夏大哥急急忙忙地跑过去，眉头紧皱，神色慌张，不知道出了什么事啊？");
        giRandTalkPush("丁萍：哥哥叫我去草棚拿鱼干，说是要给狐仙当供品，那么臭烘烘的咸鱼，又不是什么稀罕东西，狐仙怎么会喜欢？");
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
    giRandTalkRelease();
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("郭九：昨天出海捕了一箩筐的虾，个个都有手掌那么大！待会儿到临涛小酌买坛酒回来，煮虾下酒吃。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("郭九：好久没有这样心情畅快了，哈哈！常年受那死狐狸的欺压，连觉都睡不安稳，还老怕他故意把船弄翻，每次出海都要小心翼翼，现在总算能安心了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("郭九：总算把所有的灯笼都挂上去了，我还特地用粗绳扎得牢牢的，就算风再大，也绝不会被吹倒！");
        giRandTalkPush("郭九：不知道武阳那边的灯笼挂得怎么样了？我去看看，要是挂完了，找他一起喝两杯去！");
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
    giCurrentPlayerFaceToNpc("4025", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4025", true);
        giRandTalkRelease();
        giRandTalkPush("周武阳：很长时间没过太平日子了，一开始还真有点不习惯呢，呵呵，以后能一直这样就好了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giNpcFaceToCurrentPlayer("4025", true);
        giRandTalkRelease();
        giRandTalkPush("周武阳：狐仙走了的确是大喜事，就怕过一段时间他又回来了，到时候恐怕比现在还惨！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4025", true);
            giTalk("周武阳：我瞧这灯笼迟早会被风吹下来，我还是上去重新绑一下，免得出什么闪失。", "");
        }
        else
        {
            giNpcFaceToNpc("4026", "4025", true);
            giNpcFaceToNpc("4025", "4026", true);
            giTalk("周武阳：小毛，你怎么挂灯笼的？晃悠晃悠的，都快掉下来啦！", "");
            giTalk("胡小毛：周大叔，你放心好了！那是风大吹的，看着晃悠，其实稳得很！这灯笼可是为狐仙贺寿挂的，我哪敢有半点马虎！", "");
        }
    }
    giNpcResetDir("4025");
    giNpcResetDir("4026");
    giNpcResumeBeh("4025");
    giPlayerUnLock();
}

void func4026()
{
    giPlayerLock();
    giNpcPauseBeh("4026");
    giCurrentPlayerFaceToNpc("4026", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4026", true);
        giRandTalkRelease();
        giRandTalkPush("胡小毛：我前几日找方大哥打了把刀，准备从现在开始好好练武，要是日后有什么狐四太爷敢来欺负大家，我就去给他几刀，杀得他屁滚尿流！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giNpcFaceToNpc("4026", "4025", true);
        giNpcFaceToNpc("4025", "4026", true);
        giTalk("胡小毛：……只见英雄手起刀落，那狐仙的头就掉到了地上！周大哥，你没瞧见那场面，当真是……", "");
        giTalk("周武阳：咦？我怎么听说狐仙只是被打跑了，并没有死啊？", "");
        giTalk("胡小毛：这……嘿嘿～我当时站在远处，远远看见刀光一闪，至于头掉没掉下来……我也不是很清楚。", "");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4026", true);
        giRandTalkRelease();
        giRandTalkPush("胡小毛：桅杆上的灯笼都是我挂的，到了晚上给狐仙庆寿的时候，我得过来把这些灯笼一盏一盏地点上。");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("廉小雨：以前娘要是生病了，为了省钱给狐仙办寿礼，都不肯去看大夫，现在她也舍得开药了，这样身体才会很快好起来啊～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giRandTalkPush("廉小雨：还好……夏叔叔和莲宝都平安回来了，我、我好不应该，还觉得莲宝被抓走是遭了报应，幸好……狐仙跑了，大伙儿不用再像以前那样过日子了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
    {
        giRandTalkPush("廉小雨：夏叔叔是好人，平日里也帮了大家不少忙，只是他不肯供奉狐仙，终于把狐仙惹恼了……这事真是谁也帮不上的呀！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("廉小雨：这些蔬果海产是我家省了一年才省下来的，希望狐仙他老人家满意。");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcPauseBeh("281");
        giNpcFaceToCurrentPlayer("281", true);
        giCurrentPlayerFaceToNpc("281", true);
        giRandTalkRelease();
        giRandTalkPush("吴芮：王家的媳妇是从南方嫁过来的，她娘家人前些日子捎了些上好的茶叶来，听说是京城里那些大老爷爱喝的东西，王大婶得了那些茶叶，笑得嘴都合不拢。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giNpcPauseBeh("281");
        giNpcFaceToCurrentPlayer("281", true);
        giCurrentPlayerFaceToNpc("281", true);
        giRandTalkRelease();
        giRandTalkPush("吴芮：想不到啊、想不到……我还以为没人能管得了那狐仙，以后都得这么过了……那打跑狐仙的人，真是大善人。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90300 /* 第二章 / 6-1-1.为祸一方 / 书生寻女 */)
    {
        giNpcPauseBeh("4028");
        giNpcFaceToCurrentPlayer("4028", true);
        giCurrentPlayerFaceToNpc("4028", true);
        giRandTalkRelease();
        giRandTalkPush("吴芮：真是作孽啊！夏家那孩子平时待大伙儿那么好，就是因为对狐仙不敬，女儿才会被带走……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcPauseBeh("4028");
        giNpcFaceToCurrentPlayer("4028", true);
        giCurrentPlayerFaceToNpc("4028", true);
        giRandTalkRelease();
        giRandTalkPush("吴芮：今年的天气不太好，上个月刮了两三次狂风，下了十多天大雨……一定得求狐仙多保佑我们啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4028");
    giNpcResetDir("281");
    giNpcResumeBeh("4028");
    giNpcResumeBeh("281");
    giPlayerUnLock();
}

void func4031()
{
    bool has_property_3255 = false;

    giPlayerLock();
    giNpcPauseBeh("4031");
    giNpcFaceToCurrentPlayer("4031", true);
    giCurrentPlayerFaceToNpc("4031", true);
    if (maze_var3 != 1)
    {
        if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
        {
            giTalk("任老爹：哈哈哈，老头子我才钓了一小会儿鱼，这鱼篓子就满啦！回家拿给儿子媳妇，要煮要卖都随他们！", "");
        }
        else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
        {
            giTalk("任老爹：哎呀呀，这回可真是太好喽！那臭狐狸欺负我们七、八年了，现在终于遭了报应！英雄您可要在咱即墨多待几天，让大伙儿都好好招待招待您！", "");
        }
        else
        {
            giTalk("任老爹：年纪大啦，每次出海回来，这把老骨头都像散了架似的疼。可不出海嘛，说不定什么时候就被狐仙三太爷照应照应……还不如出海的好！", "");
        }
    }
    else
    {
        has_property_3255 = giCheckPackProperty(3255, 1);
        if (!giCheckPackProperty(3255, 1))
        {
            if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
            {
                giTalk("任老爹：哈哈哈，老头子我才钓了一小会儿鱼，这鱼篓子就满啦！回家拿给儿子媳妇，要煮要卖都随他们！", "");
            }
            else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
            {
                giTalk("任老爹：哎呀呀，这回可真是太好喽！那臭狐狸欺负我们七、八年了，现在终于遭了报应！英雄您可要在咱即墨多待几天，让大伙儿都好好招待招待您！", "");
            }
            else
            {
                giTalk("任老爹：年纪大啦，每次出海回来，这把老骨头都像散了架似的疼。可不出海嘛，说不定什么时候就被狐仙三太爷照应照应……还不如出海的好！", "");
            }
        }
        else
        {
            giTalk("任老爹：呵呵，又是宋老板送糕点来了？让我尝尝～", "");
            giDelProperty(3255, 1, true);
            giWait(2.0);
            giTalk("任老爹：嗯～不错、不错～<colour red=255 green=187 blue=0 alpha=255>替我告诉宋老板</colour><dc0>，就说绿豆糕的味道特别好，别的嘛，就不怎么样了。</dc0>", "");
            maze_var3 = 2;
        }
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
    if (var_shop006 != 1)
    {
        if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
        {
            giTalk("张艳：以前夏大哥在的时候，总是帮大伙很多忙，爷爷的病也是夏大哥帮忙才治好的……不知道现在夏大哥去了哪里，过得怎么样？", "");
        }
        else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
        {
            giTalk("张艳：记得我小的时候，狐三太爷刚来隐香山，有时候还是会帮帮我们的，是后来才渐渐开始欺负人的……不过不管怎么样，这些都是过去的事情啦！", "");
        }
        else
        {
            giTalk("张艳：海上的天气总是变化无常，就算现在看起来风平浪静，到了夜里说不定就来几场暴风雨。没有经验丰富的渔人陪着，可千万别随便出海。", "");
        }
    }
    else
    {
        giTalk("张艳：你是说，这块石头是刘大哥让你带来的？他还是这样，把铸剑用的矿石当宝贝，可惜我一点都不懂呢……", "");
        giTalk("张艳：<colour red=255 green=187 blue=0 alpha=255>如果你再去寿阳，就帮我告诉刘大哥</colour><dc0>，他喜欢寿阳城外巢湖的水，我却只爱即墨的海，这块石头，还是送给懂得欣赏它们的人吧……</dc0>", "");
        var_shop006 = 2;
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("穆小小：虽然莲宝平常都不怎么跟我说话，可我还是很喜欢她……现在夏叔叔带着莲宝一起走了……我好想莲宝呀！", "");
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giTalk("穆小小：哥哥你真是太厉害了，打跑了狐狸，救了莲宝！我长大了，也要像哥哥一样四处去打坏蛋！", "");
    }
    else
    {
        giTalk("穆小小：呜呜呜……娘说今年家里没有别的东西了，要杀大牯牛送给狐三太爷做寿礼……呜呜呜，小小不要大牯牛死，呜……", "");
    }
    giNpcResetDir("4033");
    giNpcResumeBeh("4033");
    giPlayerUnLock();
}

void func4035()
{
    giPlayerLock();
    giNpcPauseBeh("4035");
    giNpcFaceToCurrentPlayer("4035", true);
    giCurrentPlayerFaceToNpc("4035", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("赵常：最近海上风平浪静，出海的人带回来的海产也比以前多，咱店里的各式海味炒菜可是一样也不缺，英雄您可要尝尝不？", "");
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giTalk("赵常：英雄！您来啦！虽然店里的房间简陋了点儿，不过已经为您打扫干净了！如果您逛累了，随时都可以来歇息！", "");
    }
    else
    {
        giTalk("赵常：咱这“安潮客栈”虽然比不上大城里的客栈舒坦，但是上房的窗户对着海，晚上歇息时，能听到海潮起落的声音，哈哈！", "");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("宋笑生：糟糕！我竟然忘记曾飞鸽传书约唐家堡五小姐陈州相见之事了！唐五小姐向来刁蛮，这回我竟然爽了她的约，可是大大的不妙～", "");
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giTalk("宋笑生：我说那狐狸到底有什么本事，让整个即墨的人都对他如此恭敬？原来也不过是一只狐精，几个名不见经传的小毛孩子就能把他打跑，真是无聊～", "");
    }
    else
    {
        giTalk("宋笑生：这里的人真是奇怪，竟把一只狐狸敬得像神仙？若那狐狸真这么有本事，那我“夺命书生”宋笑生倒想会他一会～", "");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("谭九：嘿嘿，告诉你一个秘密！在这世上，有一种会走会跑的神秘水滴，总是说一些奇奇怪怪的话，但是那些话中却往往包含着无上天机！", "");
    }
    else if (global_mvar >= 90800 /* 第二章 / 6-1-3.为祸一方 / 回到即墨 */)
    {
        giTalk("谭九：少侠您年纪不大，修为却不浅，更奇的是我竟然没有在江湖上听过少侠的名号！看少侠的打扮……难道您是传说中的蜀山剑仙？", "");
    }
    else
    {
        giTalk("谭九：不是说“夺命书生”宋笑生和唐家堡的三小姐相约陈州吗？可是我今天早上路过狐仙庙时，好像看到了那个“夺命书生”哎？", "");
    }
    giNpcResetDir("4037");
    giNpcResumeBeh("4037");
    giPlayerUnLock();
}

void func4029()
{
    giPlayerLock();
    giNpcPauseBeh("4027");
    gi2DSoundPlay("WB020", 1);
    giNpcResumeBeh("4027");
    giPlayerUnLock();
}

void func4034()
{
    gi2DSoundPlay("WB022", 1);
}

void func5001()
{
    giPlayerLock();
    giNpcPauseBeh("5001");
    giNpcFaceToCurrentPlayer("5001", true);
    giCurrentPlayerFaceToNpc("5001", true);
    if (maze_var3 != 0)
    {
        if (maze_var3 != 2)
        {
            giStartTradeSystem("shop035", "");
        }
        else
        {
            giTalk("宋圆：只有绿豆糕的味道特别好？唉……其实这几样糕点当中，只有绿豆糕是我娘子做的，其余都是我的手艺。没想到我精心苦练这么多天，做的糕点仍旧不如娘子啊……这些点心都送给你吧，下次我一定会做出更好吃的点心！", "");
            giAddProperty(3022, 30, true);
            giWait(2.0);
            giAddProperty(3016, 30, true);
            giWait(2.0);
            maze_var3 = 3;
            giStartTradeSystem("shop035", "");
        }
    }
    else
    {
        giStartTradeSystem("shop035", "Buiness_Q09_5001");
    }
    giNpcResetDir("5001");
    giNpcResumeBeh("5001");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("5002");
    giNpcFaceToCurrentPlayer("5002", true);
    giCurrentPlayerFaceToNpc("5002", true);
    if (maze_var4 != 0)
    {
        if (maze_var4 != 2)
        {
            giStartTradeSystem("shop026", "");
        }
        else
        {
            giTalk("方正：原来、原来是秀华？嘿、嘿嘿～她、她说改天还会再来，哈哈、哈哈哈哈～～来，这几件东西你拿好了，别客气！", "");
            giAddEquipment(3514, true);
            giWait(2.0);
            giAddPrescription(8157, true);
            giWait(2.0);
            maze_var4 = 3;
            giStartTradeSystem("shop026", "");
        }
    }
    else
    {
        giStartTradeSystem("shop026", "Buiness_Q09_5002");
    }
    giNpcResetDir("5002");
    giNpcResumeBeh("5002");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("5003");
    giNpcFaceToCurrentPlayer("5003", true);
    giCurrentPlayerFaceToNpc("5003", true);
    if (maze_var2 != 0)
    {
        if (maze_var2 != 1)
        {
            giStartTradeSystem("shop005", "");
        }
        else
        {
            if (giCheckPackProperty(3254, 1))
            {
                giTalk("余子坚：英雄！您真是我们即墨人的大英雄！打跑了狐仙，还帮我找回了这支救命用的参！这些药是我一直藏着舍不得卖的，送给英雄您，就算是我小小的心意吧！", "");
                giDelProperty(3254, 1, true);
                giWait(2.0);
                giAddProperty(3031, 10, true);
                giWait(2.0);
                giAddProperty(3003, 10, true);
                giWait(2.0);
                maze_var2 = 2;
            }
            giStartTradeSystem("shop005", "");
        }
    }
    else
    {
        giStartTradeSystem("shop005", "Buiness_Q09_5003");
    }
    giNpcResetDir("5003");
    giNpcResumeBeh("5003");
    giPlayerUnLock();
}

void func5004()
{
    giPlayerLock();
    giNpcPauseBeh("5004");
    giNpcFaceToCurrentPlayer("5004", true);
    giCurrentPlayerFaceToNpc("5004", true);
    giStartTradeSystem("shop015", "");
    giNpcResetDir("5004");
    giNpcResumeBeh("5004");
    giPlayerUnLock();
}

void func5005()
{
    int inn_dialog_result = 0;
    int money_amount = 0;
    int common_dialog_last_select = 0;

    giPlayerLock();
    giNpcPauseBeh("5005");
    giNpcFaceToCurrentPlayer("5005", true);
    giCurrentPlayerFaceToNpc("5005", true);
    giShowInnDialog(false);
    inn_dialog_result = giGetInnDialogResult();
    money_amount = giGetMoney();
    if (giGetInnDialogResult() == 1)
    {
        giShowCommonDialogInSelectMode("花费100文钱住宿吗？", 0.5, 0.4);
        common_dialog_last_select = giCommonDialogGetLastSelect();
        if (giCommonDialogGetLastSelect() == 1)
        {
            if (money_amount >= 100)
            {
                giFlashOutBlack(3.0, true, true);
                giPayMoney(100, true);
                giPlayerTakeARest();
                giWait(2.0);
                giFlashInBlack(3.0, true);
            }
            else
            {
                giTalk("谭德海：您身上的钱不够。", "");
            }
        }
    }
    giPlayerSetAttr(-1, -1, 100);
    giNpcResetDir("5005");
    giNpcResumeBeh("5005");
    giPlayerUnLock();
}

void Buiness_Q09_5001()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("哈哈，小哥，如果你有时间，能不能帮我把这包糕点拿去给<colour red=255 green=187 blue=0 alpha=255>下面栈道上的任老爹</colour><dc0>尝尝？</dc0><br/><dc0>你愿意帮我送去吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var3 = 1;
        giAddProperty(3255, 1, true);
        giWait(2.0);
    }
}

void Buiness_Q09_5002()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("不知道是什么时候的事情，铺子里忽然多出一条发带，上面还绣了我的名字……可是我用的衣裳帽子都是直接买现成的，从来没见过这种东西！小哥你能<colour red=255 green=187 blue=0 alpha=255>帮我去问问</colour><dc0>，有谁丢了发带？</dc0><br/><dc0>你愿意帮我去问问吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var4 = 1;
    }
}

void Buiness_Q09_5003()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("唉呀呀！我的天哪！上好的紫蕴玄参，王家婆婆等着救命用的，竟被<colour red=255 green=187 blue=0 alpha=255>狐仙</colour><dc0>他老人家带走了！这可怎么办才好啊！</dc0><br/><dc0>你愿意帮我去取回来吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var2 = 1;
    }
}
