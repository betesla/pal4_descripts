// Structured PAL4 reconstruction for M14.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M14_1_init()
{
    giTimeScript(180.0, "func9001");
    func2001();
    if (global_mvar < 100600)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetNpcVisible("MN001", false);
        giSetNpcVisible("MN002", false);
        giArenaReadyRestore();
    }
}

void M14_2_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar < 100800)
    {
        giNpcDoAction("MN001", "J01", -1, false);
        giArenaReadyRestore();
    }
    else if (global_mvar >= 101400)
    {
        giSetNpcVisible("MN001", false);
        giSetObjectVisible("effect001", false);
        giArenaReadyRestore();
    }
    else
    {
        if (global_mvar == 100800)
        {
            giScriptMusicPlay("P65", 2, 2.5, 2.5);
        }
        giIMMBegin();
        giNpcSetPos("MN001", -55.013, 76.9849, 102.6391);
        giSetNpcVisible("MN002", true);
        giNpcSetPos("MN002", -59.7988, 77.1719, 31.7965);
        giNpcSetAng("MN001", 259.0);
        giNpcSetAng("MN002", 299.0);
        giIMMEnd();
        giArenaReadyRestore();
    }
}

void M14_3_init()
{
    bool flag01_visible = false;
    bool flag02_visible = false;

    giTimeScript(180.0, "func9001");
    flag01_visible = giGetVisibleObject("flag01");
    flag02_visible = giGetVisibleObject("flag02");
    if (!flag02_visible || !giGetVisibleObject("flag01"))
    {
        giEventVolumeVisible("jump03", false);
    }
    if (global_mvar <= 100800)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("MO001", false);
        giArenaReadyRestore();
    }
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    if (!giBGMConfigIsInArea("1"))
    {
        giArenaLoad("M14", "1", "", true);
    }
    giPlayerCurrentSetPos(-743.0, -195.0, 2184.0);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    if (global_mvar != 100600)
    {
        if (global_mvar != 101100 /* 第二章 / 6-4-4.神农仆众 / 回月幽之境 */)
        {
            giArenaLoad("M14", "2", "", true);
            giPlayerCurrentSetPos(169.29933, 77.44493, 590.5619);
            giPlayerCurrentSetAng(181.0);
            giCameraSetMode(5, true);
            giArenaReady();
        }
        else
        {
            giArenaLoad("M14", "2", "", true);
            func2005();
        }
    }
    else
    {
        giFlashOutBlack(0.1, true, true);
        giArenaLoad("M14", "2", "", true);
        func2003();
    }
}

