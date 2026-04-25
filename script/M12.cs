// Structured PAL4 reconstruction for M12.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M12_1_init()
{
    giTimeScript(180.0, "func9001");
    giOpenWeather(8);
    if (global_mvar < 140100 && global_mvar >= 131300 /* 第三章 / 8-3-3.心愿 / 前往妖界 / 亘古神陵 */)
    {
        giSetObjectVisible("entrance1", false);
        giArenaReadyRestore();
    }
    if (global_mvar >= 160200 /* 第四章 / 9-3-2.君莫思归 / 再访长老 / 生离之痛 */)
    {
        giSetObjectVisible("entrance1", false);
        giArenaReadyRestore();
    }
    if (global_mvar != 140801)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void EarthBall()
{
    giPlayerLock();
    giFlashOutBlack(1.0, true, true);
    giPlayerCurrentSetPos(3402.6694, 284.04095, 1569.3074);
    giPlayerCurrentSetAng(298.0);
    giCameraSetMode(5, true);
    giFlashInBlack(1.0, true);
    giArenaReady();
    giPlayerUnLock();
}

void func1001()
{
    giArenaLoad("Q08", "Q08", "", true);
    giPlayerCurrentSetPos(487.51642, -516.4262, 1706.742);
    giPlayerCurrentSetAng(136.0);
    giCameraSetMode(0, true);
    giArenaReady();
}

void func1002()
{
    switch (global_mvar)
    {
        case 91200:
            giArenaLoad("Q06", "Q06Q", "", true);
            break;
        case 101400:
            giFlashOutBlack(0.1, true, false);
            giArenaLoad("Q06", "Q06Q", "", true);
            break;
        case 120100:
            giFlashOutBlack(0.1, true, false);
            giArenaLoad("Q06", "Q06Q", "", true);
            break;
        default:
            if (global_mvar != 101400 && global_mvar != 120100 && global_mvar != 91200 && global_mvar < 131300 || global_mvar >= 140100 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
            {
                if (global_mvar < 160200 || global_mvar >= 161100 /* 第四章 / 9-3-2.君莫思归 / 再访长老 / 生离之痛 */)
                {
                    if (global_mvar < 160200 /* 第四章 / 9-3-2.君莫思归 / 再访长老 / 生离之痛 */)
                    {
                        giArenaLoad("Q06", "Q06Q", "", true);
                        giPlayerCurrentSetPos(19971.604, -1084.9795, -1784.5197);
                        giPlayerCurrentSetAng(144.0);
                        giCameraSetMode(0, true);
                        giArenaReady();
                    }
                    else
                    {
                        giPlayerLock();
                        giPlayerSetLeader(0);
                        giPlayerWalkTo(0, 3397.1924, 284.0496, 1584.1384, true);
                        giPlayerSetDir(0, 292.0, true);
                        giCameraAutoSeek(true);
                        giCameraSetMode(5, true);
                        giSetPortrait("101J", true);
                        giTalk("云天河：<colour red=255 green=187 blue=0 alpha=255>琼华派</colour><dc0>已经升上空中，想要去那里，一定要</dc0><colour red=255 green=187 blue=0 alpha=255>御剑</colour><dc0>才行。</dc0>", "");
                        giPlayerUnLock();
                    }
                }
                else
                {
                    giPlayerLock();
                    giPlayerSetLeader(0);
                    giPlayerWalkTo(0, 3397.1924, 284.0496, 1584.1384, true);
                    giPlayerSetDir(0, 292.0, true);
                    giCameraAutoSeek(true);
                    giCameraSetMode(5, true);
                    giSetPortrait("101J", true);
                    giTalk("云天河：现在不能去琼华派……", "");
                    giPlayerUnLock();
                }
            }
            else
            {
                giPlayerLock();
                giPlayerSetLeader(0);
                giPlayerWalkTo(0, 3397.1924, 284.0496, 1584.1384, true);
                giPlayerSetDir(0, 292.0, true);
                giCameraAutoSeek(true);
                giCameraSetMode(5, true);
                giSetPortrait("101J", true);
                giTalk("云天河：菱纱说<colour red=255 green=187 blue=0 alpha=255>要在封神陵找一件很重要的东西</colour><dc0>，现在暂时不回琼华派。</dc0>", "");
                giPlayerUnLock();
            }
            break;
    }
}

void func2001()
{
    if (global_mvar == 140801)
    {
        giTimeScriptTerminate();
        giPlayerLock();
        giScriptMusicPlay("P68", 2, 2.5, 2.5);
        giMonsterStopPursuit();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giSetNpcVisible("MN001", true);
        giSetNpcVisible("MN002", true);
        giCameraPrepare("MC001");
        giCameraRunSingle("010", true);
        giMonsterSetHide("m12-06-02", false);
        giMonsterSetHide("m12-06-03", false);
        giMonsterSetHide("m12-04-04", false);
        giMonsterSetHide("m12-08-02", false);
        giMonsterSetHide("m12-09-02", false);
        giArenaReady();
        giCGEffPlay(11);
        giCameraRunSingle("001", false);
        giFlashInWhite(2.0, true);
        giWait(3.0);
        giNpcWalkTo("MN002", -424.5569, 3.2184, -1887.6111, true);
        giWait(1.0);
        giSetPortrait("231B", false);
        giTalk("玄霄：夙玉，你果然在此。", "45622");
        giNpcSetDir("MN001", 311.0, true);
        giSetPortrait("232B", true);
        giTalk("夙玉：玄霄师兄……", "45623");
        giWait(1.0);
        giCameraRunSingle("002", true);
        giCameraRunSingle("009", false);
        giWait(0.5);
        giSetPortrait("231B", true);
        giTalk("玄霄：你刚才唱的，那是什么歌？", "45624");
        giSetPortrait("232B", false);
        giTalk("夙玉：咦？师兄对音律也有兴趣？", "45625");
        giNpcDoAction("MN002", "C09", 1, false);
        giSetPortrait("231B", true);
        giTalk("玄霄：我不懂音律，只不过那歌中透着无尽怅然，令我略感好奇罢了。", "45626");
        giNpcEndAction("MN002", true);
        giWait(1.0);
        giCameraRunSingle("012", true);
        giCameraRunSingle("011", false);
        giWait(0.5);
        giSetPortrait("232D", true);
        giTalk("夙玉：……那首歌自然是很哀伤的……", "45627");
        giWait(0.699999988079071);
        giSetPortrait("232D", true);
        giTalk("夙玉：杳杳灵凤，绵绵长归。悠悠我思，永与愿违。万劫无期，何时来飞？", "45628");
        giWait(0.699999988079071);
        giSetPortrait("231A", false);
        giTalk("玄霄：……万劫无期，何时来飞？", "45629");
        giWait(0.5);
        giSetPortrait("231B", false);
        giTalk("玄霄：同门两年，我却不知夙玉你也擅诗赋。", "45630");
        giSetPortrait("232A", true);
        giTalk("夙玉：夙玉哪里会，这不过是源自书中的一个故事，倒让师兄你见笑了。", "45631");
        giSetPortrait("231A", false);
        giTalk("玄霄：哦？是怎样的故事，竟会如此伤情？", "45632");
        giWait(1.0);
        giCameraRunSingle("015", true);
        giCameraRunSingle("016", false);
        giWait(0.5);
        giSetPortrait("232A", false);
        giTalk("夙玉：……道经有云，西方卫罗国蓄有一只灵凤，能化人形。王有长女，字曰配瑛，十分怜爱这只凤凰。", "45633");
        giWait(0.5);
        giSetPortrait("232A", false);
        giTalk("夙玉：数年之后，王女忽而有胎，王觉得古怪，怒而斩下凤头，埋于长林丘中。", "45634");
        giWait(0.5);
        giSetPortrait("232A", false);
        giTalk("夙玉：王女伤心不已，不久之后，诞下一名女婴，女婴落地能言，反而很得王的喜爱。", "45635");
        giWait(0.5);
        giSetPortrait("232A", false);
        giTalk("夙玉：那以后许多年，王女一直郁郁寡欢，某日天降大雪，王女因为思忆灵凤，来到长林丘中，唱起歌来，或许是歌声太过悲戚，感动了天地，灵凤竟死而复生，带着王女一同飞入云端……", "45636");
        giWait(0.699999988079071);
        giSetPortrait("232A", false);
        giTalk("夙玉：好在这个故事总算善始善终，也不负这对有情人了。", "45637");
        giWait(1.0);
        giCameraRunSingle("008", true);
        giWait(0.5);
        giSetPortrait("231C", false);
        giTalk("玄霄：……莫非，在夙玉的心中，也是思念着谁？", "45638");
        giSetPortrait("232C", true);
        giTalk("夙玉：……！", "45639");
        giWait(0.699999988079071);
        giSetPortrait("232D", true);
        giTalk("夙玉：哪里……我不过是见这些凤凰花开得绚丽，便想到了那个关于凤凰的传说。", "45640");
        giSetPortrait("232D", true);
        giTalk("夙玉：平日若是练功累了，我就来这儿看看花，总觉得心中会平静许多，只可惜不能常来……", "45641");
        giSetPortrait("231B", false);
        giTalk("玄霄：为何不能常来？你不必过于顾忌与我修炼双剑之事，虽然眼下我的进境暂时比你快上一些，但是你不可急功躁进，反会欲速则不达。", "45642");
        giCameraRunSingle("004", true);
        giCameraRunSingle("005", false);
        giWait(0.5);
        giSetPortrait("231B", false);
        giTalk("玄霄：你若是喜欢，日后我也可以陪你一同来赏花……", "45643");
        giSetPortrait("232C", true);
        giTalk("夙玉：真的吗，师兄？你愿意和我一起来看凤凰花？", "45644");
        giWait(0.5);
        giSetPortrait("232A", true);
        giTalk("夙玉：我还以为……师兄除去练功之外，唯一喜爱的便是夜观星空。", "45645");
        giSetPortrait("231B", false);
        giTalk("玄霄：天悬银河、繁星灿烂，自然令人望之胸中开阔，不过此地风光秀丽，我也十分喜爱，我们便约好了，闲暇时若有兴致，就来此赏花。", "45646");
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("232B", true);
        giTalk("夙玉：……嗯，师兄，说好了，一言为定。", "45647");
        giNpcEndAction("MN001", true);
        giNpcDoAction("MN002", "C08", 1, false);
        giSetPortrait("231B", false);
        giTalk("玄霄：一言为定。", "45648");
        giWait(2.0);
        giFlashOutWhite(2.5, true, true);
        giCGEffStop();
        global_mvar = 141000; // 0x000226C8
        giCameraRunSingle("010", true);
        giArenaLoad("Q06", "Q06H", "", false);
    }
}

void func3001()
{
    if (global_mvar <= 101400 && global_mvar >= 91400 && npc_d == 1 /* 第二章 / 6-4-5.神农仆众 / 回昆仑琼华派 / 梭罗树仙 */)
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giScriptMusicPlay("P33", 2, 0.0, 0.0);
        giTimeScriptTerminate();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giMonsterSetHide("m12-01-01", false);
        giSetObjectVisible("item101", false);
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 2038.3612, 284.2759, 1740.1299);
        giPlayerSetAng(0, 270.0);
        giPlayerSetVisible(0, true);
        giHideGASkillObject();
        giIMMEnd();
        giCameraPrepare("feng2");
        giCameraRunSingle("001", true);
        giFlashInBlack(1.5, true);
        giSetPortrait("102B", false);
        giTalk("云天河：大哥说的凤凰花，就是这个吧？仔细瞧瞧，还真是挺好看的～", "");
        giWait(1.0);
        giTalk("沐风：……少年人，你是来赏花的吗？", "");
        giCameraRunSingle("002", true);
        giNpcBlendIn("SN001", 2.0, true);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102D", true);
        giTalk("云天河：我……我是来替人摘花的，你是谁？这些花是你的，要钱买？", "");
        giPlayerEndAction(0);
        giCameraRunSingle("003", false);
        giTalk("沐风：我是这棵凤凰树的花仙……已经许多年没有人来赏花了，更不会有人称赞这些花好看……", "");
        giSetPortrait("102A", true);
        giTalk("云天河：这么说起来，你也和我大哥一样，很久没和人讲过话了？", "");
        giWait(0.5);
        giTalk("沐风：……少年人，除了你之外，我还从来没有在凡人面前现身过。", "");
        giWait(0.5);
        giTalk("沐风：……即使……是在许多年前，我也没有勇气和他说上一句话……", "");
        giSetPortrait("102C", true);
        giTalk("云天河：“他”……又是谁啊？", "");
        giCameraRunSingle("004", true);
        giCameraRunSingle("005", false);
        giTalk("沐风：我不知道……我连他叫什么名字都不清楚……那个时候，他和他的师妹常常来这儿赏花，我总是远远地、静静地看着……", "");
        giTalk("沐风：他虽是凡人，修为却意外地和我这个地仙相差无几，我不敢……不敢让他察觉我的气息……", "");
        giWait(0.5);
        giSetPortrait("102C", true);
        giTalk("云天河：我不懂……要是你很想和那个人说话，干嘛不让他看见你呢？", "");
        giWait(0.5);
        giTalk("沐风：……近君情怯，无以能言……何况，即便他看见我，又能如何？他的眼中只有自己的师妹，只有目光投向她时，神情才会变得那样柔和……", "");
        giWait(0.5);
        giTalk("沐风：或许……这便是凡人所说的恋慕之情，我还是未能明白，也永远没有机会明白了……", "");
        giWait(1.0);
        giCameraRunSingle("008", true);
        giSetPortrait("102C", false);
        giTalk("云天河：啊？什么意思？", "");
        giTalk("沐风：五百年的修行功德圆满，我明日便要离开此地，往九重天上而去，位列天女，从此怎敢再有情思牵挂？", "");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("102A", false);
        giTalk("云天河：你说的……我还是有些懂、有些不懂……", "");
        giPlayerEndAction(0);
        giCameraRunSingle("009", true);
        giTalk("沐风：少年人，很谢谢你愿意陪我说说话，既然你是来替人摘花，这截凤凰花枝便送给你。", "");
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("feng01", true);
        giSetObjectVisible("feng-01", true);
        giIMMEnd();
        giSetPortrait("102B", false);
        giTalk("云天河：送我？真的吗？……我也没帮你做什么啊？", "");
        giTalk("沐风：你尚有赤子之心，未曾经历世间劫难，我愿你就这样开心到老，姻缘美满。", "");
        giWait(0.5);
        giTalk("沐风：就此别过——", "");
        giWait(0.5);
        giNpcBlendOut("SN001", 2.0, false);
        giWait(0.5);
        giCameraRunSingle("006", true);
        giCameraRunSingle("007", false);
        giWait(2.0);
        giPlayerDoAction(0, "C07", -1, true);
        giWait(0.5);
        giIMMBegin();
        giSetObjectVisible("feng01", false);
        giSetObjectVisible("feng-01", false);
        giIMMEnd();
        giWait(0.5);
        giPlayerUnHoldAct(0);
        giPlayerEndAction(0);
        giAddProperty(3243, 1, true);
        giWait(2.0);
        giSetPortrait("102A", false);
        giTalk("云天河：（这个人……不知为什么，和大哥有点像……虽然偶尔也会笑，可是好像过得不快活，让人有点替她难过……）", "");
        giWait(0.5);
        giPlayerDoAction(0, "C09", 1, false);
        giSetPortrait("102B", false);
        giTalk("云天河：哎，不想了，<colour red=255 green=187 blue=0 alpha=255>快点回去找大哥～</colour><dc0>他看了这花，一定很高兴，呵呵。</dc0>", "");
        giWait(1.0);
        giFlashOutBlack(1.5, true, true);
        giCameraRunSingle("001", true);
        giIMMBegin();
        giSetObjectVisible("item101", true);
        giPlayerSetVisible(0, false);
        giPlayerCurrentSetVisible(true);
        giPlayerCurrentSetPos(2196.9028, 284.2754, 1725.7632);
        giPlayerCurrentSetAng(122.0);
        npc_d = 2;
        giShowSignpost();
        giIMMEnd();
        giCameraSetMode(0, true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        giTimeScript(180.0, "func9001");
        giScriptMusicStop(1, 2.5);
        giPlayerUnLock();
        giFlashInBlack(1.5, true);
    }
}

void func7001()
{
    if (var_shu == 0)
    {
        giPlayerLock();
        giCameraPrepare("viewBox");
        giCameraRunSingle("viewBox", false);
        giCameraRunSingle("viewBox1", false);
        giMSTBlendIn("m12-07-04", 0.6, true);
        giWait(1.0);
        giMSTBlendIn("m12-07-03", 0.6, true);
        giMSTBlendIn("m12-07-02", 0.6, true);
        giWait(1.0);
        giMSTBlendIn("m12-07-01", 1.0, true);
        giWait(1.2000000476837158);
        giCameraSetMode(5, true);
        giCameraAutoSeek(true);
        giCameraSeekToPlayer();
        giFlushTailYAngle();
        var_shu = 1;
        giPlayerUnLock();
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
