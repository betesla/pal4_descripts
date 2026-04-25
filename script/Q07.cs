// Structured PAL4 reconstruction for Q07.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void Q07_Q07_init()
{
    if (global_mvar == 70700 /* 荒漠深处 */)
    {
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4011", false);
        giSetNpcVisible("4008", false);
        giSetNpcVisible("4004", false);
        giSetNpcVisible("4006", false);
        giSetNpcVisible("4005", false);
        func2001();
    }
    if (global_mvar >= 130100)
    {
        if (global_mvar >= 150100 /* 噩梦纷争 */)
        {
            giSetObjectVisible("mark1", false);
            giSetNpcVisible("4001", false);
            giSetNpcVisible("4003", false);
            giSetNpcVisible("4004", false);
            giSetNpcVisible("4005", false);
            giSetNpcVisible("4006", false);
            giSetNpcVisible("4008", false);
            giSetNpcVisible("4009", false);
            giSetNpcVisible("5001", false);
            giSetNpcVisible("4011", false);
            giSetNpcVisible("5006", true);
            giSetObjectVisible("mark4", true);
            giSetObjectVisible("mark1", false);
        }
        else
        {
            giSetNpcVisible("4004", false);
            giSetNpcVisible("4005", false);
            giSetNpcVisible("4006", false);
            giSetNpcVisible("4008", false);
            giSetNpcVisible("4009", false);
        }
    }
    if (global_mvar == 160100)
    {
        func2003();
    }
    if (global_mvar < 70800 || global_mvar < 90100 && global_mvar >= 70901)
    {
        giSetObjectVisible("entrance0", false);
        giSetObjectVisible("entrance1", true);
    }
    else
    {
        giSetObjectVisible("entrance0", true);
        giSetObjectVisible("entrance1", false);
    }
    giArenaReadyRestore();
}

