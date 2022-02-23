// Automatically generated by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.Picky.Diplomat;
#pragma warning restore 0105

namespace Devolutions.Picky;

#nullable enable

/// <summary>
/// UTC date and time.
/// </summary>
public partial class UtcDate: IDisposable
{
    private unsafe Raw.UtcDate* _inner;

    public byte Day
    {
        get
        {
            return GetDay();
        }
    }

    public byte Hour
    {
        get
        {
            return GetHour();
        }
    }

    public byte Minute
    {
        get
        {
            return GetMinute();
        }
    }

    public byte Month
    {
        get
        {
            return GetMonth();
        }
    }

    public byte Second
    {
        get
        {
            return GetSecond();
        }
    }

    public long Timestamp
    {
        get
        {
            return GetTimestamp();
        }
    }

    public ushort Year
    {
        get
        {
            return GetYear();
        }
    }

    /// <summary>
    /// Creates a managed <c>UtcDate</c> from a raw handle.
    /// </summary>
    /// <remarks>
    /// Safety: you should not build two managed objects using the same raw handle (may causes use-after-free and double-free).
    /// </remarks>
    /// <remarks>
    /// This constructor assumes the raw struct is allocated on Rust side.
    /// If implemented, the custom Drop implementation on Rust side WILL run on destruction.
    /// </remarks>
    public unsafe UtcDate(Raw.UtcDate* handle)
    {
        _inner = handle;
    }

    /// <returns>
    /// A <c>UtcDate</c> allocated on Rust side.
    /// </returns>
    public static UtcDate? New(ushort year, byte month, byte day, byte hour, byte minute, byte second)
    {
        unsafe
        {
            Raw.UtcDate* retVal = Raw.UtcDate.New(year, month, day, hour, minute, second);
            if (retVal == null)
            {
                return null;
            }
            return new UtcDate(retVal);
        }
    }

    /// <returns>
    /// A <c>UtcDate</c> allocated on Rust side.
    /// </returns>
    public static UtcDate? Ymd(ushort year, byte month, byte day)
    {
        unsafe
        {
            Raw.UtcDate* retVal = Raw.UtcDate.Ymd(year, month, day);
            if (retVal == null)
            {
                return null;
            }
            return new UtcDate(retVal);
        }
    }

    /// <returns>
    /// A <c>UtcDate</c> allocated on Rust side.
    /// </returns>
    public static UtcDate Now()
    {
        unsafe
        {
            Raw.UtcDate* retVal = Raw.UtcDate.Now();
            return new UtcDate(retVal);
        }
    }

    /// <exception cref="PickyException"></exception>
    /// <returns>
    /// A <c>UtcDate</c> allocated on Rust side.
    /// </returns>
    public static UtcDate FromTimestamp(long timestamp)
    {
        unsafe
        {
            IntPtr resultPtr = Raw.UtcDate.FromTimestamp(timestamp);
            Raw.DateFfiResultBoxUtcDateBoxPickyError result = Marshal.PtrToStructure<Raw.DateFfiResultBoxUtcDateBoxPickyError>(resultPtr);
            Raw.DateFfiResultBoxUtcDateBoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
            Raw.UtcDate* retVal = result.Ok;
            return new UtcDate(retVal);
        }
    }

    /// <exception cref="PickyException"></exception>
    public long GetTimestamp()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("UtcDate");
            }
            IntPtr resultPtr = Raw.UtcDate.GetTimestamp(_inner);
            Raw.DateFfiResultI64BoxPickyError result = Marshal.PtrToStructure<Raw.DateFfiResultI64BoxPickyError>(resultPtr);
            Raw.DateFfiResultI64BoxPickyError.Destroy(resultPtr);
            if (!result.isOk)
            {
                throw new PickyException(new PickyError(result.Err));
            }
            long retVal = result.Ok;
            return retVal;
        }
    }

    public byte GetMonth()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("UtcDate");
            }
            byte retVal = Raw.UtcDate.GetMonth(_inner);
            return retVal;
        }
    }

    public byte GetDay()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("UtcDate");
            }
            byte retVal = Raw.UtcDate.GetDay(_inner);
            return retVal;
        }
    }

    public byte GetHour()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("UtcDate");
            }
            byte retVal = Raw.UtcDate.GetHour(_inner);
            return retVal;
        }
    }

    public byte GetMinute()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("UtcDate");
            }
            byte retVal = Raw.UtcDate.GetMinute(_inner);
            return retVal;
        }
    }

    public byte GetSecond()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("UtcDate");
            }
            byte retVal = Raw.UtcDate.GetSecond(_inner);
            return retVal;
        }
    }

    public ushort GetYear()
    {
        unsafe
        {
            if (_inner == null)
            {
                throw new ObjectDisposedException("UtcDate");
            }
            ushort retVal = Raw.UtcDate.GetYear(_inner);
            return retVal;
        }
    }

    /// <summary>
    /// Returns the underlying raw handle.
    /// </summary>
    public unsafe Raw.UtcDate* AsFFI()
    {
        return _inner;
    }

    /// <summary>
    /// Destroys the underlying object immediately.
    /// </summary>
    public void Dispose()
    {
        unsafe
        {
            if (_inner == null)
            {
                return;
            }

            Raw.UtcDate.Destroy(_inner);
            _inner = null;

            GC.SuppressFinalize(this);
        }
    }

    ~UtcDate()
    {
        Dispose();
    }
}