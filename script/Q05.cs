// Structured PAL4 reconstruction for Q05.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q05_Q05_init()
{
    if (global_mvar >= 60200 /* 第二章 / 4-1-2.寻仙昆仑 / 往南上山 */)
    {
        if (global_mvar < 70500 || global_mvar < 90100 && global_mvar >= 70901 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
        {
            giIMMBegin();
            giSetObjectVisible("entrance0", false);
            giSetObjectVisible("entrance2", false);
            giSetObjectVisible("entrance1", true);
            giIMMEnd();
            giArenaReadyRestore();
        }
        else
        {
            giIMMBegin();
            giSetObjectVisible("entrance0", true);
            giSetObjectVisible("entrance2", true);
            giSetObjectVisible("entrance1", false);
            giIMMEnd();
            giArenaReadyRestore();
        }
    }
    else
    {
        giIMMBegin();
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance0", false);
        giSetObjectVisible("entrance2", false);
        giEventVolumeVisible("ev_Q05_Q05_24", false);
        giIMMEnd();
        giArenaReadyRestore();
    }
    if (global_mvar < 60200 /* 第二章 / 4-1-2.寻仙昆仑 / 往南上山 */)
    {
        LL_001(global_mvar);
        giArenaReadyRestore();
    }
    else
    {
        giEventVolumeVisible("ev_Q05_Q05_29", false);
        giArenaReadyRestore();
    }
    if (global_mvar == 51400 /* 陈州行侠 */)
    {
        func2001();
    }
}

void Q05_Q05P_init()
{
    if (global_mvar != 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2003();
    }
}

void Q05_N02_init()
{
    if (global_mvar != 51600 /* 第一章 / 4-1-1.寻仙昆仑 / 恢复体力 */)
    {
        LL_001(global_mvar);
        giArenaReadyRestore();
    }
    else
    {
        LL_001(global_mvar);
        func2002();
    }
}

void Q05_N01b_init()
{
    if (global_mvar > 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giSetNpcVisible("4008", false);
    }
    giArenaReadyRestore();
}

void Q05_N05a_init()
{
    if (global_mvar > 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giSetNpcVisible("4017", true);
    }
    giArenaReadyRestore();
}

void Q05_N05b_init()
{
    if (global_mvar > 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giSetNpcVisible("4037", true);
        giSetNpcVisible("4036", true);
    }
    giArenaReadyRestore();
}

void Q05_N05c_init()
{
    if (global_mvar > 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giSetNpcVisible("4058", true);
    }
    giArenaReadyRestore();
}

void LL_001(int arg0)
{
    // typed_typeinfo_hints: primary=void; extras=[int]
    // prototype_hint: void LL_001(int)
    if (global_mvar > 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giSetNpcVisible("4045", true);
        giSetNpcVisible("4046", true);
        giSetNpcVisible("4003", false);
        giSetNpcVisible("4006", false);
        giSetNpcVisible("4007", false);
        giSetNpcVisible("4011", false);
        giSetNpcVisible("4018", false);
        giSetNpcVisible("4030", false);
        giSetNpcVisible("4054", false);
        giSetNpcVisible("4080", false);
        giSetNpcVisible("4084", false);
        giSetNpcVisible("4085", false);
    }
    if (global_mvar >= 90100 || var_shop034 == 1 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giSetNpcVisible("4029", true);
    }
}

void func1001()
{
    giArenaLoad("Q05", "N01", "N01a", true);
    giPlayerCurrentSetPos(151.7, 0.1, 2.1);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q05", "N02", "", true);
    giPlayerCurrentSetPos(-241.0, 106.2, 190.3);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q05", "N01", "N01b", true);
    giPlayerCurrentSetPos(151.7, 0.1, 2.1);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q05", "N02", "", true);
    giPlayerCurrentSetPos(-238.2, 106.2, 6.6);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q05", "N01", "N01c", true);
    giPlayerCurrentSetPos(151.7, 0.1, 2.1);
    giPlayerCurrentSetAng(270.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q05", "N02", "", true);
    giPlayerCurrentSetPos(-238.1, 106.2, -176.4);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1007()
{
    if (global_mvar != 51600 /* 第一章 / 4-1-1.寻仙昆仑 / 恢复体力 */)
    {
        giArenaLoad("Q05", "N02", "", true);
        giPlayerCurrentSetPos(182.0, 0.5, -60.9);
        giPlayerCurrentSetAng(270.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
    else
    {
        giFlashOutBlack(0.5, true, true);
        giArenaLoad("Q05", "N02", "", true);
    }
}

void func1008()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(218.2, 18.3, 1349.1);
        giPlayerCurrentSetAng(183.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(218.2, 18.3, 1349.1);
        giPlayerCurrentSetAng(183.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1009()
{
    giArenaLoad("Q05", "N03", "", true);
    giPlayerCurrentSetPos(0.4, 0.9, 338.9);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1010()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(-573.2, 18.3, 1120.3);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(-573.2, 18.3, 1120.3);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1011()
{
    giArenaLoad("Q05", "N04", "", true);
    giPlayerCurrentSetPos(-0.3, 0.2, 107.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1012()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(1686.4, 18.3, -455.8);
        giPlayerCurrentSetAng(310.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(1686.4, 18.3, -455.8);
        giPlayerCurrentSetAng(310.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1013()
{
    giArenaLoad("Q05", "N05", "N05a", true);
    giPlayerCurrentSetPos(-79.1, 0.0, 36.6);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1014()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(-256.7, 18.3, -1071.8);
        giPlayerCurrentSetAng(10.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(-256.7, 18.3, -1071.8);
        giPlayerCurrentSetAng(10.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1015()
{
    giArenaLoad("Q05", "N05", "N05b", true);
    giPlayerCurrentSetPos(-79.1, 0.0, 36.6);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1016()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(-945.3, 18.3, -851.7);
        giPlayerCurrentSetAng(334.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(-945.3, 18.3, -851.7);
        giPlayerCurrentSetAng(334.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1017()
{
    giArenaLoad("Q05", "N05", "N05c", true);
    giPlayerCurrentSetPos(-79.1, 0.0, 36.6);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1018()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(1952.1, 145.1, 1326.3);
        giPlayerCurrentSetAng(250.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(1952.1, 145.1, 1326.3);
        giPlayerCurrentSetAng(250.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1019()
{
    giArenaLoad("Q05", "N05", "N05d", true);
    giPlayerCurrentSetPos(-79.1, 0.0, 36.6);
    giPlayerCurrentSetAng(90.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1020()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(653.1, 145.1, 2410.6);
        giPlayerCurrentSetAng(193.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(653.1, 145.1, 2410.6);
        giPlayerCurrentSetAng(193.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1021()
{
    giArenaLoad("Q05", "N06", "", true);
    giPlayerCurrentSetPos(0.0, 0.0, 73.9);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1022()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(666.1, 18.3, -958.1);
        giPlayerCurrentSetAng(340.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(666.1, 18.3, -958.1);
        giPlayerCurrentSetAng(340.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1023()
{
    giArenaLoad("Q05", "N06", "", true);
    giPlayerCurrentSetPos(200.3, 0.0, 72.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1024()
{
    if (global_mvar < 161100 /* 第四章 / 9-7-1.终局 / 飞上琼华 */)
    {
        giArenaLoad("Q05", "Q05", "", true);
        giPlayerCurrentSetPos(806.4, 18.3, -905.0);
        giPlayerCurrentSetAng(340.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q05", "Q05P", "", true);
        giPlayerCurrentSetPos(806.4, 18.3, -905.0);
        giPlayerCurrentSetAng(340.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1025()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 70500 || global_mvar < 90100 && global_mvar >= 70901 /* 第二章 / 4-3-4.御剑逍遥 / 东南荒漠 / 修仙习剑 */)
    {
        if (global_mvar != 60200 /* 第二章 / 4-1-2.寻仙昆仑 / 往南上山 */)
        {
            giArenaLoad("M09", "1", "", true);
            giPlayerCurrentSetPos(-3450.8, -226.2, -1768.2);
            giPlayerCurrentSetAng(30.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        else
        {
            giFlashOutBlack(0.5, true, true);
            giArenaLoad("M09", "1", "", true);
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
                giPlayerWalkTo(leader_player_id, 250.7, 145.1, 2607.0, true);
                giPlayerSetDir(leader_player_id, 175.0, true);
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
            giArenaLoad("M09", "1", "", true);
            giPlayerCurrentSetPos(-3450.8, -226.2, -1768.2);
            giPlayerCurrentSetAng(30.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1026()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar <= 70900 && global_mvar >= 70500 || global_mvar >= 90100 /* 第二章 / 4-4-2.叹沧桑 / 禀报掌门 */)
    {
        giPlayerLock();
        giSelectDialogAddItem("1.御剑飞行  ");
        giSelectDialogAddItem("2.什么都不做");
        giSelectDialogSetDefaultSelect(1);
        giShowSelectDialog("              准备<colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>吗？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            leader_player_id = giPlayerGetLeader();
            giPlayerWalkTo(leader_player_id, 2221.1, 145.6, 800.0, true);
            giPlayerSetDir(leader_player_id, 275.0, true);
            giCameraAutoSeek(true);
            giCameraSetMode(0, true);
            giPlayerUnLock();
        }
        else
        {
            giShowWorldMap();
        }
    }
}

void func1027()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(1223.7, 145.1, 2193.0, true);
    giPlayerCurrentSetAng(214.0);
    giSetPortrait("101C", true);
    giTalk("云天河：还是不要进去为好。", "");
    giPlayerUnLock();
}

void func2001()
{
    if (global_mvar == 51400 /* 陈州行侠 */)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 1945.9, 145.1, 957.9);
        giPlayerSetAng(0, 230.0);
        giPlayerSetPos(1, 1988.4, 145.1, 928.5);
        giPlayerSetAng(1, 252.0);
        giPlayerSetPos(2, 1984.4, 145.1, 876.9);
        giPlayerSetAng(2, 278.0);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("4002", false);
        giSetNpcVisible("4065", false);
        giSetNpcVisible("4027", false);
        giSetNpcVisible("4004", false);
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4057", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giArenaReady();
        giWait(1.5);
        giPlayerDoAction(0, "J16", -1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：哟嚯～御剑果然好玩！整个人都飞在天上！", "42252");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：这儿……似乎是一个市镇？", "42253");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giNpcSetDir("MN001", 98.0, false);
        giNpcSetDir("MN002", 74.0, false);
        giWait(0.8);
        giSetPortrait("203B", true);
        giTalk("怀朔：此地乃是播仙镇，我和师妹只能将你们带到这里了。若想入门拜师，就一定要自行上山。", "42254");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：山？哈，那也没啥，走山路一点都不费力。", "42255");
        giIMMBegin();
        giCameraRunSingle("007", false);
        giNpcSetAng("MN002", 24.0);
        giNpcSetAng("MN001", 38.0);
        giIMMEnd();
        giWait(0.4);
        giNpcDoAction("MN002", "J03", 1, false);
        giSetPortrait("202C", false);
        giTalk("璇玑：掉以轻心～小心到时候哭鼻子！", "42256");
        giSetPortrait("203B", true);
        giTalk("怀朔：……山中设有不少险阻，乃是为考验求仙之人的毅力，诸位多加小心。", "42257");
        giNpcSetDir("MN002", 342.0, true);
        giSetPortrait("202D", false);
        giTalk("璇玑：师兄～不用讲一堆啦，他们自己去镇上打听打听，就能知道怎么上山，反正我们能帮的也都帮了。", "42258");
        giSetPortrait("106B", false);
        giTalk("柳梦璃：谢谢两位，接下来若有任何困难，就让我们试试自行解决，方能显出求仙的诚心。", "42259");
        giSetPortrait("203B", true);
        giTalk("怀朔：多保重，下回见面时说不定已是同门。", "42260");
        giSetPortrait("202D", false);
        giTalk("璇玑：师兄～走～啦～！！", "42261");
        giPlayerSetPos(1, 2004.8, 145.1, 936.5);
        giPlayerSetPos(0, 1927.2, 145.1, 961.9);
        giPlayerSetPos(2, 1977.8, 145.1, 877.0);
        giNpcSetDir("MN001", 169.0, false);
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("203B", true);
        giTalk("怀朔：好好好……", "42262");
        giNpcSetDir("MN002", 208.0, false);
        giNpcSetDir("MN001", 204.0, false);
        giWait(0.7);
        giEffectPlayWithNPC("H_089", 1, "MN002");
        giNpcBlendOut("MN002", 1.5, false);
        giEffectPlayWithNPC("H_089", 1, "MN001");
        giNpcBlendOut("MN001", 1.5, false);
        giWait(3.0);
        giCameraRunSingle("008", true);
        giWait(0.5);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：就知道没那么容易……", "42263");
        giPlayerDoAction(1, "J19", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：啊……", "42264");
        giIMMBegin();
        giPlayerSetDir(2, 40.0, false);
        giPlayerSetDir(0, 102.0, false);
        giIMMEnd();
        giSetPortrait("101D", true);
        giTalk("云天河：……！", "42265");
        giPlayerWalkTo(2, 1988.7, 145.1, 893.4, false);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetAng(0, 98.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giPlayerEndMove(2);
        giPlayerDoAction(2, "J03", -1, false);
        giSetPortrait("106G", false);
        giTalk("柳梦璃：菱纱，你怎么了？！ ", "42266");
        giWait(1.0);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……我也不知道怎么回事，这几天经常头晕……总觉得很累……", "42267");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.5);
        giPlayerSetDir(1, 202.0, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：没事，一会儿就好了……先去打探打探上山的事……", "42268");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：……今天不上山了！", "42269");
        giPlayerSetDir(1, 300.0, false);
        giPlayerSetDir(2, 328.0, false);
        giWait(1.0);
        giSetPortrait("101H", true);
        giTalk("云天河：我们先找那个叫＂客栈＂的地方休息一下。", "42270");
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：没关系，我头不晕了……", "42271");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：那也不行，还是过一晚再走。", "42272");
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：喂，不是说过在外面都听我的吗？！", "42273");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetAng(0, 102.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：话是这么说没错，可是怀朔讲过那里很危险，所以你一定要先去客栈休息。", "42274");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：你、你这么关心我干嘛……", "42275");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……哼，你走山路一点都不费力，我却要休息，显得我很差劲似的……", "42276");
        giPlayerSetDir(2, 5.0, true);
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：我看别争了，就按云公子说的吧。", "42277");
        giPlayerSetDir(1, 202.0, true);
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：我也会担心你啊～菱纱。", "42278");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……好、好嘛。", "42279");
        giPlayerDoAction(0, "J14", 1, false);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101B", true);
        giTalk("云天河：呵呵，<colour red=255 green=187 blue=0 alpha=255>那还是先去客栈</colour><dc0>。</dc0>", "42280");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("4002", true);
        giSetNpcVisible("4065", true);
        giSetNpcVisible("4027", true);
        giSetNpcVisible("4004", true);
        giSetNpcVisible("4001", true);
        giSetNpcVisible("4057", true);
        giIMMEnd();
        global_mvar = 51600; // 0x0000C990, 第一章 / 4-1-1.寻仙昆仑 / 恢复体力
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(1906.8, 145.1, 865.4);
        giPlayerCurrentSetAng(202.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 51600 /* 第一章 / 4-1-1.寻仙昆仑 / 恢复体力 */)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 246.0, 0.5, -59.8);
        giPlayerSetAng(0, 268.0);
        giPlayerSetPos(1, 246.2, 0.5, -88.4);
        giPlayerSetAng(1, 214.0);
        giPlayerSetPos(2, 243.2, 0.5, -49.1);
        giPlayerSetAng(2, 270.0);
        giNpcSetAng("4009", 350.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("4010", false);
        giSetNpcVisible("4080", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(3.0, false);
        giArenaReady();
        giWait(0.8);
        giCameraRunSingle("002", false);
        giWait(0.5);
        giPlayerWalkTo(2, 137.2, 0.5, -102.0, false);
        giWait(1.2);
        giPlayerWalkTo(0, 171.1, 0.5, -60.3, false);
        giWait(0.5);
        giPlayerWalkTo(1, 214.6, 0.5, -90.8, false);
        giPlayerEndMove(0);
        giPlayerEndMove(2);
        giIMMBegin();
        giPlayerSetDir(2, 146.0, false);
        giPlayerSetDir(0, 184.0, false);
        giPlayerSetDir(1, 214.0, false);
        giIMMEnd();
        giCameraWait();
        giWait(1.0);
        giTalk("狄丽拜尔：三位客人，欢迎欢迎！神仙会保佑你们的。", "42281");
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：老板，请给我们三间客房。", "42282");
        giWait(0.5);
        giPlayerEndAction(2);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：……这里的房子都怪模怪样，圆圆的，顶上还有尖刺……", "42283");
        giPlayerEndAction(0);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giTalk("狄丽拜尔：哈哈，西域和中土不同，我们世世代代都住在这种房子里，才能躲过风沙日晒。", "42284");
        giWait(0.5);
        giNpcSetDir("4009", 36.0, true);
        giWait(0.5);
        giTalk("狄丽拜尔：这个姑娘面孔发白，中暑了吧？这样的身体千万别去仙山！", "42285");
        giWait(0.5);
        giCameraRunSingle("004", true);
        giWait(0.8);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：咦？！老板，你怎么知道我们要去那里？", "42286");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("狄丽拜尔：姑娘～你们几个的装扮一看就是从中原来的，带了刀剑，不是做生意，那应该就是去仙山了。", "42287");
        giWait(0.5);
        giTalk("狄丽拜尔：山上的神仙连许多中原人都知道，来这儿就是想见神仙一面。", "42288");
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：那，你能告诉我们去山上的路吗？", "42289");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giNpcSetDir("4009", 350.0, true);
        giWait(0.5);
        giTalk("狄丽拜尔：当然，这儿人人都知道，<colour red=255 green=187 blue=0 alpha=255>出了播仙镇，往南就可以去仙山</colour><dc0>，可是没什么人能见到神仙的。</dc0>", "42290");
        giSetPortrait("106D", true);
        giTalk("柳梦璃：这又是为什么呢？", "42291");
        giTalk("狄丽拜尔：山路上有会伤人的怪物啊，怪物也杀不死，很多人就逃回了镇上。也有人去了那边，再也没回来过，也许是被神仙带走了吧……", "42292");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：呀……", "42293");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("005", true);
        giWait(0.5);
        giPlayerSetDir(0, 106.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J18", 1, false);
        giWait(0.5);
        giSetPortrait("101B", true);
        giTalk("云天河：菱纱，不用怕～山上的怪物打不过我们的。", "42294");
        giPlayerEndAction(0);
        giPlayerSetDir(1, 294.0, false);
        giPlayerSetDir(2, 78.0, false);
        giPlayerDoAction(1, "J14", -1, false);
        giWait(0.5);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：哼，谁怕了？", "42295");
        giPlayerDoAction(2, "J14", 1, false);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerEndAction(2);
        giWait(0.5);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：镇上的人好像都会说中原话，也很崇拜剑仙，嗯……就是他们说的神仙，要不是房子和衣着不一样，周围又全是黄沙，真看不出这是西域呢。", "42296");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("4009", 36.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giPlayerSetDir(0, 183.0, false);
        giPlayerSetDir(1, 214.0, false);
        giPlayerSetDir(2, 168.0, false);
        giWait(0.8);
        giTalk("狄丽拜尔：姑娘，播仙镇能变成绿洲，是因为神仙怜悯我们，才让仙山上的水流下来，所有人都不能忘记这份恩情。", "42297");
        giTalk("狄丽拜尔：神仙保佑！要是没有水，也就没有中原人来做生意。中原话都是那些商人教给我们的。", "42298");
        giWait(0.3);
        giCameraRunSingle("007", true);
        giWait(0.3);
        giPlayerDoAction(2, "C08", 1, true);
        giSetPortrait("106B", true);
        giTalk("柳梦璃：真是叫人大长见识。", "42299");
        giWait(0.5);
        giNpcSetDir("4009", 350.0, true);
        giWait(0.5);
        giTalk("狄丽拜尔：客人如果喜欢这儿，就多住一段时间吧。", "47004");
        giWait(0.5);
        giNpcSetDir("4009", 36.0, true);
        giWait(0.5);
        giTalk("狄丽拜尔：来，我带你们去楼上的房间，再给这姑娘送一杯热乎乎的奶茶。神仙会保佑你快点好的！", "42300");
        giWait(1.0);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：谢谢……", "42301");
        giWait(0.5);
        giPlayerSetDir(0, 106.0, false);
        giPlayerSetDir(2, 78.0, false);
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：我……我又头晕了……难道真的中暑了吗？", "42302");
        giFlashOutBlack(2.0, true, true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcSetAng("4009", 5.0);
        giIMMBegin();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giPlayerSetVisible(1, false);
        giPlayerSetPos(2, -263.4, 106.2, 176.0);
        giPlayerSetAng(2, 180.0);
        giPlayerSetPos(1, -243.5, 106.2, -118.0);
        giPlayerSetAng(1, 0.0);
        giPlayerSetPos(0, -256.6, 106.2, 4.0);
        giPlayerSetAng(0, 58.0);
        giIMMEnd();
        gi2DSoundPlay("WJ063", 1);
        giWait(4.0);
        giFlashInBlack(2.0, false);
        giWait(1.0);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：（……呃……睏死了，晚上没睡好……）", "42303");
        giWait(1.5);
        giPlayerWalkTo(2, -220.1, 106.2, 43.6, true);
        giWait(0.3);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 232.0, true);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：云公子，你怎么不太有精神的样子？ ", "42304");
        giWait(0.3);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetAng(0, 36.0);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：啊？是、是吗？", "42305");
        giPlayerDoAction(2, "C08", 1, false);
        giWait(1.5);
        giSetPortrait("101E", false);
        giTalk("云天河：……其实，昨天夜里我好像一直听到菱纱在说梦话……", "42306");
        giWait(0.5);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……她……肯定很想念自己的爹娘吧……", "42307");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：咦？原来你也听到了啊。", "42308");
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：……", "42309");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        gi2DSoundPlay("WJ077", 1);
        giPlayerSetVisible(1, true);
        giCameraRunSingle("003", false);
        giWait(0.3);
        giPlayerWalkTo(1, -240.4, 106.2, -49.1, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 350.0, true);
        giWait(0.6);
        giCameraWait();
        giPlayerSetDir(0, 158.0, false);
        giPlayerSetDir(2, 185.0, false);
        giWait(1.0);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：……菱纱，你，好了吗？", "42310");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：那当然，小病小痛，不算什么～", "42311");
        giWait(0.5);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……天呐，你那黑眼圈是怎么回事？看起来好蠢哦～", "42312");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：我……还不是因为……昨晚你……", "42313");
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：什么？大点声行吗？", "42314");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：……不说了，没什么。", "42315");
        giWait(1.0);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：（奇怪……一点不像平时的天河，难道是水土不服？）", "42316");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：是不是换你不舒服了？要不然，我们再歇息一下？", "42317");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("005", true);
        giPlayerDoAction(0, "J05", 1, false);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101B", true);
        giTalk("云天河：不用不用，<colour red=255 green=187 blue=0 alpha=255>我们快点上山，</colour><dc0>越快越好！呵呵。</dc0>", "42318");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：唉，这么大的人了，还一心只想着玩……", "42319");
        giPlayerDoAction(2, "J14", 1, false);
        giWait(0.8);
        giFlashOutBlack(2.0, true, true);
        giPlayerEndAction(0);
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("4010", true);
        giSetNpcVisible("4080", true);
        giIMMEnd();
        giSetFullHP();
        giSetFullMP();
        global_mvar = 60200; // 0x0000EB28, 第二章 / 4-1-2.寻仙昆仑 / 往南上山
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(-70.1, 0.5, -191.0);
        giPlayerCurrentSetAng(60.0);
        giCameraSetMode(2, true);
        giCameraSeekToPlayer();
        giPlayerUnLock();
        giFlashInBlack(0.5, true);
    }
}

void func2003()
{
    if (global_mvar == 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 773.9, 18.3, 324.6);
        giPlayerSetAng(0, 334.0);
        giPlayerSetPos(1, 808.1, 18.3, 333.9);
        giPlayerSetAng(1, 344.0);
        giPlayerSetPos(3, 863.1, 18.3, 338.5);
        giPlayerSetAng(3, 330.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giNpcSetPos("MN001", 651.4, 23.9, 224.4);
        giNpcSetAng("MN001", 26.0);
        giSetObjectVisible("title09", false);
        giSetNpcVisible("5006", false);
        giSetNpcVisible("5007", false);
        giSetNpcVisible("5008", false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(3.0);
        giCameraRunSingle("002", false);
        giWait(0.5);
        giPlayerWalkTo(3, 757.8, 18.3, 538.2, false);
        giWait(0.5);
        giPlayerWalkTo(1, 763.7, 18.3, 474.3, false);
        giWait(0.3);
        giPlayerWalkTo(0, 701.9, 18.3, 476.7, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 348.0, true);
        giPlayerEndMove(1);
        giPlayerEndMove(3);
        giCameraWait();
        giWait(1.0);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：怎么镇上变得冷清好多？难道出了什么事……？", "46595");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J13", 1, true);
        giWait(1.0);
        giSetNpcVisible("MN001", true);
        giCameraRunSingle("003", false);
        giNpcWalkTo("MN001", 713.5, 18.3, 386.0, true);
        giNpcSetDir("MN001", 26.0, true);
        giCameraWait();
        giTalk("库莫若：中原来的朋友，你们怎么还不离开播仙镇？", "46596");
        giWait(0.5);
        giPlayerSetDir(1, 198.0, false);
        giPlayerSetDir(0, 158.0, false);
        giPlayerSetDir(3, 196.0, false);
        giWait(1.0);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：大叔，请问镇上的人都去了哪里？为什么一下子这样冷清？", "46597");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giCameraRunSingle("004", false);
        giWait(0.8);
        giTalk("库莫若：唉……姑娘你不知道，就在一天以前，仙山上出了天大的事啊，吓得老人孩子都不敢出门了……", "46598");
        giWait(1.0);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：……！请问到底是什么事？！", "46599");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.3);
        giTalk("库莫若：是神仙……神仙发怒了……忽然之间，大地轰鸣、河水沸腾，天空也变得暗沉沉，等到一切平息下来，绿洲的水已经浑浊了……", "46600");
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：啊？！", "46601");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：那镇上的人有没有受伤？！", "46602");
        giWait(0.5);
        giCameraRunSingle("005", false);
        giTalk("库莫若：受伤倒是没有，但是水里混了沙土，不再清澈，这是以前从来没有过的事情，老人们都说这不吉利，水会渐渐枯竭的，然后会有大灾难发生……", "46603");
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.3);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：那后来呢？还发生了其他事吗？", "46604");
        giWait(0.8);
        giTalk("库莫若：……大地的震动停了之后，仙山上就出现了一座浮着的山峰，慢慢往上升，现在飞得太高，已经看不见了……", "46605");
        giSetPortrait("105F", true);
        giTalk("慕容紫英：……！！", "46606");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：浮着的山峰？会不会是……", "46607");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("库莫若：听说那是神仙住的地方，他们要回天上去了，要遗弃我们、遗弃这个镇子了，再也不会像以前一样赐给我们干净的水……", "46608");
        giCameraRunSingle("006", true);
        giTalk("库莫若：唉，天神保佑……你们不是镇上的人，快点离开吧，如果真有灾难发生，不要留下受苦……", "46609");
        giWait(0.5);
        giNpcWalkTo("MN001", 651.4, 23.9, 224.4, true);
        giSetNpcVisible("MN001", false);
        giWait(0.8);
        giCameraRunSingle("007", false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：…………", "46610");
        giWait(1.0);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……琼华派已经升起，竟还祸及山脚下的村镇……", "46611");
        giPlayerSetDir(0, 50.0, false);
        giPlayerSetDir(1, 6.0, true);
        giWait(0.6);
        giSetPortrait("101H", false);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>我们现在赶快御剑追上去！</colour>", "46612");
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, true);
        giWait(0.5);
        giCameraRunSingle("011", true);
        giPlayerWalkTo(0, 727.1, 18.3, 475.5, true);
        giSetPortrait("101J", true);
        giTalk("云天河：菱纱……", "46613");
        giWait(0.5);
        giPlayerSetDir(1, 276.0, true);
        giWait(0.7);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……？", "46614");
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giIMMBegin();
        giSetObjectVisible("Jeffect001", true);
        giSetObjectVisible("Jeffect002", true);
        giIMMEnd();
        giWait(3.0);
        giIMMBegin();
        giSetObjectVisible("Jeffect001", false);
        giSetObjectVisible("Jeffect002", false);
        giIMMEnd();
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：天河……？", "46615");
        giWait(0.3);
        giSetPortrait("101J", false);
        giTalk("云天河：你一定要去的话，这样会好一点吧？", "46616");
        giWait(1.0);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：……嗯，暖暖的，谢谢你。", "46617");
        giWait(0.8);
        giPlayerDoAction(0, "C08", 1, true);
        giSetPortrait("101J", false);
        giTalk("云天河：走！去找玄霄！", "46618");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giSetNpcVisible("5006", true);
        giSetNpcVisible("5007", true);
        giSetNpcVisible("5008", true);
        giSetObjectVisible("title09", true);
        giIMMEnd();
        global_mvar = 161100; // 0x0002754C, 第四章 / 9-7-1.终局 / 飞上琼华
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(761.2, 18.3, 613.6);
        giPlayerCurrentSetAng(326.0);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2004()
{
    if (global_mvar < 51600 /* 第一章 / 4-1-1.寻仙昆仑 / 恢复体力 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -564.5, 58.3, -447.1, true);
        giPlayerSetDir(0, 175.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101A", true);
        giTalk("云天河：现在不要出城了，<colour red=255 green=187 blue=0 alpha=255>先去客栈休息</colour><dc0>。</dc0>", "");
        giPlayerUnLock();
    }
}

void func4001()
{
    giPlayerLock();
    giNpcPauseBeh("4001");
    giNpcFaceToCurrentPlayer("4001", true);
    giCurrentPlayerFaceToNpc("4001", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("赫依里：天神真的要降罪给我们，我们也是没有办法的，但不管怎么样，我绝对不会离开播仙镇！", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("赫依里：现在马贼已经没有以前那么嚣张了，一定又是神仙保佑我们！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("赫依里：附近有个村子断了水，整个村都被黄沙埋了……天神保佑，我们是住在仙山脚下……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("赫依里：精铁铸老板造兵器的手艺不错！播仙镇上的小伙子，几乎都有一把他打的刀。");
        giRandTalkPush("赫依里：西域风沙大，雨下得少，如果不是有了仙山上流下的河水，播仙镇一定会变成一片荒漠。");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("乌依古尔：唉……以前听说沙漠里有个村落的人触怒了天神，天神发怒惩罚他们，我还不怎么信，现在，惩罚就要降到我们头上了……这可怎么办啊……", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("乌依古尔：天神保佑～官府会来管马贼的事，一定也是天神安排的，这段日子总算平静很多了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("乌依古尔：最近马贼又开始猖獗了，来往客商常常被抢，镇上的人天天都过得不安心！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("乌依古尔：播仙镇以前叫且末郡，一直都是丝绸之路上的重镇，大伙儿很长时间受仙人保佑，为了感激，就把这里改叫播仙镇了。");
        giRandTalkPush("乌依古尔：镇上往来的商人很多，全都在镇中心的车马驿歇息，你们想要住店的话，就去那里吧。");
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
    if (global_mvar >= 160100)
    {
        giRandTalkPush("艾沙：……是不是要有什么大事发生了？我总觉得……心里很慌……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("艾沙：以前上山想要见神仙的人，这段日子都下山了，沙依木告诉我，仙人不见他们，让所有人都离开。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("艾沙：镇南药铺伊哈桑老板的药可千万别去买！上回我阿爸跌伤，擦了他的跌打药酒，膝盖肿得像个大包！");
        giRandTalkPush("艾沙：看你的打扮，是不是要去仙山呢？其实我也去过，不过那实在太危险了，我半路就跑了回来……");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("阿丹：难道、难道是伊哈桑那个黑心的人做了错事，天神才会惩罚我们？我们把伊哈桑交给天神处置，天神会原谅我们吗？", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("阿丹：伊哈桑的心有点黑，他总要骗中原来的客人，拿不好的药冒充灵药，你千万别上当！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("阿丹：马贼打劫往来商客，受了伤的人都快把药店的大门给挤破了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿丹：有很多中原人会到播仙镇来做买卖，车马驿的生意好得不得了，老板娘从早忙到晚，整天乐呵呵～");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("伊哈桑：哼！什么天神的惩罚，我伊哈桑才不相信呢！不就是河水有点浑浊吗？有什么要紧的！", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("伊哈桑：马贼被打跑了……没人受伤，我这药店也就没生意了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("伊哈桑：自从附近马贼猖獗，来我店里买伤药的人就越来越多，生意好啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("伊哈桑：嘿嘿～你是不是要上昆仑山找仙人？那里的路可不好走，要不要在我这儿买些伤药？以防万一嘛！");
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
    if (global_mvar >= 160100)
    {
        giRandTalkPush("乔勒旁：听说做了仙人以后就不会老，可是如果老了以后再做仙人，会变成什么样呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("乔勒旁：你的衣服……好漂亮～你是不是见到仙人了？告诉我他长什么样好不好～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("乔勒旁：你是去昆仑山拜师的吧？正好我也是～不如我们一起上山，也好有个照应，你看怎么样？");
        giRandTalkPush("乔勒旁：一听说我要上山去找仙人，阿妈就给我备了一大箱的东西，可我力气小，那么大的箱子怎么抬得动？");
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
    giCurrentPlayerFaceToNpc("4007", true);
    giRandTalkRelease();
    if (global_mvar >= 160100)
    {
        giRandTalkPush("陈旺财：没用的官府！把马贼打跑又怎样？也不能把我被抢的丝绸追回来啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("陈旺财：该死的马贼！抢了我一整箱丝绸！这回连老本都蚀了，早知道就不带这么多上路……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("陈旺财：这批丝绸要是卖了好价钱，我就可以回中原买新房讨老婆了～哈哈！");
        giRandTalkPush("陈旺财：西域的姑娘真是热情又大胆，我刚到这儿第一天，就被隔壁绿洲酒肆的老板娘拉进店里灌了个烂醉！");
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
    if (global_mvar >= 160100)
    {
        giRandTalkPush("何生钱：所有人都传山上住着仙人，可谁也没亲眼见过啊，你说～要是能弄到仙人衣服上的衣角，那得值多少钱啊！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("何生钱：商队在路上遇到马贼了！还好我这回只带了一小包金银饰物，拎起包就跑，正巧朝廷的官兵赶来，这才逃过一劫。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("何生钱：没想到沙尘满天的荒漠中竟然还有播仙镇这样的绿洲！这对商人来说实在太好了！");
        giRandTalkPush("何生钱：我这是第一回跟着商队来西域，一路上就这儿还能住人，其他地方除了黄沙还是黄沙……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4008");
    giNpcResumeBeh("4008");
    giPlayerUnLock();
}

void func4010()
{
    giPlayerLock();
    giNpcPauseBeh("4010");
    giNpcFaceToCurrentPlayer("4010", true);
    giCurrentPlayerFaceToNpc("4010", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("萨迪克：天神啊！只要您收回您的惩罚，再次赐给我们清澈的河水，我愿意每天都做很多很多的事，再也不偷懒！", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("萨迪克：也许世界上最可怕的不是马贼，而是永远都干不完的活……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("萨迪克：最近来住店的客人少了很多，听说是因为附近出现了马贼，不来人也好，我正好轻松～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("萨迪克：老板娘还没嫁人时，曾经是镇上最受欢迎的女人，她歌唱得动听、舞跳得好，喜欢她的人能从这里排队到昆仑顶上！");
        giRandTalkPush("萨迪克：不管我偷不偷懒，事情永远做不完，不如想办法让自己闲一点～");
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
    if (var_shop029 != 1)
    {
        if (global_mvar >= 160100)
        {
            giRandTalkRelease();
            giRandTalkPush("塔依夫：最近曼丽请了个不太灵巧的人给她做帮手，酒还没酿好，那个人就把酒桶打开了，这样香味会散掉，不好喝……");
            giRandTalk();
            giRandTalkRelease();
        }
        else
        {
            giRandTalkRelease();
            giRandTalkPush("塔依夫：这里几乎不下雨，全靠仙山上的河水流下，我们才能住下来。");
            giRandTalkPush("塔依夫：中原人喝酒喜欢用小小的杯子，太没气概！我们习惯大碗喝酒，更厉害的就用桶，譬如说我就是！");
            giRandTalk();
            giRandTalkRelease();
        }
    }
    else
    {
        giTalk("塔依夫：没错，就是我要娶狄丽拜尔！想当年，这播仙镇上多少好男儿争着想娶她？没想到她竟然嫁给一个中原来的男人！", "");
        giTalk("塔依夫：本来，这也没什么，可那男人一年到头出门在外，从没好好陪伴过狄丽拜尔！我就是看不下去！<colour red=255 green=187 blue=0 alpha=255>你帮我去跟她说</colour><dc0>，只要她愿意，我随时都能带她走！</dc0>", "");
        var_shop029 = 2;
    }
    giPlayerUnLock();
}

void func4012()
{
    giPlayerLock();
    giNpcPauseBeh("4012");
    giNpcFaceToCurrentPlayer("4012", true);
    giCurrentPlayerFaceToNpc("4012", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("曼丽：老人们都说河水快要干了，这是天神抛弃了我们……可是我们到底做错了什么事，天神为什么不再保佑我们了？", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("曼丽：天神啊！怎么会有人在酒没酿好前，就把木桶打开了……香味都散掉的酒，我可不敢拿给酒肆去卖……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("曼丽：我不怕马贼！我们可不是好欺负的，要是马贼敢来镇上，一定要给他们些教训！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("曼丽：播仙镇的葡萄是用昆仑山的仙水灌溉的，所以颗颗都又大又甜～用来酿酒的话，可不是别处的酸葡萄能比的！");
        giRandTalkPush("曼丽：酿制葡萄酒的方法说简单也简单，但要酿得好，却不容易～绿洲酒肆的葡萄酒都是我酿的，又香又甜，一点酸涩味都没有，你可要尝尝？");
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
    giCurrentPlayerFaceToNpc("4013", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("张远山：我看这昆仑山顶上飞起的山峰，难不成就是传说中的白日飞升？看来山顶上的剑仙道行很深啊！", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("张远山：播仙镇的人是不是喝酒喝糊涂了？昆仑山上住的哪里是什么天神，明明就是修道的剑仙～那天我亲眼所见，几个人御剑从天上飞了过去！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("张远山：经商难、难于上青天！本来千里迢迢往返中原和西域之间已经够受的了！偏偏路上又被马贼给抢了，真是老天无眼啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("张远山：要在中原买葡萄酒，几两银子才一点点，这儿的葡萄酒几十文钱就能买一大桶，哈哈！今天我一定要喝个够！");
        giRandTalkPush("张远山：把中原的丝绸卖到西域，再把西域的葡萄酒、和阗玉带回中原去卖，虽然路上要花的时间不少，但怎么瞧也是一本万利的大生意呐～");
        giRandTalk();
        giRandTalkRelease();
    }
    giPlayerUnLock();
}

void func4014()
{
    giPlayerLock();
    giNpcPauseBeh("4014");
    giNpcFaceToCurrentPlayer("4014", true);
    giCurrentPlayerFaceToNpc("4014", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("泽依同：镇上去过仙山的人，都说仙山和我们想的不一样，到底是哪里不一样？天神更威严、更厉害吗？", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("泽依同：我……我上回遇见那个马贼的首领了，他长得好英俊，也没我想的那么凶，武艺却比哥哥还好得多！可是……他……他为什么要当马贼呢……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("泽依同：哼，那些马贼自以为了不起吗？总有一天我会带着明晃晃的弯刀，跟着哥哥去把他们杀个片甲不留！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("泽依同：中原来的人总说我们的名字怪，哪里怪了？“泽依同”的意思其实就是你们中原人说的“青果”啊～");
        giRandTalkPush("泽依同：中原人也许不能明白，马匹对我们来说就是像兄弟手足般的亲人～“年少时离开父亲、旅途中失去马匹”对我们来说都是最糟糕的事。");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("阿克木：我们播仙镇上的儿郎个个都是顶天立地的男子汉，天神有什么罪要降 ，就都降在我头上吧！不要牵连那些无辜的老人和孩子！", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("阿克木：我和那个马贼首领交过手了，他的武艺实在太高强，我都以为自己死定了，没想到他竟然没杀我，还下令放我们所有人平安回来，真是太奇怪了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("阿克木：这几天大漠里马贼闹得很凶，我和镇上几个武艺不错的兄弟商量了一下，决定跟着商队一起从镇上出发，遇到马贼时就能把他们给除了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿克木：泽依同那丫头从小就跟着我一起骑马射箭，练就一身好武艺，镇上武艺比她好的小伙子都没几个。");
        giRandTalkPush("阿克木：我的武艺也算不错了，但那次在大漠里遇到一只凶恶的妖怪，我使出全部本事都打不倒它，还好有仙人飞过，几招就把它制服了！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4015");
    giNpcResumeBeh("4015");
    giPlayerUnLock();
}

void func4016()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4016");
    giCurrentPlayerFaceToNpc("4016", true);
    if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4016", true);
        giTalk("阿娜尔：……有个商人给了阿爸很多钱，说要带我去中原，幸好阿爸看出他的眼神不正直，没有答应。", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4016", true);
        giTalk("阿娜尔：真不知道那些强盗什么时候才能被抓住……这几天来镇上的商人大都被马贼打劫过，我这儿的首饰也好久没新的了……", "");
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4016", true);
            giTalk("阿娜尔：常有小伙子来我这儿买了首饰送到姑娘家当聘礼，不过也有买不起的，那就只有趁天黑时去把心爱的姑娘偷回家啦～只要是月圆的晚上，偷了姑娘就不用补聘礼。", "");
        }
        else
        {
            giNpcFaceToNpc("4016", "4017", true);
            giNpcFaceToNpc("4017", "4016", true);
            giTalk("阿娜尔：尼露拜尔奶奶又来啦？这回是给哪个孙女挑首饰啊？", "");
            giTalk("尼露拜尔：呵呵，我只有泽依同这一个孙女啊～她只喜欢刀剑，不喜欢首饰。", "");
        }
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("尼露拜尔：一定是镇上有人惹怒了天神，天神才会降罪惩罚我们的！只要是这个镇上的人，就算跑得再远，也逃不过天神的惩罚呐！", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("尼露拜尔：我孙女说了，她只嫁武艺比她更好的小伙子……唉，我看今年家里是没喜事了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("尼露拜尔：最近马贼闹得凶，我孙子孙女都说要去打马贼，就只凭他们俩，武艺再强也不行呐……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("尼露拜尔：我想挑些首饰，让孙子送给他的心上人～我孙子是镇上最勇敢的小伙子，喜欢他的姑娘很多，就是不知道他喜欢哪一个。");
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
    if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4018", true);
        giRandTalkRelease();
        giRandTalkPush("高琴芬：相公打算去更远的地方做生意了，要穿过大沙漠，而且也许一年都不能回来一趟，我好担心他……一年到头都那么辛苦，挣再多钱又有什么用……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4018", true);
            giTalk("高琴芬：以前在中原时，难得看见这些样子的首饰，来了这儿天天见，倒也没那么新奇了。", "");
        }
        else
        {
            giNpcFaceToNpc("4018", "4016", true);
            giNpcFaceToNpc("4016", "4018", true);
            giTalk("高琴芬：阿娜尔，我喜欢这条新项链～你是从哪里弄来的？", "");
            giTalk("阿娜尔：商队昨天才到镇上，这回是从更西边的地方带回来的首饰，样样都是从前没见过的！", "");
        }
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
    if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("沙吾提：上回有个汉人问我买了很多方毯，我猜他是要带回中原去卖，听说这在中原卖得很好、很值钱。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("沙吾提：花帽子花毯子，大坛子小弯刀，都是新到的货啦！");
        giRandTalkPush("沙吾提：阿吉达在我这儿买了把弯刀，就上仙山去了，天神保佑！他千万别被山上的怪物伤了……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4019");
    giNpcResumeBeh("4019");
    giPlayerUnLock();
}

void func4021()
{
    giPlayerLock();
    giNpcPauseBeh("4021");
    giNpcFaceToCurrentPlayer("4021", true);
    giCurrentPlayerFaceToNpc("4021", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("铁木尔：别嫌我的银壶贵，告诉你，这样的壶，到了中原你出十两黄金都买不到！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("铁木尔：有个波斯商人经常会来播仙镇，我卖的金器银具都是从他那儿来的。听说中原也有人做类似的东西，但价钱比我这里的贵太多了。");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("阿依汗：前几天，天神的仆人从仙山上下来，告诉我们河水快要干了，连神的仆人都帮不了我们，劝我们离开这里……可是我在这里住了一辈子，怎么能说走就走呢！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("阿依汗：我年轻的时候啊，见过仙山上神的仆人，他们都是穿长长的袍子，带着一把剑……我被沙漠里的妖怪追，幸亏他们救了我一命～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿依汗：阿吉达这孩子啊，前不久去了仙山，到现在都没回来……不过镇上有些年轻人也是这样，有的回来了，有的没回来，还不如在这里好好地过日子。");
        giRandTalkPush("阿依汗：听说在更远的西边呐，有种魔毯可以让人在天上飞，可惜我们播仙镇却没有这样的东西。");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("骆远图：原来很多年以前，这附近最有名的河是叫月牙河，但是不知为什么，突然就干涸了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("骆远图：这家的毛毯是我看过用料最好、做工最细的，可惜老板娘说这毯子都是她自己家里织出来的，一个月也只能织一条……");
        giRandTalkPush("骆远图：这里的人都说山上住着神仙，镇里的河水都是山上仙界流下来的，我看这是积雪融化的水，跟仙人有什么关系？");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4023");
    giNpcResumeBeh("4023");
    giPlayerUnLock();
}

void func4024()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4024");
    giCurrentPlayerFaceToNpc("4024", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giNpcFaceToCurrentPlayer("4024", true);
        giTalk("萨比尔：阿依慕好不容易答应嫁给我了，可是天神的惩罚就要降临，阿爹说大家都会死的……我、我不想阿依慕死，不想大家死！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4024", true);
        giRandTalkRelease();
        giRandTalkPush("萨比尔：我好不容易学会吹笛子，阿依慕却又叫我学吹筚篥，说是只要我用筚篥吹出好听的曲子，她就答应嫁给我！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4024", true);
            giTalk("萨比尔：阿依慕是镇上舞跳得最好的姑娘，我喜欢她很久了！可她说如果我不学会吹笛子，以后就再也不理我！", "");
        }
        else
        {
            giNpcFaceToNpc("4024", "4025", true);
            giNpcFaceToNpc("4025", "4024", true);
            giTalk("萨比尔：阿布都大叔！你教教我吹牛角笛吧！阿依慕说，我吹不好牛角笛，她以后就再也不理我！", "");
            giTalk("阿布都：我上回不是教过你了吗？你自己不好好练，我也没办法啊。", "");
        }
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("阿布都：难道我们也和月牙村的人一样触怒了天神，天神才会收回他恩赐给我们的河水？", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("阿布都：你知道月牙村吗？离这里不算非常远，但现在已经去不了了，我小的时候还跟着爷爷去过一趟，都过了几十年，那里早被黄沙埋了吧……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿布都：这里的小伙子个个都能吹能唱！要是谁家的孩子不会拍手鼓吹筚篥，是没有姑娘愿意嫁他的～");
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
        giRandTalkPush("阿依慕：萨比尔学吹牛角笛终于能吹出调子来了，这回我叫他去学吹筚篥，要是他能练好，我就嫁给他～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿依慕：镇上人人都会吹牛角笛，只有萨比尔那个大笨蛋不会！要是让别人知道我喜欢的人这么笨，我一定会被笑话！");
        giRandTalkPush("阿依慕：你看起来不像商人，那就是要去仙山啰？那里的路不好走，有勇气去的人，都是我心目中的英雄！");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("穆哈希木：天神……天神果然是要抛弃我们了啊！那天梦见天神背转过身的事情，果然是真的！这、这可怎么办啊！", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("穆哈希木：昨天夜里，我做梦梦见天神背转过身，连他头上的光芒也看不到了，难道……这是不吉利的征兆？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("穆哈希木：沙木沙克成天嚷着要上山去拜天神，可他从来没有去过，这种光说不做的人，是会受到惩罚的！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4027");
    giNpcResumeBeh("4027");
    giPlayerUnLock();
}

void func4029()
{
    giPlayerLock();
    giNpcPauseBeh("4029");
    giNpcFaceToCurrentPlayer("4029", true);
    giCurrentPlayerFaceToNpc("4029", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("阿克：天神先是不让沙依木姐姐待在山上，现在又收回了清澈的河水……我们到底做错了什么事，天神要这样惩罚我们？", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("阿克：沙依木姐姐从仙山上回来了，仙人不愿意收她做仆人，也不让她继续待在山上……姐姐她好伤心……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿克：吉顺大叔卖的饼味道是最好的，就是有点贵～哈哈。");
        giRandTalkPush("阿克：沙依木姐姐说她要去仙山了，娘送给她很多好吃的带在路上～她长得那么漂亮，又聪明，天神一定愿意留下她做自己的仆人。");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("范泰：这次的货物比以往都多，听说沙漠里还出现了强盗，幸好、幸好大家都平安无事～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("范泰：想不到一路黄沙，竟能在这里看到如此繁华的绿洲～");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("沙木沙克：我、我可什么坏事都没做！天神要降灾，可千万别降到我头上啊！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("沙木沙克：那些上仙山的人都回来了，天神不愿意见他们……那我怎么办，我看我还是别去山上了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("沙木沙克：不管有多难，我一定要上山见到天神，请他给我力量，能够保护这个镇子！");
        giRandTalkPush("沙木沙克：穆哈希木大爷老喜欢嘲笑我只说不做，其实我衣服和弯刀都准备好了，虽然花了八年时间，但总算可以启程了。");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("塔吉古丽：这回我也见到仙山上下来的人了，他们不肯说仙山上到底发生了什么事，只告诉我们河水也许快要干了，让我们快离开……", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("塔吉古丽：阿娘说她曾经见过一次仙山上下来的人，是个非常英俊的男人～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("塔吉古丽：汉人的女子要嫁谁，得听父母的，那万一嫁的是不喜欢的人怎么办？");
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
        giRandTalkPush("阿库：咦？你穿的衣服好奇怪，不像商人，也不像中原来的其他人～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("阿库：我长大了一定要去山上见天神，请他教我怎么飞，这样我就能带着夏提飞到很远很远的地方去玩！");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("夏提：听说天神住的地方平常人是不能去的，要是以后阿库去了，那夏提不就不能经常见到他了？呜呜～～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("夏提：阿库说过以后要带我在天上飞哎～阿库是个男子汉，夏提相信他一定会做到的！");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("段无名：家乡的人只喜欢种菜种茶，我打了武器都没人看一下，这儿就不一样啦，小伙子人人都配一把弯刀，看起来精神得很！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("段无名：我从小就喜欢打造兵器，可惜在中原时没人赏识，后来化名到了西域，反而比以前过得快活～不错、不错！");
        giRandTalkPush("段无名：嘿嘿～这镇上的人都很崇拜所谓的“天神”，他们不知道昆仑山上的“天神”其实就是剑仙，我来这儿以前，也只知道蜀地才有剑仙呢～");
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
    giCurrentPlayerFaceToNpc("4036", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("崔贵：虽然我不信什么天神，但是镇上的人都很不安心的样子，难道播仙镇真的会出什么大事？", "");
    }
    else if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4036", true);
        giRandTalkRelease();
        giRandTalkPush("崔贵：百闻不如一见，我那日在沙地里遇见一只怪虫子，才知道世上真的有妖怪……差点就没命回来见夫人了……");
        giRandTalk();
        giRandTalkRelease();
        giNpcResetDir("4036");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4036", true);
        giRandTalkRelease();
        giRandTalkPush("崔贵：我家迁来这儿几年，一直都算太平，没想到最近马贼竟然连连闹事，希望朝廷早日将马贼解决，我们也好安心过日子。");
        giRandTalk();
        giRandTalkRelease();
        giNpcResetDir("4036");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4036", true);
        giRandTalkRelease();
        giRandTalkPush("崔贵：播仙镇风景独特，虽不及中原繁盛，却别有一番风情，我就是喜欢这儿的人热情好客，爽朗大方，所以迁居此地。");
        giRandTalkPush("崔贵：夫人天天都想回中原，可是中原有哪里好？还是这儿悠闲，种点葡萄就能养活一家人，不用整天为了吃口饭而苦恼。");
        giRandTalk();
        giRandTalkRelease();
        giNpcResetDir("4036");
    }
    giPlayerUnLock();
}

void func4037()
{
    giPlayerLock();
    giNpcPauseBeh("4037");
    giNpcFaceToCurrentPlayer("4037", true);
    giCurrentPlayerFaceToNpc("4037", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("崔巧娘：唉，看看播仙镇现在这个样子，可能连葡萄也种不了了，往后的日子真不知道该怎么过啊……", "");
    }
    else if (global_mvar >= 160100)
    {
        giRandTalkRelease();
        giRandTalkPush("崔巧娘：吓死我了……阿贵他差点在沙漠里被怪虫子吃了，我、我以后再也不和他吵架了，他平安回来就好……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("崔巧娘：我几次三番跟阿贵说要回中原去，他都不理我，还说要走叫我自己走！真是气死我了！要是我真的回去了，谁给他做饭洗衣，谁帮他一块儿照料这些葡萄啊！");
        giRandTalkPush("崔巧娘：播仙镇再好，到底不是自己的家乡，我做梦都想回中原看看！阿贵怎么就不明白呢！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4037");
    giNpcResumeBeh("4037");
    giPlayerUnLock();
}

void func4044()
{
    giPlayerLock();
    giNpcPauseBeh("4044");
    giNpcFaceToCurrentPlayer("4044", true);
    giCurrentPlayerFaceToNpc("4044", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("应玛：这几天镇上人心惶惶，来这里做生意的汉人跑得差不多了，其实大伙儿也没什么心思招呼他们，唉……", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("应玛：说起来，那天一大早，好端端的大晴天突然就阴下来，还刮起了大风！然后天上就多出了一个黑影，朝着仙山的方向飘过去了！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("应玛：镇子附近闹马贼了，害的这些中原商人都不敢出镇去。说也奇怪，那群马贼只挑中原人的商队劫，抢了东西不算，人也都杀光，太可怕了！", "");
    }
    else
    {
        giTalk("应玛：马槽里的这几匹海青马听说是花了大价钱从尼雅买来的，我看过的马可不少，这几匹马只是看起来精神些，其实和普通的海青没什么不一样的。", "");
    }
    giNpcResetDir("4044");
    giNpcResumeBeh("4044");
    giPlayerUnLock();
}

void func4045()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4045", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("贾任屏：这里地动山摇，水也快要不能喝了，不管沙漠里有多危险，我也一定要离开！", "");
    }
    else if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4045", true);
        giTalk("贾任屏：官府派出了兵马，听说是把马贼一网打尽了，不过又有人说其实官府只是封锁了兵败的消息，现在马贼比以前更加猖獗！", "");
        giNpcResetDir("4045");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4045", true);
        giTalk("贾任屏：最近沙漠里不太平，听说是出了凶狠的马贼，而且只挑汉人的商队动手，杀人越货，手段凶残！我看我还是等过了这一阵再回中原吧。", "");
        giNpcResetDir("4045");
    }
    else
    {
        giNpcFaceToNpc("4045", "4046", true);
        giNpcFaceToNpc("4046", "4045", true);
        giTalk("贾任屏：这次从尼雅带来的这些，可都是上等的海青马，花了我不少银子才搞到的，如果不是熟人，我还不想卖呢！", "");
        giTalk("赵九贯：上等的海青？我说任屏啊，你该不会是上当了吧？我看这几匹马普通的很，好不到哪儿去嘛！", "");
        giNpcResetDir("4045");
    }
    giPlayerUnLock();
}

void func4046()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4046", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("赵九贯：这个播仙镇最近异象连连，先是空中出现黑影，后来又山摇地动，河水浑浊，镇上的人也怪，一边怕的要死，一边却又不肯逃走！", "");
    }
    else if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4046", true);
        giTalk("赵九贯：我经商多年，来这播仙镇不下数十次，还是头一回看到天上那个黑影！听这里的老人说，这黑影十几年前也见过一次，没什么要紧的……", "");
        giNpcResetDir("4046");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4046", true);
        giTalk("赵九贯：不是说昆仑山上的神仙保佑着这个镇吗？马贼那么猖獗，那些神仙怎么不下山帮忙杀马贼？", "");
        giNpcResetDir("4046");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4046", true);
        giTalk("赵九贯：播仙镇是个好地方，南来北往的商贩都会路过这里，什么货想要出手，在这儿最容易找到买家。", "");
        giNpcResetDir("4046");
    }
    giPlayerUnLock();
}

void func4051()
{
    giPlayerLock();
    giNpcPauseBeh("4051");
    giNpcFaceToCurrentPlayer("4051", true);
    giCurrentPlayerFaceToNpc("4051", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("凌剑非：这地方似乎有些不妙，前几天一阵山摇地动的，后来水也浊了……我看我还是早点离开的好！", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("凌剑非：本来还想上山找仙人的，没想到原本上山的人都回来了，看来是没有指望请仙人指点了……", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("凌剑非：嘿！我原本是来找“汗血宝马”的，到了这儿才听说山上住着会飞的仙人，如果能上山请仙人指点一二，把那个会飞的本事学了，那就什么马都用不着啦！", "");
    }
    else
    {
        giTalk("凌剑非：一直听说西域有一种“汗血宝马”，长得不见高大，但却能日行千里，夜走八百！可惜我从雁门关一直走到这里，始终没有探询到这宝马的消息。", "");
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
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("吾其昆：唉呀，真不知道大伙儿在慌什么，就算河里的水浊了、不能喝了，我们还能喝酒嘛！葡萄酒的味道比水好喝多了！", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("吾其昆：那天一开始，我还以为是我喝多了眼花，没想到我家兰蒂也说她看到天上飞过一个黑影！那个黑影飞到仙山上，现在远远看过去，还能看到模模糊糊的影子！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("吾其昆：嗝～～我知道兰蒂是关心我，让我少喝酒也是为我好～～嗝～～可是、可是～嗝～她就不能像别的女人那样～～嗝～～温柔一点吗？", "");
    }
    else
    {
        giTalk("吾其昆：我也知道总是泡在酒肆里不好，可是葡萄酒实在是太好喝了，我、我忍不住啊！", "");
    }
    giNpcResetDir("4052");
    giNpcResumeBeh("4052");
    giPlayerUnLock();
}

void func4053()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4053");
    giCurrentPlayerFaceToNpc("4053", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giNpcFaceToNpc("4053", "4052", true);
        giNpcFaceToNpc("4052", "4053", true);
        giTalk("兰蒂：你啊！泡在酒缸里人都傻了是不是？！如果河里没了水，你让人拿什么去种葡萄、拿什么去酿酒？", "");
        giTalk("吾其昆：嘿嘿……这话说的……好像也有道理……不管，反正曼丽藏的陈年好酒还多得是，足够我再喝整整三年的～", "");
    }
    else if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4053", true);
        giTalk("兰蒂：那天的风特别大，特别冷！然后天上就飞来一个黑乎乎的大东西，一直飞上了仙山！希望天神保佑，千万不要有什么妖魔出现！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToNpc("4053", "4052", true);
        giNpcFaceToNpc("4052", "4053", true);
        giTalk("兰蒂：看看你的样子！喝成这样……要是现在马贼杀进来了，别说拿起弯刀和他们斗，就是让你跨上马立刻逃跑都没力气！", "");
        giTalk("吾其昆：嗝～～～说、说什么哪～如果马贼～嗝～～真的来了，我又怎么、怎么能丢下你～嗝～不管？", "");
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4053", true);
            giTalk("兰蒂：天神啊！求您发发慈悲，让我家这男人少喝几口酒，多做点正经事情吧！", "");
        }
        else
        {
            giNpcFaceToNpc("4053", "4052", true);
            giNpcFaceToNpc("4052", "4053", true);
            giTalk("兰蒂：你这个混蛋，叫你不许喝酒，又偷偷跑来酒肆！骑马射箭就喊累，整天喝得烂醉你能不累吗？！", "");
            giTalk("吾其昆：我我我……我已经六个时辰没有喝酒了，兰蒂你行行好，就让我喝几口吧！", "");
        }
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
    if (global_mvar >= 160100)
    {
        giTalk("阿比旦：前几天，有个英俊的男人来我们酒肆，他带着一匹好马，披着黑色的斗篷，只在镇上停留了一小会就走了，官爷说，那人很可能是马贼头目！可我看着却不太像……", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("阿比旦：我们老板娘酿的葡萄酒连驻守龟兹镇的将军都知道，上次还专门派了官兵来买呢！", "");
    }
    else
    {
        giTalk("阿比旦：我们酒肆有西域最好的葡萄酒，还有西域最漂亮的姑娘为您斟酒，客人您要不要来坐坐？", "");
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
    if (global_mvar >= 160100)
    {
        giTalk("西琳：有一些上了仙山的人，最近都回到了播仙镇上，原来他们还没有见过天神，天神也不许他们继续住在仙山山腰，唉，那不就是白白辛苦了……", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("西琳：这段日子马贼作乱，真是太危险了，商人都来买这儿的护身符，保佑平安，我相信天神一定会来帮我们的。", "");
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("西琳：你们中原人有句话说“三分长相，七分打扮”，这话说的好！姑娘戴上这店里的帽子，看起来会更像一朵漂亮的花！");
        giRandTalkPush("西琳：小伙子，瞧你的装扮，是不是想去仙山？那里很危险，一般人没有办法靠近，我劝你打消这个念头吧。");
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
    if (global_mvar >= 160100)
    {
        giTalk("王万：马贼刚刚被官府打跑，太平日子还没过上几天，就刮起了一阵怪风，吹倒了好几个葡萄架子！要不是那些老人说没事，我还以为是天神降祸了呢！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("王万：有人说那些马贼生性凶残，什么人都杀，又有人说那些马贼只抢中原的商人，从来不抢西域人——到底哪个传闻才是真的？", "");
    }
    else
    {
        giTalk("王万：沙吾提大叔这儿有的就是各式各样的小东西，看看这些弯刀，最多只能给小孩子玩玩，没有什么大用处。", "");
    }
    giNpcResetDir("4056");
    giNpcResumeBeh("4056");
    giPlayerUnLock();
}

void func4057()
{
    int money_amount = 0;

    giPlayerLock();
    giNpcPauseBeh("4057");
    giNpcFaceToCurrentPlayer("4057", true);
    giCurrentPlayerFaceToNpc("4057", true);
    if (var_shop007 != 1)
    {
        if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
        {
            giTalk("夏拉：眼看着葡萄就要收成，可前几天突然一阵山摇地动，刚熟的葡萄都从架子上掉下来摔烂了，真是叫人心疼啊……", "");
        }
        else if (global_mvar >= 160100)
        {
            giTalk("夏拉：前几天忽然起了一阵大风，阴冷阴冷的，吹倒了好几个葡萄架子！幸好那风只刮了没多久就停了，大伙儿帮忙，才把这些架子重新搭起来。", "");
        }
        else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
        {
            giTalk("夏拉：葡萄收成了之后，除了用来酿酒，还能做成葡萄干，你看西边那些石头屋子，就是专用来晒葡萄干的。", "");
        }
        else
        {
            giTalk("夏拉：西域的天气一直很干燥，很少下雨，我们都用仙山上流下来的水种葡萄，每年都有很好的收成，每一颗葡萄都又大又甜！", "");
        }
    }
    else
    {
        money_amount = giGetMoney();
        if (giGetMoney() <= 200)
        {
            if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
            {
                giTalk("夏拉：眼看着葡萄就要收成，可前几天突然一阵山摇地动，刚熟的葡萄都从架子上掉下来摔烂了，真是叫人心疼啊……", "");
            }
            else if (global_mvar >= 160100)
            {
                giTalk("夏拉：前几天忽然起了一阵大风，阴冷阴冷的，吹倒了好几个葡萄架子！幸好那风只刮了没多久就停了，大伙儿帮忙，才把这些架子重新搭起来。", "");
            }
            else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
            {
                giTalk("夏拉：葡萄收成了之后，除了用来酿酒，还能做成葡萄干，你看西边那些石头屋子，就是专用来晒葡萄干的。", "");
            }
            else
            {
                giTalk("夏拉：西域的天气一直很干燥，很少下雨，我们都用仙山上流下来的水种葡萄，每年都有很好的收成，每一颗葡萄都又大又甜！", "");
            }
        }
        else
        {
            giTalk("夏拉：我家沙依木以前常给吉顺大叔捣蛋，这回赔偿他些银钱也是应该的，没想到他又退回来了，真是太客气啦！<colour red=255 green=187 blue=0 alpha=255>替我谢谢吉顺大叔</colour><dc0>！</dc0>", "");
            giPayMoney(200, true);
            giWait(2.0);
            var_shop007 = 2;
        }
    }
    giNpcResetDir("4057");
    giNpcResumeBeh("4057");
    giPlayerUnLock();
}

void func4058()
{
    giPlayerLock();
    giNpcPauseBeh("4058");
    giNpcFaceToCurrentPlayer("4058", true);
    giCurrentPlayerFaceToNpc("4058", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("吾日耶提：那时候，地也动、山也摇，震得我这把老骨头都快散了……可是我们到底做错了什么事情，让天神发怒、抛弃我们呢？", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("吾日耶提：前些日子那怪风，在播仙镇也不是第一次啦！十几年前的那一次，风吹的比这次阴冷多了，大伙儿都以为是妖怪来了！结果却什么都没发生。", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("吾日耶提：你……你是不是神的仆人？有没有见过我那上山的孙儿？他在山上过得怎么样了？没有做错事情被天神惩罚吧？", "");
    }
    else
    {
        giTalk("吾日耶提：我的孙儿是前年上的仙山，到现在也一直没有他的消息，我想他一定是被天神收做仆人了吧？", "");
    }
    giNpcResetDir("4058");
    giNpcResumeBeh("4058");
    giPlayerUnLock();
}

void func4059()
{
    giPlayerLock();
    giNpcPauseBeh("4059");
    giNpcFaceToCurrentPlayer("4059", true);
    giCurrentPlayerFaceToNpc("4059", true);
    if (global_mvar >= 160100)
    {
        giTalk("则南蒂：前几天，天上飞过去一个黑乎乎的东西，镇上还刮了大风——不过这没什么好怕的，我小时候就见过一次。", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("则南蒂：大漠里的人过得已经很辛苦了，那些马贼还要打劫往来的客商，这伙没有良心的人，天神会惩罚他们的！", "");
    }
    else
    {
        giTalk("则南蒂：播仙镇的河水是仙山上流下来的，永远都不会干，不像我的家乡，现在大概已经变成一片荒漠了……", "");
    }
    giNpcResetDir("4059");
    giNpcResumeBeh("4059");
    giPlayerUnLock();
}

void func4060()
{
    giPlayerLock();
    giNpcPauseBeh("4060");
    giCurrentPlayerFaceToNpc("4060", true);
    if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4060", true);
        giTalk("妲蒂：喀玛勒上次真的跟阿克木他们去杀马贼了！我……我一直都以为他是个只说不干的胆小鬼，原来是错怪他了……", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToNpc("4060", "4061", true);
        giNpcFaceToNpc("4061", "4060", true);
        giTalk("妲蒂：说什么都是假的，有本事你就去把那些可恶的马贼都打跑！", "");
        giTalk("喀玛勒：去就去！难道我还怕马贼吗？！看着吧，我杀的马贼，一定会比阿克木杀的多！", "");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4060", true);
        giTalk("妲蒂：喀玛勒长得是英俊，牛角笛吹的也很棒，就是武艺差，胆子小，骑术也不怎么样，我、我才不要喜欢这样的人呢！", "");
    }
    giNpcResetDir("4060");
    giNpcResumeBeh("4060");
    giPlayerUnLock();
}

void func4061()
{
    giPlayerLock();
    giNpcPauseBeh("4061");
    giCurrentPlayerFaceToNpc("4061", true);
    if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4061", true);
        giTalk("喀玛勒：呵呵，自从上次去打马贼回来，妲蒂对我就和以前不一样了，再也不会不理我，而且常常对我笑呢！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4061", true);
        giTalk("喀玛勒：哼！就算我武艺比不上阿克木，骑术也、也普通了点，但这并不代表我会害怕！我们得到天神的保佑，去打马贼，一定能胜利！", "");
    }
    else
    {
        giNpcFaceToNpc("4061", "4060", true);
        giNpcFaceToNpc("4060", "4061", true);
        giTalk("喀玛勒：妲蒂，为什么你总是不愿意喜欢我？我到底哪里不好？你说，你说给我听，我马上就改！", "");
        giTalk("妲蒂：我说了你就能改吗？那就等你把武艺练得比阿克木更好，马儿骑得比阿克木更快的时候，再来找我吧！", "");
    }
    giNpcResetDir("4061");
    giNpcResumeBeh("4061");
    giPlayerUnLock();
}

void func4062()
{
    giPlayerLock();
    giNpcPauseBeh("4062");
    giCurrentPlayerFaceToNpc("4062", true);
    if (global_mvar >= 160100)
    {
        giNpcFaceToCurrentPlayer("4062", true);
        giTalk("卓合拉：仙山上下来很多神的仆人，他们叫镇上的人早点离开这里，免得日后遭殃……我们、我们到底要怎么做才能平息天神的怒火？", "");
    }
    else if (global_mvar >= 120500 /* 第三章 / 7-4-4.仙妖乱 / 寻找梦璃 */)
    {
        giNpcFaceToCurrentPlayer("4062", true);
        giTalk("卓合拉：在我很小的时候，哥哥就上山去见天神了，后来一直都没有回来，哥哥一定是被天神留下当仆人了～", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4062", true);
        giTalk("卓合拉：你……你是仙山上天神的仆人对不对？你能带我上山见见天神吗？卓合拉好想好想见天神一面，就一面，好不好？", "");
    }
    else
    {
        giNpcFaceToNpc("4064", "4062", true);
        giNpcFaceToNpc("4062", "4064", true);
        giTalk("卓合拉：艾里西尔，你要是真心喜欢我，就把天神的仆人请下山，让天神的仆人证明你对我的爱情！", "");
        giTalk("艾里西尔：卓合拉，你又不是不知道，上了仙山也不一定见得到天神的仆人，就算见到了，他们也不会愿意下山来办这种事的啊！", "");
    }
    giNpcResetDir("4062");
    giNpcResumeBeh("4062");
    giPlayerUnLock();
}

void func4063()
{
    giPlayerLock();
    giNpcPauseBeh("4063");
    giNpcFaceToCurrentPlayer("4063", true);
    giCurrentPlayerFaceToNpc("4063", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("帕塔木：老人们都说一定是镇上有人惹怒了天神，天神要降祸惩罚我们！可是、可是大多数人都没有做错事，也没有不尊敬天神，天神为什么连无辜的人也要惩罚？", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("帕塔木：听泽依同说，那个马贼的首领长得很英俊，还打赢了阿克木大哥，但是却并没有伤害他们，看来那些马贼也并不像别人说的那么坏…… ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("帕塔木：其实我想跟阿克木大哥还有泽依同他们一起出去打马贼！可是姐姐说我武艺不够好，硬是不许我去，还一定要我跟在她身边……", "");
    }
    else
    {
        giTalk("帕塔木：姐姐总想些奇怪的事情来为难艾里西尔，不过谁叫艾里西尔要喜欢我姐姐呢？嘻嘻！", "");
    }
    giNpcResetDir("4063");
    giNpcResumeBeh("4063");
    giPlayerUnLock();
}

void func4064()
{
    giPlayerLock();
    giNpcPauseBeh("4064");
    giCurrentPlayerFaceToNpc("4064", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giNpcFaceToCurrentPlayer("4064", true);
        giTalk("艾里西尔：不管发生什么事，我也一定会留在播仙镇保护大家，保护卓合拉的！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToNpc("4064", "4063", true);
        giTalk("艾里西尔：帕塔木啊，你年纪也不小了，喜欢你的小伙子又那么多，别总是跟着你姐姐好不好？", "");
        giNpcFaceToNpc("4062", "4064", true);
        giTalk("卓合拉：怎么了？你是不是嫌弃我妹妹？你要敢嫌弃我妹妹，那我和她一起走！ ", "");
        giNpcFaceToNpc("4064", "4062", true);
        giTalk("艾里西尔：哎？没、没有啦，帕塔木这么可爱，我怎么会嫌弃她？卓合拉你、你别生气啊！ ", "");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4064", true);
        giTalk("艾里西尔：卓合拉什么都好，就是脾气太古怪，喜欢的东西也和别的姑娘不一样，尽是提些古古怪怪的要求，真让人头疼！", "");
    }
    giNpcResetDir("4064");
    giNpcResumeBeh("4064");
    giPlayerUnLock();
}

void func4065()
{
    giPlayerLock();
    giNpcPauseBeh("4065");
    giNpcFaceToCurrentPlayer("4065", true);
    giCurrentPlayerFaceToNpc("4065", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("昆仑神丐：我“昆仑神丐”和昆仑山碧玉、紫翠两派的掌门都有点交情，不过他们也都不知道这山顶上突然飞起的东西到底是什么……", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("昆仑神丐：据说十几年前，昆仑山上曾经出现过一个庞然大物，只不过那庞然大物过了一阵子就又飞走了，不知道这次飞到仙山上的，是不是同十几年前的那东西一样？ ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("昆仑神丐：哼！那群马贼如此猖獗，真是太不给我“昆仑神丐”面子了！看我亲自出马，三天之内就叫他们从西域消失！", "");
    }
    else
    {
        giTalk("昆仑神丐：老夫乃是大名鼎鼎的“昆仑神丐”，西至精绝古城、东至雁门关，天山南麓各条道上的朋友，谁都要给老夫三分面子！", "");
    }
    giNpcResetDir("4065");
    giNpcResumeBeh("4065");
    giPlayerUnLock();
}

void func4080()
{
    giPlayerLock();
    giNpcPauseBeh("4080");
    giNpcFaceToCurrentPlayer("4080", true);
    giCurrentPlayerFaceToNpc("4080", true);
    if (global_mvar >= 160100)
    {
        giTalk("莱丽：天神保佑！那些马贼终于被赶跑了，但要是不抓到他们，谁知道接下来哪里会遭殃呢……", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("莱丽：最近这几天附近马贼猖獗，不少中原商人都被抢了，你们来来往往的，可都要小心些。愿天神保佑你们！", "");
    }
    else
    {
        giTalk("莱丽：播仙镇来来往往的客商很多，我和阿娘从早忙到晚，偏偏店里帮忙的人又爱偷懒……唉，真是没办法……", "");
    }
    giNpcResetDir("4080");
    giNpcResumeBeh("4080");
    giPlayerUnLock();
}

void func4081()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4081", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("萧康：道门中人得道飞升的事情我也不是没听说过，不过要说像前几天看到的那样，整座山都往上飞的，还真是闻所未闻！", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("萧康：本来还想和史兄弟再上一次仙山，没想到上次在半山腰见到的几个人现在也都下山了，看来仙山中的确有大事要发生。 ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("萧康：前几天我们上山，在半山腰遇到两个自称“剑南双侠”的人，两三下就被我打趴了，就这点功夫还敢拦路抢劫，简直就是找死！", "");
    }
    else
    {
        giTalk("萧康：史兄弟，听说上了太一仙径的人，很少有能回来的……这，听起来怪邪门，如果山上住的不是仙人是妖怪，那不是大大的不好？", "");
        giTalk("史默遥：萧兄弟你想太多了，播仙镇这么多人都一口咬定山上住的是神仙，怎么会有假？何况我们千里迢迢跑来这里，不上山看看怎么行？！", "");
    }
    giPlayerUnLock();
}

void func4082()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4082", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("史默遥：听说昆仑山上还有别的修仙门派，我和萧兄弟打算过几天就去别处找找，看看有没有别的地方能上山修仙的～", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("史默遥：山顶上那群道士干嘛那么霸道？昆仑山又不是他们的，住在半山腰都不行？ ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("史默遥：说起“剑南双侠”，以前在江南一带行走时倒有听说过，他们虽然没有什么大作为，但也不至于沦落成打家劫舍的盗匪……", "");
    }
    else
    {
        giTalk("史默遥：我们兄弟两人从中原来，昨天刚到播仙镇，总得歇息几天，打听清楚仙山的事情再动身去求仙。", "");
    }
    giPlayerUnLock();
}

void func4083()
{
    giPlayerLock();
    giNpcPauseBeh("4083");
    giNpcFaceToCurrentPlayer("4083", true);
    giCurrentPlayerFaceToNpc("4083", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("易仁：播仙镇最近接连发生奇怪的事情，看镇上的人都这么紧张，难道真的会出什么大事？", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("易仁：那些马贼狡猾地很，朝廷的人马跟他们交手几次，双方都没占到便宜，好在如今他们终于收敛一些，只不过被马贼掳走的邢公子，却还是下落不明…… ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("易仁：听往来的商人提起，那马贼首领的相貌，似乎和月前掳走邢公子的刺客有些相似，难道沙漠中的马贼和那刺客有所牵连？", "");
    }
    else
    {
        giTalk("易仁：龟兹镇邢大人的公子被刺客掳走，我奉命调查此案多日，终于找到一些蛛丝马迹，追至此地后，线索却又断了，唉……", "");
    }
    giNpcResetDir("4083");
    giNpcResumeBeh("4083");
    giPlayerUnLock();
}

void func4084()
{
    giPlayerLock();
    giNpcPauseBeh("4084");
    giNpcFaceToCurrentPlayer("4084", true);
    giCurrentPlayerFaceToNpc("4084", true);
    if (global_mvar >= 160100)
    {
        giTalk("莫夫人：听说马贼已经被官兵给除去了，可是相公却还没回来……要是相公他有什么三长两短，可叫我们孤儿寡母怎么活呀！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("莫夫人：相公去了更西边的城里，说是办货，已经好几天了，最近沙漠里又在闹马贼，真是担心死人了！", "");
    }
    else
    {
        giTalk("莫夫人：前几次，相公是一个人来西域做买卖的，一趟来回一年多，留下我们孤儿寡母住在京里，还不如像现在这样跟相公一起出门的好。", "");
    }
    giNpcResetDir("4084");
    giNpcResumeBeh("4084");
    giPlayerUnLock();
}

void func4085()
{
    giPlayerLock();
    giNpcPauseBeh("4085");
    giNpcFaceToCurrentPlayer("4085", true);
    giCurrentPlayerFaceToNpc("4085", true);
    if (global_mvar >= 160100)
    {
        giTalk("莫小福：小福天天在等爹爹，娘说只要爹爹一来，我们就回家！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("莫小福：我和阿娘已经在这里住了好久了，到底什么时候才能回家呢？我还答应了小莲这次回家就送她礼物呢！", "");
    }
    else
    {
        giTalk("莫小福：阿娘说，爹爹去了别的地方，很快就会回来，还会送小福一支新笛子！", "");
    }
    giNpcResetDir("4085");
    giNpcResumeBeh("4085");
    giPlayerUnLock();
}

void func4086()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4086", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("粱大刚：仙山上的仙人要回天上去了，以后没有水从山上流下来，就再也喝不到这么好的葡萄酒啦……", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("粱大刚：上回我喝醉了酒，不知怎么就睡到十里外的荒郊，幸好有朝廷的兵马路过把我救了，否则就算不遇到马贼，也得让野狼吃了…… ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("粱大刚：那群胆小的商人把那些马贼说的像妖怪一样，我看不过就是一群小毛贼！老板娘！再来三斤葡萄酒！等我喝够了，立刻就去把那群小贼给砍了！", "");
    }
    else
    {
        giTalk("粱大刚：哈哈哈！这酒肆的姑娘长得漂亮，葡萄酒也好喝的不得了，最要紧的是——这酒钱也便宜的很！", "");
    }
    giPlayerUnLock();
}

void func4087()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4087", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("罗熙：我走南闯北数十年，却从来没遇到过这样的事！好好的河水一夜之间变浑浊，天上还飞起一座山！真是个鬼地方，看来还是早点离开为妙！", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("罗熙：听说那马贼头头武功很高，朝廷的兵马也在他手里吃了暗亏！如果有机会，我一定要会会那家伙！ ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("罗熙：告诉你，邢大人的公子根本就不是被马贼掳走的，而是自愿投奔那群马贼的！至于这其中的蹊跷嘛～～当然是不能告诉你的。", "");
    }
    else
    {
        giTalk("罗熙：我在龟兹的时候就听人说起过播仙镇的绿洲酒肆，说是连邢大人的公子都对这里的葡萄酒赞不绝口，今日一尝，果然名不虚传！", "");
    }
    giPlayerUnLock();
}

void func4088()
{
    giPlayerLock();
    giCurrentPlayerFaceToNpc("4088", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("西丁：完了，完了！天神已经飞到天上去，再也不会管我们了！河里的水很快就会变成黄沙，大家都会死的！！", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("西丁：上次泽依同和镇上几个小伙子骑马出去找马贼，过了十几天才回来，还好没有人受重伤，真是天神保佑！ ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("西丁：自从附近闹马贼，泽依同就嚷着要去杀马贼……马贼那么凶悍，她一个小姑娘，出了事怎么办啊！", "");
    }
    else
    {
        giTalk("西丁：唉……我喜欢泽依同很久了，可是她看也不看我一眼，上次我去她家想带她走，还被她揍了一顿，为什么她要这么待我啊……", "");
    }
    giPlayerUnLock();
}

void func4089()
{
    giPlayerLock();
    giNpcPauseBeh("4089");
    giNpcFaceToCurrentPlayer("4089", true);
    giCurrentPlayerFaceToNpc("4089", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("奈蒂尔：天神抛弃我们了，难道播仙镇也要和我的家乡月牙村一样，变成一片黄沙吗……", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("奈蒂尔：天上飞过那么大一个黑影，虽然说没有发生什么别的事情，但我心里总觉得不安宁，好像要有不好的事情发生了…… ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("奈蒂尔：我的家乡原来也有一条清澈的河流，后来村子里的人做了错事，天神惩罚我们，收回了恩赐给我们的河水，日子实在过不下去了，我只能跟着家里人搬到这里来。", "");
    }
    else
    {
        giTalk("奈蒂尔：荒漠中的村子很容易就会被黄沙吞没，但是播仙镇受到天神的保佑，不但不怕风沙，而且长年都有清澈的河水可以使用。", "");
    }
    giNpcResetDir("4089");
    giNpcResumeBeh("4089");
    giPlayerUnLock();
}

void func4090()
{
    giPlayerLock();
    giNpcPauseBeh("4090");
    giNpcFaceToCurrentPlayer("4090", true);
    giCurrentPlayerFaceToNpc("4090", true);
    if (global_mvar >= 161000 /* 第四章 / 9-6-2.死生悠茫 / 再往播仙镇 / 宗炼手记 */)
    {
        giTalk("古兰慕：天神保佑了播仙镇几百年了，老人们都说天神是永远也不会抛弃我们的……可是为什么现在河里的水变浑浊，而且一天比一天少了呢……", "");
    }
    else if (global_mvar >= 160100)
    {
        giTalk("古兰慕：我、我不是故意把装酒的木桶打开的！我只是想闻闻酒酿好了没有，根本不知道这样做会让酒的香味散掉啊…… ", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("古兰慕：听说附近又有一个村子被黄沙吞没了，天神保佑！幸好我们播仙镇一直平安无事……", "");
    }
    else
    {
        giTalk("古兰慕：曼丽大姐酿的葡萄酒是整个西域的人都知道的，我要跟着她，把她酿酒的手艺好好地学一学。", "");
    }
    giNpcResetDir("4090");
    giNpcResumeBeh("4090");
    giPlayerUnLock();
}

void func4100()
{
    if (global_mvar < 70200 && var_shop034 == 0 /* 第二章 / 4-3-2.御剑逍遥 / 剑舞坪修行 */)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giFlashOutBlack(1.0, true, true);
        giPlayerSetPos(0, -159.4, 18.3, -286.5);
        giPlayerSetAng(0, 192.0);
        giSetNpcVisible("4029", true);
        giCameraPrepare("NPC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, true);
        giTalk("吉顺：卖大饼啦～香喷喷的大饼出炉啦！不香不收钱啦！", "");
        giCameraRunSingle("002", true);
        giNpcWalkTo("4029", -195.7, 18.3, -390.9, true);
        giNpcSetAng("4029", 138.0);
        giTalk("阿克：哇！太好了！大叔～来十个不香的！", "");
        giNpcFaceToNpc("4028", "4029", true);
        giCameraRunSingle("002", true);
        giTalk("吉顺：阿克你又来捣蛋！再胡闹我就告诉你娘！", "");
        giTalk("阿克：吉顺大叔你老那么严肃，真没意思！看在我每天都来买饼的份上～便宜点卖我几个吧，好不好？", "");
        giTalk("吉顺：好说好说，你别胡闹就成～", "");
        giCameraRunSingle("003", true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：……便宜卖？不懂……", "");
        giPlayerEndAction(0);
        giWait(0.5);
        giFlashOutBlack(1.0, true, true);
        var_shop034 = 1;
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
    giNpcPauseBeh("4035");
    giNpcFaceToCurrentPlayer("4035", true);
    giCurrentPlayerFaceToNpc("4035", true);
    giStartTradeSystem("shop023", "");
    giNpcResetDir("4035");
    giNpcResumeBeh("4035");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("4028");
    giNpcFaceToCurrentPlayer("4028", true);
    giCurrentPlayerFaceToNpc("4028", true);
    if (var_shop007 != 0)
    {
        if (var_shop007 != 2)
        {
            giStartTradeSystem("shop034", "");
        }
        else
        {
            giTalk("吉顺：哈哈，谢谢兄弟你帮忙，这些手抓饭和奶茶可是播仙镇上的一绝，送你一些，带在路上吃，保证比你们中原人干巴巴的面饼好吃！", "");
            giAddProperty(3015, 30, true);
            giWait(2.0);
            giAddProperty(3021, 30, true);
            giWait(2.0);
            var_shop007 = 3;
            giStartTradeSystem("shop034", "");
        }
    }
    else
    {
        giStartTradeSystem("shop034", "Buiness_Q05_5002");
    }
    giNpcResetDir("4028");
    giNpcResumeBeh("4028");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("4020");
    giNpcFaceToCurrentPlayer("4020", true);
    giCurrentPlayerFaceToNpc("4020", true);
    giStartTradeSystem("shop013", "");
    giNpcResetDir("4020");
    giNpcResumeBeh("4020");
    giPlayerUnLock();
}

void func5004()
{
    giPlayerLock();
    giNpcPauseBeh("4005");
    giNpcFaceToCurrentPlayer("4005", true);
    giCurrentPlayerFaceToNpc("4005", true);
    giStartTradeSystem("shop003", "");
    giNpcResetDir("4005");
    giNpcResumeBeh("4005");
    giPlayerUnLock();
}

void func5005()
{
    int local_2 = 0;
    int local_3 = 0;
    int local_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4009");
    giNpcFaceToCurrentPlayer("4009", true);
    giCurrentPlayerFaceToNpc("4009", true);
    if (var_shop029 != 0)
    {
        if (var_shop029 != 2)
        {
            giShowInnDialog(false);
            local_4 = giGetInnDialogResult();
            local_2 = giGetMoney();
            if (giGetInnDialogResult() == 1)
            {
                giShowCommonDialogInSelectMode("花费150文钱住宿吗？", 0.5, 0.4);
                local_3 = giCommonDialogGetLastSelect();
                if (giCommonDialogGetLastSelect() == 1)
                {
                    if (local_2 >= 150)
                    {
                        giFlashOutBlack(3.0, true, true);
                        giPayMoney(150, true);
                        giPlayerTakeARest();
                        giWait(2.0);
                        giFlashInBlack(3.0, true);
                    }
                    else
                    {
                        giTalk("狄丽拜尔：您身上的钱不够。", "");
                    }
                }
            }
        }
        else
        {
            giTalk("狄丽拜尔：呵呵，原来是这样……当年我决定嫁给相公的时候，心里就只有相公一个人，就算有再英俊、再好的小伙子，我也都不会喜欢的。", "");
            giTalk("狄丽拜尔：谢谢你帮我这个忙，这件衣裳给你，送给喜欢的姑娘吧！塔依夫的事情，我自己去找他说就行。", "");
            giAddEquipment(3613, true);
            giWait(2.0);
            var_shop029 = 3;
            giShowInnDialog(false);
            local_2 = giGetInnDialogResult();
            local_3 = giGetMoney();
            if (giGetInnDialogResult() == 1)
            {
                giShowCommonDialogInSelectMode("花费150文钱住宿吗？", 0.5, 0.4);
                local_4 = giCommonDialogGetLastSelect();
                if (giCommonDialogGetLastSelect() == 1)
                {
                    if (local_3 >= 150)
                    {
                        giFlashOutBlack(3.0, true, true);
                        giPayMoney(150, true);
                        giPlayerTakeARest();
                        giWait(2.0);
                        giFlashInBlack(3.0, true);
                    }
                    else
                    {
                        giTalk("狄丽拜尔：您身上的钱不够。", "");
                    }
                }
            }
        }
    }
    else
    {
        giShowInnDialog(true);
        local_2 = giGetInnDialogResult();
        local_3 = giGetMoney();
        if (giGetInnDialogResult() != 1)
        {
            if (local_2 == 2)
            {
                Buiness_Q05_5005();
            }
        }
        else
        {
            giShowCommonDialogInSelectMode("花费150文钱住宿吗？", 0.5, 0.4);
            local_4 = giCommonDialogGetLastSelect();
            if (giCommonDialogGetLastSelect() == 1)
            {
                if (local_3 >= 150)
                {
                    giFlashOutBlack(3.0, true, true);
                    giPayMoney(150, true);
                    giPlayerTakeARest();
                    giWait(2.0);
                    giFlashInBlack(3.0, true);
                }
                else
                {
                    giTalk("狄丽拜尔：您身上的钱不够。", "");
                }
            }
        }
    }
    giPlayerSetAttr(-1, -1, 100);
    giNpcResetDir("4009");
    giNpcResumeBeh("4009");
    giPlayerUnLock();
}

void func5006()
{
    giPlayerLock();
    giNpcPauseBeh("5006");
    giNpcFaceToCurrentPlayer("5006", true);
    giCurrentPlayerFaceToNpc("5006", true);
    giTalk("陈天远：我从中原千里迢迢赶来西域，专为收集到奇珍异宝，没想到播仙镇竟然出了此等大事，到如今只能设法变卖一些东西，凑够回乡的盘缠，尽快离开这里了。", "");
    giNpcResetDir("5006");
    giNpcResumeBeh("5006");
    giPlayerUnLock();
}

void func5007()
{
    giPlayerLock();
    giNpcPauseBeh("5007");
    giNpcFaceToCurrentPlayer("5007", true);
    giCurrentPlayerFaceToNpc("5007", true);
    giStartTradeSystem("shop038", "");
    giNpcResetDir("5007");
    giNpcResumeBeh("5007");
    giPlayerUnLock();
}

void func5008()
{
    giPlayerLock();
    giNpcPauseBeh("5008");
    giNpcFaceToCurrentPlayer("5008", true);
    giCurrentPlayerFaceToNpc("5008", true);
    giStartTradeSystem("shop039", "");
    giNpcResetDir("5008");
    giNpcResumeBeh("5008");
    giPlayerUnLock();
}

void Buiness_Q05_5002()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("沙依木那姑娘上山求仙去啦！临走还特地买了我摊上的大饼，真是……认识她那么久了，我怎么好意思收这么多银钱？小兄弟，帮我把这些钱送还给沙依木他娘吧，她就在<colour red=255 green=187 blue=0 alpha=255>车马驿上面葡萄架的附近</colour><dc0>。</dc0><br/><dc0>你愿意帮我送去吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        giAddMoney(200, true);
        giWait(2.0);
        var_shop007 = 1;
    }
}

void Buiness_Q05_5005()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("真不知道是哪家的小伙子，竟然送来一份这么贵重的礼物，还留书说月圆之夜就来“窃婚”？<br/><dc0>我出嫁前倒是常常遇到这种事情，但那也都是很多年前啦……小兄弟，如果你有时间，就帮我</dc0><colour red=255 green=187 blue=0 alpha=255>查查是谁开的这玩笑</colour><dc0>，他到底想干什么？</dc0><br/><dc0>你愿意帮我查查吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        var_shop029 = 1;
    }
}
