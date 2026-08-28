// Structured PAL4 reconstruction for M17.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M17_1_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar != 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void M17_2_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M17_3_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M17_4_init()
{
    giTimeScript(180.0, "func9001");
    giArenaReadyRestore();
}

void M17_5_init()
{
    bool yellow_ball01_visible = false;
    bool yellow_ball02_visible = false;
    bool yellow_ball03_visible = false;
    bool red_ball01_visible = false;
    bool red_ball02_visible = false;
    bool red_ball03_visible = false;
    bool blue_ball01_visible = false;
    bool blue_ball02_visible = false;
    bool blue_ball03_visible = false;
    bool mark01_visible = false;
    bool mark02_visible = false;
    bool mark03_visible = false;

    giTimeScript(180.0, "func9001");
    if (global_mvar >= 140100 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giSetObjectVisible("move4", false);
        giSetObjectVisible("move3", false);
        giSetObjectVisible("move1", false);
        giSetObjectVisible("move2", false);
        giSetObjectVisible("move8", false);
        giSetObjectVisible("JA02", false);
        giSetObjectVisible("JA01", false);
        giSetObjectVisible("move7", false);
        giSetObjectVisible("move5", false);
        giSetObjectVisible("move6", false);
        giSetObjectVisible("mark", false);
        giGOBSetPosition("MO002", -0.7, 448.4, -364.6);
    }
    yellow_ball01_visible = giGetVisibleObject("yellowBall01");
    yellow_ball02_visible = giGetVisibleObject("yellowBall02");
    yellow_ball03_visible = giGetVisibleObject("yellowBall03");
    red_ball01_visible = giGetVisibleObject("redBall01");
    red_ball02_visible = giGetVisibleObject("redBall02");
    red_ball03_visible = giGetVisibleObject("redBall03");
    blue_ball01_visible = giGetVisibleObject("blueBall01");
    blue_ball02_visible = giGetVisibleObject("blueBall02");
    blue_ball03_visible = giGetVisibleObject("blueBall03");
    mark01_visible = giGetVisibleObject("mark01");
    mark02_visible = giGetVisibleObject("mark02");
    mark03_visible = giGetVisibleObject("mark03");
    if (blue_ball01_visible && blue_ball02_visible && blue_ball03_visible && giGetVisibleObject("yellowBall01") && red_ball01_visible && red_ball02_visible && red_ball03_visible && yellow_ball02_visible && yellow_ball03_visible)
    {
        giSetObjectVisible("move4", false);
        giSetObjectVisible("move3", false);
        giSetObjectVisible("move1", false);
        giSetObjectVisible("move2", false);
        giSetObjectVisible("JA02", false);
        giSetObjectVisible("JA01", false);
        giSetObjectVisible("move7", false);
        giSetObjectVisible("move5", false);
        giSetObjectVisible("move6", false);
        giSetObjectVisible("move8", false);
    }
    if (mark01_visible && mark02_visible && mark03_visible)
    {
        giSetObjectVisible("mark", false);
    }
    if (global_mvar <= 131500 /* 第三章 / 8-3-2.心愿 / 入陵寻宝 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        giSetObjectVisible("MO001", false);
        giSetObjectVisible("effect010", false);
        giSetObjectVisible("effect009", false);
        giSetObjectVisible("effect008", false);
        giSetObjectVisible("effect007", false);
        giSetObjectVisible("effect011", false);
        giArenaReadyRestore();
    }
}

void EarthBall()
{
    int leader_player_id = 0;

    if (global_mvar >= 140100 || var_yan != 1 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.0, true, true);
        if (!giBGMConfigIsInArea("1"))
        {
            giArenaLoad("M17", "1", "", true);
        }
        giPlayerCurrentSetPos(5.0, -34.0, 5794.0);
        giPlayerCurrentSetAng(180.0);
        giCameraSetMode(5, true);
        giFlashInBlack(1.0, true);
        giArenaReady();
        giPlayerUnLock();
    }
    else
    {
        leader_player_id = giPlayerGetLeader();
        giShowHint("现在不可使用土灵珠", 0.5, 0.15);
    }
}

void func1001()
{
    giArenaLoad("M17", "2", "", true);
    giPlayerCurrentSetPos(9.2, 0.0, 796.4);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1002()
{
    giArenaLoad("M17", "1", "", true);
    giPlayerCurrentSetPos(-8.1, 271.1, -1452.7);
    giPlayerCurrentSetAng(2.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1003()
{
    giArenaLoad("M17", "3", "", true);
    giPlayerCurrentSetPos(565.1, 84.4, 802.4);
    giPlayerCurrentSetAng(216.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1004()
{
    giArenaLoad("M17", "2", "", true);
    giPlayerCurrentSetPos(-3.3, 0.0, -558.7);
    giPlayerCurrentSetAng(359.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1005()
{
    giArenaLoad("M17", "4", "", true);
    giPlayerCurrentSetPos(-1.4, 1.0, 857.4);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1006()
{
    giArenaLoad("M17", "3", "", true);
    giPlayerCurrentSetPos(-288.1, 444.5, 771.7);
    giPlayerCurrentSetAng(345.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1007()
{
    giArenaLoad("M17", "2", "", true);
    giPlayerCurrentSetPos(-3.3, 296.3, -1336.6);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1008()
{
    giArenaLoad("M17", "4", "", true);
    giPlayerCurrentSetPos(8.8, 1.0, -1469.6);
    giPlayerCurrentSetAng(1.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1009()
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
        giPlayerWalkTo(leader_player_id, 4.0, -34.0, 5876.0, true);
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

void func1010()
{
    giArenaLoad("M17", "5", "", true);
    giPlayerCurrentSetPos(-1.6, 0.2, 1165.5);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func1011()
{
    giArenaLoad("M17", "2", "", true);
    giPlayerCurrentSetPos(-2.4, 0.2, -2703.3);
    giPlayerCurrentSetAng(359.0);
    giCameraSetMode(5, true);
    giArenaReady();
}

void func2001()
{
    if (global_mvar == 131300 /* 第三章 / 8-3-1.心愿 / 前去封神陵 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -15.1, -34.0, 5500.6);
        giPlayerSetPos(1, 28.5, -34.0, 5453.5);
        giPlayerSetPos(3, -52.4, -34.0, 5484.3);
        giPlayerSetAng(0, 174.0);
        giPlayerSetAng(1, 184.0);
        giPlayerSetAng(3, 174.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giSetObjectVisible("save1", false);
        giMonsterSetHide("m17-01-01", false);
        giMonsterSetHide("m17-01-02", false);
        giSetObjectVisible("entrance1", false);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(2.0, false);
        giArenaReady();
        giCameraRunSingle("002", true);
        giWait(2.0);
        giCameraRunSingle("003", true);
        giWait(0.8);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：此地气氛异常肃穆，又悬浮于空中，似乎不可能是寻常墓穴……", "45236");
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：是啊，我有点紧张，这地方……很特别……", "45237");
        giWait(0.5);
        giPlayerSetDir(1, 330.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：原来你野人也有怕的时候～", "45238");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：不是怕……这地方有一种气，像是杀气，但又不是，我觉得怪怪的。", "45239");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giIMMBegin();
        giPlayerSetAng(0, 150.0);
        giPlayerSetAng(3, 132.0);
        giCameraRunSingle("004", false);
        giIMMEnd();
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：其实这儿是不是墓穴，我也不太清楚，也有人说，这是一个太古遗迹，似乎被什么东西守护着。", "45240");
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：太古遗迹？是否曾有神明居于此地？那我们贸然闯入，岂非大大的不敬？", "45241");
        giWait(0.5);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：何况于你阳寿，恐怕……", "45242");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：唔，紫英说的对，我们还是快点离开吧！", "45243");
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：什么“说的对”，你真懂紫英在说什么吗？就知道附和……", "45244");
        giWait(0.5);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：我不管……来都来了，我一定要进去拿一样东西，就一样而已！", "45245");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：不然我这辈子都会不甘心！", "45246");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：你究竟所为何物？", "45247");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.3);
        giPlayerDoAction(1, "C09", 1, true);
        giWait(0.5);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：……等找到你们就知道了。", "45248");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.8);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：我的曾祖父曾经来过这里，我不清楚他是用了什么法子，因为封神陵悬在半空，除了御剑还有其他办法可以靠近吗？……", "45249");
        giSetPortrait("103A", false);
        giTalk("韩菱纱：听说曾祖父他回到故乡之后，就变得沉默寡言，好像整个魂都已经不在身上了，有人说他疯了，也有人说他只是偶尔会神智不清……不过还是有族人从他的只字片语里，知道了这个地方，还有那件宝物……", "45250");
        giWait(0.6);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：……我……我怕我现在不来，再过个几年，就没机会来了。", "45251");
        giCameraRunSingle("007", true);
        giWait(0.8);
        giPlayerDoAction(3, "J13", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：人为财死、鸟为食亡。菱纱，听我一劝，此地凶多吉少，有什么宝物会比性命还重要？我们即刻离开才是上上之举——", "45252");
        giPlayerDoAction(0, "C08", 1, false);
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：对啊，你那个什么曾祖父，只是来了这里，就变得怪怪的，谁知道里面有什么东西！", "45253");
        giWait(0.5);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：你怕了？", "45254");
        giPlayerDoAction(0, "C09", 1, false);
        giWait(0.5);
        giSetPortrait("101H", true);
        giTalk("云天河：我才不怕！我是担心你，我们别进去了，马上走！", "45255");
        giWait(0.5);
        giPlayerDoAction(1, "J15", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：不要！我说过，来都来了，我不甘心！大不了我答应你们，真的遇到什么危险，我们马上逃就是了！", "45256");
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：你……", "45257");
        giWait(0.5);
        giPlayerDoAction(0, "J15", 1, false);
        giWait(1.5);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：走吧、走吧，别又一副臭脸。<colour red=255 green=187 blue=0 alpha=255>快点进去，找到那件宝物，</colour><dc0>不就可以速战速决了？</dc0>", "45258");
        giPlayerEndAction(1);
        giCameraRunSingle("008", true);
        giPlayerWalkTo(1, 76.1, -34.0, 5343.7, false);
        giWait(2.5);
        giPlayerDoAction(3, "C09", 1, true);
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, true);
        giWait(0.7);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giSetObjectVisible("save1", true);
        giMonsterSetHide("m17-01-01", true);
        giMonsterSetHide("m17-01-02", true);
        giSetObjectVisible("entrance1", true);
        giPlayerCurrentSetVisible(true);
        giIMMEnd();
        global_mvar = 131500; // 0x000201AC, 第三章 / 8-3-2.心愿 / 入陵寻宝
        giPlayerCurrentSetPos(-15.8, -34.0, 5482.7);
        giPlayerCurrentSetAng(174.0);
        giCameraSetMode(5, true);
        giFlushTailYAngle();
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 131500 /* 第三章 / 8-3-2.心愿 / 入陵寻宝 */)
    {
        giTimeScriptTerminate();
        giMonsterStopPursuit();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giIMMBegin();
        giHideGASkillObject();
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -47.7, 110.2, -755.6);
        giPlayerSetPos(1, -10.0, 110.2, -777.3);
        giPlayerSetPos(3, 41.0, 110.2, -779.0);
        giPlayerSetAng(0, 28.0);
        giPlayerSetAng(1, 10.0);
        giPlayerSetAng(3, 348.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giIMMEnd();
        giFlashInBlack(1.5, true);
        giWait(0.8);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：嘻嘻，果然找到了！", "45259");
        giWait(0.5);
        giCameraRunSingle("002", true);
        giPlayerDoAction(1, "C01", 1, false);
        giWait(1.0);
        giCameraRunSingle("003", false);
        giSetPortrait("105D", false);
        giTalk("慕容紫英：……！", "45260");
        giWait(0.5);
        giSetPortrait("101D", false);
        giTalk("云天河：这是……？！", "45261");
        giWait(1.2);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：怎么样？这把弓很漂亮吧？就算静静地在那里，都能感觉到一股好强的灵力！应该就是我曾祖父提过的神弓了！", "45262");
        giWait(1.5);
        giIMMBegin();
        giPlayerSetVisible(3, false);
        giCameraRunSingle("004", true);
        giIMMEnd();
        giScriptMusicPlay("P33", 2, 0.0, 0.0);
        giWait(0.8);
        giPlayerSetDir(1, 312.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：这把弓天河你拿着一定很帅～", "45263");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetEmotion(0, "101_jy");
        giCameraRunSingle("005", true);
        giWait(0.5);
        giPlayerSetDir(0, 135.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：啊？！……原来……原来你说要来这里取个东西，是为我？！", "45264");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetEmotion(0, "101_zc");
        giSetPortrait("103G", true);
        giTalk("韩菱纱：什、什么，谁为了你！少往自己脸上贴金！", "45265");
        giCameraRunSingle("006", false);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：我只不过觉得这次去妖界，一定会有大事发生，你拿着它，也算多一份力量，对我们几个都有好处！", "45266");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("101E", false);
        giTalk("云天河：是、是吗？", "45267");
        giWait(0.5);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：是啊…………", "45268");
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("103G", true);
        giTalk("韩菱纱：不过……你硬要说成是为了你，那我、我也没办法，谁让我们几个人里面，只有你是用弓的，哼，便宜你了。", "45269");
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 122.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("101E", true);
        giTalk("云天河：哦……", "45270");
        giWait(0.7);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：咦？！", "45271");
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "45272");
        giWait(0.5);
        giCameraRunSingle("008", false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：我没看错吧？野人也会眼眶湿润呀～", "45273");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "45274");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：在心里感动就好了，可别真的流下眼泪啊，男儿有泪不轻弹嘛……", "45275");
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101E", true);
        giTalk("云天河：哪有……哪有眼泪……你看错了……", "45276");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(1.0);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：你喜欢这个礼物，我就很开心了。", "45277");
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetEmotion(0, "101_bs");
        giPlayerSetPos(1, -21.9, 110.0, -770.3);
        giPlayerSetAng(1, 310.0);
        giPlayerSetAng(0, 130.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giWait(1.2);
        giSetPortrait("101E", false);
        giTalk("云天河：这把弓真的很不错，但是……", "45278");
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：什么……？", "45279");
        giWait(0.5);
        giCameraRunSingle("037", false);
        giSetPortrait("101G", false);
        giTalk("云天河：……早知道来这里是要拿弓，我死都不会让你来……", "45280");
        giWait(0.5);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：为什么？", "45281");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：世上再好的弓，也只是一把弓，根本不值得拿你的命来换，哪怕只是一个月、几天……都不值得……", "45282");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetEmotion(1, "103_bs");
        giWait(0.5);
        giPlayerSetDir(1, 160.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……你……要是真的这么想，就好好地用这把弓吧……", "45283");
        giWait(0.7);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：嗯，我会的……", "45284");
        giWait(0.6);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 310.0, true);
        giWait(0.5);
        giCameraRunSingle("010", false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：你答应我，永远把它带在身边，就算有一天你用不着了，也要带着……", "45285");
        giWait(0.3);
        giPlayerSetEmotion(1, "103_zc");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：好，我答应你！", "45286");
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：你总是说……我对你很好很好，其实那些都没什么……", "45287");
        giSetPortrait("103M", true);
        giTalk("韩菱纱：可是，有了这把弓……不管以后你和谁在一起，不管我是不是已经死了……你偶尔念着我对你的好，我就会很开心了……", "45288");
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.8);
        giSetPortrait("101E", false);
        giTalk("云天河：什么叫我“跟谁在一起”，那个“谁”又是谁啊？", "45289");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：哎，不管是谁啦，总之我跟你约定了。", "45290");
        giPlayerEndAction(1);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：（……你可以有资格去喜欢一个人，但我却不能……我的阳寿可能……我是没有资格去喜欢别人的……）", "45291");
        giSetPortrait("101H", false);
        giTalk("云天河：你别说这种话，你一定会活很久很久的，有我保护你，一定没关系的！", "45292");
        giWait(0.5);
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：嗯，傻瓜……", "45293");
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：我……", "45294");
        giPlayerEndAction(0);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetEmotion(0, "101_zc");
        giPlayerSetAng(3, 280.0);
        giPlayerSetVisible(3, true);
        giPlayerSetAng(1, 328.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：云、天、河。", "45295");
        giWait(0.3);
        giSetPortrait("101E", true);
        giTalk("云天河：啊？怎么？", "45296");
        giSetPortrait("103B", false);
        giTalk("韩菱纱：不管我还有多少时间，一定要记得我这个好朋友，好吗？", "45297");
        giWait(0.6);
        giSetPortrait("101G", true);
        giTalk("云天河：好朋友……我知道……我怎么可能忘记…………", "45298");
        giWait(0.5);
        giCameraRunSingle("012", true);
        giWait(0.6);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：…………", "45299");
        giWait(1.2);
        giPlayerFaceToPlayer(1, 3, true);
        giWait(0.8);
        giPlayerWalkTo(1, 5.9, 110.0, -772.3, true);
        giIMMBegin();
        giPlayerSetAng(1, 100.0);
        giPlayerSetAng(3, 274.0);
        giPlayerSetVisible(0, false);
        giCameraRunSingle("013", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("103M", false);
        giTalk("韩菱纱：……对不起哦，紫英，我都没有想到什么好东西，是你适用的……", "45300");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：适用的东西…………", "45301");
        giWait(0.5);
        giPlayerDoAction(3, "C09", 1, true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：不必……神兵利器，我并不稀罕，但你须记得自己的誓言，往后不可再因盗墓折去阳寿，这才是最重要的。", "45302");
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：今日之行我并不认同，但……如若取此弓会有任何报应，慕容紫英为朋友心甘情愿。", "45303");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：紫英，谢谢你……", "45304");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：快去将弓取下吧，然后速速离开此地，以免夜长梦多。", "45305");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：嗯！", "45306");
        giPlayerEndAction(1);
        giCameraRunSingle("014", false);
        giWait(2.3);
        giPlayerWalkTo(1, 1.8, 110.0, -702.0, false);
        giCameraWait();
        giWait(0.8);
        giPlayerSetDir(3, 358.0, true);
        giWait(0.8);
        giPlayerDoAction(3, "J15", -1, false);
        giWait(0.8);
        giSetObjectVisible("MO003", true);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：（……九龙缚丝剑穗…………菱纱……）", "45307");
        giWait(0.8);
        giSetObjectVisible("MO003", false);
        giWait(0.5);
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(2.3);
        giCameraRunSingle("015", true);
        giPlayerDoAction(1, "C07", -1, false);
        giWait(1.2);
        giIMMBegin();
        giSetObjectVisible("effect011", false);
        giSetObjectVisible("MO001", false);
        giIMMEnd();
        giWait(0.5);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetAng(0, 26.0);
        giPlayerSetAng(3, 344.0);
        giPlayerSetVisible(0, true);
        giCameraRunSingle("016", true);
        giIMMEnd();
        giSetObjectVisible("effect010", false);
        giWait(1.0);
        giSetObjectVisible("effect007", false);
        giWait(1.0);
        giCameraRunSingle("017", true);
        giSetObjectVisible("effect008", false);
        giWait(1.0);
        giSetObjectVisible("effect009", false);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(0, -40.3, 110.2, -759.2);
        giPlayerSetPos(3, 41.7, 110.2, -772.5);
        giCameraRunSingle("018", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerSetDir(1, 184.0, true);
        giWait(0.5);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：拿到了，走吧！", "45308");
        giWait(0.8);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P42", 2, 0.0, 2.5);
        giWait(0.5);
        giGOMTouch("Jeffect002");
        giTalk("？？：罪人！还不快将后羿射日弓放下！", "45309");
        giWait(0.5);
        giPlayerSetDir(1, 2.0, true);
        giSetPortrait("101H", false);
        giTalk("云天河：谁？！", "45310");
        giSetObjectVisible("Jeffect004", true);
        giNpcBlendIn("MN001", 1.0, true);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetDir(0, 10.0, false);
        giPlayerSetDir(3, 358.0, false);
        giPlayerSetPos(1, 0.4, 110.2, -772.1);
        giCameraRunSingle("019", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("B15A", true);
        giTalk("？？：吾乃神将句芒，镇守封神陵！", "45311");
        giWait(0.5);
        giCameraRunSingle("020", true);
        giWait(0.5);
        giSetPortrait("B15A", true);
        giTalk("句芒：凡间的罪人，你满是罪孽的双手不配执拿神器，放下！！", "45312");
        giWait(0.5);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：罪……人……是说我……？", "45313");
        giSetPortrait("B15A", true);
        giTalk("句芒：你身上的罪孽，连同你们一族的世代因果，本神将不会错认！", "45314");
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：……！！你怎么会知道……", "45315");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("B15A", true);
        giTalk("句芒：念你窃取神器并非利己私心，本神将饶你不死，也不夺你二魂六魄！速将后弈射日弓归位，即刻离开封神陵！", "45316");
        giWait(0.5);
        giCameraRunSingle("021", true);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：夺取二魂六魄？！难道菱纱的曾祖父……", "45317");
        giWait(0.5);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：可是，这把弓——", "45318");
        giSetPortrait("101H", false);
        giTalk("云天河：杀气！！", "45319");
        giSetPortrait("B15A", true);
        giTalk("句芒：告诫再三而执迷！本神将不会姑息！", "45320");
        giWait(0.5);
        giPlayerDoAction(0, "Z01", 0, false);
        giSetObjectVisible("Jeffect006", true);
        giSetPortrait("101H", false);
        giTalk("云天河：菱纱！小心！", "45321");
        giSetPortrait("B15A", true);
        giTalk("句芒：唔？！神龙之息！！", "45322");
        giSetPortrait("B15A", true);
        giTalk("句芒：你！衔烛之龙与你有何关系？", "45323");
        giWait(0.5);
        giSetPortrait("101H", false);
        giTalk("云天河：什么关系？简单的打架关系啊！", "45324");
        giNpcDoAction("MN001", "Z02", -1, false);
        giGOMTouch("Jeffect002");
        giSetPortrait("B15A", true);
        giTalk("句芒：大胆！竟敢在本神将面前胡言乱语！", "45325");
        giFlashOutBlack(1.5, true, true);
        giWait(2.0);
        giSetObjectVisible("Jeffect006", false);
        giIMMBegin();
        giAddPlayerFavor(0, 1, 30);
        giAddPlayerFavor(3, 1, 10);
        giSetFullHP();
        giSetFullMP();
        giNpcEndAction("MN001", true);
        giSetObjectVisible("Jeffect004", false);
        giIMMEnd();
        giAddCombatMonster(2593, 1);
        giAddCombatMonster(2564, 0);
        giAddCombatMonster(2564, 2);
        giConfigCombatBgm("P43");
        giConfigCombatCamera("CA7");
        giConfigCombatGroundCamera("CA12");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M17D");
        giScriptMusicPlay("P43", 2, 0.0, 0.0);
        giAddPlayerFavor(0, 1, -10);
        giPlayerLock();
        giIMMBegin();
        giPlayerSetPos(0, -41.5, 110.2, -742.6);
        giPlayerSetAng(0, 16.0);
        giPlayerSetAng(3, 268.0);
        giIMMEnd();
        giPlayerDoAction(1, "J19", -1, false);
        giPlayerDoAction(0, "Z01", 0, false);
        giWait(2.0);
        giCameraRunSingle("022", true);
        giFlashInBlack(1.0, true);
        giWait(0.5);
        giSetPortrait("103L", false);
        giTalk("韩菱纱：唔……", "45326");
        giPlayerDoAction(3, "J03", -1, false);
        giSetPortrait("105F", true);
        giTalk("慕容紫英：菱纱！你受伤了！", "45327");
        giWait(0.3);
        giNpcDoAction("MN001", "Z04", 1, true);
        giWait(0.5);
        giIMMBegin();
        giOBJBlendIn("MO001", 1.5, true);
        giSetObjectVisible("effect011", true);
        giIMMEnd();
        giWait(0.5);
        giCameraRunSingle("017", true);
        giSetObjectVisible("effect009", true);
        giWait(1.0);
        giSetObjectVisible("effect008", true);
        giWait(1.0);
        giCameraRunSingle("016", true);
        giSetObjectVisible("effect007", true);
        giWait(1.0);
        giSetObjectVisible("effect010", true);
        giWait(1.0);
        giCameraRunSingle("022", true);
        giWait(1.5);
        giSetPortrait("101I", false);
        giTalk("云天河：你！竟敢打伤菱纱……", "45328");
        giWait(0.3);
        giCameraRunSingle("023", false);
        giSetPortrait("B15A", true);
        giTalk("句芒：能与本神将战到此种地步，在凡人之中，亦属罕见！", "45329");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giPlayerSetDir(3, 356.0, true);
        giSetPortrait("B15A", true);
        giTalk("句芒：罪人！本神将不收你性命，因你一生所为，死后皆由鬼界而断！", "45330");
        giSetPortrait("B15A", true);
        giTalk("句芒：尔等速离封神陵！", "45331");
        giWait(0.8);
        giIMMBegin();
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giNpcSetAng("MN001", 192.0);
        giCameraRunSingle("024", true);
        giIMMEnd();
        giWait(1.2);
        giSetPortrait("101I", false);
        giTalk("云天河：等等！", "45332");
        giWait(0.5);
        giSetPortrait("101I", false);
        giTalk("云天河：可恶！这把弓要是不能拿，我们就不拿！但你干嘛要打伤她？！", "45333");
        giWait(0.5);
        giSetPortrait("B15A", true);
        giTalk("句芒：本神将不容罪人玷污神器！此乃天经地义！", "45334");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giCameraRunSingle("025", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("101I", false);
        giTalk("云天河：你，可恶！我——", "45335");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 314.0, true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：天河！不要……", "45336");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：千万不要为了我顶撞神将……是我不好，我太没用了……本以为这一次可以替你找到一把好弓……", "45337");
        giSetPortrait("101I", true);
        giTalk("云天河：什么破射日弓！我不要了！ ", "45338");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 8.0);
        giCameraRunSingle("026", true);
        giIMMEnd();
        giSetObjectVisible("Jeffect003", true);
        giWait(3.0);
        giSetPortrait("101I", false);
        giTalk("云天河：可他竟然把你打伤！！我真的、真的生气了！！", "45339");
        giSetPortrait("B15A", true);
        giTalk("句芒：唔？！", "45340");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：……别担心……我的伤其实还好，只不过最近总是很容易没力……", "45341");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.8);
        giNpcSetDir("MN001", 180.0, true);
        giWait(0.5);
        giSetPortrait("B15A", true);
        giTalk("句芒：罪人之手，不容玷污神器！心如明镜、三世澄澈之人，方有资格成为神器之主！", "45342");
        giWait(0.5);
        giPlayerSetDir(1, 0.0, true);
        giWait(0.5);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……心如明镜……三世澄澈……", "45343");
        giWait(0.5);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：那……那天河呢？天河能拿这把弓吗？！换他拿……是不是就没关系？", "45344");
        giWait(0.8);
        giNpcSetDir("MN001", 192.0, true);
        giWait(0.3);
        giCameraRunSingle("027", false);
        giSetPortrait("B15A", true);
        giTalk("句芒：一介凡人，为何身上竟有神龙之息！", "45345");
        giWait(0.3);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101I", false);
        giTalk("云天河：你说什么我听不懂！而且我现在很生气，就算听懂，也不想回答你！！", "45346");
        giPlayerEndAction(0);
        giWait(0.3);
        giPlayerSetDir(1, 316.0, true);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：天河……你别这样……", "45347");
        giSetPortrait("B15A", true);
        giTalk("句芒：凡人，你想成为后弈射日弓之主？", "45348");
        giWait(0.5);
        giSetPortrait("101I", false);
        giTalk("云天河：……", "45349");
        giWait(0.5);
        giSetPortrait("B15A", true);
        giTalk("句芒：凡人，回答本神将！", "45350");
        giWait(0.5);
        giPlayerSetEmotion(0, "101_zc");
        giPlayerSetEmotion(1, "101_wj");
        giIMMBegin();
        giPlayerSetAng(3, 304.0);
        giCameraRunSingle("028", true);
        giIMMEnd();
        giWait(2.0);
        giPlayerDoAction(0, "C09", 1, false);
        giWait(0.3);
        giSetPortrait("101I", true);
        giTalk("云天河：有什么稀罕的！我不——", "45351");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：天河！", "45352");
        giSetPortrait("101I", true);
        giTalk("云天河：…………", "45353");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你忘了？你答应过我什么？", "45354");
        giWait(0.5);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：我想要看你用这把弓的样子……不管以后会发生什么，你都永远把它带在身边……", "45355");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.5);
        giSetPortrait("101I", true);
        giTalk("云天河：…………", "45356");
        giWait(0.5);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：快、快点头啊！你要是说“不”，这一路过来的辛苦不都白费了？！", "45357");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("029", false);
        giWait(0.5);
        giSetPortrait("101C", true);
        giTalk("云天河：…………", "45358");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：天河！！", "45359");
        giWait(1.0);
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "45360");
        giSetObjectVisible("Jeffect003", false);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P36", 2, 0.0, 0.0);
        giCameraWait();
        giWait(3.5);
        giPlayerDoAction(0, "C08", 1, true);
        giWait(0.5);
        giSetPortrait("101J", true);
        giTalk("云天河：……我、想要这把弓！", "45361");
        giWait(0.8);
        giCameraRunSingle("030", true);
        giWait(0.8);
        giPlayerSetEmotion(1, "103_zc");
        giSetPortrait("B15A", true);
        giTalk("句芒：盘古有训，纵横六界，诸事皆有缘法！凡人仰观苍天，无明日月潜息、四时更替，幽冥之间，万物已循因缘，恒大者则为“天道”。", "45362");
        giWait(0.5);
        giSetPortrait("B15A", true);
        giTalk("句芒：今日始，后羿射日弓尊你为主，力量挥放多寡，决于主人！", "45363");
        giWait(0.5);
        giSetPortrait("101J", true);
        giTalk("云天河：……决于主人……？", "45364");
        giWait(0.5);
        giCameraRunSingle("031", false);
        giWait(1.5);
        giNpcDoAction("MN001", "Z04", 1, true);
        giWait(0.5);
        giIMMBegin();
        giOBJBlendOut("MO001", 1.5, true);
        giSetObjectVisible("effect011", false);
        giIMMEnd();
        giWait(0.5);
        giEffectPlayWithPlayer("HW_497_X01", 1, 0);
        giWait(2.5);
        giCameraRunSingle("016", true);
        giSetObjectVisible("effect010", false);
        giWait(1.0);
        giSetObjectVisible("effect007", false);
        giWait(1.0);
        giCameraRunSingle("017", true);
        giSetObjectVisible("effect008", false);
        giWait(1.0);
        giSetObjectVisible("effect009", false);
        giWait(1.0);
        giCameraRunSingle("032", false);
        giWait(1.3);
        giSetPortrait("B15A", true);
        giTalk("句芒：凡人，既然你不愿多说，本神将也不再追问，望你善用神器，好自为之！", "45365");
        giWait(0.7);
        giSetPortrait("B15A", true);
        giTalk("句芒：你若身死，神器将重返封神陵！", "45366");
        giSetObjectVisible("Jeffect005", true);
        giWait(0.5);
        giNpcBlendOut("MN001", 1.0, true);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetPos(0, -41.5, 110.2, -742.6);
        giPlayerSetAng(0, 356.0);
        giPlayerSetPos(1, 0.6, 110.2, -772.4);
        giPlayerSetAng(1, 314.0);
        giPlayerSetPos(3, 36.8, 110.2, -748.8);
        giPlayerSetAng(3, 274.0);
        giIMMEnd();
        giCameraRunSingle("033", true);
        giWait(0.6);
        giAddProperty(3115, 1, true);
        giWait(2.3);
        giPlayerAddSkill(0, 5506, true);
        giWait(2.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101J", false);
        giTalk("云天河：到底要我说什么？……而且为什么又有人说我死了以后会怎样怎样……我……", "45367");
        giPlayerEndAction(0);
        giPlayerWalkTo(1, -12.6, 110.2, -763.0, true);
        giWait(0.5);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：太好了，天河！", "45368");
        giWait(0.3);
        giPlayerSetDir(0, 128.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：想不到……会这样顺利，更想不到……你啊，居然还算是个大好人，不像我……哈哈……", "45369");
        giWait(0.3);
        giPlayerSetDir(3, 250.0, true);
        giWait(0.8);
        giSetPortrait("101H", false);
        giTalk("云天河：菱纱，那家伙乱讲的！你要是不高兴，我把弓扔掉好了！", "45370");
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：什么？！你敢！要是扔了，我跟你没完！", "45371");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：……", "45372");
        giWait(1.0);
        giPlayerSetDir(1, 78.0, true);
        giWait(0.8);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：……", "45373");
        giWait(1.0);
        giPlayerSetDir(1, 314.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：哎，你们！干嘛一副要死不活的样子？弓也拿到了，大家都没事，不是皆大欢喜？", "45374");
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("101G", false);
        giTalk("云天河：可是……", "45375");
        giWait(1.0);
        giCameraRunSingle("034", false);
        giPlayerWalkTo(1, -7.7, 110.2, -782.7, true);
        giWait(0.5);
        giPlayerSetDir(0, 142.0, false);
        giPlayerSetDir(3, 224.0, false);
        giPlayerDoAction(1, "J04", -1, true);
        giWait(0.5);
        giSetPortrait("103H", false);
        giTalk("韩菱纱：其实啊，你们根本不用替我难过，在鬼界听到伯父说那些话，我心里反而静下来了。", "45376");
        giSetPortrait("103H", false);
        giTalk("韩菱纱：就算不信命，我也相信这世上有因才有果……韩氏一族会落到今天这个地步，不怪别人……事到如今，让族里更小的孩子别再去盗墓，以后也不要有人去……我就安心了。", "45377");
        giWait(0.5);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：那你呢？你也不会再去了吧？！你说过这是最后一次的！", "45378");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 336.0, true);
        giWait(0.5);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：傻瓜，你担心什么？我可是向来言出必行！", "45379");
        giWait(0.3);
        giCameraRunSingle("035", true);
        giWait(0.8);
        giPlayerDoAction(3, "C07", -1, false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：不但不可再去盗墓，日后也应多做善事，累积功德，于你有益无害。", "45380");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giPlayerSetDir(1, 58.0, true);
        giWait(0.5);
        giPlayerDoAction(1, "C08", 1, true);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：知道～小紫英又在说教了！", "45381");
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerSetDir(1, 330.0, false);
        giCameraRunSingle("036", true);
        giWait(1.0);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：走啦，回琼华派去！我们刚才走过的地方，应该只是封神陵的冰山一角，这里还藏着许多秘密，要是太深入，可能就出不去了，早早回头为妙。", "45382");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "C08", 1, false);
        giWait(0.5);
        giSetPortrait("101J", false);
        giTalk("云天河：……好，<colour red=255 green=187 blue=0 alpha=255>一回到琼华派，我们就进妖界找梦璃！</colour>", "45383");
        giFlashOutBlack(1.5, true, true);
        giGOBMovment("MO002", 0.1, -0.7, 448.4, -364.6, true);
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giIMMEnd();
        global_mvar = 140100; // 0x00022344, 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵
        giPlayerCurrentSetPos(-41.5, 110.2, -742.6);
        giPlayerCurrentSetAng(354.0);
        giShowSignpost();
        giCameraSetMode(5, true);
        giScriptMusicStop(0, 2.5);
        giTimeScript(180.0, "func9001");
        giSetObjectVisible("Jeffect005", false);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func7001()
{
    bool yellow_ball01_visible = false;
    bool yellow_ball02_visible = false;
    bool yellow_ball03_visible = false;
    bool red_ball01_visible = false;
    bool red_ball02_visible = false;
    bool red_ball03_visible = false;
    bool blue_ball01_visible = false;
    bool blue_ball02_visible = false;
    bool blue_ball03_visible = false;
    bool mark01_visible = false;
    bool mark02_visible = false;
    bool mark03_visible = false;

    yellow_ball01_visible = giGetVisibleObject("yellowBall01");
    yellow_ball02_visible = giGetVisibleObject("yellowBall02");
    yellow_ball03_visible = giGetVisibleObject("yellowBall03");
    red_ball01_visible = giGetVisibleObject("redBall01");
    red_ball02_visible = giGetVisibleObject("redBall02");
    red_ball03_visible = giGetVisibleObject("redBall03");
    blue_ball01_visible = giGetVisibleObject("blueBall01");
    blue_ball02_visible = giGetVisibleObject("blueBall02");
    blue_ball03_visible = giGetVisibleObject("blueBall03");
    mark01_visible = giGetVisibleObject("mark01");
    mark02_visible = giGetVisibleObject("mark02");
    mark03_visible = giGetVisibleObject("mark03");
    if (!yellow_ball01_visible || !yellow_ball02_visible || !yellow_ball03_visible || giGetVisibleObject("mark01"))
    {
        if (!mark02_visible && !red_ball03_visible && red_ball01_visible && red_ball02_visible)
        {
            if (!mark03_visible && blue_ball01_visible && blue_ball02_visible && blue_ball03_visible)
            {
                giSetObjectVisible("mark03", true);
                giWait(0.5);
            }
        }
        else
        {
            giSetObjectVisible("mark02", true);
            giWait(0.5);
        }
    }
    else
    {
        giSetObjectVisible("mark01", true);
        giWait(0.5);
    }
    if (blue_ball01_visible && blue_ball02_visible && blue_ball03_visible && red_ball01_visible && red_ball02_visible && red_ball03_visible && yellow_ball01_visible && yellow_ball02_visible && yellow_ball03_visible)
    {
        giPlayerLock();
        giCameraSetCollide(false);
        giFlashOutBlack(1.0, true, true);
        giCameraPrepare("viewDispr");
        giCameraRunSingle("viewDispr_1", true);
        giFlashInBlack(1.0, true);
        giOBJBlendOut("move4", 0.5, false);
        giCameraRunSingle("viewDispr_2", false);
        giWait(1.5);
        giOBJBlendOut("move3", 0.5, false);
        giWait(0.5);
        giCameraRunSingle("viewDispr_3", false);
        giWait(1.5);
        giOBJBlendOut("move1", 0.5, false);
        giOBJBlendOut("move2", 0.5, false);
        giWait(0.5);
        giCameraRunSingle("viewDispr_4", false);
        giWait(0.8);
        giOBJBlendOut("move8", 0.5, false);
        giWait(0.4);
        giOBJBlendOut("JA02", 0.5, false);
        giWait(0.4);
        giOBJBlendOut("JA01", 0.5, false);
        giWait(0.4);
        giCameraRunSingle("viewDispr_5", false);
        giOBJBlendOut("move7", 0.5, false);
        giWait(1.6);
        giOBJBlendOut("move5", 0.5, false);
        giOBJBlendOut("move6", 0.5, false);
        giWait(0.6);
        giOBJBlendOut("mark", 1.0, true);
        giFlashOutBlack(1.0, true, true);
        giCameraPrepare("viewBow");
        giCameraRunSingle("viewBow_1", true);
        giFlashInBlack(1.0, true);
        giGOMTouch("MO002");
        giWait(12.0);
        giCameraRunSingle("viewBow_2", true);
        giFlashOutBlack(1.0, true, true);
        giCameraSetMode(5, true);
        giWait(1.0);
        giFlashInBlack(1.0, true);
        giPlayerUnLock();
    }
}

void func7002()
{
    if (global_mvar < 140100 && var_yan == 0 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giPlayerLock();
        var_yan = 1;
        giCameraSetCollide(false);
        giFlashOutBlack(1.0, true, true);
        giCameraPrepare("viewClose");
        giCameraRunSingle("viewClose", true);
        giFlashInBlack(1.0, true);
        giGOBMovment("MO002", 1.0, -0.7, 168.4, -364.6, false);
        giWait(0.93);
        giSetObjectVisible("quake", true);
        gi2DSoundPlay("we028", 1);
        giWait(2.5);
        giFlashOutBlack(1.0, true, true);
        giCameraSetMode(5, true);
        giWait(1.0);
        giSetObjectVisible("quake", false);
        giFlashInBlack(1.0, true);
        giPlayerUnLock();
    }
}

void func7003()
{
    float local_2 = 0.0;

    giPlayerLock();
    giCameraSetCollide(false);
    giGOBSetPosition("mark01", -821.1, 40.4, -183.7);
    giCameraPrepare("viewTest");
    giCameraRunSingle("viewTest", true);
    while (local_2 < 99.0)
    {
        giIMMBegin();
        giIMMEnd();
        giGOBMovment("mark01", 0.6, -821.1, 40.4, -183.7, true);
    }
    giCameraSetMode(5, true);
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
        local_3 = local_3 + 1;
    }
    giIMMEnd();
}