void Q07_N03b_init()
{
    if (global_mvar < 150100 /* 噩梦纷争 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("4002", false);
        giArenaReadyRestore();
    }
}

void Q07_N02_init()
{
    if (global_mvar < 150100 /* 噩梦纷争 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("4007", false);
        giArenaReadyRestore();
    }
}

void Q07_N03c_init()
{
    if (global_mvar != 70900 /* 第二章 / 4-4-2.叹沧桑 / 禀报掌门 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("MN001", true);
        giSetObjectVisible("MO001", true);
        giArenaReadyRestore();
    }
}

void func1001()
{
    giArenaLoad("Q07", "N01", "", true);
    giPlayerCurrentSetPos(44.24654, 1.430281, 91.99919);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("Q07", "Q07", "", true);
    giPlayerCurrentSetPos(-188.40321, 10.918547, -174.4457);
    giPlayerCurrentSetAng(4.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("Q07", "N02", "", true);
    giPlayerCurrentSetPos(-3.553157, 0.562542, 63.8504);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("Q07", "Q07", "", true);
    giPlayerCurrentSetPos(201.8758, 10.918549, -844.85205);
    giPlayerCurrentSetAng(359.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("Q07", "N03", "N03a", true);
    giPlayerCurrentSetPos(19.203232, 1.090019, 119.12068);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("Q07", "Q07", "", true);
    giPlayerCurrentSetPos(-769.54, 10.918549, -891.7108);
    giPlayerCurrentSetAng(343.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("Q07", "N03", "N03b", true);
    giPlayerCurrentSetPos(19.203232, 1.090019, 119.12068);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("Q07", "Q07", "", true);
    giPlayerCurrentSetPos(-1956.5455, 10.984173, 126.21924);
    giPlayerCurrentSetAng(99.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1009()
{
    giArenaLoad("Q07", "N03", "N03c", true);
    giPlayerCurrentSetPos(19.203232, 1.090019, 119.12068);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(2, true);
    giArenaReady();
}

void func1010()
{
    giArenaLoad("Q07", "Q07", "", true);
    giPlayerCurrentSetPos(220.07617, 10.918547, 706.24805);
    giPlayerCurrentSetAng(158.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1011()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    if (global_mvar < 70800 || global_mvar < 90100 && global_mvar >= 70901)
    {
        giArenaLoad("M11", "1", "", true);
        giPlayerCurrentSetPos(2925.9087, -95.6444, -4626.729);
        giPlayerCurrentSetAng(325.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giSelectDialogAddItem("1.去月牙河谷");
        giSelectDialogAddItem("2.御剑飞行  ");
        giSelectDialogAddItem("3.什么都不做");
        giSelectDialogSetDefaultSelect(2);
        giShowSelectDialog(" 准备<colour red=255 green=102 blue=0 alpha=255>去月牙河谷</colour><dc0>还是</dc0><colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>？</dc0>");
        select_dialog_last_select = giSelectDialogGetLastSelect();
        if (select_dialog_last_select != 0)
        {
            if (select_dialog_last_select != 1)
            {
                leader_player_id = giPlayerGetLeader();
                giPlayerWalkTo(leader_player_id, -2135.864, -71.1017, 647.13367, true);
                giPlayerSetDir(leader_player_id, 66.0, true);
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
            giArenaLoad("M11", "1", "", true);
            giPlayerCurrentSetPos(2925.9087, -95.6444, -4626.729);
            giPlayerCurrentSetAng(325.0);
            giCameraSetMode(5, true);
            giArenaReady();
        }
        giPlayerUnLock();
    }
}

void func1012()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(-587.497, 10.918549, 614.5434, true);
    giPlayerCurrentSetAng(157.0);
    giSetPortrait("102C", true);
    giTalk("云天河：房门锁住了……", "");
    giPlayerUnLock();
}

void func1013()
{
    giPlayerLock();
    giPlayerCurrentWalkTo(556.60425, 11.348549, 709.358, true);
    giPlayerCurrentSetAng(223.0);
    giSetPortrait("102C", true);
    giTalk("云天河：房门锁住了……", "");
    giPlayerUnLock();
}

void func2001()
{
    if (global_mvar == 70700 /* 荒漠深处 */)
    {
        giPlayerLock();
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -1358.3396, 6.0652, 307.9243);
        giPlayerSetAng(0, 96.0);
        giPlayerSetPos(1, -1282.1595, 10.9185, 358.486);
        giPlayerSetAng(1, 112.0);
        giPlayerSetPos(2, -1348.3491, 7.6411, 401.9274);
        giPlayerSetAng(2, 106.0);
        giSetObjectVisible("title04", false);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("4001", false);
        giSetNpcVisible("4011", false);
        giSetNpcVisible("4008", false);
        giSetNpcVisible("4004", false);
        giSetNpcVisible("4006", false);
        giSetNpcVisible("4005", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.0);
        giCameraRunSingle("002", false);
        giWait(1.5);
        giPlayerWalkTo(1, -1144.1891, 10.9185, 331.4507, false);
        giPlayerWalkTo(0, -1224.111, 10.9185, 294.9966, false);
        giWait(0.3);
        giPlayerWalkTo(2, -1236.2451, 10.9185, 363.3908, true);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 66.0, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 81.0, false);
        giPlayerSetDir(2, 118.0, false);
        giCameraWait();
        giWait(2.0);
        giCameraRunSingle("003", true);
        giWait(1.0);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：有个村子……还有人在吗？", "42865");
        giWait(0.5);
        giPlayerDoAction(0, "J13", 1, false);
        giWait(1.0);
        giPlayerSetDir(1, 60.0, false);
        giWait(1.0);
        giPlayerSetDir(1, 150.0, false);
        giPlayerEndAction(0);
        giWait(1.0);
        giPlayerDoAction(2, "C07", -1, false);
        giWait(0.5);
        giSetPortrait("107G", true);
        giTalk("柳梦璃：等一下！", "42866");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetAng(1, 290.0);
        giPlayerSetAng(0, 358.0);
        giPlayerSetAng(2, 75.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(1.2);
        giCameraRunSingle("004", false);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107G", false);
        giTalk("柳梦璃：那里……那里有人在喊……让我们救救他！", "42867");
        giCameraRunSingle("006", true);
        giIMMBegin();
        giPlayerDoAction(2, "C01", 0, false);
        giPlayerSetAng(2, 118.0);
        giPlayerSetAng(1, 82.0);
        giPlayerSetAng(0, 64.0);
        giIMMEnd();
        giCameraWait();
        giWait(1.0);
        giCameraRunSingle("003", true);
        giWait(1.0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：啊？有吗？", "42868");
        giWait(0.5);
        giPlayerSetDir(1, 258.0, true);
        giWait(0.2);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104F", false);
        giTalk("韩菱纱：梦璃说有就有啦！走，我们快过去看看！", "42869");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerEndAction(0);
        giPlayerWalkTo(1, -1054.5273, 10.9185, 344.5991, false);
        giWait(0.8);
        giPlayerWalkTo(2, -1057.4484, 10.9186, 342.9155, false);
        giWait(0.5);
        giPlayerWalkTo(0, -1053.8456, 10.9185, 302.1494, false);
        giWait(0.5);
        giFlashOutBlack(1.0, true, true);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giPlayerEndMove(2);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetObjectVisible("title04", true);
        giIMMEnd();
        global_mvar = 70800; // 0x00011490
        giArenaLoad("Q07", "N03", "N03c", true);
        giPlayerLock();
        giScriptMusicPlay("P35", 2, 0.0, 2.5);
        giPlayerCurrentSetVisible(false);
        giIMMBegin();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetPos(0, 3.3515, 1.09, 137.7315);
        giPlayerSetPos(1, 3.3515, 1.09, 137.7315);
        giPlayerSetPos(2, 3.3515, 1.09, 137.7315);
        giSetNpcVisible("MN001", true);
        giNpcSetAng("MN001", 166.0);
        giSetObjectVisible("MO001", true);
        giIMMEnd();
        giArenaReady();
        gi2DSoundPlay("WJ025", 1);
        giNpcDoAction("MN001", "J01", -1, false);
        giWait(0.5);
        giFlashInBlack(0.5, true);
        gi2DSoundPlay("WJ029", 0);
        giWait(1.5);
        giPlayerRunTo(1, 1.3215, 1.09, 10.3396, true);
        giPlayerSetAng(1, 141.0);
        giWait(0.1);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("104I", true);
        giTalk("韩菱纱：快住手！", "42870");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        gi2DSoundStop();
        giNpcSetDir("MN001", 324.0, true);
        giSetPortrait("214A", false);
        giTalk("乌兰：……！", "42871");
        giWait(1.0);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(2, -42.2569, 1.09, -51.7405, false);
        giWait(0.5);
        giPlayerWalkTo(0, -53.1952, 1.09, 9.5345, false);
        giPlayerEndMove(0);
        giPlayerEndMove(2);
        giIMMBegin();
        giPlayerSetDir(0, 120.0, false);
        giPlayerSetDir(2, 93.0, false);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("214A", false);
        giTalk("乌兰：你们！你们是……", "42872");
        giWait(0.3);
        giSetPortrait("104I", true);
        giTalk("韩菱纱：你在做什么？ ", "42873");
        giWait(0.5);
        giSetPortrait("214A", false);
        giTalk("乌兰：我、没……", "42874");
        giWait(0.5);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("104K", true);
        giTalk("韩菱纱：那么小的孩子和你有深仇大恨吗？！你居然想把他活活掐死！", "42875");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("214A", false);
        giTalk("乌兰：不是的！！我没有……", "42876");
        giWait(0.3);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("104K", true);
        giTalk("韩菱纱：什么没有！我明明看见的！", "42877");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        gi2DSoundPlay("WJ025", 1);
        giSetNpcVisible("MN002", true);
        giCameraRunSingle("003", true);
        giWait(1.0);
        giNpcDoAction("MN002", "J01", 1, false);
        giSetPortrait("215A", true);
        giTalk("巴图：天吶！乌兰，你竟然做出这样的糊涂事！", "42878");
        giNpcEndAction("MN002", true);
        giNpcWalkTo("MN002", 40.7694, 1.09, 54.8797, false);
        giIMMBegin();
        giPlayerSetDir(0, 56.0, false);
        giPlayerSetDir(1, 38.0, false);
        giPlayerSetDir(2, 38.0, false);
        giNpcSetDir("MN001", 0.0, false);
        giIMMEnd();
        giWait(0.5);
        giCameraRunSingle("004", true);
        giNpcEndMove("MN002");
        giNpcSetDir("MN002", 174.0, true);
        giWait(0.5);
        giSetPortrait("214A", true);
        giTalk("乌兰：村长！……", "42879");
        giWait(0.5);
        giNpcDoAction("MN002", "J01", 1, false);
        giSetPortrait("215A", false);
        giTalk("巴图：我是听见声音才进来的，没想到你……", "42880");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.8);
        giSetPortrait("214A", false);
        giTalk("乌兰：…………村长，我……我也不想的……", "42881");
        giWait(0.3);
        giNpcDoAction("MN001", "J02", -1, false);
        giSetPortrait("214A", false);
        giTalk("乌兰：只要还有一点办法，我又怎能狠下心来……这孩子毕竟是我的骨血啊！", "42882");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giIMMBegin();
        giPlayerSetAng(0, 120.0);
        giPlayerSetAng(1, 141.0);
        giPlayerSetAng(2, 95.0);
        giNpcSetAng("MN001", 329.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J02", 1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：啊？！", "42883");
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107G", false);
        giTalk("柳梦璃：他、他是你的小孩？到底发生了什么事？让你连自己的孩子都要杀？！", "42884");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(2, "C09", 1, false);
        giWait(1.0);
        giSetPortrait("107G", false);
        giTalk("柳梦璃：……若不是、若不是幼儿灵力极强，令我听见他的求救……", "42885");
        giPlayerEndAction(2);
        giWait(0.5);
        giNpcSetDir("MN001", 280.0, true);
        giWait(0.5);
        giSetPortrait("214A", true);
        giTalk("乌兰：…………我又有什么办法……这孩子的姐姐，生下来以后连一岁都不到就死了……水实在太少，食物也是有一顿没一顿的……", "42886");
        giWait(0.5);
        giSetPortrait("214A", true);
        giTalk("乌兰：往后……让我眼睁睁看着他活不下去，倒不如、不如……", "42887");
        giNpcDoAction("MN001", "J02", -1, false);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, -60.5136, 1.09, 2.3399);
        giPlayerSetPos(1, 2.1175, 1.09, 15.3652);
        giPlayerSetPos(2, -49.5752, 1.09, -49.1009);
        giNpcSetPos("MN002", 57.9247, 1.09, 51.5047);
        giNpcSetAng("MN002", 190.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("215A", false);
        giTalk("巴图：乌兰……我知道你自从丈夫和女儿病死之后，一直很伤心，但再怎么苦，都要熬过去啊！", "42888");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.3);
        giNpcSetDir("MN001", 6.0, true);
        giWait(0.3);
        giSetPortrait("215A", false);
        giTalk("巴图：能够带走人性命的，只有天上的神，你要是真的那样做了，死后连灵魂都不能得到神的宽恕！", "42889");
        giWait(0.3);
        giWait(0.3);
        giSetPortrait("214A", true);
        giTalk("乌兰：村长……我……我到底该怎么办！", "42890");
        giWait(0.5);
        giPlayerWalkTo(0, -5.673, 1.09, -50.235, true);
        giPlayerDoAction(0, "J03", -1, false);
        giNpcSetDir("MN001", 280.0, false);
        giWait(1.2);
        giSetObjectVisible("MO002", true);
        giWait(0.5);
        giSetPortrait("214A", false);
        giTalk("乌兰：……！", "42891");
        giWait(0.2);
        giSetObjectVisible("MO003", true);
        giWait(0.8);
        giSetObjectVisible("MO004", true);
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetDir(0, 90.0, true);
        giWait(0.5);
        giSetPortrait("102J", true);
        giTalk("云天河：你不是说没有水也没有食物吗？我身上的这些都可以给你。", "42892");
        giWait(0.8);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：还有我和梦璃的！", "42893");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "C08", 1, false);
        giWait(0.5);
        giNpcSetDir("MN001", 324.0, true);
        giSetPortrait("214A", false);
        giTalk("乌兰：……", "42894");
        giWait(1.5);
        giNpcSetDir("MN002", 218.0, true);
        giWait(1.5);
        giSetPortrait("215A", false);
        giTalk("巴图：你们？这身装扮……天呐！你们是仙山上神的仆人！", "42895");
        giWait(0.3);
        giIMMBegin();
        giPlayerSetDir(0, 31.0, false);
        giPlayerSetDir(1, 58.0, false);
        giPlayerSetDir(2, 47.0, false);
        giIMMEnd();
        giWait(1.0);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：神的仆人？不是啊——", "42896");
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("008", false);
        giSetPortrait("215A", false);
        giTalk("巴图：求求你们了！能不能帮村子里的人向神祷告，让月牙河再恢复从前的样子？！", "42897");
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：……先别急，告诉我们究竟是怎么一回事吧。", "42898");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.7);
        giIMMBegin();
        giPlayerSetVisible(3, true);
        giPlayerSetPos(3, -14.7144, 1.09, 93.2009);
        giPlayerSetAng(3, 162.0);
        giCameraRunSingle("010", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：不错，我也很想知道是怎么一回事！", "42899");
        giIMMBegin();
        giPlayerSetPos(0, -24.9276, 1.09, -31.3462);
        giPlayerSetAng(0, 4.0);
        giPlayerSetPos(1, 10.9199, 1.09, 6.6495);
        giPlayerSetAng(1, 348.0);
        giPlayerSetPos(2, -62.9738, 1.09, -15.6328);
        giPlayerSetAng(2, 26.0);
        giNpcSetAng("MN001", 341.0);
        giNpcSetAng("MN002", 300.0);
        giIMMEnd();
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(3, 183.8234);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("102D", false);
        giTalk("云天河：师、师叔？！", "42900");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：你们眼里还有我这个师叔？！", "42901");
        giWait(0.5);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：我倒不知何时吩咐过你们下山办事了！", "42902");
        giPlayerEndAction(3);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102E", false);
        giTalk("云天河：呃……", "42903");
        giWait(1.0);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：紫英你先别生气嘛～你不是说过琼华派弟子应该扶危济困？这回我们误打误撞，才发现昆仑山脚下竟有这样缺水的村子，于情于理总该先帮帮他们吧？", "42904");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.8);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……虽是其心可悯，但这与擅自下山却是两回事，回去之后再罚你们。", "42905");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：……小气……", "42906");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.2);
        giSetPortrait("215A", false);
        giTalk("巴图：……你是？", "42907");
        giWait(0.5);
        giPlayerSetDir(3, 131.8234, true);
        giWait(0.3);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：老人家，在下慕容紫英，乃是昆仑琼华派的弟子。能不能告诉我们，这个村子为何会如此干旱？若能相助，定然义不容辞。", "42908");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetDir(0, 36.0, false);
        giPlayerSetDir(1, 38.0, false);
        giPlayerSetDir(2, 56.0, false);
        giIMMEnd();
        giWait(1.0);
        giSetPortrait("215A", false);
        giTalk("巴图：你们～你们果然是仙山上来的人，这真是上天可怜我们呐！", "42909");
        giWait(0.3);
        giCameraRunSingle("012", false);
        giWait(0.3);
        giSetPortrait("215A", false);
        giTalk("巴图：……说起来也已经是很久以前的事了，月牙村曾经是个美丽的绿洲，从昆仑山上流下一条月牙河，养活了整个村子的人。在河的源头还有一片树林，虽然不很大，但是长得特别茂盛。", "42910");
        giSetPortrait("215A", false);
        giTalk("巴图：可是……到我爷爷那一辈，村里来了很多做生意的中原人，说那片树林是传说中的“昆仑圣木”，砍了以后能够卖个好价钱。", "42911");
        giWait(0.5);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：这、这怎么可以？！", "42912");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giNpcDoAction("MN002", "C09", 1, false);
        giSetPortrait("215A", false);
        giTalk("巴图：是啊，可惜那个时候村里的祭司虽然极力反对，但是其他人都想变得和中原商人一样富有，最后还是同意了砍树……那些树倒了之后，月牙河的水就慢慢枯竭了……", "42913");
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107F", true);
        giTalk("柳梦璃：…………", "42914");
        giPlayerEndAction(2);
        giWait(0.5);
        giSetPortrait("215A", false);
        giTalk("巴图：所有人都后悔了，想过很多办法让水源恢复，甚至还修了新的祭坛向上天祷告，但是没有用……天神已经被激怒了……", "42915");
        giWait(0.4);
        giCameraRunSingle("013", false);
        giWait(0.8);
        giSetPortrait("215A", false);
        giTalk("巴图：最近几年，月牙河完全干了，不少人因为缺水，都患上重病过世了……也有年轻力壮的，离开这儿想去别处生活，却再也没有回来过……", "42916");
        giWait(0.5);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：老人家，不如你们也迁去其他地方吧？此处风尘环伺，实在不宜定居。", "42917");
        giPlayerDoAction(0, "C08", 1, false);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.3);
        giNpcDoAction("MN002", "C09", 1, true);
        giSetPortrait("215A", false);
        giTalk("巴图：唉，村子里的孤儿寡母，又怎么经得起长途跋涉……", "42918");
        giSetPortrait("215A", false);
        giTalk("巴图：更重要的是，月牙村是我们祖祖辈辈安家的地方啊，我身为村长，难道……难道连这故土都保不住…………", "42919");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giWait(0.3);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：……就没有其他办法了吗？", "42920");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giNpcSetDir("MN002", 243.0, true);
        giWait(0.3);
        giNpcDoAction("MN002", "C09", 1, true);
        giSetPortrait("215A", false);
        giTalk("巴图：办法是有的，只是太难……", "42921");
        giSetPortrait("215A", false);
        giTalk("巴图：我听已经过世的老祭司说过，这世上有一种叫“水灵珠”的宝物，只要有了它，水源就能恢复，一切也会变回原来的模样。", "42922");
        giWait(0.8);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：水灵珠？！", "42923");
        giNpcSetDir("MN002", 310.0, true);
        giWait(0.8);
        giSetPortrait("215A", false);
        giTalk("巴图：老祭司他确实是这么告诉我的……", "42924");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetDir(2, 26.0, false);
        giPlayerSetDir(0, 4.0, false);
        giPlayerSetDir(1, 348.0, false);
        giIMMEnd();
        giWait(0.9);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107D", true);
        giTalk("柳梦璃：师叔，你是不是知道些什么？", "42925");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giWait(0.8);
        giPlayerSetDir(3, 184.0, true);
        giWait(0.5);
        giCameraRunSingle("016", false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：若是水灵珠，倒有一线希望，因它正是本门镇派之宝！", "42926");
        giWait(0.5);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", false);
        giTalk("韩菱纱：咦？竟有这样巧的事？！", "42927");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(3, "C08", 1, true);
        giWait(0.5);
        giWait(0.5);
        giPlayerSetDir(3, 132.0, true);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：待我禀明掌门，看是否可将水灵珠借来一用。老祭司说的应该没错，水灵珠乃世间至宝，相信以水灵之力，必能令河源复苏。", "42928");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：呵呵，这真是太好了！", "42929");
        giPlayerEndAction(0);
        giWait(0.3);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：老人家，我们先将身边的水和食物都留下，请等候消息。", "42930");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("215A", false);
        giTalk("巴图：谢谢你们！你们果然是天神的使者啊！", "42931");
        giWait(0.5);
        giIMMBegin();
        giNpcSetAng("MN001", 341.0);
        giCameraRunSingle("018", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("214A", false);
        giTalk("乌兰：……谢谢你们……谢谢……", "42932");
        giPlayerWalkTo(2, 4.1277, 1.09, -58.6716, true);
        giPlayerSetDir(2, 71.0, true);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：别担心，这个孩子的意志力很强，一定会健健康康地长大，成为一个出色的男子汉。", "42933");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giNpcSetDir("MN001", 273.0, true);
        giWait(0.5);
        giSetPortrait("214A", false);
        giTalk("乌兰：谢谢……", "42934");
        giNpcDoAction("MN001", "J02", -1, false);
        giSetPortrait("214A", false);
        giTalk("乌兰：如果不是你们，我真要后悔一辈子了……", "42935");
        giPlayerSetPos(3, -21.2219, 1.09, 81.2621);
        giPlayerSetAng(3, 154.8234);
        giWait(1.5);
        giCameraRunSingle("019", true);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：事不宜迟，你们跟我回山上，<colour red=255 green=187 blue=0 alpha=255>一同去琼华宫向掌门禀明此事</colour><dc0>。</dc0>", "42936");
        giWait(0.5);
        giPlayerWalkTo(3, 34.8901, 1.09, 128.8881, true);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giSetNpcVisible("MN002", false);
        giSetNpcVisible("MN001", false);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        global_mvar = 70900; // 0x000114F4, 第二章 / 4-4-2.叹沧桑 / 禀报掌门
        giArenaLoad("Q07", "Q07", "", true);
        giPlayerCurrentSetPos(143.188, 10.918547, 573.486);
        giPlayerCurrentSetAng(182.0);
        giCameraSetMode(0, true);
        giFlashInBlack(1.5, true);
        giArenaReady();
        giPlayerUnLock();
    }
}

