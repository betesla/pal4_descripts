// Structured PAL4 reconstruction for Q02.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q02_Q02_init()
{
    LL_001(global_mvar);
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giSetObjectVisible("entrance0", false);
        giSetObjectVisible("entrance3", false);
        giSetObjectVisible("entrance1", true);
        giSetObjectVisible("entrance2", true);
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance3", true);
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance2", false);
        giArenaReadyRestore();
    }
    if (global_mvar != 20200 /* 入世下山 */)
    {
        giGrantSmithSystem(true, true, true, true);
        giArenaReadyRestore();
    }
    else
    {
        giGrantSmithSystem(false, false, false, false);
        func2001();
    }
}

void Q02_N10b_init()
{
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        if (var_shop032 == 1)
        {
            giSetNpcVisible("4014", false);
        }
        giArenaReadyRestore();
    }
}

void LL_001(int arg0)
{
    // typed_typeinfo_hints: primary=void; extras=[int]
    // prototype_hint: void LL_001(int)
    if (global_mvar > 20600 /* 第一章 / 2-1-1.初涉红尘 / 回村无路 */)
    {
        giSetNpcVisible("4007", false);
        giSetNpcVisible("4008", false);
        giSetNpcVisible("4025", false);
        giSetNpcVisible("4026", false);
        giSetNpcVisible("4027", false);
        giSetNpcVisible("4028", false);
        giSetNpcVisible("4029", false);
        giSetNpcVisible("4030", false);
        giSetNpcVisible("4031", false);
        giSetNpcVisible("4090", false);
        giSetNpcVisible("4091", false);
        giSetNpcVisible("4092", false);
        giSetNpcVisible("4093", false);
        giSetNpcVisible("4094", false);
        giSetNpcVisible("4095", false);
        giSetNpcVisible("4096", false);
        giSetNpcVisible("MN022", false);
        giSetObjectVisible("MO001", false);
        giSetObjectVisible("MO002", false);
        giSetObjectVisible("MO003", false);
        giSetObjectVisible("MO004", false);
        giSetObjectVisible("MO005", false);
        giSetObjectVisible("MO006", false);
        giSetObjectVisible("MO007", false);
        giSetObjectVisible("MO008", false);
        giSetObjectVisible("MO009", false);
        giSetObjectVisible("MO010", false);
        giSetObjectVisible("MO011", false);
        giSetObjectVisible("MO012", false);
        giSetObjectVisible("MO013", false);
        giSetObjectVisible("MO014", false);
        giSetObjectVisible("MO015", false);
        giSetObjectVisible("MO016", false);
        giSetObjectVisible("MO017", false);
        giSetObjectVisible("MO018", false);
        giSetObjectVisible("title10", true);
        giSetObjectVisible("mark1", true);
        giSetObjectVisible("mark2", true);
        giSetObjectVisible("mark3", true);
        giEventVolumeVisible("ev_Q02_Q02_20", false);
        giEventVolumeVisible("ev_Q02_Q02_19", false);
        giNpcSetPos("4006", -175.0, 0.4, -575.3);
        giNpcSetAng("4006", 320.0);
        giNpcSetPos("4009", -1549.1, -79.7, -361.3);
        giNpcSetAng("4009", 290.0);
    }
    if (global_mvar == 20200 /* 入世下山 */)
    {
        giSetNpcVisible("4007", false);
        giSetNpcVisible("4008", false);
        giSetNpcVisible("4025", false);
        giSetNpcVisible("4026", false);
        giSetNpcVisible("4027", false);
        giSetNpcVisible("4028", false);
        giSetNpcVisible("4029", false);
        giSetNpcVisible("4030", false);
        giSetNpcVisible("4031", false);
        giSetNpcVisible("4090", false);
        giSetNpcVisible("4091", false);
        giSetNpcVisible("4092", false);
        giSetNpcVisible("4093", false);
        giSetNpcVisible("4094", false);
        giSetNpcVisible("4095", false);
        giSetNpcVisible("4096", false);
        giSetNpcVisible("MN022", false);
    }
}

