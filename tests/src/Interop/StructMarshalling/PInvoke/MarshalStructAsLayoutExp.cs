using System;
using System.Runtime.InteropServices;

public class Managed
{
    static int failures = 0;
   
    enum StructID
    {
        InnerExplicit1id,
        InnerExplicit2id,
        InnerArrayExplicit1id,
        InnerArrayExplicit2id,
        NumberExplicitid,
        ByteStructPack2Explicitid,
        ShortStructPack4Explicitid,
        IntStructPack8Explicitid,
        LongStructPack16Explicitid,
        StringExplicitid
    }

    public static int Main()
    {
        RunMarshalStructAsParamAsExpByVal();
        RunMarshalStructAsParamAsExpByRef();
        RunMarshalStructAsParamAsExpByValIn();
        RunMarshalStructAsParamAsExpByRefIn();
        RunMarshalStructAsParamAsExpByValOut();
        RunMarshalStructAsParamAsExpByRefOut();
        RunMarshalStructAsParamAsExpByValInOut();
        RunMarshalStructAsParamAsExpByRefInOut();

        if (failures > 0)
        {
            Console.WriteLine("\nTEST FAILED!");
            return 101;
        }
        else
        {
            Console.WriteLine("\nTEST PASSED!");
            return 100;
        }
    }