void func1002()
{
    giArenaLoad("M14", "1", "", true);
    giPlayerCurrentSetPos(563.7497, -734.4955, -3938.4878);
    giPlayerCurrentSetAng(357.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1003()
{
    int select_dialog_last_select = 0;
    int leader_player_id = 0;

    giMonsterStopPursuit();
    giPlayerLock();
    giSelectDialogAddItem("1.御剑飞行  ");
    giSelectDialogAddItem("2.什么都不做");
    giSelectDialogSetDefaultSelect(1);
    giShowSelectDialog("              准备<colour red=255 green=102 blue=0 alpha=255>御剑飞行</colour><dc0>吗？</dc0>");
    select_dialog_last_select = giSelectDialogGetLastSelect();
    if (select_dialog_last_select != 0)
    {
        leader_player_id = giPlayerGetLeader();
        giPlayerWalkTo(leader_player_id, -742.0, -193.0, 2295.0, true);
        giPlayerSetDir(leader_player_id, 180.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giPlayerUnLock();
    }
    else
    {
        giShowWorldMap();
    }
    giPlayerUnLock();
}

void func1004()
{
    giArenaLoad("M14", "3", "", true);
    giPlayerCurrentSetPos(306.76367, -279.66592, 1240.8668);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1005()
{
    if (global_mvar != 101100 /* 第二章 / 6-4-4.神农仆众 / 回月幽之境 */)
    {
        giArenaLoad("M14", "2", "", true);
        giPlayerCurrentSetPos(-522.13385, 77.4963, -248.01758);
        giPlayerCurrentSetAng(70.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
    else
    {
        giArenaLoad("M14", "2", "", true);
        func2005();
    }
}

void func2001()
{
    if (global_mvar == 100200 /* 第二章 / 6-3-4.义结金兰 / 炎帝神农洞 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giIMMBegin();
        giMonsterSetHide("m14-01-01", false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -694.1777, -198.445, 1994.7102);
        giPlayerSetAng(0, 300.0);
        giPlayerSetPos(1, -755.694, -198.8979, 2005.432);
        giPlayerSetAng(1, 45.0);
        giPlayerSetPos(2, -668.932, -197.4655, 2072.5923);
        giPlayerSetAng(2, 251.0);
        giPlayerSetPos(3, -780.6249, -198.6854, 2067.8882);
        giPlayerSetAng(3, 162.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("save1", false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giAddPlayerFavor(0, 1, -10);
        giAddPlayerFavor(0, 2, 10);
        giAddPlayerFavor(2, 1, 10);
        giAddPlayerFavor(3, 0, 10);
        giAddPlayerFavor(3, 1, 10);
        giAddPlayerFavor(3, 2, 10);
        giIMMEnd();
        giCameraRunSingle("002", false);
        giFlashInBlack(3.0, false);
        giArenaReady();
        giCameraWait();
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：传说炎帝神农洞是炎帝出生、植百草、驯百兽的地方，我也只知方位，从没进来过。", "43862");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……此地酷热的程度，未免太不寻常。", "43863");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, false);
        giPlayerSetDir(1, 342.0, true);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：会吗？我倒觉得这儿暖暖的。", "43864");
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……", "43865");
        giWait(0.30000001192092896);
        giPlayerSetDir(2, 215.0, true);
        giWait(0.4000000059604645);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107D", false);
        giTalk("柳梦璃：云公子，你也只是觉得暖暖的？", "43866");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giCameraWait();
        giIMMBegin();
        giPlayerSetPos(3, -749.2454, -198.2565, 2061.0684);
        giPlayerSetAng(1, 105.0);
        giPlayerSetAng(3, 123.0);
        giPlayerSetAng(0, 21.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("102A", false);
        giTalk("云天河：……一开始有点热，用了大哥教我的“凝冰诀”，就没什么了～", "43867");
        giSetPortrait("104J", true);
        giTalk("韩菱纱：说到这个，你和玄霄结拜的事，我跟梦璃都听说了。", "43868");
        giIMMBegin();
        giPlayerSetDir(0, 288.0, false);
        giPlayerSetDir(3, 165.0, false);
        giPlayerSetDir(2, 195.0, false);
        giCameraRunSingle("004", false);
        giIMMEnd();
        giWait(0.4000000059604645);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104J", true);
        giTalk("韩菱纱：某个人啊，运气就是好，能和那样厉害的人物称兄道弟～ ", "43869");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102M", false);
        giTalk("云天河：呵呵，大哥普通厉害而已啦！", "43870");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104J", true);
        giTalk("韩菱纱：还装！瞧你得意的。", "43871");
        giCameraRunSingle("005", true);
        giPlayerSetDir(2, 258.0, true);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：青阳长老……真的没弄错吗？这样炎热的地方，又怎会有至阴至寒之物？", "43872");
        giIMMBegin();
        giPlayerSetDir(3, 78.0, false);
        giPlayerSetDir(0, 322.0, false);
        giPlayerSetDir(1, 3.0, true);
        giIMMEnd();
        giWait(0.6000000238418579);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：长老绝不会说出无把握的事，<colour red=255 green=187 blue=0 alpha=255>我们边走边探查一番吧。</colour>", "43873");
        giWait(0.5);
        giPlayerDoAction(2, "C08", 1, true);
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giMonsterSetHide("m14-01-01", true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetObjectVisible("save1", true);
        global_mvar = 100400; // 0x00018830, 查探炎洞
        giIMMEnd();
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giPlayerCurrentSetVisible(true);
        giTimeScript(180.0, "func9001");
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2002()
{
    if (global_mvar == 100400 /* 查探炎洞 */)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giHideGASkillObject();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -1398.829, -203.1979, 1494.7268);
        giPlayerSetPos(1, -1398.829, -203.1979, 1494.7268);
        giPlayerSetPos(2, -1398.829, -203.1979, 1494.7268);
        giPlayerSetPos(3, -1398.829, -203.1979, 1494.7268);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("save1", false);
        giMonsterSetHide("m14-01-03", false);
        giMonsterSetHide("m14-01-04", false);
        giMonsterSetHide("m14-01-02", false);
        giIMMEnd();
        giNpcDoAction("MN001", "J01", -1, false);
        giCameraPrepare("MC002");
        giCameraRunSingle("003", true);
        giFlashInBlack(2.0, true);
        giIMMBegin();
        giNpcDoAction("MN002", "X01", 1, false);
        gi2DSoundPlay("WJ068", 1);
        giIMMEnd();
        giWait(1.9);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：妖孽，休得伤人！", "43874");
        giPlayerWalkTo(3, -1494.709, -202.2104, 1467.2098, false);
        giWait(0.5);
        giCameraRunSingle("002", false);
        giPlayerEndMove(3);
        giPlayerSetAng(3, 247.0);
        giIMMBegin();
        giPlayerDoAction(3, "T01", 1, false);
        giSetObjectVisible("Jeffect001", true);
        giIMMEnd();
        giWait(2.0);
        gi2DSoundPlay("WH004", 1);
        giSetObjectVisible("Jeffect002", true);
        giNpcBlendOut("MN002", 1.0, true);
        giPlayerEndAction(3);
        giWait(1.5);
        giPlayerWalkTo(3, -1646.6176, -199.9489, 1425.262, false);
        giPlayerWalkTo(2, -1628.6743, -202.5309, 1472.2544, false);
        giCameraRunSingle("004", false);
        giPlayerEndMove(3);
        giPlayerSetDir(3, 129.0, false);
        giPlayerWalkTo(1, -1537.8137, -203.2271, 1388.5023, false);
        giWait(0.4000000059604645);
        giPlayerWalkTo(0, -1565.5168, -202.8767, 1482.6049, false);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 143.0, true);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 247.0, true);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 190.0, true);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：咦？！是女孩子？", "43875");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "J12", 1, false);
        giEffectAttachToPlayer(2, "H_TL03.2", false);
        giWait(3.5);
        giEffectDetachFromPlayer(2);
        giEffectPlayWithNPC("H_086", 1, "MN001");
        giWait(3.5);
        giPlayerSetDir(0, 229.0, false);
        giPlayerSetDir(3, 60.0, false);
        giPlayerSetDir(1, 297.0, false);
        giWait(0.5);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：她没事吧？", "43876");
        giSetPortrait("107A", false);
        giTalk("柳梦璃：……这，似乎不是寻常昏迷，用我的香也无济于事……", "43877");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：怎么会呢？", "43878");
        giWait(0.30000001192092896);
        giPlayerSetDir(1, 265.0, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J03", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：我瞧瞧。", "43879");
        giWait(0.30000001192092896);
        giPlayerSetDir(0, 176.0, false);
        giPlayerSetDir(3, 116.0, false);
        giWait(1.7000000476837158);
        giSetPortrait("222A", false);
        giTalk("少女：嗯……", "43880");
        giSetPortrait("107A", false);
        giTalk("柳梦璃：啊，她醒了？", "43881");
        giSetPortrait("104A", true);
        giTalk("韩菱纱：你怎么样？有没有受伤？", "43882");
        giSetPortrait("222A", false);
        giTalk("少女：我……在哪里…………", "43883");
        giCameraRunSingle("005", true);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：我们来时见你昏倒在地，差点被妖物所害……", "43884");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giIMMBegin();
        giPlayerSetPos(1, -1534.7952, -203.2104, 1442.062);
        giPlayerSetAng(1, 201.0);
        giNpcSetPos("MN001", -1558.2925, -197.2271, 1380.5215);
        giNpcSetAng("MN001", 291.0);
        giIMMEnd();
        giCameraRunSingle("006", true);
        giWait(0.5);
        giSetPortrait("222A", false);
        giTalk("少女：啊！太危险了……", "43885");
        giSetPortrait("222A", false);
        giTalk("少女：一定是你们救了我吧？谢谢。", "43886");
        giCameraRunSingle("007", true);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……你一个女孩子，来这里做什么？", "43887");
        giSetPortrait("222A", true);
        giTalk("少女：……我叫楚碧痕，本就住在这炎帝神农洞中。", "43888");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102D", true);
        giTalk("云天河：你住这里？！那你知不知道有一件至阴至寒的东西？", "43889");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giNpcSetDir("MN001", 358.0, true);
        giSetPortrait("222A", false);
        giTalk("楚碧痕：……！", "43890");
        giSetPortrait("222A", false);
        giTalk("楚碧痕：你们是什么人？！要找那个做什么？", "43891");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：我们需要那样东西，乃是为了救人。姑娘能否相告？", "43892");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcSetDir("MN001", 277.0, true);
        giWait(0.5);
        giSetPortrait("222A", true);
        giTalk("楚碧痕：……实不相瞒，我和姐姐楚寒镜住在<colour red=255 green=187 blue=0 alpha=255>洞府中的“月幽之境”</colour><dc0>，那里没有熔岩，气候阴冷。</dc0>", "43893");
        giSetPortrait("222A", true);
        giTalk("楚碧痕：我们姐妹俩虽是半仙之体，却无法承受月幽之境外的酷热，更不是妖怪对手，我今日冒死跑出来，也是为了寻找一件很重要的东西……", "43894");
        giSetPortrait("222A", true);
        giTalk("楚碧痕：你们……能不能先把我送回去？我和姐姐或许有办法帮忙找到那至阴至寒之物……", "43895");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：当然啰！总不能把你丢在这里不管吧？", "43896");
        giNpcSetDir("MN001", 24.0, true);
        giWait(0.4000000059604645);
        giSetPortrait("222A", false);
        giTalk("楚碧痕：谢谢……", "43897");
        giSetPortrait("222A", false);
        giTalk("楚碧痕：还有……姐姐应该还在睡觉，请不要告诉她我偷跑出来的事。", "43898");
        giSetPortrait("104M", true);
        giTalk("韩菱纱：行啊。", "43899");
        giSetPortrait("222A", false);
        giTalk("楚碧痕：…………", "43900");
        giSetPortrait("104C", true);
        giTalk("韩菱纱：怎么了？", "43901");
        giSetPortrait("222A", false);
        giTalk("楚碧痕：你、能不能靠过来一点？你体质阴寒，我挨着，便不会觉得那么酷热难耐……", "43902");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：可以啊～我还以为是什么事呢。", "43903");
        giPlayerEndAction(1);
        giPlayerWalkTo(1, -1541.8102, -203.209, 1415.748, false);
        giFlashOutBlack(1.0, true, true);
        giPlayerEndMove(1);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giMonsterSetHide("m14-01-03", true);
        giMonsterSetHide("m14-01-04", true);
        giMonsterSetHide("m14-01-02", true);
        giSetObjectVisible("Jeffect001", false);
        giSetObjectVisible("Jeffect002", false);
        giSetNpcVisible("MN001", false);
        giShowSignpost();
        giSetObjectVisible("save1", true);
        giIMMEnd();
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 100600; // 0x000188F8
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2003()
{
    if (global_mvar == 100600)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giScriptMusicPlay("P65", 2, 2.5, 2.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance2", false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(1, 173.9154, 76.9168, 392.1468);
        giPlayerSetAng(1, 226.0);
        giPlayerSetPos(0, 211.2713, 77.4428, 441.4216);
        giPlayerSetAng(0, 226.0);
        giPlayerSetPos(2, 154.532, 77.3356, 457.1431);
        giPlayerSetAng(2, 226.0);
        giPlayerSetPos(3, 121.3595, 77.2285, 409.1794);
        giPlayerSetAng(3, 218.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("save1", false);
        giSetNpcVisible("MN002", true);
        giSetNpcVisible("MN001", true);
        giIMMEnd();
        giArenaReady();
        giNpcDoAction("MN001", "J01", -1, false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giCameraRunSingle("002", false);
        giWait(4.5);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：天吶，这里好冷……", "43904");
        giCameraWait();
        giWait(2.0);
        giCameraRunSingle("004", false);
        giNpcWalkTo("MN002", 102.0752, 81.059, 43.159, true);
        giNpcSetDir("MN002", 222.0, true);
        giSetPortrait("222A", false);
        giTalk("楚碧痕：姐姐，你醒醒！", "43905");
        giSetPortrait("221A", true);
        giTalk("楚寒镜：碧痕……", "43906");
        giSetPortrait("222A", false);
        giTalk("楚碧痕：姐姐，有人来了！", "43907");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giNpcSetDir("MN001", 14.0, false);
        giIMMBegin();
        giPlayerSetPos(0, 199.0666, 80.1126, 220.7897);
        giPlayerSetPos(1, 168.0428, 78.8594, 147.9242);
        giPlayerSetPos(3, 117.9792, 82.5635, 185.8717);
        giPlayerSetPos(2, 144.5944, 86.0059, 256.1876);
        giPlayerSetAng(0, 234.0);
        giPlayerSetAng(1, 247.0);
        giPlayerSetAng(3, 228.0);
        giPlayerSetAng(2, 216.0);
        giIMMEnd();
        giCameraWait();
        giCameraRunSingle("007", true);
        giSetPortrait("221B", true);
        giTalk("楚寒镜：怎会有生人在此？！", "43908");
        giSetPortrait("222A", false);
        giTalk("楚碧痕：姐姐，你别怕，他们、他们是要来找寻一件至阴至寒之物，想要救人……", "43909");
        giIMMBegin();
        giPlayerSetPos(0, 156.8716, 82.4918, 194.5096);
        giPlayerSetPos(1, 135.0633, 79.7695, 144.9208);
        giPlayerSetPos(3, 86.995, 79.8014, 164.9227);
        giPlayerSetPos(2, 92.4271, 86.0059, 215.5223);
        giPlayerSetAng(0, 234.0);
        giPlayerSetAng(1, 237.0);
        giPlayerSetAng(3, 211.0);
        giPlayerSetAng(2, 195.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：冒昧打扰，实不得已。姑娘若是知道，请不吝赐教！", "43910");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.6000000238418579);
        giIMMBegin();
        giNpcSetPos("MN001", 67.4769, 77.2493, 66.8524);
        giNpcSetPos("MN002", 108.179, 81.059, 65.8552);
        giNpcSetAng("MN001", 23.0);
        giNpcSetAng("MN002", 9.0);
        giIMMEnd();
        giCameraRunSingle("010", true);
        giPlayerSetVisible(3, false);
        giWait(0.800000011920929);
        giSetPortrait("221A", true);
        giTalk("楚寒镜：……", "43911");
        giNpcSetDir("MN001", 197.0, true);
        giWait(0.5);
        giSetPortrait("221A", true);
        giTalk("楚寒镜：你们回去，我无可奉告。", "43912");
        giCameraRunSingle("011", false);
        giNpcSetDir("MN002", 276.0, true);
        giSetPortrait("222B", false);
        giTalk("楚碧痕：姐姐！你不能这样！", "43913");
        giWait(0.30000001192092896);
        giSetPortrait("222B", false);
        giTalk("楚碧痕：这么多年来，只有这些人进到这个山洞，而且他们还身怀法力，错过这一次，又要等多久，才会有人帮我们去找炙炎石啊？！", "43914");
        giSetPortrait("221A", true);
        giTalk("楚寒镜：碧痕你……你还不死心吗？", "43915");
        giSetPortrait("222B", false);
        giTalk("楚碧痕：我不可能死心的，我连做梦都想要找到那块石头！", "43916");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(0, 144.1431, 82.7, 169.1954);
        giPlayerSetAng(0, 215.0);
        giPlayerSetPos(1, 150.3116, 85.1809, 138.9286);
        giPlayerSetAng(1, 233.0);
        giPlayerSetPos(2, 59.0262, 84.3778, 181.276);
        giPlayerSetAng(2, 190.0);
        giPlayerSetVisible(3, true);
        giPlayerSetAng(3, 190.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.699999988079071);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：二位姑娘若有为难之事，不妨说出来，看我们是否能帮得上忙。", "43917");
        giWait(0.30000001192092896);
        giNpcDoAction("MN001", "J02", 1, false);
        giSetPortrait("221B", true);
        giTalk("楚寒镜：你们回去！快走！", "43918");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", false);
        giSetPortrait("222B", true);
        giTalk("楚碧痕：姐姐！", "43919");
        giCameraRunSingle("003", true);
        giNpcSetDir("MN002", 352.0, true);
        giSetPortrait("222B", true);
        giTalk("楚碧痕：……我来说吧，你们要找的至阴至寒之物，十之八九便是这梭罗树上的梭罗果——", "43920");
        giSetPortrait("221B", true);
        giTalk("楚寒镜：碧痕！", "43921");
        giWait(0.4000000059604645);
        giSetPortrait("102C", false);
        giTalk("云天河：可这树上没有果子啊？", "43922");
        giWait(0.5);
        giSetPortrait("222A", true);
        giTalk("楚碧痕：我和姐姐正是这里的梭罗树仙。当初，主人为这颗树注入灵力，使我俩成为半仙之体，身中却只有幽寒之气。", "43923");
        giWait(0.30000001192092896);
        giSetPortrait("222A", true);
        giTalk("楚碧痕：……待我们成年之后，就能使用一种叫“炙炎石”的灵物进行身合，届时树顶结出果实，我们便会成为真正的地仙，从此不必再困守洞中。", "43924");
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giPlayerSetPos(0, 129.8947, 83.0258, 192.887);
        giPlayerSetAng(0, 207.0);
        giPlayerSetPos(1, 140.1631, 85.1809, 154.2377);
        giPlayerSetAng(1, 218.0);
        giPlayerSetPos(2, 59.0262, 84.3778, 181.276);
        giPlayerSetAng(2, 168.0);
        giPlayerSetAng(3, 177.0);
        giCameraRunSingle("012", true);
        giIMMEnd();
        giWait(0.6000000238418579);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：冒昧请问，你们的主人，又是哪位高人？", "43925");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giNpcSetDir("MN002", 32.0, true);
        giSetPortrait("222A", true);
        giTalk("楚碧痕：……主人是与伏羲、女娲并称“三皇”的神农。", "43926");
        giSetPortrait("105D", false);
        giTalk("慕容紫英：竟是神农？！那他现在何处？", "43927");
        giIMMBegin();
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", false);
        giNpcSetAng("MN001", 23.0);
        giCameraRunSingle("013", true);
        giIMMEnd();
        giCameraRunSingle("014", false);
        giWait(0.5);
        giSetPortrait("221C", false);
        giTalk("楚寒镜：……主人……可能已经不在世上了……", "43928");
        giSetPortrait("221C", false);
        giTalk("楚寒镜：那个时候，他正和另一位大神伏羲相争……有一次离开以后，就再也没有回来……", "43929");
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("221C", false);
        giTalk("楚寒镜：若不是落败身死，主人是不会丢下这里不管的，他的心那么善良，这儿的一草一木，他都十分爱惜……", "43930");
        giSetPortrait("104D", true);
        giTalk("韩菱纱：神农、伏羲、女娲……那些、那些都只是传说啊！如果是真的，你们在这究竟待了多少年？！", "43931");
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("221C", false);
        giTalk("楚寒镜：不知道，总之是很久很久……", "43932");
        giSetPortrait("221C", false);
        giTalk("楚寒镜：这个山洞渐渐地气候失衡，越来越炎热，成了怪物聚集的场所……", "43933");
        giSetPortrait("221A", false);
        giTalk("楚寒镜：起初，我们姐妹俩还不能维持人形很久，等到修炼千百年，终于可以了，外面却变得妖怪环伺，更是炎热无比……", "43934");
        giIMMBegin();
        giCameraRunSingle("015", true);
        giPlayerSetVisible(0, false);
        giSetNpcVisible("MN002", true);
        giNpcSetAng("MN002", 265.0);
        giNpcSetAng("MN001", 33.0);
        giIMMEnd();
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：不对啊，依我看这儿的风水，并非穷山恶水之相，怎么会聚集了这样多的怪物？", "43935");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetPos(0, 134.6265, 83.0258, 189.0847);
        giPlayerSetAng(0, 207.0);
        giPlayerSetVisible(0, true);
        giCameraRunSingle("017", true);
        giIMMEnd();
        giWait(0.5);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("221C", true);
        giTalk("楚寒镜：我不懂你的意思……不过主人在洞府内还豢养了许多兽类，这些兽最后都化成了妖……", "43936");
        giNpcEndAction("MN001", true);
        giNpcSetDir("MN002", 352.0, true);
        giSetPortrait("222A", true);
        giTalk("楚碧痕：求求你们，帮帮我和姐姐，在洞府里找到那块炙炎石好不好？", "43937");
        giNpcSetDir("MN001", 108.0, true);
        giWait(0.5);
        giNpcDoAction("MN001", "J02", 1, false);
        giSetPortrait("221A", false);
        giTalk("楚寒镜：碧痕！", "43938");
        giNpcSetDir("MN002", 265.0, true);
        giWait(0.30000001192092896);
        giSetPortrait("222A", true);
        giTalk("楚碧痕：姐姐，你告诉他们石头在哪里！主人只说给你听过！", "43939");
        giSetPortrait("221A", false);
        giTalk("楚寒镜：不可，洞中妖类潜伏，此行对凡人来说太过危险！", "43940");
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：你放心，我们不怕妖怪！", "43941");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.30000001192092896);
        giIMMBegin();
        giNpcSetAng("MN001", 217.0);
        giCameraRunSingle("016", true);
        giIMMEnd();
        giWait(0.6000000238418579);
        giSetPortrait("221A", true);
        giTalk("楚寒镜：我是不会答应的。", "43942");
        giWait(0.4000000059604645);
        giNpcDoAction("MN002", "J02", -1, false);
        giSetPortrait("222C", false);
        giTalk("楚碧痕：……呜……", "43943");
        giNpcSetDir("MN001", 75.0, true);
        giSetPortrait("221B", true);
        giTalk("楚寒镜：碧痕？你、你哭了？", "43944");
        giSetPortrait("222C", false);
        giTalk("楚碧痕：你永远只会说不可以、不可以！但你知道我有多痛苦吗？！", "43945");
        giSetPortrait("222C", false);
        giTalk("楚碧痕：我想去看看洞府外是什么样子，而不是永远守在这里，永远只能面对同一个人！", "43946");
        giSetPortrait("222C", false);
        giTalk("楚碧痕：姐姐你又是这么冷淡……月幽之境四面被熔岩所围，可我的心、我的心早就已经被冻成冰了！", "43947");
        giWait(0.699999988079071);
        giSetPortrait("221C", true);
        giTalk("楚寒镜：碧痕……", "43948");
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", false);
        giCameraRunSingle("017", true);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104H", false);
        giTalk("韩菱纱：这样……真的太可怜了……", "43949");
        giSetPortrait("104H", false);
        giTalk("韩菱纱：我们认识一个人，被关在某处十几年，已经够孤单的，何况是你们这样守了成百上千年……", "43950");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：姑娘，且让我等略尽绵薄之力吧。", "43951");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.699999988079071);
        giSetPortrait("221C", false);
        giTalk("楚寒镜：唉……碧痕，你可知用炙炎石身合并非万无一失？你主意已定，绝不后悔？", "43952");
        giSetPortrait("222A", true);
        giTalk("楚碧痕：姐姐，你答应了？！", "43953");
        giSetPortrait("222A", true);
        giTalk("楚碧痕：我、我早就想好了，就算是命赴黄泉，我也甘愿！好过这样永无止境地等下去！", "43954");
        giSetPortrait("221C", false);
        giTalk("楚寒镜：……", "43955");
        giWait(0.5);
        giNpcSetDir("MN001", 2.0, true);
        giWait(0.5);
        giSetPortrait("221D", true);
        giTalk("楚寒镜：……既然如此，就要烦请诸位去<colour red=255 green=187 blue=0 alpha=255>月幽之境西北的炙焰洞</colour><dc0>取那块</dc0><colour red=255 green=187 blue=0 alpha=255>炙炎石</colour><dc0>了，它会发出极大的热力，绝无可能认错。</dc0>", "43956");
        giNpcSetDir("MN002", 3.0, true);
        giPlayerDoAction(0, "C14", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：那……我们是不是不能带走梭罗果？", "43957");
        giWait(0.5);
        giSetPortrait("221D", true);
        giTalk("楚寒镜：不碍事，梭罗果只是一种依凭，若真成为仙身，反倒不重要了。", "43958");
        giWait(0.5);
        giSetPortrait("221C", true);
        giTalk("楚寒镜：……就送给你们，当作报答吧。", "43959");
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：哈哈，太好了！", "43960");
        giPlayerEndAction(0);
        giSetPortrait("102K", false);
        giTalk("云天河：看着吧，要不了多久，我们很快就会回来的！", "43961");
        giWait(1.2000000476837158);
        giPlayerWalkTo(2, -68.2236, 77.4384, 151.941, false);
        giPlayerWalkTo(3, -62.0394, 77.412, 131.4078, false);
        giPlayerWalkTo(0, -68.2236, 77.4384, 151.941, false);
        giPlayerWalkTo(1, -62.0394, 77.412, 131.4078, false);
        giWait(2.5);
        giNpcSetDir("MN001", 299.0, true);
        giNpcSetDir("MN002", 265.0, true);
        giWait(0.5);
        giCameraRunSingle("018", false);
        giSetPortrait("221C", true);
        giTalk("楚寒镜：……", "43962");
        giCameraWait();
        giSetPortrait("222A", true);
        giTalk("楚碧痕：姐姐～我们就要真正成仙了，你怎么一点都不高兴呢？", "43963");
        giNpcSetDir("MN001", 86.0, true);
        giWait(0.5);
        giSetPortrait("221C", false);
        giTalk("楚寒镜：傻丫头……", "43964");
        giWait(0.800000011920929);
        giSetPortrait("222A", true);
        giTalk("楚碧痕：（姐姐……我知道，我即将成仙，你自然会不高兴……）", "43965");
        giFlashOutBlack(1.5, true, true);
        giSetObjectVisible("save1", true);
        giArenaLoad("M14", "3", "", true);
        giPlayerCurrentSetPos(306.76367, -279.66592, 1240.8668);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(5, true);
        giArenaReady();
        global_mvar = 100800; // 0x000189C0
        giIMMEnd();
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2004()
{
    if (global_mvar == 100800)
    {
        giMonsterStopPursuit();
        giTimeScriptTerminate();
        giPlayerLock();
        giFlashOutBlack(0.5, true, true);
        giIMMBegin();
        giHideGASkillObject();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 424.4433, -279.6659, -1054.5842);
        giPlayerSetAng(0, 179.0);
        giPlayerSetPos(1, 368.7137, -279.7145, -1067.4941);
        giPlayerSetAng(1, 168.0);
        giPlayerSetPos(2, 470.4463, -279.7145, -1110.7815);
        giPlayerSetAng(2, 198.0);
        giPlayerSetPos(3, 303.6303, -279.7145, -1091.9783);
        giPlayerSetAng(3, 145.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giMonsterSetHide("m14-02-03", false);
        giMonsterSetHide("m14-02-04", false);
        giMonsterSetHide("m14-02-02", false);
        giMonsterSetHide("m14-02-01", false);
        giMonsterSetHide("m14-03-03", false);
        giMonsterSetHide("m14-03-04", false);
        giMonsterSetHide("m14-03-02", false);
        giMonsterSetHide("m14-03-01", false);
        giMonsterSetHide("m14-03-05", false);
        giCameraPrepare("MC001");
        giIMMEnd();
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, true);
        giCameraRunSingle("002", true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：这块晶石热力惊人，应该没错了……", "43966");
        giWait(0.5);
        giScriptMusicPlay("P46", 2, 0.0, 2.5);
        gi2DSoundPlay("WJ034", 1);
        giGOMTouch("Jeffect003");
        giTalk("？？：吼～～～", "43967");
        giWait(1.7000000476837158);
        giCameraRunSingle("004", true);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", true);
        giTalk("韩菱纱：啊？怎么了？", "43968");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("102H", true);
        giTalk("云天河：好强的杀气！！", "43969");
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：神农洞中妖物太多，我们快取晶石，免得夜长梦多！", "43970");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        gi2DSoundPlay("WJ034", 1);
        giGOMTouch("Jeffect003");
        giWait(2.0);
        giPlayerSetDir(2, 303.0, true);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：这晶石灼热异常，我们无法取走，云公子能否用凝冰诀试试？", "43971");
        giPlayerSetDir(0, 145.0, true);
        giWait(0.30000001192092896);
        giSetPortrait("102H", false);
        giTalk("云天河：好，我来！让我用凝冰诀把它冰起来，不然你们可要烫坏了！", "43972");
        giWait(0.4000000059604645);
        giPlayerWalkTo(0, 391.7119, -279.6659, -1162.906, false);
        giWait(1.5);
        giIMMBegin();
        giPlayerSetAng(2, 206.0);
        giPlayerSetAng(1, 148.0);
        giPlayerSetAng(3, 131.0);
        giCameraRunSingle("003", false);
        giIMMEnd();
        giPlayerEndMove(0);
        giPlayerSetDir(0, 135.0, true);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：云公子小心一点，我担心……", "43973");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        gi2DSoundPlay("WJ034", 1);
        giGOMTouch("Jeffect003");
        giWait(2.0);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：放心吧，大哥教的心法一定没问题，看我的！", "43974");
        giPlayerEndAction(0);
        gi2DSoundPlay("WJ034", 1);
        giGOMTouch("Jeffect003");
        giTalk("？？：谁、敢、擅、动！！", "43975");
        giWait(2.0);
        giIMMBegin();
        giCameraRunSingle("005", true);
        giPlayerSetDir(0, 12.0, false);
        giPlayerSetDir(1, 1.0, false);
        giPlayerSetDir(2, 19.0, false);
        giPlayerSetDir(3, 5.0, false);
        giIMMEnd();
        giSetPortrait("104F", true);
        giTalk("韩菱纱：什么人？", "43976");
        giGOMTouch("Jeffect003");
        giTalk("？？：吾乃熔岩兽王！", "43977");
        giWait(3.0);
        giIMMBegin();
        giPlayerSetPos(0, 461.5484, -279.6659, -948.1671);
        giPlayerSetPos(1, 411.6844, -279.6659, -1021.5067);
        giPlayerSetPos(2, 480.3381, -277.7506, -1023.0841);
        giPlayerSetPos(3, 399.5758, -279.6659, -922.8743);
        giPlayerSetAng(0, 313.0);
        giPlayerSetAng(1, 21.0);
        giPlayerSetAng(2, 338.0);
        giPlayerSetAng(3, 32.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giSetPortrait("107A", true);
        giTalk("柳梦璃：既然可以说话，应是通灵的妖兽了。", "43978");
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：我们取这炙炎石乃是为了助人，你能否通情割让？", "43979");
        giPlayerEndAction(0);
        gi2DSoundPlay("WJ034", 1);
        giSetObjectVisible("Jeffect004", true);
        giWait(1.0);
        giCameraRunSingle("007", false);
        giNpcBlendIn("MN001", 0.5, true);
        giNpcDoAction("MN001", "X02", 1, true);
        giGOMTouch("Jeffect003");
        giSetPortrait("B12A", true);
        giTalk("熔岩兽王：吾熔岩兽王只听神农大神命令，没必要给女娲的人类任何东西！", "43980");
        giWait(1.5);
        giSetPortrait("105F", false);
        giTalk("慕容紫英：和妖物根本毋须多言！更不必手下留情！", "43981");
        giIMMBegin();
        giPlayerDoAction(0, "Z01", 0, false);
        giPlayerDoAction(1, "Z01", 0, false);
        giPlayerDoAction(2, "Z01", 0, false);
        giPlayerDoAction(3, "Z01", 0, false);
        giIMMEnd();
        giSetPortrait("B12A", true);
        gi2DSoundPlay("WJ034", 1);
        giGOMTouch("Jeffect003");
        giTalk("熔岩兽王：无知凡人！看我将你们化为灰烬！", "43982");
        giNpcDoAction("MN001", "Z03", 1, false);
        giWait(1.5);
        giCameraRunSingle("009", false);
        giWait(2.0);
        giFlashOutBlack(1.5, true, true);
        giSetObjectVisible("Jeffect004", false);
        giSetFullHP();
        giSetFullMP();
        giAddCombatMonster(2590, 1);
        giConfigCombatBgm("P46");
        giConfigCombatCamera("CA8");
        giConfigCombatGroundCamera("CA14");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M14");
        giIMMBegin();
        giPlayerDoAction(0, "C01", 0, false);
        giPlayerDoAction(1, "C01", 0, false);
        giPlayerDoAction(2, "C01", 0, false);
        giPlayerDoAction(3, "C01", 0, false);
        giIMMEnd();
        giIMMBegin();
        giPlayerSetPos(0, 422.207, -279.6659, -1059.4913);
        giPlayerSetPos(1, 345.1239, -279.7145, -1050.4445);
        giPlayerSetPos(2, 435.8424, -279.7145, -981.0505);
        giPlayerSetPos(3, 338.1385, -279.7145, -986.6002);
        giPlayerSetAng(0, 305.0);
        giPlayerSetAng(1, 104.0);
        giPlayerSetAng(2, 208.0);
        giPlayerSetAng(3, 144.0);
        giIMMEnd();
        giSetNpcVisible("MN001", false);
        giCameraRunSingle("008", false);
        giFlashInBlack(1.5, true);
        giWait(0.30000001192092896);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102H", true);
        giTalk("云天河：呼～累死我……", "43983");
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：哈哈，这个什么兽王，算不算世上最强的野兽了？", "43984");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：哪里是野兽，分明是妖怪好不好……", "43985");
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：天河，你去将石头拿下，我们<colour red=255 green=187 blue=0 alpha=255>速速返回</colour><dc0>。</dc0>", "43986");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：此地妖孽实力甚强，我只怕夜长梦多……", "43987");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：好，看我的～", "43988");
        giPlayerEndAction(0);
        giCameraRunSingle("010", false);
        giPlayerWalkTo(0, 396.7018, -279.6659, -1166.6039, false);
        giWait(0.5);
        giPlayerSetDir(1, 154.0, false);
        giPlayerSetDir(2, 208.0, false);
        giPlayerSetDir(3, 174.0, false);
        giPlayerEndMove(0);
        giPlayerDoAction(0, "C07", -1, true);
        giIMMBegin();
        giSetObjectVisible("Jeffect002", true);
        giSetObjectVisible("Jeffect001", false);
        giIMMEnd();
        giWait(1.5);
        giIMMBegin();
        giSetObjectVisible("MO001", false);
        giSetObjectVisible("Jeffect002", false);
        giIMMEnd();
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giAddProperty(3117, 1, true);
        giWait(2.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giMonsterSetHide("m14-02-03", true);
        giMonsterSetHide("m14-02-04", true);
        giMonsterSetHide("m14-02-02", true);
        giMonsterSetHide("m14-02-01", true);
        giMonsterSetHide("m14-03-03", true);
        giMonsterSetHide("m14-03-04", true);
        giMonsterSetHide("m14-03-02", true);
        giMonsterSetHide("m14-03-01", true);
        giMonsterSetHide("m14-03-05", true);
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 101100; // 0x00018AEC, 第二章 / 6-4-4.神农仆众 / 回月幽之境
        giShowSignpost();
        giIMMEnd();
        giTimeScript(180.0, "func9001");
        giWait(0.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2005()
{
    if (global_mvar == 101100 /* 第二章 / 6-4-4.神农仆众 / 回月幽之境 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giScriptMusicPlay("P65", 2, 2.5, 0.0);
        giSetObjectVisible("entrance1", false);
        giSetObjectVisible("entrance2", false);
        giFlashOutBlack(0.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -139.2635, 76.3044, 48.6353);
        giPlayerSetAng(0, 93.0);
        giPlayerSetPos(1, -174.2057, 76.506, 103.288);
        giPlayerSetAng(1, 116.0);
        giPlayerSetPos(2, -229.5782, 76.8213, 154.559);
        giPlayerSetAng(2, 120.0);
        giPlayerSetPos(3, -240.2275, 76.7289, 37.5449);
        giPlayerSetAng(3, 83.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("save1", false);
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.0);
        giCameraRunSingle("006", false);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：看！是这个吧？", "43989");
        giIMMBegin();
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("Jeffect001", true);
        giIMMEnd();
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("221C", false);
        giTalk("楚寒镜：你们……竟然真的取到了……", "43990");
        giNpcDoAction("MN002", "C07", -1, false);
        giSetPortrait("222A", false);
        giTalk("楚碧痕：炙炎石……我终于得到了！", "43991");
        giWait(0.30000001192092896);
        giIMMBegin();
        giSetObjectVisible("MO002", false);
        giSetObjectVisible("Jeffect001", false);
        giIMMEnd();
        giDelProperty(3117, 1, false);
        giWait(0.5);
        giNpcUnHoldAct("MN002");
        giNpcEndAction("MN002", false);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：呀，等等！", "43992");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("222B", false);
        giTalk("楚碧痕：不能等了！", "43993");
        giNpcFaceToNpc("MN002", "MN001", true);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P32", 2, 2.5, 0.0);
        giSetPortrait("222B", true);
        giTalk("楚碧痕：姐姐，你真可怜……我就要成为真正的仙身了，而你注定要魂飞魄散，不过这也是没有办法的事情……", "43994");
        giCameraRunSingle("003", true);
        giPlayerDoAction(3, "C07", 1, false);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：你说什么？！", "43995");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giIMMBegin();
        giNpcSetAng("MN001", 193.0);
        giNpcSetAng("MN002", 3.0);
        giPlayerSetVisible(0, false);
        giIMMEnd();
        giCameraRunSingle("004", true);
        giCameraRunSingle("005", false);
        giWait(0.30000001192092896);
        giSetPortrait("221B", false);
        giTalk("楚寒镜：……", "43996");
        giSetPortrait("222B", true);
        giTalk("楚碧痕：哼，其实我早就知道了，梭罗树注入灵力之后，却出现了我姐妹二人，也大大出乎主人意料。", "43997");
        giSetPortrait("222B", true);
        giTalk("楚碧痕：你我既是一体，又非一体，而这梭罗树一生只结一个果实，所以我们之中一人成仙，另一人便要死去，对不对？！", "43998");
        giSetPortrait("221C", false);
        giTalk("楚寒镜：……", "43999");
        giWait(0.5);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：你……是否因为不能决定谁要成仙、谁要死去，一直很犹豫，所以才不愿说出石头的下落？", "44000");
        giWait(0.5);
        giSetPortrait("222B", true);
        giTalk("楚碧痕：姐姐！那些事情都是我听见主人和你说的，你却不肯告诉我！因为你不想我成仙是不是？！", "44001");
        giSetPortrait("222B", true);
        giTalk("楚碧痕：你越是不说，我越是痛苦，好几次偷跑出去，漫无目的地寻找，差点丢了性命！", "44002");
        giWait(0.5);
        giSetPortrait("221C", false);
        giTalk("楚寒镜：……你听见了主人和我说的话，便该知道，唯有善心才能令你身合成仙，若是怀着私念，只能让梭罗树结果，你却一样要魂飞魄散……", "44003");
        giWait(0.5);
        giIMMBegin();
        giSetNpcVisible("MN001", false);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giCameraRunSingle("008", false);
        giSetPortrait("222B", false);
        giTalk("楚碧痕：哈哈，姐姐，你到现在还想骗我？！", "44004");
        giSetPortrait("222B", false);
        giTalk("楚碧痕：你说我有私心吗？想要离开这个可怕的地方，算什么私心？！", "44005");
        giSetPortrait("222B", false);
        giTalk("楚碧痕：我自己的命要由自己决定！不管是主人还是你，都休想左右我！", "44006");
        giWait(0.5);
        giSetPortrait("222B", false);
        giTalk("楚碧痕：……永别了，姐姐！待我成仙之后，永远也会记得你的。", "44007");
        giFlashOutWhite(1.5, true, true);
        giIMMBegin();
        giPlayerSetPos(0, -120.1831, 76.4614, 32.7603);
        giPlayerSetPos(1, -160.9958, 76.6547, 91.9275);
        giPlayerSetPos(2, -180.2755, 76.8213, 40.2371);
        giPlayerSetPos(3, -125.1731, 76.7289, -4.3498);
        giPlayerSetAng(0, 48.0);
        giPlayerSetAng(1, 98.0);
        giPlayerSetAng(2, 78.0);
        giPlayerSetAng(3, 30.0);
        giPlayerSetVisible(0, true);
        giSetNpcVisible("MN001", true);
        giIMMEnd();
        giSetNpcVisible("MN002", false);
        giScriptMusicPause();
        giPlayMovie("10L.bik");
        giOpenMovieFlag(6);
        giScriptMusicResume();
        giScriptMusicPlay("P34", 2, 0.0, 2.5);
        giCameraRunSingle("010", true);
        giNpcDoAction("MN001", "J03", -1, true);
        giSetObjectVisible("MO001", true);
        giFlashInWhite(1.0, true);
        giSetPortrait("221C", true);
        giTalk("楚寒镜：碧痕——！！", "44008");
        giWait(0.5);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("107E", false);
        giTalk("柳梦璃：她…………", "44009");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("221C", true);
        giTalk("楚寒镜：碧痕，你怎么那么傻……我、我不能阻止你，不配当你的姐姐……", "44010");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：这……天啊……这到底……", "44011");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(3, false);
        giNpcSetAng("MN001", 242.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giCameraRunSingle("009", false);
        giWait(0.800000011920929);
        giSetPortrait("221C", true);
        giTalk("楚寒镜：…………你们知道我为何不肯说出炙炎石的所在？", "44012");
        giSetPortrait("107A", false);
        giTalk("柳梦璃：…………", "44013");
        giSetPortrait("221C", true);
        giTalk("楚寒镜：……那是因为在很久以前，我就知道碧痕有多痛恨我了，她把我当成一种威胁，想着万一成仙的不是自己，又该怎么办……", "44014");
        giSetPortrait("221C", true);
        giTalk("楚寒镜：我隐隐觉得，以她的心性，就算找到炙炎石身合，也不能成为仙身了……", "44015");
        giSetPortrait("221C", true);
        giTalk("楚寒镜：可是，我不能眼睁睁地看着她消散……我也不再想得到炙炎石了，我们二人相伴，虽然亘古寂寞，总好过我心中的那个结果……", "44016");
        giWait(1.2000000476837158);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(3, true);
        giPlayerSetAng(0, 29.0);
        giPlayerSetAng(3, 7.0);
        giPlayerSetAng(2, 75.0);
        giPlayerSetAng(1, 102.0);
        giCameraRunSingle("012", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107F", false);
        giTalk("柳梦璃：都是、都是我们害的……", "44017");
        giPlayerEndAction(2);
        giNpcDoAction("MN001", "C09", 1, false);
        giWait(0.5);
        giSetPortrait("221D", true);
        giTalk("楚寒镜：与你们无关。", "44018");
        giWait(0.5);
        giSetPortrait("221D", true);
        giTalk("楚寒镜：碧痕她今日又偷偷跑出去找炙炎石了对不对？或许就像她说的，只是需要一个了结，不在今日，也在明日……", "44019");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102E", true);
        giTalk("云天河：……她那样，算是死了吗？", "44020");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("221D", false);
        giTalk("楚寒镜：……生生死死，真的需要这么执着吗？", "44021");
        giSetPortrait("221D", false);
        giTalk("楚寒镜：我在这儿过了这么久，到如今连自己是死了还是活着，都早已分不清了……", "44022");
        giSetPortrait("102E", true);
        giTalk("云天河：……", "44023");
        giCameraWait();
        giWait(0.5);
        giCameraRunSingle("015", false);
        giSetObjectVisible("Jeffect002", true);
        giWait(4.0);
        giSetPortrait("221D", false);
        giTalk("楚寒镜：你们若是想要梭罗果，就把这个带走吧……", "44024");
        giWait(0.5);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：那你呢？", "44025");
        giWait(0.5);
        giSetPortrait("221D", false);
        giTalk("楚寒镜：我说过了，梭罗树一生只结一个果实，这是自然之理，即使碧痕没有成为真正的仙身，我却也要消散而亡了……", "44026");
        giWait(0.699999988079071);
        giIMMBegin();
        giSetObjectVisible("MO001", false);
        giSetObjectVisible("Jeffect002", false);
        giIMMEnd();
        giWait(0.699999988079071);
        giSetPortrait("104H", true);
        giTalk("韩菱纱：为什么会这样……", "44027");
        giCameraRunSingle("016", true);
        giSetPortrait("221D", false);
        giTalk("楚寒镜：你们不用觉得有愧……能够从漫长的时间里解脱出来，我很开心……我觉得自己死了以后，一定能……回到主人的身边……", "44028");
        giWait(0.699999988079071);
        giSetObjectVisible("Jeffect003", true);
        giNpcBlendOut("MN001", 2.0, true);
        giSetObjectVisible("Jeffect003", false);
        giWait(2.5);
        giSetObjectVisible("effect001", false);
        giWait(2.0999999046325684);
        giIMMBegin();
        giPlayerSetPos(0, -109.2719, 76.4614, 58.3985);
        giPlayerSetPos(1, -141.1095, 76.506, 114.6644);
        giPlayerSetPos(2, -189.2903, 76.8213, 83.3965);
        giPlayerSetPos(3, -163.6472, 76.7289, 34.4868);
        giPlayerSetAng(0, 346.0);
        giPlayerSetAng(1, 162.0);
        giPlayerSetAng(2, 64.0);
        giPlayerSetAng(3, 17.0);
        giCameraRunSingle("017", true);
        giIMMEnd();
        giWait(0.30000001192092896);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("104I", true);
        giTalk("韩菱纱：为什么？成仙不是一件好事吗？为什么这样残酷，一定要有人死呢？！", "44029");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：…………", "44030");
        giSetPortrait("104I", true);
        giTalk("韩菱纱：走！我们离开这里！回去、<colour red=255 green=187 blue=0 alpha=255>回琼华派</colour><dc0>去！我不想继续待着了！</dc0>", "44031");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102G", false);
        giTalk("云天河：……好，我们现在就走。", "44032");
        giWait(0.5);
        giAddProperty(3109, 1, true);
        giWait(2.0);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giSetObjectVisible("entrance1", true);
        giSetObjectVisible("entrance2", true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giSetObjectVisible("save1", true);
        giPlayerCurrentSetVisible(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 101400; // 0x00018C18, 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙
        giIMMEnd();
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2006()
{
    giPlayerLock();
    giNpcFaceToCurrentPlayer("MN001", true);
    giCurrentPlayerFaceToNpc("MN001", true);
    giSetPortrait("221C", false);
    giTalk("楚寒镜：你们……不必勉强，随时可以放弃……", "");
    giNpcSetDir("MN001", 259.0, true);
    giPlayerUnLock();
}

void func2007()
{
    giPlayerLock();
    giNpcFaceToCurrentPlayer("MN002", true);
    giCurrentPlayerFaceToNpc("MN002", true);
    giSetPortrait("222A", false);
    giTalk("楚碧痕：还没找到<colour red=255 green=187 blue=0 alpha=255>炙炎石</colour><dc0>吗？……</dc0>", "");
    giNpcSetDir("MN002", 299.0, true);
    giPlayerUnLock();
}

void func7001()
{
    giMSTBlendIn("m14-08-01", 1.0, true);
    giMSTBlendIn("m14-08-02", 1.0, true);
}

void func7002()
{
    bool flag01_visible = false;
    bool flag02_visible = false;

    flag01_visible = giGetVisibleObject("flag01");
    flag02_visible = giGetVisibleObject("flag02");
    if (flag02_visible && giGetVisibleObject("flag01"))
    {
        giEventVolumeVisible("jump03", true);
    }
    else
    {
        giEventVolumeVisible("jump03", false);
    }
}

void danger()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(1.5, true, true);
    giWait(0.5);
    giResetPlayerToJumpStart();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(1.5, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func9001()
{
    string local_1 = "";
    int local_3 = 0;
    bool item202_visible = false;
    string local_5 = "";

    local_1 = "item";
    giIMMBegin();
    while (local_3 <= 99)
    {
        local_1 = "item";
        if (local_3 >= 10)
        {
            local_1 = "item" + "20" + "2";
        }
        else
        {
            local_1 = "item" + "20";
        }
        local_5 = "item" + "20" + "2";
        item202_visible = giGetVisibleObject("item" + "20" + "2");
        if (!giGetVisibleObject(local_5))
        {
            local_5 = "item" + "20" + "2";
            giGOBReset("item" + "20" + "2");
            local_5 = "item" + "20" + "2";
            giSetObjectVisible("item" + "20" + "2", true);
        }
    }
    giIMMEnd();
}
