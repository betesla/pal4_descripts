// Structured PAL4 reconstruction for M10.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M10_1_init()
{
    int ui_timer_save_data = 0;

    giSetObjectVisible("calCtrl", true);
    if (global_mvar != 61000)
    {
        if (global_mvar != 61002 /* 第二章 / 4-2-2.幻境试炼 / 寻找美酒 */)
        {
            giAlwaysJump(true);
            giArenaReadyRestore();
        }
        else
        {
            giAlwaysJump(true);
            giArenaReadyRestore();
            ui_timer_save_data = giUiTimerGetSaveData();
            giStartUiTimer(ui_timer_save_data, "func2004");
        }
    }
    else
    {
        func2001();
        giAlwaysJump(true);
    }
}

void M10_10_init()
{
    if (global_mvar != 61003 /* 第二章 / 4-2-3.幻境试炼 / 继续闯关 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2005();
    }
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    if (global_mvar >= 61000)
    {
        if (global_mvar <= 61005 && global_mvar > 61003 /* 收集宝石 */)
        {
            giPlayerCurrentSetPos(-6.567932, 0.055222, -1293.762);
            giPlayerCurrentSetAng(180.0);
            giCameraSetMode(5, true);
        }
        else
        {
            giPlayerCurrentSetPos(404.6532, -1.757, 409.3541);
            giPlayerCurrentSetAng(220.0);
            giCameraSetMode(5, true);
        }
    }
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    if (global_mvar == 61003 /* 第二章 / 4-2-3.幻境试炼 / 继续闯关 */)
    {
        giPlayerLock();
        gi2DSoundPlay("WE061", 1);
        giWait(0.5);
        giFlashOutWhite(1.5, true, true);
        giArenaLoad("M10", "10", "", true);
    }
}

void shiyi001()
{
    giCameraRunSingle("006", true);
    giWait(0.5);
    giPlayerDoAction(0, "J16", -1, false);
    giSetPortrait("101B", false);
    giTalk("云天河：太好了！可以回去了吗？", "42542");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giWait(0.3);
    giSetPortrait("B07A", true);
    giTalk("酒仙翁：当然不是，后面还有其他的考验等着你们呐！", "42543");
    giPlayerDoAction(0, "J04", -1, false);
    giSetPortrait("101C", false);
    giTalk("云天河：哦……", "42544");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giWait(0.8);
    giPlayerDoAction(2, "J07", 1, false);
    giSetPortrait("106B", false);
    giTalk("柳梦璃：多谢仙翁。", "42545");
    giPlayerEndAction(2);
    giSetPortrait("B07A", true);
    giTalk("酒仙翁：哈哈哈～女娃儿不用谢老夫。待老夫想想，“酒色财气”四关，你们已经过了“酒”这一关，接下来嘛……", "42546");
    giCameraRunSingle("007", true);
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：我瞧小娃儿艳福不浅，身边两个如花似玉的女娃儿应该挺喜欢你的吧？“色”那一关就可以省下啰！", "42547");
    giWait(0.5);
    giSetPortrait("106E", true);
    giTalk("柳梦璃：仙翁你……", "42548");
    giPlayerDoAction(1, "J02", -1, false);
    giSetPortrait("103I", true);
    giTalk("韩菱纱：仙翁！你搞错了吧？！我我我、怎么可能喜欢这块木头！根本没有的事！ ", "42549");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giWait(0.5);
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：哈哈，喜不喜欢，你们自己心里都有数，老夫说对说错，又有什么关系。", "42550");
    giWait(0.5);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101E", true);
    giTalk("云天河：呃，那个、我……", "42551");
    giPlayerEndAction(0);
    giWait(0.5);
    giPlayerSetDir(1, 35.0, false);
    giPlayerSetDir(2, 121.0, false);
    giCameraRunSingle("008", true);
    giWait(0.8);
    giPlayerDoAction(1, "J01", -1, false);
    giSetPortrait("103G", false);
    giTalk("韩菱纱：你、你想说什么？可别胡思乱想哦……", "42552");
    giPlayerSetDir(0, 204.0, false);
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101E", true);
    giTalk("云天河：我……我是想说，原来你这么讨厌我，以前都不知道……", "42553");
    giPlayerEndAction(0);
    giSetPortrait("103G", false);
    giTalk("韩菱纱：什么？我几时说过讨厌你了？", "42554");
    giWait(0.5);
    giSetPortrait("101E", true);
    giTalk("云天河：就在刚才啊……可是，我就很喜欢你和梦璃，为什么你会讨厌我？", "42555");
    giWait(0.5);
    giPlayerDoAction(1, "J15", -1, false);
    giSetPortrait("103G", false);
    giTalk("韩菱纱：你！你这野人，木头脑袋！这要我怎么说啊！", "42556");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giWait(0.5);
    giCameraRunSingle("009", false);
    giWait(0.3);
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：哈哈，小娃儿，你的喜欢和女娃儿说的喜欢，可不是一回事～", "42557");
    giPlayerSetDir(0, 239.0, false);
    giPlayerSetDir(1, 263.0, false);
    giPlayerSetDir(2, 228.0, false);
    giCameraWait();
    giWait(0.5);
    giSetPortrait("101E", true);
    giTalk("云天河：……？", "42558");
    giWait(0.5);
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：你说的恐怕是朋友之谊，可女娃儿和老夫说的，却是男女之情啊。", "42559");
    giWait(0.3);
    giSetPortrait("101E", true);
    giTalk("云天河：有什么不一样吗？", "42560");
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：哈哈，老夫是仙，你却问老夫这个问题，让老夫如何回答你呢？", "42561");
    giWait(0.5);
    giCameraRunSingle("012", false);
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：老夫只知凡人追求痴情爱欲，何谓情爱，并无定论，有人平平淡淡便是真情，有人却非要弄到天崩地裂才罢休，一切只看你自己是如何想法，反正啊，和她在一起便觉最舒心、最自在的人，八成就是你真正喜欢的人了！", "42562");
    giWait(0.5);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101E", true);
    giTalk("云天河：……我还是不懂，喜欢还有假的吗？而且要分那么多种？好难……", "42563");
    giWait(0.5);
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：有人一见倾心，有人朋友之谊会变为爱怜之情，呵呵～小娃儿懂是不懂啊？", "42564");
    giWait(0.5);
    giPlayerDoAction(0, "J15", 1, false);
    giSetPortrait("101C", true);
    giTalk("云天河：不懂……", "42565");
    giPlayerEndAction(0);
    giWait(0.5);
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：那教你一个不用伤脑筋的办法好不好？", "42566");
    giWait(0.5);
    giPlayerDoAction(0, "C08", 1, false);
    giSetPortrait("101B", true);
    giTalk("云天河：好啊！谢谢～～", "42567");
    giPlayerEndAction(0);
    giWait(0.5);
    giSetPortrait("B07A", false);
    giTalk("酒仙翁：两个字……喝酒……", "42568");
    giWait(0.3);
    giPlayerDoAction(2, "J14", 1, false);
    giSetPortrait("106C", true);
    giTalk("柳梦璃：噗……", "42569");
    giPlayerEndAction(2);
    giCameraRunSingle("010", true);
    giWait(0.5);
    giPlayerDoAction(0, "J14", 1, false);
    giSetPortrait("101D", true);
    giTalk("云天河：……呃，那个……菱纱说喝酒伤身，我喝多了会被她骂，还有别的办法吗？", "42570");
    giWait(0.5);
    giIMMBegin();
    giPlayerSetDir(1, 35.0, false);
    giPlayerSetDir(2, 116.0, false);
    giIMMEnd();
    giWait(0.5);
    giSetPortrait("106B", false);
    giTalk("柳梦璃：……", "42571");
    giWait(0.5);
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103G", true);
    giTalk("韩菱纱：……天河，我说你呀，别总在这个问题上纠缠不休了，我们快点通过试炼比较重要吧？", "42572");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giWait(0.3);
    giWait(0.3);
    giCameraRunSingle("011", true);
    giWait(0.8);
    giSetPortrait("B07A", true);
    giTalk("酒仙翁：不错不错，哈哈，女娃儿说的对，跳脱不出尘世多情，你们还求什么仙道啊？", "42573");
    giWait(0.5);
    giSetPortrait("B07A", true);
    giTalk("酒仙翁：快走吧，老夫要开始畅饮美酒了，然后睡上个天昏地暗，你们也加把劲，快快通过考验～", "42574");
    giFlashOutBlack(1.5, true, true);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    giPlayerCurrentSetVisible(true);
    giMonsterSetHide("m10-01-01", true);
    giMonsterSetHide("m10-01-04", true);
    giMonsterSetHide("m10-04-05", true);
    giMonsterSetHide("m10-04-01", true);
    giSetObjectVisible("save1", true);
    giIMMEnd();
    global_mvar = 61003; // 0x0000EE4B, 第二章 / 4-2-3.幻境试炼 / 继续闯关
    giPlayerCurrentSetPos(268.2812, -1.7571, 32.7826);
    giPlayerCurrentSetAng(265.0);
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giScriptMusicStop(1, 2.5);
    giShowSignpost();
    giPlayerUnLock();
    giFlashInBlack(1.5, true);
}

