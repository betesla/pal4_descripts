// Structured PAL4 reconstruction for M20.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M20_1_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar >= 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        giSetNpcVisible("MM002", true);
        giSetNpcVisible("MM003", true);
        giSetNpcVisible("MM004", true);
        giMonsterSetHide("m20-01-01", false);
        giMonsterSetHide("m20-01-02", false);
        giMonsterSetHide("m20-02-01", false);
        giMonsterSetHide("m20-02-02", false);
        giMonsterSetHide("m20-02-03", false);
        giMonsterSetHide("m20-02-04", false);
    }
    if (global_mvar >= 120400 /* 第三章 / 7-4-2.仙妖乱 / 兄弟话别 */)
    {
        giSetObjectVisible("entrance2", false);
    }
    if (global_mvar == 91400 /* 第二章 / 6-3-2.义结金兰 / 离开禁地 / 结拜兄弟 */)
    {
        func2004();
    }
    if (global_mvar == 120300 /* 第三章 / 7-4-1.仙妖乱 / 离开禁地 */)
    {
        func2005();
    }
    giArenaReadyRestore();
}

void M20_1Y_init()
{
    giTimeScript(180.0, "func9001");
    if (global_mvar <= 71600 && global_mvar >= 71400 /* 前去禁地 */)
    {
        giSetObjectVisible("entrance2", false);
    }
    if (global_mvar != 71400 /* 第二章 / 5-1-1.寒剑夜鸣 / 前去禁地 */)
    {
        if (global_mvar != 71900 /* 第二章 / 5-1-3.寒剑夜鸣 / 进入山洞 */)
        {
            if (global_mvar == 72200 /* 第二章 / 5-1-4.寒剑夜鸣 / 离开禁地 */)
            {
                func2003();
            }
        }
        else
        {
            giSetObjectVisible("MO004", false);
            giSetObjectVisible("MO002", false);
            giSetObjectVisible("MO006", true);
        }
    }
    else
    {
        func2001();
    }
    giArenaReadyRestore();
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    giPlayerCurrentSetPos(767.5579, 5.223337, -462.87793);
    giPlayerCurrentSetAng(293.0);
    giCameraSetMode(5, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    if (global_mvar != 80800 /* 第二章 / 5-3-1.三寒器 / 寻访长老 */)
    {
        giArenaLoad("Q06", "Q06Q", "", true);
        giPlayerCurrentSetPos(15184.638, 128.21144, -3331.9087);
        giPlayerCurrentSetAng(160.0);
        giCameraSetMode(0, true);
        giArenaReady();
    }
    else
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giArenaLoad("Q06", "Q06Q", "", true);
    }
}

