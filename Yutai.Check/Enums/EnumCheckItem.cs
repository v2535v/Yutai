﻿// 项目名称 :  Yutai
// 项目描述 :  
// 类 名 称 :  EnumCheckItem.cs
// 版 本 号 :  
// 说    明 :  
// 作    者 :  
// 创建时间 :  2017/08/15  09:20
// 更新时间 :  2017/08/15  09:20
namespace Yutai.Check.Enums
{
    public enum EnumCheckItem
    {
        P_FieldFull,        // 属性检查 字段完整性检查 对必填的关键字段进行检查，以确保不会因为这些关键字段没有填写，而导致分析统计出错。
        P_FieldRepeat,      // 属性检查 字段重复值检查 相同字段值检查，针对管点和管线的业务场景，部分属性不能出现重复的值。如果出现重复的值则视为有错误。
        P_Hylink,           // 属性检查 超链接检查 检查照片路径是否正确。
        G_SinglePoint,      // 空间检查 孤立点检查 是否存在管点没有落在管线情况，如果存在说明该管点绘制有错误。
        G_SingleLine,       // 空间检查 孤立线检查 是否存在管线不与任何其他管线有公共点，如果存在说明该管线绘制有错误。
        G_PointRepeat,      // 空间检查 重复点检查 检查在统一位置是否存在多个管点。
        G_LineRepeat,       // 空间检查 重复线检查 是否存在管线完全重合的情况，如果存在管线完全重合，则认为管线有错误。
        G_Coord,            // 空间检查 坐标信息检查 检查点坐标XY与属性XY差值是否超过容差值。
        G_Relation,         // 空间检查 点线关联检查 检查线段的起点编号字段与实际的起点编号是否一致。
        G_Feature,          // 空间检查 特征点检查 检查直线点，三通点，四通点，多通点是否与实际连线相同。 
        G_Elevation,        // 空间检查 高程检查 检查高程起伏超过限定值的管点。
        G_Flow,             // 空间检查 流向检查 该点的地面高程与该点的起点埋深相减，得到的值，与其他连接的其他点的高程减埋深相对比，大值流向小值，判断流向。如果出现，大管径流向小管径的提示检查。
        G_Intersect,        // 空间检查 交叉检查 检查管线在三维空间下是否交叉。
    }
}