    #region	Struct with Layout Explicit scenario1
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByValInnerExplicit1(InnerExplicit1 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInnerExplicit1(ref InnerExplicit1 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerExplicit1")]
    static extern bool MarshalStructAsParam_AsExpByValInInnerExplicit1([In] InnerExplicit1 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInInnerExplicit1([In] ref InnerExplicit1 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerExplicit1")]
    static extern bool MarshalStructAsParam_AsExpByValOutInnerExplicit1([Out] InnerExplicit1 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefOutInnerExplicit1(out InnerExplicit1 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerExplicit1")]
    static extern bool MarshalStructAsParam_AsExpByValInOutInnerExplicit1([In, Out] InnerExplicit1 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefInnerExplicit1")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutInnerExplicit1([In, Out] ref InnerExplicit1 str1);

    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefInOutStringExplicit")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutStringExplicit([In, Out] ref StringExplicit str1);

    #endregion
    #region Struct with Layout Explicit scenario2
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByValInnerExplicit2(InnerExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefInnerExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByRefInnerExplicit2(ref InnerExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByValInInnerExplicit2([In] InnerExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefInInnerExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByRefInInnerExplicit2([In] ref InnerExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByValOutInnerExplicit2([Out] InnerExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefOutInnerExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByRefOutInnerExplicit2(out InnerExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByValInOutInnerExplicit2([In, Out] InnerExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefInnerExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutInnerExplicit2([In, Out] ref InnerExplicit2 str1);
    #endregion
    #region Struct with Layout Explicit scenario3
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByValInnerArrayExplicit1(InnerArrayExplicit1 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInnerArrayExplicit1(ref InnerArrayExplicit1 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerArrayExplicit1")]
    static extern bool MarshalStructAsParam_AsExpByValInInnerArrayExplicit1([In] InnerArrayExplicit1 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInInnerArrayExplicit1([In] ref InnerArrayExplicit1 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerArrayExplicit1")]
    static extern bool MarshalStructAsParam_AsExpByValOutInnerArrayExplicit1([Out] InnerArrayExplicit1 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit1(out InnerArrayExplicit1 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerArrayExplicit1")]
    static extern bool MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit1([In, Out] InnerArrayExplicit1 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefInnerArrayExplicit1")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit1([In, Out] ref InnerArrayExplicit1 str1);
    #endregion
    #region Struct with Layout Explicit scenario4
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByValInnerArrayExplicit2(InnerArrayExplicit2 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInnerArrayExplicit2(ref InnerArrayExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerArrayExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByValInInnerArrayExplicit2([In] InnerArrayExplicit2 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInInnerArrayExplicit2([In] ref InnerArrayExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerArrayExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByValOutInnerArrayExplicit2([Out] InnerArrayExplicit2 str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit2(out InnerArrayExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValInnerArrayExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit2([In, Out] InnerArrayExplicit2 str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefInnerArrayExplicit2")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit2([In, Out] ref InnerArrayExplicit2 str1);
    #endregion
    #region Struct(NumberExplicit) with Layout Explicit scenario5
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByValNumberExplicit(NumberExplicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefNumberExplicit(ref NumberExplicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValNumberExplicit")]
    static extern bool MarshalStructAsParam_AsExpByValInNumberExplicit([In] NumberExplicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInNumberExplicit([In] ref NumberExplicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValNumberExplicit")]
    static extern bool MarshalStructAsParam_AsExpByValOutNumberExplicit([Out] NumberExplicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefOutNumberExplicit(out NumberExplicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValNumberExplicit")]
    static extern bool MarshalStructAsParam_AsExpByValInOutNumberExplicit([In, Out] NumberExplicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefNumberExplicit")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutNumberExplicit([In, Out] ref NumberExplicit str1);
    #endregion

    #region Struct(ByteStructPack2Explicit) with Layout Explicit scenario6
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByValByteStructPack2Explicit(ByteStructPack2Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefByteStructPack2Explicit(ref ByteStructPack2Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValByteStructPack2Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValInByteStructPack2Explicit([In] ByteStructPack2Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInByteStructPack2Explicit([In] ref ByteStructPack2Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValByteStructPack2Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValOutByteStructPack2Explicit([Out] ByteStructPack2Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefOutByteStructPack2Explicit(out ByteStructPack2Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValByteStructPack2Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValInOutByteStructPack2Explicit([In, Out] ByteStructPack2Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefByteStructPack2Explicit")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutByteStructPack2Explicit([In, Out] ref ByteStructPack2Explicit str1);

    #endregion
    #region Struct(ShortStructPack4Explicit) with Layout Explicit scenario7
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByValShortStructPack4Explicit(ShortStructPack4Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefShortStructPack4Explicit(ref ShortStructPack4Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValShortStructPack4Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValInShortStructPack4Explicit([In] ShortStructPack4Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInShortStructPack4Explicit([In] ref ShortStructPack4Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValShortStructPack4Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValOutShortStructPack4Explicit([Out] ShortStructPack4Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefOutShortStructPack4Explicit(out ShortStructPack4Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValShortStructPack4Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValInOutShortStructPack4Explicit([In, Out] ShortStructPack4Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefShortStructPack4Explicit")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutShortStructPack4Explicit([In, Out] ref ShortStructPack4Explicit str1);
    #endregion
    #region Struct(IntStructPack8Explicit) with Layout Explicit scenario8
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByValIntStructPack8Explicit(IntStructPack8Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefIntStructPack8Explicit(ref IntStructPack8Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValIntStructPack8Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValInIntStructPack8Explicit([In] IntStructPack8Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInIntStructPack8Explicit([In] ref IntStructPack8Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValIntStructPack8Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValOutIntStructPack8Explicit([Out] IntStructPack8Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefOutIntStructPack8Explicit(out IntStructPack8Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValIntStructPack8Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValInOutIntStructPack8Explicit([In, Out] IntStructPack8Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefIntStructPack8Explicit")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutIntStructPack8Explicit([In, Out] ref IntStructPack8Explicit str1);
    #endregion
    #region Struct(LongStructPack16Explicit) with Layout Explicit scenario9
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByValLongStructPack16Explicit(LongStructPack16Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefLongStructPack16Explicit(ref LongStructPack16Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValLongStructPack16Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValInLongStructPack16Explicit([In] LongStructPack16Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefInLongStructPack16Explicit([In] ref LongStructPack16Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValLongStructPack16Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValOutLongStructPack16Explicit([Out] LongStructPack16Explicit str1);
    [DllImport("MarshalStructAsParam")]
    static extern bool MarshalStructAsParam_AsExpByRefOutLongStructPack16Explicit(out LongStructPack16Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByValLongStructPack16Explicit")]
    static extern bool MarshalStructAsParam_AsExpByValInOutLongStructPack16Explicit([In, Out] LongStructPack16Explicit str1);
    [DllImport("MarshalStructAsParam", EntryPoint = "MarshalStructAsParam_AsExpByRefLongStructPack16Explicit")]
    static extern bool MarshalStructAsParam_AsExpByRefInOutLongStructPack16Explicit([In, Out] ref LongStructPack16Explicit str1);
    #endregion

    #region Marshal Explicit struct method

    private static void MarshalStructAsParam_AsExpByVal(StructID id)
    {
        try
        {
            switch (id)
            {
                case StructID.InnerExplicit1id:
                    InnerExplicit1 sourceInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");
                    InnerExplicit1 cloneInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInnerExplicit1...");
                    if (!MarshalStructAsParam_AsExpByValInnerExplicit1(sourceInnerExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInnerExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit1(sourceInnerExplicit1, cloneInnerExplicit1, "MarshalStructAsParam_AsExpByValInnerExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerExplicit2id:
                    InnerExplicit2 sourceInnerExplicit2 = new InnerExplicit2();
                    sourceInnerExplicit2.f1 = 1;
                    sourceInnerExplicit2.f3 = "some string";
                    InnerExplicit2 cloneInnerExplicit2 = new InnerExplicit2();
                    cloneInnerExplicit2.f1 = 1;
                    cloneInnerExplicit2.f3 = "some string";

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInnerExplicit2...");
                    if (!MarshalStructAsParam_AsExpByValInnerExplicit2(sourceInnerExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInnerExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit2(sourceInnerExplicit2, cloneInnerExplicit2, "MarshalStructAsParam_AsExpByValInnerExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit1id:
                    InnerArrayExplicit1 sourceInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");
                    InnerArrayExplicit1 cloneInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInnerArrayExplicit1...");
                    if (!MarshalStructAsParam_AsExpByValInnerArrayExplicit1(sourceInnerArrayExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInnerArrayExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit1(sourceInnerArrayExplicit1, cloneInnerArrayExplicit1, "MarshalStructAsParam_AsExpByValInnerArrayExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit2id:
                    InnerArrayExplicit2 sourceInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");
                    InnerArrayExplicit2 cloneInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInnerArrayExplicit2...");
                    if (!MarshalStructAsParam_AsExpByValInnerArrayExplicit2(sourceInnerArrayExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInnerArrayExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit2(sourceInnerArrayExplicit2, cloneInnerArrayExplicit2, "MarshalStructAsParam_AsExpByValInnerArrayExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.NumberExplicitid:
                    NumberExplicit sourceNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);
                    NumberExplicit cloneNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValNumberExplicit...");
                    if (!MarshalStructAsParam_AsExpByValNumberExplicit(sourceNumberExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValNumberExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateNumberExplicit(sourceNumberExplicit, cloneNumberExplicit, "MarshalStructAsParam_AsExpByValNumberExplicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ByteStructPack2Explicitid:
                    ByteStructPack2Explicit sourceByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    ByteStructPack2Explicit cloneByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValByteStructPack2Explicit...");
                    if (!MarshalStructAsParam_AsExpByValByteStructPack2Explicit(sourceByteStructPack2Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValByteStructPack2Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateByteStructPack2Explicit(sourceByteStructPack2Explicit, 
                        cloneByteStructPack2Explicit, "MarshalStructAsParam_AsExpByValByteStructPack2Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ShortStructPack4Explicitid:
                    ShortStructPack4Explicit sourceShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    ShortStructPack4Explicit cloneShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValShortStructPack4Explicit...");
                    if (!MarshalStructAsParam_AsExpByValShortStructPack4Explicit(sourceShortStructPack4Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValShortStructPack4Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateShortStructPack4Explicit(sourceShortStructPack4Explicit, 
                        cloneShortStructPack4Explicit, "MarshalStructAsParam_AsExpByValShortStructPack4Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.IntStructPack8Explicitid:
                    IntStructPack8Explicit sourceIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    IntStructPack8Explicit cloneIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValIntStructPack8Explicit...");
                    if (!MarshalStructAsParam_AsExpByValIntStructPack8Explicit(sourceIntStructPack8Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValIntStructPack8Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateIntStructPack8Explicit(sourceIntStructPack8Explicit, 
                        cloneIntStructPack8Explicit, "MarshalStructAsParam_AsExpByValIntStructPack8Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.LongStructPack16Explicitid:
                    LongStructPack16Explicit sourceLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    LongStructPack16Explicit cloneLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValLongStructPack16Explicit...");
                    if (!MarshalStructAsParam_AsExpByValLongStructPack16Explicit(sourceLongStructPack16Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValLongStructPack16Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateLongStructPack16Explicit(sourceLongStructPack16Explicit, 
                        cloneLongStructPack16Explicit, "MarshalStructAsParam_AsExpByValLongStructPack16Explicit"))
                    {
                        failures++;
                    }
                    break;
                default:
                    Console.WriteLine("\tThere is not the struct id");
                    failures++;
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Exception:" + e.ToString());
            failures++;
        }
    }

    private static void MarshalStructAsParam_AsExpByRef(StructID id)
    {
        try
        {
            switch (id)
            {
                case StructID.InnerExplicit1id:
                    InnerExplicit1 sourceInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");
                    InnerExplicit1 changeInnerExplicit1 = Helper.NewInnerExplicit1(77, 77.0F, "changed string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInnerExplicit1...");
                    if (!MarshalStructAsParam_AsExpByRefInnerExplicit1(ref sourceInnerExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInnerExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit1(sourceInnerExplicit1, changeInnerExplicit1, "MarshalStructAsParam_AsExpByRefInnerExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerExplicit2id:
                    InnerExplicit2 sourceInnerExplicit2 = new InnerExplicit2();
                    sourceInnerExplicit2.f1 = 1;
                    sourceInnerExplicit2.f3 = "some string";
                    InnerExplicit2 changeInnerExplicit2 = new InnerExplicit2();
                    changeInnerExplicit2.f1 = 77;
                    changeInnerExplicit2.f3 = "changed string";

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInnerExplicit2...");
                    if (!MarshalStructAsParam_AsExpByRefInnerExplicit2(ref sourceInnerExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInnerExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit2(sourceInnerExplicit2, changeInnerExplicit2, "MarshalStructAsParam_AsExpByRefInnerExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit1id:
                    InnerArrayExplicit1 sourceInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");
                    InnerArrayExplicit1 changeInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(77, 77.0F, "change string1", "change string2");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInnerArrayExplicit1...");
                    if (!MarshalStructAsParam_AsExpByRefInnerArrayExplicit1(ref sourceInnerArrayExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInnerArrayExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit1(sourceInnerArrayExplicit1, changeInnerArrayExplicit1, "MarshalStructAsParam_AsExpByRefInnerArrayExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit2id:
                    InnerArrayExplicit2 sourceInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");
                    InnerArrayExplicit2 changeInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(77, 77.0F, "changed string", "changed string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInnerArrayExplicit2...");
                    if (!MarshalStructAsParam_AsExpByRefInnerArrayExplicit2(ref sourceInnerArrayExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInnerArrayExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit2(sourceInnerArrayExplicit2, changeInnerArrayExplicit2, "MarshalStructAsParam_AsExpByRefInnerArrayExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.NumberExplicitid:
                    NumberExplicit sourceNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);
                    NumberExplicit changeNumberExplicit = Helper.NewNumberExplicit(Int32.MaxValue, UInt32.MinValue, new IntPtr(-64), 
                        new UIntPtr(64), short.MaxValue, ushort.MinValue, byte.MaxValue, sbyte.MinValue, long.MaxValue, ulong.MinValue, 64.0F, 6.4);

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefNumberExplicit...");
                    if (!MarshalStructAsParam_AsExpByRefNumberExplicit(ref sourceNumberExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefNumberExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateNumberExplicit(sourceNumberExplicit, changeNumberExplicit, "MarshalStructAsParam_AsExpByRefNumberExplicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ByteStructPack2Explicitid:
                    ByteStructPack2Explicit sourceByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    ByteStructPack2Explicit changeByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefByteStructPack2Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefByteStructPack2Explicit(ref sourceByteStructPack2Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefByteStructPack2Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateByteStructPack2Explicit(sourceByteStructPack2Explicit, 
                        changeByteStructPack2Explicit, "MarshalStructAsParam_AsExpByRefByteStructPack2Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ShortStructPack4Explicitid:
                    ShortStructPack4Explicit sourceShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    ShortStructPack4Explicit changeShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefShortStructPack4Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefShortStructPack4Explicit(ref sourceShortStructPack4Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefShortStructPack4Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateShortStructPack4Explicit(sourceShortStructPack4Explicit, 
                        changeShortStructPack4Explicit, "MarshalStructAsParam_AsExpByRefShortStructPack4Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.IntStructPack8Explicitid:
                    IntStructPack8Explicit sourceIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    IntStructPack8Explicit changeIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefIntStructPack8Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefIntStructPack8Explicit(ref sourceIntStructPack8Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefIntStructPack8Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateIntStructPack8Explicit(sourceIntStructPack8Explicit, 
                        changeIntStructPack8Explicit, "MarshalStructAsParam_AsExpByRefIntStructPack8Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.LongStructPack16Explicitid:
                    LongStructPack16Explicit sourceLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    LongStructPack16Explicit changeLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefLongStructPack16Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefLongStructPack16Explicit(ref sourceLongStructPack16Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefLongStructPack16Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateLongStructPack16Explicit(sourceLongStructPack16Explicit, 
                        changeLongStructPack16Explicit, "MarshalStructAsParam_AsExpByRefLongStructPack16Explicit"))
                    {
                        failures++;
                    }
                    break;
                default:
                    Console.WriteLine("\tThere is not the struct id");
                    failures++;
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Exception:" + e.ToString());
            failures++;
        }
    }

    private static void MarshalStructAsParam_AsExpByValIn(StructID id)
    {
        try
        {
            switch (id)
            {
                case StructID.InnerExplicit1id:
                    InnerExplicit1 sourceInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");
                    InnerExplicit1 cloneInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInInnerExplicit1...");
                    if (!MarshalStructAsParam_AsExpByValInInnerExplicit1(sourceInnerExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInInnerExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit1(sourceInnerExplicit1, cloneInnerExplicit1, "MarshalStructAsParam_AsExpByValInInnerExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerExplicit2id:
                    InnerExplicit2 sourceInnerExplicit2 = new InnerExplicit2();
                    sourceInnerExplicit2.f1 = 1;
                    sourceInnerExplicit2.f3 = "some string";
                    InnerExplicit2 cloneInnerExplicit2 = new InnerExplicit2();
                    cloneInnerExplicit2.f1 = 1;
                    cloneInnerExplicit2.f3 = "some string";

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInInnerExplicit2...");
                    if (!MarshalStructAsParam_AsExpByValInInnerExplicit2(sourceInnerExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInInnerExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit2(sourceInnerExplicit2, cloneInnerExplicit2, "MarshalStructAsParam_AsExpByValInInnerExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit1id:
                    InnerArrayExplicit1 sourceInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");
                    InnerArrayExplicit1 cloneInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInInnerArrayExplicit1...");
                    if (!MarshalStructAsParam_AsExpByValInInnerArrayExplicit1(sourceInnerArrayExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInInnerArrayExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit1(sourceInnerArrayExplicit1, cloneInnerArrayExplicit1, "MarshalStructAsParam_AsExpByValInInnerArrayExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit2id:
                    InnerArrayExplicit2 sourceInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");
                    InnerArrayExplicit2 cloneInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInInnerArrayExplicit2...");
                    if (!MarshalStructAsParam_AsExpByValInInnerArrayExplicit2(sourceInnerArrayExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInInnerArrayExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit2(sourceInnerArrayExplicit2, cloneInnerArrayExplicit2, "MarshalStructAsParam_AsExpByValInInnerArrayExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.NumberExplicitid:
                    NumberExplicit sourceNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);
                    NumberExplicit cloneNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInNumberExplicit...");
                    if (!MarshalStructAsParam_AsExpByValInNumberExplicit(sourceNumberExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInNumberExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateNumberExplicit(sourceNumberExplicit, cloneNumberExplicit, "MarshalStructAsParam_AsExpByValInNumberExplicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ByteStructPack2Explicitid:
                    ByteStructPack2Explicit sourceByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    ByteStructPack2Explicit cloneByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInByteStructPack2Explicit...");
                    if (!MarshalStructAsParam_AsExpByValInByteStructPack2Explicit(sourceByteStructPack2Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInByteStructPack2Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateByteStructPack2Explicit(sourceByteStructPack2Explicit, 
                        cloneByteStructPack2Explicit, "MarshalStructAsParam_AsExpByValInByteStructPack2Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ShortStructPack4Explicitid:
                    ShortStructPack4Explicit sourceShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    ShortStructPack4Explicit cloneShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInShortStructPack4Explicit...");
                    if (!MarshalStructAsParam_AsExpByValInShortStructPack4Explicit(sourceShortStructPack4Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInShortStructPack4Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateShortStructPack4Explicit(sourceShortStructPack4Explicit, 
                        cloneShortStructPack4Explicit, "MarshalStructAsParam_AsExpByValInShortStructPack4Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.IntStructPack8Explicitid:
                    IntStructPack8Explicit sourceIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    IntStructPack8Explicit cloneIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInIntStructPack8Explicit...");
                    if (!MarshalStructAsParam_AsExpByValInIntStructPack8Explicit(sourceIntStructPack8Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInIntStructPack8Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateIntStructPack8Explicit(sourceIntStructPack8Explicit, 
                        cloneIntStructPack8Explicit, "MarshalStructAsParam_AsExpByValInIntStructPack8Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.LongStructPack16Explicitid:
                    LongStructPack16Explicit sourceLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    LongStructPack16Explicit cloneLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInLongStructPack16Explicit...");
                    if (!MarshalStructAsParam_AsExpByValInLongStructPack16Explicit(sourceLongStructPack16Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInLongStructPack16Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateLongStructPack16Explicit(sourceLongStructPack16Explicit, 
                        cloneLongStructPack16Explicit, "MarshalStructAsParam_AsExpByValInLongStructPack16Explicit"))
                    {
                        failures++;
                    }
                    break;
                default:
                    Console.WriteLine("\tThere is not the struct id");
                    failures++;
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Exception:" + e.ToString());
            failures++;
        }
    }

    private static void MarshalStructAsParam_AsExpByRefIn(StructID id)
    {
        try
        {
            switch (id)
            {
                case StructID.InnerExplicit1id:
                    InnerExplicit1 sourceInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");
                    InnerExplicit1 changeInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInInnerExplicit1...");
                    if (!MarshalStructAsParam_AsExpByRefInInnerExplicit1(ref sourceInnerExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInInnerExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit1(sourceInnerExplicit1, changeInnerExplicit1, "MarshalStructAsParam_AsExpByRefInInnerExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerExplicit2id:
                    InnerExplicit2 sourceInnerExplicit2 = new InnerExplicit2();
                    sourceInnerExplicit2.f1 = 1;
                    sourceInnerExplicit2.f3 = "some string";
                    InnerExplicit2 changeInnerExplicit2 = new InnerExplicit2();
                    changeInnerExplicit2.f1 = 1;
                    changeInnerExplicit2.f3 = "some string";

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInInnerExplicit2...");
                    if (!MarshalStructAsParam_AsExpByRefInInnerExplicit2(ref sourceInnerExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInInnerExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit2(sourceInnerExplicit2, changeInnerExplicit2, "MarshalStructAsParam_AsExpByRefInInnerExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit1id:
                    InnerArrayExplicit1 sourceInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");
                    InnerArrayExplicit1 changeInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInInnerArrayExplicit1...");
                    if (!MarshalStructAsParam_AsExpByRefInInnerArrayExplicit1(ref sourceInnerArrayExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInInnerArrayExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit1(sourceInnerArrayExplicit1, changeInnerArrayExplicit1, "MarshalStructAsParam_AsExpByRefInInnerArrayExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit2id:
                    InnerArrayExplicit2 sourceInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");
                    InnerArrayExplicit2 changeInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInInnerArrayExplicit2...");
                    if (!MarshalStructAsParam_AsExpByRefInInnerArrayExplicit2(ref sourceInnerArrayExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInInnerArrayExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit2(sourceInnerArrayExplicit2, changeInnerArrayExplicit2, "MarshalStructAsParam_AsExpByRefInInnerArrayExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.NumberExplicitid:
                    NumberExplicit sourceNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);
                    NumberExplicit changeNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInNumberExplicit...");
                    if (!MarshalStructAsParam_AsExpByRefInNumberExplicit(ref sourceNumberExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInNumberExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateNumberExplicit(sourceNumberExplicit, changeNumberExplicit, "MarshalStructAsParam_AsExpByRefInNumberExplicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ByteStructPack2Explicitid:
                    ByteStructPack2Explicit sourceByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    ByteStructPack2Explicit changeByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInByteStructPack2Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefInByteStructPack2Explicit(ref sourceByteStructPack2Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInByteStructPack2Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateByteStructPack2Explicit(sourceByteStructPack2Explicit, 
                        changeByteStructPack2Explicit, "MarshalStructAsParam_AsExpByRefInByteStructPack2Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ShortStructPack4Explicitid:
                    ShortStructPack4Explicit sourceShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    ShortStructPack4Explicit changeShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInShortStructPack4Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefInShortStructPack4Explicit(ref sourceShortStructPack4Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInShortStructPack4Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateShortStructPack4Explicit(sourceShortStructPack4Explicit, 
                        changeShortStructPack4Explicit, "MarshalStructAsParam_AsExpByRefInShortStructPack4Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.IntStructPack8Explicitid:
                    IntStructPack8Explicit sourceIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    IntStructPack8Explicit changeIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInIntStructPack8Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefInIntStructPack8Explicit(ref sourceIntStructPack8Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInIntStructPack8Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateIntStructPack8Explicit(sourceIntStructPack8Explicit, 
                        changeIntStructPack8Explicit, "MarshalStructAsParam_AsExpByRefInIntStructPack8Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.LongStructPack16Explicitid:
                    LongStructPack16Explicit sourceLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    LongStructPack16Explicit changeLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInLongStructPack16Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefInLongStructPack16Explicit(ref sourceLongStructPack16Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInLongStructPack16Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateLongStructPack16Explicit(sourceLongStructPack16Explicit, 
                        changeLongStructPack16Explicit, "MarshalStructAsParam_AsExpByRefInLongStructPack16Explicit"))
                    {
                        failures++;
                    }
                    break;
                default:
                    Console.WriteLine("\tThere is not the struct id");
                    failures++;
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Exception:" + e.ToString());
            failures++;
        }
    }

    private static void MarshalStructAsParam_AsExpByValOut(StructID id)
    {
        try
        {
            switch (id)
            {
                case StructID.InnerExplicit1id:
                    InnerExplicit1 sourceInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");
                    InnerExplicit1 cloneInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutInnerExplicit1...");
                    if (!MarshalStructAsParam_AsExpByValOutInnerExplicit1(sourceInnerExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutInnerExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit1(sourceInnerExplicit1, cloneInnerExplicit1, "MarshalStructAsParam_AsExpByValOutInnerExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerExplicit2id:
                    InnerExplicit2 sourceInnerExplicit2 = new InnerExplicit2();
                    sourceInnerExplicit2.f1 = 1;
                    sourceInnerExplicit2.f3 = "some string";
                    InnerExplicit2 cloneInnerExplicit2 = new InnerExplicit2();
                    cloneInnerExplicit2.f1 = 1;
                    cloneInnerExplicit2.f3 = "some string";

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutInnerExplicit2...");
                    if (!MarshalStructAsParam_AsExpByValOutInnerExplicit2(sourceInnerExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutInnerExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit2(sourceInnerExplicit2, cloneInnerExplicit2, "MarshalStructAsParam_AsExpByValOutInnerExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit1id:
                    InnerArrayExplicit1 sourceInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");
                    InnerArrayExplicit1 cloneInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutInnerArrayExplicit1...");
                    if (!MarshalStructAsParam_AsExpByValOutInnerArrayExplicit1(sourceInnerArrayExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutInnerArrayExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit1(sourceInnerArrayExplicit1, cloneInnerArrayExplicit1, "MarshalStructAsParam_AsExpByValOutInnerArrayExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit2id:
                    InnerArrayExplicit2 sourceInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");
                    InnerArrayExplicit2 cloneInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutInnerArrayExplicit2...");
                    if (!MarshalStructAsParam_AsExpByValOutInnerArrayExplicit2(sourceInnerArrayExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutInnerArrayExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit2(sourceInnerArrayExplicit2, cloneInnerArrayExplicit2, "MarshalStructAsParam_AsExpByValOutInnerArrayExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.NumberExplicitid:
                    NumberExplicit sourceNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);
                    NumberExplicit cloneNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutNumberExplicit...");
                    if (!MarshalStructAsParam_AsExpByValOutNumberExplicit(sourceNumberExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutNumberExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateNumberExplicit(sourceNumberExplicit, cloneNumberExplicit, "MarshalStructAsParam_AsExpByValOutNumberExplicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ByteStructPack2Explicitid:
                    ByteStructPack2Explicit sourceByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    ByteStructPack2Explicit cloneByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutByteStructPack2Explicit...");
                    if (!MarshalStructAsParam_AsExpByValOutByteStructPack2Explicit(sourceByteStructPack2Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutByteStructPack2Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateByteStructPack2Explicit(sourceByteStructPack2Explicit, 
                        cloneByteStructPack2Explicit, "MarshalStructAsParam_AsExpByValOutByteStructPack2Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ShortStructPack4Explicitid:
                    ShortStructPack4Explicit sourceShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    ShortStructPack4Explicit cloneShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutShortStructPack4Explicit...");
                    if (!MarshalStructAsParam_AsExpByValOutShortStructPack4Explicit(sourceShortStructPack4Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutShortStructPack4Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateShortStructPack4Explicit(sourceShortStructPack4Explicit, 
                        cloneShortStructPack4Explicit, "MarshalStructAsParam_AsExpByValOutShortStructPack4Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.IntStructPack8Explicitid:
                    IntStructPack8Explicit sourceIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    IntStructPack8Explicit cloneIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutIntStructPack8Explicit...");
                    if (!MarshalStructAsParam_AsExpByValOutIntStructPack8Explicit(sourceIntStructPack8Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutIntStructPack8Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateIntStructPack8Explicit(sourceIntStructPack8Explicit, 
                        cloneIntStructPack8Explicit, "MarshalStructAsParam_AsExpByValOutIntStructPack8Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.LongStructPack16Explicitid:
                    LongStructPack16Explicit sourceLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    LongStructPack16Explicit cloneLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValOutLongStructPack16Explicit...");
                    if (!MarshalStructAsParam_AsExpByValOutLongStructPack16Explicit(sourceLongStructPack16Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValOutLongStructPack16Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateLongStructPack16Explicit(sourceLongStructPack16Explicit, 
                        cloneLongStructPack16Explicit, "MarshalStructAsParam_AsExpByValOutLongStructPack16Explicit"))
                    {
                        failures++;
                    }
                    break;
                default:
                    Console.WriteLine("\tThere is not the struct id");
                    failures++;
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Exception:" + e.ToString());
            failures++;
        }
    }
   
    private static void MarshalStructAsParam_AsExpByRefOut(StructID id)
    {
        try
        {
            switch (id)
            {
                case StructID.InnerExplicit1id:
                    InnerExplicit1 sourceInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");
                    InnerExplicit1 changeInnerExplicit1 = Helper.NewInnerExplicit1(77, 77.0F, "changed string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutInnerExplicit1...");
                    if (!MarshalStructAsParam_AsExpByRefOutInnerExplicit1(out sourceInnerExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutInnerExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit1(sourceInnerExplicit1, changeInnerExplicit1, "MarshalStructAsParam_AsExpByRefOutInnerExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerExplicit2id:
                    InnerExplicit2 sourceInnerExplicit2 = new InnerExplicit2();
                    sourceInnerExplicit2.f1 = 1;
                    sourceInnerExplicit2.f3 = "some string";
                    InnerExplicit2 changeInnerExplicit2 = new InnerExplicit2();
                    changeInnerExplicit2.f1 = 77;
                    changeInnerExplicit2.f3 = "changed string";

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutInnerExplicit2...");
                    if (!MarshalStructAsParam_AsExpByRefOutInnerExplicit2(out sourceInnerExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutInnerExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit2(sourceInnerExplicit2, changeInnerExplicit2, "MarshalStructAsParam_AsExpByRefOutInnerExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit1id:
                    InnerArrayExplicit1 sourceInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");
                    InnerArrayExplicit1 changeInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(77, 77.0F, "change string1", "change string2");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit1...");
                    if (!MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit1(out sourceInnerArrayExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit1(sourceInnerArrayExplicit1, changeInnerArrayExplicit1, "MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit2id:
                    InnerArrayExplicit2 sourceInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");
                    InnerArrayExplicit2 changeInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(77, 77.0F, "changed string", "changed string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit2...");
                    if (!MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit2(out sourceInnerArrayExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit2(sourceInnerArrayExplicit2, changeInnerArrayExplicit2, "MarshalStructAsParam_AsExpByRefOutInnerArrayExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.NumberExplicitid:
                    NumberExplicit sourceNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);
                    NumberExplicit changeNumberExplicit = Helper.NewNumberExplicit(Int32.MaxValue, UInt32.MinValue, new IntPtr(-64), 
                        new UIntPtr(64), short.MaxValue, ushort.MinValue, byte.MaxValue, sbyte.MinValue, long.MaxValue, ulong.MinValue, 64.0F, 6.4);

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutNumberExplicit...");
                    if (!MarshalStructAsParam_AsExpByRefOutNumberExplicit(out sourceNumberExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutNumberExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateNumberExplicit(sourceNumberExplicit, changeNumberExplicit, "MarshalStructAsParam_AsExpByRefOutNumberExplicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ByteStructPack2Explicitid:
                    ByteStructPack2Explicit sourceByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    ByteStructPack2Explicit changeByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutByteStructPack2Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefOutByteStructPack2Explicit(out sourceByteStructPack2Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutByteStructPack2Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateByteStructPack2Explicit(sourceByteStructPack2Explicit, 
                        changeByteStructPack2Explicit, "MarshalStructAsParam_AsExpByRefOutByteStructPack2Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ShortStructPack4Explicitid:
                    ShortStructPack4Explicit sourceShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    ShortStructPack4Explicit changeShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutShortStructPack4Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefOutShortStructPack4Explicit(out sourceShortStructPack4Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutShortStructPack4Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateShortStructPack4Explicit(sourceShortStructPack4Explicit, 
                        changeShortStructPack4Explicit, "MarshalStructAsParam_AsExpByRefOutShortStructPack4Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.IntStructPack8Explicitid:
                    IntStructPack8Explicit sourceIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    IntStructPack8Explicit changeIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutIntStructPack8Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefOutIntStructPack8Explicit(out sourceIntStructPack8Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutIntStructPack8Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateIntStructPack8Explicit(sourceIntStructPack8Explicit, 
                        changeIntStructPack8Explicit, "MarshalStructAsParam_AsExpByRefOutIntStructPack8Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.LongStructPack16Explicitid:
                    LongStructPack16Explicit sourceLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    LongStructPack16Explicit changeLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefOutLongStructPack16Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefOutLongStructPack16Explicit(out sourceLongStructPack16Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefOutLongStructPack16Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateLongStructPack16Explicit(sourceLongStructPack16Explicit, 
                        changeLongStructPack16Explicit, "MarshalStructAsParam_AsExpByRefOutLongStructPack16Explicit"))
                    {
                        failures++;
                    }
                    break;
                default:
                    Console.WriteLine("\tThere is not the struct id");
                    failures++;
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Exception:" + e.ToString());
            failures++;
        }
    }

    private static void MarshalStructAsParam_AsExpByValInOut(StructID id)
    {
        try
        {
            switch (id)
            {
                case StructID.InnerExplicit1id:
                    InnerExplicit1 sourceInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");
                    InnerExplicit1 cloneInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutInnerExplicit1...");
                    if (!MarshalStructAsParam_AsExpByValInOutInnerExplicit1(sourceInnerExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutInnerExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit1(sourceInnerExplicit1, cloneInnerExplicit1, "MarshalStructAsParam_AsExpByValInOutInnerExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerExplicit2id:
                    InnerExplicit2 sourceInnerExplicit2 = new InnerExplicit2();
                    sourceInnerExplicit2.f1 = 1;
                    sourceInnerExplicit2.f3 = "some string";
                    InnerExplicit2 cloneInnerExplicit2 = new InnerExplicit2();
                    cloneInnerExplicit2.f1 = 1;
                    cloneInnerExplicit2.f3 = "some string";

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutInnerExplicit2...");
                    if (!MarshalStructAsParam_AsExpByValInOutInnerExplicit2(sourceInnerExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutInnerExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit2(sourceInnerExplicit2, cloneInnerExplicit2, "MarshalStructAsParam_AsExpByValInOutInnerExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit1id:
                    InnerArrayExplicit1 sourceInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");
                    InnerArrayExplicit1 cloneInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit1...");
                    if (!MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit1(sourceInnerArrayExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit1(sourceInnerArrayExplicit1, cloneInnerArrayExplicit1, "MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit2id:
                    InnerArrayExplicit2 sourceInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");
                    InnerArrayExplicit2 cloneInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit2...");
                    if (!MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit2(sourceInnerArrayExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit2(sourceInnerArrayExplicit2, cloneInnerArrayExplicit2, "MarshalStructAsParam_AsExpByValInOutInnerArrayExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.NumberExplicitid:
                    NumberExplicit sourceNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);
                    NumberExplicit cloneNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutNumberExplicit...");
                    if (!MarshalStructAsParam_AsExpByValInOutNumberExplicit(sourceNumberExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutNumberExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateNumberExplicit(sourceNumberExplicit, cloneNumberExplicit, "MarshalStructAsParam_AsExpByValInOutNumberExplicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ByteStructPack2Explicitid:
                    ByteStructPack2Explicit sourceByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    ByteStructPack2Explicit cloneByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutByteStructPack2Explicit...");
                    if (!MarshalStructAsParam_AsExpByValInOutByteStructPack2Explicit(sourceByteStructPack2Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutByteStructPack2Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateByteStructPack2Explicit(sourceByteStructPack2Explicit, 
                        cloneByteStructPack2Explicit, "MarshalStructAsParam_AsExpByValInOutByteStructPack2Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ShortStructPack4Explicitid:
                    ShortStructPack4Explicit sourceShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    ShortStructPack4Explicit cloneShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutShortStructPack4Explicit...");
                    if (!MarshalStructAsParam_AsExpByValInOutShortStructPack4Explicit(sourceShortStructPack4Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutShortStructPack4Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateShortStructPack4Explicit(sourceShortStructPack4Explicit, 
                        cloneShortStructPack4Explicit, "MarshalStructAsParam_AsExpByValInOutShortStructPack4Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.IntStructPack8Explicitid:
                    IntStructPack8Explicit sourceIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    IntStructPack8Explicit cloneIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutIntStructPack8Explicit...");
                    if (!MarshalStructAsParam_AsExpByValInOutIntStructPack8Explicit(sourceIntStructPack8Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutIntStructPack8Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateIntStructPack8Explicit(sourceIntStructPack8Explicit, 
                        cloneIntStructPack8Explicit, "MarshalStructAsParam_AsExpByValInOutIntStructPack8Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.LongStructPack16Explicitid:
                    LongStructPack16Explicit sourceLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    LongStructPack16Explicit cloneLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByValInOutLongStructPack16Explicit...");
                    if (!MarshalStructAsParam_AsExpByValInOutLongStructPack16Explicit(sourceLongStructPack16Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByValInOutLongStructPack16Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateLongStructPack16Explicit(sourceLongStructPack16Explicit, 
                        cloneLongStructPack16Explicit, "MarshalStructAsParam_AsExpByValInOutLongStructPack16Explicit"))
                    {
                        failures++;
                    }
                    break;
                default:
                    Console.WriteLine("\tThere is not the struct id");
                    failures++;
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Exception:" + e.ToString());
            failures++;
        }
    }

    private static void MarshalStructAsParam_AsExpByRefInOut(StructID id)
    {
        try
        {
            switch (id)
            {
                case StructID.InnerExplicit1id:
                    InnerExplicit1 sourceInnerExplicit1 = Helper.NewInnerExplicit1(1, 1.0F, "some string");
                    InnerExplicit1 changeInnerExplicit1 = Helper.NewInnerExplicit1(77, 77.0F, "changed string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutInnerExplicit1...");
                    if (!MarshalStructAsParam_AsExpByRefInOutInnerExplicit1(ref sourceInnerExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutInnerExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit1(sourceInnerExplicit1, changeInnerExplicit1, "MarshalStructAsParam_AsExpByRefInOutInnerExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerExplicit2id:
                    InnerExplicit2 sourceInnerExplicit2 = new InnerExplicit2();
                    sourceInnerExplicit2.f1 = 1;
                    sourceInnerExplicit2.f3 = "some string";
                    InnerExplicit2 changeInnerExplicit2 = new InnerExplicit2();
                    changeInnerExplicit2.f1 = 77;
                    changeInnerExplicit2.f3 = "changed string";

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutInnerExplicit2...");
                    if (!MarshalStructAsParam_AsExpByRefInOutInnerExplicit2(ref sourceInnerExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutInnerExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerExplicit2(sourceInnerExplicit2, changeInnerExplicit2, "MarshalStructAsParam_AsExpByRefInOutInnerExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit1id:
                    InnerArrayExplicit1 sourceInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(1, 1.0F, "some string1", "some string2");
                    InnerArrayExplicit1 changeInnerArrayExplicit1 = Helper.NewInnerArrayExplicit1(77, 77.0F, "change string1", "change string2");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit1...");
                    if (!MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit1(ref sourceInnerArrayExplicit1))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit1.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit1(sourceInnerArrayExplicit1, changeInnerArrayExplicit1, "MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit1"))
                    {
                        failures++;
                    }
                    break;
                case StructID.InnerArrayExplicit2id:
                    InnerArrayExplicit2 sourceInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(1, 1.0F, "some string", "some string");
                    InnerArrayExplicit2 changeInnerArrayExplicit2 = Helper.NewInnerArrayExplicit2(77, 77.0F, "changed string", "changed string");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit2...");
                    if (!MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit2(ref sourceInnerArrayExplicit2))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit2.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateInnerArrayExplicit2(sourceInnerArrayExplicit2, changeInnerArrayExplicit2, "MarshalStructAsParam_AsExpByRefInOutInnerArrayExplicit2"))
                    {
                        failures++;
                    }
                    break;
                case StructID.NumberExplicitid:
                    NumberExplicit sourceNumberExplicit = Helper.NewNumberExplicit(Int32.MinValue, UInt32.MaxValue, new IntPtr(-32), 
                        new UIntPtr(32), short.MinValue, ushort.MaxValue, byte.MinValue, sbyte.MaxValue, long.MinValue, ulong.MaxValue, 32.0F, 3.2);
                    NumberExplicit changeNumberExplicit = Helper.NewNumberExplicit(Int32.MaxValue, UInt32.MinValue, new IntPtr(-64), 
                        new UIntPtr(64), short.MaxValue, ushort.MinValue, byte.MaxValue, sbyte.MinValue, long.MaxValue, ulong.MinValue, 64.0F, 6.4);

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutNumberExplicit...");
                    if (!MarshalStructAsParam_AsExpByRefInOutNumberExplicit(ref sourceNumberExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutNumberExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateNumberExplicit(sourceNumberExplicit, changeNumberExplicit, "MarshalStructAsParam_AsExpByRefInOutNumberExplicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ByteStructPack2Explicitid:
                    ByteStructPack2Explicit sourceByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(32, 32);
                    ByteStructPack2Explicit changeByteStructPack2Explicit = Helper.NewByteStructPack2Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutByteStructPack2Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefInOutByteStructPack2Explicit(ref sourceByteStructPack2Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutByteStructPack2Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateByteStructPack2Explicit(sourceByteStructPack2Explicit, 
                        changeByteStructPack2Explicit, "MarshalStructAsParam_AsExpByRefInOutByteStructPack2Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.ShortStructPack4Explicitid:
                    ShortStructPack4Explicit sourceShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(32, 32);
                    ShortStructPack4Explicit changeShortStructPack4Explicit = Helper.NewShortStructPack4Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutShortStructPack4Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefInOutShortStructPack4Explicit(ref sourceShortStructPack4Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutShortStructPack4Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateShortStructPack4Explicit(sourceShortStructPack4Explicit, 
                        changeShortStructPack4Explicit, "MarshalStructAsParam_AsExpByRefInOutShortStructPack4Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.IntStructPack8Explicitid:
                    IntStructPack8Explicit sourceIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(32, 32);
                    IntStructPack8Explicit changeIntStructPack8Explicit = Helper.NewIntStructPack8Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutIntStructPack8Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefInOutIntStructPack8Explicit(ref sourceIntStructPack8Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutIntStructPack8Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateIntStructPack8Explicit(sourceIntStructPack8Explicit, 
                        changeIntStructPack8Explicit, "MarshalStructAsParam_AsExpByRefInOutIntStructPack8Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.LongStructPack16Explicitid:
                    LongStructPack16Explicit sourceLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(32, 32);
                    LongStructPack16Explicit changeLongStructPack16Explicit = Helper.NewLongStructPack16Explicit(64, 64);
                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutLongStructPack16Explicit...");
                    if (!MarshalStructAsParam_AsExpByRefInOutLongStructPack16Explicit(ref sourceLongStructPack16Explicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutLongStructPack16Explicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateLongStructPack16Explicit(sourceLongStructPack16Explicit, 
                        changeLongStructPack16Explicit, "MarshalStructAsParam_AsExpByRefInOutLongStructPack16Explicit"))
                    {
                        failures++;
                    }
                    break;
                case StructID.StringExplicitid:
                    StringExplicit sourceStringExplicit = Helper.NewStringExplicit("Native_LPCSTR", "Native_LPCSTR", "ggggggggg\0");
                    StringExplicit changeStringExplicit = Helper.NewStringExplicit("Managed_LPCSTR", "Managed_LPCSTR", "bbbbbbbbb\0");

                    Console.WriteLine("\tCalling MarshalStructAsParam_AsExpByRefInOutStringExplicit...");
                    if (!MarshalStructAsParam_AsExpByRefInOutStringExplicit(ref sourceStringExplicit))
                    {
                        Console.WriteLine("\tFAILED! Managed to Native failed in MarshalStructAsParam_AsExpByRefInOutStringExplicit.Expected:True;Actual:False");
                        failures++;
                    }
                    if (!Helper.ValidateStringExplicit(sourceStringExplicit, changeStringExplicit, "MarshalStructAsParam_AsExpByRefInOutStringExplicit"))
                    {
                        Console.WriteLine("Changed stringexplicit:");
                        Helper.PrintStringExplicit(sourceStringExplicit, "StringExplicit");
                        failures++;
                    }
                    break;
                default:
                    Console.WriteLine("\tThere is not the struct id");
                    failures++;
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Exception:" + e.ToString());
            failures++;
        }
    }

    #endregion

    private static void RunMarshalStructAsParamAsExpByVal()
    {
        Console.WriteLine("\nVerify marshal Explicit layout struct as param as ByVal");
        MarshalStructAsParam_AsExpByVal(StructID.InnerExplicit1id);
        MarshalStructAsParam_AsExpByVal(StructID.InnerExplicit2id);
        MarshalStructAsParam_AsExpByVal(StructID.InnerArrayExplicit1id);
        MarshalStructAsParam_AsExpByVal(StructID.InnerArrayExplicit2id);
        MarshalStructAsParam_AsExpByVal(StructID.NumberExplicitid);
        MarshalStructAsParam_AsExpByVal(StructID.ByteStructPack2Explicitid);
        MarshalStructAsParam_AsExpByVal(StructID.ShortStructPack4Explicitid);
        MarshalStructAsParam_AsExpByVal(StructID.IntStructPack8Explicitid);
        MarshalStructAsParam_AsExpByVal(StructID.LongStructPack16Explicitid);
    }

    private static void RunMarshalStructAsParamAsExpByRef()
    {
        Console.WriteLine("\nVerify marshal Explicit layout struct as param as ByRef");
        MarshalStructAsParam_AsExpByRef(StructID.InnerExplicit1id);
        MarshalStructAsParam_AsExpByRef(StructID.InnerExplicit2id);
        MarshalStructAsParam_AsExpByRef(StructID.InnerArrayExplicit1id);
        MarshalStructAsParam_AsExpByRef(StructID.InnerArrayExplicit2id);
        MarshalStructAsParam_AsExpByRef(StructID.NumberExplicitid);
        MarshalStructAsParam_AsExpByRef(StructID.ByteStructPack2Explicitid);
        MarshalStructAsParam_AsExpByRef(StructID.ShortStructPack4Explicitid);
        MarshalStructAsParam_AsExpByRef(StructID.IntStructPack8Explicitid);
        MarshalStructAsParam_AsExpByRef(StructID.LongStructPack16Explicitid);
    }

    private static void RunMarshalStructAsParamAsExpByValIn()
    {
        Console.WriteLine("\nVerify marshal Explicit layout struct as param as ByValIn");
        MarshalStructAsParam_AsExpByValIn(StructID.InnerExplicit1id);
        MarshalStructAsParam_AsExpByValIn(StructID.InnerExplicit2id);
        MarshalStructAsParam_AsExpByValIn(StructID.InnerArrayExplicit1id);
        MarshalStructAsParam_AsExpByValIn(StructID.InnerArrayExplicit2id);
        MarshalStructAsParam_AsExpByValIn(StructID.NumberExplicitid);
        MarshalStructAsParam_AsExpByValIn(StructID.ByteStructPack2Explicitid);
        MarshalStructAsParam_AsExpByValIn(StructID.ShortStructPack4Explicitid);
        MarshalStructAsParam_AsExpByValIn(StructID.IntStructPack8Explicitid);
        MarshalStructAsParam_AsExpByValIn(StructID.LongStructPack16Explicitid);
    }

    private static void RunMarshalStructAsParamAsExpByRefIn()
    {
        Console.WriteLine("\nVerify marshal Explicit layout struct as param as ByRefIn");
        MarshalStructAsParam_AsExpByRefIn(StructID.InnerExplicit1id);
        MarshalStructAsParam_AsExpByRefIn(StructID.InnerExplicit2id);
        MarshalStructAsParam_AsExpByRefIn(StructID.InnerArrayExplicit1id);
        MarshalStructAsParam_AsExpByRefIn(StructID.InnerArrayExplicit2id);
        MarshalStructAsParam_AsExpByRefIn(StructID.NumberExplicitid);
        MarshalStructAsParam_AsExpByRefIn(StructID.ByteStructPack2Explicitid);
        MarshalStructAsParam_AsExpByRefIn(StructID.ShortStructPack4Explicitid);
        MarshalStructAsParam_AsExpByRefIn(StructID.IntStructPack8Explicitid);
        MarshalStructAsParam_AsExpByRefIn(StructID.LongStructPack16Explicitid);
    }

    private static void RunMarshalStructAsParamAsExpByValOut()
    {
        Console.WriteLine("\nVerify marshal Explicit layout struct as param as ByValOut");
        MarshalStructAsParam_AsExpByValOut(StructID.InnerExplicit1id);
        MarshalStructAsParam_AsExpByValOut(StructID.InnerExplicit2id);
        MarshalStructAsParam_AsExpByValOut(StructID.InnerArrayExplicit1id);
        MarshalStructAsParam_AsExpByValOut(StructID.InnerArrayExplicit2id);
        MarshalStructAsParam_AsExpByValOut(StructID.NumberExplicitid);
        MarshalStructAsParam_AsExpByValOut(StructID.ByteStructPack2Explicitid);
        MarshalStructAsParam_AsExpByValOut(StructID.ShortStructPack4Explicitid);
        MarshalStructAsParam_AsExpByValOut(StructID.IntStructPack8Explicitid);
        MarshalStructAsParam_AsExpByValOut(StructID.LongStructPack16Explicitid);
    }

    private static void RunMarshalStructAsParamAsExpByRefOut()
    {
        Console.WriteLine("\nVerify marshal Explicit layout struct as param as ByRefOut");
        MarshalStructAsParam_AsExpByRefOut(StructID.InnerExplicit1id);
        MarshalStructAsParam_AsExpByRefOut(StructID.InnerExplicit2id);
        MarshalStructAsParam_AsExpByRefOut(StructID.InnerArrayExplicit1id);
        MarshalStructAsParam_AsExpByRefOut(StructID.InnerArrayExplicit2id);
        MarshalStructAsParam_AsExpByRefOut(StructID.NumberExplicitid);
        MarshalStructAsParam_AsExpByRefOut(StructID.ByteStructPack2Explicitid);
        MarshalStructAsParam_AsExpByRefOut(StructID.ShortStructPack4Explicitid);
        MarshalStructAsParam_AsExpByRefOut(StructID.IntStructPack8Explicitid);
        MarshalStructAsParam_AsExpByRefOut(StructID.LongStructPack16Explicitid);
    }

    private static void RunMarshalStructAsParamAsExpByValInOut()
    {
        Console.WriteLine("\nVerify marshal Explicit layout struct as param as ByValInOut");
        MarshalStructAsParam_AsExpByValInOut(StructID.InnerExplicit1id);
        MarshalStructAsParam_AsExpByValInOut(StructID.InnerExplicit2id);
        MarshalStructAsParam_AsExpByValInOut(StructID.InnerArrayExplicit1id);
        MarshalStructAsParam_AsExpByValInOut(StructID.InnerArrayExplicit2id);
        MarshalStructAsParam_AsExpByValInOut(StructID.NumberExplicitid);
        MarshalStructAsParam_AsExpByValInOut(StructID.ByteStructPack2Explicitid);
        MarshalStructAsParam_AsExpByValInOut(StructID.ShortStructPack4Explicitid);
        MarshalStructAsParam_AsExpByValInOut(StructID.IntStructPack8Explicitid);
        MarshalStructAsParam_AsExpByValInOut(StructID.LongStructPack16Explicitid);
    }

    private static void RunMarshalStructAsParamAsExpByRefInOut()
    {
        Console.WriteLine("\nVerify marshal Explicit layout struct as param as ByRefInOut");
        MarshalStructAsParam_AsExpByRefInOut(StructID.InnerExplicit1id);
        MarshalStructAsParam_AsExpByRefInOut(StructID.StringExplicitid);
        MarshalStructAsParam_AsExpByRefInOut(StructID.InnerExplicit2id);
        MarshalStructAsParam_AsExpByRefInOut(StructID.InnerArrayExplicit1id);
        MarshalStructAsParam_AsExpByRefInOut(StructID.InnerArrayExplicit2id);
        MarshalStructAsParam_AsExpByRefInOut(StructID.NumberExplicitid);
        MarshalStructAsParam_AsExpByRefInOut(StructID.ByteStructPack2Explicitid);
        MarshalStructAsParam_AsExpByRefInOut(StructID.ShortStructPack4Explicitid);
        MarshalStructAsParam_AsExpByRefInOut(StructID.IntStructPack8Explicitid);
        MarshalStructAsParam_AsExpByRefInOut(StructID.LongStructPack16Explicitid);
    }

}