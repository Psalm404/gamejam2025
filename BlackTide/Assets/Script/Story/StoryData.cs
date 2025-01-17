using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class StoryData
{
    public static List<DialogSequence> dialogSequences = new List<DialogSequence>();

    public static void Init() {
        DialogSequence s1 = new DialogSequence(0, 1, GameState.SceneGame);
        s1.AddDialog(new Dialog("小夫", "嗯、嗯，您放心，我明天的东西都准备好了。", 3));
        s1.AddDialog(new Dialog("小夫", "肯定会有很好的呈现的。", 3));
        s1.AddDialog(new Dialog("小夫", "辛苦您这么晚了还打电话来问候，您快休息。", 3));
        s1.AddDialog(new Dialog("小夫", "哈……哈，好的，我一定注意身体。", 3));
        dialogSequences.Add(s1);

        DialogSequence s2 = new DialogSequence(1, 2, GameState.SceneGame);
        s2.AddDialog(new Dialog("小夫", "刚想喝点麻醉一下……", 4));
        s2.AddDialog(new Dialog("小夫", "我哪知道该做什么……", 4));
        s2.AddDialog(new Dialog("小夫", "拿往年的套话拼一拼呗……", 4));
        dialogSequences.Add(s2);

        DialogSequence s3 = new DialogSequence(2, 3, GameState.MiniGame);
        s3.AddDialog(new Dialog("小夫", "公司产业整合顺利，集群化程度显著提高。"));
        dialogSequences.Add(s3);

        DialogSequence s4 = new DialogSequence(3, 4, GameState.MiniGame);
        s4.AddDialog(new Dialog("小夫", "企业发展势头迅猛，年度营收迈上新台阶。"));
        s4.AddDialog(new Dialog("小夫", "哈……净说些谁都不信的话……"));
        s4.AddDialog(new Dialog("小夫", "再找点数据支撑吧……"));
        dialogSequences.Add(s4);

        DialogSequence s5 = new DialogSequence(4, 5, GameState.MiniGame);
        s5.AddDialog(new Dialog("小夫", "较去年同期同比增长……"));
        dialogSequences.Add(s5);

        DialogSequence s6 = new DialogSequence(5, 6, GameState.MiniGame);
        s6.AddDialog(new Dialog("小夫", "企业于全行业居于龙头地位，占领50%以上市场份额……"));
        s6.AddDialog(new Dialog("小夫", "呵，跟打工人有什么关系"));
        s6.AddDialog(new Dialog("小夫", "还不是要半夜加班……"));
        s6.AddDialog(new Dialog("小夫", "不过本来也吃不下、睡不着。"));
        s6.AddDialog(new Dialog("小夫", "最近真不知道怎么了……"));
        s6.AddDialog(new Dialog("小夫", "还是喝点麻醉一下吧……"));
        dialogSequences.Add(s6);

        DialogSequence s7 = new DialogSequence(6, 7, GameState.MiniGame);
        s7.AddDialog(new Dialog("小夫", "好久好久都感觉不到快乐了……"));
        s7.AddDialog(new Dialog("小夫", "只有喝醉的时候，心里会涌起没来由的快乐……"));
        s7.AddDialog(new Dialog("小夫", "我之前可是滴酒不沾的，哈哈……"));
        dialogSequences.Add(s7);

        DialogSequence s8 = new DialogSequence(7, 8, GameState.MiniGame);
        s8.AddDialog(new Dialog("小夫", "火辣辣的、苦、酸，就是这个感觉……"));
        s8.AddDialog(new Dialog("小夫", "这不就是我的人生吗，哈哈"));
        s8.AddDialog(new Dialog("小夫", "与其说是喝酒寻求快乐，不如说是在惩罚自己……"));
        dialogSequences.Add(s8);

        DialogSequence s9 = new DialogSequence(8, 9, GameState.SceneGame);
        s9.AddDialog(new Dialog("小夫", "喝的有点猛，上头了，哈哈……"));
        dialogSequences.Add(s9);

        DialogSequence s10 = new DialogSequence(9, 10, GameState.SceneGame);
        s10.AddDialog(new Dialog("小夫", "晕了，先把做了的关了，点一下叉……"));
        dialogSequences.Add(s10);

        DialogSequence s11 = new DialogSequence(10, 11, GameState.MiniGame);
        s11.AddDialog(new Dialog("小夫", "情绪涌起来了……不要……这种时候不行……"));
        s11.AddDialog(new Dialog("小夫", "快压下去……"));
        dialogSequences.Add(s11);

        DialogSequence s12 = new DialogSequence(11, 12, GameState.MiniGame);
        s12.AddDialog(new Dialog("小夫", "(闭眼）还是……压不住啊……"));
        dialogSequences.Add(s12);




        //下编

        DialogSequence p1 = new DialogSequence(20, 21, GameState.SceneGame);
        p1.AddDialog(new Dialog("小日", "《隋唐制度渊源略论稿》……"));
        p1.AddDialog(new Dialog("小日", "你也是历史学院来的吗 ?"));
        dialogSequences.Add(p1);

        DialogSequence p2 = new DialogSequence(20, 21, GameState.SceneGame);
        p2.AddDialog(new Dialog("小夫", "啊没有没有……我是理工科转来的，对历史感兴趣而已啦。"));
        p2.AddDialog(new Dialog("小日", "我就是感觉没见过你嘛。"));
        p2.AddDialog(new Dialog("小日", "还是第一次在班里遇到和我一样做历史的呢。"));
        p2.AddDialog(new Dialog("小日", "(浅笑)我叫小日，历史学院来的。"));
        p2.AddDialog(new Dialog("小夫", "你是历史系来的? 你就是那个专业第一吗?"));
        p2.AddDialog(new Dialog("小日", "那都是过去的事儿了。以后大家多交流哦。"));
        p2.AddDialog(new Dialog("小夫", "不敢不敢，我吃喝玩乐还比较行，看书就头大了，哈哈，可以一起玩呀。"));
        p2.AddDialog(new Dialog("小日", "过谦了。"));
        p2.AddDialog(new Dialog("小日", "不过说回来，如果是理工科转过来的，可能真的要补补专业课。"));
        p2.AddDialog(new Dialog("小日", "你有《古籍概要》吗 ?"));
        p2.AddDialog(new Dialog("小夫", "啊我买了……"));
        dialogSequences.Add(p2);
    }
}