void func2002()
{
    if (global_mvar == 70900 /* 第二章 / 4-4-2.叹沧桑 / 禀报掌门 */)
    {
        giPlayerLock();
        giCurrentPlayerFaceToNpc("MN001", true);
        giRandTalkRelease();
        giRandTalkPush("乌兰：谢谢，如果不是你们，我真要后悔一辈子了……");
        giRandTalkPush("乌兰：……谢谢你们……谢谢……");
        giRandTalk();
        giRandTalkRelease();
        giPlayerUnLock();
    }
}

void func2003()
{
    if (global_mvar == 160100)
    {
        giPlayerLock();
        giScriptMusicPlay("P31", 2, 0.0, 0.0);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 217.7719, 10.9185, -490.153);
        giPlayerSetAng(0, 102.0);
        giPlayerSetPos(1, 228.9679, 10.9185, -542.2311);
        giPlayerSetAng(1, 82.0);
        giPlayerSetPos(3, 292.0882, 10.9186, -510.3862);
        giPlayerSetAng(3, 286.0);
        giPlayerSetPos(2, 157.5445, 10.9186, -478.2012);
        giPlayerSetAng(2, 84.0);
        giSetObjectVisible("title01", false);
        giSetObjectVisible("title04", false);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giArenaReady();
        giWait(1.2);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giEffectPlayWithPlayer("H_097", 1, 0);
        giEffectPlayWithPlayer("H_097", 1, 1);
        giEffectPlayWithPlayer("H_097", 1, 3);
        giIMMEnd();
        giWait(1.0);
        giCameraRunSingle("002", false);
        giWait(5.5);
        giCameraRunSingle("003", true);
        giWait(0.3);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：这儿是……月牙村？", "46159");
        giPlayerSetDir(0, 50.0, true);
        giPlayerDoAction(0, "J13", -1, false);
        giWait(0.8);
        giCameraRunSingle("004", true);
        giWait(0.8);
        giCameraRunSingle("005", false);
        giWait(1.2);
        giSetPortrait("101G", true);
        giTalk("云天河：妖界看不见了……梦璃她……真的走了……", "46160");
        giWait(1.5);
        giPlayerSetAng(1, 356.0);
        giCameraRunSingle("006", true);
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：天河，你别难过了……", "46161");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giSetPortrait("101G", true);
        giTalk("云天河：以前在山上一切都很自在，爹对生死离别也看得很淡……", "46162");
        giWait(0.5);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：但我现在不一样了，也许这就是伤心吧……", "46163");
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：天河……", "46164");
        giWait(2.0);
        giEffectPlayWithPlayer("H_132", 1, 2);
        giPlayerBlendIn(2, 1.5, true);
        giWait(1.5);
        giCameraRunSingle("007", false);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetDir(0, 276.0, false);
        giPlayerSetDir(1, 310.0, false);
        giPlayerSetDir(3, 292.0, false);
        giIMMEnd();
        giCameraWait();
        giWait(1.5);
        giCameraRunSingle("030", false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：……至少，还有另一个“梦璃”陪着我们，就算……她也只是一场梦…………如果……如果在琼华派和幻瞑界之间发生的那些事，也能像做梦一样，醒来之后发觉全是假的，那该有多好……", "46165");
        giWait(1.0);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：人生已如枕梁一梦，我们所以为的“幻境”，说不定仅是梦中之梦，生死则是一场更大的梦。", "46166");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, 223.5384, 10.9185, -509.0511);
        giPlayerSetAng(0, 50.0);
        giPlayerSetPos(1, 251.7593, 10.9185, -561.4496);
        giPlayerSetAng(1, 30.0);
        giPlayerSetPos(3, 292.9307, 10.9185, -477.2229);
        giPlayerSetAng(3, 284.0);
        giPlayerSetVisible(2, false);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：紫英……？", "46167");
        giPlayerDoAction(3, "C09", 1, true);
        giWait(0.3);
        giPlayerSetDir(3, 210.0, true);
        giWait(0.4);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：没什么，只是忽然想起了以前宗炼师公说过的话，历经这么多事，我才明白其中的那种无奈……", "46168");
        giWait(0.8);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：你们……我不懂，人活着，还分什么真的假的？梦璃走了，我心里难过，一定是真的，怎么会有假？还有接下来要去做的很多事……如果这些都是梦，干嘛还要做？", "46169");
        giWait(0.5);
        giPlayerSetDir(1, 344.0, true);
        giWait(0.3);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……", "");
        giWait(0.5);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：天河你啊，一点都没变，总会说出些让人吓一跳的话。", "46171");
        giWait(0.5);
        giPlayerSetDir(0, 144.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：有吗？就是想到什么说什么啊。", "46172");
        giWait(0.6);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：无论如何，我们还有许多事要做，不能一直耽于感伤……眼前便要将水灵珠交给月牙村的村长。", "46173");
        giPlayerSetDir(1, 18.0, false);
        giPlayerSetDir(0, 50.0, false);
        giWait(0.8);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", true);
        giTalk("韩菱纱：啊，对了！梦璃是告诉过我，那个人……玄霄他把水灵珠给了天河，这么说来，这里真的能再一次变成绿洲了？！", "46174");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giPlayerDoAction(3, "C08", 1, true);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：到底要如何做，等一下再问村长吧。", "46175");
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：我这就去告诉村长！", "46176");
        giWait(0.3);
        giCameraRunSingle("009", false);
        giWait(0.3);
        giPlayerRunTo(1, 207.6704, 10.9185, -865.603, false);
        giWait(0.3);
        giPlayerSetDir(0, 172.0, false);
        giPlayerSetDir(3, 204.0, false);
        giPlayerEndMove(1);
        giPlayerBlendOut(1, 1.0, true);
        giWait(2.5);
        giPlayerSetDir(3, 234.0, true);
        giWait(0.5);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：天河，接下来你如何打算？是否去找……玄霄师叔？", "46177");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giPlayerSetDir(0, 48.0, false);
        giCameraRunSingle("010", true);
        giWait(0.8);
        giSetPortrait("101H", false);
        giTalk("云天河：当然！我要夺回望舒剑！", "46178");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……但是，以师叔如今之能，就算你我倾尽全力，只怕也难动他分毫……", "46179");
        giWait(0.5);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：打不过也要打！不然菱纱——", "46180");
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：我绝对不能再伤心一次，我不要！", "46181");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：…………", "46182");
        giWait(0.5);
        gi2DSoundPlay("WJ025", 1);
        giWait(1.0);
        giPlayerSetAng(1, 6.0);
        giPlayerSetVisible(1, true);
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：天河！紫英！", "46183");
        giWait(0.5);
        giCameraRunSingle("011", true);
        giWait(0.5);
        giPlayerSetDir(0, 158.0, false);
        giPlayerSetDir(3, 208.0, false);
        giWait(0.5);
        giPlayerRunTo(1, 251.7593, 10.9185, -561.4496, true);
        giPlayerSetAng(1, 18.0);
        giWait(0.6);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：我们……", "46184");
        giWait(0.5);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：发生何事？！", "46185");
        giWait(0.5);
        giCameraRunSingle("012", false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：我们……来晚了……村长、还有其他人……他们已经离开了月牙村……", "46186");
        giWait(0.5);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：……！何时走的？！", "46187");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：看村长的留书，有一个多月了……他说很感激我们，可是……村里人没办法再等下去了……以前从村里出去的人经商赚了钱，带着商队回来接他们……他们最终还是放弃了，决定穿过沙漠，去绿洲生活……", "46188");
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：……都走了？…………也好，他们能过得比以前好……", "46189");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……梦璃走了，月牙村的人也走了，到头来以为能够做成的事，一件都做不成……", "46190");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101G", true);
        giTalk("云天河：……", "46191");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：琼华派所有人……身在昆仑，受人敬仰，却无法泽被山脚下的百姓，如此大过，枉被称为“剑仙”……", "46192");
        giPlayerEndAction(3);
        giPlayerSetDir(1, 20.0, false);
        giPlayerSetDir(0, 52.0, false);
        giWait(0.8);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：紫英……", "46193");
        giWait(1.0);
        giPlayerSetDir(0, 142.0, true);
        giWait(0.3);
        giSetPortrait("101G", true);
        giTalk("云天河：菱纱，让紫英送你去播仙镇吧，你太累了，好好睡上一觉——", "46194");
        giPlayerSetDir(1, 340.0, true);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：那你呢？", "46195");
        giWait(0.5);
        giCameraRunSingle("014", true);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P33", 2, 0.0, 0.0);
        giWait(1.9);
        giSetPortrait("101G", true);
        giTalk("云天河：我回琼华派，去找玄霄。", "46196");
        giWait(0.3);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：什么？！", "46197");
        giWait(0.3);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：不可以，你别去，你根本不是他的对手！", "46198");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101G", true);
        giTalk("云天河：……", "46199");
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你不是答应过我？要一起回青鸾峰吗？是骗人的？！ ", "46200");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：我说话算话，不过得先抢回望舒剑，玄霄他们再用那把剑，你会没命的……", "46201");
        giWait(0.5);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：我早说了，不稀罕什么命长命短，你别去！", "46202");
        giPlayerDoAction(0, "C09", 1, true);
        giSetPortrait("101I", true);
        giTalk("云天河：……但我稀罕。", "46203");
        giWait(0.3);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你……", "46204");
        giWait(0.4);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：…………", "46205");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你！你一定要去的话，我宁可马上就死了，也不要你赔上一条命！", "46206");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：你乱说什么！", "46207");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：你们，休要再争！", "46208");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetDir(0, 58.0, false);
        giPlayerSetDir(1, 22.0, false);
        giPlayerSetDir(3, 222.0, false);
        giIMMEnd();
        giCameraRunSingle("015", true);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：菱纱所言极是，硬闯琼华派乃是下策，以卵击石，于事无补。", "46209");
        giWait(0.3);
        giSetPortrait("101H", true);
        giTalk("云天河：那要怎么办？！难道就不管菱纱——", "46210");
        giWait(0.4);
        giIMMBegin();
        giPlayerSetAng(3, 242.0);
        giCameraRunSingle("016", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：唯今之计，我们不如先去清风涧寻两位长老，问问他们有无他法。", "46211");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101I", false);
        giTalk("云天河：我不去！他们根本就是帮着玄霄的！明明知道不可以用望舒剑，对菱纱不好，却一直瞒我们！到现在还会管菱纱的死活吗？说不定他们已经去琼华派找玄霄了！", "46212");
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……两位长老行事，或许亦有苦衷，他们十九年来愧疚难安，一心要助师叔破冰，所以才……", "46213");
        giSetPortrait("105C", true);
        giTalk("慕容紫英：假若长老真是心如铁石、是非不分，为何要传授菱纱心法，又将“红魄”交给菱纱，还在我们欲往幻瞑界时多番指点？", "46214");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：……那又怎样？对不起一个人，就可以为他做任何事，为他不顾别人的命吗？玄霄重要，菱纱就什么都不是？", "46215");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：…………", "46216");
        giWait(0.5);
        giCameraRunSingle("031", true);
        giWait(0.3);
        giPlayerDoAction(3, "J13", 1, true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……好！就算你心中忿忿难平，也该想想菱纱吧？", "46217");
        giWait(0.3);
        giSetPortrait("101H", false);
        giTalk("云天河：……！", "46218");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：姑且不论两位长老是否已去往琼华派，我只当去清风涧一试运气。", "46219");
        giWait(0.5);
        giCameraRunSingle("016", true);
        giWait(0.8);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：…………", "46220");
        giWait(0.8);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：你们……你们都别再说了……就这样，大家一起回青鸾峰不好吗？", "46221");
        giPlayerEndAction(1);
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerSetDir(0, 152.0, false);
        giPlayerSetDir(3, 204.0, false);
        giWait(0.2);
        giPlayerSetDir(1, 336.0, true);
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：天河，就像你讲的……在青阳长老、重光长老的心里，玄霄的份量远远胜过我，你气他们心有偏袒，一定要把人命分个孰重孰轻……", "46222");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：既然人命无贵贱，我一条命，你一条命，为什么还要去找玄霄……", "46223");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：你以为能活久一点，我一定会高兴吗？就算真的夺回了望舒剑，万一你和紫英有什么……我、我一辈子都不会开心的！", "46224");
        giWait(0.5);
        giPlayerSetDir(3, 236.0, false);
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：菱纱……", "46225");
        giWait(0.5);
        giPlayerWalkTo(1, 227.3661, 10.9185, -519.5344, true);
        giPlayerSetAng(1, 328.0);
        giPlayerDoAction(1, "J10", -1, false);
        giWait(1.0);
        giCameraRunSingle("017", false);
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：算我求你……不要让我这么难过好不好……", "46226");
        giWait(0.6);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：对不起……对不起…………", "46227");
        giPlayerEndAction(0);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……猪头……出了事就会说对不起，每次还不是让我担心个半死……", "46228");
        giCameraRunSingle("018", true);
        giWait(0.8);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("019", false);
        giPlayerWalkTo(1, 257.7593, 10.9185, -569.0717, true);
        giPlayerSetDir(3, 204.0, false);
        giPlayerDoAction(1, "J04", 1, true);
        giCameraWait();
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：……那个……走吧，<colour red=255 green=187 blue=0 alpha=255>我们去清风涧</colour><dc0>……</dc0>", "46229");
        giPlayerEndAction(0);
        giWait(0.3);
        giPlayerSetDir(1, 329.0, true);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：你？！", "46230");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：我不会就这样去找玄霄了，不过……还是得想办法救你。紫英说两位长老也许会有办法，不管怎样，都要去一趟清风涧！", "46231");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：算一下时日，琼华派应该还未以双剑做成剑柱。我们不要贸然行事，留存实力，此事未必没有转机。", "46232");
        giPlayerDoAction(1, "C08", 1, false);
        giWait(0.3);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：……嗯……但是太危险的事，千万别去做……", "46233");
        giPlayerEndAction(1);
        giSetPortrait("101E", false);
        giTalk("云天河：放心吧！都已经答应你了，我们又不去琼华派。", "46234");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：哼，不单是去找玄霄，其他危险的事也不许做！", "46235");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("101G", false);
        giTalk("云天河：好好好，都听你的就是……", "46236");
        giWait(0.3);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetObjectVisible("title01", true);
        giSetObjectVisible("title04", true);
        giSetObjectVisible("entrance1", false);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        global_mvar = 160200; // 0x000271C8, 第四章 / 9-3-2.君莫思归 / 再访长老 / 生离之痛
        giPlayerCurrentSetPos(223.5384, 10.9185, -509.0511);
        giPlayerCurrentSetAng(236.0);
        giCameraSetMode(0, true);
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
    if (global_mvar >= 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giRandTalkPush("昆珠：不知道为什么，已经很少有仙山上的人来了，日子越来越难过，很多人下定决心要离开了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("昆珠：如果不是仙山上的人帮忙送水，我们大概早就撑不下去了，谢谢……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("昆珠：怎么还有人会来我们月牙村？自从月牙河干涸之后，已经很久没有外人来了……");
        giRandTalkPush("昆珠：听说月牙河还没干涸的时候，村里也有人放牧，也有人种地，还经常有商队经过，现在却什么都没有了……");
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
    if (global_mvar >= 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giRandTalkPush("卓西姆：送水的人也不太来了……村子里越来越多的人离开，可是我还是舍不得月牙村啊……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("卓西姆：每天都有人会送水来，可是……天神什么时候才能原谅我们，让月牙河恢复原样呢……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("卓西姆：天神已经遗弃月牙村了……这都是天神降给我们的惩罚啊……");
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
    if (global_mvar >= 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giRandTalkPush("纳珠：鲁桑娜跟着萨西里一家走了，阿娘说，我们也要搬到其他地方去住，到底什么时候才能再见到鲁桑娜呢？");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("纳珠：天神的本事很大，天神让人给我们送水来～过不了多久，还能让水从地下涌出来！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("纳珠：纳珠好渴……");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("萨瓦桑：该走了……虽然现在有人送水和食物来，但河里没水，这里终究是住不下去的……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("萨瓦桑：该试的办法都试过了，还是没有水……月牙河的下面真的已经干了……");
        giRandTalkPush("萨瓦桑：我小时候曾经跟爹去过一个叫播仙镇的地方，那里真的是绿洲啊……天神眷顾他们，却遗弃了我们……");
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
    giCurrentPlayerFaceToNpc("4005", true);
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giNpcFaceToCurrentPlayer("4005", true);
        giRandTalkRelease();
        giRandTalkPush("鲁桑娜：萨西里说我们要去很远很远的地方，可是巴图爷爷不想跟我们一起，鲁桑娜不要离开巴图爷爷……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giNpcFaceToNpc("4006", "4005", true);
        giNpcFaceToNpc("4005", "4006", true);
        giTalk("鲁桑娜：萨西里，萨西里～我阿爷睡着了，为什么萨瓦桑叔叔要把他埋起来？", "");
        giTalk("萨西里：鲁桑娜，你阿爷不是睡着了，你阿爷是……他死了……", "");
        giTalk("鲁桑娜：什么意思……？鲁桑娜不懂……", "");
        giTalk("萨西里：……", "");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("萨西里：阿爹要带我穿过沙漠，去南边，但是他不肯带鲁桑娜一起走……我会照顾鲁桑娜的！不能丢下她！");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("萨西里：鲁桑娜的阿爷死了……我不知道该怎么和她说……");
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
    if (global_mvar >= 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giSetPortrait("215A", true);
        giTalk("巴图：仙山上是不是发生了什么事？送水的人也很少来了……还有……水灵珠……我们真的还要等下去吗？……", "");
        giSetPortrait("101E", true);
        giTalk("云天河：……对不起……", "");
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("巴图：感谢你们！每天都会送来水和食物，村里人的身体又慢慢好了起来。");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("巴图：只要有了水灵珠，一切都会好起来的……");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("乌娜：哥哥要带我离开这里了……他说只要穿过沙漠，以后日子会好的……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("乌娜：月牙弯弯，月光淡淡，这是老奶奶教我唱的，她说以前河里的水很清，有月亮的晚上，月光照在水面上，天上的月儿小小的，月牙村的月儿大大的……");
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
    if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkRelease();
        giRandTalkPush("格齐：其他人都说要穿过沙漠，去找绿洲，我也要带上妹妹跟他们走……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("格齐：巴图爷爷说昆仑山上住着天神，我、我想去找天神！让天神救救大家！……可是，留下我妹妹一个人怎么办……");
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
    if (global_mvar >= 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giRandTalkPush("应元勇：我早说过……靠剑仙也没用，这个村子已经没有希望了……我也打算离开了……");
        giRandTalk();
        giRandTalkRelease();
    }
    else if (global_mvar >= 90100 /* 第二章 / 5-3-3.三寒器 / 前往即墨 / 三件寒器 */)
    {
        giRandTalkPush("应元勇：山上来的人是剑仙吧……但是一直靠他们送水也没用，月牙河的水又不会再恢复了，这里迟早待不下去的……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkPush("应元勇：河干了、地干了，连房子都不能再住下去……");
        giRandTalkPush("应元勇：没有水怎么打铁……我就只剩下一些图谱了……");
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
    if (global_mvar >= 130100 /* 第三章 / 7-5-3.往事 / 不周山 */)
    {
        giRandTalkRelease();
        giRandTalkPush("依玛：……让我离开村子……我舍不得，反正年纪这么大了，又能活多久……我不会走的……");
        giRandTalk();
        giRandTalkRelease();
    }
    else
    {
        giRandTalkRelease();
        giRandTalkPush("依玛：多少年啦……这地方从还有牛羊变成现在的样子，谁的心不痛……");
        giRandTalk();
        giRandTalkRelease();
    }
    giNpcResetDir("4011");
    giNpcResumeBeh("4011");
    giPlayerUnLock();
}

void func5001()
{
    giPlayerLock();
    giNpcPauseBeh("5001");
    giNpcFaceToCurrentPlayer("5001", true);
    giCurrentPlayerFaceToNpc("5001", true);
    if (maze_var1 != 0)
    {
        if (maze_var1 != 1)
        {
            giStartTradeSystem("shop025", "");
        }
        else
        {
            if (giCheckPackProperty(3155, 1))
            {
                giTalk("李元勇：啊！是我的月长石！太好了！小兄弟你真是了不起！这回我终于没什么牵挂了，再过几天就离开这个荒村，不过铺子里还有些矿石，如果你有需要，我可以卖给你。", "");
                maze_var1 = 2;
                giDelProperty(3155, 1, true);
                giWait(2.0);
                gi2DSoundPlay("WA06", 1);
                giShowHint("开启新交易品", 0.5, 0.15);
                giWait(2.0);
            }
            giStartTradeSystem("shop025", "");
        }
    }
    else
    {
        giStartTradeSystem("shop025", "Buiness_Q07_5001");
    }
    giNpcResumeBeh("5001");
    giNpcResetDir("5001");
    giPlayerUnLock();
}

void func5006()
{
    giPlayerLock();
    giNpcPauseBeh("5006");
    giNpcFaceToCurrentPlayer("5006", true);
    giCurrentPlayerFaceToNpc("5006", true);
    giRandTalkRelease();
    giRandTalkPush("金·水滴好人：像孤魂妹妹那种带两把刀的坏人能在陈州住上下两层的大房子，像我这样的好人却要被流放沙漠头顶烈日，这年头，好人难当啊！");
    giRandTalkPush("金·水滴好人：本来只是在陈州街头迷了路，谁知半夜一阵歪风吹，等我醒来的时候就被埋在这个奇怪的地方了，难道这就是我“金·水滴好人”的宿命？");
    giRandTalkPush("金·水滴好人：年轻人，想知道最后的敌人是谁吗？不告诉你就不告诉你！我很坏，对吧！哇哈哈～～～");
    giRandTalkPush("金·水滴好人：年轻人，想知道为啥我的东西都卖一万元吗？唉～ 我也是被逼的……");
    giRandTalk();
    giRandTalkRelease();
    giStartTradeSystem("shop037", "");
    giNpcResetDir("5006");
    giNpcResumeBeh("5006");
    giPlayerUnLock();
}

void Buiness_Q07_5001()
{
    int quest_dialog_result = 0;

    giShowQuestDialog("很多年前，我外出采矿，不小心将一颗<colour red=255 green=187 blue=0 alpha=255>月长石</colour><dc0>掉入了月牙河。现在月牙河干了，我想在离开村子之前把那颗宝石找回来，但是月牙河谷却有妖怪出没……难道我真的找不回那颗宝石了吗？</dc0><br/><dc0>你愿意帮我去找找吗？</dc0>");
    quest_dialog_result = giGetQuestDialogResult();
    if (quest_dialog_result == 1)
    {
        maze_var1 = 1;
    }
}