void func2001()
{
    giPlayerLock();
    giIMMBegin();
    giSetObjectVisible("calCtrl", false);
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(0, 447.8887, -1.7571, 396.4918);
    giPlayerSetAng(0, 302.0);
    giPlayerSetPos(1, 398.6532, -1.757, 331.3541);
    giPlayerSetAng(1, 33.0);
    giPlayerSetPos(2, 333.3695, -1.757, 382.0242);
    giPlayerSetAng(2, 91.0);
    giPlayerSetVisible(0, true);
    giPlayerSetVisible(1, true);
    giPlayerSetVisible(2, true);
    giMonsterSetHide("m10-01-01", false);
    giMonsterSetHide("m10-03-02", false);
    giMonsterSetHide("m10-05-02", false);
    giMonsterSetHide("m10-03-04", false);
    giSetObjectVisible("save1", false);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInWhite(2.5, false);
    giArenaReady();
    giWait(2.0);
    giCameraRunSingle("002", true);
    giWait(3.0);
    giCameraRunSingle("003", true);
    giWait(1.5);
    giCameraRunSingle("004", false);
    giWait(1.0);
    giPlayerDoAction(0, "J13", 1, true);
    giCameraWait();
    giWait(0.5);
    giPlayerSetDir(0, 203.0, true);
    giWait(0.3);
    giSetPortrait("101D", true);
    giTalk("云天河：这是哪里？掌门不是说要带我们去一个地方？", "42490");
    giWait(0.3);
    giSetPortrait("103J", false);
    giTalk("韩菱纱：嘻，不懂了吧～还跑路爬山的，掌门可不是要带你去踏青，她使的是仙～法～", "42491");
    giWait(0.5);
    giPlayerDoAction(2, "C08", 1, false);
    giSetPortrait("106A", false);
    giTalk("柳梦璃：嗯……这法术十分厉害，须臾之间便将几人送来此地，绝非易事，但是掌门施展起来却不费吹灰之力。", "42492");
    giPlayerEndAction(2);
    giPlayerSetDir(1, 317.0, false);
    giPlayerSetDir(0, 262.0, false);
    giWait(0.5);
    giPlayerDoAction(1, "J13", -1, false);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：好梦璃，你不是也会幻术？能带我们出去吗？", "42493");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giWait(0.5);
    giPlayerSetDir(2, 123.0, true);
    giPlayerDoAction(2, "C09", 1, false);
    giSetPortrait("106A", true);
    giTalk("柳梦璃：此地亦幻亦真，虚实难辨，凭我的法力还不能破解。", "42494");
    giPlayerDoAction(1, "J13", -1, false);
    giSetPortrait("103B", false);
    giTalk("韩菱纱：哇～这么厉害？琼华派果然不简单！", "42495");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：最想不到的，掌门居然是个女的，还是个大美人，看起来又那么威严，害我刚才好紧张。", "42496");
    giWait(0.5);
    giPlayerSetDir(0, 225.0, true);
    giPlayerDoAction(0, "J13", -1, false);
    giWait(0.8);
    giSetPortrait("101B", true);
    giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>那边有人，问问他怎么走好了～</colour>", "42497");
    giWait(0.5);
    giIMMBegin();
    giPlayerSetDir(1, 231.0, false);
    giPlayerSetDir(2, 215.0, false);
    giIMMEnd();
    giCameraRunSingle("005", true);
    giWait(1.0);
    giCameraRunSingle("006", true);
    gi2DSoundPlay("WJ027", 0);
    giWait(5.0);
    gi2DSoundStop();
    giCameraRunSingle("007", true);
    giWait(0.5);
    giPlayerDoAction(1, "C08", 1, false);
    giWait(0.3);
    giSetPortrait("103M", false);
    giTalk("韩菱纱：也好，一时半会想不到其他办法了。", "42498");
    giWait(1.0);
    giFlashOutBlack(1.5, true, true);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    giPlayerSetVisible(2, false);
    giPlayerCurrentSetVisible(true);
    giMonsterSetHide("m10-01-01", true);
    giMonsterSetHide("m10-03-02", true);
    giMonsterSetHide("m10-05-02", true);
    giMonsterSetHide("m10-03-04", true);
    giSetObjectVisible("save1", true);
    giIMMEnd();
    global_mvar = 61001; // 0x0000EE49, 第二章 / 4-2-1.幻境试炼 / 询问老者
    giPlayerCurrentSetPos(398.6532, -1.757, 331.3541);
    giPlayerCurrentSetAng(203.0);
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giPlayerUnLock();
    giFlashInBlack(1.5, true);
}