void func1002()
{
    if (global_mvar != 120400 /* 第三章 / 7-4-2.仙妖乱 / 兄弟话别 */)
    {
        if (global_mvar != 120501 /* 第三章 / 7-4-5.仙妖乱 / 追上卷云台 */)
        {
            if (global_mvar < 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
            {
                giPlayerLock();
                giIMMBegin();
                giGOMTouch("MO001");
                giGOMTouch("MO003");
                giIMMEnd();
                giWait(3.0);
                giArenaLoad("Q06", "Q06H", "", true);
                giPlayerCurrentSetPos(-69.58, 0.56, -952.33);
                giPlayerCurrentSetAng(255.0);
                giCameraSetMode(5, true);
                giArenaReady();
                giPlayerUnLock();
            }
        }
        else
        {
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerCurrentWalkTo(-223.5689, 3.8011, 1618.0342, true);
            giPlayerCurrentSetAng(164.0);
            giSetPortrait("101A", true);
            giTalk("云天河：现在还是不要进去了……", "");
            giCameraSetMode(5, true);
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerCurrentWalkTo(-223.5689, 3.8011, 1618.0342, true);
        giPlayerCurrentSetAng(164.0);
        giSetPortrait("102A", true);
        giTalk("云天河：现在还是不要进去了……", "");
        giCameraSetMode(5, true);
        giPlayerUnLock();
    }
}

void func1003()
{
    if (global_mvar != 71900 /* 第二章 / 5-1-3.寒剑夜鸣 / 进入山洞 */)
    {
        giPlayerLock();
        giIMMBegin();
        giGOMTouch("MO002");
        giGOMTouch("MO004");
        giIMMEnd();
        giWait(3.0);
        giArenaLoad("Q06", "Q06H", "", true);
        giPlayerCurrentSetPos(-69.58, 0.56, -952.33);
        giPlayerCurrentSetAng(255.0);
        giCameraSetMode(5, true);
        giArenaReady();
        giPlayerUnLock();
    }
    else
    {
        giArenaLoad("Q06", "Q06H", "", true);
        giPlayerCurrentSetPos(-69.58, 0.56, -952.33);
        giPlayerCurrentSetAng(255.0);
        giCameraSetMode(5, true);
        giArenaReady();
    }
}

void func1004()
{
    giArenaLoad("Q06", "Q06QY", "", true);
    giPlayerCurrentSetPos(15184.638, 128.21144, -3331.9087);
    giPlayerCurrentSetAng(160.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func2001()
{
    if (global_mvar == 71400 /* 第二章 / 5-1-1.寒剑夜鸣 / 前去禁地 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetObjectVisible("entrance1", false);
        giPlayerSetPos(0, 880.6423, 3.7867, -581.4664);
        giPlayerSetAng(0, 135.0);
        giPlayerSetPos(1, 880.6423, 3.7867, -581.4664);
        giPlayerSetAng(1, 163.0);
        giPlayerSetPos(2, 880.6423, 3.7867, -581.4664);
        giPlayerSetAng(2, 170.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giMonsterSetHide("m20-01-01", false);
        giMonsterSetHide("m20-01-02", false);
        giMonsterSetHide("m20-02-01", false);
        giMonsterSetHide("m20-02-02", false);
        giMonsterSetHide("m20-02-03", false);
        giMonsterSetHide("m20-02-04", false);
        giCameraPrepare("MC001");
        giIMMEnd();
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giPlayerWalkTo(0, 771.5801, 5.5756, -350.6233, false);
        giWait(1.0);
        giCameraRunSingle("002", false);
        giPlayerWalkTo(1, 764.0604, 4.96, -414.8063, false);
        giWait(1.0);
        giPlayerWalkTo(2, 824.7398, 5.6825, -426.8651, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 289.0, true);
        giPlayerEndMove(1);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 311.0, true);
        giPlayerDoAction(0, "J13", -1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：好大的剑～～", "43050");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", true);
        giTalk("韩菱纱：你们不觉得奇怪吗？紫英明明说过这个地方不能靠近，可是这么重要，居然连一个看守的人都没有。", "43051");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("003", true);
        gi2DSoundPlay("WJ031", 0);
        giPlayerDoAction(0, "J09", -1, false);
        giGOBAttachToPlayer("MO005", "H_080", 0, true);
        giSetPortrait("102D", true);
        giTalk("云天河：听！这把剑又发出声音了！", "43052");
        giPlayerSetDir(1, 1.0, false);
        giCameraRunSingle("004", true);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104A", true);
        giTalk("韩菱纱：看来找对地方了，先进去看看再说！", "43053");
        gi2DSoundStop();
        giGOBAttachToPlayer("MO005", "", 0, true);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giScriptMusicPlay("P56", 2, 0.0, 2.5);
        giSetPortrait("B01A", false);
        giTalk("魁召：主人有命，琼华派一般弟子不可通过此地！", "43054");
        giIMMBegin();
        giPlayerSetAng(0, 214.0);
        giPlayerSetAng(1, 277.0);
        giPlayerSetAng(2, 296.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.3);
        giEffectPlayWithNPC("H_082", 1, "MN001");
        giWait(0.2);
        giSetNpcVisible("MN001", true);
        giWait(0.5);
        giPlayerDoAction(0, "J02", -1, false);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("102D", true);
        giTalk("云天河：是石沉溪洞里那个怪物！长得一模一样！", "43055");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：不怕，反正这怪物害怕你的剑，快亮给他看，让他放我们过去！", "43056");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：好！", "43057");
        giPlayerEndAction(0);
        giCameraRunSingle("006", false);
        giPlayerWalkTo(0, 680.4572, 5.5756, -403.0565, true);
        giPlayerDoAction(0, "J09", -1, false);
        giSetPortrait("102M", true);
        giTalk("云天河：哈哈，你看这是什么！怕的话就快快消失！", "43058");
        giSetPortrait("B01A", false);
        giTalk("魁召：主人有命，擅闯者杀无赦！", "43059");
        giSetPortrait("102B", true);
        giTalk("云天河：等等！你是不是没看清楚啊？！你看你看！", "43060");
        giSetPortrait("B01A", false);
        giTalk("魁召：主人有命，擅闯者杀无赦！", "43061");
        giCameraWait();
        giIMMBegin();
        giPlayerSetPos(1, 703.6942, 5.0927, -359.5704);
        giPlayerSetPos(2, 738.4697, 5.4958, -400.6163);
        giPlayerSetAng(1, 228.0);
        giPlayerSetAng(2, 251.0);
        giIMMEnd();
        giPlayerDoAction(1, "Z01", 0, false);
        giPlayerDoAction(2, "Z01", 0, false);
        giCameraRunSingle("007", false);
        giSetPortrait("102D", true);
        giTalk("云天河：啊啊啊～你再仔细看看呀！喂——", "43062");
        giFlashOutBlack(1.5, true, true);
        giAddCombatMonster(2541, 1);
        giConfigCombatBgm("P39");
        giConfigCombatCamera("CA7");
        giConfigCombatGroundCamera("CA12");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M20B");
        giGOBDetachFromPlayer(0);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerEndAction(1);
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetAng(0, 262.0);
        giPlayerSetAng(1, 249.0);
        giPlayerSetAng(2, 270.0);
        giIMMEnd();
        giCameraRunSingle("008", false);
        giFlashInBlack(1.5, false);
        giNpcBlendOut("MN001", 2.5, true);
        giOBJBlendIn("MO001", 1.5, true);
        giWait(1.0);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：……看来就算长得一样，不同的符灵忌讳的东西也不同，他不怕天河的剑呢……", "43063");
        giPlayerSetDir(2, 314.0, true);
        giWait(0.3);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：……这些灵的气很强，可见驱符的是个高手，这么强的气，即便一时消失了，过一段时间又会生聚而成。", "43064");
        giPlayerEndAction(2);
        giIMMBegin();
        giPlayerSetAng(1, 154.0);
        giPlayerSetAng(0, 77.0);
        giCameraRunSingle("009", false);
        giIMMEnd();
        giWait(0.7);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：这就对了！所以这儿才没有其他人把守！", "43065");
        giPlayerSetDir(0, 18.0, true);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：嘻～害人家越来越想知道，禁地里到底有些什么。走，<colour red=255 green=187 blue=0 alpha=255>进去瞧瞧！</colour>", "43066");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giMonsterSetHide("m20-01-01", true);
        giMonsterSetHide("m20-01-02", true);
        giMonsterSetHide("m20-02-01", true);
        giMonsterSetHide("m20-02-02", true);
        giMonsterSetHide("m20-02-03", true);
        giMonsterSetHide("m20-02-04", true);
        giSetObjectVisible("MO001", false);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetAng(240.0);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giSetObjectVisible("entrance1", true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giIMMEnd();
        global_mvar = 71600; // 0x000117B0, 前去禁地
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2002()
{
    if (global_mvar == 71600 /* 前去禁地 */)
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
        giSetObjectVisible("entrance2", false);
        giPlayerSetPos(0, -157.3177, 8.7605, 1412.5925);
        giPlayerSetPos(1, -204.1355, 7.6893, 1396.9629);
        giPlayerSetPos(2, -124.6225, 13.1341, 1418.8865);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giMonsterSetHide("m20-01-01", false);
        giMonsterSetHide("m20-01-02", false);
        giMonsterSetHide("m20-02-01", false);
        giMonsterSetHide("m20-02-02", false);
        giMonsterSetHide("m20-02-03", false);
        giMonsterSetHide("m20-02-04", false);
        giSetObjectVisible("save1", false);
        giCameraPrepare("MC002");
        giIMMEnd();
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, false);
        giPlayerWalkTo(0, -212.6438, 3.7281, 1619.2354, false);
        giPlayerWalkTo(1, -255.5392, 3.3246, 1568.6418, false);
        giWait(0.3);
        giPlayerWalkTo(2, -195.4064, 3.2213, 1561.6721, false);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giPlayerEndMove(2);
        giSetPortrait("102B", false);
        giTalk("云天河：有扇门，我推开它！", "43067");
        giPlayerWalkTo(0, -237.7655, 6.7281, 1657.6403, false);
        giIMMBegin();
        giPlayerSetAng(1, 18.0);
        giPlayerSetAng(2, 318.0);
        giCameraRunSingle("002", true);
        giIMMEnd();
        giPlayerEndMove(0);
        giWait(0.5);
        giSetPortrait("107A", true);
        giTalk("柳梦璃：云公子，等一下……", "43068");
        giIMMBegin();
        giPlayerSetPos(0, -225.9678, 1.7281, 1661.3549);
        giPlayerSetPos(1, -262.0396, 6.4182, 1607.8925);
        giPlayerSetPos(2, -217.6665, 3.8799, 1609.7717);
        giPlayerSetAng(0, 345.0);
        giPlayerSetAng(1, 37.0);
        giPlayerSetAng(2, 18.0);
        giCameraRunSingle("003", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("107A", false);
        giTalk("柳梦璃：这门似乎是被法力所封，用寻常方法打不开的。", "43069");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：唔～法力……被梦璃一说，我倒觉得门上这个标志，像是对应什么东西，说不定就是开门的机关，可惜我们不知道是什么……", "43070");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：我明白了～", "43071");
        giPlayerEndAction(0);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：明白什么？", "43072");
        giSetPortrait("102K", false);
        giTalk("云天河：嘿嘿，试试看～", "43073");
        giWait(0.6);
        giIMMBegin();
        giSetObjectVisible("MO003", true);
        giSetObjectVisible("Jeffect001", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：咦？对啊，这块玉——", "43074");
        giIMMBegin();
        giGOBMovment("MO003", 6.0, -226.1676, 110.3379, 1721.1178, false);
        giGOBMovment("Jeffect001", 6.0, -226.1676, 44.3379, 1721.1178, false);
        giIMMEnd();
        giWait(6.0);
        giIMMBegin();
        giGOMTouch("MO002");
        giGOMTouch("MO004");
        giIMMEnd();
        giWait(6.0);
        giIMMBegin();
        giPlayerSetPos(1, -272.1712, 6.4182, 1626.7596);
        giPlayerSetAng(1, 45.0);
        giPlayerSetAng(2, 334.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(0, "J16", 1, false);
        giSetPortrait("102K", true);
        giTalk("云天河：哈哈，猜对了！上面的图案是一样的～", "43075");
        giSetPortrait("104B", true);
        giTalk("韩菱纱：瞧你得意的……不过你爹留下的玉，居然能打开琼华派禁地的大门，越想越不可思议……", "43076");
        giPlayerSetDir(0, 234.0, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102K", false);
        giTalk("云天河：呵呵，一定是爹在保佑我，让我来这里～", "43077");
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：<colour red=255 green=187 blue=0 alpha=255>进去看看吧，</colour><dc0>或许真是云叔保佑，冥冥之中自有天意……</dc0>", "43078");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giSetObjectVisible("save1", true);
        giSetObjectVisible("MO003", false);
        giSetObjectVisible("Jeffect001", false);
        global_mvar = 71900; // 0x000118DC, 第二章 / 5-1-3.寒剑夜鸣 / 进入山洞
        giTimeScript(180.0, "func9001");
        giArenaLoad("Q06", "Q06H", "", true);
        giPlayerCurrentSetPos(-93.88, 0.56, -931.14);
        giPlayerCurrentSetAng(249.0);
        giCameraSetMode(5, true);
        giArenaReady();
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2003()
{
    if (global_mvar == 72200 /* 第二章 / 5-1-4.寒剑夜鸣 / 离开禁地 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giScriptMusicPlay("P03", 2, 0.0, 0.0);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -253.6433, 8.7281, 1644.359);
        giPlayerSetAng(0, 195.0);
        giPlayerSetPos(1, -270.1565, 6.4182, 1575.9983);
        giPlayerSetAng(1, 218.0);
        giPlayerSetPos(2, -303.9831, 7.6603, 1629.8656);
        giPlayerSetAng(2, 143.0);
        giPlayerSetPos(3, -207.2345, 7.7975, 1532.706);
        giPlayerSetAng(3, 293.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giPlayerSetVisible(3, true);
        giMonsterSetHide("m20-01-01", false);
        giMonsterSetHide("m20-01-02", false);
        giMonsterSetHide("m20-02-01", false);
        giMonsterSetHide("m20-02-02", false);
        giMonsterSetHide("m20-02-03", false);
        giMonsterSetHide("m20-02-04", false);
        giSetObjectVisible("entrance2", false);
        giSetObjectVisible("MO002", false);
        giSetObjectVisible("MO004", false);
        giSetObjectVisible("MO006", true);
        giSetObjectVisible("save1", false);
        giCameraPrepare("MC003");
        giIMMEnd();
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104C", false);
        giTalk("韩菱纱：那个人……真的太奇怪了，怎么会被封在冰里呢？", "43170");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("107F", false);
        giTalk("柳梦璃：他……也许是个很可怜的人，我还从来没有感觉过一个人的灵，像那样孤单、寂寥，简直像要把身边所有的一切都冰结了，实在太痛苦了……", "43171");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：那，我们以后过来多陪陪他不就好了？", "43172");
        giWait(0.5);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：师叔之事，我们做后辈的，不必妄加猜测！", "43173");
        giSetPortrait("105C", true);
        giTalk("慕容紫英：倒是你们几个，究竟如何打开禁地石门的？", "43174");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(0, 134.0);
        giPlayerSetPos(0, -233.8368, 3.3841, 1675.5985);
        giPlayerSetPos(3, -159.281, 7.7975, 1623.4286);
        giPlayerSetAng(3, 316.0);
        giCameraRunSingle("006", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(0, "C07", -1, false);
        giWait(0.8);
        giSetObjectVisible("MO007", true);
        giSetPortrait("102B", false);
        giTalk("云天河：很简单啊，用这块玉就打开了～", "43175");
        giWait(0.4);
        giSetObjectVisible("MO007", false);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.3);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……！这玉哪里来的？", "43176");
        giWait(0.5);
        giPlayerSetDir(0, 134.0, true);
        giWait(0.3);
        giSetPortrait("102B", false);
        giTalk("云天河：是在我爹和我娘的墓室里找到的，就一直带身边了……", "43177");
        giWait(0.5);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……", "443178");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetPos(1, -237.2653, 6.4182, 1587.9967);
        giPlayerSetAng(1, 88.0);
        giPlayerSetPos(2, -276.9182, 4.1485, 1648.5927);
        giPlayerSetAng(2, 111.0);
        giPlayerSetAng(3, 258.0);
        giPlayerSetAng(0, 129.0);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("104J", false);
        giTalk("韩菱纱：紫英，你之前说没听过云天青这个人，铁定是骗人的吧？", "43179");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104J", false);
        giTalk("韩菱纱：玄霄明明说了～天河的爹娘都做过琼华派的弟子。", "43180");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：我确实不知，何必欺瞒。", "43181");
        giSetPortrait("104J", false);
        giTalk("韩菱纱：干嘛一脸严肃，你、你可别想阳奉阴违，处罚我们哦。", "43182");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：我已答应师叔不再追究，自会做到。", "43183");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：时候不早了，你们几个回房去吧。", "43184");
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P24", 2, 2.5, 2.5);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("104D", false);
        giTalk("韩菱纱：啊，险些忘了！还要送水给月牙村的人！怎么办，天都快亮了！", "43185");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……不必去了。", "43186");
        giSetPortrait("104C", false);
        giTalk("韩菱纱：为什么？水灵珠又没拿到！", "43187");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102J", false);
        giTalk("云天河：对，我也要去！", "43188");
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetPos(3, -156.5614, 7.7975, 1596.6694);
        giPlayerSetAng(3, 257.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giSetPortrait("105A", true);
        giTalk("慕容紫英：不必。我已命弟子每日送足够的水和食物给村民。", "43189");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：村长留恋故土，不愿离去，但掌门又是心意已决，或许……妖界之事过后，她会愿意借出水灵珠……如今也只能静观其变，你们不要莽撞行事。", "43190");
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：咦咦咦？小紫英～你是个大好人嘛，想得比我们周全，那你刚才怎么不讲清楚，让别人误会～", "43191");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：我只做应做之事，无须向任何人解释。", "43192");
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：也对，有些事只管做就好了，干嘛要说那么多？", "43193");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：受不了……男孩子就是粗枝大叶的，对吧，梦璃？", "43194");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("107B", false);
        giTalk("柳梦璃：嗯，我觉得这样也不错啊。", "43195");
        giWait(1.0);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：不必在此多话，通通回房去歇下。", "43196");
        giPlayerSetDir(3, 105.0, true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：先等一下～", "43197");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerWalkTo(1, -203.2497, 6.4182, 1602.5831, true);
        giPlayerSetAng(1, 100.0);
        giWait(0.5);
        giPlayerSetDir(3, 274.0, true);
        giIMMBegin();
        giPlayerSetAng(1, 102.0);
        giPlayerSetVisible(0, false);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giWait(0.3);
        giSetPortrait("104M", true);
        giTalk("韩菱纱：听其他弟子说，紫英你喜欢宝剑，还有和宝剑相关的东西，这玩意我一直带在身边，用不上也可惜了，不如送给你吧～", "43198");
        giPlayerDoAction(1, "C07", -1, false);
        giWait(0.8);
        giSetObjectVisible("MO008", true);
        giWait(0.4);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：……九龙缚丝剑穗？！", "43199");
        giWait(0.5);
        giSetObjectVisible("MO008", false);
        giWait(0.5);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.4);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：哇，你果然识货！这确实是选了万年冰蚕丝，再用“九龙缚丝”的特殊手法结成的剑穗，虽然看起来不是珠玉在外，但绝对是个好东西。", "43200");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：……如此贵重之物，唯有皇族方能持有，你如何得来？", "43201");
        giCameraRunSingle("010", false);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("104B", true);
        giTalk("韩菱纱：别管那些有的没的，你拿着就是。", "43202");
        giSetPortrait("104M", true);
        giTalk("韩菱纱：人说拜师有大礼，才显得诚心，你怎么说也是师叔，我们还没送过你什么东西呢！", "43203");
        giPlayerDoAction(3, "J13", 1, false);
        giWait(0.1);
        giSetPortrait("105C", false);
        giTalk("慕容紫英：琼华派乃是修仙清静之地，何来此等世俗规矩？", "43204");
        giSetPortrait("105C", false);
        giTalk("慕容紫英：何况此物贵重，我不能收。", "43205");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("104E", true);
        giTalk("韩菱纱：唉……就知道你是一板一眼的人……俗话说宝剑配英雄，香花赠美人，你拿着不是刚刚好？", "43206");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetAng(3, 268.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giCameraRunSingle("012", false);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105C", true);
        giTalk("慕容紫英：不必多言，我已说过不收。", "43207");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104A", false);
        giTalk("韩菱纱：好嘛……那你就当帮这剑穗找到原本相配的宝剑好了，我得到它的时候，只有剑穗，剑早就不知所踪了，要是能物归原处，也算一件功德吧？", "43208");
        giSetPortrait("104A", false);
        giTalk("韩菱纱：我听说琼华派藏剑上千，说不定其中就有那把剑呢。", "43209");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：…………若是如此，我暂且替你保管，看看能不能找到原本的那支剑……", "43210");
        giPlayerDoAction(1, "J16", 1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：嘻嘻，太好了！", "43211");
        giSetPortrait("105A", true);
        giTalk("慕容紫英：……你既然能寻到剑穗，也算与它有缘。找到原本的配剑之后，若是掌门允许，我自会一同交付给你。", "43212");
        giPlayerDoAction(1, "C09", 1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：给我？不用、不用，你尽管留着！", "43213");
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……好了，<colour red=255 green=187 blue=0 alpha=255>通通回房去，</colour><dc0>若是错过明日早课，我定不轻饶！</dc0>", "43214");
        giPlayerWalkTo(3, -29.4236, 16.2351, 1509.4609, false);
        giWait(2.5);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("104E", false);
        giTalk("韩菱纱：哼，凶巴巴～", "43215");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetVisible(0, true);
        giPlayerSetAng(0, 139.0);
        giCameraRunSingle("013", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerSetDir(1, 331.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J16", 1, false);
        giSetPortrait("104M", false);
        giTalk("韩菱纱：不过呢，至少他把剑穗收下了，嘻！", "43216");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：菱纱，我不明白，你不是说别把师叔当成师叔吗？可你刚才又说，因为他是师叔，才送他东西……？", "43217");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：笨，所谓吃人的嘴软、拿人的手短，紫英拿了我的东西，以后就不太会对我们凶了，多少总要有点顾忌吧？", "43218");
        giPlayerEndAction(1);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("104B", false);
        giTalk("韩菱纱：而且据我观察，小紫英八成是那种刀子嘴豆腐心的人，对付他用这招最有效了～我也是想让往后日子好过点嘛。", "43219");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：哦……真难懂……", "43220");
        giSetPortrait("104E", false);
        giTalk("韩菱纱：……也没指望你能懂…………", "43221");
        giSetPortrait("104E", false);
        giTalk("韩菱纱：<colour red=255 green=187 blue=0 alpha=255>回房、回房，</colour><dc0>我都睏了。</dc0>", "43222");
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("107B", true);
        giTalk("柳梦璃：嗯。", "43223");
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giSetObjectVisible("MO003", false);
        giSetObjectVisible("entrance2", true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerSetVisible(3, false);
        giIMMEnd();
        giIMMBegin();
        giPlayerCurrentSetPos(-153.46, 11.21, 1488.96);
        giPlayerCurrentSetAng(129.0);
        giPlayerCurrentSetVisible(true);
        giMonsterSetHide("m20-01-01", true);
        giMonsterSetHide("m20-01-02", true);
        giMonsterSetHide("m20-02-01", true);
        giMonsterSetHide("m20-02-02", true);
        giMonsterSetHide("m20-02-03", true);
        giMonsterSetHide("m20-02-04", true);
        giSetObjectVisible("MO002", true);
        giSetObjectVisible("MO004", true);
        giSetObjectVisible("MO006", false);
        giSetObjectVisible("save1", true);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        global_mvar = 80100; // 0x000138E4, 第二章 / 5-1-5.寒剑夜鸣 / 回房睡觉 / 寒剑夜鸣
        giScriptMusicStop(0, 2.5);
        giIMMEnd();
        giTimeScript(180.0, "func9001");
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2004()
{
    if (global_mvar == 91400 /* 第二章 / 6-3-2.义结金兰 / 离开禁地 / 结拜兄弟 */)
    {
        giTimeScriptTerminate();
        giPlayerLock();
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -228.5065, 3.3842, 1661.0713);
        giPlayerSetAng(0, 172.0);
        giPlayerSetPos(3, -219.2325, 5.0067, 1592.7435);
        giPlayerSetAng(3, 352.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(3, true);
        giMonsterSetHide("m20-01-01", false);
        giMonsterSetHide("m20-01-02", false);
        giMonsterSetHide("m20-02-01", false);
        giMonsterSetHide("m20-02-02", false);
        giMonsterSetHide("m20-02-03", false);
        giMonsterSetHide("m20-02-04", false);
        giSetObjectVisible("entrance2", false);
        giCameraPrepare("MC005");
        giAddPlayerFavor(0, 1, 10);
        giAddPlayerFavor(1, 0, 10);
        giAddPlayerFavor(0, 2, 10);
        giAddPlayerFavor(2, 0, 10);
        giAddPlayerFavor(1, 2, 10);
        giAddPlayerFavor(2, 1, 10);
        giAddPlayerFavor(0, 3, 10);
        giAddPlayerFavor(1, 3, 10);
        giAddPlayerFavor(2, 3, 10);
        giAddPlayerFavor(3, 0, 10);
        giAddPlayerFavor(3, 1, 10);
        giAddPlayerFavor(3, 2, 10);
        giIMMEnd();
        giCameraRunSingle("001", true);
        giFlashInBlack(2.0, false);
        giArenaReady();
        giWait(1.1);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：天河，师叔传你的心法……", "43838");
        giSetPortrait("102C", true);
        giTalk("云天河：怎么？", "43839");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……各人体质不同，故适合修习的心法也不尽相同，长老传授菱纱心法一事姑且不论，一般而言，所学甚杂未必是好事。", "43840");
        giSetPortrait("102C", true);
        giTalk("云天河：不是好事？", "43841");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：不会啊，大哥自己想出来的心法比琼华派的功夫厉害多了！练过之后身体变得好轻，心里也会觉得很平静、很舒坦。", "43842");
        giPlayerEndAction(0);
        giPlayerDoAction(3, "C08", 1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：……难怪，你修为进境非同一般。", "43843");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102B", true);
        giTalk("云天河：掌门又不教我们厉害的功夫，我跟大哥学几招应该没什么吧？", "43844");
        giSetPortrait("102B", true);
        giTalk("云天河：反正我也不怎么想做神仙，只要变更强就好了，不然也帮不上大哥和你。", "43845");
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……随你吧。", "43846");
        giWait(0.5);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：天河，这些日子你多注意菱纱和梦璃，刚才师叔提及她们，似乎有未尽之言，我不太放心……", "43847");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：有吗？那我去找玄霄问清楚——", "43848");
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：不必了……这几日奔波劳顿，<colour red=255 green=187 blue=0 alpha=255>先在派中歇息一晚，</colour><dc0>明日再去找剩余两件寒器。</dc0>", "43849");
        giPlayerEndAction(0);
        giWait(0.8);
        giPlayerWalkTo(3, -218.6174, 5.8504, 1517.0286, true);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giSetPortrait("102C", true);
        giTalk("云天河：（……紫英是不高兴了？可又不见他说出来……）", "43850");
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giCameraWait();
        giPlayerOutTeam(3, false);
        giIMMBegin();
        giSetObjectVisible("entrance2", true);
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(3, false);
        giMonsterSetHide("m20-01-01", true);
        giMonsterSetHide("m20-01-02", true);
        giMonsterSetHide("m20-02-01", true);
        giMonsterSetHide("m20-02-02", true);
        giMonsterSetHide("m20-02-03", true);
        giMonsterSetHide("m20-02-04", true);
        giIMMEnd();
        giIMMBegin();
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetAng(169.0);
        global_mvar = 100100; // 0x00018704, 第二章 / 6-3-3.义结金兰 / 歇息一晚
        giIMMEnd();
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giTimeScript(180.0, "func9001");
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
    }
}

void func2005()
{
    if (global_mvar == 120300 /* 第三章 / 7-4-1.仙妖乱 / 离开禁地 */)
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerSetPos(0, -260.8957, 4.3295, 1620.7494);
        giPlayerSetAng(0, 172.0);
        giPlayerSetVisible(0, true);
        giMonsterSetHide("m20-01-01", false);
        giMonsterSetHide("m20-01-02", false);
        giMonsterSetHide("m20-02-01", false);
        giMonsterSetHide("m20-02-02", false);
        giMonsterSetHide("m20-02-03", false);
        giMonsterSetHide("m20-02-04", false);
        giSetObjectVisible("entrance2", false);
        giCameraPrepare("MC004");
        giIMMEnd();
        giArenaReady();
        giCameraRunSingle("001", true);
        giCameraRunSingle("002", false);
        giFlashInWhite(2.0, true);
        giWait(1.0);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("102C", true);
        giTalk("云天河：（……大哥今天真是有些古怪，说的话也让人听不太懂……）", "44392");
        giSetPortrait("102A", true);
        giTalk("云天河：（……算了，想不明白就不想！）", "44393");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerDoAction(0, "J17", -1, false);
        giSetPortrait("102A", true);
        giTalk("云天河：（不知道梦璃回来了没有？<colour red=255 green=187 blue=0 alpha=255>我先回房休息一下，</colour><dc0>等她回来，就喊上菱纱，一起去找紫英……）</dc0>", "44394");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("102G", true);
        giTalk("云天河：（唉，但愿真像大哥说的那样，紫英还会跟我们和好……）", "44395");
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("001", true);
        giIMMBegin();
        giSetObjectVisible("entrance2", true);
        giPlayerCurrentSetAng(169.0);
        giCameraSetCollide(true);
        giCameraAutoSeek(true);
        giMonsterSetHide("m20-01-01", true);
        giMonsterSetHide("m20-01-02", true);
        giMonsterSetHide("m20-02-01", true);
        giMonsterSetHide("m20-02-02", true);
        giMonsterSetHide("m20-02-03", true);
        giMonsterSetHide("m20-02-04", true);
        giSetObjectVisible("entrance2", false);
        giCameraSetMode(5, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giTimeScript(180.0, "func9001");
        global_mvar = 120400; // 0x0001D650, 第三章 / 7-4-2.仙妖乱 / 兄弟话别
        giPlayerUnLock();
        giIMMEnd();
        giFlashInBlack(1.5, true);
    }
}

void func2006()
{
    if (global_mvar != 120800 /* 第三章 / 7-5-1.往事 / 再寻玄霄 */)
    {
        if (global_mvar >= 121100 /* 第三章 / 7-5-2.往事 / 向长老求助 / 禁地生变 */)
        {
            giPlayerLock();
            giPlayerSetLeader(0);
            giPlayerCurrentWalkTo(103.3756, 9.095, 1313.3967, true);
            giPlayerCurrentSetAng(133.0);
            giSetPortrait("101G", true);
            giTalk("云天河：禁地不能再去了……大哥……", "44664");
            giCameraSetMode(5, true);
            giPlayerUnLock();
        }
    }
    else
    {
        giPlayerLock();
        giTimeScriptTerminate();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -119.1102, 13.1451, 1508.2205);
        giPlayerSetAng(0, 303.0);
        giPlayerSetPos(1, -179.9306, 8.789, 1460.9935);
        giPlayerSetAng(1, 318.0);
        giPlayerSetPos(3, -172.8293, 9.409, 1508.9927);
        giPlayerSetAng(3, 314.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(3, true);
        giCameraPrepare("MC001");
        giIMMEnd();
        giArenaReady();
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：咦？禁地入口怎会有其他人？", "44571");
        giCameraRunSingle("002", true);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：元亦，你们在这里做什么？", "44572");
        giNpcSetDir("MN002", 135.0, true);
        giTalk("元亦：是紫英师兄！", "44573");
        giNpcWalkTo("MM002", -233.8552, 5.1244, 1591.4342, true);
        giWait(0.5);
        giTalk("元亦：掌门命我们从今日起镇守禁地，未经允许，不得让任何人入内，她自己似乎也要在禁地内闭关了。", "44574");
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giSetPortrait("105A", true);
        giTalk("慕容紫英：这等时候，掌门却要闭关？", "44575");
        giTalk("元亦：是啊，掌门说妖界或许是有了死守之心，才会在入口布下结界，但我们一日不攻进去，妖界却也未必会主动攻过来。掌门打算先闭关修炼一段日子，似乎另有秘法。", "44576");
        giCameraRunSingle("004", true);
        giWait(0.5);
        giSetPortrait("101C", false);
        giTalk("云天河：那我大哥呢？他还在禁地里吗？！", "44577");
        giWait(0.5);
        giNpcSetDir("MM002", 108.0, true);
        giWait(0.5);
        giTalk("元亦：你大哥？谁啊？", "44578");
        giPlayerWalkTo(0, -169.5623, 7.7709, 1565.5183, false);
        giCameraRunSingle("005", true);
        giSetNpcVisible("MN001", true);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 287.0, true);
        giSetPortrait("101A", false);
        giTalk("云天河：我自己进去看！", "44579");
        giNpcDoAction("MM002", "C07", -1, false);
        giTalk("元亦：慢着！你——", "44580");
        giSetPortrait("213A", true);
        giTalk("夙瑶：何事喧哗？！", "44581");
        giNpcDoAction("MN002", "C01", 1, false);
        giIMMBegin();
        giNpcSetAng("MM003", 97.0);
        giNpcSetAng("MM004", 277.0);
        giCameraRunSingle("006", true);
        giSetNpcVisible("MN001", true);
        giIMMEnd();
        giIMMBegin();
        giGOMTouch("MO001");
        giGOMTouch("MO003");
        giIMMEnd();
        giWait(4.0);
        giNpcWalkTo("MN001", -224.4307, 0.6574, 1693.8212, false);
        giWait(2.0);
        gi2DSoundPlay("WC001", 0);
        giWait(3.0);
        gi2DSoundStop();
        giIMMBegin();
        giPlayerSetPos(0, -142.0216, 8.8951, 1558.5923);
        giPlayerSetAng(0, 333.0);
        giPlayerSetPos(1, -210.8512, 6.1774, 1530.3975);
        giPlayerSetAng(1, 10.0);
        giPlayerSetPos(3, -189.3641, 5.5598, 1582.0642);
        giPlayerSetAng(3, 348.0);
        giNpcSetPos("MM002", -278.2734, 6.0708, 1649.3293);
        giNpcSetAng("MM002", 58.0);
        giCameraRunSingle("008", true);
        giIMMEnd();
        giObjectDoAction("MO001", "A", -1, false);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105A", false);
        giTalk("慕容紫英：弟子参见掌门！", "44582");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.8);
        giIMMBegin();
        giPlayerSetPos(0, -139.7661, 8.8951, 1552.3303);
        giCameraRunSingle("007", true);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("213B", true);
        giTalk("夙瑶：哦？几天不见，紫英你竟已目无尊长了？", "44583");
        giSetPortrait("105A", false);
        giTalk("慕容紫英：弟子不敢！", "44584");
        giSetPortrait("213B", true);
        giTalk("夙瑶：不敢？！那你们几人跑来禁地，所为何来？", "44585");
        giSetPortrait("101H", false);
        giTalk("云天河：我们是来找我大哥、找玄霄的！", "44586");
        giWait(0.5);
        giSetPortrait("213B", true);
        giTalk("夙瑶：玄霄？哼，他不会见你们。", "44587");
        giIMMBegin();
        giPlayerSetVisible(3, false);
        giSetNpcVisible("MM003", false);
        giPlayerSetPos(0, -177.7117, 5.8, 1630.3378);
        giPlayerSetAng(0, 316.0);
        giNpcSetAng("MN001", 143.0);
        giNpcSetAng("MM004", 213.0);
        giCameraRunSingle("009", true);
        giIMMEnd();
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：为什么？你为什么会在禁地里？你把我大哥怎么了？！", "44588");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("213B", false);
        giTalk("夙瑶：你口口声声称玄霄大哥，看不出他还颇有办法，让你这么死心塌地。", "44589");
        giSetPortrait("101H", true);
        giTalk("云天河：你……什么意思？", "44590");
        giWait(0.5);
        giSetPortrait("213B", false);
        giTalk("夙瑶：可悲，还想不明白吗？", "44591");
        giWait(0.5);
        giSetPortrait("213B", false);
        giTalk("夙瑶：今日一切都是我与玄霄策谋，而你们，不过是棋盘中的几颗小小棋子。", "44592");
        giScriptMusicPlay("P15", 2, 2.5, 2.5);
        giSetPortrait("105D", true);
        giTalk("慕容紫英：……！", "44593");
        giSetPortrait("103F", true);
        giTalk("韩菱纱：……！", "44594");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101I", true);
        giTalk("云天河：不可能！你胡说！", "44595");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("010", true);
        giIMMBegin();
        giPlayerSetPos(0, -142.8939, 7.0066, 1590.7692);
        giPlayerSetAng(0, 314.0);
        giPlayerSetPos(1, -172.7928, 9.4571, 1553.8235);
        giPlayerSetAng(1, 342.0);
        giPlayerSetPos(3, -202.6647, 5.5491, 1562.5107);
        giPlayerSetAng(3, 351.0);
        giPlayerSetVisible(3, true);
        giSetNpcVisible("MM003", true);
        giIMMEnd();
        giWait(0.7);
        giSetPortrait("213B", false);
        giTalk("夙瑶：玄霄身为羲和剑之主，在望舒剑被你们带至山门时，自然有所感应，有他告知，我才会见机收你们入门。", "44596");
        giSetPortrait("213B", false);
        giTalk("夙瑶：不然就凭你们在禁地数次大摇大摆地出入，我又怎会不知？", "44597");
        giIMMBegin();
        giNpcSetAng("MN001", 151.0);
        giCameraRunSingle("011", true);
        giIMMEnd();
        giSetPortrait("103F", true);
        giTalk("韩菱纱：……所以、所以你根本不是靠什么占术，才知道有故人之子上山……", "44598");
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：掌门，弟子斗胆。弟子实在不解，难道如此做，只是为了取回望舒剑？此剑乃本门之物，若是向天河索要，他自然也会归还……", "44599");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giWait(0.5);
        giSetPortrait("213B", false);
        giTalk("夙瑶：你莫弄错，我要的不是望舒剑，而是再度苏醒过来的望舒剑。", "44600");
        giWait(0.5);
        giSetPortrait("105E", true);
        giTalk("慕容紫英：弟子驽钝……", "44601");
        giCameraRunSingle("013", true);
        giWait(0.8);
        giSetPortrait("213B", false);
        giTalk("夙瑶：不懂便罢，如今妖界虽然按兵不动，但大敌当前，岂可轻忽？紫英你还是回去多多修行，勿要被杂念所扰。", "44602");
        giSetPortrait("213B", false);
        giTalk("夙瑶：至于其他几人就自行下山去吧，最好将山上的一切通通忘记。", "44603");
        giSetPortrait("105C", true);
        giTalk("慕容紫英：……！", "44604");
        giIMMBegin();
        giNpcSetAng("MM002", 116.0);
        giNpcSetAng("MM003", 129.0);
        giIMMEnd();
        giCameraRunSingle("015", true);
        giWait(0.5);
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101I", false);
        giTalk("云天河：等等！我不懂你的意思！你说大哥骗了我们？可是大哥为什么要骗我们？！", "44605");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101I", false);
        giTalk("云天河：他、他不是我爹娘的师兄吗？", "44606");
        giWait(0.5);
        giSetPortrait("213B", true);
        giTalk("夙瑶：……师兄？那又如何？", "44607");
        giSetPortrait("213B", true);
        giTalk("夙瑶：你可知道？玄霄恨云天青、夙玉入骨，没有杀了你，已算手下留情！", "44608");
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：你……说什么？怎么可能？！", "44609");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("213A", true);
        giTalk("夙瑶：看样子，不与你说清楚，你是不会死心的。", "44610");
        giCameraRunSingle("016", false);
        giSetPortrait("213A", true);
        giTalk("夙瑶：元亦，去将本派秘卷取来。", "44611");
        giNpcSetDir("MM002", 76.0, true);
        giTalk("元亦：是。", "44612");
        giEffectPlayWithNPC("H_097", 1, "MM002");
        giNpcBlendOut("MM002", 2.0, true);
        giWait(4.3);
        giEffectPlayWithNPC("H_097", 1, "MM002");
        giNpcBlendIn("MM002", 2.0, true);
        giWait(1.0);
        giSetPortrait("213A", true);
        giTalk("夙瑶：元亦，我命你将卷轴上所记，一字不差地念出来。", "44613");
        giNpcDoAction("MM002", "J01", -1, false);
        giWait(2.0);
        giTalk("元亦：……！掌门，这……", "44614");
        giSetPortrait("213B", true);
        giTalk("夙瑶：念！", "44615");
        giTalk("元亦：是！", "44616");
        giCameraRunSingle("017", false);
        giTalk("元亦：“吾派第二十代掌门道胤真人以惊世之才，苦修终年，于晚年参悟以阴阳双剑合合之力，携派中弟子飞升之秘法。自此，穷三代之人力、物力，终成羲和、望舒双剑。”", "44617");
        giTalk("元亦：“阴阳双剑需以‘人剑相合’之法修炼，数载方有所成。而双剑飞升之法，必辅强盛灵力，非人世苦修所能及。道胤真人不愧思虑深远，曾夜观星象，占一奇地，灵气充沛异常，应能为吾派所用。奈何此为妖界，并不易与……”", "44618");
        giTalk("元亦：“……吾派弟子玄霄、夙玉资质上佳，乃被选为双剑宿体。历三载，逢妖界以十九年为一周，再度降临。玄霄、夙玉合双剑之力网缚妖界，令其不可动弹，以引取极大灵力。而妖界顽抗，吾派与之力斗，第二十四代掌门太清真人不幸为妖孽所害，引发战局旷日持久，惨烈非常。”", "44619");
        giTalk("元亦：“关键之时，望舒剑宿体夙玉心生怯意，更因私情，与其师兄云天青携剑出逃。羲和剑宿体玄霄独力难支，令妖界脱离昆仑而去。此一役吾派伤亡过百，其中掌门太清真人、掌门首徒玄震、长老——”", "44620");
        giSetPortrait("213A", true);
        giTalk("夙瑶：够了。", "44621");
        giTalk("元亦：是……", "44622");
        giNpcUnHoldAct("MM002");
        giNpcEndAction("MM002", true);
        giCameraRunSingle("012", true);
        giCameraRunSingle("018", false);
        giWait(0.8);
        giSetPortrait("101H", false);
        giTalk("云天河：…………", "44623");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：怎么、怎么会这样……", "44624");
        giSetPortrait("213A", true);
        giTalk("夙瑶：云天河，这下你再无疑惑了吧？", "44625");
        giWait(0.5);
        giSetPortrait("213A", true);
        giTalk("夙瑶：若非云天青、夙玉临阵脱逃，玄霄又怎会运功过度？且他无望舒剑支持，内息大乱，才终致阳炎侵体，变为后来的模样！", "44626");
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：大哥……他……他是被我爹和我娘害的……", "44627");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giPlayerSetAng(1, 38.0);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103I", true);
        giTalk("韩菱纱：天河，你别理她！不知从哪里找来的卷轴，随便念一念，就要别人相信啊！如果这些都是真的，那这卷轴为何不敢放在经楼里？", "44628");
        giSetPortrait("213B", true);
        giTalk("夙瑶：派中秘辛，岂是人人可知？何况有你妙手空空，万一卷轴被你所见，那我与玄霄不是功亏一篑？", "44629");
        giPlayerSetDir(1, 342.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：你……！！", "44630");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giNpcSetAng("MM002", 108.0);
        giCameraRunSingle("015", true);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(3, "J07", -1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：掌门，弟子还是不明，无论如何，本派只是要将望舒剑取回，又何必……何必如此对待天河他们？", "44631");
        giPlayerUnHoldAct(3);
        giPlayerEndAction(3);
        giSetPortrait("213B", true);
        giTalk("夙瑶：大胆！你有此一问，是觉得我曾错待他们？", "44632");
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……", "44633");
        giWait(0.5);
        giSetPortrait("213B", true);
        giTalk("夙瑶：云天河等人入门以来，我命你尽心传授心法，如今令他们下山，也不以驱逐之名，我自问待他们已是不薄。", "44634");
        giWait(0.5);
        giPlayerDoAction(0, "J30", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：我、我还是不信……你让我见大哥一面！", "44635");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("213A", true);
        giTalk("夙瑶：……我说过，玄霄不会见你。", "44636");
        giWait(0.5);
        giSetPortrait("213A", true);
        giTalk("夙瑶：他此时正运功调息，不可被打扰。何况，真的令你与他相对，你又如何言语？玄霄未因前事报复，已是难得，难道非要引出他旧恨，弄到不可收拾的地步？", "44637");
        giWait(0.8);
        giSetPortrait("101G", false);
        giTalk("云天河：我……", "44638");
        giSetPortrait("213A", true);
        giTalk("夙瑶：我并非危言耸听，你好自为之！", "44639");
        giIMMBegin();
        giNpcSetAng("MM002", 76.0);
        giCameraRunSingle("019", true);
        giIMMEnd();
        giNpcSetDir("MN001", 352.0, true);
        giWait(0.5);
        giSetPortrait("213A", true);
        giTalk("夙瑶：元亦！我要入禁地闭关！你带人在此守好，绝不可让人闯入！", "44640");
        giTalk("元亦：是！掌门！", "44641");
        giIMMBegin();
        giGOMTouch("MO001");
        giGOMTouch("MO003");
        giIMMEnd();
        giWait(4.0);
        giNpcWalkTo("MN001", -217.2401, 20.6681, 1806.2992, false);
        giWait(2.5);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P28", 2, 0.0, 2.5);
        giIMMBegin();
        giPlayerSetPos(0, -104.7058, 12.5315, 1508.2798);
        giPlayerSetAng(0, 322.0);
        giPlayerSetPos(1, -139.3754, 12.7168, 1462.3978);
        giPlayerSetAng(1, 36.0);
        giPlayerSetPos(3, -168.45, 9.4742, 1521.1292);
        giPlayerSetAng(3, 147.0);
        giPlayerSetVisible(3, false);
        giCameraRunSingle("020", true);
        giIMMEnd();
        giSetPortrait("101G", false);
        giTalk("云天河：…………", "44642");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……天河，你还好吗？……", "44643");
        giPlayerSetDir(0, 200.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：我、我也不知道，要是真像掌门说的那样，是我爹娘害了大哥……我又该怎么办？", "44644");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：振作一点，天河！你别听信掌门的一面之辞！再说梦璃还下落不明，等着我们去弄清楚真相！", "44645");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：梦璃……大哥……怎么会……怎么所有事都变得这么乱……", "44646");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：天河……", "44647");
        giIMMBegin();
        giPlayerSetVisible(3, true);
        giPlayerSetAng(0, 220.0);
        giCameraRunSingle("021", true);
        giIMMEnd();
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("101G", false);
        giTalk("云天河：菱纱……也许我错了，我真的不该下山，真的真的不该下山……", "44648");
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：……或许吧……你说的对，许多事情、知道了……还不如不知道……", "44649");
        giWait(0.5);
        giSetPortrait("103H", true);
        giTalk("韩菱纱：我……对不起你……", "44650");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……不如，我们硬闯进去，问过玄霄，就什么都清楚了！", "44651");
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：不！我、我不想这样，掌门说大哥正在运功，不可以被打扰……而且、而且我根本不知道要问他什么……", "44652");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：天河，你……", "44653");
        giWait(0.3);
        giPlayerSetDir(0, 316.0, true);
        giWait(0.4);
        giPlayerDoAction(0, "J04", -1, false);
        giSetPortrait("101G", true);
        giTalk("云天河：爹和娘害了大哥……真的吗？我该怎么办？", "44654");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giCameraRunSingle("022", false);
        giWait(1.0);
        giPlayerDoAction(3, "C09", 1, false);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……禁地这条路已是不通了，<colour red=255 green=187 blue=0 alpha=255>我们不如去找青阳、重光两位长老</colour><dc0>。无论玄霄师叔之事，还是梦璃之事，或许长老都会有些办法可想……</dc0>", "44655");
        giPlayerSetDir(1, 325.0, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……紫英，掌门都已经让我和天河下山了，你……还要跟我们一起吗？", "44656");
        giWait(0.3);
        giPlayerDoAction(3, "C08", 1, true);
        giWait(0.5);
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……我并非不信掌门的话，但是也不能丢下你们不管，就算天河的爹娘……那些事也不该由他来背负……", "44657");
        giSetPortrait("105E", false);
        giTalk("慕容紫英：何况，梦璃失踪之事也要弄清楚原由。", "44658");
        giPlayerDoAction(1, "C08", 1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：……谢谢你，天河现在这样，有你一起，总好过我一个人陪着他……", "44659");
        giSetPortrait("105E", false);
        giTalk("慕容紫英：……走吧。", "44660");
        giWait(0.5);
        giPlayerSetDir(1, 37.0, false);
        giCameraRunSingle("023", false);
        giWait(0.5);
        giSetPortrait("101G", true);
        giTalk("云天河：…………", "44661");
        giWait(0.5);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：天河，我们走吧。", "44662");
        giWait(2.0);
        giPlayerDoAction(0, "C08", 1, false);
        giSetPortrait("101G", false);
        giTalk("云天河：嗯……", "44663");
        giWait(0.8);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(3, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(103.3756, 9.095, 1313.3967);
        giPlayerCurrentSetAng(133.0);
        giCameraSetMode(5, true);
        giNpcSetAng("MM004", 257.0);
        giNpcSetAng("MM003", 122.0);
        giNpcSetAng("MM002", 148.0);
        global_mvar = 121100; // 0x0001D90C, 第三章 / 7-5-2.往事 / 向长老求助 / 禁地生变
        giTimeScript(180.0, "func9001");
        giPlayerUnLock();
        giIMMEnd();
        giFlashInBlack(1.5, true);
    }
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
