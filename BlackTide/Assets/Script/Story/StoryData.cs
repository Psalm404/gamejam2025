using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class StoryData
{
    public static List<DialogSequence> dialogSequences = new List<DialogSequence>();

    public static void Init()
    {
        DialogSequence s1 = new DialogSequence(0, 1, GameState.SceneGame);
        s1.AddDialog(new Dialog("小夫", "嗯、嗯，您放心，我明天的东西都准备好了。", 1));
        s1.AddDialog(new Dialog("小夫", "肯定会有很好的呈现的。", 1));
        s1.AddDialog(new Dialog("小夫", "辛苦您这么晚了还打电话来问候，您快休息。", 1));
        s1.AddDialog(new Dialog("小夫", "哈……哈，好的，我一定注意身体。", 1));
        dialogSequences.Add(s1);

        DialogSequence s2 = new DialogSequence(1, 2, GameState.SceneGame);
        s2.AddDialog(new Dialog("小夫", "刚想喝点麻醉一下……"));
        s2.AddDialog(new Dialog("小夫", "我哪知道该做什么……"));
        s2.AddDialog(new Dialog("小夫", "拿往年的套话拼一拼呗……"));
        dialogSequences.Add(s2);

        DialogSequence s3 = new DialogSequence(2, 3, GameState.SceneGame);
        s3.AddDialog(new Dialog("小夫", "公司产业整合顺利，集群化程度显著提高。"));
        dialogSequences.Add(s3);

        DialogSequence s4 = new DialogSequence(3, 4, GameState.SceneGame);
        s4.AddDialog(new Dialog("小夫", "企业发展势头迅猛，年度营收迈上新台阶。"));
        s4.AddDialog(new Dialog("小夫", "哈……净说些谁都不信的话……"));
        s4.AddDialog(new Dialog("小夫", "再找点数据支撑吧……"));
        dialogSequences.Add(s4);

        DialogSequence s5 = new DialogSequence(4, 5, GameState.SceneGame);
        s5.AddDialog(new Dialog("小夫", "较去年同期同比增长……"));
        dialogSequences.Add(s5);

        DialogSequence s6 = new DialogSequence(5, 6, GameState.SceneGame);
        s6.AddDialog(new Dialog("小夫", "企业于全行业居于龙头地位，占领50%以上市场份额……"));
        s6.AddDialog(new Dialog("小夫", "呵，跟打工人有什么关系"));
        s6.AddDialog(new Dialog("小夫", "还不是要半夜加班……"));
        s6.AddDialog(new Dialog("小夫", "不过本来也吃不下、睡不着。"));
        s6.AddDialog(new Dialog("小夫", "最近真不知道怎么了……"));
        s6.AddDialog(new Dialog("小夫", "还是喝点麻醉一下吧。调制饮料，改变人生……"));
        dialogSequences.Add(s6);

        DialogSequence s7 = new DialogSequence(6, 7, GameState.SceneGame);
        s7.AddDialog(new Dialog("小夫", "好久好久都感觉不到快乐了……"));
        s7.AddDialog(new Dialog("小夫", "只有喝醉的时候，心里会涌起没来由的快乐……"));
        s7.AddDialog(new Dialog("小夫", "我之前可是滴酒不沾的，哈哈……"));
        dialogSequences.Add(s7);

        DialogSequence s8 = new DialogSequence(7, 8, GameState.SceneGame);
        s8.AddDialog(new Dialog("小夫", "火辣辣的、苦、酸，就是这个感觉……"));
        s8.AddDialog(new Dialog("小夫", "这不就是我的人生吗，哈哈"));
        s8.AddDialog(new Dialog("小夫", "与其说是喝酒寻求快乐，不如说是在惩罚自己……"));
        dialogSequences.Add(s8);

        DialogSequence s9 = new DialogSequence(8, 9, GameState.SceneGame);
        s9.AddDialog(new Dialog("小夫", "喝的有点猛，上头了，哈哈……"));
        dialogSequences.Add(s9);

        DialogSequence s10 = new DialogSequence(9, 10, GameState.LastSceneGame);
        s10.AddDialog(new Dialog("小夫", "晕了，先把做了的关了，点一下叉……"));
        dialogSequences.Add(s10);

        DialogSequence s11 = new DialogSequence(10, 11, GameState.MiniGame);
        s11.AddDialog(new Dialog("小夫", "情绪涌起来了……不要……这种时候不行……"));
        s11.AddDialog(new Dialog("小夫", "快压下去……"));
        dialogSequences.Add(s11);

        DialogSequence s12 = new DialogSequence(11, 12, GameState.MiniGame);
        s12.AddDialog(new Dialog("小夫", "(还是……压不住啊……"));
        dialogSequences.Add(s12);


        //序章到上编过渡

        DialogSequence g1 = new DialogSequence(12, 13, GameState.SceneGame);
        g1.AddDialog(new Dialog("小夫", "我感到我被一直拉下去，我也不知道会去哪里……", 7));
        g1.AddDialog(new Dialog("小夫", "无边的黑暗……不停的下坠……", 7));
        g1.AddDialog(new Dialog("小夫", "我……（哽咽抽泣）", 8));
        g1.AddDialog(new Dialog("小夫", "对不起……我不该这样", 9));
        g1.AddDialog(new Dialog("？？？", "没关系。放松，一切会好起来的。", 10));
        g1.AddDialog(new Dialog("？？？", "你还好吗？放轻松，擦一下眼泪吧。", 10));
        dialogSequences.Add(g1);

        DialogSequence g2 = new DialogSequence(13, 14, GameState.MiniGame);
        g2.AddDialog(new Dialog("？？？", "擦擦眼泪吧……"));
        dialogSequences.Add(g2);

        DialogSequence g3 = new DialogSequence(14, 15, GameState.SceneGame);
        g3.AddDialog(new Dialog("？？？", "保管好好不好，不要乱丢哦。"));
        g3.AddDialog(new Dialog("小夫", "好……"));
        dialogSequences.Add(g3);


        DialogSequence g4 = new DialogSequence(15, 16, GameState.SceneGame);
        g4.AddDialog(new Dialog("小夫", "谢谢你……", 15));
        g4.AddDialog(new Dialog("？？？", "抱歉，刚才让你想起了难过的回忆。听起来你上一次情绪发作真的很难受……", 15));
        g4.AddDialog(new Dialog("？？？", "我们再聊点其他关于你过去的事情，好吗？", 15));
        g4.AddDialog(new Dialog("小夫", "好的……谢谢您。", 15));
        dialogSequences.Add(g4);

        //上编
        DialogSequence f1 = new DialogSequence(200, 16, GameState.LastSceneGame);
        f1.AddDialog(new Dialog("小夫", "对不起……都怪我不好。"));
        f1.AddDialog(new Dialog("小夫", "对不起，都是我的错。"));
        f1.AddDialog(new Dialog("小夫", "我不该不听话……"));
        f1.AddDialog(new Dialog("小夫", "对不起，都怪我……"));
        f1.AddDialog(new Dialog("咨询师", "别害怕，你的恐惧在骗你。"));
        f1.AddDialog(new Dialog("咨询师", "都过去了。它们看似强大，其实很脆弱，像泡泡一样。"));
        f1.AddDialog(new Dialog("咨询师", "你已经从那些黑暗的时刻里走过来了，你已经战胜他们了。"));
        f1.AddDialog(new Dialog("咨询师", "你还记得吗？"));
        f1.AddDialog(new Dialog("咨询师", "打破他们，相信自己。"));
        dialogSequences.Add(f1);

        DialogSequence f2 = new DialogSequence(201, 16, GameState.LastSceneGame);
        f2.AddDialog(new Dialog("咨询师", "你已经战胜他们了，只不过这段记忆被它们留下的痛苦蒙蔽了，清理掉这些污浊吧。"));
        dialogSequences.Add(f2);

        DialogSequence f3 = new DialogSequence(202, 16, GameState.LastSceneGame);
        f3.AddDialog(new Dialog("咨询师", "你还记得你当时怎么战胜这些痛苦的吗？"));
        dialogSequences.Add(f3);

        DialogSequence f4 = new DialogSequence(203, 16, GameState.LastSceneGame);
        f4.AddDialog(new Dialog("咨询师", "把负能量击碎，我相信你。"));
        dialogSequences.Add(f4);

        //上下过渡

        DialogSequence t1 = new DialogSequence(16, 17, GameState.Dialog);
        t1.AddDialog(new Dialog("咨询师", "……我好心疼你。"));
        t1.AddDialog(new Dialog("咨询师", "这么久以来，辛苦啦。"));
        t1.AddDialog(new Dialog("咨询师", "一个人承受了这么多，一次又一次的倒下再爬起来……"));
        t1.AddDialog(new Dialog("小夫", "谢谢您。"));
        t1.AddDialog(new Dialog("小夫", "我在过去经历过很多痛苦。"));
        t1.AddDialog(new Dialog("小夫", "最艰难的时刻，我读了很多人文学科的书。"));
        t1.AddDialog(new Dialog("小夫", "是人文学界救了我。"));
        dialogSequences.Add(t1);

        DialogSequence t2 = new DialogSequence(17, 18, GameState.Dialog);
        t2.AddDialog(new Dialog("小夫", "……"));
        t2.AddDialog(new Dialog("小夫", "不对……我的确是受人文关怀的吸引去了人文学界。"));
        t2.AddDialog(new Dialog("小夫", "但我记得我在那里很痛苦，那里很多人没有人文关怀。"));
        t2.AddDialog(new Dialog("小夫", "我期待的其实是人文关怀，是爱。"));
        t2.AddDialog(new Dialog("小夫", "不对，那我是怎么从无边的痛苦中熬过来的……"));
        t2.AddDialog(new Dialog("咨询师", "关键还是你自己啦，没有人能代替你承受这一切。"));
        dialogSequences.Add(t2);

        DialogSequence t3 = new DialogSequence(18, 20, GameState.SceneGame);
        t3.AddDialog(new Dialog("小夫", "一定是有个人，给了我很多爱，带我走出这一切。"));
        t3.AddDialog(new Dialog("小夫", "我好像记得她对我的意义，给予我的支持……"));
        t3.AddDialog(new Dialog("小夫", "但她是谁？到底长什么样子……"));
        t3.AddDialog(new Dialog("小夫", "我记不清了"));
        t3.AddDialog(new Dialog("咨询师", "记不清就不要回忆了……不一定什么事情都要想起来的……"));
        t3.AddDialog(new Dialog("小夫", "不，我感到她对我很重要……"));
        t3.AddDialog(new Dialog("咨询师", "有时候该忘就忘记吧……也许想起来你会痛苦的"));
        t3.AddDialog(new Dialog("小夫", "不。我清晰的记得她的存在，那一幕幕……"));
        dialogSequences.Add(t3);


        //下编
        DialogSequence p1 = new DialogSequence(20, 21, GameState.SceneGame);
        p1.AddDialog(new Dialog("小日", "《隋唐制度渊源略论稿》……"));
        p1.AddDialog(new Dialog("小日", "你也是历史系来的吗 ?"));
        dialogSequences.Add(p1);

        DialogSequence p2 = new DialogSequence(21, 22, GameState.SceneGame);
        p2.AddDialog(new Dialog("小夫", "啊没有没有……我是理工科转来的，对历史感兴趣而已啦。"));
        p2.AddDialog(new Dialog("小日", "我就是感觉没见过你嘛。"));
        p2.AddDialog(new Dialog("小日", "还是第一次在人文实验班里遇到和我一样做历史的呢。"));
        p2.AddDialog(new Dialog("小日", "(浅笑)我叫小日，历史系来的。"));
        p2.AddDialog(new Dialog("小夫", "你是历史系来的? 你就是那个专业第一吗?"));
        p2.AddDialog(new Dialog("小日", "那都是过去的事儿了。以后大家多交流哦。"));
        p2.AddDialog(new Dialog("小夫", "不敢不敢。都说进入人文实验班就是提前进入了学术圈，果然都是像你这样的精英啊。要多向你们学习呀。"));
        p2.AddDialog(new Dialog("小日", "过谦了。"));
        p2.AddDialog(new Dialog("小日", "不过说回来，如果是理工科转过来的，可能真的要补补专业课。"));
        p2.AddDialog(new Dialog("小日", "你有《古籍概要》吗 ?"));
        p2.AddDialog(new Dialog("小夫", "啊我买了……"));
        dialogSequences.Add(p2);

        DialogSequence p3 = new DialogSequence(22, 23, GameState.MiniGame);
        p3.AddDialog(new Dialog("小夫", "还挺新的，看不太明白...."));
        p3.AddDialog(new Dialog("小日", "没关系的，你有这个补课的意识就真的很超前了。"));
        p3.AddDialog(new Dialog("小日", "如果你不嫌弃的话，我之前曾经看过配套的网课，记了一些笔记，可以供你参考。"));
        dialogSequences.Add(p3);

        DialogSequence p4 = new DialogSequence(23, 24, GameState.SceneGame);
        p4.AddDialog(new Dialog("小夫", "啊太谢谢了，你的字真漂亮……"));
        p4.AddDialog(new Dialog("小日", "不客气哦，以后多交流。"));
        p4.AddDialog(new Dialog("小日", "嗯嗯……"));
        dialogSequences.Add(p4);

        DialogSequence p5 = new DialogSequence(24, 25, GameState.SceneGame);
        p5.AddDialog(new Dialog("小日", "看不出来，你正经起来还挺有范的嘛。"));
        p5.AddDialog(new Dialog("小日", "论文答辩的时候，讲起来还挺有魅力的。"));
        p5.AddDialog(new Dialog("小日", "(低头浅笑)你很适合穿衬衫。"));
        p5.AddDialog(new Dialog("小夫", "哈哈…谢谢。也要谢谢你借我的领带，我之前的领带像销售。"));
        dialogSequences.Add(p5);

        DialogSequence p6 = new DialogSequence(25, 26, GameState.Dialog);
        p6.AddDialog(new Dialog("小夫", "你的领带，我洗好晾干了，收在这里面。"));
        p6.AddDialog(new Dialog("小日", "你好贴心……"));
        p6.AddDialog(new Dialog("小日", "居然还帮我洗了。"));
        p6.AddDialog(new Dialog("小日", "你也没那么不靠谱嘛……"));
        dialogSequences.Add(p6);

        DialogSequence p7 = new DialogSequence(26, 27, GameState.SceneGame);
        p7.AddDialog(new Dialog("小夫", "哈哈……"));
        p7.AddDialog(new Dialog("小夫", "……那个，谢谢你。"));
        p7.AddDialog(new Dialog("小日", "怎么突然说这个。"));
        p7.AddDialog(new Dialog("小夫", "谢谢你愿意抱着善意对我"));
        p7.AddDialog(new Dialog("小夫", "你也没传说的那么难相处嘛…"));
        p7.AddDialog(new Dialog("小夫", "你这么厉害，又这么内敛。换谁都会不敢跟你交流的吧……"));
        dialogSequences.Add(p7);


        DialogSequence p8 = new DialogSequence(27, 28, GameState.MiniGame);
        p8.AddDialog(new Dialog("小夫", "啊……我不是那个意思……"));
        p8.AddDialog(new Dialog("小日", "(捂嘴笑)你别紧张，我知道你没有恶意"));
        p8.AddDialog(new Dialog("小日", "(低头喝咖啡)这世界上坏人很多，尤其是男人里面。"));
        p8.AddDialog(new Dialog("小日", "（冷脸）不过你很简单……"));
        p8.AddDialog(new Dialog("小日", "（低头）我想跟你说件事，我在学校话剧团活动。"));
        p8.AddDialog(new Dialog("小日", "你想来演话剧吗? 我们剧团很缺男演员。"));
        p8.AddDialog(new Dialog("小日", "马上就有一部戏。"));
        p8.AddDialog(new Dialog("小日", "这么好的表现力，来我们这正合适。"));
        p8.AddDialog(new Dialog("小夫", "啊……好啊。"));
        p8.AddDialog(new Dialog("小日", "画上相关的图案当暗号，这就是你的介绍信了。"));
        dialogSequences.Add(p8);

        DialogSequence p8_2 = new DialogSequence(28, 29, GameState.SceneGame);
        p8_2.AddDialog(new Dialog("小日", "这就算生效了。"));
        p8_2.AddDialog(new Dialog("小日", "(浅笑)到时见。"));
        dialogSequences.Add(p8_2);
 
        DialogSequence p9 = new DialogSequence(29, 30, GameState.SceneGame);
        p9.AddDialog(new Dialog("小夫", "没想到又弄到这么晚。"));
        p9.AddDialog(new Dialog("小日", "（低头，握拳放于桌上）我不是把你拉来给我干活的……"));
        p9.AddDialog(new Dialog("小日", "我当时只是觉得你会合适这个角色。"));
        p9.AddDialog(new Dialog("小夫", "我当然知道。你怎么会这么想。"));
        p9.AddDialog(new Dialog("小日", "（仍然低头）我不该麻烦你……"));
        p9.AddDialog(new Dialog("小日", "这些事我自己可以干好。"));
        p9.AddDialog(new Dialog("小夫", "听我说。"));
        p9.AddDialog(new Dialog("小夫", "我是自愿帮忙的，我们都想把这件事干好，对吗？"));
        p9.AddDialog(new Dialog("小夫", "你不需要把一切都抗在自己身上。"));
        p9.AddDialog(new Dialog("小夫", "有我在，我们一起面对，好不好。"));
        p9.AddDialog(new Dialog("小夫", "戏里我们是默契无间的男女主角，戏外我们也一起面对一切好不好。"));
        p9.AddDialog(new Dialog("小日", "……"));
        p9.AddDialog(new Dialog("小日", "我想喝酒。我带了。帮我倒一杯可以吗。"));
        p9.AddDialog(new Dialog("小夫", "啊当然可以。"));
        dialogSequences.Add(p9);

        DialogSequence p10 = new DialogSequence(30, 31, GameState.SceneGame);
        p10.AddDialog(new Dialog("小日", "……对不起对不起。", 28));
        p10.AddDialog(new Dialog("小日", "明明是我自己可以干好的……", 28));
        p10.AddDialog(new Dialog("小夫", "别这么说……", 28));
        p10.AddDialog(new Dialog("小日", "（低头）我习惯了一切都是一个人。", 29));
        p10.AddDialog(new Dialog("小日", "从小到大我一直是自己做事。", 29));
        p10.AddDialog(new Dialog("小日", "爸妈都忙，也都让我学会独立。", 29));
        p10.AddDialog(new Dialog("小日", "我记得十岁那年，爸爸妈妈忙工作，一直没有回来。", 29));
        p10.AddDialog(new Dialog("小日", "……", 29));
        p10.AddDialog(new Dialog("小日", "（伸手）看到我食指的这道口子了吗……", 30));
        dialogSequences.Add(p10);

        DialogSequence p11 = new DialogSequence(31, 32, GameState.Dialog);
        p11.AddDialog(new Dialog("小日", "我把自己变成了刺猬，不让人靠近。", 31));
        p11.AddDialog(new Dialog("小日", "因为我不想……", 31));
        p11.AddDialog(new Dialog("小日", "但你，你很可靠……", 31));
        p11.AddDialog(new Dialog("小日", "……", 31));
        p11.AddDialog(new Dialog("小日", "你还记得我给你的那张票吗？", 31));
        p11.AddDialog(new Dialog("小夫", "我随身保存着。", 32));
        p11.AddDialog(new Dialog("小日", "雨伞是遮蔽风雨，玫瑰你明白，太阳……", 33));
        p11.AddDialog(new Dialog("小日", "那是我藏在心底的愿望。", 33));
        p11.AddDialog(new Dialog("小日", "我叫小日，但我的生活里没有太阳。", 33));
        p11.AddDialog(new Dialog("小日", "你知道为什么我要排曹禺的《日出》吗？", 33));
        p11.AddDialog(new Dialog("小日", "你知道为什么我要演陈白露吗？", 33));
        p11.AddDialog(new Dialog("小日", "我和她一样陷于泥淖无法自拔，我们都期待着太阳能照耀我们……", 33));
        dialogSequences.Add(p11);

        DialogSequence p12 = new DialogSequence(32, 33, GameState.SceneGame);
        p12.AddDialog(new Dialog("小日", "我喝多了，今晚的话你会忘的对吧。", 34));
        p12.AddDialog(new Dialog("小夫", "当然，我会尊重你的秘密。", 34));
        p12.AddDialog(new Dialog("小日", "最后对一下台词吧……然后回去睡觉。", 34));
        p12.AddDialog(new Dialog("小日", "太阳升起来了，黑暗留在后面。", 34));
        p12.AddDialog(new Dialog("小日", "……", 34));
        p12.AddDialog(new Dialog("小日", "但太阳不是我们的，我们要睡了。", 34));
        p12.AddDialog(new Dialog("小夫", "我来的时候觉察屋子里很黑。", 34));
        p12.AddDialog(new Dialog("小夫", "我走到窗前把幕帷拉开。", 34));
        p12.AddDialog(new Dialog("小夫", "阳光射满了一屋子。", 34));
        dialogSequences.Add(p12);


        DialogSequence p13 = new DialogSequence(33, 34, GameState.Dialog);
        p13.AddDialog(new Dialog("小夫", "……"));
        p13.AddDialog(new Dialog("小日", "……"));
        p13.AddDialog(new Dialog("小夫", "多亏有你……"));
        p13.AddDialog(new Dialog("小日", "这话该我来说，你知道一个靠谱的男演员有多难找吗。"));
        p13.AddDialog(new Dialog("小夫", "我不是说这个……"));
        p13.AddDialog(new Dialog("小夫", "……"));
        p13.AddDialog(new Dialog("小夫", "谢谢你，在你闪闪发光的时刻愿意拥抱最落魄的我……"));
        dialogSequences.Add(p13);

        DialogSequence p14 = new DialogSequence(34, 35, GameState.Dialog);
        p14.AddDialog(new Dialog("小夫", "你高中就在五汉大学简帛网上发了学术论文，过了民众大学自主招生……"));
        p14.AddDialog(new Dialog("小夫", "大一第一节汇报课就一鸣惊人，被院长说“有研究生水平”"));
        p14.AddDialog(new Dialog("小夫", "历史系第一，考入人文实验班还是第一……"));
        p14.AddDialog(new Dialog("小夫", "谁不喜欢你啊。"));
        p14.AddDialog(new Dialog("小夫", "可我……"));
        p14.AddDialog(new Dialog("小夫", "我不知道为什么我学不会这些东西……"));
        p14.AddDialog(new Dialog("小夫", "我不止一次被人评价不踏实，不靠谱，我的一切不幸都是咎由自取。"));
        p14.AddDialog(new Dialog("小夫", "我好委屈……"));
        p14.AddDialog(new Dialog("小夫", "我觉得自己像个忘记密码的保险箱，没有人知道它怎么打开，只能一点点去试。"));
        p14.AddDialog(new Dialog("小夫", "我不知道怎么样才能开始踏踏实实的奋斗，不知道什么时候才能取得一些成绩。"));
        p14.AddDialog(new Dialog("小夫", "在此之前我就是一个失败者，一个醉生梦死的混子。"));
        p14.AddDialog(new Dialog("小夫", "赌我的人生能走上正轨完全没有意义，你为什么不去找一个朝气蓬勃、前途大好的男孩子呢。"));
        dialogSequences.Add(p14);

        DialogSequence p15 = new DialogSequence(35, 36, GameState.SceneGame);
        p15.AddDialog(new Dialog("小日", "不许这么说自己。"));
        p15.AddDialog(new Dialog("小日", "老实说，我也听到了很多声音。"));
        p15.AddDialog(new Dialog("小日", "但我，只相信自己看到的。"));
        p15.AddDialog(new Dialog("小日", "你善良、温柔，有独立之精神自由之思想。"));
        p15.AddDialog(new Dialog("小日", "我觉得你缺一个机缘，你以后一定会大有作为。"));
        p15.AddDialog(new Dialog("小日", "更重要的是……"));
        p15.AddDialog(new Dialog("小日", "你也是我的依靠。"));
        dialogSequences.Add(p15);

        //星空对话
        //小夫：1
        DialogSequence sky1 = new DialogSequence(101, 36, GameState.LastSceneGame);
        sky1.AddDialog(new Dialog("小夫", "我说了很多遍了，学文科是我自己的选择，我就是喜欢！"));
        sky1.AddDialog(new Dialog("电话", "你喜欢，那你做出成绩了吗？"));
        sky1.AddDialog(new Dialog("电话", "本来专业就没法就业，做成这个样子你打算毕业怎么办？"));
        sky1.AddDialog(new Dialog("电话", "好好的理工科脑子，不学理工科自降身价学这个？"));
        sky1.AddDialog(new Dialog("电话", "整天脑子里想些什么东西！"));
        sky1.AddDialog(new Dialog("电话", "你还振振有词上了，喜欢？喜欢你做好啊！你做成什么样了！"));
        sky1.AddDialog(new Dialog("电话", "我和你妈企业里干了一辈子，你也回不来。你干成这样能干啥？啃老一辈子？"));
        dialogSequences.Add(sky1);

        //人群：2
        DialogSequence sky2 = new DialogSequence(102, 36, GameState.LastSceneGame);
        sky2.AddDialog(new Dialog("人群1", "呦，道德模范又在那谈他的理想情怀了。"));
        sky2.AddDialog(new Dialog("人群1", "整天正事不干一点，就知道凹人设？"));
        sky2.AddDialog(new Dialog("人群2", "就是，整天不切实际的，也不看看自己啥样。"));
        sky2.AddDialog(new Dialog("人群2", "有那闲工夫，还不如多去参加几个实习，多攒点经验，以后找工作也容易点。"));
        sky2.AddDialog(new Dialog("人群3", "就是自己懒呗，还有啥借口。"));
        sky2.AddDialog(new Dialog("人群3", "不就是懒，不想努力？净拿理想当借口。"));
        sky2.AddDialog(new Dialog("人群3", "不是活该？这有啥可同情的。"));
        dialogSequences.Add(sky2);

        //小日：4
        DialogSequence sky3 = new DialogSequence(104, 36, GameState.LastSceneGame);
        sky3.AddDialog(new Dialog("小日", "你们不要再说了，我跟他相处了这么久我自己有判断。"));
        sky3.AddDialog(new Dialog("小日", "他善良、温柔、有独立的思想。"));
        sky3.AddDialog(new Dialog("小日", "他只是没找到自己的节奏而已。"));
        sky3.AddDialog(new Dialog("小日", "不要再伤人了好吗。"));
        dialogSequences.Add(sky3);

        //【小夫 & 人群】1+2 = 3
        DialogSequence sky4 = new DialogSequence(103, 36, GameState.LastSceneGame);
        sky4.AddDialog(new Dialog("人群", "呦，难得你来听课啊。"));
        sky4.AddDialog(new Dialog("小夫", "……"));
        sky4.AddDialog(new Dialog("人群", "来不来的无所谓，反正你又不听。"));
        sky4.AddDialog(new Dialog("小夫", "你们不觉得……我们每天的生活没有意义吗？"));
        sky4.AddDialog(new Dialog("小夫", "所谓“身无半亩心忧天下，读破万卷神交古人”"));
        sky4.AddDialog(new Dialog("小夫", "为什么每天大家只关心保研奖学金啊。"));
        sky4.AddDialog(new Dialog("小夫", "如果这么想挣钱，为什么不学个工科，这样多接地气啊。"));
        sky4.AddDialog(new Dialog("人群", "你又开始装逼了。"));
        sky4.AddDialog(new Dialog("人群", "巧言令色鲜以仁。"));
        sky4.AddDialog(new Dialog("人群", "让你保研给你奖学金你要不要？"));
        sky4.AddDialog(new Dialog("人群", "装什么逼呢在这……"));
        sky4.AddDialog(new Dialog("人群", "我要能去工科那么好的专业我还在这跟你废话？"));
        dialogSequences.Add(sky4);

        //【小日 & 人群】 4+2 = 6
        DialogSequence sky5 = new DialogSequence(106, 36, GameState.LastSceneGame);
        sky5.AddDialog(new Dialog("人群", "你已经拿到京海大学的推免补录资格了哎！"));
        sky5.AddDialog(new Dialog("人群", "为什么第一志愿不填上？你不想去京海大学吗？"));
        sky5.AddDialog(new Dialog("人群", "说不定就去了。"));
        sky5.AddDialog(new Dialog("小日", "我已经和本校的老师说好了，陆老师对我很好，我不该失约。"));
        sky5.AddDialog(new Dialog("人群", "难不成京海大学真要你了你还不去？"));
        sky5.AddDialog(new Dialog("小日", "我当然不去。人难道不该讲信誉吗？"));
        sky5.AddDialog(new Dialog("人群", "……"));
        sky5.AddDialog(new Dialog("人群", "真是愚忠。"));
        sky5.AddDialog(new Dialog("人群", "跟你的前途比起来，守信一文不值。"));
        dialogSequences.Add(sky5);

        //【小夫&人群&小日】 4+1+2 = 7
        DialogSequence sky6 = new DialogSequence(107, 36, GameState.LastSceneGame);
        sky6.AddDialog(new Dialog("人群1", "躲远点吧，俩逼王又来了。"));
        sky6.AddDialog(new Dialog("人群1", "人家都是不屑于同流合污，要不早呼风唤雨了。"));
        sky6.AddDialog(new Dialog("人群2", "能耐要有吹的牛一半大也不至于混成这样。"));
        dialogSequences.Add(sky6);

        //【小夫 & 小日】 4+1 = 5
        DialogSequence sky7 = new DialogSequence(105, 36, GameState.LastSceneGame);
        sky7.AddDialog(new Dialog("小夫", "我们现在是什么关系……"));
        sky7.AddDialog(new Dialog("小日", "你已经是了呀。"));
        dialogSequences.Add(sky7);


        DialogSequence p16 = new DialogSequence(36, 37, GameState.Dialog);
        p16.AddDialog(new Dialog("小夫", "谢谢你选择我。", 20));
        p16.AddDialog(new Dialog("小日", "别这么说。", 20));
        p16.AddDialog(new Dialog("小日", "我们是互相救赎。", 20));
        p16.AddDialog(new Dialog("小日", "你帮了我很多。", 20));
        p16.AddDialog(new Dialog("小日", "我之前像刺猬一样，从来不敢对人打开心房。", 20));
        p16.AddDialog(new Dialog("小日", "但遇到你之后，我愿意破一次例。", 20));
        p16.AddDialog(new Dialog("小日", "初中的时候，我的班主任告诉我：", 20));
        p16.AddDialog(new Dialog("小日", "“相信有爱，一生行善。”", 20));
        p16.AddDialog(new Dialog("小日", "我一直践行这句话。", 20));
        p16.AddDialog(new Dialog("小日", "……差点就不相信了……", 20));
        p16.AddDialog(new Dialog("小日", "还好有你。", 20));
        p16.AddDialog(new Dialog("小日", "因为你，我愿意继续如此。", 20));
        p16.AddDialog(new Dialog("小夫", "今晚月色真美。", 20));
        p16.AddDialog(new Dialog("小夫", "月光照在你身上，跟你白色的裙子交相辉映，好像洁白的婚纱。", 20));
        p16.AddDialog(new Dialog("小夫", "你穿洁白的婚纱肯定特别美。", 20));
        dialogSequences.Add(p16);

        DialogSequence p17 = new DialogSequence(37, 38, GameState.SceneGame);
        p17.AddDialog(new Dialog("小夫", "你怎么了，你还好吗？", 21));
        p17.AddDialog(new Dialog("小夫", "是不是我太冒失了，对不起对不起，我不是有意让你不高兴的。", 21));
        p17.AddDialog(new Dialog("小日", "不……是太高兴了。", 21));
        p17.AddDialog(new Dialog("小日", "给我擦擦眼泪好吗。", 21));
        p17.AddDialog(new Dialog("小夫", "好，你等一下。", 21));
        dialogSequences.Add(p17);


        DialogSequence p18 = new DialogSequence(38, 39, GameState.SceneGame);
        p18.AddDialog(new Dialog("小日", "下次我给你擦。"));
        p18.AddDialog(new Dialog("小夫", "哈哈，一言为定。我肯定也会经常幸福的流泪的。"));
        dialogSequences.Add(p18);

        DialogSequence p19 = new DialogSequence(39, 45, GameState.SceneGame);
        p19.AddDialog(new Dialog("小夫", "！！？"));
        p19.AddDialog(new Dialog("小夫", "！！！！！！！！！！！！"));
        dialogSequences.Add(p19);


        //跨时空对话
        DialogSequence ts1 = new DialogSequence(40, 46, GameState.LastSceneGame);
        ts1.AddDialog(new DialogSplit("小夫", "大一上学期就这么结束了啊。",
           "小日", "咱们好久没有单独相处过了……"));
        ts1.AddDialog(new DialogSplit("小夫", "收拾收拾东西，看看哪些要带回家吧。",
            "小日", "有些事，我想跟你聊聊……"));
        dialogSequences.Add(ts1);

        //照片
        DialogSequence ts2 = new DialogSequence(41, 46, GameState.LastSceneGame);
        ts2.AddDialog(new DialogSplit("小夫", "这是我中考成绩出的那个晚上！我考了全班第一哎！我记得那个时候我还很坚定的要考燕京大学医学院呢！",
           "小日", "这是我中考完的聚餐照。"));
        ts2.AddDialog(new DialogSplit("小夫", "当医生很有魅力啊！可以治病救人哎！还有什么比治病救人更伟大的事情啊。",
            "小日", "那个时候跟爸妈商量文理选科的事情。"));
        ts2.AddDialog(new DialogSplit("小夫", "当时给爷爷奶奶敬酒说我要当医生，爷爷可开心了，说有人接班了。",
           "小日", "我父母都是医生，所以我最早也想做医生。"));
        ts2.AddDialog(new DialogSplit("小夫", "可惜我分不够没考上临床医学。我的分数好像能去公共卫生吧，但那个方向对我没什么吸引力哎。",
            "小日", "但后来，我发现比起让世人健康，我更想让他们幸福。"));
        ts2.AddDialog(new DialogSplit("小夫", "又不能真的治病救人，只能防护一下传染病什么的，现在哪还有什么可怕的传染病啊。",
           "小日", "我觉得我理科学得很好，学文会可惜分数。"));
        ts2.AddDialog(new DialogSplit("小夫", "鼠疫霍乱早就是过去式了，天花都快灭绝了。",
            "小日", "但爸爸跟我说：“跟随你的内心”"));
        ts2.AddDialog(new DialogSplit("小夫", "……",
           "小日", "……"));
        ts2.AddDialog(new DialogSplit("小夫", "最后还是没能实现小时候的梦想啊。",
            "小日", "就这样，我学了历史。"));
        dialogSequences.Add(ts2);

        //课本
        DialogSequence ts3 = new DialogSequence(42, 46, GameState.LastSceneGame);
        ts3.AddDialog(new DialogSplit("小夫", "这课比我想象中要无聊哎。",
           "小日", "说真的，读历史我很幸福。我能设身处地的跨越时空，和过去一个个炽热滚烫的灵魂相拥。"));
        ts3.AddDialog(new DialogSplit("小夫", "虽然说我们学校的数学是出了名的好，全国都算顶尖的。",
            "小日", "但后来，我越来越迷茫了。"));
        ts3.AddDialog(new DialogSplit("小夫", "但感觉确实不怎么好玩啊。纯粹是思维游戏……感觉不太能触动我。",
           "小日", "我越是将热血洒向一抔黄土，越对现实中的自己感到无力。"));
        ts3.AddDialog(new DialogSplit("小夫", "想象中的大学应该是有大师、有理想、有热情、有温度的。",
            "小日", "我对现实中生灵的哭声充耳不闻，却对古卷里的枯骨热泪盈眶。这难道不是本末倒置吗？"));
        ts3.AddDialog(new DialogSplit("小夫", "难道理工科都是这样的吗……",
           "小日", "我想我该做点什么……"));
        dialogSequences.Add(ts3);

        //笔
        DialogSequence ts4 = new DialogSequence(43, 46, GameState.LastSceneGame);
        ts4.AddDialog(new DialogSplit("小夫", "最头疼的来了。",
           "小日", "从那以后我就变了。"));
        ts4.AddDialog(new DialogSplit("小夫", "每天就是写实验报告。",
            "小日", "我日渐意识到我做的一切不过是舞文弄墨、文字游戏。"));
        ts4.AddDialog(new DialogSplit("小夫", "写步骤、称重量、洗仪器……",
           "小日", "我想做点什么，我想改变点什么，我想拯救点什么。"));
        ts4.AddDialog(new DialogSplit("小夫", "加热、搅拌、粉碎、混合……",
            "小日", "但我不知道什么是爱，我没有勇气去爱，我不知道世界是否值得被爱。"));
        ts4.AddDialog(new DialogSplit("小夫", "太多繁文缛节了。",
           "小日", "直到我遇到了你。"));
        ts4.AddDialog(new DialogSplit("小夫", "虽然化学也是双一流，但就是喜欢不起来啊……",
           "小日", "你永远热情、真诚、温柔。对谁都是这样，即使在自己最艰难的时刻依然坚持对别人好。"));
        ts4.AddDialog(new DialogSplit("小夫", "最近学院的老师好像都在研究什么抗病毒的新药吧……",
           "小日", "你是我心目中最接近小天使的存在。"));
        ts4.AddDialog(new DialogSplit("小夫", "哪有那么多可怕的病毒。",
           "小日", "因为你，我觉得世界比我想象的要美好那么一点。"));
        ts4.AddDialog(new DialogSplit("小夫", "或许我真正的归宿还是去读文史哲吧。",
           "小日", "我愿意让它变得更温暖。"));
        dialogSequences.Add(ts4);

        //跨时空对话end
        DialogSequence ts5 = new DialogSequence(44, 46, GameState.LastSceneGame);
        ts5.AddDialog(new Dialog("小夫", "大胆去做吧，我永远支持你。"));
        dialogSequences.Add(ts5);

        DialogSequence ts6 = new DialogSequence(45, 46, GameState.LastSceneGame);
        ts6.AddDialog(new DialogSplit("小夫", "嗯！我还年轻。",
            "小日", "嗯……谢谢你支持我。"));
        ts6.AddDialog(new DialogSplit("小夫", "有梦就去追！",
           "小日", "谢谢鼓励我下定决心。"));
        dialogSequences.Add(ts6);


        //高潮
        DialogSequence e1 = new DialogSequence(46, 47, GameState.SceneGame);
        e1.AddDialog(new Dialog("小夫", "我再也不想回想那个时刻，但我无时无刻脑子里都在重复。"));
        e1.AddDialog(new Dialog("小夫", "她就躺在我面前，全身惨白，比那晚月光照耀下还要白的刺眼。"));
        e1.AddDialog(new Dialog("小夫", "她脸上插满了管子，连气管都被切开了。我跪在她面前，隔着玻璃，连碰她都是奢望。"));
        e1.AddDialog(new Dialog("小夫", "我什么都做不了。"));
        e1.AddDialog(new Dialog("小夫", "我睡不着。"));
        e1.AddDialog(new Dialog("小夫", "我每天晚上都睡不着。"));
        e1.AddDialog(new Dialog("小夫", "我一直在做噩梦。"));
        e1.AddDialog(new Dialog("小夫", "无穷无尽的噩梦。"));
        e1.AddDialog(new Dialog("小夫", "我知道胡思乱想没有用，可我一直在想。"));
        e1.AddDialog(new Dialog("小夫", "如果我当初学了公共医学，阻止了非典的爆发。"));
        e1.AddDialog(new Dialog("小夫", "如果我当时继续好好学化学，研制出了病毒的特效药。"));
        e1.AddDialog(new Dialog("小夫", "如果我没有痴心妄想和她在一起，她能继续做她的学术天才。"));
        e1.AddDialog(new Dialog("小夫", "如果我不跟她聊什么所谓高尚的理想，什么所谓高尚的道德追求。"));
        e1.AddDialog(new Dialog("小夫", "甚至，如果我跟她聊天的那一晚，早点察觉到她的意图，劝她不要去做危险的事。"));
        e1.AddDialog(new Dialog("小夫", "哪怕我陪她一起去。"));
        e1.AddDialog(new Dialog("小夫", "我有那么多机会救她，但我什么都没做，我什么都做不了。"));
        e1.AddDialog(new Dialog("小夫", "她救了我的人生，我却没能救她……"));
        e1.AddDialog(new Dialog("小夫", "她本应该继续在大学校园里漫步，她本该继续在学术道路上大放光彩。"));
        e1.AddDialog(new Dialog("小夫", "她不该早早的结束她的人生。"));
        e1.AddDialog(new Dialog("小夫", "该死的人是我！"));
        e1.AddDialog(new Dialog("小夫", "明明该死的人是我才对！"));
        e1.AddDialog(new Dialog("小夫", "为什么我什么都没做，为什么我什么都做不了。"));
        dialogSequences.Add(e1);

        DialogSequence e2 = new DialogSequence(47, 48, GameState.Dialog);
        e2.AddDialog(new Dialog("小日", "不要伤害自己……"));
        e2.AddDialog(new Dialog("小日", "你从来没有伤害过我。"));
        e2.AddDialog(new Dialog("小日", "你什么都不欠我。"));
        e2.AddDialog(new Dialog("小日", "一切都是我自己的选择。"));
        e2.AddDialog(new Dialog("小日", "你拯救了我，让我相信世界上有善、有爱。"));
        e2.AddDialog(new Dialog("小日", "你让我觉得世界值得期待，世界值得被爱。"));
        e2.AddDialog(new Dialog("小日", "我才会想要把这种爱传递出去。"));
        e2.AddDialog(new Dialog("小日", "你没有错，或许我也没有错，爱不会有错。"));
        e2.AddDialog(new Dialog("小日", "……"));
        e2.AddDialog(new Dialog("小日", "答应我最后一个请求好吗？"));
        e2.AddDialog(new Dialog("小日", "照顾好自己。"));
        dialogSequences.Add(e2);

        DialogSequence e3 = new DialogSequence(48, 49, GameState.Dialog);
        e3.AddDialog(new Dialog("小夫", "……"));
        e3.AddDialog(new Dialog("小夫", "你知道为什么我会来到这里吧。"));
        e3.AddDialog(new Dialog("小夫", "你知道这意味着什么吧……"));
        e3.AddDialog(new Dialog("小夫", "恕我不能答应你了。"));
        e3.AddDialog(new Dialog("小夫", "我不能让你一个人待在这里。"));
        e3.AddDialog(new Dialog("小夫", "我无法想象没有你的人生。"));
        dialogSequences.Add(e3);

        DialogSequence e4 = new DialogSequence(49, 50, GameState.MiniGame);
        e4.AddDialog(new Dialog("小日", "……"));
        e4.AddDialog(new Dialog("小日", "你还记得你把我的《古籍概要》还我的那天吗？"));
        e4.AddDialog(new Dialog("小日", "我们一起聊历史学的意义。"));
        e4.AddDialog(new Dialog("小夫", "我记得。"));
        e4.AddDialog(new Dialog("小日", "历史学的意义，有人说是为后世提供行为指南，有人说是为了传承自己的思想主张，还有人说就是为了弥补失忆……"));
        e4.AddDialog(new Dialog("小日", "我记得咱们那天没有达成共识，但有一点我们都认可。"));
        e4.AddDialog(new Dialog("小日", "历史的进步，依靠的是文明火把的传递。"));
        e4.AddDialog(new Dialog("小日", "对吗？"));
        dialogSequences.Add(e4);


        DialogSequence e5 = new DialogSequence(50, 51, GameState.MiniGame);
        e5.AddDialog(new Dialog("小日", "如果我们作为先行者都放弃了，那么后来的理想主义者靠谁去指引，靠谁去温暖呢？"));
        e5.AddDialog(new Dialog("小日", "需要有人去讲述我们的故事。"));
        e5.AddDialog(new Dialog("小日", "如今，你可以把我们吃过的苦搓成药丸，喂同病相怜的人吃下去，带他们离开泥淖。"));
        e5.AddDialog(new Dialog("小日", "就像当初我们互相救赎那样。"));
        e5.AddDialog(new Dialog("小日", "别放弃这次机会好吗？"));

        e5.AddDialog(new Dialog("小夫", "……"));
        e5.AddDialog(new Dialog("小夫", "没想到最后一次，又是你救了我……"));
        e5.AddDialog(new Dialog("小夫", "对不起……"));

        e5.AddDialog(new Dialog("小日", "别这么说"));
        e5.AddDialog(new Dialog("小日", "我见过太阳，我没有遗憾了。"));

        e5.AddDialog(new Dialog("小日", "“但太阳不是我们的，我们要睡了。”"));
        e5.AddDialog(new Dialog("小日", "一直走吧，走出这里，拥抱阳光。然后成为太阳。"));
        e5.AddDialog(new Dialog("小日", "带着我的那份一起。"));

        e5.AddDialog(new Dialog("小夫", "再给我一点时间，就一点好吗？"));
        e5.AddDialog(new Dialog("小夫", "抱抱我吧，最后一次。"));
        e5.AddDialog(new Dialog("小夫", "我快醒了……"));
        dialogSequences.Add(e5);


        //尾声

        DialogSequence e6 = new DialogSequence(51, 52, GameState.SceneGame);
        e6.AddDialog(new Dialog("小夫", "后来，我还是没能在人文学界混出头，不得不找份工作贴补用度。"));
        e6.AddDialog(new Dialog("小夫", "但依然保有人文关怀，怀抱着所有的热情和真诚给予身边的每一个人。"));
        e6.AddDialog(new Dialog("小夫", "小日给了我活下去的理由，我日渐勇敢的学会了面对一切。"));
        e6.AddDialog(new Dialog("小夫", "我帮助过的“理想主义者”很多，也许只有一些是真的在泥淖中的人。"));
        e6.AddDialog(new Dialog("小夫", "今天这个估计也不是，还没入圈就主动约我见面问问题的，也是人精啊……"));
        e6.AddDialog(new Dialog("小晞", "师兄您好……我是小晞。"));
        dialogSequences.Add(e6);

        DialogSequence e7 = new DialogSequence(52, 53, GameState.MiniGame);
        e7.AddDialog(new Dialog("小晞", "之前咨询过您学术圈的事情，今天是来感谢的。"));
        e7.AddDialog(new Dialog("小晞", "我已经以第一名的成绩入选了，功不唐捐……"));
        e7.AddDialog(new Dialog("小夫", "恭喜。不过抱歉我记不清了，您之前在哪里就读？"));
        e7.AddDialog(new Dialog("小晞", "我之前在历史学系。"));
        e7.AddDialog(new Dialog("小夫", "我想起来了！你也是历史学系第一名！"));
        e7.AddDialog(new Dialog("小夫", "你真的来考研究生班了？"));
        e7.AddDialog(new Dialog("小晞", "对的。"));
        e7.AddDialog(new Dialog("小晞", "师兄您当时劝过我。跟我说了很多……"));
        dialogSequences.Add(e7);

        DialogSequence e8 = new DialogSequence(53, 54, GameState.Dialog);
        e8.AddDialog(new Dialog("小晞", "我真的很感动。"));
        e8.AddDialog(new Dialog("小晞", "我知道说真话是有代价的，我没想到您会跟我说这么多。"));
        e8.AddDialog(new Dialog("小晞", "我知道，很多美好的东西都是假的。"));
        e8.AddDialog(new Dialog("小晞", "就像泡泡，看着绚烂，其实一碰，一手的阴湿。"));
        e8.AddDialog(new Dialog("小晞", "我知道世界上总有光照不到的地方。"));
        e8.AddDialog(new Dialog("小晞", "但我想人文学科的使命不就是让世界更好吗？"));
        e8.AddDialog(new Dialog("小晞", "我愿意尽我所能温暖这个世界。"));
        e8.AddDialog(new Dialog("小晞", "进入研究生班，这里是更高的殿堂，我能做更多的事。"));
        dialogSequences.Add(e8);

        DialogSequence e9 = new DialogSequence(54, 55, GameState.Dialog);
        e9.AddDialog(new Dialog("小夫", "……"));
        e9.AddDialog(new Dialog("小夫", "你真的是这么想的？"));
        e9.AddDialog(new Dialog("小夫", "我觉得我说的够残酷了。"));
        e9.AddDialog(new Dialog("小夫", "人文精神是可贵的，但圈子不一定。"));
        e9.AddDialog(new Dialog("小夫", "进入研究生班便是提前踏入了圈子。"));
        e9.AddDialog(new Dialog("小夫", "圈子里的东西都潜藏在深水里，可不像书本上的东西一样清晰可见。"));
        e9.AddDialog(new Dialog("小夫", "像你这样既有灵性又有情怀的天才，进圈子的不在少数。"));
        e9.AddDialog(new Dialog("小夫", "要么被黑潮吞噬，成为黑暗的一部分。"));
        e9.AddDialog(new Dialog("小夫", "要么被折磨的遍体鳞伤出走，为理想奉献一切。"));
        e9.AddDialog(new Dialog("小夫", "理想主义是要付出代价的。"));
        e9.AddDialog(new Dialog("小夫", "不仅在圈子里混不开，甚至自己可能一无所有。"));
        e9.AddDialog(new Dialog("小夫", "做个俗人，或者做个坏人，对你而言是好得多的选择。"));
        dialogSequences.Add(e9);

        DialogSequence e10 = new DialogSequence(55, 56, GameState.SceneGame);
        e10.AddDialog(new Dialog("小晞", "谢谢你师兄，但……我想试试。"));
        e10.AddDialog(new Dialog("小晞", "此后若没有炬火，我便是唯一的光。"));
        e10.AddDialog(new Dialog("小夫", "……"));
        e10.AddDialog(new Dialog("小夫", "加油吧，祝你乘风破浪。"));
        e10.AddDialog(new Dialog("小晞", "谢谢师兄。我一定好好努力，未来再见。"));
        e10.AddDialog(new Dialog("小夫", "等等……"));
        e10.AddDialog(new Dialog("小夫", "……"));
        e10.AddDialog(new Dialog("小夫", "记得，照顾好自己。"));
        e10.AddDialog(new Dialog("小夫", "还有……"));
        e10.AddDialog(new Dialog("小夫", "如果可以的话，努力做太阳吧。"));
        dialogSequences.Add(e10);
    }
}