void func2002()
{
    if (global_mvar == 61002 /* 第二章 / 4-2-2.幻境试炼 / 寻找美酒 */)
    {
        giPlayerLock();
        giCurrentPlayerFaceToNpc("MN001", true);
        giSetPortrait("B07A", true);
        giTalk("酒仙翁：还不快去给老夫找酒？<colour red=255 green=187 blue=0 alpha=255>找到了酒就倒进后面的酒缶里！</colour>", "");
        giPlayerUnLock();
    }
    if (global_mvar == 61003 /* 第二章 / 4-2-3.幻境试炼 / 继续闯关 */)
    {
        giPlayerLock();
        giCurrentPlayerFaceToNpc("MN001", true);
        giSetPortrait("B07A", true);
        giTalk("酒仙翁：快走吧，老夫要开始畅饮美酒了，然后睡上个天昏地暗～", "");
        giPlayerUnLock();
    }
    if (global_mvar == 61001 /* 第二章 / 4-2-1.幻境试炼 / 询问老者 */)
    {
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giHideGASkillObject();
        giIMMBegin();
        giSetObjectVisible("calCtrl", false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 268.2812, -1.7571, 32.7826);
        giPlayerSetAng(0, 239.0);
        giPlayerSetPos(1, 263.3467, -1.757, -28.1301);
        giPlayerSetAng(1, 263.0);
        giPlayerSetPos(2, 218.4137, -1.757, 50.9575);
        giPlayerSetAng(2, 228.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giMonsterSetHide("m10-01-01", false);
        giMonsterSetHide("m10-01-04", false);
        giMonsterSetHide("m10-04-05", false);
        giSetObjectVisible("save1", false);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, true);
        gi2DSoundPlay("WJ027", 0);
        giWait(3.0);
        giCameraRunSingle("002", true);
        giWait(1.0);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：老人家，打扰一下可以吗？", "42499");
        giPlayerEndAction(2);
        giScriptMusicPlay("P62", 2, 0.0, 0.0);
        giWait(1.0);
        giSetPortrait("B07A", true);
        giTalk("老人：……唔？", "42500");
        giWait(0.5);
        giWait(1.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：……老人家？", "42501");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.8);
        giSetPortrait("B07A", true);
        giTalk("老人：……唔……好酒……", "42502");
        giSetPortrait("103E", false);
        giTalk("韩菱纱：…………", "42503");
        giPlayerWalkTo(1, 231.6931, -2.7108, -31.2752, true);
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：老人家！", "42504");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(2.0);
        giSetPortrait("B07A", true);
        gi2DSoundStop();
        giTalk("老人：啊？！我梦里的酒！没了、全没了！你们、你们没见老夫正在打盹吗？！吵醒了老夫，梦里的好酒都喝不上了！", "42505");
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：实在对不住，我们不是有意要打扰您睡觉，只是想问问从这儿怎么出去。", "42506");
        giPlayerEndAction(2);
        giWait(0.5);
        giSetPortrait("B07A", true);
        giTalk("老人：唔？原来是从琼华派来的小娃儿。", "42507");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：正是，老人家您认识琼华派的人吗？能不能告诉我们出去的路啊？", "42508");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giSetPortrait("B07A", false);
        giTalk("老人：……唉，被你们这一闹，肚子里的酒虫全醒了，咕咕直叫！", "42509");
        giPlayerDoAction(0, "C07", -1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：你肚子饿的话，我们带了干粮～", "42510");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giSetPortrait("B07A", false);
        giTalk("老人：干粮管什么用？老夫乃是酒仙翁，自然要喝酒。", "42511");
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：老人家～喝酒伤身，而且会喝醉呢。", "42512");
        giPlayerEndAction(1);
        giSetPortrait("B07A", false);
        giTalk("酒仙翁：哈哈哈～莫说醉，醉了海阔天空！喝酒好、喝酒好啊～", "42513");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：（爹也是这么爱喝酒吗……）", "42514");
        giPlayerEndAction(0);
        giCameraRunSingle("004", true);
        giWait(0.8);
        giSetPortrait("B07A", true);
        giTalk("酒仙翁：说起来，你们几个娃儿，刚才把别人好梦惊醒，害老夫没能喝到梦中的美酒，居然还想要老夫帮忙，想得美哦。", "42515");
        giWait(0.5);
        giSetPortrait("B07A", true);
        giTalk("酒仙翁：唔……刚刚梦到蜜酒，好久没梦到了，真是好喝啊，嗯……嗯……", "42516");
        giWait(0.5);
        giCameraRunSingle("005", true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：蜜酒？我爹也很爱喝的！", "42517");
        giSetPortrait("B07A", false);
        giTalk("酒仙翁：是吗？看你这傻小子的眼睛就知道说的是实话，不是顺竿爬来哄老翁开心，呵呵呵～你我有缘，你我有缘啊。", "42518");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：老人家～我们也不知道您正梦见喝美酒啊，所谓不知者不罪，您就大人有大量，别计较了。", "42519");
        giPlayerDoAction(2, "J13", 1, false);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("B07A", false);
        giTalk("酒仙翁：女娃儿说的轻松，老夫才没那么好打发，除非……", "42520");
        giWait(0.3);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：除非什么？！", "42521");
        giWait(0.5);
        giSetPortrait("B07A", false);
        giTalk("酒仙翁：哈，你们害老夫没喝到酒，自然要给老夫找酒来，这样吧，<colour red=255 green=187 blue=0 alpha=255>去找九十九坛美酒，把我身后这个酒缶装满，</colour><dc0>老夫能喝得过瘾，少不了要帮帮你们。</dc0>", "42522");
        giPlayerEndAction(2);
        giCameraRunSingle("006", false);
        giWait(2.5);
        giIMMBegin();
        giPlayerSetDir(2, 258.0, false);
        giPlayerSetDir(0, 260.0, false);
        giPlayerSetDir(1, 284.0, false);
        giIMMEnd();
        giCameraWait();
        giWait(3.0);
        giCameraRunSingle("007", true);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetDir(2, 228.0, false);
        giPlayerSetDir(0, 239.0, false);
        giPlayerSetDir(1, 263.0, false);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：嘻，太好了，谢谢仙翁指点！", "42523");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("008", true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：你这么想喝酒，为什么自己不去找呢？", "42524");
        giWait(0.3);
        giPlayerEndAction(0);
        giPlayerSetDir(1, 33.0, false);
        giPlayerSetDir(2, 113.0, false);
        giWait(0.5);
        giSetPortrait("103B", false);
        giTalk("韩菱纱：哎呀，少呆了，这就是仙翁给我们的考验呐！", "42525");
        giWait(0.5);
        giSetPortrait("B07A", false);
        giTalk("酒仙翁：哈哈，无妨，就当老夫年纪大了，只好麻烦年轻人跑跑腿。", "42526");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：可你一次喝那么多酒，头不会晕？我上回只喝了一点，就撑不住了……", "42527");
        giPlayerDoAction(2, "J14", 1, true);
        giCameraRunSingle("009", true);
        giWait(0.5);
        giSetPortrait("B07A", true);
        giTalk("酒仙翁：你这娃儿有意思，求人办事还问东问西的。这倒让我想起很久以前，也有个年轻人，哄得老夫很开心呢！仔细看，你和那人长得真有几分像。", "42528");
        giWait(0.5);
        giCameraRunSingle("008", true);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103A", false);
        giTalk("韩菱纱：喂，天河，他说的是不是你爹啊？", "42529");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：真的吗？爹也来过这里？", "42530");
        giPlayerEndAction(0);
        giSetPortrait("B07A", false);
        giTalk("酒仙翁：好了，闲话少说，去吧！动作不够快，老夫可要生气的！", "42531");
        giWait(0.5);
        giShowTutorial(21);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        giMonsterSetHide("m10-01-01", true);
        giMonsterSetHide("m10-01-04", true);
        giMonsterSetHide("m10-04-05", true);
        giSetObjectVisible("save1", true);
        giSetObjectVisible("calCtrl", true);
        giIMMEnd();
        global_mvar = 61002; // 0x0000EE4A, 第二章 / 4-2-2.幻境试炼 / 寻找美酒
        giPlayerCurrentSetPos(268.2812, -1.7571, 32.7826);
        giPlayerCurrentSetAng(48.5);
        giCameraSetMode(5, true);
        giFlushTailYAngle();
        giScriptMusicStop(0, 2.5);
        giShowSignpost();
        giFlashInBlack(1.5, true);
        giPlayerUnLock();
        giStartUiTimer(3000, "func2004");
    }
}

void func2003()
{
    if (global_mvar == 61002 /* 第二章 / 4-2-2.幻境试炼 / 寻找美酒 */)
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giScriptMusicPlay("P62", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giHideGASkillObject();
        giSetObjectVisible("calCtrl", false);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 268.2812, -1.7571, 32.7826);
        giPlayerSetAng(0, 239.0);
        giPlayerSetPos(1, 231.6931, -2.7108, -31.2752);
        giPlayerSetAng(1, 263.0);
        giPlayerSetPos(2, 218.4137, -1.757, 50.9575);
        giPlayerSetAng(2, 228.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giMonsterSetHide("m10-01-01", false);
        giMonsterSetHide("m10-01-04", false);
        giMonsterSetHide("m10-04-05", false);
        giMonsterSetHide("m10-04-01", false);
        giSetObjectVisible("save1", false);
        giIMMEnd();
        giCameraPrepare("MC003");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.0, true);
        giWait(1.0);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giSetPortrait("B07A", true);
        giTalk("酒仙翁：这味儿，好香哇！小娃儿不错，手脚俐落得很，这些瓶瓶罐罐的，就拿去玩吧！", "42532");
        giAddProperty(3026, 5, true);
        giWait(1.5);
        giAddProperty(3031, 5, true);
        giWait(1.5);
        giAddProperty(3212, 3, true);
        giWait(1.5);
        giTalk("韩菱纱：嘻！谢谢仙翁！不过，那个出口……", "42533");
        giTalk("酒仙翁：莫急，莫急～老夫这就送你们一程。", "42534");
        giWait(0.5);
        gi2DSoundPlay("WE197", 1);
        giSetObjectVisible("Jeffect001", true);
        giWait(1.5);
        shiyi001();
    }
}

void func2004()
{
    int property_3253_count = 0;

    if (global_mvar == 61002 /* 第二章 / 4-2-2.幻境试炼 / 寻找美酒 */)
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giScriptMusicPlay("P62", 2, 0.0, 0.0);
        giFlashOutBlack(1.5, true, true);
        giHideGASkillObject();
        giSetObjectVisible("calCtrl", false);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 268.2812, -1.7571, 32.7826);
        giPlayerSetAng(0, 239.0);
        giPlayerSetPos(1, 231.6931, -2.7108, -31.2752);
        giPlayerSetAng(1, 263.0);
        giPlayerSetPos(2, 218.4137, -1.757, 50.9575);
        giPlayerSetAng(2, 228.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giMonsterSetHide("m10-01-01", false);
        giMonsterSetHide("m10-01-04", false);
        giMonsterSetHide("m10-04-05", false);
        giMonsterSetHide("m10-04-01", false);
        giSetObjectVisible("save1", false);
        giIMMEnd();
        giNpcDoAction("MN001", "Z01", 0, false);
        giCameraPrepare("MC003");
        giCameraRunSingle("003", true);
        giFlashInBlack(1.0, true);
        giWait(1.0);
        giSetPortrait("B07A", true);
        giTalk("酒仙翁：不是让你们动作快一点吗？！", "42536");
        giWait(0.5);
        giSetPortrait("B07A", true);
        giTalk("酒仙翁：老夫等了又等，被酒虫闹得浑身发痒，来来来！你们几个，找不到酒，就陪我活动活动筋骨！", "42537");
        giWait(0.5);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giSetPortrait("101D", true);
        giTalk("云天河：要打架？", "42538");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101J", true);
        giTalk("云天河：我不干，你年纪这么大了，我不出手。", "42539");
        giPlayerEndAction(0);
        giSetPortrait("B07A", false);
        giTalk("酒仙翁：哈哈，大话别说得太早！", "42540");
        giWait(0.6);
        giFlashOutBlack(0.5, true, true);
        giSetFullHP();
        giSetFullMP();
        giAddCombatMonster(2585, 1);
        giAddCombatMonster(2530, 0);
        giAddCombatMonster(2530, 2);
        giConfigCombatBgm("P54");
        giConfigCombatCamera("CA7");
        giConfigCombatGroundCamera("CA13");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M10A");
        giPlayerLock();
        giScriptMusicPlay("P62", 2, 0.0, 0.0);
        giNpcEndAction("MN001", true);
        giFlashInBlack(1.5, true);
        giWait(0.6);
        giSetPortrait("B07A", false);
        giTalk("酒仙翁：你们几个打架倒不含糊，好吧，也算通过这一关，老夫送你们一程！", "42541");
        property_3253_count = giGetPropertyNumb(3253);
        if (giGetPropertyNumb(3253) > 0)
        {
            giDelProperty(3253, property_3253_count, false);
        }
        giWait(0.5);
        gi2DSoundPlay("WE197", 1);
        giSetObjectVisible("Jeffect001", true);
        giWait(1.5);
        shiyi001();
    }
}

