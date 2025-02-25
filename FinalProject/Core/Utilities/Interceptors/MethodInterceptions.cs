﻿using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute, IInterceptor
    {
       
            protected virtual void OnBefore(IInvocation invocation) { }
            protected virtual void OnAfter(IInvocation invocation) { }
            protected virtual void OnException(IInvocation invocation, System.Exception e) { }
            protected virtual void OnSuccess(IInvocation invocation) { }
            public virtual void Intercept(IInvocation invocation)
            {
                var isSuccess = true;
                OnBefore(invocation);
                try
                {
                    invocation.Proceed();
                }
                catch (Exception e)
                {
                    isSuccess = false;
                    OnException(invocation, e);
                    throw;
                }
                finally
                {
                    if (isSuccess)
                    {
                        OnSuccess(invocation);
                    }
                }
                OnAfter(invocation);
            }
        }
    }

