// Structured PAL4 reconstruction for M04.csb
// Only simple if / if-else candidates backed by CFG evidence are folded.

void M04_1_init()
{
    giOpenWeather(9);
    if (global_mvar != 22100 /* 第一章 / 2-3-2.礼请天河 / 离开柳府 */)
    {
        giArenaReadyRestore();
    }
    else
    {
        func2001();
    }
}

void func1001()
{
    giArenaLoad("Q03", "XN03Y", "", true);
    giPlayerCurrentSetPos(16.567957, -0.199997, 41.982555);
    giPlayerCurrentSetAng(180.0);
    giCameraSetMode(3, true);
    giArenaReady();
}

void func2001()
{
    giPlayerLock();
    giCameraSetCollide(false);
    giCameraAutoSeek(false);
    giIMMBegin();
    giPlayerCurrentSetVisible(false);
    giPlayerSetPos(0, 1218.6853, -0.671, 1311.3892);
    giPlayerSetAng(0, 262.0);
    giPlayerSetVisible(0, true);
    giPlayerSetPos(1, 1247.351, -0.6711, 1366.5398);
    giPlayerSetAng(1, 267.0);
    giPlayerSetVisible(1, true);
    giSetObjectVisible("title", false);
    giSetObjectVisible("save2", false);
    giAddPlayerFavor(0, 1, 10);
    giAddPlayerFavor(1, 0, 10);
    giIMMEnd();
    giCameraPrepare("MC001");
    giCameraRunSingle("001", true);
    giFlashInBlack(2.5, false);
    giPlayerWalkTo(0, 1107.0708, -0.6711, 1311.2004, false);
    giPlayerWalkTo(1, 1140.6144, -0.6711, 1368.7423, false);
    giArenaReady();
    giPlayerEndMove(1);
    giPlayerEndMove(0);
    giWait(1.5);
    giPlayerDoAction(0, "J24", 1, false);
    giWait(1.5);
    gi2DSoundPlay("WJ066", 1);
    giSetPortrait("101E", true);
    giTalk("云天河：啊、啊嚏——！！", "41069");
    giCameraRunSingle("002", false);
    giPlayerSetDir(1, 223.0, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：小心！尽量少吸气！这雾有古怪。", "41070");
    giPlayerDoAction(0, "J22", -1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：我来的时候就觉得这柳府不一般，果然——", "41071");
    giPlayerDoAction(1, "J02", -1, false);
    giSetPortrait("103D", false);
    giTalk("韩菱纱：呀——！你做什么？都说了少吸气，你还深呼吸？！", "41072");
    giPlayerUnHoldAct(1);
    giPlayerEndAction(1);
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giSetPortrait("101B", true);
    giTalk("云天河：呵呵，香香的，好闻，就是鼻子痒……", "41073");
    giPlayerDoAction(0, "J24", 1, false);
    giWait(1.5);
    gi2DSoundPlay("WJ066", 1);
    giSetPortrait("101E", true);
    giTalk("云天河：啊嚏！啊嚏！！", "41074");
    giPlayerDoAction(1, "J06", 1, false);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：……自作自受，又不是出门踏青，野人还闻什么花香……听好了，这地方不太对劲，和之前的山野树林不一样，别大意！", "41075");
    giPlayerEndAction(1);
    giWait(0.3);
    giPlayerSetDir(0, 207.0, true);
    giWait(0.3);
    giPlayerDoAction(0, "J13", -1, true);
    giWait(0.3);
    giCameraRunSingle("003", true);
    giWait(0.3);
    giSetPortrait("101B", true);
    giTalk("云天河：咦？<colour red=255 green=187 blue=0 alpha=255>那边有个发光的东西，过去看看～</colour>", "41076");
    giPlayerUnHoldAct(0);
    giPlayerEndAction(0);
    giPlayerRunTo(0, 1009.9736, -0.6711, 1061.2703, false);
    giWait(1.5);
    giPlayerDoAction(1, "J15", -1, false);
    giCameraRunSingle("004", true);
    giSetPortrait("103F", false);
    giTalk("韩菱纱：…………", "41077");
    giSetPortrait("103F", false);
    giTalk("韩菱纱：（可恨！根本没在听……时机不对，我忍！！）", "41078");
    giWait(0.5);
    giFlashOutBlack(1.5, true, true);
    giPlayerEndMove(0);
    giIMMBegin();
    giPlayerSetVisible(0, false);
    giPlayerSetVisible(1, false);
    global_mvar = 22300; // 0x0000571C, 第一章 / 2-4-1.迷香梦绕 / 院中迷路
    giSetObjectVisible("save2", true);
    giIMMEnd();
    giPlayerCurrentSetPos(970.6122, -0.6711, 1026.7485);
    giPlayerCurrentSetAng(199.0);
    giPlayerCurrentSetVisible(true);
    giSetObjectVisible("title", true);
    giCameraSetMode(5, true);
    giCameraSeekToPlayer();
    giFlashInBlack(1.5, true);
    giPlayerUnLock();
}

void func2002()
{
    if (global_mvar == 22300 /* 第一章 / 2-4-1.迷香梦绕 / 院中迷路 */)
    {
        giMonsterStopPursuit();
        giPlayerLock();
        giFlashOutBlack(1.5, true, true);
        giIMMBegin();
        giCameraSetCollide(false);
        giCameraAutoSeek(false);
        giPlayerCurrentSetVisible(false);
        giPlayerSetPos(0, 446.9677, -0.3235, -1476.0447);
        giPlayerSetAng(0, 95.0);
        giPlayerSetVisible(0, true);
        giPlayerSetPos(1, 419.1948, -0.3235, -1430.7311);
        giPlayerSetAng(1, 133.0);
        giPlayerSetVisible(1, true);
        giSetNpcVisible("MN002", true);
        giPlayerSetPos(2, 611.6048, -0.3236, -1788.126);
        giPlayerSetAng(2, 197.0);
        giMonsterSetHide("m04-07-01", false);
        giMonsterSetHide("m04-06-01", false);
        giIMMEnd();
        giArenaReady();
        giNpcDoAction("MN002", "J16", 0, false);
        giCameraPrepare("MC002");
        giCameraRunSingle("002", true);
        giFlashInBlack(1.5, false);
        giScriptMusicPlay("P25", 2, 0.0, 0.0);
        giSetPortrait("101B", true);
        giTalk("云天河：这什么声音？……很好听……", "41079");
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：噤声！那边好像有人！别打草惊蛇！", "41080");
        giPlayerEndAction(1);
        giPlayerWalkTo(0, 548.7952, -0.3235, -1488.7032, false);
        giPlayerWalkTo(1, 586.6346, -0.3235, -1465.8109, false);
        giCameraRunSingle("004", false);
        giPlayerEndMove(0);
        giPlayerSetDir(0, 154.0, false);
        giPlayerEndMove(1);
        giPlayerSetDir(1, 195.0, true);
        giWait(0.6);
        giCameraWait();
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：喂～～～前面的人～～～", "41081");
        giSetPortrait("101B", true);
        giTalk("云天河：这么大的雾，我们好像迷路了～你知不知道出口在哪？", "41082");
        giPlayerWalkTo(1, 561.2173, -0.3235, -1471.7928, true);
        giPlayerSetDir(1, 195.0, true);
        giPlayerDoAction(1, "J20", 1, false);
        giWait(0.2);
        gi2DSoundPlay("WJ012", 1);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：你白痴啊！！我不是说要谨慎行事？哪有这样直接打招呼的，万一是陷阱怎么办？！", "41083");
        giPlayerSetDir(0, 21.0, true);
        giWait(0.3);
        giSetPortrait("101B", true);
        giTalk("云天河：呵呵，不会～她不是坏人。", "41084");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：哼，你又知道了。", "41085");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101K", true);
        giTalk("云天河：因为没有杀气啊～", "41086");
        giCameraRunSingle("003", false);
        giCameraWait();
        giWait(0.3);
        giCameraRunSingle("005", true);
        giWait(0.6);
        giTalk("？？：梦影雾花，尽是虚空，因心想杂乱，方随逐诸尘——", "41087");
        giSetObjectVisible("Jeffect001", true);
        giNpcDoAction("MN002", "J17", 1, false);
        giTalk("？？：不如～万～般～皆～散！", "41088");
        giCloseWeather();
        giNpcEndAction("MN002", true);
        giNpcDoAction("MN002", "C01", 0, false);
        giWait(0.5);
        giPlayerSetVisible(2, true);
        giSetNpcVisible("MN002", false);
        giPlayerSetDir(2, 34.0, false);
        giWait(0.5);
        giCameraRunSingle("006", false);
        giSetPortrait("106A", true);
        giTalk("？？：这“千华灵幻之阵”对人无害的，没想到你们用了这么久才出阵——", "41089");
        giIMMBegin();
        giPlayerSetPos(0, 811.8018, -0.3235, -1536.5935);
        giPlayerSetAng(0, 218.0);
        giPlayerSetPos(1, 760.5401, -0.3235, -1519.9387);
        giPlayerSetAng(1, 209.0);
        giIMMEnd();
        giPlayerRunTo(1, 643.9106, -0.3235, -1697.9279, false);
        giPlayerRunTo(0, 698.5276, -0.3235, -1711.4918, false);
        giPlayerEndMove(0);
        giPlayerEndMove(1);
        giIMMBegin();
        giPlayerSetDir(1, 202.0, false);
        giPlayerSetDir(0, 233.0, false);
        giIMMEnd();
        giWait(0.8);
        giSetPortrait("101D", false);
        giTalk("云天河：你……", "41090");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：哼，你谁啊？凭什么把人当猴耍？还说无害，那些臭女人、臭灯笼打在我身上还不是一样痛！", "41091");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giCameraRunSingle("007", true);
        giPlayerSetDir(1, 108.0, true);
        giWait(0.3);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：喂，我说的对不对？", "41092");
        giSetPortrait("101D", true);
        giTalk("云天河：……", "41093");
        giPlayerDoAction(1, "J17", -1, false);
        giSetPortrait("103I", false);
        giTalk("韩菱纱：喂！！", "41094");
        giSetPortrait("101D", true);
        giTalk("云天河：…………", "41095");
        giSetPortrait("103I", false);
        giTalk("韩菱纱：看的眼珠都快掉出来了！有这么好看吗？", "41096");
        giSetPortrait("101D", true);
        giTalk("云天河：啊？！", "41097");
        giPlayerSetDir(0, 278.0, true);
        giWait(0.3);
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101F", true);
        giTalk("云天河：没……没…………好看……", "41098");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerSetDir(1, 202.0, true);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103F", false);
        giTalk("韩菱纱：哼，你少瞧不起人，我旁边这家伙虽然看起来傻乎乎，内功却深不可测，一拳能打死三头熊。", "41099");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("101H", true);
        giTalk("云天河：呃，菱纱……", "41100");
        giSetPortrait("103F", false);
        giTalk("韩菱纱：至于我嘛，更是纵横江湖多年的侠女，手下败将无数，刚才只不过疏忽大意了，要不然……哼哼～～", "41101");
        giPlayerDoAction(0, "J05", 1, false);
        giSetPortrait("101H", true);
        giTalk("云天河：菱纱，不可能只用拳头就打死熊吧……山猪还可以试试……", "41102");
        giCameraRunSingle("008", true);
        giWait(0.5);
        giPlayerFaceToPlayer(0, 2, false);
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", false);
        giTalk("？？：云公子，你爹，他还好吗？", "41103");
        giCameraRunSingle("009", true);
        giWait(0.3);
        giSetPortrait("101A", true);
        giTalk("云天河：你也认识我爹？……我不知道他现在好不好，他病死很久了。", "41104");
        giSetPortrait("106E", false);
        giTalk("？？：云叔过世了？！", "41105");
        giSetPortrait("106F", false);
        giTalk("？？：……怎么会这样……当年他在祸乱中救我一命，我一直想再找到他、报答他。", "41106");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101C", true);
        giTalk("云天河：你是柳波波的女儿？", "41107");
        giPlayerEndAction(0);
        giPlayerDoAction(2, "C08", 1, false);
        giSetPortrait("106F", false);
        giTalk("？？：我叫柳梦璃。", "41108");
        giCameraRunSingle("010", true);
        giWait(0.3);
        giPlayerDoAction(1, "C07", 1, false);
        giCameraRunSingle("011", false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：啊，明白了！原来你就是那个半老徐娘？！", "41109");
        giPlayerSetDir(2, 20.0, true);
        giPlayerDoAction(1, "J05", 1, false);
        giSetPortrait("103D", false);
        giTalk("韩菱纱：不不不，我是说大小姐，既然也算故人，你又何必设下迷障为难我们呢？", "41110");
        giSetPortrait("106F", true);
        giTalk("柳梦璃：对不起，我听说他是云叔的儿子，就想试试他的功力，而且我想问他云叔现在过得好不好。因为爹什么也不肯告诉我，说是等到明天再谈……", "41111");
        giSetPortrait("103C", false);
        giTalk("韩菱纱：那个……你被救的时候年纪应该很小，居然记得是谁救你？", "41112");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：嗯……万物生而具备五灵，就算是幼儿，也有他们自己的方法感知外界，只是凡人懵憧，成年后反而自闭视听，变得无感无知。", "41113");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101E", false);
        giTalk("云天河：……不太明白，好难懂……", "41114");
        giPlayerEndAction(0);
        giPlayerSetDir(0, 283.0, true);
        giSetPortrait("101E", false);
        giTalk("云天河：菱纱，你听懂了吗？", "41115");
        giWait(0.5);
        giSetNpcVisible("MN001", true);
        giTalk("柳世封：贤侄呐～", "41116");
        giCameraRunSingle("012", true);
        giCameraRunSingle("013", false);
        giIMMBegin();
        giWait(0.5);
        giPlayerSetDir(0, 32.0, false);
        giPlayerSetDir(1, 54.0, false);
        giPlayerSetDir(2, 47.0, false);
        giIMMEnd();
        giSetPortrait("205A", false);
        giTalk("柳世封：贤侄，我去找你，本想秉烛夜谈，你怎么跑到璃儿这边来了？", "41117");
        giCameraWait();
        giWait(0.8);
        giSetPortrait("205A", false);
        giTalk("柳世封：莫非、莫非你和小女，你们已经私订终身？！", "41118");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：爹，您别胡思乱想，我看云家公子和这位姑娘都无意在府上久留，不如打点打点，让他们随意离去吧。", "41119");
        giSetPortrait("205A", false);
        giTalk("柳世封：我说女儿啊，那怎么行！", "41120");
        giCameraRunSingle("014", true);
        giNpcSetPos("MN001", 833.8353, -0.3235, -1597.9987);
        giNpcSetAng("MN001", 222.0);
        giNpcRunTo("MN001", 678.4155, -0.3235, -1771.714, false);
        giWait(1.0);
        giIMMBegin();
        giPlayerSetDir(0, 194.0, false);
        giPlayerSetDir(1, 152.0, false);
        giPlayerSetDir(2, 77.0, false);
        giIMMEnd();
        giWait(0.7);
        giNpcEndMove("MN001");
        giNpcSetDir("MN001", 260.0, true);
        giSetPortrait("205A", false);
        giTalk("柳世封：天河是爹千挑万选才帮你看中的夫婿，他可是你云叔叔的儿子——", "41121");
        giPlayerDoAction(2, "C07", -1, false);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：爹，既然您知道云叔是我心中的大英雄、大恩人，那又怎么可能有人比得上他。", "41122");
        giPlayerUnHoldAct(2);
        giPlayerEndAction(2);
        giSetPortrait("106F", true);
        giTalk("柳梦璃：更何况仰慕之意不同儿女之情，终身大事，女儿想要自己作主……", "41123");
        giNpcDoAction("MN001", "J01", 1, false);
        giSetPortrait("205A", false);
        giTalk("柳世封：这……好好好～爹都依你，哈哈，璃儿高兴就好。", "41124");
        giNpcEndAction("MN001", false);
        giCameraRunSingle("015", true);
        giWait(0.3);
        giPlayerDoAction(1, "J13", -1, false);
        giSetPortrait("103A", true);
        giTalk("韩菱纱：嘻嘻，见过怕老婆的，还没见过怕女儿的呢～", "41125");
        giIMMBegin();
        giNpcSetDir("MN001", 327.0, false);
        giPlayerSetDir(2, 42.0, false);
        giIMMEnd();
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("205A", false);
        giTalk("柳世封：这位姑娘是……？三更半夜怎会出现在柳府？", "41126");
        giSetPortrait("101B", true);
        giTalk("云天河：柳波波，我和菱纱要走了，以后再来找你玩～", "41127");
        giNpcSetDir("MN001", 24.0, true);
        giSetPortrait("205A", false);
        giTalk("柳世封：她、她便是那个女贼？！如此说来，带罪之身岂能四处乱跑！这位姑娘理应回到衙门，听候发落。", "41128");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：什么“贼”！我可是堂堂正正的“大盗”，听清楚哦，是大～盗～！！", "41129");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giNpcFaceToPlayer("MN001", 1, true);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：再说我不偷不抢活人的东西，死人都已经入土了，那些陪葬的瓶瓶罐罐根本用不上，把它们拿来帮助更需要的人，又有什么错？！", "41130");
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("205A", false);
        giTalk("柳世封：这、这……全是歪理、全是歪理呐！", "41131");
        giNpcEndAction("MN001", true);
        giSetPortrait("101H", true);
        giTalk("云天河：柳波波，到底为什么？你不让菱纱走，我们就不能一起去修仙了。", "41132");
        giNpcSetDir("MN001", 24.0, true);
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("205A", false);
        giTalk("柳世封：贤侄，你不明白……", "41133");
        giSetPortrait("205A", false);
        giTalk("柳世封：唉！这叫我如何是好！", "41134");
        giPlayerSetDir(2, 71.0, true);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：唔……爹，女儿倒有一个办法。", "41135");
        giIMMBegin();
        giNpcSetDir("MN001", 261.0, false);
        giPlayerSetDir(1, 201.0, false);
        giIMMEnd();
        giSetPortrait("205A", false);
        giTalk("柳世封：哦？快说来听听！ ", "41136");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：我今早刚听说……近来寿阳附近的女萝岩时有妖怪出没，您十分伤神，不如让韩姑娘他们和我一同去探查此事，若是解决了，韩姑娘就算为地方上做件大好事，您放了她倒也说的过去。", "41137");
        giPlayerDoAction(1, "J16", 1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：成交！就这么说定了！", "41138");
        giNpcDoAction("MN001", "C09", 1, false);
        giSetPortrait("205A", false);
        giTalk("柳世封：不行！万万不可！这一着太过凶险，你们几个年纪还小，怎能、怎能担此重任？", "41139");
        giPlayerDoAction(2, "J13", 1, false);
        giSetPortrait("106A", true);
        giTalk("柳梦璃：爹，您不用担心，女儿自有分寸。何况云公子和韩姑娘也都是身怀绝技之人，大家小心一点，不至于有什么闪失。", "41140");
        giPlayerEndAction(2);
        giSetPortrait("205A", false);
        giTalk("柳世封：但是……", "41141");
        giSetPortrait("106A", true);
        giTalk("柳梦璃：爹，您不相信女儿吗？", "41142");
        giSetPortrait("205A", false);
        giTalk("柳世封：这……", "41143");
        giNpcDoAction("MN001", "C08", 1, false);
        giSetPortrait("205A", false);
        giTalk("柳世封：唉，就按璃儿所说吧，你们务必要谨慎行事。璃儿你虽然天生具有灵力，也不可疏忽大意呐。", "41144");
        giNpcEndAction("MN001", true);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：（……可怜的老爹……连反对都这么软弱无力，真是孝儿呀……孝、顺、女、儿……）", "41145");
        giPlayerDoAction(0, "J18", 1, false);
        giSetPortrait("101B", true);
        giTalk("云天河：要去打妖怪？好啊好啊～上回输给那些家伙，这次可不会再输了！", "41146");
        giPlayerEndAction(0);
        giIMMBegin();
        giPlayerSetDir(1, 109.0, false);
        giPlayerSetDir(2, 42.0, false);
        giNpcSetDir("MN001", 23.0, false);
        giIMMEnd();
        giWait(0.8);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103M", true);
        giTalk("韩菱纱：笨蛋！你高兴个什么劲？天底下的妖怪又不是只有一种。", "41147");
        giPlayerEndAction(1);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：…………", "41148");
        giNpcDoAction("MN001", "J01", 1, false);
        giSetPortrait("205A", false);
        giTalk("柳世封：哈哈，贤侄有此斗志，实在难得！", "41149");
        giSetPortrait("205A", false);
        giTalk("柳世封：我这就去吩咐下人把别间客房收拾收拾，让韩姑娘歇息。", "41150");
        giNpcEndAction("MN001", true);
        giCameraRunSingle("016", false);
        giNpcWalkTo("MN001", 861.8132, -0.3236, -1721.4968, false);
        giWait(0.5);
        giIMMBegin();
        giPlayerSetDir(1, 98.0, false);
        giPlayerSetDir(2, 76.0, false);
        giPlayerSetDir(0, 98.0, false);
        giIMMEnd();
        giWait(0.6);
        giNpcEndMove("MN001");
        giWait(0.3);
        giIMMBegin();
        giPlayerSetDir(1, 199.0, false);
        giPlayerSetDir(0, 216.0, false);
        giIMMEnd();
        giWait(0.7);
        giPlayerSetDir(2, 42.0, true);
        giWait(0.7);
        giPlayerDoAction(2, "J07", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：我也回房了，两位请自便。", "41151");
        giPlayerEndAction(2);
        giPlayerWalkTo(2, 595.2087, -0.3236, -1830.8253, false);
        giWait(0.15);
        giPlayerDoAction(1, "C07", -1, false);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：哎～等等。", "41152");
        giPlayerEndMove(2);
        giWait(0.3);
        giPlayerSetDir(2, 33.0, true);
        giWait(0.3);
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：不管怎么说，谢谢你替我解围，我可不想再回那个破烂牢房。", "41153");
        giPlayerDoAction(2, "C09", 1, false);
        giSetPortrait("106A", false);
        giTalk("柳梦璃：你太客气了，以你的身手就算要逃，我爹又有什么办法呢？你顺水推舟，愿意帮忙，是我要感谢这份善心。", "41154");
        giPlayerEndAction(2);
        giPlayerWalkTo(2, 527.801, 8.9631, -1910.993, true);
        giPlayerSetVisible(2, false);
        giScriptMusicStop(0, 2.5);
        giScriptMusicPlay("P23", 2, 2.5, 2.5);
        giWait(1.0);
        giPlayerDoAction(1, "J13", 1, false);
        giSetPortrait("103B", true);
        giTalk("韩菱纱：……哈、哈哈，这柳府果然有意思，一个呆呆的老爹，加上一个神神秘秘的女儿，倒是和山顶野人挺相称的～", "41155");
        giPlayerEndAction(1);
        giPlayerSetDir(1, 107.0, true);
        giSetPortrait("103C", true);
        giTalk("韩菱纱：咦？天河？", "41156");
        giWait(1.0);
        giPlayerWalkTo(1, 648.1628, -0.3235, -1745.722, true);
        giCameraRunSingle("017", false);
        giPlayerSetDir(1, 52.0, true);
        giWait(0.3);
        giPlayerDoAction(1, "J06", 1, false);
        giSetPortrait("103J", true);
        giTalk("韩菱纱：回～神～啦～～人都走光了。", "41157");
        giPlayerEndAction(1);
        giSetPortrait("101C", false);
        giTalk("云天河：啊？", "41158");
        giSetPortrait("103J", true);
        giTalk("韩菱纱：哼，在想什么呢？", "41159");
        giPlayerDoAction(0, "J14", 1, false);
        giSetPortrait("101B", false);
        giTalk("云天河：我……我跟你说～这里的饭菜好吃得不得了！我们多住几天，又能多吃几天咧～～", "41160");
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……你刚才……一直不说话……都在想这些？", "41161");
        giSetPortrait("101B", false);
        giTalk("云天河：对啊，你说要离开柳家的时候，我真有点难过。", "41162");
        giPlayerDoAction(0, "J15", 0, false);
        giSetPortrait("101H", false);
        giTalk("云天河：那么好吃的饭菜，以后要是吃不到了可怎么办？……", "41163");
        giSetPortrait("101K", false);
        giTalk("云天河：真的好好吃啊～～～", "41164");
        giPlayerEndAction(0);
        giPlayerDoAction(1, "J04", 1, false);
        giSetPortrait("103E", true);
        giTalk("韩菱纱：……我、我一定是哪里不小心得罪了老天爷，才会遇到这家伙，这都是报应……", "41165");
        giSetPortrait("101B", false);
        giTalk("云天河：菱纱，你怎么了？干嘛自己和自己说话？", "41166");
        giPlayerDoAction(1, "J01", -1, false);
        giSetPortrait("103F", true);
        giTalk("韩菱纱：你走开啦！我不要认识脑袋里只装食物的人！我要跟你拆伙！", "41167");
        giPlayerUnHoldAct(1);
        giPlayerEndAction(1);
        giPlayerRunTo(1, 662.6783, -0.3236, -1526.0282, false);
        giCameraRunSingle("018", false);
        giWait(0.4);
        giPlayerSetDir(0, 342.0, true);
        giPlayerEndMove(1);
        giWait(0.7);
        giPlayerDoAction(0, "J19", 1, false);
        giSetPortrait("101D", false);
        giTalk("云天河：喂～～～你不是要我走开吗？为什么变成你走开啊啊啊？", "41168");
        giPlayerDoAction(0, "J14", 1, false);
        giWait(0.5);
        giFlashOutBlack(1.5, true, true);
        global_mvar = 22400; // 0x00005780
        giPlayerOutTeam(1, false);
        giSetObjectVisible("Jeffect001", false);
        giSetNpcVisible("MN001", false);
        giArenaLoad("Q03", "XN03Y", "", false);
    }
}

void func7001()
{
    int random_1_5 = 0;
    int leader_player_id = 0;
    int local_4 = 0;

    giPlayerLock();
    random_1_5 = giGetRandnum(1, 5);
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    if (giGetRandnum(1, 5) <= 5)
    {
        if (local_4 >= 1)
        {
            giPlayerCurrentSetPos(-1010.463, -0.671106, 1354.0293);
            giPlayerCurrentSetAng(357.0);
        }
    }
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7002()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(-1010.463, -0.671106, 1354.0293);
    giPlayerCurrentSetAng(357.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7003()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(-1099.0139, -0.671106, 489.55978);
    giPlayerCurrentSetAng(270.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7004()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(-5.31661, -0.671106, 1058.0408);
    giPlayerCurrentSetAng(357.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7005()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(984.19135, -0.671108, 1378.6823);
    giPlayerCurrentSetAng(90.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7006()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(932.942, -0.671106, 494.85803);
    giPlayerCurrentSetAng(180.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7007()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(699.91486, -0.671108, -203.30919);
    giPlayerCurrentSetAng(1.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7008()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(-465.48056, -0.671106, -216.15585);
    giPlayerCurrentSetAng(87.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7009()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(-874.83203, -0.323545, -1056.125);
    giPlayerCurrentSetAng(356.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}

void func7010()
{
    int leader_player_id = 0;

    giPlayerLock();
    giEffectPlayWithCurrentPlayer("H_121", 1);
    gi2DSoundPlay("wc005", 1);
    leader_player_id = giPlayerGetLeader();
    giPlayerBlendOut(leader_player_id, 0.5, false);
    giWait(0.30000001192092896);
    giFlashOutBlack(0.65, true, true);
    giWait(0.5);
    giPlayerCurrentSetPos(-323.56113, -0.323542, -1420.5624);
    giPlayerCurrentSetAng(179.0);
    giArenaReady();
    giCameraSetMode(5, true);
    giFlushTailYAngle();
    giFlashInBlack(0.65, false);
    giWait(0.15000000596046448);
    giEffectPlayWithCurrentPlayer("H_122", 1);
    gi2DSoundPlay("wc006", 1);
    giWait(0.30000001192092896);
    giPlayerBlendIn(leader_player_id, 0.5, false);
    giPlayerUnLock();
}