void func2005()
{
    if (global_mvar == 61003 /* 第二章 / 4-2-3.幻境试炼 / 继续闯关 */)
    {
        giPlayerLock();
        giScriptMusicPlay("P24", 2, 0.0, 0.0);
        giFlashOutBlack(0.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 214.4711, 94.7091, -1846.3544);
        giPlayerSetAng(0, 285.0);
        giPlayerSetPos(1, 165.2726, 94.7091, -1798.4966);
        giPlayerSetAng(1, 276.0);
        giPlayerSetPos(2, 226.9647, 94.7091, -1765.1788);
        giPlayerSetAng(2, 258.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giNpcSetAng("MN001", 34.0);
        giMonsterSetHide("m10-02-07", false);
        giMonsterSetHide("m10-05-03", false);
        giMonsterSetHide("m10-03-03", false);
        giMonsterSetHide("m10-05-04", false);
        giMonsterSetHide("m10-05-01", false);
        giIMMEnd();
        giCameraPrepare("MC001");
        giCameraRunSingle("001", true);
        giFlashInWhite(2.0, false);
        giArenaReady();
        giWait(2.0);
        giCameraRunSingle("002", true);
        giWait(1.0);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：这个人……好像很有钱的样子。", "42575");
        giWait(0.3);
        giCameraRunSingle("003", true);
        giWait(0.5);
        giCameraRunSingle("004", false);
        giWait(0.5);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：但是他好严肃……都不讲话。", "42576");
        giCameraWait();
        giWait(1.2);
        giCameraRunSingle("005", false);
        giWait(1.2);
        giPlayerWalkTo(1, 152.7725, 94.7091, -1794.8358, false);
        giPlayerWalkTo(2, 123.6267, 94.7091, -1739.7155, false);
        giPlayerWalkTo(0, 111.6506, 94.7091, -1844.1875, false);
        giPlayerEndMove(2);
        giPlayerSetDir(2, 258.0, false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 303.0, false);
        giCameraWait();
        giWait(1.0);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106B", false);
        giTalk("柳梦璃：请问，这一关要怎样才能通过呢？", "42577");
        giPlayerEndAction(2);
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：不难、不难，让我高兴就好。", "42578");
        giWait(0.5);
        giSetPortrait("103E", false);
        giTalk("韩菱纱：（哼～神气什么？讲话都不看人的……）", "42579");
        giWait(0.5);
        giCameraRunSingle("006", true);
        giWait(0.3);
        giPlayerDoAction(2, "J13", 1, false);
        giWait(0.3);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……那，要怎样您才会高兴呢？", "42580");
        giWait(0.8);
        giPlayerEndAction(2);
        giSetPortrait("B09A", true);
        giTalk("财神爷：去找十颗宝石给我，听好～只要最值钱的九眼石，其他的我通通看不上眼。", "42581");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103C", false);
        giTalk("韩菱纱：九……眼石？没听说过啊……是什么样子的？", "42582");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("007", true);
        giWait(0.3);
        giNpcSetDir("MN001", 85.0, true);
        giWait(0.3);
        giSetPortrait("B09A", true);
        giTalk("财神爷：唉！怎地如此孤陋寡闻？一看就知道生财无方，注定要做穷鬼。", "42583");
        giWait(0.5);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：你！……", "42584");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("B09A", true);
        giTalk("财神爷：九眼石就是一种金色的石头，这么简单都不知道……", "42585");
        giWait(0.5);
        giCameraRunSingle("006", true);
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：唉，指点你们费时又费力，快去吧，找十一颗九眼石给我。", "42586");
        giWait(0.5);
        giSetPortrait("106E", false);
        giTalk("柳梦璃：…………", "42587");
        giWait(0.3);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：咦？不是十颗吗，怎么又多一颗？！", "42588");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：既然你问我答，多一颗是我回答你们的报酬。去找十二颗宝石来吧。", "42589");
        giWait(0.3);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：…………", "42590");
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：骗人的吧？财神爷不是应该散财吗？这个家伙居然见钱眼开又乱抬价……", "42591");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giCameraRunSingle("008", true);
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：小姑娘，别以为小声说我坏话，我就听不见。你问我答～天上各路财神一大把，要是不想办法敛财，哪来的财可以散？单是我的这身行头也不便宜呐——", "42592");
        giNpcDoAction("MN001", "C07", -1, false);
        giSetPortrait("B09A", true);
        giTalk("财神爷：<colour red=255 green=187 blue=0 alpha=255>去找十三颗九眼石来吧。</colour>", "42593");
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(0.5);
        giCameraRunSingle("007", true);
        giWait(0.5);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你！……", "42594");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(0, 33.0, false);
        giPlayerSetDir(2, 142.0, true);
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106D", true);
        giTalk("柳梦璃：菱纱你先别和财神爷说话了，我们说越多，他要的宝石就越多……", "42595");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101A", true);
        giTalk("云天河：是啊，好像夏天山里的蚊子，越杀越多。", "42596");
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：嗯，这句免钱～还是你们两个聪明，快去快回吧！", "42597");
        giIMMBegin();
        giPlayerSetDir(2, 258.0, false);
        giPlayerSetDir(0, 316.0, false);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J15", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：（……气死人了！不痛骂这破财神，难消我心头之恨！可是，这家伙又会坐地起价敲竹杠……）", "42598");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giPlayerSetVisible(0, false);
        giPlayerSetVisible(1, false);
        giPlayerSetVisible(2, false);
        giPlayerCurrentSetVisible(true);
        giNpcSetAng("MN001", 34.0);
        giMonsterSetHide("m10-02-07", true);
        giMonsterSetHide("m10-05-03", true);
        giMonsterSetHide("m10-03-03", true);
        giMonsterSetHide("m10-05-04", true);
        giMonsterSetHide("m10-05-01", true);
        giIMMEnd();
        global_mvar = 61005; // 0x0000EE4D, 收集宝石
        giPlayerCurrentSetPos(105.335, 94.7091, -1737.6846);
        giPlayerCurrentSetAng(322.0);
        giCameraSetMode(5, true);
        giFlushTailYAngle();
        giScriptMusicStop(0, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func2006()
{
    if (!giCheckPackProperty(3126, 13))
    {
        giSetPortrait("B09A", true);
        giTalk("财神爷：没找到<colour red=255 green=187 blue=0 alpha=255>十三颗九眼石</colour><dc0>之前，不要和我说话。</dc0>", "");
    }
    else
    {
        giPlayerLock();
        giScriptMusicPlay("P24", 2, 0.0, 0.0);
        giFlashOutBlack(0.5, true, true);
        giHideGASkillObject();
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, -40.5017, 94.7091, -1670.5986);
        giPlayerSetAng(0, 160.0);
        giPlayerSetPos(1, 23.1775, 94.709, -1638.8938);
        giPlayerSetAng(1, 188.0);
        giPlayerSetPos(2, 72.6831, 94.7091, -1676.6632);
        giPlayerSetAng(2, 218.0);
        giPlayerSetVisible(0, true);
        giPlayerSetVisible(1, true);
        giPlayerSetVisible(2, true);
        giNpcSetAng("MN002", 34.0);
        giMonsterSetHide("m10-02-07", false);
        giMonsterSetHide("m10-05-03", false);
        giMonsterSetHide("m10-03-03", false);
        giMonsterSetHide("m10-05-04", false);
        giMonsterSetHide("m10-05-01", false);
        giIMMEnd();
        giCameraPrepare("MC002");
        giCameraRunSingle("001", true);
        giFlashInBlack(0.5, true);
        giWait(1.0);
        giCameraRunSingle("002", true);
        giWait(0.5);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：财神爷，您要的宝石我们已经带来了。", "42599");
        giPlayerEndAction(2);
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：不错不错，快给我吧！", "42600");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：慢——！", "42601");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giIMMBegin();
        giNpcSetDir("MN001", 11.0, false);
        giPlayerSetDir(2, 319.0, false);
        giPlayerSetDir(0, 49.0, false);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("106D", false);
        giTalk("柳梦璃：菱纱？有什么不对吗？", "42602");
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：财神爷，你看清楚了，是这些吗？ ", "42603");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：是啊，还不快给我。", "42604");
        giWait(0.5);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：嘻嘻，既然你是财神爷，那一定懂商道吧？没听过一手交钱一手交货吗？", "42605");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("B09A", true);
        giTalk("财神爷：嗯，有道理！", "42606");
        giWait(0.3);
        giNpcSetDir("MN001", 267.0, true);
        giWait(0.3);
        giNpcDoAction("MN001", "C07", -1, false);
        giWait(0.9);
        giCameraRunSingle("003", true);
        giWait(0.3);
        gi2DSoundPlay("WE197", 1);
        giSetObjectVisible("Jeffect002", true);
        giIMMBegin();
        giPlayerSetDir(0, 218.0, false);
        giPlayerSetDir(1, 223.0, false);
        giPlayerSetDir(2, 243.0, false);
        giIMMEnd();
        giWait(2.0);
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(1.2);
        giCameraRunSingle("004", true);
        giWait(0.5);
        giNpcSetDir("MN001", 11.0, true);
        giWait(0.8);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：天河！", "42607");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giIMMBegin();
        giPlayerSetDir(0, 66.0, false);
        giPlayerSetDir(2, 308.0, false);
        giIMMEnd();
        giWait(0.5);
        giSetPortrait("101C", true);
        giTalk("云天河：啊？干嘛？", "42608");
        giWait(0.5);
        giIMMBegin();
        giPlayerSetAng(1, 249.0);
        giCameraRunSingle("005", true);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：你数一下，刚刚我放你包里的宝石有几颗～", "42609");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("101A", false);
        giTalk("云天河：不就是十三颗吗？", "42610");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：少多话，叫你数就数啊。", "42611");
        giPlayerEndAction(1);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：呃，我数数……咦，不对，怎么多了三颗？！", "42612");
        giPlayerEndAction(0);
        giWait(0.3);
        giSetPortrait("B09A", false);
        giTalk("财神爷：……！！", "42613");
        giWait(0.5);
        giPlayerDoAction(1, "J16", -1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：嘻嘻～既然财神爷这么喜欢这些宝石，那一定很值钱，我刚才顺手多弄了几颗，打算带回去卖钱。", "42614");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giPlayerDoAction(0, "J02", -1, false);
        giSetPortrait("101H", false);
        giTalk("云天河：啊？！难怪刚才打得有点慢，你竟然偷藏……", "42615");
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：小赚一笔嘛～ ", "42616");
        giPlayerEndAction(1);
        giCameraRunSingle("006", true);
        giWait(0.5);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：……菱纱……我懂你的意思，但是你这样做，会不会太冒险了……", "42617");
        giWait(0.3);
        giPlayerSetDir(1, 131.0, false);
        giPlayerSetDir(0, 86.0, false);
        giWait(0.3);
        giCameraRunSingle("007", false);
        giWait(0.3);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：好梦璃，你放心吧，瞧我的！", "42618");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraWait();
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：什么意思？我都糊涂了……", "42619");
        giPlayerEndAction(0);
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：不可不可！这些宝石并非凡物，你们不能把多余的带走！", "42620");
        giIMMBegin();
        giPlayerSetDir(0, 151.0, false);
        giPlayerSetDir(1, 190.0, false);
        giPlayerSetDir(2, 218.0, false);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：哼，懒得管你，反正门开了，给你十三颗，银货两讫。", "42621");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giNpcDoAction("MN001", "Z01", 0, false);
        giSetPortrait("B09A", true);
        giTalk("财神爷：放肆！竟然敢跟财神爷这样说话！你们都别想走！", "42622");
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：咦？刚刚说好的，一手交钱一手交货，想讲话不守信用吗？你懂不懂商道啊？", "42623");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("B09A", true);
        giTalk("财神爷：你！你！你好大的胆子！三个年轻人不懂爱惜自己的性命，不要以为财神爷只数钱不打架！", "42624");
        giWait(0.5);
        giPlayerDoAction(1, "J02", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：呀！恼羞成怒？你想动手？！", "42625");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("008", true);
        giSetPortrait("B09A", true);
        giTalk("财神爷：从来没人会想多带宝石！每个试炼的人都是战战兢兢、规规矩矩！你、你、你们这几个闯关的家伙，尤、尤、尤其是你，太不像话了！", "42626");
        giSetPortrait("B09A", true);
        giTalk("财神爷：看我今天好好收拾你们，我、我、我一定要给你们好看！", "42627");
        giFlashOutBlack(1.5, true, true);
        giSetFullHP();
        giSetFullMP();
        giAddCombatMonster(2587, 1);
        giAddCombatMonster(2529, 0);
        giAddCombatMonster(2528, 2);
        giConfigCombatBgm("P54");
        giConfigCombatCamera("CA6");
        giConfigCombatGroundCamera("CA13");
        giConfigCombatParam(true, 0, 0, 0);
        giStartCombat("M10C");
        giPlayerLock();
        giNpcEndAction("MN001", true);
        giCameraRunSingle("009", true);
        giFlashInBlack(1.5, true);
        giWait(0.5);
        giSetPortrait("B09A", true);
        giTalk("财神爷：……我败了……", "42628");
        giWait(0.5);
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：怎样？服不服气？ ", "42629");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(1.0);
        giSetPortrait("B09A", true);
        giTalk("财神爷：……", "42630");
        giWait(0.8);
        giPlayerSetDir(0, 55.0, true);
        giWait(0.3);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：……", "42631");
        giWait(1.0);
        giSetPortrait("B09A", true);
        giTalk("财神爷：…………", "42632");
        giWait(1.0);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：…………", "42633");
        giWait(1.0);
        giPlayerSetDir(0, 151.0, true);
        giWait(0.5);
        giPlayerDoAction(0, "J17", 1, false);
        giSetPortrait("101D", true);
        giTalk("云天河：（怎么他们都不讲话？是不是这个老头还想打？……但我没感到杀气啊……）", "42634");
        giWait(0.5);
        giPlayerEndAction(0);
        giSetPortrait("B09A", true);
        giTalk("财神爷：……………………", "42635");
        giWait(0.5);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：……？", "42636");
        giIMMBegin();
        giScriptMusicPlay("P63", 2, 0.0, 2.5);
        giIMMEnd();
        giPlayerEndAction(0);
        giWait(0.3);
        giSetPortrait("B09B", true);
        giTalk("财神爷：哈哈哈，三位真乃人中豪杰，刚才是开个小玩笑，别当真啊，有话好商量嘛～", "42637");
        giWait(0.5);
        giPlayerDoAction(1, "J04", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：（……转得好硬，果然是无奸不商……）", "42638");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.5);
        giSetPortrait("B09B", true);
        giTalk("财神爷：这么多闯关的人来来去去，就只有这位姑娘会想到多搜集一些宝石，真是难得的人才啊！", "42639");
        giWait(0.5);
        giPlayerDoAction(1, "J14", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：别嘴巴跟抹了蜂蜜似的，姑娘我不吃这一套。", "42640");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("B09B", true);
        giTalk("财神爷：是是是～那到底该用哪一套，望姑娘指点一二。", "42641");
        giWait(0.3);
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：哼，想要全部的宝石也行，直接让我们把“气”那一关也过了！", "42642");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("B09B", true);
        giTalk("财神爷：啊？！你们不一关一关地闯，这不合规矩呀！", "42643");
        giWait(0.5);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：是～～吗～～那就没得谈了，你要的宝石给你，多余的我带着继续闯关啰。", "42644");
        giPlayerEndAction(1);
        giWait(0.3);
        giSetPortrait("B09B", true);
        giTalk("财神爷：别～别～别～有话好商量。大家都是熟人、都是熟人呀！不用这么计较吧？", "42645");
        giWait(0.5);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：（谁跟是你熟人……）", "42646");
        giWait(0.5);
        giSetPortrait("B09B", true);
        giTalk("财神爷：……我想想……", "42647");
        giWait(0.5);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：……", "42648");
        giWait(0.5);
        giPlayerSetDir(2, 312.0, true);
        giWait(0.5);
        giPlayerDoAction(2, "J14", 1, false);
        giSetPortrait("106C", false);
        giTalk("柳梦璃：菱纱你实在是……呵呵……", "42649");
        giPlayerEndAction(2);
        giWait(0.5);
        giNpcSetDir("MN001", 267.0, true);
        giWait(0.3);
        giSetPortrait("B09B", true);
        giTalk("财神爷：唉～～～罢了、罢了，亏了、亏了。", "42650");
        giWait(0.3);
        giIMMBegin();
        giPlayerSetDir(0, 218.0, false);
        giPlayerSetDir(1, 223.0, false);
        giPlayerSetDir(2, 243.0, false);
        giIMMEnd();
        giWait(0.7);
        giNpcDoAction("MN001", "C07", -1, false);
        giWait(0.7);
        giCameraRunSingle("003", true);
        giWait(0.3);
        giSetObjectVisible("Jeffect002", false);
        giWait(1.2);
        gi2DSoundPlay("WE197", 1);
        giSetObjectVisible("Jeffect001", true);
        giWait(2.0);
        giNpcUnHoldAct("MN001");
        giNpcEndAction("MN001", true);
        giWait(1.0);
        giCameraRunSingle("010", true);
        giWait(0.5);
        giNpcSetDir("MN001", 9.0, true);
        giWait(0.5);
        giSetPortrait("B09B", true);
        giTalk("财神爷：三位过去吧，从这里直接就能回琼华派了。", "42651");
        giWait(0.5);
        giSetPortrait("B09B", true);
        giTalk("财神爷：姑娘……你看……那个宝石……", "42652");
        giWait(0.3);
        giIMMBegin();
        giPlayerSetDir(0, 151.0, false);
        giPlayerSetDir(1, 190.0, false);
        giPlayerSetDir(2, 218.0, false);
        giIMMEnd();
        giWait(0.5);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：哼！给你。", "42653");
        giWait(0.5);
        giDelProperty(3126, 16, true);
        giWait(2.5);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giWait(0.1);
        giSetPortrait("103J", false);
        giTalk("韩菱纱：我们走了！", "42654");
        giWait(0.3);
        giSetPortrait("B09B", true);
        giTalk("财神爷：是、是、是，您慢走。", "42655");
        giWait(0.5);
        giPlayerWalkTo(1, -117.7459, 94.7091, -1793.7587, false);
        giWait(1.8);
        giNpcSetDir("MN001", 281.0, false);
        giPlayerSetDir(0, 219.0, false);
        giPlayerSetDir(2, 240.0, false);
        giWait(0.2);
        giPlayerEndMove(1);
        gi2DSoundPlay("WE061", 1);
        giPlayerBlendOut(1, 0.8, false);
        giWait(1.0);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：……一下就能过关了？", "42656");
        giPlayerEndAction(0);
        giPlayerDoAction(2, "c08", 1, false);
        giSetPortrait("106C", false);
        giTalk("柳梦璃：嗯，多亏了菱纱的妙计呢。", "42657");
        giPlayerEndAction(2);
        giCameraRunSingle("011", false);
        giPlayerWalkTo(0, -117.7459, 94.7091, -1793.7587, false);
        giWait(0.2);
        giPlayerWalkTo(2, -117.7459, 94.7091, -1793.7587, false);
        giPlayerEndMove(0);
        gi2DSoundPlay("WE061", 1);
        giPlayerBlendOut(0, 0.8, false);
        giWait(0.2);
        giPlayerEndMove(2);
        gi2DSoundPlay("WE061", 1);
        giPlayerBlendOut(2, 0.8, true);
        giWait(0.5);
        giSetObjectVisible("Jeffect001", false);
        giCameraWait();
        giWait(0.5);
        giSetPortrait("B09B", false);
        giTalk("财神爷：哈哈……三位慢走、三位慢走。", "42658");
        giWait(1.5);
        giSetPortrait("B09A", false);
        giTalk("财神爷：（哼！可恶的三个小娃儿，别再给我看到！不然我、我、我……罢了，和气生财、和气生财。）", "42659");
        giFlashOutWhite(1.5, true, true);
        giPlayerCurrentSetVisible(true);
        giIMMBegin();
        giMonsterSetHide("m10-02-07", false);
        giMonsterSetHide("m10-05-03", false);
        giMonsterSetHide("m10-03-03", false);
        giMonsterSetHide("m10-05-04", false);
        giMonsterSetHide("m10-05-01", false);
        giIMMEnd();
        global_mvar = 61100; // 0x0000EEAC
        giArenaLoad("Q06", "QN03", "", true);
    }
}

void func2007()
{
    if (global_mvar == 61001 /* 第二章 / 4-2-1.幻境试炼 / 询问老者 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, -428.212, -2.6609, -420.5049, true);
        giPlayerSetDir(0, 48.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giSetPortrait("101C", true);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>先要找人问路。</colour>", "");
        giPlayerUnLock();
    }
}

void func2008()
{
    if (global_mvar == 61001 /* 第二章 / 4-2-1.幻境试炼 / 询问老者 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 305.9011, -2.5104, -316.428, true);
        giPlayerSetDir(0, 311.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giSetPortrait("101C", true);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>先要找人问路。</colour>", "");
        giPlayerUnLock();
    }
}

void func2009()
{
    if (global_mvar == 61001 /* 第二章 / 4-2-1.幻境试炼 / 询问老者 */)
    {
        giPlayerLock();
        giPlayerSetLeader(0);
        giPlayerWalkTo(0, 410.1558, -1.757, 413.558, true);
        giPlayerSetDir(0, 225.0, true);
        giCameraAutoSeek(true);
        giCameraSetMode(5, true);
        giSetPortrait("101C", true);
        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>先要找人问路。</colour>", "");
        giPlayerUnLock();
    }
}

void func7001()
{
    giAddProperty(3253, 1, true);
}

void func7002()
{
    int property_3253_count = 0;
    string local_7 = "";
    string local_8 = "";
    string local_9 = "";

    giPlayerLock();
    giPauseUiTimer();
    giCameraSetCollide(false);
    property_3253_count = giGetPropertyNumb(3253);
    if (giGetPropertyNumb(3253) <= 0)
    {
        if (global_mvar != 61002 /* 第二章 / 4-2-2.幻境试炼 / 寻找美酒 */)
        {
            if (global_mvar == 61003 /* 第二章 / 4-2-3.幻境试炼 / 继续闯关 */)
            {
                giSetPortrait("B07A", true);
                giTalk("酒仙翁：快走吧，老夫要开始畅饮美酒了，然后睡上个天昏地暗～", "");
            }
        }
        else
        {
            func8001();
            giSetPortrait("B07A", true);
            giTalk("酒仙翁：还不快去给老夫找酒？老夫可要等不及了！", "");
            giResumeUiTimer();
        }
    }
    else
    {
        giPlayerCurrentFaceToGOB("surface01", true);
        giFlushTailYAngle();
        giWait(1.0);
        giPlayerCurrentDoAction("C07", -1, true);
        giDelProperty(3253, property_3253_count, true);
        var_xia = var_xia;
        giPlayerCurrentEndAction();
        giWait(0.5);
        giCameraPrepare("viewContainer");
        giCameraRunSingle("viewContainer", true);
        giWait(0.5);
        giGOBMovment("surface01", 1.5, 2.0896, (40.2362 + (40.0 * 1.0)), -0.7878, false);
        giGOBScale("surface01", (0.98 + (0.14 * 1.0)), 1.5, true);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
        if (var_xia < 99)
        {
            local_7 = "酒仙翁：还少";
            local_9 = func7006(var_xia);
            local_8 = local_9;
            local_9 = local_9;
            local_7 = "酒仙翁：还少" + local_9;
            local_7 = "酒仙翁：还少" + local_9 + "坛酒。";
            giSetPortrait("B07A", true);
            local_9 = "酒仙翁：还少" + local_9 + "坛酒。";
            giTalk("酒仙翁：还少" + local_9 + "坛酒。", "");
            giIMMBegin();
            giCameraSetMode(5, true);
            giCameraAutoSeek(true);
            giCameraSeekToPlayer();
            giIMMEnd();
            giResumeUiTimer();
        }
        else
        {
            giClearUiTimer();
            func2003();
        }
    }
    giPlayerUnLock();
}

void func7004()
{
}

void func7005()
{
    string local_1 = "";
    int local_3 = 0;
    bool wine000_visible = false;
    string local_5 = "";

    local_1 = "wine";
    giIMMBegin();
    while (local_3 <= 119)
    {
        local_1 = "wine";
        if (local_3 >= 10)
        {
            if (local_3 < 100)
            {
                local_1 = "wine" + "00" + "0";
            }
        }
        else
        {
            local_1 = "wine" + "00";
        }
        local_5 = "wine" + "00" + "0";
        wine000_visible = giGetVisibleObject("wine" + "00" + "0");
        if (!giGetVisibleObject(local_5))
        {
            local_5 = "wine" + "00" + "0";
            giGOBReset("wine" + "00" + "0");
            local_5 = "wine" + "00" + "0";
            giSetObjectVisible("wine" + "00" + "0", true);
        }
    }
    giIMMEnd();
}

string func7006(int arg0)
{
    // typed_typeinfo_hints: primary=array<string>; extras=[int]
    // prototype_hint: array<string> func7006(int)
    string local_3 = "";
    string local_4 = "";
    int local_5 = 0;

    if ((arg0 / 10) > 9)
    {
        local_3 = "";
    }
    else if (local_5 >= 1)
    {
        local_3 = "一";
    }
    if ((arg0 % 10) > 9)
    {
        local_4 = "";
    }
    else if (local_5 >= 1)
    {
        local_4 = "一";
    }
    if ((arg0 / 10) != 0)
    {
        if ((arg0 / 10) != 1)
        {
            return local_3 + "十" + local_4;
        }
        else
        {
            return "十" + local_4;
        }
    }
    else
    {
        return local_4;
    }
}

void func7007()
{
    giGOBReset("door01");
    giOBJBlendOut("door01", 1.0, false);
    giGOBReset("door03");
    giOBJBlendIn("door03", 1.0, false);
}

void func7008()
{
    giGOBReset("door02");
    giOBJBlendOut("door02", 1.0, false);
    giGOBReset("door01");
    giOBJBlendIn("door01", 1.0, false);
}

void func7009()
{
    giGOBReset("door03");
    giOBJBlendOut("door03", 1.0, false);
    giGOBReset("door02");
    giOBJBlendIn("door02", 1.0, false);
}

void func7010()
{
    giGOBReset("door01");
    giOBJBlendIn("door01", 1.0, false);
}

void func7011()
{
    giGOBReset("door02");
    giOBJBlendIn("door02", 1.0, false);
}

void func7012()
{
    giGOBReset("door03");
    giOBJBlendIn("door03", 1.0, false);
}

void func7013()
{
    giGOBSetPosition("JA01", -713.9085, 231.2562, -539.8408);
    giOBJBlendIn("treasure01", 1.5, true);
    giObjectDoAction("treasure01", "OM08", -1, true);
    giOBJBlendOut("treasure01", 1.0, false);
    giOBJBlendIn("JA01", 1.5, true);
    giGOBMovment("JA01", 5.0, -713.9085, 8.2562, -539.8408, true);
    giSetObjectVisible("JA01", false);
}

void func7014()
{
    giGOBSetPosition("JA02", 4.7763, 214.2562, 993.3723);
    giOBJBlendIn("treasure02", 1.5, true);
    giObjectDoAction("treasure02", "OM08", -1, true);
    giOBJBlendOut("treasure02", 1.0, false);
    giOBJBlendIn("JA02", 1.5, true);
    giGOBMovment("JA02", 5.0, 4.7763, 8.2562, 993.3723, true);
    giSetObjectVisible("JA02", false);
}

void func7015()
{
    giGOBSetPosition("JA03", 821.6183, 232.2561, -534.5714);
    giOBJBlendIn("treasure03", 1.5, true);
    giObjectDoAction("treasure03", "OM08", -1, true);
    giOBJBlendOut("treasure03", 1.0, false);
    giOBJBlendIn("JA03", 1.5, true);
    giGOBMovment("JA03", 5.0, 821.6183, 8.2562, -534.5714, true);
    giSetObjectVisible("JA03", false);
}

void func7016()
{
    int property_3126_count = 0;

    giAddProperty(3126, 1, true);
    giSetObjectVisible("JA01", false);
    property_3126_count = giGetPropertyNumb(3126);
    if (giGetPropertyNumb(3126) == 13)
    {
        func7019();
    }
}

void func7017()
{
    int property_3126_count = 0;

    giAddProperty(3126, 1, true);
    giSetObjectVisible("JA02", false);
    property_3126_count = giGetPropertyNumb(3126);
    if (giGetPropertyNumb(3126) == 13)
    {
        func7019();
    }
}

void func7018()
{
    int property_3126_count = 0;

    giAddProperty(3126, 1, true);
    giSetObjectVisible("JA03", false);
    property_3126_count = giGetPropertyNumb(3126);
    if (giGetPropertyNumb(3126) == 13)
    {
        func7019();
    }
}

void func7019()
{
    int leader_player_id = 0;
    int local_3 = 0;

    giPlayerLock();
    giIMMBegin();
    giSetObjectVisible("calTreasure", false);
    giSetObjectVisible("calOpenDoor", false);
    giSetObjectVisible("gEff01", false);
    giSetObjectVisible("gEff02", false);
    giSetObjectVisible("gEff03", false);
    giIMMEnd();
    giWait(1.0);
    leader_player_id = giPlayerGetLeader();
    if (giPlayerGetLeader() > 3)
    {
        giSetPortrait("101B", true);
        giTalk("云天河：十三颗宝石收集齐了，<colour red=255 green=187 blue=0 alpha=255>我们赶快找财神去吧。</colour>", "");
    }
    else if (local_3 >= 0)
    {
        giSetPortrait("101B", true);
        giTalk("云天河：十三颗宝石收集齐了，<colour red=255 green=187 blue=0 alpha=255>我们赶快找财神去吧。</colour>", "");
    }
    giIMMBegin();
    giOBJBlendOut("door01", 1.5, false);
    giOBJBlendOut("door02", 1.5, false);
    giOBJBlendOut("door03", 1.5, false);
    giIMMEnd();
    giPlayerUnLock();
}

void func7020()
{
    bool tip_visible = false;

    tip_visible = giGetVisibleObject("tip");
    if (giGetVisibleObject("tip") && global_mvar == 61005 /* 收集宝石 */)
    {
        giPlayerLock();
        giFlashOutBlack(0.7, true, true);
        giFlashInBlack(0.5, true);
        giCameraSetCollide(false);
        giCameraPrepare("viewTr");
        giCameraRunSingle("viewTr01", true);
        giShowCommonDialog("迷宫中有三个区域会依次掉落九眼石。", 0.5, 0.5);
        giWait(0.5);
        giOBJBlendIn("gEff01", 0.5, true);
        giWait(1.0);
        giCameraRunSingle("viewTr02", true);
        giWait(0.5);
        giOBJBlendIn("gEff02", 0.5, true);
        giWait(1.0);
        giCameraRunSingle("viewTr03", true);
        giWait(0.5);
        giOBJBlendIn("gEff03", 0.5, true);
        giWait(1.0);
        giCameraRunSingle("viewTr03_2", true);
        giWait(0.5);
        giOBJBlendOut("door03", 1.5, true);
        giShowCommonDialog("每个区域的大门每三十秒开启一次，三十秒后关闭。", 0.5, 0.5);
        giWait(1.0);
        giCameraRunSingle("viewTr03_3", true);
        giShowCommonDialog("大门打开一段时间后……", 0.5, 0.5);
        giWait(1.0);
        func7015();
        giWait(1.0);
        giShowCommonDialog("九眼石落地过程中，接住它能够获得该物品，落地消失后要等待下次空中宝箱出现。", 0.5, 0.5);
        giWait(1.0);
        giIMMBegin();
        giSetObjectVisible("calTreasure", true);
        giSetObjectVisible("calOpenDoor", true);
        giSetObjectVisible("tip", false);
        giSetObjectVisible("door03", true);
        giIMMEnd();
        giFlashOutBlack(0.7, true, true);
        giIMMBegin();
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giIMMEnd();
        giFlashInBlack(0.5, true);
        giPlayerUnLock();
    }
}

void func8001()
{
    if (var_cha == 2007)
    {
        giPlayerLock();
        giClearUiTimer();
        func2004();
        var_cha = 0;
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