void func1001()
{
    giArenaLoad("Q02", "N02", "", true);
    giPlayerCurrentSetPos(10.5, 0.1, 40.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q02", "Q02", "", true);
    giPlayerCurrentSetPos(-1554.7, -82.4, -112.8);
    giPlayerCurrentSetAng(275.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q02", "n03", "", true);
    giPlayerCurrentSetPos(5.0, 0.1, 74.6);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q02", "Q02", "", true);
    giPlayerCurrentSetPos(-2076.0, -80.2, -418.4);
    giPlayerCurrentSetAng(97.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q02", "N05", "", true);
    giPlayerCurrentSetPos(38.5, 0.2, 65.2);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q02", "Q02", "", true);
    giPlayerCurrentSetPos(1364.5, 0.6, -182.1);
    giPlayerCurrentSetAng(282.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("Q02", "N08", "N08a", true);
    giPlayerCurrentSetPos(7.2, 0.1, 71.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("Q02", "N08", "N08a", true);
    giPlayerCurrentSetPos(58.9, 0.1, 16.0);
    giPlayerCurrentSetAng(330.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("Q02", "N07", "", true);
    giPlayerCurrentSetPos(37.5, 0.1, 46.3);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q02", "Q02", "", true);
    giPlayerCurrentSetPos(-312.7, 0.6, 358.2);
    giPlayerCurrentSetAng(179.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("Q02", "N08", "", true);
    giPlayerCurrentSetPos(7.2, 0.1, 71.1);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1012()
{
    if (!giBGMConfigIsInArea("N08a"))
    {
        giArenaLoad("Q02", "Q02", "", true);
        giPlayerCurrentSetPos(-3.8, 0.3, -1319.5);
        giPlayerCurrentSetAng(4.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("Q02", "Q02", "", true);
        giPlayerCurrentSetPos(1266.8, 0.0, -515.9);
        giPlayerCurrentSetAng(278.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
}

void func1013()
{
    if (!giBGMConfigIsInArea("N08a"))
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerCurrentWalkTo(58.9, 0.1, 16.0, true);
        giPlayerCurrentSetAng(330.0);
        giSetPortrait("101C", true);
        giTalk("云天河：还是不要进去为好。", "");
        giPlayerUnLock();
    }
    else
    {
        giArenaLoad("Q02", "N06", "", true);
        giPlayerCurrentSetPos(2.3, 0.1, 69.0);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
}

void func1014()
{
}

void func1015()
{
    giArenaLoad("Q02", "N10", "N10a", true);
    giPlayerCurrentSetPos(-51.5, 0.1, 22.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1016()
{
    giArenaLoad("Q02", "Q02", "", true);
    giPlayerCurrentSetPos(-2105.6, 17.1, -1159.9);
    giPlayerCurrentSetAng(81.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1017()
{
    if (global_mvar >= 90100 || var_shop032 != 0 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("Q02", "N10", "N10b", true);
        giPlayerCurrentSetPos(-51.5, 0.1, 22.7);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(2, true);
        giArenaReady();
    }
    else
    {
        func4100();
    }
}

void func1018()
{
    giArenaLoad("Q02", "Q02", "", true);
    giPlayerCurrentSetPos(574.9, 98.2, -1260.9);
    giPlayerCurrentSetAng(329.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1019()
{
    giArenaLoad("Q02", "N10", "N10c", true);
    giPlayerCurrentSetPos(-51.5, 0.1, 22.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1020()
{
    giArenaLoad("Q02", "Q02", "", true);
    giPlayerCurrentSetPos(894.6, 279.4, 1221.0);
    giPlayerCurrentSetAng(188.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1021()
{
    giArenaLoad("Q02", "N10", "N10d", true);
    giPlayerCurrentSetPos(-51.5, 0.1, 22.7);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1022()
{
    giArenaLoad("Q02", "Q02", "", true);
    giPlayerCurrentSetPos(2005.0, 184.0, 777.2);
    giPlayerCurrentSetAng(266.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1023()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giArenaLoad("M02", "3", "", true);
        giPlayerCurrentSetPos(-159.7, -664.7, -1309.3);
        giPlayerCurrentSetAng(78.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去紫云架  ");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog("   准备<colour red=255 green=102 blue=0 alpha=255>去紫云架</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -424.3, 232.4, 1561.6, true);
                giPlayerSetDir(leader_player_id, 165.0, true);
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
            giArenaLoad("M02", "3", "", true);
            giPlayerCurrentSetPos(-159.7, -664.7, -1309.3);
            giPlayerCurrentSetAng(78.0);
            giCameraSetMode(0, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1024()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar != 110200 /* 第二章 / 6-5-2.非愿 / 前往巢湖 / 月夜惜别 */)
    {
        if (global_mvar != 20600 /* 第一章 / 2-1-1.初涉红尘 / 回村无路 */)
        {
            if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
            {
                giArenaLoad("M03", "1", "", true);
                giPlayerCurrentSetPos(2096.5, -21.3, 2492.3);
                giPlayerCurrentSetAng(212.0);
                giCameraSetMode(5, true);
                giArenaReady();
            }
            else
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
                        giPlayerWalkTo(leader_player_id, -1954.6, -79.8, -1910.6, true);
                        giPlayerSetDir(leader_player_id, 353.0, true);
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
                    giPlayerCurrentSetPos(2096.5, -21.3, 2492.3);
                    giPlayerCurrentSetAng(212.0);
                    giCameraSetMode(5, true);
                    giArenaReady();
                }
                giPlayerUnLock();
            }
        }
        else
        {
            giArenaLoad("M03", "1", "", true);
        }
    }
    else
    {
        giFlashOutBlack(0.1, true, false);
        giArenaLoad("M03", "1", "", true);
    }
}

void func1025()
{
    giPlayerLock();
    giSetPortrait("101C", true);
    giTalk("云天河：这边是仓库，就不要进去了吧。", "");
    giPlayerCurrentWalkTo(1203.1, 0.2, -642.7, true);
    giPlayerCurrentSetAng(345.0);
    giPlayerUnLock();
}

void func2001()
{
    giPlayerLock();
    giScriptMusicPlay("P24", 2, 0.0, 0.0);
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(0, -341.0, 218.0, 1256.0);
    giPlayerSetAng(0, 101.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, -354.0, 218.0, 1197.0);
    giPlayerSetAng(1, 97.0);
    giPlayerSetVisible(1, true);
    giIMMBegin();
    giSetNpcVisible("MN001", true);
    giSetNpcVisible("MN002", true);
    giSetNpcVisible("MN003", true);
    giSetNpcVisible("MN004", true);
    giSetNpcVisible("MN005", true);
    giSetNpcVisible("MN006", true);
    giSetNpcVisible("MN007", true);
    giSetNpcVisible("MN008", true);
    giSetNpcVisible("MN009", true);
    giSetNpcVisible("MN010", true);
    giSetNpcVisible("4064", false);
    giSetObjectVisible("entrance1", false);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.0, false);
    giArenaReady();
    giWait(1.5);
    giCameraRunSingle("002", true);
    giWait(1.5);
    giCameraRunSingle("003", true);
    giWait(1.0);
    giPlayerDoAction(0, "J13", -1, true);
    giNpcDoAction("MN001", "J02", 0, false);
    giSetPortrait("101K", false);
    giTalk("云天河：哇～～～～～～人好多！这么多人！", "40424");
    giWait(0.5);
    giCameraRunSingle("004", true);
    giWait(1.5);
    giTalk("男孩：王大哥跳舞跳得真好！", "40425");
    giTalk("青年：什么跳舞……小孩子不懂别乱讲，王大哥这是扮钟馗打鬼，等下还得去祠堂前的戏台上。", "40426");
    giPlayerSetDir(1, 5.0, false);
    giCameraRunSingle("005", true);
    giWait(0.3);
    giSetPortrait("103A", false);
    giTalk("韩菱纱：大惊小怪，没见过人多啊……", "40427");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerSetDir(0, 188.0, true);
    giWait(0.3);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：是、是没见过啊，人原来这么多啊……", "40428");
    giSetPortrait("103E", false);
    giTalk("韩菱纱：唉……", "40429");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：土包子别东张西望，小心招来麻烦～", "40430");
    giPlayerSetDir(0, 101.0, true);
    giWait(0.3);
    giPlayerDoAction(0, "C07", -1, false);
    giSetPortrait("101D", true);
    giTalk("云天河：快看！中间那个！那个穿红衣的，是他们的大王？……啊，他们走了，往另一个方向去了……", "40431");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：（……根本没在听我说话……）", "40432");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：什么大王小鬼？又在说傻话？", "40433");
    giWait(0.5);
    giIMMBegin();
    giCameraRunSingle("006", false);
    giPlayerSetAng(0, 188.0);
    giIMMEnd();
    giWait(0.5);
    giSetPortrait("101K", true);
    giTalk("云天河：呵呵，原来你不懂啊？猴群里的猴子都会跟着最厉害的猴王。那个红衣服的要不是老大，干嘛一堆人围着他？", "40434");
    giPlayerDoAction(1, "C09", 1, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：傻瓜，我看你干脆去当猴子算了！", "40435");
    giPlayerEndAction(1);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：你记住了，山下和山上不一样，不是只比谁的拳头硬，凡事都要讲个规矩，就像老百姓要听当官的，当官的要听皇帝的。", "40436");
    giPlayerDoAction(0, "J17", -1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：那个叫“黄弟”的，很厉害吗？剑法如何？", "40437");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：我又没见过皇帝，哪知道他会不会使剑啊。反正他权力很大，只要一声令下，成千上万的人都得掉脑袋。", "40438");
    giSetPortrait("101D", true);
    giTalk("云天河：这么厉害？那不是已经到了爹说的以气御剑的境界？", "40439");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103E", false);
    giTalk("韩菱纱：哎呀～根本不是一回事嘛。", "40440");
    giSetPortrait("103A", false);
    giTalk("韩菱纱：少问一些有的没的，天色不早了，我们先找个地方歇息，然后商量接下来要去哪里。", "40441");
    giSetPortrait("101K", true);
    giTalk("云天河：找地方？不用找啦，这儿这么多房子，我随便睡哪都行。", "40442");
    giCameraRunSingle("008", true);
    giWait(0.3);
    giPlayerDoAction(1, "J15", -1, false);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：天呐～～傻瓜傻瓜大傻瓜！", "40443");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103B", true);
    giTalk("韩菱纱：房子再多也是别人的，主人不同意你就进去住，是想做强盗啊？", "40444");
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101D", false);
    giTalk("云天河：……？", "40445");
    giPlayerEndAction(0);
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：停——！接下来你别问我“强盗”是什么，反正在山下你都不懂，一个不懂和两个三个不懂也没差啦。", "40446");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101E", false);
    giTalk("云天河：哦……饿死了，我想吃东西。", "40447");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：哼，别满嘴死啊死的，你哪有这么虚弱！", "40448");
    giPlayerEndAction(1);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：这太平村地方小，也没客栈，我们借住在村长家好了。 ", "40449");
    giSetPortrait("101B", false);
    giTalk("云天河：村长家有好东西吃吗？", "40450");
    giPlayerDoAction(1, "J04", -1, false);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：……唉，我现在就去找村长，你别跟来了，免得添乱。", "40451");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101K", false);
    giTalk("云天河：那我去看那个穿红衣服的～", "40452");
    giWait(0.3);
    giPlayerDoAction(1, "C08", 1, true);
    giWait(0.5);
    giCameraRunSingle("009", false);
    giPlayerWalkTo(1, -265.0, 216.0, 1102.0, false);
    giWait(1.3);
    giPlayerSetDir(0, 145.0, false);
    giPlayerEndMove(1);
    giWait(0.5);
    giSetPortrait("103E", true);
    giTalk("韩菱纱：……", "40453");
    giWait(0.4);
    giPlayerSetDir(1, 336.0, true);
    giWait(0.3);
    giPlayerDoAction(1, "J17", -1, false);
    giSetPortrait("103A", true);
    giTalk("韩菱纱：听好了！有什么事等我回来再说，不～许～惹～麻～烦！", "40454");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("101B", false);
    giTalk("云天河：哦，那些人我又不认识。", "40455");
    giSetPortrait("103E", true);
    giTalk("韩菱纱：（哼，就是不认识，才更麻烦。）", "40456");
    giPlayerDoAction(1, "C07", -1, false);
    giSetPortrait("103M", true);
    giTalk("韩菱纱：我走了，记得你答应的话！", "40457");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerRunTo(1, 158.0, 201.0, 1138.0, false);
    giWait(1.6);
    giPlayerSetDir(0, 90.0, true);
    giWait(2.5);
    giFlashOutBlack(1.5, true, true);
    giPlayerOutTeam(1, false);
    giPlayerEndMove(1);
    giNpcEndAction("MN001", false);
    giIMMBegin();
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(0, false);
    giSetNpcVisible("MN001", false);
    giSetNpcVisible("MN002", false);
    giSetNpcVisible("MN003", false);
    giSetNpcVisible("MN004", false);
    giSetNpcVisible("MN005", false);
    giSetNpcVisible("MN006", false);
    giSetNpcVisible("MN007", false);
    giSetNpcVisible("MN008", false);
    giSetNpcVisible("MN009", false);
    giSetNpcVisible("MN010", false);
    giSetNpcVisible("4064", true);
    giSetNpcVisible("4007", true);
    giSetNpcVisible("4008", true);
    giSetNpcVisible("4025", true);
    giSetNpcVisible("4026", true);
    giSetNpcVisible("4027", true);
    giSetNpcVisible("4028", true);
    giSetNpcVisible("4029", true);
    giSetNpcVisible("4030", true);
    giSetNpcVisible("4031", true);
    giSetNpcVisible("4090", true);
    giSetNpcVisible("4091", true);
    giSetNpcVisible("4092", true);
    giSetNpcVisible("4093", true);
    giSetNpcVisible("4094", true);
    giSetNpcVisible("4095", true);
    giSetNpcVisible("4096", true);
    giSetNpcVisible("MN022", true);
    giSetObjectVisible("entrance1", true);
    giIMMEnd();
    global_mvar = 20300; // 0x00004F4C, 第一章 / 1-4-3.入世 / 村中闲逛 / 决意下山
    giPlayerCurrentSetPos(-111.0, 214.0, 1074.0);
    giPlayerCurrentSetAng(97.0);
    giPlayerCurrentSetVisible(true);
    giCameraSetMode(0, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giScriptMusicStop(1, 2.5);
    giPlayerUnLock();
}

void func2002()
{
    if (global_mvar == 20300 /* 第一章 / 1-4-3.入世 / 村中闲逛 / 决意下山 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetLeader(0);
        giPlayerCurrentSetPos(-757.0, 0.4, -1072.0);
        giPlayerCurrentSetAng(211.0);
        giNpcSetAng("4012", 31.0);
        giNpcDoAction("4012", "J01", 0, false);
        giSetNpcVisible("4015", false);
        giSetNpcVisible("4006", false);
        giSetObjectVisible("title06", false);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giTalk("李慎：又香又好吃的粽子咧～", "40458");
        giTalk("李慎：只有端午节才吃的到，过了这村可就没这店了！", "40459");
        giPlayerWalkTo(0, -831.0, 0.5, -1156.0, true);
        giPlayerSetDir(0, 192.0, true);
        giWait(0.3);
        giNpcEndAction("4012", false);
        giTalk("李慎：嘿嘿，小哥尝尝看吧。 ", "40460");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101K", false);
        giTalk("云天河：这个，真的好吃？ ", "40461");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giTalk("李慎：哈哈，那当然！看你打扮是附近村子的猎户吧，居然不清楚我李家这块大好招牌～", "40462");
        giTalk("李慎：我们村里还有个习俗，每年端午就有扮钟馗、斩小鬼的戏目，谢他老人家保佑平安。一边吃粽子，一边看戏，真是再好不过了～", "40463");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：……原来山下的人不吃烤肉。", "40464");
        giSetPortrait("101D", false);
        giTalk("云天河：这玩意怪模怪样，外面壳好像很硬，还绑了绳子，古怪。", "40465");
        giScriptMusicPlay("P70", 2, 2.5, 2.5);
        giTalk("李慎：小哥你……", "40466");
        giCameraRunSingle("002", true);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(0, "J22", -1, false);
        giWait(1.5);
        gi2DSoundPlay("WJ039", 1);
        giSetPortrait("101J", true);
        giTalk("云天河：唔、唔……", "40467");
        giSetPortrait("101E", true);
        giTalk("云天河：唔，不好吃、不好吃！", "40468");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101E", true);
        giTalk("云天河：三两口就吃完了，外面的壳还嚼不烂！", "40469");
        giTalk("李慎：我说小哥，你和我说笑呢？", "40470");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：这种东西哪比得上香喷喷的烤肉，你们吃这个，难怪长得不结实，看我下回猎几头山猪来送你！", "40471");
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerSetDir(0, 38.0, false);
        giCameraRunSingle("004", true);
        giNpcDoAction("4012", "C07", -1, false);
        giTalk("李慎：哎，等等！你还没付钱呢！", "40472");
        giWait(0.3);
        giPlayerSetDir(0, 200.0, false);
        giNpcUnHoldAct("4012");
        giNpcEndAction("4012", true);
        giWait(0.3);
        giSetPortrait("101C", true);
        giTalk("云天河：……钱？", "40473");
        giTalk("李慎：一个粽子一文钱，招牌上写得清清楚楚，我小本生意，你可别吃霸王饭坑人呐！", "40474");
        giPlayerSetPos(1, -698.0, 0.4, -1046.0);
        giPlayerSetAng(1, 221.0);
        giPlayerSetVisible(1, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：是你要我尝尝，我才吃的。", "40475");
        giPlayerEndAction(0);
        giTalk("李慎：好哇！你想赖帐？！", "40476");
        giPlayerRunTo(1, -791.0, 0.3, -1158.0, true);
        giPlayerSetDir(1, 232.0, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：怎么回事？", "40477");
        giWait(0.5);
        giIMMBegin();
        giCameraRunSingle("003", false);
        giPlayerSetAng(0, 86.0);
        giNpcSetAng("4012", 52.0);
        giIMMEnd();
        giWait(0.5);
        giTalk("李慎：这位姑娘来的正好，你评评理，这小子吃东西不给钱，还一副理直气壮的样子。", "40478");
        giSetPortrait("101C", false);
        giTalk("云天河：“钱”是什么？是他让我尝尝看，我才拿起来吃，又不好吃……", "40479");
        giNpcDoAction("4012", "C07", -1, false);
        giTalk("李慎：你敢瞧不起李家的手艺？！", "40480");
        giNpcUnHoldAct("4012");
        giNpcEndAction("4012", true);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：对不住，我这个朋友不懂世事，也不会说话，他欠你多少钱，我赔就是！", "40481");
        giPlayerEndAction(1);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：（云天河，我竟然相信你不会惹麻烦，可恶～～！！）", "40482");
        giTalk("李慎：敢情你们俩认识？ ", "40483");
        giSetNpcVisible("4004", false);
        giSetNpcVisible("4005", false);
        giTalk("李慎：别跟我谈钱，俗气！钱财事小，名声事大！让这小子乱说我李家的粽子难吃，我以后还要不要在村里混——", "40484");
        gi2DSoundPlay("WJ008", 1);
        giSetNpcVisible("MN011", true);
        giSetNpcVisible("MN012", true);
        giTalk("宋大田：混蛋！给我站住——！", "40485");
        giIMMBegin();
        giCameraRunSingle("005", false);
        giPlayerSetVisible(1, false);
        giIMMEnd();
        gi2DSoundPlay("WJ008", 1);
        giNpcRunTo("MN011", -542.0, 0.6, -986.2, true);
        giNpcRunTo("MN012", -440.5, 0.6, -1025.0, false);
        giTalk("宋大田：气死我了！还不给我乖乖滚回鸡窝！！", "40486");
        giNpcSetDir("MN011", 102.0, true);
        gi2DSoundPlay("WJ008", 1);
        giNpcDoAction("MN011", "J01", 1, true);
        giWait(0.3);
        giTalk("宋大田：……", "40487");
        giSetNpcVisible("MN013", true);
        giSetNpcVisible("MN014", true);
        giSetNpcVisible("MN015", true);
        giCameraRunSingle("006", false);
        giTalk("青年：哈哈哈，宋大叔你还是老样子，吼得最响，退得最快～", "40488");
        giNpcSetDir("MN012", 104.0, true);
        giTalk("宋大田：谁、谁说的！我今天非教训它不可！ ", "40489");
        giWait(0.4);
        giNpcFaceToNpc("MN012", "MN011", true);
        giNpcDoAction("MN012", "J01", -1, false);
        giTalk("宋大田：别以为能生几个蛋我就治不了你！瞧我宰了你炖汤！", "40490");
        giCameraRunSingle("008", true);
        giPlayerCurrentSetPos(-704.0, 0.5, -1070.0);
        giPlayerCurrentSetAng(48.0);
        giPlayerSetPos(1, -748.0, 0.3, -1062.0);
        giPlayerSetAng(1, 67.0);
        giPlayerSetVisible(1, true);
        gi2DSoundPlay("WJ008", 1);
        giNpcDoAction("MN011", "J01", 1, true);
        giNpcRunTo("MN011", -593.5, 0.7, -1075.0, true);
        giNpcRunTo("MN011", -577.7, 0.6, -951.5, true);
        giNpcRunTo("MN011", -485.1, 0.6, -959.7, true);
        giNpcRunTo("MN011", -542.0, 0.6, -986.2, true);
        giNpcSetDir("MN011", 102.0, true);
        gi2DSoundPlay("WJ008", 1);
        giNpcDoAction("MN011", "J01", 1, true);
        giNpcUnHoldAct("MN012");
        giNpcEndAction("MN012", false);
        giPlayerCurrentSetVisible(false);
        giSetNpcVisible("MN021", true);
        giTalk("宋大田：呃……", "40491");
        giSetPortrait("101K", true);
        giTalk("云天河：别怕，我帮你！！", "40492");
        giCameraRunSingle("007", false);
        giWait(0.5);
        giNpcDoAction("MN021", "J25", 1, false);
        giWait(0.6);
        gi2DSoundPlay("WJ067", 1);
        giWait(0.7);
        gi2DSoundPlay("WH030", 1);
        giWait(0.1);
        giSetObjectVisible("Jeffect001", true);
        giNpcDoAction("MN011", "J02", -1, false);
        gi2DSoundPlay("WJ009", 1);
        giCameraRunSingle("009", true);
        giCameraRunSingle("010", false);
        giWait(3.6);
        gi2DSoundPlay("WJ009a", 1);
        giWait(0.1);
        giTalk("女孩：哇！小花怎么不动了？！", "40493");
        giTalk("青年：这、这是什么妖法……", "40494");
        giTalk("猎户：就是就是！刚才眼前蓝光这么一闪，像是一把剑飞了出去，可是剑又怎么会自己飞回来，八成是妖法……", "40495");
        giPlayerCurrentSetVisible(true);
        giSetNpcVisible("MN021", false);
        giSetNpcVisible("4012", false);
        giCameraRunSingle("011", true);
        giNpcRunTo("MN012", -624.0, 0.6, -1020.0, true);
        giNpcSetDir("MN012", 247.0, true);
        giTalk("宋大田：你！你杀了我家小花！！", "40496");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：呵呵，它凶得很，你又说要宰了它，我帮你一把嘛。", "40497");
        giPlayerEndAction(0);
        giNpcDoAction("MN012", "J01", -1, false);
        giTalk("宋大田：臭小子，我饶不了你！！", "40498");
        giNpcUnHoldAct("MN012");
        giNpcEndAction("MN012", false);
        giPlayerRunTo(1, -700.0, 0.3, -1025.0, true);
        giPlayerSetDir(1, 82.0, true);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：等一下！大叔你冷静点，有话好说。", "40499");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：这只鸡……我、我赔钱就是！", "40500");
        giIMMBegin();
        giSetNpcVisible("4010", false);
        giSetNpcVisible("MN013", false);
        giSetNpcVisible("MN014", false);
        giSetNpcVisible("MN015", false);
        giSetNpcVisible("MN011", false);
        giIMMEnd();
        giTalk("宋大田：赔钱？！你赔得起吗？！我这可是一天能下四只蛋的宝贝母鸡，臭小子不知用什么古怪法子把它弄死了，以后我们全家靠什么吃饭啊～！！", "40501");
        giSetPortrait("101D", true);
        giTalk("云天河：吃饭？", "40502");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：简单呐，不就是靠自己的一张嘴张口吃饭，有什么困难？", "40503");
        giNpcDoAction("MN012", "J01", -1, false);
        giTalk("宋大田：气～气～气～气死我也！小子欠揍！", "40504");
        giNpcUnHoldAct("MN012");
        giNpcEndAction("MN012", false);
        giNpcSetPos("4012", -559.6, 0.7, -1103.1);
        giNpcSetAng("4012", 294.0);
        giSetNpcVisible("4012", true);
        giNpcSetPos("MN001", -508.9, 0.7, -1058.6);
        giNpcSetAng("MN001", 270.0);
        giSetNpcVisible("MN001", true);
        giTalk("李慎：等等！揍人也要有个先来后到，他头一个得罪的是我，宋大叔你让让先！", "40505");
        giWait(0.3);
        giNpcFaceToNpc("MN012", "4012", false);
        giPlayerSetDir(0, 84.0, false);
        giPlayerSetDir(1, 110.0, false);
        giCameraRunSingle("012", true);
        giWait(0.3);
        giTalk("宋大田：凭什么？！看你身上没几两肉，打架行不行啊？ ", "40506");
        giTalk("李慎：嘿嘿，我有帮手！", "40507");
        giSetPortrait("B03A", false);
        giTalk("？？：王魁山在此！谁敢吃霸王饭！", "40508");
        giNpcFaceToCurrentPlayer("MN012", true);
        giNpcDoAction("4012", "C07", -1, false);
        giTalk("李慎：王大哥，就是他！头像鸟窝的那个！", "40509");
        giNpcUnHoldAct("4012");
        giNpcEndAction("4012", true);
        giSetPortrait("B03A", false);
        giTalk("王魁山：吃霸王饭的，来来来！你跟俺较量较量，看你还敢不敢白吃东西！", "40510");
        giTalk("李慎：这位王魁山王大哥是我们村的大力士，年年都在端午节扮钟馗，他的力气可不比真钟馗小，专门对付那些捣乱的家伙！", "40511");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：你们别不讲理，我明明说了要给钱的。", "40512");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：菱纱，打就打！他们不讲理，我听他们的话，还要被揍！", "40513");
        giPlayerSetDir(1, 173.0, true);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（不好！野人牛脾气发了……）", "40514");
        giSetPortrait("101I", true);
        giTalk("云天河：就算他们的大王来了，我也不怕！", "40515");
        giTalk("青年：糟糕！那边……王大哥要和人打起来了……", "40516");
        giFlashOutBlack(1.0, true, true);
        giPlayerInTeam(1, false);
        giSetFullHP();
        giSetFullMP();
        giIMMBegin();
        giPlayerCurrentSetPos(-677.5, 0.5, -944.1);
        giPlayerCurrentSetAng(100.0);
        giPlayerSetPos(1, -688.4, 0.6, -901.3);
        giPlayerSetAng(1, 114.0);
        giIMMEnd();
        giSetObjectVisible("Jeffect001", false);
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giAddCombatMonster(2581, 1);
        giConfigCombatBgm("P54");
        giConfigCombatCamera("CA6");
        giConfigCombatGroundCamera("CA12");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("Q02");
        giIMMBegin();
        giNpcSetPos("4012", -585.2, 0.7, -993.7);
        giNpcSetAng("4012", 71.0);
        giNpcSetPos("MN001", -532.5, 0.7, -977.6);
        giNpcSetAng("MN001", 297.0);
        giNpcSetPos("4010", -493.3, 0.4, -1040.7);
        giNpcSetAng("4010", 317.0);
        giSetNpcVisible("4010", true);
        giNpcSetPos("4029", -592.2, 0.8, -1050.6);
        giNpcSetAng("4029", 340.0);
        giSetNpcVisible("4029", true);
        giNpcSetPos("MN007", -500.5, 0.6, -887.2);
        giNpcSetAng("MN007", 246.0);
        giSetNpcVisible("MN007", true);
        giNpcSetPos("MN013", -547.1, 0.5, -873.7);
        giNpcSetAng("MN013", 241.0);
        giSetNpcVisible("MN013", true);
        giNpcSetPos("MN014", -543.7, 0.6, -825.1);
        giNpcSetAng("MN014", 226.0);
        giSetNpcVisible("MN014", true);
        giNpcSetPos("MN015", -519.7, 0.6, -1010.5);
        giNpcSetAng("MN015", 306.0);
        giSetNpcVisible("MN014", true);
        giNpcSetPos("MN012", -629.9, 0.6, -1015.5);
        giNpcSetAng("MN012", 333.0);
        giSetNpcVisible("MN016", true);
        giSetNpcVisible("MN019", true);
        giSetNpcVisible("MN020", true);
        giSetNpcVisible("MN017", true);
        giSetNpcVisible("4009", false);
        giIMMEnd();
        giFlashInBlack(1.0, false);
        giWait(1.0);
        giNpcDoAction("MN001", "J01", 1, false);
        giSetPortrait("B03A", false);
        giTalk("王魁山：……厉害，俺不是这小伙子的对手……", "40517");
        giTalk("李慎：王大哥！你、唉！你怎么就输了呢？", "40518");
        giTalk("女孩：呜哇～爹爹骗人，还说钟馗是最厉害的！ ", "40519");
        giNpcDoAction("MN012", "J01", -1, false);
        giTalk("宋大田：你们！以多欺少，不算英雄好汉！", "40520");
        giNpcUnHoldAct("MN012");
        giNpcEndAction("MN012", true);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetDir(0, 140.0, false);
        giPlayerSetDir(1, 145.0, false);
        giNpcFaceToNpc("4012", "MN012", false);
        giNpcSetDir("MN001", 261.0, true);
        giIMMEnd();
        giWait(0.3);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：你说什么？！", "40521");
        giTalk("李慎：说的好！宋大叔，换你好好教训这小子！", "40522");
        giNpcSetDir("MN012", 64.0, true);
        giTalk("宋大田：啊？！这个嘛……我看魁山他也是一时不小心……歇息歇息肯定能把他们打趴下！", "40523");
        giNpcDoAction("MN001", "J01", 1, false);
        giSetPortrait("B03A", true);
        giTalk("王魁山：俺、俺不打了，刚才这姑娘好像说了要给钱，俺不能冤枉好人。", "40524");
        giTalk("谷婆婆：瞧瞧，今天是端午节，大伙儿本该聚到戏台去看戏，怎么这儿比戏台还热闹？", "40525");
        giIMMBegin();
        giPlayerSetDir(0, 83.0, false);
        giPlayerSetDir(1, 101.0, false);
        giNpcSetDir("MN012", 64.0, false);
        giNpcSetDir("4012", 68.0, false);
        giNpcSetDir("MN001", 68.0, false);
        giNpcSetDir("MN019", 117.0, false);
        giIMMEnd();
        giWait(0.3);
        giIMMBegin();
        giNpcSetDir("MN020", 122.0, false);
        giNpcSetDir("MN013", 119.0, false);
        giNpcSetDir("MN007", 120.0, false);
        giNpcSetDir("4029", 46.0, false);
        giNpcSetDir("MN016", 54.0, false);
        giIMMEnd();
        giWait(0.3);
        giIMMBegin();
        giNpcSetDir("MN015", 65.0, false);
        giNpcSetDir("4010", 48.0, false);
        giNpcSetDir("MN014", 134.0, false);
        giIMMEnd();
        giCameraRunSingle("002", true);
        giWait(1.0);
        giTalk("谷婆婆：咦？这孩子看起来眼熟得很呐……我年纪是大了，但眼睛可一点没昏花……", "40526");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", false);
        giTalk("云天河：是说我？我没见过你啊。", "40527");
        giIMMBegin();
        giNpcSetDir("MN012", 323.0, false);
        giNpcSetDir("4012", 310.0, false);
        giNpcSetDir("MN001", 294.0, false);
        giNpcSetDir("MN019", 217.0, false);
        giIMMEnd();
        giWait(0.3);
        giIMMBegin();
        giNpcSetDir("MN020", 228.0, false);
        giNpcSetDir("MN013", 252.0, false);
        giIMMEnd();
        giWait(0.3);
        giIMMBegin();
        giNpcSetDir("MN007", 254.0, false);
        giNpcSetDir("4029", 328.0, false);
        giNpcSetDir("MN016", 319.0, false);
        giNpcSetDir("MN015", 307.0, false);
        giNpcSetDir("4010", 310.0, false);
        giNpcSetDir("MN014", 230.0, false);
        giIMMEnd();
        giNpcWalkTo("MN017", -440.0, 0.6, -926.0, true);
        giWait(1.0);
        giTalk("谷婆婆：……像，真是像，这眉毛、这眼睛，和云家那惹祸精十几岁时没两样……", "40528");
        giCameraRunSingle("003", true);
        giWait(0.7);
        giNpcSetPos("MN017", -506.5, 0.6, -837.9);
        giNpcSetAng("MN017", 254.0);
        giTalk("村民甲：对啊，他不就是那个云天青？！不对不对……年纪差太多了，可是……", "40529");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：你认识我爹？", "40530");
        giTalk("村民甲：好哇！原来你是那混帐的儿子！他回村了没？！我可要找他算帐！", "40531");
        giTalk("村民乙：谁？！谁说云天青回来了？找他算我一个！", "40532");
        giPlayerSetDir(0, 129.0, true);
        giWait(0.7);
        giPlayerSetDir(0, 45.0, true);
        giWait(0.8);
        giPlayerSetDir(0, 85.0, true);
        giSetPortrait("101D", false);
        giTalk("云天河：怎么你们都认识我爹？", "40533");
        giTalk("村民乙：岂止认识？那小子的事我记得最清楚了！从小就不学好，三天两头骗我糖吃！", "40534");
        giTalk("村民乙：隔壁阿香喜欢我，他偏要和我抢！幸好阿香有眼光，最后还是做了我老婆！", "40535");
        giTalk("阿香：死鬼～多少年以前的事了，说出来也不害臊！", "40536");
        giTalk("村民甲：你那些事算什么！有一回他趁我醉酒，把我扒光了衣服扔在路上，脸都丢光了！", "40537");
        giTalk("少女：嘻，原来爹还有这样的糗事啊，瞧你平时都一本正经的～", "40538");
        giTalk("村民甲：笑什么笑！静儿你回去，村里大事，小孩子少管！", "40539");
        giTalk("村民丙：你们都没我惨！有一回云天青和我打赌，输了的人要大冬天浸冰水，结果那家伙耍赖，害我……害我在床上躺了半个多月——", "40540");
        giTalk("？？：够了！吵些什么？！", "40541");
        giSetNpcVisible("MN018", true);
        giCameraRunSingle("004", false);
        giIMMBegin();
        giNpcSetDir("MN012", 64.0, false);
        giNpcSetDir("4012", 68.0, false);
        giNpcSetDir("MN001", 68.0, false);
        giNpcSetDir("MN019", 117.0, false);
        giIMMEnd();
        giWait(0.3);
        giIMMBegin();
        giNpcSetDir("MN020", 122.0, false);
        giNpcSetDir("MN013", 119.0, false);
        giNpcSetDir("MN007", 120.0, false);
        giNpcSetDir("4029", 46.0, false);
        giNpcSetDir("MN016", 54.0, false);
        giIMMEnd();
        giWait(0.3);
        giIMMBegin();
        giNpcSetDir("MN015", 65.0, false);
        giNpcSetDir("4010", 48.0, false);
        giNpcSetDir("MN014", 134.0, false);
        giNpcSetDir("MN017", 137.0, false);
        giIMMEnd();
        giWait(1.0);
        giTalk("村民乙：啊？！村长来了！", "40542");
        giTalk("宋大田：村长来的正好！来替我们评评理！", "40543");
        giTalk("云靳：端午节这等日子，喧哗胡闹，还有没有祖宗礼法了？！ ", "40544");
        giTalk("村民：…………", "40545");
        giNpcWalkTo("MN018", -567.5, 0.6, -925.8, false);
        giCameraRunSingle("005", true);
        giWait(1.7);
        giIMMBegin();
        giNpcSetDir("MN012", 323.0, false);
        giNpcSetDir("4012", 310.0, false);
        giNpcSetDir("MN001", 294.0, false);
        giNpcSetDir("MN019", 217.0, false);
        giIMMEnd();
        giWait(0.4);
        giIMMBegin();
        giNpcSetDir("MN020", 228.0, false);
        giNpcSetDir("MN013", 252.0, false);
        giNpcSetDir("MN007", 254.0, false);
        giNpcSetDir("4029", 328.0, false);
        giIMMEnd();
        giWait(0.4);
        giIMMBegin();
        giNpcSetDir("MN016", 319.0, false);
        giNpcSetDir("MN015", 307.0, false);
        giNpcSetDir("4010", 310.0, false);
        giNpcSetDir("MN014", 230.0, false);
        giNpcSetDir("MN017", 254.0, false);
        giIMMEnd();
        giNpcEndMove("MN018");
        giWait(1.0);
        giNpcDoAction("MN018", "C13", 1, false);
        giTalk("云靳：韩姑娘，我念你一个女孩孤身在外不易，才答应让你留宿村中，可不是让你招出是非！", "40546");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：村长，我们不是——", "40547");
        giPlayerRunTo(0, -639.2, 0.5, -925.1, true);
        giIMMBegin();
        giPlayerSetDir(0, 85.0, false);
        giNpcFaceToCurrentPlayer("MN012", false);
        giNpcFaceToCurrentPlayer("MN019", false);
        giIMMEnd();
        giWait(0.3);
        giSetPortrait("101I", true);
        giTalk("云天河：你干嘛？！", "40548");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：爹说过女孩子是要好好对待的，不是拿来凶的！", "40549");
        giCameraRunSingle("006", true);
        giWait(0.3);
        giTalk("云靳：你是——？！", "40550");
        giTalk("云靳：云……天青？！", "40551");
        giTalk("云靳：……不对，你刚才说……云天青是你爹？！", "40552");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101A", true);
        giTalk("云天河：对啊，原来你们都认识我爹。", "40553");
        giNpcDoAction("MN018", "J02", 1, false);
        giTalk("云靳：是谁让他进村的？还不快把他赶出去！", "40554");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：村长——？！", "40555");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giTalk("云靳：云天青早已不是云家子孙，和他有亲缘之人也不得留在太平村中！", "40556");
        giPlayerSetDir(0, 290.0, true);
        giSetPortrait("101C", false);
        giTalk("云天河：菱纱，他说的什么意思？ ", "40557");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：…………", "40558");
        giWait(0.3);
        giCameraRunSingle("007", true);
        giWait(0.3);
        giPlayerCurrentSetAng(88.0);
        giTalk("云靳：……看样子你爹也羞于向你提起旧事。也罢，不管你来此何意，今日我就当着大伙的面，再说一说这村里的大事和规矩！", "40559");
        giTalk("云靳：我云家先祖镇守边疆有功，得以被朝廷恩赐修建祠堂，并将原本的云家村赐名“太平”。", "40560");
        giNpcDoAction("MN018", "J01", -1, false);
        giTalk("云靳：赫赫天威，皇恩浩荡！云家后代未再有人入仕已是惭愧，不想到了这代，本家竟出了一个浪荡子云天青，不遵礼法，行止违和，实是家门不幸！", "40561");
        giNpcUnHoldAct("MN018");
        giNpcEndAction("MN018", true);
        giTalk("云靳：家中长辈痛心疾首，奈何此人屡教不改，已在多年前被逐出家门，永不得返！", "40562");
        giTalk("宋大田：竟……竟还有这事，我十年前才迁过来，都不知道。", "40563");
        giTalk("谷婆婆：唉，云家人虽然读过圣贤书，对那孩子却一点也没办法。", "40564");
        giCameraRunSingle("006", true);
        giWait(0.5);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：哼，<colour red=255 green=187 blue=0 alpha=255>天河，我们走！</colour>", "40565");
        giPlayerSetDir(0, 290.0, true);
        giSetPortrait("101D", false);
        giTalk("云天河：等等！我爹的事还没问完呢。", "40566");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：还问什么问，他们除了骂人什么都不会说的！", "40567");
        giPlayerEndAction(1);
        giTalk("云靳：韩姑娘此言差矣，今日就事论事，绝无像市井谩骂一般有失体统。", "40568");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：村长不知有时候人言快过刀子吗？天河是天河，他爹是他爹，你们这么多人围着一个小辈，还真是客气啊！", "40569");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcDoAction("MN018", "J02", 1, false);
        giTalk("云靳：岂有此理！放肆了！！", "40570");
        giTalk("村民乙：竟敢对村长无礼？", "40571");
        giTalk("宋大田：就算不管他爹，这小子杀了我家的鸡又怎么算？！", "40572");
        giTalk("村民乙：你们走！不然别怪我们动粗！", "40573");
        giSetPortrait("103K", true);
        giTalk("韩菱纱：走就走，姑娘我也不稀罕留下！", "40574");
        giSetPortrait("101E", false);
        giTalk("云天河：可是——", "40575");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：还可是什么，走了！", "40576");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerRunTo(1, -867.4, 0.6, -910.4, false);
        giFlashOutBlack(1.5, true, true);
        giPlayerEndMove(1);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(0, false);
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("4012", false);
        giSetNpcVisible("4010", false);
        giSetNpcVisible("MN013", false);
        giSetNpcVisible("MN014", false);
        giSetNpcVisible("MN015", false);
        giSetNpcVisible("MN016", false);
        giSetNpcVisible("MN017", false);
        giSetNpcVisible("MN018", false);
        giSetNpcVisible("MN019", false);
        giSetNpcVisible("MN020", true);
        giSetNpcVisible("4007", false);
        giSetNpcVisible("4008", false);
        giSetNpcVisible("4025", false);
        giSetNpcVisible("4026", false);
        giSetNpcVisible("4027", false);
        giSetNpcVisible("4028", false);
        giSetNpcVisible("4029", false);
        giSetNpcVisible("4030", false);
        giSetNpcVisible("4031", false);
        giIMMEnd();
        global_mvar = 20600; // 0x00005078, 第一章 / 2-1-1.初涉红尘 / 回村无路
        giPlayerCurrentSetPos(-1942.0, -79.8, -1838.0);
        giPlayerCurrentSetAng(182.0);
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2003()
{
    if (global_mvar < 20600 /* 第一章 / 2-1-1.初涉红尘 / 回村无路 */)
    {
        giPlayerLock();
        giNpcFaceToCurrentPlayer("MN022", true);
        giCurrentPlayerFaceToNpc("MN022", true);
        giTalk("小洛子：村长伯伯家来了客人，小洛子想要伯伯给我讲故事，伯伯都没空……", "");
        giNpcResetDir("MN022");
        giNpcResumeBeh("MN022");
        giPlayerUnLock();
    }
}

void func2004()
{
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -1942.0, -79.8, -1838.0, true);
        giPlayerSetDir(0, 175.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(0, true);
        giSetPortrait("101E", true);
        giTalk("云天河：菱纱说我们<colour red=255 green=187 blue=0 alpha=255>要离开这地方了</colour><dc0>，那些人好像也不想我们留下来……</dc0>", "");
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
        giRandTalkPush("林环凤：听说那些大城里的人把吃茶叫作“品茗”，不是泡了茶就喝，而是一滴一滴落在嘴唇上尝。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("林环凤：哎，我看什么剑仙的传说都是别人胡乱说的，不能当真～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("林环凤：前几天，咱这太平村来了一个女娃，穿着一身红衣裳，又机灵又俊俏，那晚找不着地方住，还是在村长家借宿的呢。");
        giRandTalkPush("林环凤：原本想去找村西边的石匠打个石磨，但今天大伙儿都在祠堂外看“跳钟馗”，去了也不一定能找到人。");
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
        giRandTalkPush("单广青：茶可解渴，也能解毒，传说炎帝神农尝百草，日遇七十二毒，得茶而解之。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("单广青：传说中的剑仙我没见过，倒是太平村的临睦茶，是为一绝，若送去京城，也许能与寿阳的宁香一较长短。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("单广青：此地名为太平村，今日正是端午，村民大多去祠堂看扮钟馗的戏了，有趣倒也有趣，可惜那戏台太小，哪比得上城里的气派～");
        giRandTalkPush("单广青：听说太平村附近的深山里住着仙人，可我远道而来，在此半年有余，上山不下十几次，却从未见过仙人的踪影……");
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
        giRandTalkPush("云庚年：上一回村里几个小伙子拉了一车茶叶去寿阳，没几日茶叶就卖完了。现在咱们村的茶叶不愁卖不了，只怕没货卖！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("云庚年：村里的茶叶收成一直不错，可惜总没商人来村里买，我跟云靳说，应该找几个年轻力壮的小伙子，用马车拉了茶叶，咱们自己去城里卖！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("云庚年：我孙女的手艺不错，今天过端阳，她正在厨房里忙着准备饭菜呢！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4003");
    giNpcResumeBeh("4003");
    giPlayerUnLock();
}

void func4004()
{
    int random_1_4 = 0;

    giPlayerLock();
    giNpcPauseBeh("4004");
    giCurrentPlayerFaceToNpc("4004", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4004", true);
        giTalk("玲珑：爹说家里的茶叶卖得很好，这次去城里，会给我买新衣服～等爹回来，就有新衣服穿喽！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4004", true);
        giTalk("玲珑：上次小山哥在湖边看见了剑仙，要是我也去湖边玩，是不是也能见到剑仙？", "");
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giNpcFaceToCurrentPlayer("4004", true);
            giTalk("玲珑：端午节时要把艾草、菖蒲和大蒜挂在门口，听阿娘说这样就没有鬼怪来害人了～", "");
        }
        else
        {
            giNpcFaceToNpc("4004", "4005", true);
            giNpcFaceToNpc("4005", "4004", true);
            giTalk("玲珑：大家都说剑仙保佑着咱们村～可是为什么每年端午节都是扮钟馗，不是扮剑仙呢？", "");
            giTalk("小山子：这个……大概是因为钟馗比剑仙还厉害吧！", "");
            giTalk("玲珑：那为什么从来没人说钟馗降妖的故事呢？", "");
            giTalk("小山子：钟馗不是捉妖的，是捉鬼的啦～", "");
        }
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
        giRandTalkPush("小山子：最近茶颜姐姐总是忙着烘茶揉茶，都不陪我玩，还说什么大人的事情小孩子不会懂，我已经不是什么都不懂的小孩子了！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("小山子：告诉你，我见过剑仙哦～就在巢湖边上，有几个仙人踩着剑从天上飞过去，一眨眼就不见了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("小山子：好想到戏台前头去看魁山伯伯扮钟馗、打小鬼，可是那里围着好多人，挤也挤不进去！");
        giRandTalkPush("小山子：阿爹和阿娘常上山采银杏，我好想跟他们一块儿去！可是阿爹说山上有猛兽，不肯带我去。");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("云颂：如今茶叶卖得好，大伙儿日子也过得好，祠堂里的贡品也比以前多多了。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("云颂：村里人的祖宗牌位大都在这祠堂里，这段日子听说湖里闹妖怪，就经常有人来上香，求祖宗保平安。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("云颂：别看魁山在台上的样子高大威猛、又打鬼来又驱邪，其实他人很好，小孩子们都很喜欢他。");
        giRandTalkPush("云颂：这云氏宗祠是先皇为封赏我们云家一位战功卓著的先祖而下令建的，算到如今也有百多年了～可惜云家自那以后就再也没出过什么大人物了……");
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
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("虎头王：俺是住在山上的猎户，今天下山来赶集，正巧赶上端午节，又能吃粽子又能看戏～不错不错！");
        giRandTalkPush("虎头王：俺常常来太平村卖兽皮、换柴米，这村子每年到了这几天都会特别热闹～");
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
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("秋兰：扮钟馗的戏～每年也就只有端午能看到，整出戏分三段，正对应避祸、祈福、驱邪这三件事。");
        giRandTalkPush("秋兰：下月初我就要嫁人了，嫁到很远很远的海边……这一去，以后就再也吃不到小李裹的糯米粽、看不到王大哥扮的钟馗了……");
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
        giRandTalkPush("云小宝：娘说今年和往年不一样，我们的茶叶卖了好价钱，以后天天都能吃鱼吃肉！");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("云小宝：小山子总说他见过剑仙，可是问他剑仙长什么样，他又说不清，我看他一定在骗人！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("云小宝：今天是端午节，有好吃的粽子吃！可是……为什么不是天天过节呢？");
        giRandTalkPush("云小宝：你喜欢钟馗，还是喜欢剑仙？我就最喜欢剑仙了，剑仙一定比钟馗好看得多，又会飞，还有厉害的宝剑来除妖！");
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
        giRandTalkPush("蔡三刀：我们太平村的茶叶都进京了，什么时候我的山猪肉也能卖到京城去呢 ？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("蔡三刀：这可是今天早上刚从猎户手里收来的山猪，扛条后腿回家烧着吃，保准味美无比！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("蔡三刀：这几天小李的肉粽卖得好啊，我这儿的猪肉都让他给包了，只剩下猪头猪尾猪脚爪。");
        giRandTalkPush("蔡三刀：那些小鬼，总说剑仙会踩着云在天上飞，要我说，剑仙剑仙，当然是踩着剑飞，否则就该叫云仙了不是～");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("云湘秀：茶笋炖肉是我们太平村的好菜，以前茶叶卖得不好，大伙儿日子不好过，这道菜只有逢年过节才能吃上。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("云湘秀：你看起来有些面善呢，以前是不是来过我们村？……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("云湘秀：年年端午，村里都有扮钟馗的戏，魁山大哥演这钟馗也有些年头了。");
        giRandTalkPush("云湘秀：我爹最喜欢吃的就是清炒蕨菜了～做起来也简单，蕨菜在附近山坡上就能挖到。");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("李慎：我、我怎么觉得你眼熟得很？可这身打扮明明就没见过啊……");
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
        giRandTalkPush("茶颜：今年的茶叶不但长得特别好，卖得也特别好，村里人开始有些闲钱了，再也不用羡慕寿阳人了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("茶颜：每年总有几天，村长会召集村里人到祠堂去议事，但是爹从来不带我一起，说是那种时候女孩子不准进祠堂……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("茶颜：村子里原本只有一个云家，像我们这些外姓人，都是从别处迁来的。");
        giRandTalkPush("茶颜：传说附近的山里住着剑仙，是一男一女～男仙英俊神武，女仙更是如观音娘娘般温柔美丽～");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("赵元吉：一生为墨客，几世作茶仙～既然考不上功名，就在此地当个茶仙也不错。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("赵元吉：唉，我七次赶考，七次都未能中秀才，难道真的与功名无缘？");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("徐婆婆：小李卖的茶叶蛋又香又入味，可惜我牙不利索，吃得慢，没吃到半个，蛋就凉了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("徐婆婆：剑仙也好，妖怪也好，我老太婆这辈子都还没见过，现在只求祖宗保佑，让我安安稳稳过完剩下的日子就是了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("徐婆婆：记得有一年端午啊，祠堂里“钟馗”演得好好的，就是云家那个小惹祸精，居然在钟馗的戏袍上系了一串鞭炮！那场面，真叫鸡飞狗跳！");
        giRandTalkPush("徐婆婆：年纪大了就是苦啊，想吃粽子，又怕粘口吞不下……");
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
        giRandTalkPush("金兰：李家打铁的手艺是祖上传下来的，传儿传媳不传女～");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("金兰：哎？我没认错的话，你就是前阵子的那个……你真是云家小哥的儿子？都长这么大了？");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("金兰：别看我相公平时只帮村里人打些农具，其实他打造兵器的手艺才是最好的！");
        giRandTalkPush("金兰：记得小时候，村里云家的小哥哥总爱捣蛋，大伙都躲着他，那会儿只有我和我如今的相公，经常和他在一起玩。");
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
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkPush("李九金：村里人都种茶去了，没人种稻，也没人来我这儿打镰刀，正好让我有时间钻研武器图谱。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("李九金：剑仙用的剑，既能用来踩着飞，也能用来杀妖怪，一定不是寻常兵器，要能见识一下就好了～");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("李九金：你想买农具的话，到门口找我娘子！有现成打好了的。");
        giRandTalkPush("李九金：我和弟弟从小就爱铸兵器，可惜当年只有云家小哥欣赏咱们的手艺……后来他说要去闯江湖，弟弟也说要搜集最好的兵器图谱，两人结伴走了，就再没回来过……");
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
    giNpcFaceToCurrentPlayer("4018", true);
    giCurrentPlayerFaceToNpc("4018", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giRandTalkRelease();
        giRandTalkPush("云阿菊：媳妇怀了小娃娃，儿子说要给她补补，这些日子除了捕鱼，有时还上山打野味。");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("云阿菊：听说巢湖在闹妖怪，村里人都不敢去，只有我那傻儿子，说什么有剑仙护佑，啥都不怕。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        random_1_4 = giGetRandnum(1, 4);
        if (random_1_4 != 2)
        {
            giTalk("云阿菊：我儿子和媳妇经常在巢湖捕鱼，巢湖离这儿也不远，从村北出去一直走就是了。", "");
        }
        else
        {
            giTalk("云阿菊：哎？你不就是那个……？", "");
            giTalk("云阿菊：不对、不对……都这么多年了，那孩子怎么可能还是这个年纪……", "");
        }
    }
    giNpcResetDir("4018");
    giNpcResumeBeh("4018");
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
        giRandTalkPush("王章寿：闺女说我年纪大了，让我别再上船打鱼，可不上船的话，每天又能做啥呀？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("王章寿：那天我和闺女在湖上收网，一不小心掉水里，脚上被水草给缠住，我还以为死定了！后来也不知怎么着就上了岸，要说是剑仙救的，却又不太像……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("王章寿：从这儿往北一直走，穿过林子，要不了多久就能到巢湖边上了。");
        giRandTalkPush("王章寿：今天村里热闹得很～家家户户都在庆贺端阳节，我早上打了鱼过来卖，没多久就全卖完了。");
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
        giRandTalkPush("姚若琴：相公从城里托人捎了个玉镯子给我，说是最近的茶叶生意突然好起来，可他却没说什么时候能回来，也没说什么时候接我去城里……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("姚若琴：当初我从家乡嫁过来，本以为有了依靠，却没想到相公常常出远门，一年到头也见不上几面，唉……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("姚若琴：当年我刚刚嫁到这儿的时候，村里有个姓云的小鬼，竟把我煮了想给婆婆吃的粥，整锅偷去送乞丐！我现在想想都还有气！");
        giRandTalkPush("姚若琴：别看我这铺子不大，可麻雀虽小五脏俱全，南杂北货无一不有～不过不许赊帐哦！");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4021");
    giNpcResumeBeh("4021");
    giPlayerUnLock();
}

void func4022()
{
    gi2DSoundPlay("WB022", 1);
}

void func4023()
{
    gi2DSoundPlay("WB020", 1);
}

void func4100()
{
    if (global_mvar < 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        if (var_shop032 == 0)
        {
            giPlayerLock();
            giFlashOutBlack(0.5, true, true);
            giArenaLoad("Q02", "N10", "N10b", true);
            giCameraSetCollide(false);
            giCameraAutoSeek(false);
            giIMMBegin();
            giPlayerCurrentSetPos(12.9, 0.3, 44.0);
            giPlayerCurrentSetAng(238.0);
            giCameraPrepare("NPC001");
            giIMMEnd();
            giArenaReady();
            giCameraRunSingle("001", true);
            giFlashInBlack(1.5, true);
            giTalk("赵元吉：外面怎么这么吵……害我书都读不进去，眼看三年一度的“乡贡”就在秋天，这……让我如何是好啊！", "");
            giWait(0.5);
            giCameraRunSingle("002", false);
            giPlayerCurrentWalkTo(-17.6, 0.0, 9.7, true);
            giPlayerSetAng(0, 248.0);
            giCameraWait();
            giPlayerDoAction(0, "C07", -1, false);
            giSetPortrait("101B", true);
            giTalk("云天河：热闹不好吗？山上没这么多人，也就没意思了～", "");
            giPlayerUnHoldAct(0);
            giPlayerEndAction(0);
            giNpcFaceToCurrentPlayer("4014", true);
            giTalk("赵元吉：然也，然也～兄台一语惊醒梦中人，山上清静，我干脆去那里结庐苦读算了。", "");
            giNpcWalkTo("4014", -70.4, 0.3, 65.8, false);
            giWait(1.0);
            giCameraRunSingle("003", false);
            giNpcEndMove("4014");
            giSetNpcVisible("4014", false);
            giPlayerSetDir(0, 338.0, true);
            giWait(1.0);
            giPlayerDoAction(0, "J14", 1, true);
            giWait(0.5);
            giFlashOutBlack(1.0, true, true);
            var_shop032 = 1;
            giCameraSetMode(2, true);
            giFlashInBlack(1.0, true);
            giPlayerUnLock();
        }
    }
}

void func4081()
{
    giPlayerLock();
    giNpcPauseBeh("4081");
    giCurrentPlayerFaceToNpc("4081", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4081", true);
        giTalk("李宝儿：云芳总是嚷着要跟我上山去玩儿，我才不要带这种爱哭的女孩子上山呢！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToNpc("4081", "4083", true);
        giTalk("李宝儿：嘻嘻，告诉你们！昨天我在湖边玩儿，看到湖里面爬出一只妖怪，有三只脑袋，九条手臂，张牙舞爪的样子，可吓人啦！它对我说，今天晚上就要来抓云芳！", "");
        giNpcFaceToNpc("4083", "4082", true);
        giTalk("云芳：啊！呜……哥哥！！哥哥救我！！呜……", "");
        giNpcFaceToNpc("4082", "4083", true);
        giTalk("云喜：云芳，你别理他，他是故意吓唬你的！", "");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4081", true);
        giTalk("李宝儿：两根筷子夹着碗，屏障在西也在南，东面不平北面平，黄山胜过九华山～", "");
    }
    giNpcResetDir("4081");
    giNpcResumeBeh("4081");
    giPlayerUnLock();
}

void func4082()
{
    giPlayerLock();
    giNpcPauseBeh("4082");
    giCurrentPlayerFaceToNpc("4082", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giNpcFaceToCurrentPlayer("4082", true);
        giTalk("云喜：宝儿总是欺负云芳，可是云芳还是很喜欢和宝儿一起玩……真不知道女孩子都是怎么想的～", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToNpc("4082", "4081", true);
        giTalk("云喜：宝儿，你要是再欺负我妹妹，我们以后就再也不和你玩儿了！！", "");
        giNpcFaceToNpc("4081", "4082", true);
        giTalk("李宝儿：嘻，我只是瞎编了几句想逗逗她，谁知道会把她吓哭嘛！", "");
    }
    else
    {
        giNpcFaceToCurrentPlayer("4082", true);
        giTalk("云喜：端阳节，食五黄；门插艾，香满堂；吃粽子，蘸白糖，天中五瑞虎称王。钟馗挂在大墙上，蝎子、蜈蚣无处藏～～", "");
    }
    giNpcResetDir("4082");
    giNpcResumeBeh("4082");
    giPlayerUnLock();
}

void func4083()
{
    giPlayerLock();
    giNpcPauseBeh("4083");
    giCurrentPlayerFaceToNpc("4083", true);
    giNpcFaceToCurrentPlayer("4083", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("云芳：为什么哥哥和宝儿都不肯带云芳到山上去玩呢……", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("云芳：宝儿说巢湖里面有妖怪，晚上会来抓我走，我……我好害怕！呜……", "");
    }
    else
    {
        giTalk("云芳：粽子香，香厨房；艾叶香，香满堂。桃枝插在大门上，出门一望麦儿黄，这儿端阳，那儿端阳～", "");
    }
    giNpcResetDir("4083");
    giNpcResumeBeh("4083");
    giPlayerUnLock();
}

void func4084()
{
    giPlayerLock();
    giNpcPauseBeh("4084");
    giCurrentPlayerFaceToNpc("4084", true);
    giNpcFaceToCurrentPlayer("4084", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("云三娘：村里的茶叶卖得好，大伙儿都去种茶了，用不到什么大农具，九金得了空闲，这几天又在钻研武器图谱了。", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("云三娘：金兰的手艺是跟着九金学的，算到如今也有三、四年了，如今这大李铁铺卖的农具，大都是金兰打造的。", "");
    }
    else
    {
        giTalk("云三娘：九金其实还有个弟弟，从小喜欢打兵器，后来和云家那个惹祸精一起出了村，就再也没回来过。", "");
    }
    giNpcResetDir("4084");
    giNpcResumeBeh("4084");
    giPlayerUnLock();
}

void func4085()
{
    giPlayerLock();
    giNpcPauseBeh("4085");
    giCurrentPlayerFaceToNpc("4085", true);
    giNpcFaceToCurrentPlayer("4085", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("王小鹏：姐姐说的对，阿爹年纪大了，就算湖上很太平，也不该让阿爹再上船。何况我也长大了，可以帮姐姐一起撒网收网了！", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("王小鹏：最近湖面上多了好多漩涡，风浪也比从前大，姐姐都不让我和爹上船了……", "");
    }
    else
    {
        giTalk("王小鹏：今天是端阳节，阿爹的鱼一会儿就卖完了，现在阿爹还要带我去看戏吃粽子呢！", "");
    }
    giNpcResetDir("4085");
    giNpcResumeBeh("4085");
    giPlayerUnLock();
}

void func4086()
{
    giPlayerLock();
    giNpcPauseBeh("4086");
    giCurrentPlayerFaceToNpc("4086", true);
    giNpcFaceToCurrentPlayer("4086", true);
    if (global_mvar >= 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giTalk("茶馨：茶叶摘了之后，要烘干揉细，才能泡着喝。如果是要送到大城里去卖的，还得制成饼团才行。", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giTalk("茶馨：都说巢湖上有妖怪，最近捕鱼卖鱼的人少了，想给阿娘买条鲫鱼补身子都不成了，唉……", "");
    }
    else
    {
        giTalk("茶馨：白头老媪簪红花，黑头女娘三髻丫。背上儿眠上山去，采桑已闲当采茶。", "");
    }
    giNpcResetDir("4086");
    giNpcResumeBeh("4086");
    giPlayerUnLock();
}

void func5001()
{
    giPlayerLock();
    giNpcPauseBeh("4021");
    giNpcFaceToCurrentPlayer("4021", true);
    giCurrentPlayerFaceToNpc("4021", true);
    if (var_shop035 != 0)
    {
        if (var_shop035 != 2)
        {
            giStartTradeSystem("shop010", "");
        }
        else
        {
            giTalk("姚若琴：没想到……我还以为相公他出了什么事，日日睡不安稳，没想到他竟在陈州迷恋一个风尘女子，我……我怎么这样命苦啊！", "");
            giTalk("姚若琴：唉，不好意思，让小哥你见笑了，我这儿也没别的好东西，这两个东西你拿着，别客气。", "");
            giAddEquipment(3671, true);
            giWait(2.0);
            giAddEquipment(3687, true);
            giWait(2.0);
            var_shop035 = 3;
            giStartTradeSystem("shop010", "");
        }
    }
    else
    {
        giStartTradeSystem("shop010", "Buiness_Q02_5001");
    }
    giNpcResetDir("4021");
    giNpcResumeBeh("4021");
    giPlayerUnLock();
}

void func5002()
{
    giPlayerLock();
    giNpcPauseBeh("4017");
    giNpcFaceToCurrentPlayer("4017", true);
    giCurrentPlayerFaceToNpc("4017", true);
    giStartTradeSystem("shop020", "");
    giNpcResetDir("4017");
    giNpcResumeBeh("4017");
    giPlayerUnLock();
}

void func5003()
{
    giPlayerLock();
    giNpcPauseBeh("4012");
    giNpcFaceToCurrentPlayer("4012", true);
    giCurrentPlayerFaceToNpc("4012", true);
    if (var_shop005 != 0)
    {
        if (var_shop005 != 1)
        {
            giStartTradeSystem("shop031", "");
        }
        else
        {
            if (giCheckPackProperty(3020, 5))
            {
                giTalk("李慎：嘿！不错不错，小哥你办事倒是挺利索～来，这些是咱太平村的点心，就送给你当酬劳吧！", "");
                giDelProperty(3020, 5, true);
                giWait(2.0);
                giAddProperty(3012, 30, true);
                giWait(2.0);
                giAddProperty(3018, 30, true);
                giWait(2.0);
                var_shop005 = 2;
            }
            giStartTradeSystem("shop031", "");
        }
    }
    else
    {
        giStartTradeSystem("shop031", "Buiness_Q02_5003");
    }
    giNpcResetDir("4012");
    giNpcResumeBeh("4012");
    giPlayerUnLock();
}

void Buiness_Q02_5001()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("相公他虽然常常出远门，但两、三个月总能回来一趟，可这回去了陈州，已经快半年了，还没个音信！小哥，如果你路过陈州，就<colour red=255 green=187 blue=0 alpha=255>帮忙打听一下我相公云遥庆的下落</colour><dc0>吧！谢谢你了！</dc0><br/><dc0>你愿意帮忙打听下吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        var_shop035 = 1;
    }
}

void Buiness_Q02_5003()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("嘿，小哥我看你怎么有点面熟呢……你说要帮我办事？那太好了！玲珑那小姑娘突然想吃醉枣糕，我李慎可从来不拒绝像玲珑那么可爱的小女娃儿！所以……你能不能<colour red=255 green=187 blue=0 alpha=255>帮我跑一趟陈州，带五份醉枣回来</colour><dc0>？</dc0><br/><dc0>你愿意帮我去买吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        var_shop005 = 1;
    }
}
